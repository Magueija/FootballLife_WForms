namespace FootballLife_WF
{
    partial class EditarUtilizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUtilizador));
            this.panel_Utilizador = new System.Windows.Forms.Panel();
            this.ckb_VerPass = new System.Windows.Forms.CheckBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Utilizador = new System.Windows.Forms.TextBox();
            this.tb_CodPostal = new System.Windows.Forms.TextBox();
            this.tb_Morada = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Telemovel = new System.Windows.Forms.TextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.lbl_CodPostal = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Utilizador = new System.Windows.Forms.Label();
            this.lbl_Morada = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Telemovel = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.img_Logo = new System.Windows.Forms.PictureBox();
            this.panel_Escalao = new System.Windows.Forms.Panel();
            this.rb_Infantis = new System.Windows.Forms.RadioButton();
            this.lbl_EscalaoATreinar = new System.Windows.Forms.Label();
            this.lbl_Escalao = new System.Windows.Forms.Label();
            this.rb_Seniores = new System.Windows.Forms.RadioButton();
            this.rb_Juniores = new System.Windows.Forms.RadioButton();
            this.rb_Petizes = new System.Windows.Forms.RadioButton();
            this.rb_Juvenis = new System.Windows.Forms.RadioButton();
            this.rb_Iniciados = new System.Windows.Forms.RadioButton();
            this.rb_Benjamins = new System.Windows.Forms.RadioButton();
            this.rb_Traquinas = new System.Windows.Forms.RadioButton();
            this.panel_Utilizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo)).BeginInit();
            this.panel_Escalao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Utilizador
            // 
            this.panel_Utilizador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Utilizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Utilizador.Controls.Add(this.panel_Escalao);
            this.panel_Utilizador.Controls.Add(this.ckb_VerPass);
            this.panel_Utilizador.Controls.Add(this.tb_Password);
            this.panel_Utilizador.Controls.Add(this.tb_Utilizador);
            this.panel_Utilizador.Controls.Add(this.tb_CodPostal);
            this.panel_Utilizador.Controls.Add(this.tb_Morada);
            this.panel_Utilizador.Controls.Add(this.tb_Email);
            this.panel_Utilizador.Controls.Add(this.tb_Telemovel);
            this.panel_Utilizador.Controls.Add(this.tb_Nome);
            this.panel_Utilizador.Controls.Add(this.btn_Gravar);
            this.panel_Utilizador.Controls.Add(this.lbl_CodPostal);
            this.panel_Utilizador.Controls.Add(this.lbl_Password);
            this.panel_Utilizador.Controls.Add(this.lbl_Utilizador);
            this.panel_Utilizador.Controls.Add(this.lbl_Morada);
            this.panel_Utilizador.Controls.Add(this.lbl_Email);
            this.panel_Utilizador.Controls.Add(this.lbl_Telemovel);
            this.panel_Utilizador.Controls.Add(this.lbl_Nome);
            this.panel_Utilizador.Controls.Add(this.Lbl_Titulo);
            this.panel_Utilizador.Controls.Add(this.img_Logo);
            this.panel_Utilizador.Location = new System.Drawing.Point(32, 21);
            this.panel_Utilizador.Name = "panel_Utilizador";
            this.panel_Utilizador.Size = new System.Drawing.Size(498, 465);
            this.panel_Utilizador.TabIndex = 0;
            // 
            // ckb_VerPass
            // 
            this.ckb_VerPass.AutoSize = true;
            this.ckb_VerPass.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_VerPass.Location = new System.Drawing.Point(338, 388);
            this.ckb_VerPass.Name = "ckb_VerPass";
            this.ckb_VerPass.Size = new System.Drawing.Size(96, 18);
            this.ckb_VerPass.TabIndex = 34;
            this.ckb_VerPass.Text = "Ver Password";
            this.ckb_VerPass.UseVisualStyleBackColor = true;
            this.ckb_VerPass.CheckedChanged += new System.EventHandler(this.Ckb_VerPass_CheckedChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(103, 362);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(330, 20);
            this.tb_Password.TabIndex = 21;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // tb_Utilizador
            // 
            this.tb_Utilizador.Location = new System.Drawing.Point(103, 336);
            this.tb_Utilizador.Name = "tb_Utilizador";
            this.tb_Utilizador.Size = new System.Drawing.Size(330, 20);
            this.tb_Utilizador.TabIndex = 20;
            // 
            // tb_CodPostal
            // 
            this.tb_CodPostal.Location = new System.Drawing.Point(134, 185);
            this.tb_CodPostal.Name = "tb_CodPostal";
            this.tb_CodPostal.Size = new System.Drawing.Size(299, 20);
            this.tb_CodPostal.TabIndex = 19;
            // 
            // tb_Morada
            // 
            this.tb_Morada.Location = new System.Drawing.Point(88, 162);
            this.tb_Morada.Name = "tb_Morada";
            this.tb_Morada.Size = new System.Drawing.Size(345, 20);
            this.tb_Morada.TabIndex = 18;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(76, 137);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(357, 20);
            this.tb_Email.TabIndex = 17;
            // 
            // tb_Telemovel
            // 
            this.tb_Telemovel.Location = new System.Drawing.Point(109, 111);
            this.tb_Telemovel.Name = "tb_Telemovel";
            this.tb_Telemovel.Size = new System.Drawing.Size(324, 20);
            this.tb_Telemovel.TabIndex = 16;
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(76, 84);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(358, 20);
            this.tb_Nome.TabIndex = 15;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.BackColor = System.Drawing.Color.White;
            this.btn_Gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gravar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gravar.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gravar.ForeColor = System.Drawing.Color.Black;
            this.btn_Gravar.Location = new System.Drawing.Point(396, 427);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(91, 27);
            this.btn_Gravar.TabIndex = 7;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = false;
            this.btn_Gravar.Click += new System.EventHandler(this.Btn_Gravar_Click);
            // 
            // lbl_CodPostal
            // 
            this.lbl_CodPostal.AutoSize = true;
            this.lbl_CodPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodPostal.Location = new System.Drawing.Point(17, 189);
            this.lbl_CodPostal.Name = "lbl_CodPostal";
            this.lbl_CodPostal.Size = new System.Drawing.Size(111, 16);
            this.lbl_CodPostal.TabIndex = 14;
            this.lbl_CodPostal.Text = "Código-Postal:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(17, 363);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(80, 16);
            this.lbl_Password.TabIndex = 12;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Utilizador
            // 
            this.lbl_Utilizador.AutoSize = true;
            this.lbl_Utilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Utilizador.Location = new System.Drawing.Point(17, 337);
            this.lbl_Utilizador.Name = "lbl_Utilizador";
            this.lbl_Utilizador.Size = new System.Drawing.Size(78, 16);
            this.lbl_Utilizador.TabIndex = 10;
            this.lbl_Utilizador.Text = "Utilizador:";
            // 
            // lbl_Morada
            // 
            this.lbl_Morada.AutoSize = true;
            this.lbl_Morada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Morada.Location = new System.Drawing.Point(17, 163);
            this.lbl_Morada.Name = "lbl_Morada";
            this.lbl_Morada.Size = new System.Drawing.Size(65, 16);
            this.lbl_Morada.TabIndex = 8;
            this.lbl_Morada.Text = "Morada:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(17, 137);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(51, 16);
            this.lbl_Email.TabIndex = 6;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Telemovel
            // 
            this.lbl_Telemovel.AutoSize = true;
            this.lbl_Telemovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telemovel.Location = new System.Drawing.Point(17, 111);
            this.lbl_Telemovel.Name = "lbl_Telemovel";
            this.lbl_Telemovel.Size = new System.Drawing.Size(86, 16);
            this.lbl_Telemovel.TabIndex = 4;
            this.lbl_Telemovel.Text = "Telemóvel:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(17, 85);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(53, 16);
            this.lbl_Nome.TabIndex = 2;
            this.lbl_Nome.Text = "Nome:";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(72, 30);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(0, 18);
            this.Lbl_Titulo.TabIndex = 1;
            // 
            // img_Logo
            // 
            this.img_Logo.Location = new System.Drawing.Point(13, 13);
            this.img_Logo.Name = "img_Logo";
            this.img_Logo.Size = new System.Drawing.Size(50, 50);
            this.img_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Logo.TabIndex = 0;
            this.img_Logo.TabStop = false;
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
            this.panel_Escalao.Location = new System.Drawing.Point(109, 216);
            this.panel_Escalao.Name = "panel_Escalao";
            this.panel_Escalao.Size = new System.Drawing.Size(302, 106);
            this.panel_Escalao.TabIndex = 35;
            // 
            // rb_Infantis
            // 
            this.rb_Infantis.AutoSize = true;
            this.rb_Infantis.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.rb_Infantis.Location = new System.Drawing.Point(6, 67);
            this.rb_Infantis.Name = "rb_Infantis";
            this.rb_Infantis.Size = new System.Drawing.Size(62, 19);
            this.rb_Infantis.TabIndex = 21;
            this.rb_Infantis.TabStop = true;
            this.rb_Infantis.Tag = "";
            this.rb_Infantis.Text = "Infantis";
            this.rb_Infantis.UseVisualStyleBackColor = true;
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
            this.rb_Juniores.Location = new System.Drawing.Point(77, 42);
            this.rb_Juniores.Name = "rb_Juniores";
            this.rb_Juniores.Size = new System.Drawing.Size(65, 19);
            this.rb_Juniores.TabIndex = 18;
            this.rb_Juniores.TabStop = true;
            this.rb_Juniores.Tag = "";
            this.rb_Juniores.Text = "Juniores";
            this.rb_Juniores.UseVisualStyleBackColor = true;
            // 
            // rb_Petizes
            // 
            this.rb_Petizes.AutoSize = true;
            this.rb_Petizes.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.rb_Petizes.Location = new System.Drawing.Point(239, 67);
            this.rb_Petizes.Name = "rb_Petizes";
            this.rb_Petizes.Size = new System.Drawing.Size(60, 19);
            this.rb_Petizes.TabIndex = 24;
            this.rb_Petizes.TabStop = true;
            this.rb_Petizes.Text = "Petizes";
            this.rb_Petizes.UseVisualStyleBackColor = true;
            // 
            // rb_Juvenis
            // 
            this.rb_Juvenis.AutoSize = true;
            this.rb_Juvenis.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.rb_Juvenis.Location = new System.Drawing.Point(148, 42);
            this.rb_Juvenis.Name = "rb_Juvenis";
            this.rb_Juvenis.Size = new System.Drawing.Size(60, 19);
            this.rb_Juvenis.TabIndex = 19;
            this.rb_Juvenis.TabStop = true;
            this.rb_Juvenis.Tag = "";
            this.rb_Juvenis.Text = "Juvenis";
            this.rb_Juvenis.UseVisualStyleBackColor = true;
            // 
            // rb_Iniciados
            // 
            this.rb_Iniciados.AutoSize = true;
            this.rb_Iniciados.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.rb_Iniciados.Location = new System.Drawing.Point(214, 42);
            this.rb_Iniciados.Name = "rb_Iniciados";
            this.rb_Iniciados.Size = new System.Drawing.Size(68, 19);
            this.rb_Iniciados.TabIndex = 23;
            this.rb_Iniciados.TabStop = true;
            this.rb_Iniciados.Text = "Iniciados";
            this.rb_Iniciados.UseVisualStyleBackColor = true;
            // 
            // rb_Benjamins
            // 
            this.rb_Benjamins.AutoSize = true;
            this.rb_Benjamins.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.rb_Benjamins.Location = new System.Drawing.Point(74, 67);
            this.rb_Benjamins.Name = "rb_Benjamins";
            this.rb_Benjamins.Size = new System.Drawing.Size(78, 19);
            this.rb_Benjamins.TabIndex = 20;
            this.rb_Benjamins.TabStop = true;
            this.rb_Benjamins.Tag = "";
            this.rb_Benjamins.Text = "Benjamins";
            this.rb_Benjamins.UseVisualStyleBackColor = true;
            // 
            // rb_Traquinas
            // 
            this.rb_Traquinas.AutoSize = true;
            this.rb_Traquinas.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.rb_Traquinas.Location = new System.Drawing.Point(158, 67);
            this.rb_Traquinas.Name = "rb_Traquinas";
            this.rb_Traquinas.Size = new System.Drawing.Size(77, 19);
            this.rb_Traquinas.TabIndex = 22;
            this.rb_Traquinas.TabStop = true;
            this.rb_Traquinas.Text = "Traquinas";
            this.rb_Traquinas.UseVisualStyleBackColor = true;
            // 
            // EditarUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 510);
            this.Controls.Add(this.panel_Utilizador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarUtilizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilizador";
            this.Load += new System.EventHandler(this.VisualizarUtilizador_Load);
            this.panel_Utilizador.ResumeLayout(false);
            this.panel_Utilizador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo)).EndInit();
            this.panel_Escalao.ResumeLayout(false);
            this.panel_Escalao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Utilizador;
        private System.Windows.Forms.Label lbl_Morada;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Telemovel;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.PictureBox img_Logo;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Utilizador;
        private System.Windows.Forms.Label lbl_CodPostal;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Utilizador;
        private System.Windows.Forms.TextBox tb_CodPostal;
        private System.Windows.Forms.TextBox tb_Morada;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Telemovel;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.CheckBox ckb_VerPass;
        private System.Windows.Forms.Panel panel_Escalao;
        private System.Windows.Forms.RadioButton rb_Infantis;
        private System.Windows.Forms.Label lbl_EscalaoATreinar;
        private System.Windows.Forms.Label lbl_Escalao;
        private System.Windows.Forms.RadioButton rb_Seniores;
        private System.Windows.Forms.RadioButton rb_Juniores;
        private System.Windows.Forms.RadioButton rb_Petizes;
        private System.Windows.Forms.RadioButton rb_Juvenis;
        private System.Windows.Forms.RadioButton rb_Iniciados;
        private System.Windows.Forms.RadioButton rb_Benjamins;
        private System.Windows.Forms.RadioButton rb_Traquinas;
    }
}