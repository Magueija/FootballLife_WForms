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
        public VisualizarUtilizador()
        {
            InitializeComponent();
        }

        private void VisualizarUtilizador_Load(object sender, EventArgs e)
        {

        }

        private void Admin()
        {
            img_Logo.Image = Properties.Resources.LogoAdmin;

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string Nome = "";
            string Telemovel = "";
            string Email = "";
            string Morada = "";
            string CdPostal = "";

            string Utilizador = "";
            string Password = "";

            try
            {

                SqlDataReader dr;
                string QueryAdmin = ("SELECT Nome, Telemovel, Email, Modada, CodigoPostal, Utilizador, Palavra_Chave FROM TblAdministrador WHERE IDAdministrador =");
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                    Morada = dr["Modada"].ToString();
                    CdPostal = dr["CodigoPostal"].ToString();

                    Utilizador = dr["Utilizador"].ToString();
                    Password = dr["Palavra_Chave"].ToString();
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void Treinador()
        {
            img_Logo.Image = Properties.Resources.LogoTreinador;

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string Nome = "";
            string Telemovel = "";
            string Email = "";
            string Morada = "";
            string CdPostal = "";

            string Utilizador = "";
            string Password = "";

            try
            {

                SqlDataReader dr;
                string QueryAdmin = ("SELECT Nome, Telemovel, Email, Modada, CodigoPostal, Utilizador, Palavra_Chave FROM TblTreinador WHERE IDTreinador =");
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                    Morada = dr["Modada"].ToString();
                    CdPostal = dr["CodigoPostal"].ToString();

                    Utilizador = dr["Utilizador"].ToString();
                    Password = dr["Palavra_Chave"].ToString();
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void Atleta()
        {
            img_Logo.Image = Properties.Resources.LogoAtleta;

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string Nome = "";
            string Telemovel = "";
            string Email = "";
            string Morada = "";
            string CdPostal = "";

            string Utilizador = "";
            string Password = "";

            try
            {

                SqlDataReader dr;
                string QueryAdmin = ("SELECT Nome, Telemovel, Email, Modada, CodigoPostal, Utilizador, Palavra_Chave FROM TblAtleta WHERE IDAtleta =");
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                    Morada = dr["Modada"].ToString();
                    CdPostal = dr["CodigoPostal"].ToString();

                    Utilizador = dr["Utilizador"].ToString();
                    Password = dr["Palavra_Chave"].ToString();
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void Socio()
        {
            img_Logo.Image = Properties.Resources.LogoSocio;

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string Nome = "";
            string Telemovel = "";
            string Email = "";
            string Morada = "";
            string CdPostal = "";

            string Utilizador = "";
            string Password = "";

            try
            {

                SqlDataReader dr;
                string QueryAdmin = ("SELECT Nome, Telemovel, Email, Modada, CodigoPostal, Utilizador, Palavra_Chave FROM TblSocio WHERE IDSocio =");
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                    Morada = dr["Modada"].ToString();
                    CdPostal = dr["CodigoPostal"].ToString();

                    Utilizador = dr["Utilizador"].ToString();
                    Password = dr["Palavra_Chave"].ToString();
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
