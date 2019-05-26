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
    public partial class PaginaInicial_Admin : Form
    {
        public PaginaInicial_Admin()
        {
            InitializeComponent();
            
        }

        private void PaginaInicial_Admin_Load(object sender, EventArgs e)
        {
            Discussoes();
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
        string[] IDDiscussao;
        

        private void Discussoes()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            
            string NomeDiscussao = "";
            string Descricao = "";
            string NomeAdmin = "";
            string IDAdmin = "";

            try{
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblDiscussao.IDDiscussao, dbo.TblDiscussao.NomeDiscussao, dbo.TblDiscussao.Descricao, dbo.TblAdministrador.IDAdministrador, dbo.TblAdministrador.Nome FROM dbo.TblDiscussao INNER JOIN dbo.TblAdministrador ON dbo.TblDiscussao.FK_IDAdministrador = dbo.TblAdministrador.IDAdministrador WHERE dbo.TblDiscussao.Apagado = 0 ORDER BY dbo.TblDiscussao.IDDiscussao DESC");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    int i = 0;
                    //IDDiscussao[i] = dr["IDDiscussao"].ToString();
                    

                    NomeDiscussao = dr["NomeDiscussao"].ToString();
                    Descricao = dr["Descricao"].ToString();
                    NomeAdmin = dr["Nome"].ToString();

                    IDAdmin = dr["IDAdministrador"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 800;
                    panel.Height = 250;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BorderStyle = BorderStyle.Fixed3D;
                    panel.BackColor = Color.White;
                    panel.Visible = true;
                    flowpanel_Discussoes.Controls.Add(panel);

                    PictureBox Pb = new PictureBox();
                    Pb.Location = new Point(10, 10);
                    Pb.Width = 30;
                    Pb.Height = 30;
                    Pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Pb.Image = FootballLife_WF.Properties.Resources.LogoAdmin;
                    Pb.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb.Visible = true;
                    panel.Controls.Add(Pb);

                    Label lblUser = new Label();
                    lblUser.Location = new Point(50, 18);
                    lblUser.Text = NomeAdmin;
                    lblUser.Font = new Font("Berlin Sans FB", 9, FontStyle.Regular);
                    lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblUser.Visible = true;
                    panel.Controls.Add(lblUser);

                    Label lblTitulo = new Label();
                    lblTitulo.Location = new Point(15, 70);
                    lblTitulo.Width = 765;
                    lblTitulo.Text = NomeDiscussao;
                    lblTitulo.Font = new Font("Berlin Sans FB Demi", 13, FontStyle.Regular);
                    lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblTitulo.Visible = true;
                    panel.Controls.Add(lblTitulo);

                    TextBox Tb = new TextBox();
                    Tb.Location = new Point(17, 100);
                    Tb.Width = 763;
                    Tb.Height = 120;
                    Tb.Text = Descricao;
                    Tb.Multiline = true;
                    Tb.ReadOnly = true;
                    Tb.Enabled = false;
                    Tb.Font = new Font("Arial", 12, FontStyle.Regular);
                    Tb.Anchor = AnchorStyles.Top;
                    Tb.Visible = true;
                    panel.Controls.Add(Tb);

                    if (Properties.Settings.Default.IDUser == Convert.ToInt32(IDAdmin))
                    {
                        PictureBox PbDelete = new PictureBox();
                        PbDelete.Location = new Point(760, 10);
                        PbDelete.Width = 15;
                        PbDelete.Height = 20;
                        PbDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        PbDelete.Image = FootballLife_WF.Properties.Resources.Delete;
                        PbDelete.SizeMode = PictureBoxSizeMode.Zoom;
                        PbDelete.Cursor = Cursors.Hand;
                        PbDelete.Visible = true;

                        PbDelete.Click += Btn_Discussao_Click;
                        panel.Controls.Add(PbDelete);
                    }
                    i++;
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void Btn_Discussao_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            try
            {
                string Query = ("UPDATE TblDiscussao SET Apagado = 1 WHERE IDDiscussao = ");
                SqlCommand Command = new SqlCommand(Query, con);
                Command.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            con.Close();
        }

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
            Utilizadores_Admin Users = new Utilizadores_Admin();
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
    }
}

