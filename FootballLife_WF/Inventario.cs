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
            InvJuniores();
            InvJuvenis();
            InvIniciados();
            InvInfantis();
            InvBenjamins();
            InvTraquinas();
            InvPetizes();
        }

        private void InvClube()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDMaterial = "";
            string NomeMaterial = "";
            string Quantidade = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblMaterial.IDMaterial, dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade FROM dbo.TblMaterial WHERE dbo.TblMaterial.FK_IDInventario = 1 ORDER BY dbo.TblMaterial.Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    IDMaterial = dr["IDMaterial"].ToString();
                    NomeMaterial = dr["Nome"].ToString();
                    Quantidade = dr["Quantidade"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 310;
                    panel.Height = 30;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    panel.Tag = IDMaterial;
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
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }


        private void InvSeniores()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeMaterial = "";
            string Quantidade = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade FROM dbo.TblMaterial WHERE dbo.TblMaterial.FK_IDInventario = 2 ORDER BY dbo.TblMaterial.Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    NomeMaterial = dr["Nome"].ToString();
                    Quantidade = dr["Quantidade"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 285;
                    panel.Height = 30;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    flowpanel_seniores.Controls.Add(panel);

                    Label Nome = new Label();
                    Nome.Location = new Point(5, 5);
                    Nome.Text = NomeMaterial += ":";
                    Nome.Width = 210;
                    Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                    Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Nome.Visible = true;
                    panel.Controls.Add(Nome);

                    Label lblQuantidade = new Label();
                    lblQuantidade.Location = new Point(220, 5);
                    lblQuantidade.Text = Quantidade;
                    lblQuantidade.Width = 60;
                    lblQuantidade.RightToLeft = RightToLeft.Yes;
                    lblQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
                    lblQuantidade.Anchor = AnchorStyles.Top;
                    lblQuantidade.Visible = true;
                    panel.Controls.Add(lblQuantidade);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();

        }

        private void InvJuniores()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeMaterial = "";
            string Quantidade = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade FROM dbo.TblMaterial WHERE dbo.TblMaterial.FK_IDInventario = 3 ORDER BY dbo.TblMaterial.Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    NomeMaterial = dr["Nome"].ToString();
                    Quantidade = dr["Quantidade"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 285;
                    panel.Height = 30;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    flowpanel_Juniores.Controls.Add(panel);

                    Label Nome = new Label();
                    Nome.Location = new Point(5, 5);
                    Nome.Text = NomeMaterial += ":";
                    Nome.Width = 210;
                    Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                    Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Nome.Visible = true;
                    panel.Controls.Add(Nome);

                    Label lblQuantidade = new Label();
                    lblQuantidade.Location = new Point(220, 5);
                    lblQuantidade.Text = Quantidade;
                    lblQuantidade.Width = 60;
                    lblQuantidade.RightToLeft = RightToLeft.Yes;
                    lblQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
                    lblQuantidade.Anchor = AnchorStyles.Top;
                    lblQuantidade.Visible = true;
                    panel.Controls.Add(lblQuantidade);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();

        }

        private void InvJuvenis()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeMaterial = "";
            string Quantidade = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade FROM dbo.TblMaterial WHERE dbo.TblMaterial.FK_IDInventario = 4 ORDER BY dbo.TblMaterial.Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    NomeMaterial = dr["Nome"].ToString();
                    Quantidade = dr["Quantidade"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 285;
                    panel.Height = 30;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    flowpanel_Juvenis.Controls.Add(panel);

                    Label Nome = new Label();
                    Nome.Location = new Point(5, 5);
                    Nome.Text = NomeMaterial += ":";
                    Nome.Width = 210;
                    Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                    Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Nome.Visible = true;
                    panel.Controls.Add(Nome);

                    Label lblQuantidade = new Label();
                    lblQuantidade.Location = new Point(220, 5);
                    lblQuantidade.Text = Quantidade;
                    lblQuantidade.Width = 60;
                    lblQuantidade.RightToLeft = RightToLeft.Yes;
                    lblQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
                    lblQuantidade.Anchor = AnchorStyles.Top;
                    lblQuantidade.Visible = true;
                    panel.Controls.Add(lblQuantidade);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();

        }

        private void InvIniciados()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeMaterial = "";
            string Quantidade = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade FROM dbo.TblMaterial WHERE dbo.TblMaterial.FK_IDInventario = 5 ORDER BY dbo.TblMaterial.Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    NomeMaterial = dr["Nome"].ToString();
                    Quantidade = dr["Quantidade"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 285;
                    panel.Height = 30;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    flowpanel_Iniciados.Controls.Add(panel);

                    Label Nome = new Label();
                    Nome.Location = new Point(5, 5);
                    Nome.Text = NomeMaterial += ":";
                    Nome.Width = 210;
                    Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                    Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Nome.Visible = true;
                    panel.Controls.Add(Nome);

                    Label lblQuantidade = new Label();
                    lblQuantidade.Location = new Point(220, 5);
                    lblQuantidade.Text = Quantidade;
                    lblQuantidade.Width = 60;
                    lblQuantidade.RightToLeft = RightToLeft.Yes;
                    lblQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
                    lblQuantidade.Anchor = AnchorStyles.Top;
                    lblQuantidade.Visible = true;
                    panel.Controls.Add(lblQuantidade);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();

        }

        private void InvInfantis()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeMaterial = "";
            string Quantidade = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade FROM dbo.TblMaterial WHERE dbo.TblMaterial.FK_IDInventario = 6 ORDER BY dbo.TblMaterial.Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    NomeMaterial = dr["Nome"].ToString();
                    Quantidade = dr["Quantidade"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 285;
                    panel.Height = 30;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    flowpanel_Infantis.Controls.Add(panel);

                    Label Nome = new Label();
                    Nome.Location = new Point(5, 5);
                    Nome.Text = NomeMaterial += ":";
                    Nome.Width = 210;
                    Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                    Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Nome.Visible = true;
                    panel.Controls.Add(Nome);

                    Label lblQuantidade = new Label();
                    lblQuantidade.Location = new Point(220, 5);
                    lblQuantidade.Text = Quantidade;
                    lblQuantidade.Width = 60;
                    lblQuantidade.RightToLeft = RightToLeft.Yes;
                    lblQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
                    lblQuantidade.Anchor = AnchorStyles.Top;
                    lblQuantidade.Visible = true;
                    panel.Controls.Add(lblQuantidade);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();

        }

        private void InvBenjamins()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeMaterial = "";
            string Quantidade = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade FROM dbo.TblMaterial WHERE dbo.TblMaterial.FK_IDInventario = 7 ORDER BY dbo.TblMaterial.Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    NomeMaterial = dr["Nome"].ToString();
                    Quantidade = dr["Quantidade"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 285;
                    panel.Height = 30;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    flowpanel_Benjamins.Controls.Add(panel);

                    Label Nome = new Label();
                    Nome.Location = new Point(5, 5);
                    Nome.Text = NomeMaterial += ":";
                    Nome.Width = 210;
                    Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                    Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Nome.Visible = true;
                    panel.Controls.Add(Nome);

                    Label lblQuantidade = new Label();
                    lblQuantidade.Location = new Point(220, 5);
                    lblQuantidade.Text = Quantidade;
                    lblQuantidade.Width = 60;
                    lblQuantidade.RightToLeft = RightToLeft.Yes;
                    lblQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
                    lblQuantidade.Anchor = AnchorStyles.Top;
                    lblQuantidade.Visible = true;
                    panel.Controls.Add(lblQuantidade);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();

        }

        private void InvTraquinas()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeMaterial = "";
            string Quantidade = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade FROM dbo.TblMaterial WHERE dbo.TblMaterial.FK_IDInventario = 8 ORDER BY dbo.TblMaterial.Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    NomeMaterial = dr["Nome"].ToString();
                    Quantidade = dr["Quantidade"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 285;
                    panel.Height = 30;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    flowpanel_Traquinas.Controls.Add(panel);

                    Label Nome = new Label();
                    Nome.Location = new Point(5, 5);
                    Nome.Text = NomeMaterial += ":";
                    Nome.Width = 210;
                    Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                    Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Nome.Visible = true;
                    panel.Controls.Add(Nome);

                    Label lblQuantidade = new Label();
                    lblQuantidade.Location = new Point(220, 5);
                    lblQuantidade.Text = Quantidade;
                    lblQuantidade.Width = 60;
                    lblQuantidade.RightToLeft = RightToLeft.Yes;
                    lblQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
                    lblQuantidade.Anchor = AnchorStyles.Top;
                    lblQuantidade.Visible = true;
                    panel.Controls.Add(lblQuantidade);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();

        }

        private void InvPetizes()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeMaterial = "";
            string Quantidade = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade FROM dbo.TblMaterial WHERE dbo.TblMaterial.FK_IDInventario = 9 ORDER BY dbo.TblMaterial.Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    NomeMaterial = dr["Nome"].ToString();
                    Quantidade = dr["Quantidade"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 285;
                    panel.Height = 30;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    flowpanel_Petizes.Controls.Add(panel);

                    Label Nome = new Label();
                    Nome.Location = new Point(5, 5);
                    Nome.Text = NomeMaterial += ":";
                    Nome.Width = 210;
                    Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                    Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Nome.Visible = true;
                    panel.Controls.Add(Nome);

                    Label lblQuantidade = new Label();
                    lblQuantidade.Location = new Point(220, 5);
                    lblQuantidade.Text = Quantidade;
                    lblQuantidade.Width = 60;
                    lblQuantidade.RightToLeft = RightToLeft.Yes;
                    lblQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
                    lblQuantidade.Anchor = AnchorStyles.Top;
                    lblQuantidade.Visible = true;
                    panel.Controls.Add(lblQuantidade);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();

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

        private void Btn_EditarInventario_Click(object sender, EventArgs e)
        {
            EditarInventario Editar = new EditarInventario();
            Editar.Show();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            PaginaInicial_Admin PgAdmin = new PaginaInicial_Admin();
            this.Hide();
            PgAdmin.ShowDialog();
            this.Dispose();
        }

        private void Btn_Jogos_Click(object sender, EventArgs e)
        {
            PaginaInicial_Admin PgAdmin = new PaginaInicial_Admin();
            this.Hide();
            PgAdmin.ShowDialog();
            this.Dispose();
        }

        private void Btn_Equipas_Click(object sender, EventArgs e)
        {
            PaginaInicial_Admin PgAdmin = new PaginaInicial_Admin();
            this.Hide();
            PgAdmin.ShowDialog();
            this.Dispose();
        }

        private void Btn_Estadio_Click(object sender, EventArgs e)
        {
            Estadio Estadio = new Estadio();
            this.Hide();
            Estadio.ShowDialog();
            this.Dispose();
        }

        private void Btn_Titulos_Click(object sender, EventArgs e)
        {
             
        }

        private void Btn_Financiamento_Click(object sender, EventArgs e)
        {
            Financiamento Financas = new Financiamento();
            this.Hide();
            Financas.ShowDialog();
            this.Dispose();
        }

        private void Btn_Utilizadores_Click(object sender, EventArgs e)
        {
            Utilizadores Users = new Utilizadores();
            this.Hide();
            Users.ShowDialog();
            this.Dispose();
        }
    }
}

