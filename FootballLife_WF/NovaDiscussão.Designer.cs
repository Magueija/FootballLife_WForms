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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.btn_Entrar = new System.Windows.Forms.Button();
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
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_Email.Location = new System.Drawing.Point(50, 167);
            this.tb_Email.Multiline = true;
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Email.Size = new System.Drawing.Size(463, 138);
            this.tb_Email.TabIndex = 16;
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
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.White;
            this.btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Entrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.ForeColor = System.Drawing.Color.Black;
            this.btn_Entrar.Location = new System.Drawing.Point(456, 362);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(92, 34);
            this.btn_Entrar.TabIndex = 29;
            this.btn_Entrar.Text = "Gravar";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            // 
            // NovaDiscussão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 408);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Button btn_Entrar;
    }
}