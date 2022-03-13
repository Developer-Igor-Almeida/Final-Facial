//Bibliotecas Utilizadas##
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;
using OpenTK;
using ZedGraph;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Data.SqlClient;
using Final_Facial.Caixas_de_Mensagens;
//##

//Formulario em C#, Cadastrar 
namespace Final_Facial
{
    public partial class Cadastrar : Form
    {
        Form2 fr2 = new Form2();
        ErroBanco er = new ErroBanco();

        SqlConnection sqlcon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BancoFacial;Data Source=DESKTOP-97ALHNI";
        private string strSql = string.Empty;
        public Cadastrar()
        {
            InitializeComponent();
        }

        private FilterInfoCollection f;
        private VideoCaptureDevice c;

        #region Botões Funcionais
        private void btnAbrirCamera_Click(object sender, EventArgs e)
        {
            c = new VideoCaptureDevice(f[comboBox1.SelectedIndex].MonikerString);
            c.NewFrame += new NewFrameEventHandler(c_NewFrame);
            c.Start();
        }

        void c_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bm = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bm;

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
             
            strSql = "insert into CadastrarAlguem (Nome,CPF,Data_De_Nascimento,DDD,Telefone,Profissão,Email,Grupo_de_Acesso) values(@Nome,@CPF,@Data_De_Nascimento,@DDD,@Telefone,@Profissão,@Email,@Grupo_de_Acesso)";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = TextNome.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = mtextCPF.Text;
            comando.Parameters.Add("@Data_De_Nascimento", SqlDbType.VarChar).Value = mTextDT.Text;
            comando.Parameters.Add("@DDD", SqlDbType.VarChar).Value = mTextDDD.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = mTextTelefone.Text;
            comando.Parameters.Add("@Profissão", SqlDbType.VarChar).Value = TextProf.Text;
            comando.Parameters.Add("@Grupo_de_Acesso", SqlDbType.VarChar).Value = comboBox2.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = mTextEmail.Text;

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                fr2.Show();
            
            }
            catch (Exception ex)
            {
                er.Show();
                
            }
            finally
            {
                sqlcon.Close();
            }
            TextNome.Clear();
            mtextCPF.Clear();
            mTextDT.Clear();
            mTextDDD.Clear();
            mTextTelefone.Clear();
            mTextEmail.Clear();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Botão resposavel pela impressão do relatorio
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if(printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }
        #endregion

        #region Funcionalidade Impressão
        //Responsavel por Imprimir um relatorio do cadastrado
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Dados de Cadastro", TextNome.Font, Brushes.Black, 370, 50);
            e.Graphics.DrawString("Nome:  " + TextNome.Text, TextNome.Font, Brushes.Black, 230, 100);
            e.Graphics.DrawString("CPF:  " + mtextCPF.Text, TextNome.Font, Brushes.Black, 230, 130);
            e.Graphics.DrawString("Data de Nascimento:  " + mTextDT.Text, mTextDT.Font, Brushes.Black, 230, 160);
            e.Graphics.DrawString("DDD: " + mTextDDD.Text, mTextDDD.Font, Brushes.Black, 230, 190);
            e.Graphics.DrawString("  " + mTextTelefone.Text, mTextTelefone.Font, Brushes.Black, 294, 190);
            e.Graphics.DrawString("Profissão:  " + TextProf.Text, TextProf.Font, Brushes.Black, 230, 220);
            e.Graphics.DrawString("Email:  " + mTextEmail.Text, mTextEmail.Font, Brushes.Black, 230, 245);
            e.Graphics.DrawString("Grupo de Acesso:  " + comboBox2.Text, comboBox2.Font, Brushes.Black, 230, 270);
        }
        #endregion

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            f = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in f)
            {
                comboBox1.Items.Add(VideoCaptureDevice);
            }
        }
        private void btnFoto_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\Users\HOME\source\repos\Final Facial\Fotos Inseridas";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
                MessageBox.Show("A foto foi salvada com sucesso");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c.IsRunning)
            {
                c.SignalToStop();
            }
        }
    }
}
