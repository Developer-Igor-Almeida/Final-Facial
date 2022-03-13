using Final_Facial.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Final_Facial.Apresentação
{
    public partial class FormCadastrarLogin : Form
    {
        public FormCadastrarLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCadastrarLogin_Click(object sender, EventArgs e)
        {
            Controle cr = new Controle();
            cr.cadastrar(txblogin.Text, txbsenha.Text, txbconfirmasenha.Text);

            string mensagem = cr.cadastrar(txblogin.Text, txbsenha.Text, txbconfirmasenha.Text);
            if (cr.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show(cr.mensagem);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbnome.Clear();
            txblogin.Clear();
            txbsenha.Clear();
            txbconfirmasenha.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
       
            Close();
        }

        private void barratitulocadastro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void barratitulocadastro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
