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
            this.tb_Residencia = new System.Windows.Forms.TextBox();
            this.lbl_Escalao = new System.Windows.Forms.Label();
            this.lbl_EscalaoATreinar = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.tb_Utilizador = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_ConfPassword = new System.Windows.Forms.TextBox();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.panel_Escalao = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            // tb_Residencia
            // 
            this.tb_Residencia.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_Residencia.Location = new System.Drawing.Point(99, 233);
            this.tb_Residencia.Name = "tb_Residencia";
            this.tb_Residencia.Size = new System.Drawing.Size(302, 22);
            this.tb_Residencia.TabIndex = 14;
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 19);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Séniores";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.radioButton2.Location = new System.Drawing.Point(6, 67);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 19);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Juniores";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.radioButton3.Location = new System.Drawing.Point(79, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 19);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Juvenis";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.radioButton4.Location = new System.Drawing.Point(77, 67);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(68, 19);
            this.radioButton4.TabIndex = 20;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Iniciados";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.radioButton5.Location = new System.Drawing.Point(151, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(62, 19);
            this.radioButton5.TabIndex = 21;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Infantis";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.radioButton6.Location = new System.Drawing.Point(151, 67);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(78, 19);
            this.radioButton6.TabIndex = 22;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Benjamins";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.radioButton7.Location = new System.Drawing.Point(235, 42);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(68, 19);
            this.radioButton7.TabIndex = 23;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Iniciados";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.radioButton8.Location = new System.Drawing.Point(235, 67);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(60, 19);
            this.radioButton8.TabIndex = 24;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Petizes";
            this.radioButton8.UseVisualStyleBackColor = true;
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
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(302, 22);
            this.tb_Password.TabIndex = 26;
            // 
            // tb_ConfPassword
            // 
            this.tb_ConfPassword.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_ConfPassword.Location = new System.Drawing.Point(100, 504);
            this.tb_ConfPassword.Name = "tb_ConfPassword";
            this.tb_ConfPassword.PasswordChar = '*';
            this.tb_ConfPassword.Size = new System.Drawing.Size(301, 22);
            this.tb_ConfPassword.TabIndex = 27;
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
            this.panel_Escalao.Controls.Add(this.radioButton5);
            this.panel_Escalao.Controls.Add(this.lbl_EscalaoATreinar);
            this.panel_Escalao.Controls.Add(this.lbl_Escalao);
            this.panel_Escalao.Controls.Add(this.radioButton1);
            this.panel_Escalao.Controls.Add(this.radioButton2);
            this.panel_Escalao.Controls.Add(this.radioButton8);
            this.panel_Escalao.Controls.Add(this.radioButton3);
            this.panel_Escalao.Controls.Add(this.radioButton7);
            this.panel_Escalao.Controls.Add(this.radioButton4);
            this.panel_Escalao.Controls.Add(this.radioButton6);
            this.panel_Escalao.Location = new System.Drawing.Point(99, 316);
            this.panel_Escalao.Name = "panel_Escalao";
            this.panel_Escalao.Size = new System.Drawing.Size(302, 106);
            this.panel_Escalao.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(123, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 22);
            this.textBox1.TabIndex = 31;
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
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textBox2.Location = new System.Drawing.Point(217, 261);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 22);
            this.textBox2.TabIndex = 32;
            // 
            // AdicionarUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 606);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Escalao);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.tb_ConfPassword);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Utilizador);
            this.Controls.Add(this.tb_Residencia);
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
        private System.Windows.Forms.TextBox tb_Residencia;
        private System.Windows.Forms.Label lbl_Escalao;
        private System.Windows.Forms.Label lbl_EscalaoATreinar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.TextBox tb_Utilizador;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_ConfPassword;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Panel panel_Escalao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}