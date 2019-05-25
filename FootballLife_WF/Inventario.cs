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

            //=====================

            InvClube();

            InvSeniores();
        }

        private void InvClube()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeMaterial = "";
            string Quantidade = "";

            SqlDataReader dr;
            string Query = ("SELECT dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade FROM dbo.TblMaterial WHERE dbo.TblMaterial.FK_IDInventario = 1 ORDER BY dbo.TblMaterial.Nome");
            SqlCommand Command = new SqlCommand(Query, con);
            dr = Command.ExecuteReader();
            while (dr.Read())
            {
                NomeMaterial = dr["Nome"].ToString();
                Quantidade = dr["Quantidade"].ToString();

                Panel panel = new Panel();
                panel.Width = 310;
                panel.Height = 30;
                panel.Anchor = AnchorStyles.Top;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.BackColor = Color.Transparent;
                panel.Visible = true;
                flowpanel_Clube.Controls.Add(panel);

                Label Nome = new Label();
                Nome.Location = new Point(10, 5);
                Nome.Text = NomeMaterial += ":";
                Nome.Width = 210;
                Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Nome.Visible = true;
                panel.Controls.Add(Nome);

                Label lblQuantidade = new Label();
                lblQuantidade.Location = new Point(225, 5);
                lblQuantidade.Text = Quantidade;
                lblQuantidade.Width = 75;
                lblQuantidade.RightToLeft = RightToLeft.Yes;
                lblQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
                lblQuantidade.Anchor = AnchorStyles.Top;
                lblQuantidade.Visible = true;
                panel.Controls.Add(lblQuantidade);
            }
        }


        private void InvSeniores()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeMaterial = "";
            string Quantidade = "";

            SqlDataReader dr;
            string Query = ("SELECT dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade FROM dbo.TblMaterial WHERE dbo.TblMaterial.FK_IDInventario = 2 ORDER BY dbo.TblMaterial.Nome");
            SqlCommand Command = new SqlCommand(Query, con);
            dr = Command.ExecuteReader();
            while (dr.Read())
            {
                NomeMaterial = dr["Nome"].ToString();
                Quantidade = dr["Quantidade"].ToString();

                Panel panel = new Panel();
                panel.Width = 300;
                panel.Height = 30;
                panel.Anchor = AnchorStyles.Top;
                panel.BackColor = Color.Transparent;
                panel.Visible = true;
                flowpanel_seniores.Controls.Add(panel);

                Label Nome = new Label();
                Nome.Location = new Point(10, 5);
                Nome.Text = NomeMaterial += ":";
                Nome.Width = 200;
                Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Nome.Visible = true;
                panel.Controls.Add(Nome);

                Label lblQuantidade = new Label();
                lblQuantidade.Location = new Point(215, 5);
                lblQuantidade.Text = Quantidade;
                lblQuantidade.Width = 75;
                lblQuantidade.RightToLeft = RightToLeft.Yes;
                lblQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
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

