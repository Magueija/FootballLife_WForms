namespace FootballLife_WF
{
    partial class AdicionarUtilizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarUtilizador));
            this.lbl_Funcao = new System.Windows.Forms.Label();
            this.cb_Funcao = new System.Windows.Forms.ComboBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Telemovel = new System.Windows.Forms.Label();
            this.lbl_Morada = new System.Windows.Forms.Label();
            this.lbl_Utilizador = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Confirmar = new System.Windows.Forms.Label();
            this.lbl_ConfPassword = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Telemovel = new System.Windows.Forms.TextBox();
            this.tb_Morada = new System.Windows.Forms.TextBox();
            this.lbl_Escalao = new System.Windows.Forms.Label();
            this.rb_Seniores = new System.Windows.Forms.RadioButton();
            this.rb_Juniores = new System.Windows.Forms.RadioButton();
            this.rb_Juvenis = new System.Windows.Forms.RadioButton();
            this.rb_Benjamins = new System.Windows.Forms.RadioButton();
            this.rb_Infantis = new System.Windows.Forms.RadioButton();
            this.rb_Traquinas = new System.Windows.Forms.RadioButton();
            this.rb_Iniciados = new System.Windows.Forms.RadioButton();
            this.rb_Petizes = new System.Windows.Forms.RadioButton();
            this.tb_Utilizador = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_ConfPassword = new System.Windows.Forms.TextBox();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.panel_Escalao = new System.Windows.Forms.Panel();
            this.tb_CodPostal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Localidade = new System.Windows.Forms.TextBox();
            this.ckb_VerPass = new System.Windows.Forms.CheckBox();
            this.lbl_LoginError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ObrigatorioEscalao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_EscalaoATreinar = new System.Windows.Forms.Label();
            this.panel_Escalao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Funcao
            // 
            this.lbl_Funcao.AutoSize = true;
            this.lbl_Funcao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Funcao.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Funcao.Location = new System.Drawing.Point(30, 82);
            this.lbl_Funcao.Name = "lbl_Funcao";
            this.lbl_Funcao.Size = new System.Drawing.Size(52, 16);
            this.lbl_Funcao.TabIndex = 0;
            this.lbl_Funcao.Text = "Função:";
            // 
            // cb_Funcao
            // 
            this.cb_Funcao.BackColor = System.Drawing.Color.White;
            this.cb_Funcao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Funcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Funcao.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cb_Funcao.FormattingEnabled = true;
            this.cb_Funcao.Items.AddRange(new object[] {
            "Administrador",
            "Treinador",
            "Atleta",
            "Sócio"});
            this.cb_Funcao.Location = new System.Drawing.Point(99, 79);
            this.cb_Funcao.Name = "cb_Funcao";
            this.cb_Funcao.Size = new System.Drawing.Size(185, 24);
            this.cb_Funcao.TabIndex = 1;
            this.cb_Funcao.SelectedIndexChanged += new System.EventHandler(this.Cb_Funcao_SelectedIndexChanged);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(135, 20);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(201, 21);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Adicionar Utilizador";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nome.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Nome.Location = new System.Drawing.Point(34, 149);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(46, 16);
            this.lbl_Nome.TabIndex = 3;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Email.Location = new System.Drawing.Point(35, 180);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(43, 16);
            this.lbl_Email.TabIndex = 4;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Telemovel
            // 
            this.lbl_Telemovel.AutoSize = true;
            this.lbl_Telemovel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Telemovel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Telemovel.Location = new System.Drawing.Point(23, 208);
            this.lbl_Telemovel.Name = "lbl_Telemovel";
            this.lbl_Telemovel.Size = new System.Drawing.Size(69, 16);
            this.lbl_Telemovel.TabIndex = 5;
            this.lbl_Telemovel.Text = "Telemóvel:";
            // 
            // lbl_Morada
            // 
            this.lbl_Morada.AutoSize = true;
            this.lbl_Morada.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Morada.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Morada.Location = new System.Drawing.Point(29, 236);
            this.lbl_Morada.Name = "lbl_Morada";
            this.lbl_Morada.Size = new System.Drawing.Size(58, 16);
            this.lbl_Morada.TabIndex = 6;
            this.lbl_Morada.Text = "Morada:";
            // 
            // lbl_Utilizador
            // 
            this.lbl_Utilizador.AutoSize = true;
            this.lbl_Utilizador.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Utilizador.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Utilizador.Location = new System.Drawing.Point(23, 445);
            this.lbl_Utilizador.Name = "lbl_Utilizador";
            this.lbl_Utilizador.Size = new System.Drawing.Size(68, 16);
            this.lbl_Utilizador.TabIndex = 7;
            this.lbl_Utilizador.Text = "Utilizador:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Password.Location = new System.Drawing.Point(24, 477);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(64, 16);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Confirmar
            // 
            this.lbl_Confirmar.AutoSize = true;
            this.lbl_Confirmar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Confirmar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Confirmar.Location = new System.Drawing.Point(22, 500);
            this.lbl_Confirmar.Name = "lbl_Confirmar";
            this.lbl_Confirmar.Size = new System.Drawing.Size(67, 16);
            this.lbl_Confirmar.TabIndex = 9;
            this.lbl_Confirmar.Text = "Confirmar";
            // 
            // lbl_ConfPassword
            // 
            this.lbl_ConfPassword.AutoSize = true;
            this.lbl_ConfPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ConfPassword.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_ConfPassword.Location = new System.Drawing.Point(24, 513);
            this.lbl_ConfPassword.Name = "lbl_ConfPassword";
            this.lbl_ConfPassword.Size = new System.Drawing.Size(64, 16);
            this.lbl_ConfPassword.TabIndex = 10;
            this.lbl_ConfPassword.Text = "Password:";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_Nome.Location = new System.Drawing.Point(99, 149);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(302, 22);
            this.tb_Nome.TabIndex = 11;
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_Email.Location = new System.Drawing.Point(99, 177);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(302, 22);
            this.tb_Email.TabIndex = 12;
            // 
            // tb_Telemovel
            // 
            this.tb_Telemovel.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_Telemovel.Location = new System.Drawing.Point(99, 205);
            this.tb_Telemovel.Name = "tb_Telemovel";
            this.tb_Telemovel.Size = new System.Drawing.Size(302, 22);
            this.tb_Telemovel.TabIndex = 13;
            // 
            // tb_Morada
            // 
            this.tb_Morada.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_Morada.Location = new System.Drawing.Point(99, 233);
            this.tb_Morada.Name = "tb_Morada";
            this.tb_Morada.Size = new System.Drawing.Size(302, 22);
            this.tb_Morada.TabIndex = 14;
            // 
            // lbl_Escalao
            // 
            this.lbl_Escalao.AutoSize = true;
            this.lbl_Escalao.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Escalao.Location = new System.Drawing.Point(3, 12);
            this.lbl_Escalao.Name = "lbl_Escalao";
            this.lbl_Escalao.Size = new System.Drawing.Size(53, 16);
            this.lbl_Escalao.TabIndex = 15;
            this.lbl_Escalao.Text = "Escalão:";
            // 
            // rb_Seniores
            // 
            this.rb_Seniores.AutoSize = true;
            this.rb_Seniores.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Seniores.Location = new System.Drawing.Point(6, 42);
            this.rb_Seniores.Name = "rb_Seniores";
            this.rb_Seniores.Size = new System.Drawing.Size(67, 19);
            this.rb_Seniores.TabIndex = 17;
            this.rb_Seniores.TabStop = true;
            this.rb_Seniores.Tag = "";
            this.rb_Seniores.Text = "Séniores";
            this.rb_Seniores.UseVisualStyleBackColor = true;
            // 
            // rb_Juniores
            // 
            this.rb_Juniores.AutoSize = true;
            this.rb_Juniores.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.rb_Juniores.Location = new System.Drawing.Point(6, 67);
            this.rb_Juniores.Name = "rb_Juniores";
            this.rb_Juniores.Size = new System.Drawing.Size(65, 19);
            this.rb_Juniores.TabIndex = 18;
            this.rb_Juniores.TabStop = true;
            this.rb_Juniores.Tag = "";
            this.rb_Juniores.Text = "Juniores";
            this.rb_Juniores.UseVisualStyleBackColor = true;
            // 
            // rb_Juvenis
            // 
            this.rb_Juvenis.AutoSize = true;
            this.rb_Juvenis.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.rb_Juvenis.Location = new System.Drawing.Point(79, 42);
            this.rb_Juvenis.Name = "rb_Juvenis";
            this.rb_Juvenis.Size = new System.Drawing.Size(60, 19);
            this.rb_Juvenis.TabIndex = 19;
            this.rb_Juvenis.TabStop = true;
            this.rb_Juvenis.Tag = "";
            this.rb_Juvenis.Text = "Juvenis";
            this.rb_Juvenis.UseVisualStyleBackColor = true;
            // 
            // rb_Benjamins
            // 
            this.rb_Benjamins.AutoSize = true;
            this.rb_Benjamins.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.rb_Benjamins.Location = new System.Drawing.Point(151, 67);
            this.rb_Benjamins.Name = "rb_Benjamins";
            this.rb_Benjamins.Size = new System.Drawing.Size(78, 19);
            this.rb_Benjamins.TabIndex = 20;
            this.rb_Benjamins.TabStop = true;
            this.rb_Benjamins.Tag = "";
            this.rb_Benjamins.Text = "Benjamins";
            this.rb_Benjamins.UseVisualStyleBackColor = true;
            // 
            // rb_Infantis
            // 
            this.rb_Infantis.AutoSize = true;
            this.rb_Infantis.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.rb_Infantis.Location = new System.Drawing.Point(151, 42);
            this.rb_Infantis.Name = "rb_Infantis";
            this.rb_Infantis.Size = new System.Drawing.Size(62, 19);
            this.rb_Infantis.TabIndex = 21;
            this.rb_Infantis.TabStop = true;
            this.rb_Infantis.Tag = "";
            this.rb_Infantis.Text = "Infantis";
            this.rb_Infantis.UseVisualStyleBackColor = true;
            // 
            // rb_Traquinas
            // 
            this.rb_Traquinas.AutoSize = true;
            this.rb_Traquinas.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.rb_Traquinas.Location = new System.Drawing.Point(219, 42);
            this.rb_Traquinas.Name = "rb_Traquinas";
            this.rb_Traquinas.Size = new System.Drawing.Size(77, 19);
            this.rb_Traquinas.TabIndex = 22;
            this.rb_Traquinas.TabStop = true;
            this.rb_Traquinas.Text = "Traquinas";
            this.rb_Traquinas.UseVisualStyleBackColor = true;
            // 
            // rb_Iniciados
            // 
            this.rb_Iniciados.AutoSize = true;
            this.rb_Iniciados.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.rb_Iniciados.Location = new System.Drawing.Point(77, 67);
            this.rb_Iniciados.Name = "rb_Iniciados";
            this.rb_Iniciados.Size = new System.Drawing.Size(68, 19);
            this.rb_Iniciados.TabIndex = 23;
            this.rb_Iniciados.TabStop = true;
            this.rb_Iniciados.Text = "Iniciados";
            this.rb_Iniciados.UseVisualStyleBackColor = true;
            // 
            // rb_Petizes
            // 
            this.rb_Petizes.AutoSize = true;
            this.rb_Petizes.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.rb_Petizes.Location = new System.Drawing.Point(235, 67);
            this.rb_Petizes.Name = "rb_Petizes";
            this.rb_Petizes.Size = new System.Drawing.Size(60, 19);
            this.rb_Petizes.TabIndex = 24;
            this.rb_Petizes.TabStop = true;
            this.rb_Petizes.Text = "Petizes";
            this.rb_Petizes.UseVisualStyleBackColor = true;
            // 
            // tb_Utilizador
            // 
            this.tb_Utilizador.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_Utilizador.Location = new System.Drawing.Point(99, 442);
            this.tb_Utilizador.Name = "tb_Utilizador";
            this.tb_Utilizador.Size = new System.Drawing.Size(302, 22);
            this.tb_Utilizador.TabIndex = 25;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_Password.Location = new System.Drawing.Point(99, 474);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(302, 22);
            this.tb_Password.TabIndex = 26;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // tb_ConfPassword
            // 
            this.tb_ConfPassword.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_ConfPassword.Location = new System.Drawing.Point(100, 504);
            this.tb_ConfPassword.Name = "tb_ConfPassword";
            this.tb_ConfPassword.Size = new System.Drawing.Size(301, 22);
            this.tb_ConfPassword.TabIndex = 27;
            this.tb_ConfPassword.UseSystemPasswordChar = true;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.BackColor = System.Drawing.Color.White;
            this.btn_Gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gravar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gravar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gravar.ForeColor = System.Drawing.Color.Black;
            this.btn_Gravar.Location = new System.Drawing.Point(349, 562);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(92, 34);
            this.btn_Gravar.TabIndex = 28;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = false;
            this.btn_Gravar.Click += new System.EventHandler(this.Btn_Gravar_Click);
            // 
            // panel_Escalao
            // 
            this.panel_Escalao.Controls.Add(this.rb_Infantis);
            this.panel_Escalao.Controls.Add(this.lbl_EscalaoATreinar);
            this.panel_Escalao.Controls.Add(this.lbl_Escalao);
            this.panel_Escalao.Controls.Add(this.rb_Seniores);
            this.panel_Escalao.Controls.Add(this.rb_Juniores);
            this.panel_Escalao.Controls.Add(this.rb_Petizes);
            this.panel_Escalao.Controls.Add(this.rb_Juvenis);
            this.panel_Escalao.Controls.Add(this.rb_Iniciados);
            this.panel_Escalao.Controls.Add(this.rb_Benjamins);
            this.panel_Escalao.Controls.Add(this.rb_Traquinas);
            this.panel_Escalao.Controls.Add(this.lbl_ObrigatorioEscalao);
            this.panel_Escalao.Location = new System.Drawing.Point(99, 316);
            this.panel_Escalao.Name = "panel_Escalao";
            this.panel_Escalao.Size = new System.Drawing.Size(302, 106);
            this.panel_Escalao.TabIndex = 29;
            // 
            // tb_CodPostal
            // 
            this.tb_CodPostal.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_CodPostal.Location = new System.Drawing.Point(123, 261);
            this.tb_CodPostal.Name = "tb_CodPostal";
            this.tb_CodPostal.Size = new System.Drawing.Size(88, 22);
            this.tb_CodPostal.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código-Postal: ";
            // 
            // tb_Localidade
            // 
            this.tb_Localidade.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_Localidade.Location = new System.Drawing.Point(217, 261);
            this.tb_Localidade.Name = "tb_Localidade";
            this.tb_Localidade.Size = new System.Drawing.Size(184, 22);
            this.tb_Localidade.TabIndex = 32;
            // 
            // ckb_VerPass
            // 
            this.ckb_VerPass.AutoSize = true;
            this.ckb_VerPass.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_VerPass.Location = new System.Drawing.Point(305, 532);
            this.ckb_VerPass.Name = "ckb_VerPass";
            this.ckb_VerPass.Size = new System.Drawing.Size(96, 18);
            this.ckb_VerPass.TabIndex = 33;
            this.ckb_VerPass.Text = "Ver Password";
            this.ckb_VerPass.UseVisualStyleBackColor = true;
            this.ckb_VerPass.CheckedChanged += new System.EventHandler(this.Ckb_VerPass_CheckedChanged);
            // 
            // lbl_LoginError
            // 
            this.lbl_LoginError.AutoSize = true;
            this.lbl_LoginError.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginError.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_LoginError.Location = new System.Drawing.Point(273, 131);
            this.lbl_LoginError.Name = "lbl_LoginError";
            this.lbl_LoginError.Size = new System.Drawing.Size(128, 15);
            this.lbl_LoginError.TabIndex = 34;
            this.lbl_LoginError.Text = "* Campos Obrigatórios!";
            this.lbl_LoginError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(386, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "*";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(386, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "*";
            this.label3.Visible = false;
            // 
            // lbl_ObrigatorioEscalao
            // 
            this.lbl_ObrigatorioEscalao.AutoSize = true;
            this.lbl_ObrigatorioEscalao.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ObrigatorioEscalao.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_ObrigatorioEscalao.Location = new System.Drawing.Point(0, 4);
            this.lbl_ObrigatorioEscalao.Name = "lbl_ObrigatorioEscalao";
            this.lbl_ObrigatorioEscalao.Size = new System.Drawing.Size(12, 15);
            this.lbl_ObrigatorioEscalao.TabIndex = 37;
            this.lbl_ObrigatorioEscalao.Text = "*";
            this.lbl_ObrigatorioEscalao.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(386, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "*";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(386, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "*";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(386, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "*";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(286, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "*";
            this.label8.Visible = false;
            // 
            // lbl_EscalaoATreinar
            // 
            this.lbl_EscalaoATreinar.AutoSize = true;
            this.lbl_EscalaoATreinar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_EscalaoATreinar.Location = new System.Drawing.Point(3, 12);
            this.lbl_EscalaoATreinar.Name = "lbl_EscalaoATreinar";
            this.lbl_EscalaoATreinar.Size = new System.Drawing.Size(109, 16);
            this.lbl_EscalaoATreinar.TabIndex = 16;
            this.lbl_EscalaoATreinar.Text = "Escalão a Treinar:";
            this.lbl_EscalaoATreinar.Visible = false;
            // 
            // AdicionarUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 606);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_LoginError);
            this.Controls.Add(this.ckb_VerPass);
            this.Controls.Add(this.tb_Localidade);
            this.Controls.Add(this.tb_CodPostal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Escalao);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.tb_ConfPassword);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Utilizador);
            this.Controls.Add(this.tb_Morada);
            this.Controls.Add(this.tb_Telemovel);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.lbl_ConfPassword);
            this.Controls.Add(this.lbl_Confirmar);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Utilizador);
            this.Controls.Add(this.lbl_Morada);
            this.Controls.Add(this.lbl_Telemovel);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.cb_Funcao);
            this.Controls.Add(this.lbl_Funcao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarUtilizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Utilizador";
            this.panel_Escalao.ResumeLayout(false);
            this.panel_Escalao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Funcao;
        private System.Windows.Forms.ComboBox cb_Funcao;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Telemovel;
        private System.Windows.Forms.Label lbl_Morada;
        private System.Windows.Forms.Label lbl_Utilizador;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Confirmar;
        private System.Windows.Forms.Label lbl_ConfPassword;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Telemovel;
        private System.Windows.Forms.TextBox tb_Morada;
        private System.Windows.Forms.Label lbl_Escalao;
        private System.Windows.Forms.RadioButton rb_Seniores;
        private System.Windows.Forms.RadioButton rb_Juniores;
        private System.Windows.Forms.RadioButton rb_Juvenis;
        private System.Windows.Forms.RadioButton rb_Benjamins;
        private System.Windows.Forms.RadioButton rb_Infantis;
        private System.Windows.Forms.RadioButton rb_Traquinas;
        private System.Windows.Forms.RadioButton rb_Iniciados;
        private System.Windows.Forms.RadioButton rb_Petizes;
        private System.Windows.Forms.TextBox tb_Utilizador;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_ConfPassword;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Panel panel_Escalao;
        private System.Windows.Forms.TextBox tb_CodPostal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Localidade;
        private System.Windows.Forms.CheckBox ckb_VerPass;
        private System.Windows.Forms.Label lbl_LoginError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ObrigatorioEscalao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_EscalaoATreinar;
    }
}