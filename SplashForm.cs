//Bibliotecas Utilizadas
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

namespace Final_Facial
{ 
    public partial class SplashForm : Form
    {
        //Tela de Carregamento inicial
        public SplashForm()
        {
            InitializeComponent();
        }

        
        private void SplashForm_Shown(object sender, EventArgs e)
        {
            this.Refresh();

            for (int i = 1; i < 101; i++)
            {
                //A barra de progresso vai ser inicializada a partir do FOR
                progressBar1.Value = i;
                Thread.Sleep(40);
            }
            progressBar1.Value = 99;
            Thread.Sleep(2000);

            this.Close();
        }
    }
}
