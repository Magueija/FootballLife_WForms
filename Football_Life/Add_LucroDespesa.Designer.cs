namespace FootballLife_WF
{
    partial class Add_LucroDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_LucroDespesa));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.rb_Utilizadores = new System.Windows.Forms.RadioButton();
            this.rb_Outros = new System.Windows.Forms.RadioButton();
            this.lbl_LoginError = new System.Windows.Forms.Label();
            this.tb_ONome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_OMontante = new System.Windows.Forms.Label();
            this.btn_GravarOutros = new System.Windows.Forms.Button();
            this.tb_OMontante = new System.Windows.Forms.TextBox();
            this.tb_ODescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_Outros = new System.Windows.Forms.Panel();
            this.cb_UNomeAtleta = new System.Windows.Forms.ComboBox();
            this.lbl_UFuncao = new System.Windows.Forms.Label();
            this.cb_UFuncao = new System.Windows.Forms.ComboBox();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.cb_UNomeSocio = new System.Windows.Forms.ComboBox();
            this.btn_GravarTreinador = new System.Windows.Forms.Button();
            this.tb_UDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_Utilizador = new System.Windows.Forms.Panel();
            this.panel_Outros.SuspendLayout();
            this.panel_Utilizador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(91, 27);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(102, 21);
            this.lbl_Titulo.TabIndex = 3;
            this.lbl_Titulo.Text = "Adicionar";
            // 
            // rb_Utilizadores
            // 
            this.rb_Utilizadores.AutoSize = true;
            this.rb_Utilizadores.Checked = true;
            this.rb_Utilizadores.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Utilizadores.Location = new System.Drawing.Point(36, 74);
            this.rb_Utilizadores.Name = "rb_Utilizadores";
            this.rb_Utilizadores.Size = new System.Drawing.Size(73, 19);
            this.rb_Utilizadores.TabIndex = 18;
            this.rb_Utilizadores.TabStop = true;
            this.rb_Utilizadores.Tag = "";
            this.rb_Utilizadores.Text = "Utilizador";
            this.rb_Utilizadores.UseVisualStyleBackColor = true;
            this.rb_Utilizadores.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // rb_Outros
            // 
            this.rb_Outros.AutoSize = true;
            this.rb_Outros.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Outros.Location = new System.Drawing.Point(124, 74);
            this.rb_Outros.Name = "rb_Outros";
            this.rb_Outros.Size = new System.Drawing.Size(60, 19);
            this.rb_Outros.TabIndex = 19;
            this.rb_Outros.Tag = "";
            this.rb_Outros.Text = "Outros";
            this.rb_Outros.UseVisualStyleBackColor = true;
            this.rb_Outros.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // lbl_LoginError
            // 
            this.lbl_LoginError.AutoSize = true;
            this.lbl_LoginError.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginError.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_LoginError.Location = new System.Drawing.Point(205, 89);
            this.lbl_LoginError.Name = "lbl_LoginError";
            this.lbl_LoginError.Size = new System.Drawing.Size(128, 15);
            this.lbl_LoginError.TabIndex = 35;
            this.lbl_LoginError.Text = "* Campos Obrigatórios!";
            // 
            // tb_ONome
            // 
            this.tb_ONome.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_ONome.Location = new System.Drawing.Point(62, 14);
            this.tb_ONome.Name = "tb_ONome";
            this.tb_ONome.Size = new System.Drawing.Size(232, 22);
            this.tb_ONome.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome:";
            // 
            // lbl_OMontante
            // 
            this.lbl_OMontante.AutoSize = true;
            this.lbl_OMontante.BackColor = System.Drawing.Color.Transparent;
            this.lbl_OMontante.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_OMontante.Location = new System.Drawing.Point(11, 47);
            this.lbl_OMontante.Name = "lbl_OMontante";
            this.lbl_OMontante.Size = new System.Drawing.Size(68, 16);
            this.lbl_OMontante.TabIndex = 14;
            this.lbl_OMontante.Text = "Montante:";
            // 
            // btn_GravarOutros
            // 
            this.btn_GravarOutros.BackColor = System.Drawing.Color.White;
            this.btn_GravarOutros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GravarOutros.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_GravarOutros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GravarOutros.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GravarOutros.ForeColor = System.Drawing.Color.Black;
            this.btn_GravarOutros.Location = new System.Drawing.Point(208, 254);
            this.btn_GravarOutros.Name = "btn_GravarOutros";
            this.btn_GravarOutros.Size = new System.Drawing.Size(92, 34);
            this.btn_GravarOutros.TabIndex = 29;
            this.btn_GravarOutros.Text = "Gravar";
            this.btn_GravarOutros.UseVisualStyleBackColor = false;
            this.btn_GravarOutros.Click += new System.EventHandler(this.Btn_GravarOutros_Click);
            // 
            // tb_OMontante
            // 
            this.tb_OMontante.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_OMontante.Location = new System.Drawing.Point(85, 44);
            this.tb_OMontante.Name = "tb_OMontante";
            this.tb_OMontante.Size = new System.Drawing.Size(100, 22);
            this.tb_OMontante.TabIndex = 30;
            this.tb_OMontante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_OMontante_KeyDown);
            // 
            // tb_ODescricao
            // 
            this.tb_ODescricao.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_ODescricao.Location = new System.Drawing.Point(17, 112);
            this.tb_ODescricao.Multiline = true;
            this.tb_ODescricao.Name = "tb_ODescricao";
            this.tb_ODescricao.Size = new System.Drawing.Size(280, 109);
            this.tb_ODescricao.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Descrição:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(281, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 42;
            this.label8.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(172, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "*";
            // 
            // panel_Outros
            // 
            this.panel_Outros.Controls.Add(this.label4);
            this.panel_Outros.Controls.Add(this.label8);
            this.panel_Outros.Controls.Add(this.label3);
            this.panel_Outros.Controls.Add(this.tb_ODescricao);
            this.panel_Outros.Controls.Add(this.tb_OMontante);
            this.panel_Outros.Controls.Add(this.btn_GravarOutros);
            this.panel_Outros.Controls.Add(this.lbl_OMontante);
            this.panel_Outros.Controls.Add(this.label2);
            this.panel_Outros.Controls.Add(this.tb_ONome);
            this.panel_Outros.Location = new System.Drawing.Point(21, 108);
            this.panel_Outros.Name = "panel_Outros";
            this.panel_Outros.Size = new System.Drawing.Size(311, 299);
            this.panel_Outros.TabIndex = 30;
            this.panel_Outros.Visible = false;
            // 
            // cb_UNomeAtleta
            // 
            this.cb_UNomeAtleta.BackColor = System.Drawing.Color.White;
            this.cb_UNomeAtleta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_UNomeAtleta.DisplayMember = "Nome";
            this.cb_UNomeAtleta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_UNomeAtleta.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cb_UNomeAtleta.FormattingEnabled = true;
            this.cb_UNomeAtleta.Location = new System.Drawing.Point(73, 44);
            this.cb_UNomeAtleta.Name = "cb_UNomeAtleta";
            this.cb_UNomeAtleta.Size = new System.Drawing.Size(185, 24);
            this.cb_UNomeAtleta.TabIndex = 34;
            this.cb_UNomeAtleta.ValueMember = "IDAtleta";
            this.cb_UNomeAtleta.Visible = false;
            // 
            // lbl_UFuncao
            // 
            this.lbl_UFuncao.AutoSize = true;
            this.lbl_UFuncao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UFuncao.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_UFuncao.Location = new System.Drawing.Point(14, 17);
            this.lbl_UFuncao.Name = "lbl_UFuncao";
            this.lbl_UFuncao.Size = new System.Drawing.Size(52, 16);
            this.lbl_UFuncao.TabIndex = 5;
            this.lbl_UFuncao.Text = "Função:";
            // 
            // cb_UFuncao
            // 
            this.cb_UFuncao.BackColor = System.Drawing.Color.White;
            this.cb_UFuncao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_UFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_UFuncao.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cb_UFuncao.FormattingEnabled = true;
            this.cb_UFuncao.Items.AddRange(new object[] {
            "Atleta",
            "Sócio"});
            this.cb_UFuncao.Location = new System.Drawing.Point(73, 14);
            this.cb_UFuncao.Name = "cb_UFuncao";
            this.cb_UFuncao.Size = new System.Drawing.Size(185, 24);
            this.cb_UFuncao.TabIndex = 6;
            this.cb_UFuncao.SelectedIndexChanged += new System.EventHandler(this.Cb_UFuncao_SelectedIndexChanged);
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.BackColor = System.Drawing.Color.Transparent;
            this.lb_Nome.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_Nome.Location = new System.Drawing.Point(17, 47);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(46, 16);
            this.lb_Nome.TabIndex = 13;
            this.lb_Nome.Text = "Nome:";
            // 
            // cb_UNomeSocio
            // 
            this.cb_UNomeSocio.BackColor = System.Drawing.Color.White;
            this.cb_UNomeSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_UNomeSocio.DisplayMember = "Nome";
            this.cb_UNomeSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_UNomeSocio.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cb_UNomeSocio.FormattingEnabled = true;
            this.cb_UNomeSocio.Location = new System.Drawing.Point(73, 44);
            this.cb_UNomeSocio.Name = "cb_UNomeSocio";
            this.cb_UNomeSocio.Size = new System.Drawing.Size(185, 24);
            this.cb_UNomeSocio.TabIndex = 15;
            this.cb_UNomeSocio.ValueMember = "IDSocio";
            // 
            // btn_GravarTreinador
            // 
            this.btn_GravarTreinador.BackColor = System.Drawing.Color.White;
            this.btn_GravarTreinador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GravarTreinador.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_GravarTreinador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GravarTreinador.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GravarTreinador.ForeColor = System.Drawing.Color.Black;
            this.btn_GravarTreinador.Location = new System.Drawing.Point(208, 253);
            this.btn_GravarTreinador.Name = "btn_GravarTreinador";
            this.btn_GravarTreinador.Size = new System.Drawing.Size(92, 34);
            this.btn_GravarTreinador.TabIndex = 29;
            this.btn_GravarTreinador.Text = "Gravar";
            this.btn_GravarTreinador.UseVisualStyleBackColor = false;
            this.btn_GravarTreinador.Click += new System.EventHandler(this.Btn_GravarUtilizador_Click);
            // 
            // tb_UDescricao
            // 
            this.tb_UDescricao.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tb_UDescricao.Location = new System.Drawing.Point(17, 129);
            this.tb_UDescricao.Multiline = true;
            this.tb_UDescricao.Name = "tb_UDescricao";
            this.tb_UDescricao.Size = new System.Drawing.Size(280, 109);
            this.tb_UDescricao.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(264, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(264, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "*";
            // 
            // panel_Utilizador
            // 
            this.panel_Utilizador.Controls.Add(this.label9);
            this.panel_Utilizador.Controls.Add(this.label6);
            this.panel_Utilizador.Controls.Add(this.label1);
            this.panel_Utilizador.Controls.Add(this.tb_UDescricao);
            this.panel_Utilizador.Controls.Add(this.btn_GravarTreinador);
            this.panel_Utilizador.Controls.Add(this.cb_UNomeSocio);
            this.panel_Utilizador.Controls.Add(this.lb_Nome);
            this.panel_Utilizador.Controls.Add(this.cb_UFuncao);
            this.panel_Utilizador.Controls.Add(this.lbl_UFuncao);
            this.panel_Utilizador.Controls.Add(this.cb_UNomeAtleta);
            this.panel_Utilizador.Location = new System.Drawing.Point(22, 107);
            this.panel_Utilizador.Name = "panel_Utilizador";
            this.panel_Utilizador.Size = new System.Drawing.Size(311, 300);
            this.panel_Utilizador.TabIndex = 13;
            // 
            // Add_LucroDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 416);
            this.Controls.Add(this.panel_Outros);
            this.Controls.Add(this.lbl_LoginError);
            this.Controls.Add(this.rb_Outros);
            this.Controls.Add(this.panel_Utilizador);
            this.Controls.Add(this.rb_Utilizadores);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_LucroDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar ";
            this.Load += new System.EventHandler(this.Add_LucroDespesa_Load);
            this.panel_Outros.ResumeLayout(false);
            this.panel_Outros.PerformLayout();
            this.panel_Utilizador.ResumeLayout(false);
            this.panel_Utilizador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.RadioButton rb_Utilizadores;
        private System.Windows.Forms.RadioButton rb_Outros;
        private System.Windows.Forms.Label lbl_LoginError;
        private System.Windows.Forms.TextBox tb_ONome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_OMontante;
        private System.Windows.Forms.Button btn_GravarOutros;
        private System.Windows.Forms.TextBox tb_OMontante;
        private System.Windows.Forms.TextBox tb_ODescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_Outros;
        private System.Windows.Forms.ComboBox cb_UNomeAtleta;
        private System.Windows.Forms.Label lbl_UFuncao;
        private System.Windows.Forms.ComboBox cb_UFuncao;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.ComboBox cb_UNomeSocio;
        private System.Windows.Forms.Button btn_GravarTreinador;
        private System.Windows.Forms.TextBox tb_UDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel_Utilizador;
    }
}