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
    public partial class VisualizarUtilizador : Form
    {
        string Funcao = "";
        string ID = "";

        public VisualizarUtilizador(string IDUser, string FuncaoUser)
        {
            Funcao = FuncaoUser;
            ID = IDUser;


            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);

            InitializeComponent();
        }

        private void VisualizarUtilizador_Load(object sender, EventArgs e)
        {
            if(Program.CurrentFuncaoUser == "Treinador")
            {
                if (Funcao == "Admin")
                {
                    Escalao.Visible = false;
                    lbl_Escalao.Visible = false;

                    Admin();
                }
                else if (Funcao == "Treinador")
                {
                    Treinador();
                }
                else if (Funcao == "Atleta")
                {
                    Escalao.Visible = false;
                    lbl_Escalao.Visible = false;

                    Atleta();
                }
            }
            else if (Program.CurrentFuncaoUser == "Atleta")
            {
                if (Funcao == "Treinador")
                {
                    Treinador();
                }
                else if (Funcao == "Atleta")
                {
                    Escalao.Visible = false;
                    lbl_Escalao.Visible = false;

                    Atleta();
                }
            }
            else if (Program.CurrentFuncaoUser == "Socio")
            {
                if (Funcao == "Admin")
                {
                    Telemovel.Visible = false;
                    lbl_Telemovel.Visible = false;
                    Escalao.Visible = false;
                    lbl_Escalao.Visible = false;

                    Admin();
                }
            }
        }


        //==========================================================================================


        //Adminitradores
        private void Admin()
        {
            img_Logo.Image = Properties.Resources.LogoAdmin;

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string Nome = "";
            string Telemovel = "";
            string Email = "";

            try
            {
                SqlDataReader dr;
                string QueryAdmin = ("SELECT Nome, Telemovel, Email FROM TblAdministrador WHERE IDAdministrador = " + ID);
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                }
                dr.Close();


                Lbl_Titulo.Text = Nome;

                lbl_Nome.Text = Nome;
                lbl_Email.Text = Email;

                if (Telemovel != "0")
                {
                    lbl_Telemovel.Text = Telemovel;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        //Treinadores
        private void Treinador()
        {
            img_Logo.Image = Properties.Resources.LogoTreinador;

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string Nome = "";
            string Telemovel = "";
            string Email = "";
            string Escalao = "";

            try
            {

                SqlDataReader dr;
                string QueryAdmin = ("SELECT dbo.TblTreinador.Nome, dbo.TblTreinador.Telemovel, dbo.TblTreinador.Email, dbo.TblEscalao.Escalao FROM dbo.TblTreinador INNER JOIN dbo.TblEscalao ON dbo.TblTreinador.FK_IDEscalao = dbo.TblEscalao.IDEscalao WHERE dbo.TblTreinador.IDTreinador = " + ID);
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                    Escalao = dr["Escalao"].ToString();
                }
                dr.Close();


                Lbl_Titulo.Text = Nome;

                lbl_Nome.Text = Nome;
                lbl_Email.Text = Email;
                lbl_Escalao.Text = Escalao;

                if (Telemovel != "0")
                {
                    lbl_Telemovel.Text = Telemovel;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        //Atletas
        private void Atleta()
        {
            img_Logo.Image = Properties.Resources.LogoAtleta;

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string Nome = "";
            string Telemovel = "";
            string Email = "";

            try
            {

                SqlDataReader dr;
                string QueryAdmin = ("SELECT Nome, Telemovel, Email FROM TblAtleta WHERE IDAtleta = " + ID);
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                }
                dr.Close();


                Lbl_Titulo.Text = Nome;

                lbl_Nome.Text = Nome;
                lbl_Email.Text = Email;

                if (Telemovel != "0")
                {
                    lbl_Telemovel.Text = Telemovel;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        //Socios
        /*
        private void Socio()
        {
            img_Logo.Image = Properties.Resources.LogoSocio;

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string Nome = "";
            string Telemovel = "";
            string Email = "";

            try
            {

                SqlDataReader dr;
                string QueryAdmin = ("SELECT Nome, Telemovel, Email FROM TblSocio WHERE IDSocio = " + ID);
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                }
                dr.Close();


                Lbl_Titulo.Text = Nome;

                lbl_Nome.Text = Nome;
                lbl_Email.Text = Email;

                if (Telemovel != "0")
                {
                    lbl_Telemovel.Text = Telemovel;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }*/


        //=================================================================


        //Sai do form
        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
