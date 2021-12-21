namespace FootballLife_WF
{
    partial class NovaDiscussão
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaDiscussão));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.tb_Mensagem = new System.Windows.Forms.TextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.lbl_LoginError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(196, 40);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(153, 21);
            this.lbl_Titulo.TabIndex = 3;
            this.lbl_Titulo.Text = "Nova Discussão";
            // 
            // tb_Mensagem
            // 
            this.tb_Mensagem.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_Mensagem.Location = new System.Drawing.Point(50, 167);
            this.tb_Mensagem.Multiline = true;
            this.tb_Mensagem.Name = "tb_Mensagem";
            this.tb_Mensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Mensagem.Size = new System.Drawing.Size(463, 138);
            this.tb_Mensagem.TabIndex = 16;
            // 
            // tb_Nome
            // 
            this.tb_Nome.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_Nome.Location = new System.Drawing.Point(153, 108);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(360, 22);
            this.tb_Nome.TabIndex = 15;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Email.Location = new System.Drawing.Point(47, 148);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(73, 16);
            this.lbl_Email.TabIndex = 14;
            this.lbl_Email.Text = "Mensagem:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Nome.Location = new System.Drawing.Point(47, 108);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(100, 16);
            this.lbl_Nome.TabIndex = 13;
            this.lbl_Nome.Text = "Nome Discussão:";
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.BackColor = System.Drawing.Color.White;
            this.btn_Gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gravar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gravar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gravar.ForeColor = System.Drawing.Color.Black;
            this.btn_Gravar.Location = new System.Drawing.Point(456, 362);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(92, 34);
            this.btn_Gravar.TabIndex = 29;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = false;
            this.btn_Gravar.Click += new System.EventHandler(this.Btn_Gravar_Click);
            // 
            // lbl_LoginError
            // 
            this.lbl_LoginError.AutoSize = true;
            this.lbl_LoginError.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginError.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_LoginError.Location = new System.Drawing.Point(385, 90);
            this.lbl_LoginError.Name = "lbl_LoginError";
            this.lbl_LoginError.Size = new System.Drawing.Size(128, 15);
            this.lbl_LoginError.TabIndex = 36;
            this.lbl_LoginError.Text = "* Campos Obrigatórios!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(513, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(513, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "*";
            // 
            // NovaDiscussão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_LoginError);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.tb_Mensagem);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovaDiscussão";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Discussão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox tb_Mensagem;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Label lbl_LoginError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}