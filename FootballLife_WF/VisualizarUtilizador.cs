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
                    morada.Visible = false;
                    lbl_Morada.Visible = false;

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
                    Escalao.Visible = false;
                    lbl_Escalao.Visible = false;
                    morada.Visible = false;
                    lbl_Morada.Visible = false;

                    Treinador();
                }
                else if (Funcao == "Atleta")
                {
                    Escalao.Visible = false;
                    lbl_Escalao.Visible = false;
                    morada.Visible = false;
                    lbl_Morada.Visible = false;

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
                    morada.Visible = false;
                    lbl_Morada.Visible = false;

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
            string Morada = "";
            string CodPostal = "";

            try
            {
                SqlDataReader dr;
                string QueryAdmin = ("SELECT Nome, Telemovel, Email, Morada, CodPostal FROM TblAdministrador WHERE IDAdministrador = " + ID);
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                    Morada = dr["Morada"].ToString();
                    CodPostal = dr["CodPostal"].ToString();
                }
                dr.Close();


                Lbl_Titulo.Text = Nome;

                lbl_Nome.Text = Nome;
                lbl_Email.Text = Email;

                if (Morada != "" && CodPostal != " ")
                {
                    lbl_Morada.Text = Morada + "    " + CodPostal;
                }
                else if (Morada != "" && CodPostal == " ")
                {
                    lbl_Morada.Text = Morada;
                }
                else if (Morada == "" && CodPostal != " ")
                {
                    morada.Text = "Cd Postal:";
                    lbl_Morada.Text = CodPostal;
                }

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
            string Morada = "";
            string CodPostal = "";

            try
            {

                SqlDataReader dr;
                string QueryAdmin = ("SELECT dbo.TblTreinador.Nome, dbo.TblTreinador.Telemovel, dbo.TblTreinador.Email, dbo.TblTreinador.Morada, dbo.TblTreinador.CodPostal, dbo.TblEscalao.Escalao FROM dbo.TblTreinador INNER JOIN dbo.TblEscalao ON dbo.TblTreinador.FK_IDEscalao = dbo.TblEscalao.IDEscalao WHERE dbo.TblTreinador.IDTreinador = " + ID);
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                    Escalao = dr["Escalao"].ToString();
                    Morada = dr["Morada"].ToString();
                    CodPostal = dr["CodPostal"].ToString();
                }
                dr.Close();


                Lbl_Titulo.Text = Nome;

                lbl_Nome.Text = Nome;
                lbl_Email.Text = Email;
                lbl_Escalao.Text = Escalao;

                if (Morada != "" && CodPostal != " ")
                {
                    lbl_Morada.Text = Morada + "    " + CodPostal;
                }
                else if (Morada != "" && CodPostal == " ")
                {
                    lbl_Morada.Text = Morada;
                }
                else if (Morada == "" && CodPostal != " ")
                {
                    morada.Text = "Cd Postal:";
                    lbl_Morada.Text = CodPostal;
                }

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
            string Escalao = "";
            string Morada = "";
            string CodPostal = "";

            try
            {

                SqlDataReader dr;
                string QueryAdmin = ("SELECT dbo.TblAtleta.Nome, dbo.TblAtleta.Telemovel, dbo.TblAtleta.Email, dbo.TblAtleta.Morada, dbo.TblAtleta.CodPostal, dbo.TblEscalao.Escalao FROM dbo.TblAtleta INNER JOIN dbo.TblEscalao ON dbo.TblAtleta.FK_IDEscalao = dbo.TblEscalao.IDEscalao WHERE dbo.TblAtleta.IDAtleta = " + ID);
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                    Escalao = dr["Escalao"].ToString();
                    Morada = dr["Morada"].ToString();
                    CodPostal = dr["CodPostal"].ToString();
                }
                dr.Close();


                Lbl_Titulo.Text = Nome;

                lbl_Nome.Text = Nome;
                lbl_Email.Text = Email;
                lbl_Escalao.Text = Escalao;

                
                if (Morada != "" && CodPostal != " ")
                {
                    lbl_Morada.Text = Morada + "    " + CodPostal;
                }
                else if (Morada != "" && CodPostal == " ")
                {
                    lbl_Morada.Text = Morada;
                }
                else if (Morada == "" && CodPostal != " ")
                {
                    morada.Text = "Cd Postal:";
                    lbl_Morada.Text = CodPostal;
                }


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
            string Morada = "";
            string CodPostal = "";

            try
            {

                SqlDataReader dr;
                string QueryAdmin = ("SELECT Nome, Telemovel, Email, Morada, CodPostal FROM TblSocio WHERE IDSocio = " + ID);
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                    Morada = dr["Morada"].ToString();
                    CodPostal = dr["CodPostal"].ToString();
                }
                dr.Close();


                Lbl_Titulo.Text = Nome;

                lbl_Nome.Text = Nome;
                lbl_Email.Text = Email;

                if (Morada != "" && CodPostal != " ")
                {
                    lbl_Morada.Text = Morada + "    " + CodPostal;
                }
                else if (Morada != "" && CodPostal == " ")
                {
                    lbl_Morada.Text = Morada;
                }
                else if (Morada == "" && CodPostal != " ")
                {
                    morada.Text = "Cd Postal:";
                    lbl_Morada.Text = CodPostal;
                }

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
