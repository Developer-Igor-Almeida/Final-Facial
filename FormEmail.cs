using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Final_Facial.Caixas_de_Mensagens;

namespace Final_Facial
{
    public partial class FormEmail : Form
    {
        EnvioEmail evn = new EnvioEmail();
        public FormEmail()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EmailEnviar();
        }

        private void EmailEnviar()
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    using (MailMessage email = new MailMessage())
                    {
                        smtp.Host = "smtp.gmail.com";
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new System.Net.NetworkCredential
                        ("sistemafacial159@gmail.com", "321321sd");
                        smtp.Port = 587;
                        smtp.EnableSsl = true;

                        //Email 
                        email.From = new MailAddress(txtRemetente.Text);
                        email.To.Add(txtEnviar.Text);

                        email.Subject = txtAssunto.Text;
                        email.IsBodyHtml = false;
                        email.Body = txtMensagem.Text;


                        smtp.Send(email);

                    }

                }
                evn.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " +ex.Message);
            }


        }
        private void btnAbrirSMS_Click(object sender, EventArgs e)
        {
            EnviarSMS env = new EnviarSMS();
            env.Show();
        }
    }
}
