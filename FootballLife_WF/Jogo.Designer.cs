namespace FootballLife_WF
{
    partial class Jogo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Delete = new System.Windows.Forms.PictureBox();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.btn_VerJogo = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.img_Fora = new System.Windows.Forms.PictureBox();
            this.lbl_FEquipa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_CGolos = new System.Windows.Forms.Label();
            this.lbl_FGolos = new System.Windows.Forms.Label();
            this.lbl_CEquipa = new System.Windows.Forms.Label();
            this.img_Casa = new System.Windows.Forms.PictureBox();
            this.lbl_Escalao = new System.Windows.Forms.Label();
            this.lbl_VitoriaDerrota = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Fora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Casa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb_Delete);
            this.panel1.Controls.Add(this.lbl_Data);
            this.panel1.Controls.Add(this.btn_VerJogo);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.img_Fora);
            this.panel1.Controls.Add(this.lbl_FEquipa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_CGolos);
            this.panel1.Controls.Add(this.lbl_FGolos);
            this.panel1.Controls.Add(this.lbl_CEquipa);
            this.panel1.Controls.Add(this.img_Casa);
            this.panel1.Controls.Add(this.lbl_Escalao);
            this.panel1.Controls.Add(this.lbl_VitoriaDerrota);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 175);
            this.panel1.TabIndex = 0;
            // 
            // pb_Delete
            // 
            this.pb_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Delete.Image = ((System.Drawing.Image)(resources.GetObject("pb_Delete.Image")));
            this.pb_Delete.Location = new System.Drawing.Point(663, 148);
            this.pb_Delete.Name = "pb_Delete";
            this.pb_Delete.Size = new System.Drawing.Size(15, 20);
            this.pb_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Delete.TabIndex = 32;
            this.pb_Delete.TabStop = false;
            this.pb_Delete.Visible = false;
            this.pb_Delete.Click += new System.EventHandler(this.Pb_Delete_Click);
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Data.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data.Location = new System.Drawing.Point(14, 39);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(61, 13);
            this.lbl_Data.TabIndex = 31;
            this.lbl_Data.Text = "05/05/2019";
            // 
            // btn_VerJogo
            // 
            this.btn_VerJogo.BackColor = System.Drawing.Color.White;
            this.btn_VerJogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VerJogo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_VerJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerJogo.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerJogo.ForeColor = System.Drawing.Color.Black;
            this.btn_VerJogo.Location = new System.Drawing.Point(564, 146);
            this.btn_VerJogo.Name = "btn_VerJogo";
            this.btn_VerJogo.Size = new System.Drawing.Size(95, 26);
            this.btn_VerJogo.TabIndex = 30;
            this.btn_VerJogo.Text = "Ver Jogo";
            this.btn_VerJogo.UseVisualStyleBackColor = false;
            this.btn_VerJogo.Click += new System.EventHandler(this.Btn_VerJogo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FootballLife_WF.Properties.Resources.Logo_Clube;
            this.pictureBox3.Location = new System.Drawing.Point(645, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // img_Fora
            // 
            this.img_Fora.Location = new System.Drawing.Point(516, 72);
            this.img_Fora.Name = "img_Fora";
            this.img_Fora.Size = new System.Drawing.Size(50, 50);
            this.img_Fora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Fora.TabIndex = 25;
            this.img_Fora.TabStop = false;
            // 
            // lbl_FEquipa
            // 
            this.lbl_FEquipa.AutoSize = true;
            this.lbl_FEquipa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FEquipa.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_FEquipa.Location = new System.Drawing.Point(400, 90);
            this.lbl_FEquipa.Name = "lbl_FEquipa";
            this.lbl_FEquipa.Size = new System.Drawing.Size(0, 16);
            this.lbl_FEquipa.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "-";
            // 
            // lbl_CGolos
            // 
            this.lbl_CGolos.AutoSize = true;
            this.lbl_CGolos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CGolos.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CGolos.Location = new System.Drawing.Point(286, 84);
            this.lbl_CGolos.Name = "lbl_CGolos";
            this.lbl_CGolos.Size = new System.Drawing.Size(37, 27);
            this.lbl_CGolos.TabIndex = 22;
            this.lbl_CGolos.Text = "54";
            // 
            // lbl_FGolos
            // 
            this.lbl_FGolos.AutoSize = true;
            this.lbl_FGolos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FGolos.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FGolos.Location = new System.Drawing.Point(359, 84);
            this.lbl_FGolos.Name = "lbl_FGolos";
            this.lbl_FGolos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_FGolos.Size = new System.Drawing.Size(40, 27);
            this.lbl_FGolos.TabIndex = 21;
            this.lbl_FGolos.Text = "04";
            // 
            // lbl_CEquipa
            // 
            this.lbl_CEquipa.AutoSize = true;
            this.lbl_CEquipa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CEquipa.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CEquipa.Location = new System.Drawing.Point(164, 90);
            this.lbl_CEquipa.Name = "lbl_CEquipa";
            this.lbl_CEquipa.Size = new System.Drawing.Size(0, 16);
            this.lbl_CEquipa.TabIndex = 20;
            // 
            // img_Casa
            // 
            this.img_Casa.Location = new System.Drawing.Point(103, 72);
            this.img_Casa.Name = "img_Casa";
            this.img_Casa.Size = new System.Drawing.Size(50, 50);
            this.img_Casa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Casa.TabIndex = 19;
            this.img_Casa.TabStop = false;
            // 
            // lbl_Escalao
            // 
            this.lbl_Escalao.AutoSize = true;
            this.lbl_Escalao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Escalao.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Escalao.Location = new System.Drawing.Point(306, 39);
            this.lbl_Escalao.Name = "lbl_Escalao";
            this.lbl_Escalao.Size = new System.Drawing.Size(74, 23);
            this.lbl_Escalao.TabIndex = 18;
            this.lbl_Escalao.Text = "Escalao";
            // 
            // lbl_VitoriaDerrota
            // 
            this.lbl_VitoriaDerrota.AutoSize = true;
            this.lbl_VitoriaDerrota.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VitoriaDerrota.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_VitoriaDerrota.Location = new System.Drawing.Point(13, 18);
            this.lbl_VitoriaDerrota.Name = "lbl_VitoriaDerrota";
            this.lbl_VitoriaDerrota.Size = new System.Drawing.Size(85, 21);
            this.lbl_VitoriaDerrota.TabIndex = 17;
            this.lbl_VitoriaDerrota.Text = "VITÓRIA";
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "Jogo";
            this.Size = new System.Drawing.Size(688, 180);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Fora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Casa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_VitoriaDerrota;
        private System.Windows.Forms.PictureBox img_Fora;
        private System.Windows.Forms.Label lbl_FEquipa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_CGolos;
        private System.Windows.Forms.Label lbl_FGolos;
        private System.Windows.Forms.Label lbl_CEquipa;
        private System.Windows.Forms.PictureBox img_Casa;
        private System.Windows.Forms.Label lbl_Escalao;
        private System.Windows.Forms.Button btn_VerJogo;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pb_Delete;
    }
}
