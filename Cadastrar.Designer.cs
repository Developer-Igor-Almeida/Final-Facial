
namespace Final_Facial
{
    partial class Cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirCamera = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mtextCPF = new System.Windows.Forms.MaskedTextBox();
            this.mTextDT = new System.Windows.Forms.MaskedTextBox();
            this.mTextTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mTextDDD = new System.Windows.Forms.MaskedTextBox();
            this.mTextEmail = new System.Windows.Forms.MaskedTextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.TextProf = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnSalvarFoto = new System.Windows.Forms.Button();
            this.btnFCamera = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(457, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera";
            // 
            // btnAbrirCamera
            // 
            this.btnAbrirCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirCamera.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAbrirCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCamera.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirCamera.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAbrirCamera.Location = new System.Drawing.Point(920, 101);
            this.btnAbrirCamera.Name = "btnAbrirCamera";
            this.btnAbrirCamera.Size = new System.Drawing.Size(134, 51);
            this.btnAbrirCamera.TabIndex = 4;
            this.btnAbrirCamera.Text = "Abrir Camera";
            this.btnAbrirCamera.UseVisualStyleBackColor = false;
            this.btnAbrirCamera.Click += new System.EventHandler(this.btnAbrirCamera_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(457, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 395);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TextNome
            // 
            this.TextNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextNome.Location = new System.Drawing.Point(19, 114);
            this.TextNome.Multiline = true;
            this.TextNome.Name = "TextNome";
            this.TextNome.Size = new System.Drawing.Size(290, 29);
            this.TextNome.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome Completo";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Haettenschweiler", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(457, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cadastro";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalvar.Location = new System.Drawing.Point(162, 21);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(134, 51);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "✔ Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(22, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 51);
            this.button4.TabIndex = 15;
            this.button4.Text = " ↩ Voltar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "CPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(17, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Data Nascimento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(17, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "DDD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(17, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Profissão";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(67, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Telefone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(17, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 21);
            this.label11.TabIndex = 26;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(17, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 21);
            this.label12.TabIndex = 28;
            this.label12.Text = "Grupo de Acesso";
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox10.Location = new System.Drawing.Point(19, 503);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(407, 67);
            this.textBox10.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(17, 475);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 21);
            this.label13.TabIndex = 30;
            this.label13.Text = "Observações";
            // 
            // mtextCPF
            // 
            this.mtextCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtextCPF.Location = new System.Drawing.Point(19, 170);
            this.mtextCPF.Mask = "000.000.000-00";
            this.mtextCPF.Name = "mtextCPF";
            this.mtextCPF.Size = new System.Drawing.Size(290, 29);
            this.mtextCPF.TabIndex = 31;
            this.mtextCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // mTextDT
            // 
            this.mTextDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mTextDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mTextDT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mTextDT.HideSelection = false;
            this.mTextDT.Location = new System.Drawing.Point(19, 225);
            this.mTextDT.Mask = "00/00/0000";
            this.mTextDT.Name = "mTextDT";
            this.mTextDT.Size = new System.Drawing.Size(290, 29);
            this.mTextDT.TabIndex = 32;
            this.mTextDT.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mTextDT.ValidatingType = typeof(System.DateTime);
            // 
            // mTextTelefone
            // 
            this.mTextTelefone.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mTextTelefone.Location = new System.Drawing.Point(67, 281);
            this.mTextTelefone.Mask = "00000-9999";
            this.mTextTelefone.Name = "mTextTelefone";
            this.mTextTelefone.Size = new System.Drawing.Size(242, 29);
            this.mTextTelefone.TabIndex = 33;
            this.mTextTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // mTextDDD
            // 
            this.mTextDDD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mTextDDD.Location = new System.Drawing.Point(17, 281);
            this.mTextDDD.Mask = "(00)";
            this.mTextDDD.Name = "mTextDDD";
            this.mTextDDD.Size = new System.Drawing.Size(35, 29);
            this.mTextDDD.TabIndex = 34;
            this.mTextDDD.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mTextDDD.ValidatingType = typeof(System.DateTime);
            // 
            // mTextEmail
            // 
            this.mTextEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mTextEmail.Location = new System.Drawing.Point(17, 387);
            this.mTextEmail.Name = "mTextEmail";
            this.mTextEmail.Size = new System.Drawing.Size(290, 29);
            this.mTextEmail.TabIndex = 35;
            this.mTextEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.ForestGreen;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImprimir.Location = new System.Drawing.Point(920, 313);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(134, 51);
            this.btnImprimir.TabIndex = 38;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // TextProf
            // 
            this.TextProf.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrador",
            "Administrador público",
            "Agropecuarista",
            "Contabilista",
            "Economista",
            "Especialista em comércio exterior",
            "Chef",
            "Gerente comercial",
            "Gestor de recursos humanos",
            "Gestor de turismo",
            "Gestor público",
            "Hoteleiro",
            "Piloto de avião",
            "Turismólogo",
            "Animador",
            "Arquiteto",
            "Artista plástico",
            "Ator",
            "Dançarino",
            "Designer",
            "Designer de games",
            "Designer de interiores",
            "Designer de moda",
            "Fotógrafo",
            "Historiador da arte",
            "Músico",
            "Produtor cênico",
            "Produtor fonográfico",
            "Agrônomo",
            "Bioquímico",
            "Biotecnólogo",
            "Ecologista",
            "Geofísico",
            "Geólogo",
            "Gestor ambiental",
            "Veterinário",
            "Meteorologista",
            "Oceanógrafo",
            "Zootecnólogo",
            "Analista e desenvolvedor de sistemas",
            "Astrônomo",
            "Cientista da computação",
            "Estatístico",
            "Físico",
            "Gestor da tecnologia da informação",
            "Matemático",
            "Nanotecnólogo",
            "Químico",
            "Advogado",
            "Arqueólogo",
            "Cooperativista",
            "Filósofo",
            "Geógrafo",
            "Historiador",
            "Linguista",
            "Museologista",
            "Pedagogo",
            "Professor",
            "Psicopedagogo",
            "Relações internacionais",
            "Sociólogo",
            "Teólogo",
            "Tradutor e intérprete",
            "Arquivologista",
            "Biblioteconomista",
            "Educomunicador",
            "Jornalista",
            "Produtor audiovisual",
            "Produtor cultural",
            "Produtor editorial",
            "Produtor multimídia",
            "Produtor publicitário",
            "Publicitário",
            "Radialista",
            "Relações públicas",
            "Secretária",
            "Secretária executiva",
            "Agricultor",
            "Construtor civil",
            "Construtor naval",
            "Engenheiro acústico",
            "Engenheiro aeronáutico",
            "Engenheiro agrícola",
            "Engenheiro ambiental e sanitário",
            "Engenheiro biomédico",
            "Engenheiro civil",
            "Engenheiro da computação",
            "Engenheiro de alimentos",
            "Engenheiro de biossistemas",
            "Engenheiro de controle e automação",
            "Engenheiro de energia",
            "Engenheiro de inovação",
            "Engenheiro de materiais",
            "Engenheiro de minas",
            "Engenheiro de pesca",
            "Engenheiro de petróleo",
            "Engenheiro de produção",
            "Engenheiro de segurança do trabalho",
            "Engenheiro de sistemas",
            "Engenheiro de software",
            "Engenheiro de telecomunicações",
            "Engenheiro de transporte e mobilidade",
            "Engenheiro elétrico",
            "Engenheiro eletrônico",
            "Engenheiro físico",
            "Engenheiro florestal",
            "Engenheiro hídrico",
            "Engenheiro mecânico",
            "Engenheiro mecatrônico",
            "Engenheiro naval",
            "Engenheiro químico",
            "Gestor da qualidade",
            "Minerador",
            "Silvicultor",
            "Biomédico",
            "Dentista",
            "Educador físico",
            "Enfermeiro",
            "Esteticista",
            "Farmacêutico",
            "Fisioterapeuta",
            "Fonoaudiólogo",
            "Gerontólogo",
            "Gestor em saúde",
            "Gestor hospitalar",
            "Médico",
            "Musicoterapeuta",
            "Nutricionista",
            "Psicólogo",
            "Radiologista",
            "Terapeuta ocupacional"});
            this.TextProf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextProf.FormattingEnabled = true;
            this.TextProf.Items.AddRange(new object[] {
            "Administrador",
            "Administrador público",
            "Agropecuarista",
            "Contabilista",
            "Economista",
            "Especialista em comércio exterior",
            "Chef",
            "Gerente comercial",
            "Gestor de recursos humanos",
            "Gestor de turismo",
            "Gestor público",
            "Hoteleiro",
            "Piloto de avião",
            "Turismólogo",
            "Animador",
            "Arquiteto",
            "Artista plástico",
            "Ator",
            "Dançarino",
            "Designer",
            "Designer de games",
            "Designer de interiores",
            "Designer de moda",
            "Fotógrafo",
            "Historiador da arte",
            "Músico",
            "Produtor cênico",
            "Produtor fonográfico",
            "Agrônomo",
            "Bioquímico",
            "Biotecnólogo",
            "Ecologista",
            "Geofísico",
            "Geólogo",
            "Gestor ambiental",
            "Veterinário",
            "Meteorologista",
            "Oceanógrafo",
            "Zootecnólogo",
            "Analista e desenvolvedor de sistemas",
            "Astrônomo",
            "Cientista da computação",
            "Estatístico",
            "Físico",
            "Gestor da tecnologia da informação",
            "Matemático",
            "Nanotecnólogo",
            "Químico",
            "Advogado",
            "Arqueólogo",
            "Cooperativista",
            "Filósofo",
            "Geógrafo",
            "Historiador",
            "Linguista",
            "Museologista",
            "Pedagogo",
            "Professor",
            "Psicopedagogo",
            "Relações internacionais",
            "Sociólogo",
            "Teólogo",
            "Tradutor e intérprete",
            "Arquivologista",
            "Biblioteconomista",
            "Educomunicador",
            "Jornalista",
            "Produtor audiovisual",
            "Produtor cultural",
            "Produtor editorial",
            "Produtor multimídia",
            "Produtor publicitário",
            "Publicitário",
            "Radialista",
            "Relações públicas",
            "Secretária",
            "Secretária executiva",
            "Agricultor",
            "Construtor civil",
            "Construtor naval",
            "Engenheiro acústico",
            "Engenheiro aeronáutico",
            "Engenheiro agrícola",
            "Engenheiro ambiental e sanitário",
            "Engenheiro biomédico",
            "Engenheiro civil",
            "Engenheiro da computação",
            "Engenheiro de alimentos",
            "Engenheiro de biossistemas",
            "Engenheiro de controle e automação",
            "Engenheiro de energia",
            "Engenheiro de inovação",
            "Engenheiro de materiais",
            "Engenheiro de minas",
            "Engenheiro de pesca",
            "Engenheiro de petróleo",
            "Engenheiro de produção",
            "Engenheiro de segurança do trabalho",
            "Engenheiro de sistemas",
            "Engenheiro de software",
            "Engenheiro de telecomunicações",
            "Engenheiro de transporte e mobilidade",
            "Engenheiro elétrico",
            "Engenheiro eletrônico",
            "Engenheiro físico",
            "Engenheiro florestal",
            "Engenheiro hídrico",
            "Engenheiro mecânico",
            "Engenheiro mecatrônico",
            "Engenheiro naval",
            "Engenheiro químico",
            "Gestor da qualidade",
            "Minerador",
            "Silvicultor",
            "Biomédico",
            "Dentista",
            "Educador físico",
            "Enfermeiro",
            "Esteticista",
            "Farmacêutico",
            "Fisioterapeuta",
            "Fonoaudiólogo",
            "Gerontólogo",
            "Gestor em saúde",
            "Gestor hospitalar",
            "Médico",
            "Musicoterapeuta",
            "Nutricionista",
            "Psicólogo",
            "Radiologista",
            "Terapeuta ocupacional",
            ""});
            this.TextProf.Location = new System.Drawing.Point(17, 337);
            this.TextProf.Name = "TextProf";
            this.TextProf.Size = new System.Drawing.Size(292, 29);
            this.TextProf.TabIndex = 39;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Acesso Nivel 1 (Todos podem ter Acesso)",
            "Acesso Nivel 2 ( Diretores de Divisões)",
            "Acesso Nivel 3 (Ministro do Meio Ambiente)"});
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Acesso Nivel 1 (Todos podem ter Acesso)",
            "Acesso Nivel 2 ( Diretores de Divisões)",
            "Acesso Nivel 3 (Ministro do Meio Ambiente)"});
            this.comboBox2.Location = new System.Drawing.Point(17, 443);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(292, 29);
            this.comboBox2.TabIndex = 40;
            // 
            // btnSalvarFoto
            // 
            this.btnSalvarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarFoto.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalvarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFoto.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarFoto.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalvarFoto.Location = new System.Drawing.Point(920, 170);
            this.btnSalvarFoto.Name = "btnSalvarFoto";
            this.btnSalvarFoto.Size = new System.Drawing.Size(134, 51);
            this.btnSalvarFoto.TabIndex = 41;
            this.btnSalvarFoto.Text = "Capturar Foto";
            this.btnSalvarFoto.UseVisualStyleBackColor = false;
            this.btnSalvarFoto.Click += new System.EventHandler(this.btnFoto_Click_1);
            // 
            // btnFCamera
            // 
            this.btnFCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFCamera.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFCamera.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFCamera.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFCamera.Location = new System.Drawing.Point(920, 241);
            this.btnFCamera.Name = "btnFCamera";
            this.btnFCamera.Size = new System.Drawing.Size(134, 51);
            this.btnFCamera.TabIndex = 42;
            this.btnFCamera.Text = "Fechar Camera";
            this.btnFCamera.UseVisualStyleBackColor = false;
            this.btnFCamera.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(457, 502);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(302, 23);
            this.comboBox1.TabIndex = 43;
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1066, 582);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnFCamera);
            this.Controls.Add(this.btnSalvarFoto);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.TextProf);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.mTextEmail);
            this.Controls.Add(this.mTextDDD);
            this.Controls.Add(this.mTextTelefone);
            this.Controls.Add(this.mTextDT);
            this.Controls.Add(this.mtextCPF);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextNome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAbrirCamera);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastrar";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrirCamera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mtextCPF;
        private System.Windows.Forms.MaskedTextBox mTextDT;
        private System.Windows.Forms.MaskedTextBox mTextTelefone;
        private System.Windows.Forms.MaskedTextBox mTextDDD;
        private System.Windows.Forms.MaskedTextBox mTextEmail;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox TextProf;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnSalvarFoto;
        private System.Windows.Forms.Button btnFCamera;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}