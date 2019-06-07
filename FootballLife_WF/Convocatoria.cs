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
    public partial class Convocatoria : Form
    {
        public Convocatoria()
        {
            InitializeComponent();
        }

        private void Convocatoria_Load(object sender, EventArgs e)
        {
            DadosConvocatoria();
            Titulares();
            Suplentes();
            NaoConvocados();
        }

        string Tatica = "";
        private void DadosConvocatoria()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string DataJogo = "";
            string Adversario = "";
            

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblConvocatoria.IDConvocatoria, dbo.TblConvocatoria.DataJogo, dbo.TblConvocatoria.Adversario, dbo.TblTatica.Tatica FROM dbo.TblConvocatoria INNER JOIN dbo.TblTatica ON dbo.TblConvocatoria.FK_IDTatica = dbo.TblTatica.IDTatica WHERE dbo.TblConvocatoria.FK_IDEscalao = " + Properties.Settings.Default.IDEscalao);
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    DataJogo = dr["DataJogo"].ToString();
                    Adversario = dr["Adversario"].ToString();
                    Tatica = dr["Tatica"].ToString();
                }
                dr.Close();

                lbl_Data.Text = DataJogo;
                lbl_Adversario.Text = Adversario;
                lbl_Tatica.Text = Tatica;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void Titulares()
        {
            flowpanel_Titulares.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDAtleta = "";
            string Nome = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblAtleta.IDAtleta, dbo.TblAtleta.Nome FROM dbo.TblTitular INNER JOIN dbo.TblAtleta ON dbo.TblTitular.FK_IDAtleta = dbo.TblAtleta.IDAtleta INNER JOIN " +
                    "dbo.TblConvocatoria ON dbo.TblTitular.FK_IDConvocatoria = dbo.TblConvocatoria.IDConvocatoria WHERE dbo.TblConvocatoria.FK_IDEscalao = " + Properties.Settings.Default.IDEscalao);
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                int i = 1;

                while (dr.Read())
                {
                    IDAtleta = dr["IDAtleta"].ToString();
                    Nome = dr["Nome"].ToString();


                    Panel panel = new Panel();
                    panel.Width = 250;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BorderStyle = BorderStyle.Fixed3D;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = i.ToString();
                    panel.Margin = new Padding(10, 0, 0, 0);
                    flowpanel_Titulares.Controls.Add(panel);
                   
                    Label posicao = new Label();
                    posicao.Location = new Point(5, 15);
                    posicao.Width = 45;
                    posicao.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    posicao.RightToLeft = RightToLeft.Yes;
                    posicao.Font = new Font("Cooper Black", 11);
                    posicao.Visible = true;
                    posicao.Name = "Posicao" + i;
                    posicao.Tag = IDAtleta;
                    panel.Controls.Add(posicao);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(55, 15);
                    lblUser.Text = Nome;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 170;
                    lblUser.Name = "Admin";
                    lblUser.Tag = IDAtleta;
                    panel.Controls.Add(lblUser);

                    i++;
                }
                dr.Close();

                if(Tatica == "4-5-1")
                {
                    for (int ctr = 0; ctr < flowpanel_Titulares.Controls.Count; ctr++)
                    {
                        foreach (Control c in flowpanel_Titulares.Controls[ctr].Controls)
                        {
                            if (c.Name == "Posicao1")
                            {
                                c.Text = "GR";
                                c.ForeColor = Color.ForestGreen;
                            }
                            else if (c.Name == "Posicao2")
                            {
                                c.Text = "DC";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao3")
                            {
                                c.Text = "DC";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao4")
                            {
                                c.Text = "DE";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao5")
                            {
                                c.Text = "DD";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao6")
                            {
                                c.Text = "MDC";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao7")
                            {
                                c.Text = "MC";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao8")
                            {
                                c.Text = "MC";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao9")
                            {
                                c.Text = "MOE";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao10")
                            {
                                c.Text = "MOD";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao11")
                            {
                                c.Text = "PL";
                                c.ForeColor = Color.Firebrick;
                            }
                        }
                    }
                }
                else if (Tatica == "4-3-3")
                {
                    for (int ctr = 0; ctr < flowpanel_Titulares.Controls.Count; ctr++)
                    {
                        foreach (Control c in flowpanel_Titulares.Controls[ctr].Controls)
                        {
                            if (c.Name == "Posicao1")
                            {
                                c.Text = "GR";
                                c.ForeColor = Color.ForestGreen;
                            }
                            else if (c.Name == "Posicao2")
                            {
                                c.Text = "DC";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao3")
                            {
                                c.Text = "DC";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao4")
                            {
                                c.Text = "DE";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao5")
                            {
                                c.Text = "DD";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao6")
                            {
                                c.Text = "MDC";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao7")
                            {
                                c.Text = "MC";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao8")
                            {
                                c.Text = "MC";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao9")
                            {
                                c.Text = "PL";
                                c.ForeColor = Color.Firebrick;
                            }
                            else if (c.Name == "Posicao10")
                            {
                                c.Text = "EE";
                                c.ForeColor = Color.Firebrick;
                            }
                            else if (c.Name == "Posicao11")
                            {
                                c.Text = "ED";
                                c.ForeColor = Color.Firebrick;
                            }
                        }
                    }
                }
                else if (Tatica == "4-4-2")
                {
                    for (int ctr = 0; ctr < flowpanel_Titulares.Controls.Count; ctr++)
                    {
                        foreach (Control c in flowpanel_Titulares.Controls[ctr].Controls)
                        {
                            if (c.Name == "Posicao1")
                            {
                                c.Text = "GR";
                                c.ForeColor = Color.ForestGreen;
                            }
                            else if (c.Name == "Posicao2")
                            {
                                c.Text = "DC";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao3")
                            {
                                c.Text = "DC";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao4")
                            {
                                c.Text = "DE";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao5")
                            {
                                c.Text = "DD";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao6")
                            {
                                c.Text = "MC";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao7")
                            {
                                c.Text = "MC";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao8")
                            {
                                c.Text = "ME";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao9")
                            {
                                c.Text = "MD";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao10")
                            {
                                c.Text = "PL";
                                c.ForeColor = Color.Firebrick;
                            }
                            else if (c.Name == "Posicao11")
                            {
                                c.Text = "PL";
                                c.ForeColor = Color.Firebrick;
                            }
                        }
                    }
                }
                else if (Tatica == "3-5-2")
                {
                    for (int ctr = 0; ctr < flowpanel_Titulares.Controls.Count; ctr++)
                    {
                        foreach (Control c in flowpanel_Titulares.Controls[ctr].Controls)
                        {
                            if (c.Name == "Posicao1")
                            {
                                c.Text = "GR";
                                c.ForeColor = Color.ForestGreen;
                            }
                            else if (c.Name == "Posicao2")
                            {
                                c.Text = "DC";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao3")
                            {
                                c.Text = "DC";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao4")
                            {
                                c.Text = "DC";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao5")
                            {
                                c.Text = "MDC";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao6")
                            {
                                c.Text = "MC";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao7")
                            {
                                c.Text = "MC";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao8")
                            {
                                c.Text = "ME";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao9")
                            {
                                c.Text = "MD";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao10")
                            {
                                c.Text = "PL";
                                c.ForeColor = Color.Firebrick;
                            }
                            else if (c.Name == "Posicao11")
                            {
                                c.Text = "PL";
                                c.ForeColor = Color.Firebrick;
                            }
                        }
                    }
                }
                else if (Tatica == "3-4-3")
                {
                    for (int ctr = 0; ctr < flowpanel_Titulares.Controls.Count; ctr++)
                    {
                        foreach (Control c in flowpanel_Titulares.Controls[ctr].Controls)
                        {
                            if (c.Name == "Posicao1")
                            {
                                c.Text = "GR";
                                c.ForeColor = Color.ForestGreen;
                            }
                            else if (c.Name == "Posicao2")
                            {
                                c.Text = "DC";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao3")
                            {
                                c.Text = "DC";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao4")
                            {
                                c.Text = "DC";
                                c.ForeColor = Color.DarkBlue;
                            }
                            else if (c.Name == "Posicao5")
                            {
                                c.Text = "MC";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao6")
                            {
                                c.Text = "MC";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao7")
                            {
                                c.Text = "ME";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao8")
                            {
                                c.Text = "MD";
                                c.ForeColor = Color.Gold;
                            }
                            else if (c.Name == "Posicao9")
                            {
                                c.Text = "PL";
                                c.ForeColor = Color.Firebrick;
                            }
                            else if (c.Name == "Posicao10")
                            {
                                c.Text = "EE";
                                c.ForeColor = Color.Firebrick;
                            }
                            else if (c.Name == "Posicao11")
                            {
                                c.Text = "ED";
                                c.ForeColor = Color.Firebrick;
                            }
                        }
                    }
                }



            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }


        private void Suplentes()
        {
            flowpanel_Suplentes.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDAtleta = "";
            string Nome = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblAtleta.IDAtleta, dbo.TblAtleta.Nome FROM dbo.TblSuplente INNER JOIN dbo.TblAtleta ON dbo.TblSuplente.FK_IDAtleta = dbo.TblAtleta.IDAtleta INNER JOIN " +
                    "dbo.TblConvocatoria ON dbo.TblSuplente.FK_IDConvocatoria = dbo.TblConvocatoria.IDConvocatoria WHERE dbo.TblConvocatoria.FK_IDEscalao = " + Properties.Settings.Default.IDEscalao);
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDAtleta = dr["IDAtleta"].ToString();
                    Nome = dr["Nome"].ToString();


                    Panel panel = new Panel();
                    panel.Width = 250;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BorderStyle = BorderStyle.Fixed3D;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Margin = new Padding(10, 0, 0, 0);
                    flowpanel_Suplentes.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(10, 5);
                    Pb.Width = 30;
                    Pb.Height = 35;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources._1Suplente;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(53, 15);
                    lblUser.Text = Nome;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 170;
                    lblUser.Name = "Admin";
                    lblUser.Tag = IDAtleta;
                    panel.Controls.Add(lblUser);
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void NaoConvocados()
        {
            flowpanel_NaoConv.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDAtleta = "";
            string Nome = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblAtleta.IDAtleta, dbo.TblAtleta.Nome FROM dbo.TblAtleta LEFT OUTER JOIN dbo.TblSuplente ON dbo.TblAtleta.IDAtleta = dbo.TblSuplente.FK_IDAtleta LEFT OUTER JOIN dbo.TblTitular" +
                    " ON dbo.TblAtleta.IDAtleta = dbo.TblTitular.FK_IDAtleta WHERE(dbo.TblTitular.FK_IDAtleta IS NULL) AND(dbo.TblSuplente.FK_IDAtleta IS NULL) AND(dbo.TblAtleta.FK_IDEscalao = " + Properties.Settings.Default.IDEscalao + " )");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDAtleta = dr["IDAtleta"].ToString();
                    Nome = dr["Nome"].ToString();


                    Panel panel = new Panel();
                    panel.Width = 250;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BorderStyle = BorderStyle.Fixed3D;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Margin = new Padding(10, 0, 0, 0);
                    flowpanel_NaoConv.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(10, 9);
                    Pb.Width = 30;
                    Pb.Height = 30;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.NaoConvocado2;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(53, 15);
                    lblUser.Text = Nome;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 170;
                    lblUser.Name = "Admin";
                    lblUser.Tag = IDAtleta;
                    panel.Controls.Add(lblUser);
                }
                dr.Close();
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

        private void NovaConvocatoria_MouseHover(object sender, EventArgs e)
        {
            lbl_NovaConvocatoria.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Underline);
        }
        private void NovaConvocatoria_MouseLeave(object sender, EventArgs e)
        {
            lbl_NovaConvocatoria.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Regular);
        }

//==============================================================================================

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            PaginaInicial PgInicio = new PaginaInicial();
            this.Hide();
            PgInicio.ShowDialog();
        }

        private void Btn_NovaDiscussao_Click(object sender, EventArgs e)
        {
            NovaDiscussão PgInicio = new NovaDiscussão();
            PgInicio.ShowDialog();
        }

        private void Btn_Utilizadores_Click(object sender, EventArgs e)
        {
            Utilizadores Users = new Utilizadores();
            this.Hide();
            Users.ShowDialog();
        }

        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            Inventario Inv = new Inventario();
            this.Hide();
            Inv.ShowDialog();
        }

        private void Btn_Financiamento_Click(object sender, EventArgs e)
        {
            Financiamento financas = new Financiamento();
            this.Hide();
            financas.ShowDialog();
        }

        private void Btn_Jogos_Click(object sender, EventArgs e)
        {
            Jogos jgs = new Jogos();
            this.Hide();
            jgs.ShowDialog();
        }

        private void Btn_Equipas_Click(object sender, EventArgs e)
        {
            Equipas Equipas = new Equipas();
            this.Hide();
            Equipas.ShowDialog();
        }

        private void Btn_Estadio_Click(object sender, EventArgs e)
        {
            Estadio Estadio = new Estadio();
            this.Hide();
            Estadio.ShowDialog();
        }

        private void Btn_Titulos_Click(object sender, EventArgs e)
        {

        }

        private void Btn_NovaConvocatoria_Click(object sender, EventArgs e)
        {
            NovaConvocatoria NvConv = new NovaConvocatoria();
            NvConv.ShowDialog();

            DadosConvocatoria();
            Titulares();
            Suplentes();
            NaoConvocados();
        }
    }
}

