using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FootballLife_WF
{
    public partial class Utilizadores : Form
    {
        public Utilizadores()
        {
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);

            InitializeComponent();
        }

        private void Utilizadores_Load(object sender, EventArgs e)
        {
            Visibilidade();
            CountUsers();

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
        }

        //Visibilidade dependendo da funcao do Current User
        private void Visibilidade()
        {
            if (Program.CurrentFuncaoUser == "Admin")
            {
                btn_NovoUser.Visible = true;
                img_NovoUser.Visible = true;
                lbl_NovoUser.Visible = true;

                btn_DeletedUsers.Visible = true;
                img_DeletedUsers.Visible = true;
                lbl_DeletedUsers.Visible = true;

                Admins();
                Treinadores();
                Atletas();
                Socios();
            }
            else if (Program.CurrentFuncaoUser == "Treinador")
            {
                btn_NovoUser.Visible = true;
                img_NovoUser.Visible = true;
                lbl_NovoUser.Visible = true;

                btn_DeletedUsers.Visible = true;
                img_DeletedUsers.Visible = true;
                lbl_DeletedUsers.Visible = true;


                lbl_Socios.Visible = false;
                linha_Socios.Visible = false;
                flowpanel_Socios.Visible = false;
                img4.Visible = false;

                Admins();
                Treinadores();
                Atletas();
            }
            else if (Program.CurrentFuncaoUser == "Atleta")
            {
                lbl_Admins.Visible = false;
                linha_Admins.Visible = false;
                flowpanel_Admins.Visible = false;
                img1.Visible = false;

                lbl_Socios.Visible = false;
                linha_Socios.Visible = false;
                flowpanel_Socios.Visible = false;
                img4.Visible = false;

                Treinadores();
                Atletas();
            }
            else if (Program.CurrentFuncaoUser == "Socio")
            {
                lbl_Treinadores.Visible = false;
                linha_Treinadores.Visible = false;
                flowpanel_Treinadores.Visible = false;
                img2.Visible = false;

                lbl_Atletas.Visible = false;
                linha_Atletas.Visible = false;
                flowpanel_Atletas.Visible = false;
                img3.Visible = false;

                lbl_Socios.Visible = false;
                linha_Socios.Visible = false;
                flowpanel_Socios.Visible = false;
                img4.Visible = false;

                Admins();
            }
        }

        //Se alguma funcao nao tiver nunhum utilizador, torna-se invisivel e as funcoes anteriores sobem de posicao no ecra  
        private void CountUsers()
        {
            if (flowpanel_Admins.Controls.Count == 0)
            {
                lbl_Admins.Visible = false;
                linha_Admins.Visible = false;
                flowpanel_Admins.Visible = false;
                img1.Visible = false;
            }
            else
            {
                lbl_Admins.Visible = true;
                linha_Admins.Visible = true;
                flowpanel_Admins.Visible = true;
                img1.Visible = true;
            }

            if (flowpanel_Treinadores.Controls.Count == 0)
            {
                lbl_Treinadores.Visible = false;
                linha_Treinadores.Visible = false;
                flowpanel_Treinadores.Visible = false;
                img2.Visible = false;
            }
            else
            {
                lbl_Treinadores.Visible = true;
                linha_Treinadores.Visible = true;
                flowpanel_Treinadores.Visible = true;
                img2.Visible = true;
            }

            if (flowpanel_Atletas.Controls.Count == 0)
            {
                lbl_Atletas.Visible = false;
                linha_Atletas.Visible = false;
                flowpanel_Atletas.Visible = false;
                img3.Visible = false;
            }
            else
            {
                lbl_Atletas.Visible = true;
                linha_Atletas.Visible = true;
                flowpanel_Atletas.Visible = true;
                img3.Visible = true;
            }

            if (flowpanel_Socios.Controls.Count == 0)
            {
                lbl_Socios.Visible = false;
                linha_Socios.Visible = false;
                flowpanel_Socios.Visible = false;
                img4.Visible = false;
            }
            else
            {
                lbl_Socios.Visible = true;
                linha_Socios.Visible = true;
                flowpanel_Socios.Visible = true;
                img4.Visible = true;
            }

            if (flowpanel_Admins.Visible == false)
            {
                lbl_espaco.Location = lbl_Socios.Location;

                lbl_Socios.Location = lbl_Atletas.Location;
                linha_Socios.Location = linha_Atletas.Location;
                flowpanel_Socios.Location = flowpanel_Atletas.Location;
                img4.Location = img3.Location;
                lbl4.Location = lbl3.Location;

                lbl_Atletas.Location = lbl_Treinadores.Location;
                linha_Atletas.Location = linha_Treinadores.Location;
                flowpanel_Atletas.Location = flowpanel_Treinadores.Location;
                img3.Location = img2.Location;
                lbl3.Location = lbl2.Location;

                lbl_Treinadores.Location = lbl_Admins.Location;
                linha_Treinadores.Location = linha_Admins.Location;
                flowpanel_Treinadores.Location = flowpanel_Admins.Location;
                img2.Location = img1.Location;
                lbl2.Location = lbl1.Location;
            }

            if (flowpanel_Treinadores.Visible == false)
            {
                lbl_espaco.Location = lbl_Socios.Location;

                lbl_Socios.Location = lbl_Atletas.Location;
                linha_Socios.Location = linha_Atletas.Location;
                flowpanel_Socios.Location = flowpanel_Atletas.Location;
                img4.Location = img3.Location;
                lbl4.Location = lbl3.Location;

                lbl_Atletas.Location = lbl_Treinadores.Location;
                linha_Atletas.Location = linha_Treinadores.Location;
                flowpanel_Atletas.Location = flowpanel_Treinadores.Location;
                img3.Location = img2.Location;
                lbl3.Location = lbl2.Location;

            }

            if (flowpanel_Atletas.Visible == false)
            {
                lbl_espaco.Location = lbl_Socios.Location;

                lbl_Socios.Location = lbl_Atletas.Location;
                linha_Socios.Location = linha_Atletas.Location;
                flowpanel_Socios.Location = flowpanel_Atletas.Location;
                img4.Location = img3.Location;
                lbl4.Location = lbl3.Location;
            }

            if (flowpanel_Socios.Visible == false)
            {
                lbl_espaco.Location = lbl_Socios.Location;
            }
        }


        //==============================================================================================


        int ADM = 8;
        //Administradores
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
                string Query = "";
                if (tb_Pesquisar.Text == "")
                {
                    Query = ("SELECT TOP (" + ADM + ") IDAdministrador, Nome FROM dbo.TblAdministrador WHERE(Apagado = 0) ORDER BY Nome");
                }
                else
                {
                    Query = ("SELECT TOP (" + ADM + ") IDAdministrador, Nome FROM dbo.TblAdministrador WHERE(Apagado = 0) AND Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI  ORDER BY Nome");
                }
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
                    panel.Margin = new Padding(5, 5, 5, 5);
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

                    if (Program.CurrentFuncaoUser != "Admin" || Program.CurrentFuncaoUser == "Admin" && Program.CurrentIDUser == Convert.ToInt32(IDAdmin))
                    {
                        Pbdelete.Visible = false;
                    }
                    else
                    {
                        Pbdelete.Visible = true;
                    }

                    
                }
                dr.Close();

                if (flowpanel_Admins.Controls.Count == 0)
                {
                    lbl1.Visible = true;
                }
                else if (flowpanel_Admins.Controls.Count > 0)
                {
                    lbl1.Visible = false;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            
        }

        private void Btn_DeleteAdmin_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Tem a certeza que pretente eliminar este utilizador?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
                con.Open();

                string IDAdmin = "";

                try
                {
                    string Query = "UPDATE TblAdministrador SET Apagado = 1 WHERE IDAdministrador = @IDAdmin";

                    PictureBox PbDELETE = (PictureBox)sender;
                    IDAdmin = PbDELETE.Tag.ToString();
                    SqlCommand Command = new SqlCommand(Query, con);
                    Command.Parameters.AddWithValue("@IDAdmin", IDAdmin);
                    Command.ExecuteNonQuery();

                    MessageBox.Show($"Administrador apagado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        int T = 8;
        //Treinadores
        private void Treinadores()
        {
            flowpanel_Treinadores.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string Query = "";
            string IDTreinador = "";
            string NomeTreinador = "";

            try
            {
                SqlDataReader dr;

                if (Program.CurrentFuncaoUser == "Atleta")
                {
                    if (tb_Pesquisar.Text == "")
                    {
                        Query = ("SELECT TOP (" + T + ") IDTreinador, Nome FROM dbo.TblTreinador WHERE (Apagado = 0) AND FK_IDEscalao = " + Program.CurrentIDEscalao + " ORDER BY Nome");
                    }
                    else
                    {
                        Query = ("SELECT TOP (" + T + ") IDTreinador, Nome FROM dbo.TblTreinador WHERE (Apagado = 0) AND FK_IDEscalao = " + Program.CurrentIDEscalao + " AND Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI  ORDER BY Nome");
                    }
                }
                else
                {
                    if (tb_Pesquisar.Text == "")
                    {
                        Query = ("SELECT TOP (" + T + ") IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) ORDER BY Nome");
                    }
                    else
                    {
                        Query = ("SELECT TOP (" + T + ") IDTreinador, Nome FROM dbo.TblTreinador WHERE(Apagado = 0) AND Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI  ORDER BY Nome");
                    }
                }

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
                    panel.Margin = new Padding(5, 5, 5, 5);
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


                    if (Program.CurrentFuncaoUser != "Admin")
                    {
                        Pbdelete.Visible = false;
                    }
                    else
                    {
                        Pbdelete.Visible = true;
                    }

                    
                }
                dr.Close();

                if (flowpanel_Treinadores.Controls.Count == 0)
                {
                    lbl2.Visible = true;
                }
                else if (flowpanel_Treinadores.Controls.Count > 0)
                {
                    lbl2.Visible = false;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void Btn_DeleteTreinador_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Tem a certeza que pretente eliminar este utilizador?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

                    MessageBox.Show($"Treinador apagado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        int A = 8;
        //Atletas
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
                string Query = "";
                if (Program.CurrentFuncaoUser == "Atleta" || Program.CurrentFuncaoUser == "Treinador")
                {
                    
                    if (tb_Pesquisar.Text == "")
                    {
                        Query = ("SELECT TOP (" + A + ") IDAtleta, Nome FROM dbo.TblAtleta WHERE(Apagado = 0) AND FK_IDEscalao = " + Program.CurrentIDEscalao + " ORDER BY Nome");
                    }
                    else
                    {
                        Query = ("SELECT TOP (" + A + ") IDAtleta, Nome FROM dbo.TblAtleta WHERE(Apagado = 0) AND FK_IDEscalao = " + Program.CurrentIDEscalao + " AND Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI  ORDER BY Nome");
                    }
                }
                else
                {
                    if (tb_Pesquisar.Text == "")
                    {
                        Query = ("SELECT TOP (" + A + ") IDAtleta, Nome FROM dbo.TblAtleta WHERE(Apagado = 0) ORDER BY Nome");
                    }
                    else
                    {
                        Query = ("SELECT TOP (" + A + ") IDAtleta, Nome FROM dbo.TblAtleta WHERE(Apagado = 0) AND Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI  ORDER BY Nome");
                    }
                }

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
                    panel.Margin = new Padding(5, 5, 5, 5);
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

                    if (Program.CurrentFuncaoUser != "Admin" && Program.CurrentFuncaoUser != "Treinador")
                    {
                        Pbdelete.Visible = false;
                    }
                    else if (Program.CurrentFuncaoUser == "Admin" || Program.CurrentFuncaoUser == "Treinador")
                    {
                        Pbdelete.Visible = true;
                    }

                    
                }
                dr.Close();

                if (flowpanel_Atletas.Controls.Count == 0)
                {
                    lbl3.Visible = true;
                }
                else if (flowpanel_Atletas.Controls.Count > 0)
                {
                    lbl3.Visible = false;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void Btn_DeleteAtleta_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Tem a certeza que pretente eliminar este utilizador?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

                    MessageBox.Show($"Atleta apagado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        int S = 8;
        //Socios
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

                string Query = "";
                if (tb_Pesquisar.Text == "")
                {
                    Query = ("SELECT TOP (" + S + ") IDSocio, Nome FROM dbo.TblSocio WHERE (Apagado = 0) ORDER BY Nome");
                }
                else
                {
                    Query = ("SELECT TOP (" + S + ") IDSocio, Nome FROM dbo.TblSocio WHERE (Apagado = 0) AND Nome COLLATE Latin1_General_CI_AI LIKE '%" + tb_Pesquisar.Text + "%' COLLATE Latin1_General_CI_AI  ORDER BY Nome");
                }
                
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
                    panel.Margin = new Padding(5, 5, 5, 5);
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

                    if (Program.CurrentFuncaoUser != "Admin")
                    {
                        Pbdelete.Visible = false;
                    }
                    else
                    {
                        Pbdelete.Visible = true;
                    }

                    
                }
                dr.Close();

                if (flowpanel_Socios.Controls.Count == 0)
                {
                    lbl4.Visible = true;
                }
                else if (flowpanel_Socios.Controls.Count > 0)
                {
                    lbl4.Visible = false;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void Btn_DeleteSocio_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Tem a certeza que pretente eliminar este utilizador?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                    Command.Parameters.AddWithValue("@IDSocio", IDSocio);
                    Command.ExecuteNonQuery();

                    MessageBox.Show($"Sócio apagado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        //User Click
        private void Btn_Pb_Click(object sender, EventArgs e)
        {
            PictureBox Pb = (PictureBox)sender;
            string ID = Pb.Tag.ToString();
            string Funcao = Pb.Name.ToString();

            if(Program.CurrentFuncaoUser == "Admin" || Program.CurrentFuncaoUser == "Treinador" && Funcao == "Atleta") 
            {
                EditarUser(ID, Funcao);
            }
            else
            {
                VisualizarUser(ID, Funcao);
            }

        }

        private void Btn_Lbl_Click(object sender, EventArgs e)
        {
            Label Lbl = (Label)sender;
            string ID = Lbl.Tag.ToString();
            string Funcao = Lbl.Name.ToString();

            if (Program.CurrentFuncaoUser == "Admin" || Program.CurrentFuncaoUser == "Treinador" && Funcao == "Atleta")
            {
                EditarUser(ID, Funcao);
            }
            else
            {
                VisualizarUser(ID, Funcao);
            }
        }

        //Open diffent forms
        private static void EditarUser(string ID, string Funcao)
        {
            EditarUtilizador verUser = new EditarUtilizador(ID, Funcao);
            verUser.Show();
        }

        private static void VisualizarUser(string ID, string Funcao)
        {
            VisualizarUtilizador verUser = new VisualizarUtilizador(ID, Funcao);
            verUser.Show();
        }


        //User Delete
        private void Btn_DeletedUsers_Click(object sender, EventArgs e)
        {
            DeletedUsers Apagados = new DeletedUsers();
            Apagados.ShowDialog();

            if (Program.CurrentFuncaoUser == "Admin")
            {
                Admins();
                Treinadores();
                Atletas();
                Socios();
            }
            else if (Program.CurrentFuncaoUser == "Treinador")
            {
                Admins();
                Treinadores();
                Atletas();
            }
        }


        //New User
        private void Btn_NovoUtilizador_Click(object sender, EventArgs e)
        {
            AdicionarUtilizador NewUser = new AdicionarUtilizador();
            NewUser.ShowDialog();

            if(Program.CurrentFuncaoUser == "Admin")
            {
                Admins();
                Treinadores();
                Atletas();
                Socios();
            }
            else if (Program.CurrentFuncaoUser == "Treinador")
            {
                Admins();
                Treinadores();
                Atletas();
            }

        }


        //===========================================================================


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
        

        //Side Menu
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


        //Side Menu Buttons Click
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
        }

        private void Btn_Jogos_Click(object sender, EventArgs e)
        {
            Jogos jgs = new Jogos();
            this.Hide();
            jgs.ShowDialog();
            this.Dispose();
        }

        private void Btn_Equipas_Click(object sender, EventArgs e)
        {
            Equipas Equipa = new Equipas();
            this.Hide();
            Equipa.ShowDialog();
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
            Historia Hist = new Historia();
            this.Hide();
            Hist.ShowDialog();
            this.Dispose();
        }

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

        private void Img1_Click(object sender, EventArgs e)
        {
            ADM += 8;
            Admins();
        }

        private void Img2_Click(object sender, EventArgs e)
        {
            T += 8;
            Treinadores();
        }

        private void Img3_Click(object sender, EventArgs e)
        {
            A += 8;
            Atletas();
        }

        private void Img4_Click(object sender, EventArgs e)
        {
            S += 8;
            Socios();
        }

        private void Btn_Lupa_Click(object sender, EventArgs e)
        {
            if (tb_Pesquisar.Text != "")
            {
                Visibilidade();
            }
            else
            {
                Visibilidade();

                lbl1.Visible = false;
                lbl1.Visible = false;
                lbl3.Visible = false;
                lbl4.Visible = false;
            }
        }

        private void Btn_DeletePesquisa_Click(object sender, EventArgs e)
        {
            tb_Pesquisar.Text = "";

            Visibilidade();

            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            }

        private void Tb_Pesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tb_Pesquisar.Text != "")
                {
                    Visibilidade();
                }
                else
                {
                    Visibilidade();

                    lbl1.Visible = false;
                    lbl1.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                }
            }
        }
    }
}

