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
    public partial class DeletedUsers : Form
    {
        public DeletedUsers()
        {
            InitializeComponent();
        }

        private void DeletedUsers_Load(object sender, EventArgs e)
        {
            Admins();
            Treinadores();
            Atletas();
            Socios();
        }


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
                string Query = ("SELECT IDAdministrador, Nome FROM dbo.TblAdministrador WHERE(Apagado = 1) ORDER BY Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDAdmin = dr["IDAdministrador"].ToString();
                    NomeAdmin = dr["Nome"].ToString();
                    PaneisAdmin(IDAdmin, NomeAdmin);
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();

        }

        private void PaneisAdmin(string IDAdmin, string NomeAdmin)
        {
            Panel panel = new Panel();
            panel.Width = 230;
            panel.Height = 50;
            panel.Anchor = AnchorStyles.Top;
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.BackColor = Color.White;
            panel.Visible = true;
            panel.Name = "Panel" + IDAdmin;
            panel.Margin = new Padding(0, 5, 0, 0);
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
            Pb.Name = "Administrador";
            Pb.Tag = IDAdmin;
            panel.Controls.Add(Pb);

            Label lblUser = new Label();
            lblUser.Location = new Point(50, 15);
            lblUser.Text = NomeAdmin;
            lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblUser.Visible = true;
            lblUser.Width = 150;
            lblUser.Cursor = Cursors.Hand;
            lblUser.Name = "Administrador";
            lblUser.Tag = IDAdmin;
            panel.Controls.Add(lblUser);

            Pb.Click += Btn_Pb_Click;
            lblUser.Click += Btn_Lbl_Click;
        }

        private void Treinadores()
        {
            flowpanel_Treinadores.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDTreinador = "";
            string NomeTreinador = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 1) ORDER BY Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDTreinador = dr["IDTreinador"].ToString();
                    NomeTreinador = dr["Nome"].ToString();
                    PaneisTreinador(IDTreinador, NomeTreinador);
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            con.Close();
        }

        private void PaneisTreinador(string IDTreinador, string NomeTreinador)
        {
            Panel panel = new Panel();
            panel.Width = 230;
            panel.Height = 50;
            panel.Anchor = AnchorStyles.Top;
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.BackColor = Color.White;
            panel.Visible = true;
            panel.Name = "Panel" + IDTreinador;
            panel.Margin = new Padding(0, 5, 0, 0);
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


            Pb.Click += Btn_Pb_Click;
            lblUser.Click += Btn_Lbl_Click;
        }

        private void Atletas()
        {
            flowpanel_Atletas.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDAtleta = "";
            string NomeAtleta = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT IDAtleta, Nome FROM dbo.TblAtleta WHERE(Apagado = 1) ORDER BY Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDAtleta = dr["IDAtleta"].ToString();
                    NomeAtleta = dr["Nome"].ToString();
                    PaneisAtleta(IDAtleta, NomeAtleta);
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            con.Close();
        }

        private void PaneisAtleta(string IDAtleta, string NomeAtleta)
        {
            Panel panel = new Panel();
            panel.Width = 230;
            panel.Height = 50;
            panel.Anchor = AnchorStyles.Top;
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.BackColor = Color.White;
            panel.Visible = true;
            panel.Name = "Panel" + IDAtleta;
            panel.Margin = new Padding(0, 5, 0, 0);
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

            Pb.Click += Btn_Pb_Click;
            lblUser.Click += Btn_Lbl_Click;
        }

        private void Socios()
        {
            flowpanel_Socios.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDSocio = "";
            string NomeSocio = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT IDSocio, Nome FROM dbo.TblSocio WHERE(Apagado = 1) ORDER BY Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDSocio = dr["IDSocio"].ToString();
                    NomeSocio = dr["Nome"].ToString();
                    PaneisSocio(IDSocio, NomeSocio);
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            con.Close();
        }

        private void PaneisSocio(string IDSocio, string NomeSocio)
        {
            Panel panel = new Panel();
            panel.Width = 230;
            panel.Height = 50;
            panel.Anchor = AnchorStyles.Top;
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.BackColor = Color.White;
            panel.Visible = true;
            panel.Name = "Panel" + IDSocio;
            panel.Margin = new Padding(0, 5, 0, 0);
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


            Pb.Click += Btn_Pb_Click;
            lblUser.Click += Btn_Lbl_Click;
        }


        //==========================================================================================


        //Pesquisa
        private void PesquisaAdmins()
        {
            flowpanel_Admins.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDAdmin = "";
            string NomeAdmin = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT IDAdministrador, Nome FROM dbo.TblAdministrador WHERE (Apagado = 1) AND Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI ORDER BY Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDAdmin = dr["IDAdministrador"].ToString();
                    NomeAdmin = dr["Nome"].ToString();
                    PaneisAdmin(IDAdmin, NomeAdmin);
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            if (flowpanel_Admins.Controls.Count == 0)
            {
                lbl1.Visible = true;
            }
            else
            {
                lbl1.Visible = false;
            }

            con.Close();

        }

        private void PesquisaTreinadores()
        {
            flowpanel_Treinadores.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDTreinador = "";
            string NomeTreinador = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 1) AND Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI ORDER BY Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDTreinador = dr["IDTreinador"].ToString();
                    NomeTreinador = dr["Nome"].ToString();
                    PaneisTreinador(IDTreinador, NomeTreinador);
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            if (flowpanel_Treinadores.Controls.Count == 0)
            {
                lbl2.Visible = true;
            }
            else
            {
                lbl2.Visible = false;
            }

            con.Close();
        }

        private void PesquisaAtletas()
        {
            flowpanel_Atletas.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDAtleta = "";
            string NomeAtleta = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT IDAtleta, Nome FROM dbo.TblAtleta WHERE(Apagado = 1) AND Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI ORDER BY Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDAtleta = dr["IDAtleta"].ToString();
                    NomeAtleta = dr["Nome"].ToString();
                    PaneisAtleta(IDAtleta, NomeAtleta);
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            if (flowpanel_Atletas.Controls.Count == 0)
            {
                lbl3.Visible = true;
            }
            else
            {
                lbl3.Visible = false;
            }

            con.Close();
        }

        private void PesquisaSocios()
        {
            flowpanel_Socios.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string IDSocio = "";
            string NomeSocio = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT IDSocio, Nome FROM dbo.TblSocio WHERE(Apagado = 1) AND Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI ORDER BY Nome");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    IDSocio = dr["IDSocio"].ToString();
                    NomeSocio = dr["Nome"].ToString();
                    PaneisSocio(IDSocio, NomeSocio);
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            if (flowpanel_Socios.Controls.Count == 0)
            {
                lbl4.Visible = true;
            }
            else
            {
                lbl4.Visible = false;
            }

            con.Close();
        }



        private void Btn_DeletePesquisa_Click(object sender, EventArgs e)
        {
            tb_Pesquisar.Text = "";

            Admins();
            Treinadores();
            Atletas();
            Socios();

            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
        }

        private void Btn_Lupa_Click(object sender, EventArgs e)
        {
            if (tb_Pesquisar.Text != "")
            {
                PesquisaAdmins();
                PesquisaTreinadores();
                PesquisaAtletas();
                PesquisaSocios();
            }
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tb_Pesquisar.Text != "")
                {
                    PesquisaAdmins();
                    PesquisaTreinadores();
                    PesquisaAtletas();
                    PesquisaSocios();
                }
            }
        }


        //======================================================================================


        //Set User Apagado = 0
        private void Btn_Pb_Click(object sender, EventArgs e)
        {
            PictureBox Pb = (PictureBox)sender;
            string ID = Pb.Tag.ToString();
            string funcao = Pb.Name.ToString();

            DialogResult result = MessageBox.Show($"Tem a certeza que pretente adicionar este {funcao}?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
                con.Open();

                try
                {
                    string Query = "UPDATE Tbl" + funcao + " SET Apagado = 0 WHERE ID" + funcao + " = @ID";

                    SqlCommand Command = new SqlCommand(Query, con);
                    Command.Parameters.AddWithValue("@ID", ID);
                    Command.ExecuteNonQuery();

                    MessageBox.Show($"{funcao} adicionado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                con.Close();

                Admins();
                Treinadores();
                Atletas();
                Socios();
            }
        }

        private void Btn_Lbl_Click(object sender, EventArgs e)
        {
            Label Lbl = (Label)sender;
            string ID = Lbl.Tag.ToString();
            string funcao = Lbl.Name.ToString();

            DialogResult result = MessageBox.Show($"Tem a certeza que pretente adicionar este {funcao}?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
                con.Open();

                try
                {
                    string Query = "UPDATE Tbl" + funcao + " SET Apagado = 0 WHERE ID" + funcao + " = @ID";

                    SqlCommand Command = new SqlCommand(Query, con);
                    Command.Parameters.AddWithValue("@ID", ID);
                    Command.ExecuteNonQuery();

                    MessageBox.Show($"{funcao} adicionado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                con.Close();

                Admins();
                Treinadores();
                Atletas();
                Socios();
            }
        }


        //======================================================================================


        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
