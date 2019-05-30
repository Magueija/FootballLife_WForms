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
    public partial class Utilizadores_Admin : Form
    {
        public Utilizadores_Admin()
        {
            InitializeComponent();
        }

        private void PaginaInicial_Admin_Load(object sender, EventArgs e)
        {
            Admins();
            Treinadores();
            Atletas();
            Socios();

            if(flowpanel_Admins.Controls.Count == 0)
            {
                lbl_Admins.Visible = false;
                linha_Admins.Visible = false;
                flowpanel_Admins.Visible = false;

                lbl_Treinadores.Location = new Point(129, 271);
                linha_Treinadores.Location = new Point(132, 275);
                flowpanel_Treinadores.Location = new Point(119, 313);

                lbl_Atletas.Location = new Point(129, 485);
                linha_Atletas.Location = new Point(132, 493);
                flowpanel_Atletas.Location = new Point(119, 526);

                lbl_Socios.Location = new Point(129, 702);
                linha_Socios.Location = new Point(132, 711);
                flowpanel_Socios.Location = new Point(119, 749);

                lbl_espaco.Location = new Point(129, 921);
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
            lbl_NovoUser.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Underline);
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
            lbl_NovoUser.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Regular);
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
        private void Admins()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDAdmin = "";
            string NomeAdmin = "";

            SqlDataReader dr;
            string Query = ("SELECT IDAdministrador, Nome FROM dbo.TblAdministrador WHERE(Apagado = 0)");
            SqlCommand Command = new SqlCommand(Query, con);
            dr = Command.ExecuteReader();

            while (dr.Read())
            {
                IDAdmin = dr["IDAdministrador"].ToString();
                NomeAdmin = dr["Nome"].ToString();

                Panel panel = new Panel();
                panel.Width = 230;
                panel.Height = 50;
                panel.Anchor = AnchorStyles.Top;
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.BackColor = Color.White;
                panel.Visible = true;
                panel.Name = "Panel" + IDAdmin;
                panel.Margin = new Padding(20, 5, 0, 0);
                flowpanel_Admins.Controls.Add(panel);

                PictureBox Pb = new PictureBox();
                Pb.Location = new Point(10, 5);
                Pb.Width = 35;
                Pb.Height = 35;
                Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Pb.Image = FootballLife_WF.Properties.Resources.LogoAdmin;
                Pb.SizeMode = PictureBoxSizeMode.Zoom;
                Pb.Visible = true;
                panel.Controls.Add(Pb);

                PictureBox Pbdelete = new PictureBox();
                Pbdelete.Location = new Point(205, 5);
                Pbdelete.Width = 15;
                Pbdelete.Height = 15;
                Pbdelete.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Pbdelete.Image = FootballLife_WF.Properties.Resources.Delete;
                Pbdelete.SizeMode = PictureBoxSizeMode.Zoom;
                Pbdelete.Cursor = Cursors.Hand;
                Pbdelete.Tag = IDAdmin;
                Pbdelete.Name = "Btn_Delete";
                Pbdelete.Visible = true;

                Pbdelete.Click += Btn_DeleteAdmin_Click;
                panel.Controls.Add(Pbdelete);

                Label lblUser = new Label();
                lblUser.Location = new Point(50, 15);
                lblUser.Text = NomeAdmin;
                lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                lblUser.Visible = true;
                lblUser.Width = 150;
                panel.Controls.Add(lblUser);

                if(Properties.Settings.Default.FuncaoUser == "Admin" && Properties.Settings.Default.IDUser == Convert.ToInt32(IDAdmin))
                {
                    Pbdelete.Visible = false;
                }
                else
                {
                    Pbdelete.Visible = true;
                }
            }
            dr.Close();
            
            con.Close();
        }

        private void Btn_DeleteAdmin_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Tem a certeza que pretente eliminar este utilizador?", "ATENÇÃO!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
                con.Open();

                string IDAdmin = "";

                try
                {
                    string Query = "UPDATE TblAdministador SET Apagado = 1 WHERE IDAdministrador = @IDAdmin";

                    PictureBox PbDELETE = (PictureBox)sender;
                    IDAdmin = PbDELETE.Tag.ToString();
                    SqlCommand Command = new SqlCommand(Query, con);
                    Command.Parameters.AddWithValue("@IDAdmin", IDAdmin);
                    Command.ExecuteNonQuery();

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                con.Close();

                foreach (Control c in flowpanel_Admins.Controls)
                {
                    if (c.Name == "Panel" + IDAdmin)
                    {
                        flowpanel_Admins.Controls.Remove(c);
                    }
                }
            }
        }

        //======
        private void Treinadores()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDTreinador = "";
            string NomeTreinador = "";

            SqlDataReader dr;
            string Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0)");
            SqlCommand Command = new SqlCommand(Query, con);
            dr = Command.ExecuteReader();

            while (dr.Read())
            {
                IDTreinador = dr["IDTreinador"].ToString();
                NomeTreinador = dr["Nome"].ToString();

                Panel panel = new Panel();
                panel.Width = 230;
                panel.Height = 50;
                panel.Anchor = AnchorStyles.Top;
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.BackColor = Color.White;
                panel.Visible = true;
                panel.Name = "Panel" + IDTreinador;
                panel.Margin = new Padding(20, 5, 0, 0);
                flowpanel_Treinadores.Controls.Add(panel);

                PictureBox Pb = new PictureBox();
                Pb.Location = new Point(10, 5);
                Pb.Width = 35;
                Pb.Height = 35;
                Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Pb.Image = FootballLife_WF.Properties.Resources.LogoTreinador;
                Pb.SizeMode = PictureBoxSizeMode.Zoom;
                Pb.Visible = true;
                panel.Controls.Add(Pb);

                PictureBox Pbdelete = new PictureBox();
                Pbdelete.Location = new Point(205, 5);
                Pbdelete.Width = 15;
                Pbdelete.Height = 15;
                Pbdelete.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Pbdelete.Image = FootballLife_WF.Properties.Resources.Delete;
                Pbdelete.SizeMode = PictureBoxSizeMode.Zoom;
                Pbdelete.Cursor = Cursors.Hand;
                Pbdelete.Tag = IDTreinador;
                Pbdelete.Name = "Btn_Delete";

                Pbdelete.Click += Btn_DeleteTreinador_Click;
                panel.Controls.Add(Pbdelete);

                Label lblUser = new Label();
                lblUser.Location = new Point(50, 15);
                lblUser.Text = NomeTreinador;
                lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                lblUser.Visible = true;
                lblUser.Width = 150;
                panel.Controls.Add(lblUser);

                if (Properties.Settings.Default.FuncaoUser == "Treinador" && Properties.Settings.Default.IDUser == Convert.ToInt32(IDTreinador))
                {
                    Pbdelete.Visible = false;
                }
                else
                {
                    Pbdelete.Visible = true;
                }
            }
            dr.Close();

            con.Close();
        }

        private void Btn_DeleteTreinador_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Tem a certeza que pretente eliminar este utilizador?", "ATENÇÃO!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
                con.Open();

                string IDTreinador = "";

                try
                {
                    string Query = "UPDATE TblTreinador SET Apagado = 1 WHERE IDTreinador = @IDTreinador";

                    PictureBox PbDELETE = (PictureBox)sender;
                    IDTreinador = PbDELETE.Tag.ToString();
                    SqlCommand Command = new SqlCommand(Query, con);
                    Command.Parameters.AddWithValue("@IDTreinador", IDTreinador);
                    Command.ExecuteNonQuery();

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                con.Close();

                foreach (Control c in flowpanel_Treinadores.Controls)
                {
                    if (c.Name == "Panel" + IDTreinador)
                    {
                        flowpanel_Treinadores.Controls.Remove(c);
                    }
                }
            }
        }

        //===

        private void Atletas()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDAtleta = "";
            string NomeAtleta = "";

            SqlDataReader dr;
            string Query = ("SELECT IDAtleta, Nome FROM dbo.TblAtleta WHERE(Apagado = 0)");
            SqlCommand Command = new SqlCommand(Query, con);
            dr = Command.ExecuteReader();

            while (dr.Read())
            {
                IDAtleta = dr["IDAtleta"].ToString();
                NomeAtleta = dr["Nome"].ToString();

                Panel panel = new Panel();
                panel.Width = 230;
                panel.Height = 50;
                panel.Anchor = AnchorStyles.Top;
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.BackColor = Color.White;
                panel.Visible = true;
                panel.Name = "Panel" + IDAtleta;
                panel.Margin = new Padding(20, 5, 0, 0);
                flowpanel_Atletas.Controls.Add(panel);

                PictureBox Pb = new PictureBox();
                Pb.Location = new Point(10, 5);
                Pb.Width = 35;
                Pb.Height = 35;
                Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Pb.Image = FootballLife_WF.Properties.Resources.LogoAtleta;
                Pb.SizeMode = PictureBoxSizeMode.Zoom;
                Pb.Visible = true;
                panel.Controls.Add(Pb);

                PictureBox Pbdelete = new PictureBox();
                Pbdelete.Location = new Point(205, 5);
                Pbdelete.Width = 15;
                Pbdelete.Height = 15;
                Pbdelete.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Pbdelete.Image = FootballLife_WF.Properties.Resources.Delete;
                Pbdelete.SizeMode = PictureBoxSizeMode.Zoom;
                Pbdelete.Cursor = Cursors.Hand;
                Pbdelete.Tag = IDAtleta;
                Pbdelete.Name = "Btn_Delete";
                Pbdelete.Visible = true;

                Pbdelete.Click += Btn_DeleteAtleta_Click;
                panel.Controls.Add(Pbdelete);

                Label lblUser = new Label();
                lblUser.Location = new Point(50, 15);
                lblUser.Text = NomeAtleta;
                lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                lblUser.Visible = true;
                lblUser.Width = 150;
                panel.Controls.Add(lblUser);

                if (Properties.Settings.Default.FuncaoUser == "Atleta" && Properties.Settings.Default.IDUser == Convert.ToInt32(IDAtleta))
                {
                    Pbdelete.Visible = false;
                }
                else
                {
                    Pbdelete.Visible = true;
                }
            }
            dr.Close();

            con.Close();
        }

        private void Btn_DeleteAtleta_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Tem a certeza que pretente eliminar este utilizador?", "ATENÇÃO!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
                con.Open();

                string IDAtleta = "";

                try
                {
                    string Query = "UPDATE TblAtleta SET Apagado = 1 WHERE IDAtleta = @IDAtleta";

                    PictureBox PbDELETE = (PictureBox)sender;
                    IDAtleta = PbDELETE.Tag.ToString();
                    SqlCommand Command = new SqlCommand(Query, con);
                    Command.Parameters.AddWithValue("@IDAtleta", IDAtleta);
                    Command.ExecuteNonQuery();

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                con.Close();

                foreach (Control c in flowpanel_Atletas.Controls)
                {
                    if (c.Name == "Panel" + IDAtleta)
                    {
                        flowpanel_Atletas.Controls.Remove(c);
                    }
                }
            }
        }

        //===

        private void Socios()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDSocio = "";
            string NomeSocio = "";

            SqlDataReader dr;
            string Query = ("SELECT IDSocio, Nome FROM dbo.TblSocio WHERE(Apagado = 0)");
            SqlCommand Command = new SqlCommand(Query, con);
            dr = Command.ExecuteReader();

            while (dr.Read())
            {
                IDSocio = dr["IDSocio"].ToString();
                NomeSocio = dr["Nome"].ToString();

                Panel panel = new Panel();
                panel.Width = 230;
                panel.Height = 50;
                panel.Anchor = AnchorStyles.Top;
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.BackColor = Color.White;
                panel.Visible = true;
                panel.Name = "Panel" + IDSocio;
                panel.Margin = new Padding(20, 5, 0, 0);
                flowpanel_Socios.Controls.Add(panel);

                PictureBox Pb = new PictureBox();
                Pb.Location = new Point(10, 5);
                Pb.Width = 35;
                Pb.Height = 35;
                Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Pb.Image = FootballLife_WF.Properties.Resources.LogoSocio;
                Pb.SizeMode = PictureBoxSizeMode.Zoom;
                Pb.Visible = true;
                panel.Controls.Add(Pb);

                PictureBox Pbdelete = new PictureBox();
                Pbdelete.Location = new Point(205, 5);
                Pbdelete.Width = 15;
                Pbdelete.Height = 15;
                Pbdelete.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Pbdelete.Image = FootballLife_WF.Properties.Resources.Delete;
                Pbdelete.SizeMode = PictureBoxSizeMode.Zoom;
                Pbdelete.Cursor = Cursors.Hand;
                Pbdelete.Tag = IDSocio;
                Pbdelete.Name = "Btn_Delete";
                Pbdelete.Visible = true;

                Pbdelete.Click += Btn_DeleteSocio_Click;
                panel.Controls.Add(Pbdelete);

                Label lblUser = new Label();
                lblUser.Location = new Point(50, 15);
                lblUser.Text = NomeSocio;
                lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                lblUser.Visible = true;
                lblUser.Width = 150;
                panel.Controls.Add(lblUser);

                if (Properties.Settings.Default.FuncaoUser == "Socio" && Properties.Settings.Default.IDUser == Convert.ToInt32(IDSocio))
                {
                    Pbdelete.Visible = false;
                }
                else
                {
                    Pbdelete.Visible = true;
                }
            }
            dr.Close();

            con.Close();
        }

        private void Btn_DeleteSocio_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Tem a certeza que pretente eliminar este utilizador?", "ATENÇÃO!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
                con.Open();

                string IDSocio = "";

                try
                {
                    string Query = "UPDATE TblSocio SET Apagado = 1 WHERE IDSocio = @IDSocio";

                    PictureBox PbDELETE = (PictureBox)sender;
                    IDSocio = PbDELETE.Tag.ToString();
                    SqlCommand Command = new SqlCommand(Query, con);
                    Command.Parameters.AddWithValue("@IDTreinador", IDSocio);
                    Command.ExecuteNonQuery();

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                con.Close();

                foreach (Control c in flowpanel_Socios.Controls)
                {
                    if (c.Name == "Panel" + IDSocio)
                    {
                        flowpanel_Socios.Controls.Remove(c);
                    }
                }
            }
        }

        //===========================================================================

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            PaginaInicial PgInicio = new PaginaInicial();
            this.Hide();
            PgInicio.ShowDialog();
            this.Dispose();
        }

        private void Btn_NovoUtilizador_Click(object sender, EventArgs e)
        {
            AdicionarUtilizador NewUser = new AdicionarUtilizador();
            NewUser.Show();
        }
    }
}

