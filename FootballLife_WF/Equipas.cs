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
    public partial class Equipas : Form
    {
        public Equipas()
        {
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);

            InitializeComponent();
        }

        //Verifica se é o current User ou se é um adepto
        private void Equipas_Load(object sender, EventArgs e)
        {
            Seniores();
            Juniores();
            Juvenis();
            Iniciados();
            Infantis();
            Benjamins();
            Traquinas();
            Petizes();

            if (Program.CurrentFuncaoUser == "Admin")
            {
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;

                btn1.Text = "FINANCIAMENTO";
                btn2.Text = "INVENTÁRIO";
                btn3.Text = "UTILIZADORES";
            }
            else if (Program.CurrentFuncaoUser == "Treinador")
            {
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;

                btn1.Text = "CONVOCATÓRIA";
                btn2.Text = "INVENTÁRIO";
                btn3.Text = "CONTACTOS";
            }
            else if (Program.CurrentFuncaoUser == "Atleta")
            {
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;

                btn1.Text = "CONVOCATÓRIA";
                btn2.Text = "COTA DE ATLETA";
                btn3.Text = "CONTACTOS";
            }
            else if (Program.CurrentFuncaoUser == "Socio")
            {
                btn1.Visible = true;
                btn2.Visible = true;

                btn1.Text = "COTA DE SÓCIO";
                btn2.Text = "CONTACTOS";
            }

            if (Program.CurrentFuncaoUser != "")
            {
                btn_LogOut.Visible = true;
                img_LogOut.Visible = true;
                lbl_Terminar.Visible = true;
                lbl_Sessao.Visible = true;
            }
        }

        private void Seniores()
        {
            flowpanel_Seniores.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDTreinador = "";
            string NomeTreinador = "";

            string IDAtleta = "";
            string NomeAtleta = "";

            try
            {
                //TREINADORES
                SqlDataReader dr;

                string Query = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 1) ORDER BY Nome");
                }
                else
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 1) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");

                }

                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDTreinador = dr["IDTreinador"].ToString();
                    NomeTreinador = dr["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDTreinador;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoTreinador;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeTreinador;
                    lblUser.ForeColor = Color.Firebrick;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDTreinador;
                    panel.Controls.Add(lblUser);
                }
                dr.Close();


                //ATLETAS
                SqlDataReader drAtleta;
                string QueryAtleta = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 1) ORDER BY Nome");
                }
                else
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 1) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");

                }
                SqlCommand CommandAtleta = new SqlCommand(QueryAtleta, con);
                drAtleta = CommandAtleta.ExecuteReader();

                while (drAtleta.Read())
                {
                    IDAtleta = drAtleta["IDAtleta"].ToString();
                    NomeAtleta = drAtleta["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDAtleta;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoAtleta;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeAtleta;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDAtleta;
                    panel.Controls.Add(lblUser);
                }
                drAtleta.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            if (flowpanel_Seniores.Controls.Count == 0 && tb_Pesquisar.Text != "")
            {
                lbl1.Visible = true;
            }
            else
            {
                lbl1.Visible = false;
            }
        }

        private void Juniores()
        {
            flowpanel_Juniores.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDTreinador = "";
            string NomeTreinador = "";

            string IDAtleta = "";
            string NomeAtleta = "";

            try
            {
                //TREINADORES
                SqlDataReader dr;
                string Query = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 2) ORDER BY Nome");
                }
                else
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 2) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");

                }
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDTreinador = dr["IDTreinador"].ToString();
                    NomeTreinador = dr["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDTreinador;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoTreinador;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeTreinador;
                    lblUser.ForeColor = Color.Firebrick;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDTreinador;
                    panel.Controls.Add(lblUser);
                }
                dr.Close();


                //ATLETAS
                SqlDataReader drAtleta;
                string QueryAtleta = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 2) ORDER BY Nome");
                }
                else
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 2) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");

                }
                SqlCommand CommandAtleta = new SqlCommand(QueryAtleta, con);
                drAtleta = CommandAtleta.ExecuteReader();

                while (drAtleta.Read())
                {
                    IDAtleta = drAtleta["IDAtleta"].ToString();
                    NomeAtleta = drAtleta["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDAtleta;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoAtleta;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeAtleta;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDAtleta;
                    panel.Controls.Add(lblUser);
                }
                drAtleta.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            if (flowpanel_Juniores.Controls.Count == 0 && tb_Pesquisar.Text != "")
            {
                lbl2.Visible = true;
            }
            else
            {
                lbl2.Visible = false;
            }
        }

        private void Juvenis()
        {
            flowpanel_Juvenis.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDTreinador = "";
            string NomeTreinador = "";

            string IDAtleta = "";
            string NomeAtleta = "";

            try
            {
                //TREINADORES
                SqlDataReader dr;
                string Query = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 3) ORDER BY Nome");
                }
                else
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 3) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");
                }
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDTreinador = dr["IDTreinador"].ToString();
                    NomeTreinador = dr["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDTreinador;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoTreinador;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeTreinador;
                    lblUser.ForeColor = Color.Firebrick;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDTreinador;
                    panel.Controls.Add(lblUser);
                }
                dr.Close();


                //ATLETAS
                SqlDataReader drAtleta;
                string QueryAtleta = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 3) ORDER BY Nome");
                }
                else
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 3) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");
                }
                SqlCommand CommandAtleta = new SqlCommand(QueryAtleta, con);
                drAtleta = CommandAtleta.ExecuteReader();

                while (drAtleta.Read())
                {
                    IDAtleta = drAtleta["IDAtleta"].ToString();
                    NomeAtleta = drAtleta["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDAtleta;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoAtleta;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeAtleta;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDAtleta;
                    panel.Controls.Add(lblUser);
                }
                drAtleta.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            if (flowpanel_Juvenis.Controls.Count == 0 && tb_Pesquisar.Text != "")
            {
                lbl3.Visible = true;
            }
            else
            {
                lbl3.Visible = false;
            }
        }

        private void Iniciados()
        {
            flowpanel_Iniciados.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDTreinador = "";
            string NomeTreinador = "";

            string IDAtleta = "";
            string NomeAtleta = "";

            try
            {
                //TREINADORES
                SqlDataReader dr;
                string Query = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 4) ORDER BY Nome");
                }
                else
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 4) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");
                }
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDTreinador = dr["IDTreinador"].ToString();
                    NomeTreinador = dr["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDTreinador;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoTreinador;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeTreinador;
                    lblUser.ForeColor = Color.Firebrick;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDTreinador;
                    panel.Controls.Add(lblUser);
                }
                dr.Close();


                //ATLETAS
                SqlDataReader drAtleta;
                string QueryAtleta = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 4) ORDER BY Nome");
                }
                else
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 4) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");
                }
                SqlCommand CommandAtleta = new SqlCommand(QueryAtleta, con);
                drAtleta = CommandAtleta.ExecuteReader();

                while (drAtleta.Read())
                {
                    IDAtleta = drAtleta["IDAtleta"].ToString();
                    NomeAtleta = drAtleta["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDAtleta;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoAtleta;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeAtleta;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDAtleta;
                    panel.Controls.Add(lblUser);
                }
                drAtleta.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            if (flowpanel_Iniciados.Controls.Count == 0 && tb_Pesquisar.Text != "")
            {
                lbl4.Visible = true;
            }
            else
            {
                lbl4.Visible = false;
            }
        }


        private void Infantis()
        {
            flowpanel_Infantis.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDTreinador = "";
            string NomeTreinador = "";

            string IDAtleta = "";
            string NomeAtleta = "";

            try
            {
                //TREINADORES
                SqlDataReader dr;
                string Query = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 5) ORDER BY Nome");

                }
                else
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 5) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");
                }
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDTreinador = dr["IDTreinador"].ToString();
                    NomeTreinador = dr["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDTreinador;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoTreinador;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeTreinador;
                    lblUser.ForeColor = Color.Firebrick;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDTreinador;
                    panel.Controls.Add(lblUser);
                }
                dr.Close();


                //ATLETAS
                SqlDataReader drAtleta;
                string QueryAtleta = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 5) ORDER BY Nome");
                }
                else
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 5) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");
                }
                SqlCommand CommandAtleta = new SqlCommand(QueryAtleta, con);
                drAtleta = CommandAtleta.ExecuteReader();

                while (drAtleta.Read())
                {
                    IDAtleta = drAtleta["IDAtleta"].ToString();
                    NomeAtleta = drAtleta["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDAtleta;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoAtleta;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeAtleta;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDAtleta;
                    panel.Controls.Add(lblUser);
                }
                drAtleta.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            if (flowpanel_Infantis.Controls.Count == 0 && tb_Pesquisar.Text != "")
            {
                lbl5.Visible = true;
            }
            else
            {
                lbl5.Visible = false;
            }
        }

        private void Benjamins()
        {
            flowpanel_Benjamins.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDTreinador = "";
            string NomeTreinador = "";

            string IDAtleta = "";
            string NomeAtleta = "";

            try
            {
                //TREINADORES
                SqlDataReader dr;
                string Query = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 6) ORDER BY Nome");
                }
                else
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 6) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");
                }
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDTreinador = dr["IDTreinador"].ToString();
                    NomeTreinador = dr["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDTreinador;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoTreinador;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeTreinador;
                    lblUser.ForeColor = Color.Firebrick;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDTreinador;
                    panel.Controls.Add(lblUser);
                }
                dr.Close();


                //ATLETAS
                SqlDataReader drAtleta;
                string QueryAtleta = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 6) ORDER BY Nome");
                }
                else
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 6) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");
                }
                SqlCommand CommandAtleta = new SqlCommand(QueryAtleta, con);
                drAtleta = CommandAtleta.ExecuteReader();

                while (drAtleta.Read())
                {
                    IDAtleta = drAtleta["IDAtleta"].ToString();
                    NomeAtleta = drAtleta["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDAtleta;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoAtleta;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeAtleta;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDAtleta;
                    panel.Controls.Add(lblUser);
                }
                drAtleta.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            if (flowpanel_Benjamins.Controls.Count == 0 && tb_Pesquisar.Text != "")
            {
                lbl6.Visible = true;
            }
            else
            {
                lbl6.Visible = false;
            }
        }

        private void Traquinas()
        {
            flowpanel_Traquinas.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDTreinador = "";
            string NomeTreinador = "";

            string IDAtleta = "";
            string NomeAtleta = "";

            try
            {
                //TREINADORES
                SqlDataReader dr;
                string Query = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 7) ORDER BY Nome");

                }
                else
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 7) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");
                }
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDTreinador = dr["IDTreinador"].ToString();
                    NomeTreinador = dr["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDTreinador;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoTreinador;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeTreinador;
                    lblUser.ForeColor = Color.Firebrick;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDTreinador;
                    panel.Controls.Add(lblUser);
                }
                dr.Close();


                //ATLETAS
                SqlDataReader drAtleta;
                string QueryAtleta = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 7) ORDER BY Nome");

                }
                else
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 7) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");
                }
                SqlCommand CommandAtleta = new SqlCommand(QueryAtleta, con);
                drAtleta = CommandAtleta.ExecuteReader();

                while (drAtleta.Read())
                {
                    IDAtleta = drAtleta["IDAtleta"].ToString();
                    NomeAtleta = drAtleta["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDAtleta;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoAtleta;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeAtleta;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDAtleta;
                    panel.Controls.Add(lblUser);
                }
                drAtleta.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            if (flowpanel_Traquinas.Controls.Count == 0 && tb_Pesquisar.Text != "")
            {
                lbl7.Visible = true;
            }
            else
            {
                lbl7.Visible = false;
            }
        }

        private void Petizes()
        {
            flowpanel_Petizes.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDTreinador = "";
            string NomeTreinador = "";

            string IDAtleta = "";
            string NomeAtleta = "";

            try
            {
                //TREINADORES
                SqlDataReader dr;
                string Query = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 8) ORDER BY Nome");

                }
                else
                {
                    Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND(FK_IDEscalao = 8) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");
                }
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDTreinador = dr["IDTreinador"].ToString();
                    NomeTreinador = dr["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDTreinador;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoTreinador;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeTreinador;
                    lblUser.ForeColor = Color.Firebrick;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDTreinador;
                    panel.Controls.Add(lblUser);
                }
                dr.Close();


                //ATLETAS
                SqlDataReader drAtleta;
                string QueryAtleta = "";
                if (tb_Pesquisar.Text == string.Empty)
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 8) ORDER BY Nome");
                }
                else
                {
                    QueryAtleta = ("SELECT IDAtleta, Nome, Lesao FROM dbo.TblAtleta WHERE(Apagado = 0) AND(FK_IDEscalao = 8) AND(Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI) ORDER BY Nome");
                }
                SqlCommand CommandAtleta = new SqlCommand(QueryAtleta, con);
                drAtleta = CommandAtleta.ExecuteReader();

                while (drAtleta.Read())
                {
                    IDAtleta = drAtleta["IDAtleta"].ToString();
                    NomeAtleta = drAtleta["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 260;
                    panel.Height = 50;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    panel.Name = "Panel" + IDAtleta;
                    panel.Margin = new Padding(5, 5, 0, 0);
                    flowpanel_Seniores.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(5, 5);
                    Pb.Width = 40;
                    Pb.Height = 40;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoAtleta;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 15);
                    lblUser.Text = NomeAtleta;
                    lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    lblUser.Width = 200;
                    lblUser.Tag = IDAtleta;
                    panel.Controls.Add(lblUser);
                }
                drAtleta.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            if (flowpanel_Petizes.Controls.Count == 0 && tb_Pesquisar.Text != "")
            {
                lbl8.Visible = true;
            }
            else
            {
                lbl8.Visible = false;
            }
        }


        //==============================================================================================

        //Pesquisa
        private void Btn_DeletePesquisa_Click(object sender, EventArgs e)
        {
            tb_Pesquisar.Text = "";

            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lbl7.Visible = false;
            lbl8.Visible = false;

            Seniores();
            Juniores();
            Juvenis();
            Iniciados();
            Infantis();
            Benjamins();
            Traquinas();
            Petizes();
        }

        private void Btn_Lupa_Click(object sender, EventArgs e)
        {
            if (tb_Pesquisar.Text != "")
            {
                Seniores();
                Juniores();
                Juvenis();
                Iniciados();
                Infantis();
                Benjamins();
                Traquinas();
                Petizes();
            }
        }

        private void Tb_Pesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (tb_Pesquisar.Text != "")
                {
                    Seniores();
                    Juniores();
                    Juvenis();
                    Iniciados();
                    Infantis();
                    Benjamins();
                    Traquinas();
                    Petizes();
                }
            }
        }


        //==============================================================================================


        //Side Menu
        private void Img_Menu_Click(object sender, EventArgs e)
        {
            if(panel_Menu.Visible == true && btn_Menu.Visible == true)
            {
                panel_Menu.Visible = false;
                btn_Menu.Visible = false;
            }
            else
            {
                panel_Menu.Visible = true;
                btn_Menu.Visible = true;
            }
        }


        //==============================================================================================


        //Side Menu buttons click
        private void Btn_Home_Click(object sender, EventArgs e)
        {
            if (Program.CurrentFuncaoUser == "Admin")
            {
                PaginaInicial_Admin PgInicio = new PaginaInicial_Admin();
                this.Hide();
                PgInicio.ShowDialog();
                this.Dispose();
            }
            else if (Program.CurrentFuncaoUser == "Treinador")
            {
                PaginaInicial_Treinador PgInicio = new PaginaInicial_Treinador();
                this.Hide();
                PgInicio.ShowDialog();
                this.Dispose();
            }
            else if (Program.CurrentFuncaoUser == "Atleta")
            {
                PaginaInicial_Atleta PgInicio = new PaginaInicial_Atleta();
                this.Hide();
                PgInicio.ShowDialog();
                this.Dispose();
            }
            else if (Program.CurrentFuncaoUser == "Socio")
            {
                PaginaInicial_Socio PgInicio = new PaginaInicial_Socio();
                this.Hide();
                PgInicio.ShowDialog();
                this.Dispose();
            }
            else
            {
                PaginaInicial PgInicio = new PaginaInicial();
                this.Hide();
                PgInicio.ShowDialog();
                this.Dispose();
            }
        }

        private void Btn_Jogos_Click(object sender, EventArgs e)
        {
            Jogos Jogo = new Jogos();
            this.Hide();
            Jogo.ShowDialog();
            this.Dispose();
        }

        private void Btn_Estadio_Click(object sender, EventArgs e)
        {
            Estadio Estadio = new Estadio();
            this.Hide();
            Estadio.ShowDialog();
            this.Dispose();
        }

        private void Btn_Historia_Click(object sender, EventArgs e)
        {
            Historia hist = new Historia();
            this.Hide();
            hist.ShowDialog();
            this.Dispose();
        }


        //Side menu buttons click, se nao for adepto
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Program.CurrentFuncaoUser == "Admin")
            {
                Financiamento fin = new Financiamento();
                this.Hide();
                fin.ShowDialog();
                this.Dispose();
            }
            else if (Program.CurrentFuncaoUser == "Treinador" || Program.CurrentFuncaoUser == "Atleta")
            {
                Convocatoria conv = new Convocatoria();
                this.Hide();
                conv.ShowDialog();
                this.Dispose();
            }
            else if (Program.CurrentFuncaoUser == "Socio")
            {
                Cota cota = new Cota();
                this.Hide();
                cota.ShowDialog();
                this.Dispose();
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (Program.CurrentFuncaoUser == "Admin" || Program.CurrentFuncaoUser == "Treinador")
            {
                Inventario inv = new Inventario();
                this.Hide();
                inv.ShowDialog();
                this.Dispose();
            }
            else if (Program.CurrentFuncaoUser == "Atleta")
            {
                Cota ct = new Cota();
                this.Hide();
                ct.ShowDialog();
                this.Dispose();
            }
            else if (Program.CurrentFuncaoUser == "Socio")
            {
                Utilizadores users = new Utilizadores();
                this.Hide();
                users.ShowDialog();
                this.Dispose();
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Utilizadores users = new Utilizadores();
            this.Hide();
            users.ShowDialog();
            this.Dispose();
        }



        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            Program.CurrentFuncaoUser = "";
            Program.CurrentIDUser = 0;
            Program.CurrentIDEscalao = 0;

            PaginaInicial PgInicio = new PaginaInicial();
            this.Hide();
            PgInicio.ShowDialog();
            this.Dispose();
        }
    }
}

