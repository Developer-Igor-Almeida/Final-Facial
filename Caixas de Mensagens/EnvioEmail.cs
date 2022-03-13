using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Facial.Caixas_de_Mensagens
{
    public partial class EnvioEmail : Form
    {
        public EnvioEmail()
        {
            InitializeComponent();
        }

        private void btnFecharformEmail_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
