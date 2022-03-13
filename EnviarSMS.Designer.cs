namespace Final_Facial
{
    partial class EnviarSMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarSMS));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSMS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensagemSMS = new System.Windows.Forms.TextBox();
            this.btnEnviarSms = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMetodo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Haettenschweiler", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(234, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enviar SMS";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enviar Para";
            // 
            // txtSMS
            // 
            this.txtSMS.Location = new System.Drawing.Point(136, 88);
            this.txtSMS.Name = "txtSMS";
            this.txtSMS.Size = new System.Drawing.Size(210, 23);
            this.txtSMS.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mensagem";
            // 
            // txtMensagemSMS
            // 
            this.txtMensagemSMS.Location = new System.Drawing.Point(44, 189);
            this.txtMensagemSMS.Multiline = true;
            this.txtMensagemSMS.Name = "txtMensagemSMS";
            this.txtMensagemSMS.Size = new System.Drawing.Size(474, 196);
            this.txtMensagemSMS.TabIndex = 17;
            // 
            // btnEnviarSms
            // 
            this.btnEnviarSms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviarSms.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEnviarSms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarSms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarSms.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviarSms.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEnviarSms.Location = new System.Drawing.Point(412, 391);
            this.btnEnviarSms.Name = "btnEnviarSms";
            this.btnEnviarSms.Size = new System.Drawing.Size(109, 38);
            this.btnEnviarSms.TabIndex = 19;
            this.btnEnviarSms.Text = "Enviar";
            this.btnEnviarSms.UseVisualStyleBackColor = false;
            this.btnEnviarSms.Click += new System.EventHandler(this.btnEnviarSms_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(559, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 32);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 20;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 38);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Metodos";
            // 
            // cbMetodo
            // 
            this.cbMetodo.FormattingEnabled = true;
            this.cbMetodo.Items.AddRange(new object[] {
            "Modem",
            "Twilio",
            "Ipipi",
            "ViaNett",
            "LocaSMS"});
            this.cbMetodo.Location = new System.Drawing.Point(136, 124);
            this.cbMetodo.Name = "cbMetodo";
            this.cbMetodo.Size = new System.Drawing.Size(210, 23);
            this.cbMetodo.TabIndex = 23;
            // 
            // EnviarSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 447);
            this.Controls.Add(this.cbMetodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnviarSms);
            this.Controls.Add(this.txtMensagemSMS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSMS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnviarSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnviarSMS";
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSMS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMensagemSMS;
        private System.Windows.Forms.Button btnEnviarSms;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMetodo;
    }
}