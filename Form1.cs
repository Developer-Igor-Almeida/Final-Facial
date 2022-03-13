//Bibliotecas Usadas
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//##
namespace Final_Facial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Botões Formulario
        //Comando para fechar o formulario cadastro
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Comando para Maximizar 
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        //Comando para Restaurar a Aplicação
        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        //Comando para Minimzar a Aplicação  
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region DLL de importação
        //Importação de DLL é responsavel para manipulação de janelas, mensagens e comunicação

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //##
        //Resposanvel por fechar a aplicação
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Resposanvel Pela tela de login
        private void AbrirFormCadastrar(object formCadastrar)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form c = formCadastrar as Form;
            c.TopLevel = false;
            c.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(c);
            this.panelContenedor.Tag = c;
            c.Show();
        }

        private void AbrirFormBuscar(object formbuscar)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
                Form b = formbuscar as Form;
                b.TopLevel = false;
                b.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(b);
                this.panelContenedor.Tag = b;
                b.Show();
            }
        }

        private void AbrirFormEmail(object formemail)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
                Form e = formemail as Form;
                e.TopLevel = false;
                e.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(e);
                this.panelContenedor.Tag = e;
                e.Show();
            }
        }
        private void btnCadastrarForm_Click(object sender, EventArgs e)
        {
            AbrirFormCadastrar(new Cadastrar());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.ShowDialog();

        }

        private void BuscarForm_Click(object sender, EventArgs e)
        {
            AbrirFormBuscar(new FormBuscar());
           
        }

        private void btnAbrirEmail_Click(object sender, EventArgs e)
        {
            AbrirFormEmail(new FormEmail());
        }

    }
}