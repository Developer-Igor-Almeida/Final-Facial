using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Facial
{
    public partial class EnviarSMS : Form
    {
        public EnviarSMS()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void EnviarModem()
        {
            using (var port = new System.IO.Ports.SerialPort())
            {
                port.PortName = "COM1";
                port.Open();
                port.DtrEnable = true;
                port.RtsEnable = true;
                port.Write("AT\r"); // iniciando a comunicação
                port.Write("AT+CMGF=1\r"); // setando a comunicação para o modo texto
                port.Write(string.Format("AT+CMGS=\"{0}\"\r", txtSMS.Text)); // setando o número do destinatário
                port.Write(txtMensagemSMS.Text + char.ConvertFromUtf32(26)); // enviando a mensagem
            }
        }
        private void btnEnviarSms_Click(object sender, EventArgs e)
        {
            EnviarModem();
        }
    }
}
