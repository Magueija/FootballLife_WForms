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
            for(int i = 0; i < 5; i++)
            {
            Panel panel = new Panel();
            panel.Width = 200;
            panel.Height = 50;
            panel.Anchor = AnchorStyles.Top;
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.BackColor = Color.White;
            panel.Visible = true;
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
            Pbdelete.Location = new Point(175, 5);
            Pbdelete.Width = 15;
            Pbdelete.Height = 15;
            Pbdelete.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Pbdelete.Image = FootballLife_WF.Properties.Resources.Delete;
            Pbdelete.SizeMode = PictureBoxSizeMode.Zoom;
            Pbdelete.Visible = true;
            panel.Controls.Add(Pbdelete);

            Label lblUser = new Label();
            lblUser.Location = new Point(50, 15);
            lblUser.Text = "Nome Admin";
            lblUser.Font = new Font("Berlin Sans FB ", 9, FontStyle.Bold);
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblUser.Visible = true;
            panel.Controls.Add(lblUser);

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

            string NomeDiscussao = "";
            string Descricao = "";
            string NomeAdmin = "";

            SqlDataReader dr;
            string Query = ("");
            SqlCommand Command = new SqlCommand(Query, con);
            dr = Command.ExecuteReader();

            Panel panel = new Panel();
            if (dr.Read())
            {
                panel.Width = 800;
                panel.Height = 250;
                panel.Anchor = AnchorStyles.Top;
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.BackColor = Color.White;
                panel.AutoScroll = true;
                panel.Visible = true;
                flowpanel_Admins.Controls.Add(panel);


                Button button = new Button();
                button.Width = 100;
                button.Height = 50;
                button.Anchor = AnchorStyles.Top;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.Black;
                button.BackColor = Color.White;
                button.Visible = true;

                PictureBox Pb = new PictureBox();
                Pb.Location = new Point (10, 10);
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
            }
            dr.Close();
            
            con.Close();
        }

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

