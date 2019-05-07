namespace FootballLife_WF
{
    partial class Login
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
            this.lbl_Utilizador = new System.Windows.Forms.Label();
            this.tb_Utilizador = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_LoginError = new System.Windows.Forms.Label();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.lbl_EsqueceuPassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.img_BackArrow = new System.Windows.Forms.PictureBox();
            this.img_Logo = new System.Windows.Forms.PictureBox();
            this.img_Fundo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_BackArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Fundo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Utilizador
            // 
            this.lbl_Utilizador.AutoSize = true;
            this.lbl_Utilizador.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Utilizador.Location = new System.Drawing.Point(37, 292);
            this.lbl_Utilizador.Name = "lbl_Utilizador";
            this.lbl_Utilizador.Size = new System.Drawing.Size(85, 16);
            this.lbl_Utilizador.TabIndex = 1;
            this.lbl_Utilizador.Text = "UTILIZADOR:";
            // 
            // tb_Utilizador
            // 
            this.tb_Utilizador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Utilizador.Location = new System.Drawing.Point(128, 289);
            this.tb_Utilizador.Name = "tb_Utilizador";
            this.tb_Utilizador.Size = new System.Drawing.Size(199, 22);
            this.tb_Utilizador.TabIndex = 2;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(43, 324);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(79, 16);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "PASSWORD:";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(128, 321);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(199, 22);
            this.tb_Password.TabIndex = 4;
            // 
            // lbl_LoginError
            // 
            this.lbl_LoginError.AutoSize = true;
            this.lbl_LoginError.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginError.ForeColor = System.Drawing.Color.Red;
            this.lbl_LoginError.Location = new System.Drawing.Point(152, 349);
            this.lbl_LoginError.Name = "lbl_LoginError";
            this.lbl_LoginError.Size = new System.Drawing.Size(175, 13);
            this.lbl_LoginError.TabIndex = 5;
            this.lbl_LoginError.Text = "Utilizador ou Password incorretos!";
            this.lbl_LoginError.Visible = false;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.White;
            this.btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Entrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.ForeColor = System.Drawing.Color.Black;
            this.btn_Entrar.Location = new System.Drawing.Point(226, 424);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(101, 34);
            this.btn_Entrar.TabIndex = 6;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            // 
            // lbl_EsqueceuPassword
            // 
            this.lbl_EsqueceuPassword.AutoSize = true;
            this.lbl_EsqueceuPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_EsqueceuPassword.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EsqueceuPassword.Location = new System.Drawing.Point(37, 433);
            this.lbl_EsqueceuPassword.Name = "lbl_EsqueceuPassword";
            this.lbl_EsqueceuPassword.Size = new System.Drawing.Size(165, 17);
            this.lbl_EsqueceuPassword.TabIndex = 7;
            this.lbl_EsqueceuPassword.Text = "Esqueceu a sua password?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.img_BackArrow);
            this.panel1.Controls.Add(this.lbl_EsqueceuPassword);
            this.panel1.Controls.Add(this.btn_Entrar);
            this.panel1.Controls.Add(this.lbl_LoginError);
            this.panel1.Controls.Add(this.tb_Password);
            this.panel1.Controls.Add(this.lbl_Password);
            this.panel1.Controls.Add(this.tb_Utilizador);
            this.panel1.Controls.Add(this.lbl_Utilizador);
            this.panel1.Controls.Add(this.img_Logo);
            this.panel1.Location = new System.Drawing.Point(493, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 496);
            this.panel1.TabIndex = 1;
            // 
            // img_BackArrow
            // 
            this.img_BackArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_BackArrow.Image = global::FootballLife_WF.Properties.Resources.BackArrow_Login_Normal;
            this.img_BackArrow.Location = new System.Drawing.Point(4, 4);
            this.img_BackArrow.Name = "img_BackArrow";
            this.img_BackArrow.Size = new System.Drawing.Size(31, 31);
            this.img_BackArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_BackArrow.TabIndex = 8;
            this.img_BackArrow.TabStop = false;
            this.img_BackArrow.Click += new System.EventHandler(this.Img_BackArrow_Click);
            this.img_BackArrow.MouseLeave += new System.EventHandler(this.Img_BackArrow_MouseLeave);
            this.img_BackArrow.MouseHover += new System.EventHandler(this.Img_BackArrow_MouseHover);
            // 
            // img_Logo
            // 
            this.img_Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_Logo.Image = global::FootballLife_WF.Properties.Resources.Logo_Clube;
            this.img_Logo.Location = new System.Drawing.Point(108, 75);
            this.img_Logo.Name = "img_Logo";
            this.img_Logo.Size = new System.Drawing.Size(160, 140);
            this.img_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Logo.TabIndex = 0;
            this.img_Logo.TabStop = false;
            this.img_Logo.Click += new System.EventHandler(this.Img_Logo_Click);
            // 
            // img_Fundo
            // 
            this.img_Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_Fundo.Image = global::FootballLife_WF.Properties.Resources.Fundo_1;
            this.img_Fundo.Location = new System.Drawing.Point(0, 0);
            this.img_Fundo.Name = "img_Fundo";
            this.img_Fundo.Size = new System.Drawing.Size(1370, 749);
            this.img_Fundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Fundo.TabIndex = 0;
            this.img_Fundo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img_Fundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "FOOTBALL LIFE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_BackArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Fundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Fundo;
        private System.Windows.Forms.PictureBox img_Logo;
        private System.Windows.Forms.Label lbl_Utilizador;
        private System.Windows.Forms.TextBox tb_Utilizador;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_LoginError;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Label lbl_EsqueceuPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox img_BackArrow;
    }
}

