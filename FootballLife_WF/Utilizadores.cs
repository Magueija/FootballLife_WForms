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
    public partial class Utilizadores : Form
    {
        public Utilizadores()
        {
            InitializeComponent();
        }

        private void PaginaInicial_Admin_Load(object sender, EventArgs e)
        {
            Admins();
            Treinadores();
            Atletas();
            Socios();
            CountUsers();

        }

        private void CountUsers()
        {
            if (flowpanel_Admins.Controls.Count == 0)
            {
                lbl_Admins.Visible = false;
                linha_Admins.Visible = false;
                flowpanel_Admins.Visible = false;
            }
            else if (flowpanel_Treinadores.Controls.Count == 0)
            {
                lbl_Treinadores.Visible = false;
                linha_Treinadores.Visible = false;
                flowpanel_Treinadores.Visible = false;
            }
            else if (flowpanel_Atletas.Controls.Count == 0)
            {
                lbl_Atletas.Visible = false;
                linha_Atletas.Visible = false;
                flowpanel_Atletas.Visible = false;
            }
            else if (flowpanel_Socios.Controls.Count == 0)
            {
                lbl_Socios.Visible = false;
                linha_Socios.Visible = false;
                flowpanel_Socios.Visible = false;
            }

            if (flowpanel_Admins.Visible == false)
            {
                lbl_espaco.Location = lbl_Socios.Location;

                lbl_Socios.Location = lbl_Atletas.Location;
                linha_Socios.Location = linha_Atletas.Location;
                flowpanel_Socios.Location = flowpanel_Atletas.Location;

                lbl_Atletas.Location = lbl_Treinadores.Location;
                linha_Atletas.Location = linha_Treinadores.Location;
                flowpanel_Atletas.Location = flowpanel_Treinadores.Location;

                lbl_Treinadores.Location = lbl_Admins.Location;
                linha_Treinadores.Location = linha_Admins.Location;
                flowpanel_Treinadores.Location = flowpanel_Admins.Location;
            }
            else if (flowpanel_Treinadores.Visible == false)
            {
                lbl_espaco.Location = lbl_Socios.Location;

                lbl_Socios.Location = lbl_Atletas.Location;
                linha_Socios.Location = linha_Atletas.Location;
                flowpanel_Socios.Location = flowpanel_Atletas.Location;

                lbl_Atletas.Location = lbl_Treinadores.Location;
                linha_Atletas.Location = linha_Treinadores.Location;
                flowpanel_Atletas.Location = flowpanel_Treinadores.Location;

            }
            else if (flowpanel_Atletas.Visible == false)
            {
                lbl_espaco.Location = lbl_Socios.Location;

                lbl_Socios.Location = lbl_Atletas.Location;
                linha_Socios.Location = linha_Atletas.Location;
                flowpanel_Socios.Location = flowpanel_Atletas.Location;
            }
            else if (flowpanel_Admins.Visible == false)
            {
                lbl_espaco.Location = lbl_Socios.Location;
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
            flowpanel_Admins.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDAdmin = "";
            string NomeAdmin = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT IDAdministrador, Nome FROM dbo.TblAdministrador WHERE(Apagado = 0) ORDER BY Nome");
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
                    Pb.Cursor = Cursors.Hand;
                    Pb.Visible = true;
                    Pb.Name = "Admin";
                    Pb.Tag = IDAdmin;
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
                    panel.Controls.Add(Pbdelete);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeAdmin;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 150;
                    lblUser.Cursor = Cursors.Hand;
                    lblUser.Name = "Admin";
                    lblUser.Tag = IDAdmin;
                    panel.Controls.Add(lblUser);


                    Pbdelete.Click += Btn_DeleteAdmin_Click;
                    Pb.Click += Btn_Pb_Click;
                    lblUser.Click += Btn_Lbl_Click;

                    if (Properties.Settings.Default.FuncaoUser == "Admin" && Properties.Settings.Default.IDUser == Convert.ToInt32(IDAdmin))
                    {
                        Pbdelete.Visible = false;
                    }
                    else
                    {
                        Pbdelete.Visible = true;
                    }
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
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
            flowpanel_Treinadores.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDTreinador = "";
            string NomeTreinador = "";

            SqlDataReader dr;
            string Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) ORDER BY Nome");
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
                Pb.Cursor = Cursors.Hand;
                Pb.Visible = true;
                Pb.Name = "Treinador";
                Pb.Tag = IDTreinador;
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
                Pbdelete.Visible = true;
                panel.Controls.Add(Pbdelete);

                Label lblUser = new Label();
                lblUser.Location = new Point(50, 15);
                lblUser.Text = NomeTreinador;
                lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                lblUser.Visible = true;
                lblUser.Width = 150;
                lblUser.Cursor = Cursors.Hand;
                lblUser.Name = "Treinador";
                lblUser.Tag = IDTreinador;
                panel.Controls.Add(lblUser);


                Pbdelete.Click += Btn_DeleteTreinador_Click;
                Pb.Click += Btn_Pb_Click;
                lblUser.Click += Btn_Lbl_Click;
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
            flowpanel_Atletas.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDAtleta = "";
            string NomeAtleta = "";

            SqlDataReader dr;
            string Query = ("SELECT IDAtleta, Nome FROM dbo.TblAtleta WHERE(Apagado = 0) ORDER BY Nome");
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
                Pb.Cursor = Cursors.Hand;
                Pb.Visible = true;
                Pb.Name = "Atleta";
                Pb.Tag = IDAtleta;
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
                panel.Controls.Add(Pbdelete);

                Label lblUser = new Label();
                lblUser.Location = new Point(50, 15);
                lblUser.Text = NomeAtleta;
                lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                lblUser.Visible = true;
                lblUser.Width = 150;
                lblUser.Cursor = Cursors.Hand;
                lblUser.Name = "Atleta";
                lblUser.Tag = IDAtleta;
                panel.Controls.Add(lblUser);

                Pbdelete.Click += Btn_DeleteAtleta_Click;
                Pb.Click += Btn_Pb_Click;
                lblUser.Click += Btn_Lbl_Click;
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
            flowpanel_Socios.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDSocio = "";
            string NomeSocio = "";

            SqlDataReader dr;
            string Query = ("SELECT IDSocio, Nome FROM dbo.TblSocio WHERE(Apagado = 0) ORDER BY Nome");
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
                Pb.Cursor = Cursors.Hand;
                Pb.Visible = true;
                Pb.Name = "Socio";
                Pb.Tag = IDSocio;
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
                panel.Controls.Add(Pbdelete);

                Label lblUser = new Label();
                lblUser.Location = new Point(50, 15);
                lblUser.Text = NomeSocio;
                lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                lblUser.Visible = true;
                lblUser.Width = 150;
                lblUser.Cursor = Cursors.Hand;
                lblUser.Name = "Socio";
                lblUser.Tag = IDSocio;
                panel.Controls.Add(lblUser);


                Pbdelete.Click += Btn_DeleteSocio_Click;
                Pb.Click += Btn_Pb_Click;
                lblUser.Click += Btn_Lbl_Click;
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
        private void Btn_Pb_Click(object sender, EventArgs e)
        {
            PictureBox Pb = (PictureBox)sender;
            string ID = Pb.Tag.ToString();
            string Funcao = Pb.Name.ToString();

            VisualizarUser(ID, Funcao);
        }

        private void Btn_Lbl_Click(object sender, EventArgs e)
        {
            Label Lbl = (Label)sender;
            string ID = Lbl.Tag.ToString();
            string Funcao = Lbl.Name.ToString();

            VisualizarUser(ID, Funcao);
        }

        private static void VisualizarUser(string ID, string Funcao)
        {
            EditarUtilizador verUser = new EditarUtilizador(ID, Funcao);
            verUser.Show();
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
            NewUser.ShowDialog();

            Admins();
            Treinadores();
            Atletas();
            Socios();
            CountUsers();
        }
    }
}

