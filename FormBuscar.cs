using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace Final_Facial
{
    public partial class FormBuscar : Form
    {
        public FormBuscar()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BancoFacial;Data Source=DESKTOP-97ALHNI";
        private string strSql = string.Empty;
        private void btnVerificação_Click(object sender, EventArgs e)
        {
            strSql = "select*from CadastrarAlguem where Nome=@Pesquisar";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@Pesquisar", SqlDbType.VarChar).Value = Pesquisar.Text;

            try
            {
                if(Pesquisar.Text == string.Empty)
                {
                    MessageBox.Show("Você Não Digitou Um Nome");
                }

                sqlcon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if(dr.HasRows == false)
                {
                    throw new Exception("ESTE NOME NÃO ESTA CADASTRADO");
                }
                dr.Read();

                txtnome.Text = Convert.ToString(dr["Nome"]);
                txtcpf.Text = Convert.ToString(dr["CPF"]);
                txtdt.Text = Convert.ToString(dr["Data_De_Nascimento"]);
                txtddd.Text = Convert.ToString(dr["DDD"]);
                txttelefone.Text = Convert.ToString(dr["Telefone"]);
                txtprof.Text = Convert.ToString(dr["Profissão"]);
                txtEmail.Text = Convert.ToString(dr["Email"]);
                txtgp.Text = Convert.ToString(dr["Grupo_de_Acesso"]);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            Pesquisar.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            strSql = "update CadastrarAlguem set Nome=@Nome,CPF=@CPF,Data_De_Nascimento=@Data_De_Nascimento,DDD=@DDD,Telefone=@Telefone,Profissão=@Profissão,Email=@Email,Grupo_de_Acesso=@Grupo_de_Acesso";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtnome.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txtcpf.Text;
            comando.Parameters.Add("@Data_De_Nascimento", SqlDbType.VarChar).Value = txtdt.Text;
            comando.Parameters.Add("@DDD", SqlDbType.VarChar).Value = txtddd.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txttelefone.Text;
            comando.Parameters.Add("@Profissão", SqlDbType.VarChar).Value = txtprof.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@Grupo_de_Acesso", SqlDbType.VarChar).Value = txtgp.Text;

            try
            {
                sqlcon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro Alterado Com Sucesso");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            txtnome.Clear();
            txtdt.Clear();
            txtcpf.Clear();
            txtddd.Clear();
            txttelefone.Clear();
            txtEmail.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtdt.Clear();
            txtcpf.Clear();
            txtddd.Clear();
            txttelefone.Clear();
            txtEmail.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            strSql = "delete from CadastrarAlguem where Nome=@Nome";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtnome.Text;

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Exclusão de cadastro feita com sucesso");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }
            txtnome.Clear();
            txtdt.Clear();
            txtcpf.Clear();
            txtddd.Clear();
            txttelefone.Clear();
            txtEmail.Clear();
        }
    }
}
