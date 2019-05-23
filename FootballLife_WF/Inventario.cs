using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FootballLife_WF
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();


            for (int i = 0; i < 20; i++)
            {
                Panel panel = new Panel();
                panel.Width = 300;
                panel.Height = 30;
                panel.Anchor = AnchorStyles.Top;
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.BackColor = Color.Transparent;
                panel.Visible = true;
                flowpanel_Clube.Controls.Add(panel);

                Label Nome = new Label();
                Nome.Location = new Point(10, 5);
                Nome.Text = "Nome material:";
                //Nome.Width = AutoSize.ToString;
                Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Nome.Visible = true;
                panel.Controls.Add(Nome);

                Label lblQuantidade = new Label();
                lblQuantidade.Location = new Point(160, 5);
                lblQuantidade.Text = "1000";
                lblQuantidade.Width = 300;
                lblQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
                lblQuantidade.Anchor = AnchorStyles.Top;
                lblQuantidade.Visible = true;
                panel.Controls.Add(lblQuantidade);
            }
            
        }

        private void InvClube()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeMaterial = "";
            string Quantidade = "";

            SqlDataReader dr;
            string Query = ("SELECT dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade FROM dbo.TblMaterial WHERE dbo.TblInventario.IDInventario = 1 ORDER BY dbo.TblMaterial.Nome");
            SqlCommand Command = new SqlCommand(Query, con);
            dr = Command.ExecuteReader();
            while (dr.Read())
            {
                NomeMaterial = dr["Nome"].ToString();
                Quantidade = dr["Quantidade"].ToString();

                Panel panel = new Panel();
                panel.Width = 650;
                panel.Height = 40;
                panel.Anchor = AnchorStyles.Top;
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.BackColor = Color.Transparent;
                panel.Visible = true;
                flowpanel_Clube.Controls.Add(panel);

                Label Nome = new Label();
                Nome.Location = new Point(10, 6);
                Nome.Text = NomeMaterial += ":";
                Nome.Width = 145;
                Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Nome.Visible = true;
                panel.Controls.Add(Nome);

                Label lblQuantidade = new Label();
                lblQuantidade.Location = new Point(425, 6);
                lblQuantidade.Text = Quantidade;
                lblQuantidade.Width = 100;
                lblQuantidade.Font = new Font("Arial", 11, FontStyle.Regular);
                lblQuantidade.Anchor = AnchorStyles.Top;
                lblQuantidade.Visible = true;
                panel.Controls.Add(lblQuantidade);
            }
        }

        //==============================================================================================

        private void Img_Menu_Click(object sender, EventArgs e)
        {
            if (panel_Menu.Visible == true)
            {
                panel_Menu.Visible = false;
            }
            else
            {
                panel_Menu.Visible = true;
            }
        }

//==============================================================================================

        private void NovaDiscussao_Hover()
        {
            lbl_Novadiscussao.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Underline);
        }

        private void Lbl_Novadiscussao_MouseHover(object sender, EventArgs e)
        {
            NovaDiscussao_Hover();
        }

        private void Img_NovaDiscussao_MouseHover(object sender, EventArgs e)
        {
            NovaDiscussao_Hover();
        }

        private void Btn_NovaDiscussao_MouseHover(object sender, EventArgs e)
        {
            NovaDiscussao_Hover();
        }

        //============

        private void NovaDiscussao_Leave()
        {
            lbl_Novadiscussao.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Regular);
        }

        private void Lbl_Novadiscussao_MouseLeave(object sender, EventArgs e)
        {
            NovaDiscussao_Leave();
        }
        private void Img_NovaDiscussao_MouseLeave(object sender, EventArgs e)
        {
            NovaDiscussao_Leave();
        }
        private void Btn_NovaDiscussao_MouseLeave(object sender, EventArgs e)
        {
            NovaDiscussao_Leave();
        }

        //==============================================================================================
        

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            PaginaInicial PgInicio = new PaginaInicial();
            this.Hide();
            PgInicio.ShowDialog();
            this.Dispose();
        }

        private void Btn_NovaDiscussao_Click(object sender, EventArgs e)
        {
            EditarInventario Editar = new EditarInventario();
            Editar.Show();
        }
    }
}

