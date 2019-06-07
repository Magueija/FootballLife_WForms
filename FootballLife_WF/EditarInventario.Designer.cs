namespace FootballLife_WF
{
    partial class EditarInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarInventario));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.flowpanel_material = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.img_Add = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_Add)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(332, 26);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(104, 21);
            this.lbl_Titulo.TabIndex = 3;
            this.lbl_Titulo.Text = "Inventário";
            // 
            // flowpanel_material
            // 
            this.flowpanel_material.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowpanel_material.AutoScroll = true;
            this.flowpanel_material.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowpanel_material.Location = new System.Drawing.Point(21, 81);
            this.flowpanel_material.Name = "flowpanel_material";
            this.flowpanel_material.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.flowpanel_material.Size = new System.Drawing.Size(699, 185);
            this.flowpanel_material.TabIndex = 4;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Gravar.BackColor = System.Drawing.Color.White;
            this.btn_Gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gravar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gravar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gravar.ForeColor = System.Drawing.Color.Black;
            this.btn_Gravar.Location = new System.Drawing.Point(637, 358);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(92, 34);
            this.btn_Gravar.TabIndex = 29;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = false;
            this.btn_Gravar.Click += new System.EventHandler(this.Btn_Gravar_Click);
            // 
            // img_Add
            // 
            this.img_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_Add.Image = global::FootballLife_WF.Properties.Resources.Add_Normal;
            this.img_Add.Location = new System.Drawing.Point(653, 270);
            this.img_Add.Name = "img_Add";
            this.img_Add.Size = new System.Drawing.Size(30, 30);
            this.img_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Add.TabIndex = 5;
            this.img_Add.TabStop = false;
            this.img_Add.Click += new System.EventHandler(this.Img_Add_Click);
            this.img_Add.MouseLeave += new System.EventHandler(this.EditarInventario_MouseLeave);
            this.img_Add.MouseHover += new System.EventHandler(this.EditarInventario_MouseHover);
            // 
            // EditarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 404);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.img_Add);
            this.Controls.Add(this.flowpanel_material);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventário";
            this.Load += new System.EventHandler(this.EditarInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.FlowLayoutPanel flowpanel_material;
        private System.Windows.Forms.PictureBox img_Add;
        private System.Windows.Forms.Button btn_Gravar;
    }
}