namespace FootballLife_WF
{
    partial class ContactosAdministracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactosAdministracao));
            this.flowpanel_Emails = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Contactos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowpanel_Emails
            // 
            this.flowpanel_Emails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanel_Emails.Location = new System.Drawing.Point(0, 66);
            this.flowpanel_Emails.Name = "flowpanel_Emails";
            this.flowpanel_Emails.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.flowpanel_Emails.Size = new System.Drawing.Size(497, 364);
            this.flowpanel_Emails.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Contactos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 66);
            this.panel1.TabIndex = 1;
            // 
            // lbl_Contactos
            // 
            this.lbl_Contactos.AutoSize = true;
            this.lbl_Contactos.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contactos.Location = new System.Drawing.Point(198, 25);
            this.lbl_Contactos.Name = "lbl_Contactos";
            this.lbl_Contactos.Size = new System.Drawing.Size(106, 21);
            this.lbl_Contactos.TabIndex = 3;
            this.lbl_Contactos.Text = "Contactos";
            // 
            // ContactosAdministracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 430);
            this.Controls.Add(this.flowpanel_Emails);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactosAdministracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administração";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowpanel_Emails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Contactos;
    }
}