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
    public partial class EditarUtilizador : Form
    {
        string Funcao = "";
        string ID = "";

        public EditarUtilizador(string IDUser, string FuncaoUser)
        {
            Funcao = FuncaoUser;
            ID = IDUser;
            InitializeComponent();
        }

        private void VisualizarUtilizador_Load(object sender, EventArgs e)
        {
            if(Funcao == "Admin")
            {
                panel_Escalao.Visible = false;

                Admin();
            }
            else if (Funcao == "Treinador")
            {
                lbl_EscalaoATreinar.Visible = true;
                lbl_Escalao.Visible = false;

                Treinador();
            }
            else if (Funcao == "Atleta")
            {
                lbl_EscalaoATreinar.Visible = false;
                lbl_Escalao.Visible = true;

                Atleta();
            }
            else if (Funcao == "Socio")
            {
                panel_Escalao.Visible = false;

                Socio();
            }
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
                string QueryAdmin = ("SELECT Nome, Telemovel, Email, Morada, CodPostal, Utilizador, Palavra_Chave FROM TblAdministrador WHERE IDAdministrador = " + ID);
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                    Morada = dr["Morada"].ToString();
                    CdPostal = dr["CodPostal"].ToString();

                    Utilizador = dr["Utilizador"].ToString();
                    Password = dr["Palavra_Chave"].ToString();
                }
                dr.Close();


                Lbl_Titulo.Text = Nome;

                tb_Nome.Text = Nome;
                
                tb_Email.Text = Email;
                tb_Morada.Text = Morada;
                tb_CodPostal.Text = CdPostal;

                tb_Utilizador.Text = Utilizador;
                tb_Password.Text = Password;

                if(Telemovel != "0")
                {
                    tb_Telemovel.Text = Telemovel;
                }
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string Escalao = "";

            string Utilizador = "";
            string Password = "";

            try
            {

                SqlDataReader dr;
                string QueryAdmin = ("SELECT dbo.TblTreinador.Nome, dbo.TblTreinador.Telemovel, dbo.TblTreinador.Email, dbo.TblTreinador.Morada, dbo.TblTreinador.CodPostal, dbo.TblEscalao.IDEscalao, dbo.TblTreinador.Utilizador, dbo.TblTreinador.Palavra_Chave "
                                        + "FROM dbo.TblTreinador INNER JOIN dbo.TblEscalao ON dbo.TblTreinador.FK_IDEscalao = dbo.TblEscalao.IDEscalao WHERE (dbo.TblTreinador.IDTreinador = " + ID + ")");
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                    Morada = dr["Morada"].ToString();
                    CdPostal = dr["CodPostal"].ToString();
                    Escalao = dr["IDEscalao"].ToString();

                    Utilizador = dr["Utilizador"].ToString();
                    Password = dr["Palavra_Chave"].ToString();
                }
                dr.Close();


                if (Escalao == "1")
                {
                    rb_Seniores.Checked = true;
                }
                else if (Escalao == "2")
                {
                    rb_Juniores.Checked = true;
                }
                else if (Escalao == "3")
                {
                    rb_Juvenis.Checked = true;
                }
                else if (Escalao == "4")
                {
                    rb_Iniciados.Checked = true;
                }
                else if (Escalao == "5")
                {
                    rb_Infantis.Checked = true;
                }
                else if (Escalao == "6")
                {
                    rb_Benjamins.Checked = true;
                }
                else if (Escalao == "7")
                {
                    rb_Traquinas.Checked = true;
                }
                else if (Escalao == "8")
                {
                    rb_Petizes.Checked = true;
                }

                Lbl_Titulo.Text = Nome;

                tb_Nome.Text = Nome;
                tb_Email.Text = Email;
                tb_Morada.Text = Morada;
                tb_CodPostal.Text = CdPostal;

                tb_Utilizador.Text = Utilizador;
                tb_Password.Text = Password;

                if (Telemovel != "0")
                {
                    tb_Telemovel.Text = Telemovel;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string Escalao = "";

            string Utilizador = "";
            string Password = "";

            try
            {

                SqlDataReader dr;
                string QueryAdmin = ("SELECT dbo.TblAtleta.Nome, dbo.TblAtleta.Telemovel, dbo.TblAtleta.Email, dbo.TblAtleta.Morada, dbo.TblAtleta.CodPostal, dbo.TblEscalao.IDEscalao, dbo.TblAtleta.Utilizador, dbo.TblAtleta.Palavra_Chave "
                                        + "FROM dbo.TblAtleta INNER JOIN dbo.TblEscalao ON dbo.TblAtleta.FK_IDEscalao = dbo.TblEscalao.IDEscalao WHERE (dbo.TblAtleta.IDAtleta = " + ID + ")");
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                    Morada = dr["Morada"].ToString();
                    CdPostal = dr["CodPostal"].ToString();
                    Escalao = dr["IDEscalao"].ToString();

                    Utilizador = dr["Utilizador"].ToString();
                    Password = dr["Palavra_Chave"].ToString();
                }
                dr.Close();


                if (Escalao == "1")
                {
                    rb_Seniores.Checked = true;
                }
                else if (Escalao == "2")
                {
                    rb_Juniores.Checked = true;
                }
                else if (Escalao == "3")
                {
                    rb_Juvenis.Checked = true;
                }
                else if (Escalao == "4")
                {
                    rb_Iniciados.Checked = true;
                }
                else if (Escalao == "5")
                {
                    rb_Infantis.Checked = true;
                }
                else if (Escalao == "6")
                {
                    rb_Benjamins.Checked = true;
                }
                else if (Escalao == "7")
                {
                    rb_Traquinas.Checked = true;
                }
                else if (Escalao == "8")
                {
                    rb_Petizes.Checked = true;
                }

                Lbl_Titulo.Text = Nome;

                tb_Nome.Text = Nome;
                tb_Email.Text = Email;
                tb_Morada.Text = Morada;
                tb_CodPostal.Text = CdPostal;

                tb_Utilizador.Text = Utilizador;
                tb_Password.Text = Password;

                if (Telemovel != "0")
                {
                    tb_Telemovel.Text = Telemovel;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string QueryAdmin = ("SELECT Nome, Telemovel, Email, Morada, CodPostal, Utilizador, Palavra_Chave FROM TblSocio WHERE IDSocio = " + ID);
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr["Nome"].ToString();
                    Telemovel = dr["Telemovel"].ToString();
                    Email = dr["Email"].ToString();
                    Morada = dr["Morada"].ToString();
                    CdPostal = dr["CodPostal"].ToString();

                    Utilizador = dr["Utilizador"].ToString();
                    Password = dr["Palavra_Chave"].ToString();
                }
                dr.Close();


                Lbl_Titulo.Text = Nome;

                tb_Nome.Text = Nome;
                tb_Email.Text = Email;
                tb_Morada.Text = Morada;
                tb_CodPostal.Text = CdPostal;

                tb_Utilizador.Text = Utilizador;
                tb_Password.Text = Password;

                if (Telemovel != "0")
                {
                    tb_Telemovel.Text = Telemovel;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }


        //================================================================================================


        //Gravar
        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            if (Funcao == "Admin")
            {
                GravarAdmin();
            }
            else if (Funcao == "Treinador")
            {
                GravarTreinador();
            }
            else if (Funcao == "Atleta")
            {
                GravarAtleta();
            }
            else if (Funcao == "Socio")
            {
                GravarSocio();
            }

            this.Dispose();
        }

        private void GravarAdmin()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            try
            {
                string QueryINSERT = "UPDATE dbo.TblAdministrador SET Nome = @Nome, Telemovel = @Telemovel, Email = @Email, Morada = @Morada, CodPostal = @CdPostal, Utilizador = @Utilizador, Palavra_Chave = @Password WHERE IDAdministrador = " + ID;

                SqlCommand CommandINSERT = new SqlCommand(QueryINSERT, con);
                CommandINSERT.Parameters.AddWithValue("@Nome", tb_Nome.Text);
                CommandINSERT.Parameters.AddWithValue("@Telemovel", tb_Telemovel.Text);
                CommandINSERT.Parameters.AddWithValue("@Email", tb_Email.Text);
                CommandINSERT.Parameters.AddWithValue("@Morada", tb_Morada.Text);
                CommandINSERT.Parameters.AddWithValue("@CdPostal", tb_CodPostal.Text);

                CommandINSERT.Parameters.AddWithValue("@Utilizador", tb_Utilizador.Text);
                CommandINSERT.Parameters.AddWithValue("@Password", tb_Password.Text);
                CommandINSERT.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void GravarTreinador()
        {
            string IDEscalao = "";
            if (rb_Seniores.Checked == true)
            {
                IDEscalao = "1";
            }
            else if (rb_Juniores.Checked == true)
            {
                IDEscalao = "2";
            }
            else if (rb_Juvenis.Checked == true)
            {
                IDEscalao = "3";
            }
            else if (rb_Iniciados.Checked == true)
            {
                IDEscalao = "4";
            }
            else if (rb_Infantis.Checked == true)
            {
                IDEscalao = "5";
            }
            else if (rb_Benjamins.Checked == true)
            {
                IDEscalao = "6";
            }
            else if (rb_Traquinas.Checked == true)
            {
                IDEscalao = "7";
            }
            else if (rb_Petizes.Checked == true)
            {
                IDEscalao = "8";
            }

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            try
            {
                string QueryINSERT = "UPDATE dbo.TblTreinador SET Nome = @Nome, Telemovel = @Telemovel, Email = @Email, Morada = @Morada, CodPostal = @CdPostal, FK_IDEscalao = @Escalao, Utilizador = @Utilizador, Palavra_Chave = @Password WHERE IDTreinador = " + ID;

                SqlCommand CommandINSERT = new SqlCommand(QueryINSERT, con);
                CommandINSERT.Parameters.AddWithValue("@Nome", tb_Nome.Text);
                CommandINSERT.Parameters.AddWithValue("@Telemovel", tb_Telemovel.Text);
                CommandINSERT.Parameters.AddWithValue("@Email", tb_Email.Text);
                CommandINSERT.Parameters.AddWithValue("@Morada", tb_Morada.Text);
                CommandINSERT.Parameters.AddWithValue("@CdPostal", tb_CodPostal.Text);
                CommandINSERT.Parameters.AddWithValue("@Escalao", IDEscalao);

                CommandINSERT.Parameters.AddWithValue("@Utilizador", tb_Utilizador.Text);
                CommandINSERT.Parameters.AddWithValue("@Password", tb_Password.Text);
                CommandINSERT.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void GravarAtleta()
        {
            string IDEscalao = "";
            if (rb_Seniores.Checked == true)
            {
                IDEscalao = "1";
            }
            else if (rb_Juniores.Checked == true)
            {
                IDEscalao = "2";
            }
            else if (rb_Juvenis.Checked == true)
            {
                IDEscalao = "3";
            }
            else if (rb_Iniciados.Checked == true)
            {
                IDEscalao = "4";
            }
            else if (rb_Infantis.Checked == true)
            {
                IDEscalao = "5";
            }
            else if (rb_Benjamins.Checked == true)
            {
                IDEscalao = "6";
            }
            else if (rb_Traquinas.Checked == true)
            {
                IDEscalao = "7";
            }
            else if (rb_Petizes.Checked == true)
            {
                IDEscalao = "8";
            }

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            try
            {
                string QueryINSERT = "UPDATE dbo.TblAtleta SET Nome = @Nome, Telemovel = @Telemovel, Email = @Email, Morada = @Morada, CodPostal = @CdPostal, FK_IDEscalao = @Escalao, Utilizador = @Utilizador, Palavra_Chave = @Password WHERE IDAtleta = " + ID;

                SqlCommand CommandINSERT = new SqlCommand(QueryINSERT, con);
                CommandINSERT.Parameters.AddWithValue("@Nome", tb_Nome.Text);
                CommandINSERT.Parameters.AddWithValue("@Telemovel", tb_Telemovel.Text);
                CommandINSERT.Parameters.AddWithValue("@Email", tb_Email.Text);
                CommandINSERT.Parameters.AddWithValue("@Morada", tb_Morada.Text);
                CommandINSERT.Parameters.AddWithValue("@CdPostal", tb_CodPostal.Text);
                CommandINSERT.Parameters.AddWithValue("@Escalao", IDEscalao);

                CommandINSERT.Parameters.AddWithValue("@Utilizador", tb_Utilizador.Text);
                CommandINSERT.Parameters.AddWithValue("@Password", tb_Password.Text);
                CommandINSERT.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void GravarSocio()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            try
            {
                string QueryINSERT = "UPDATE dbo.TblSocio SET Nome = @Nome, Telemovel = @Telemovel, Email = @Email, Morada = @Morada, CodPostal = @CdPostal, Utilizador = @Utilizador, Palavra_Chave = @Password WHERE IDSocio = " + ID;

                SqlCommand CommandINSERT = new SqlCommand(QueryINSERT, con);
                CommandINSERT.Parameters.AddWithValue("@Nome", tb_Nome.Text);
                CommandINSERT.Parameters.AddWithValue("@Telemovel", tb_Telemovel.Text);
                CommandINSERT.Parameters.AddWithValue("@Email", tb_Email.Text);
                CommandINSERT.Parameters.AddWithValue("@Morada", tb_Morada.Text);
                CommandINSERT.Parameters.AddWithValue("@CdPostal", tb_CodPostal.Text);

                CommandINSERT.Parameters.AddWithValue("@Utilizador", tb_Utilizador.Text);
                CommandINSERT.Parameters.AddWithValue("@Password", tb_Password.Text);
                CommandINSERT.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }


        //=========================================================================


        private void Ckb_VerPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_VerPass.Checked == true)
            {
                tb_Password.UseSystemPasswordChar = false;
            }
            else
            {
                tb_Password.UseSystemPasswordChar = true;
            }
        }


        //=========================================================================


        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
