//Bibiliotecas Utilizadas
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using Final_Facial.Apresentação;
using Final_Facial.Modelo;

namespace Final_Facial
{
    public partial class LoginForm : Form
    {
        public static bool Cancelar;

        //Importação de DLL é responsavel para manipulação de janelas, mensagens e comunicação. 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public LoginForm()
        {
            InitializeComponent();
        }
        //Foi criado uma propriedade cujo tem a integração da classe CadastrarUsuario.
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtUsuario.Text, txtSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Login ou senha estão Incorretos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
        //Foi inserido um botão cancelar na aplicação de login, ela é acionado com uma propriedade Estatica chamada Cancelar que está na Raiz da classe.
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Cancelar = true;
            Application.Exit();
        }
        //Responsavel por fazer a movimentação do formulario segurando o click 
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Responsavel por chamar o formulario de splash
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            SplashForm SP = new SplashForm();
            SP.Show();
        }

        private void btnCadastrarse_Click(object sender, EventArgs e)
        {
            FormCadastrarLogin cad = new FormCadastrarLogin();
            cad.Show();

        }
    }
}
