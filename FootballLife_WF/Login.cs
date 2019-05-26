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
using System.Data.Sql;

namespace FootballLife_WF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            if (Properties.Settings.Default.username != string.Empty)
            {
                tb_Utilizador.Text = Properties.Settings.Default.username;
                tb_Password.Text = Properties.Settings.Default.password;
                chb_Lembrar.Checked = true;
            }
        }

        private void Img_Logo_Click(object sender, EventArgs e)
        {
            PaginaInicial PagIn = new PaginaInicial();
            this.Hide();
            PagIn.ShowDialog();
            this.Dispose();
        }

        private void Img_BackArrow_MouseHover(object sender, EventArgs e)
        {
            img_BackArrow.Image = Properties.Resources.Back_Hover;
        }

        private void Img_BackArrow_MouseLeave(object sender, EventArgs e)
        {
            img_BackArrow.Image = Properties.Resources.Back_Normal;
        }

        private void Img_BackArrow_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogIn();
            }
        }

        public int IDLogIn { get; set; }

        private void LogIn()
        {
            if (chb_Lembrar.Checked)
            {
                Properties.Settings.Default.username = tb_Utilizador.Text;
                Properties.Settings.Default.password = tb_Password.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            
            string IDAdmin = "";
            string userAdmin = "";
            string passAdmin = "";

            string IDTreinador = "";
            string userTreinador = "";
            string passTreinador = "";

            string IDAtleta = "";
            string userAtleta = "";
            string passAtleta = "";

            string IDSocio = "";
            string userSocio = "";
            string passSocio = "";

            try
            {

                SqlDataReader dr;
                //Administrador
                string QueryAdmin = ("SELECT IDAdministrador, Utilizador, Palavra_Chave FROM TblAdministrador");
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);
                dr = CommandAdmin.ExecuteReader();
                while (dr.Read())
                {
                    IDAdmin = dr["IDAdministrador"].ToString();
                    userAdmin = dr["Utilizador"].ToString();
                    passAdmin = dr["Palavra_Chave"].ToString();
                }
                dr.Close();

                //Treinador
                string QueryTreinador = ("SELECT IDTreinador, Utilizador, Palavra_Chave FROM TblTreinador");
                SqlCommand CommandTreinador = new SqlCommand(QueryTreinador, con);
                dr = CommandTreinador.ExecuteReader();
                while (dr.Read())
                {
                    IDTreinador = dr["IDTreinador"].ToString();
                    userTreinador = dr["Utilizador"].ToString();
                    passTreinador = dr["Palavra_Chave"].ToString();
                }
                dr.Close();

                //Atleta
                string QueryAtleta = ("SELECT IDAtleta, Utilizador, Palavra_Chave FROM TblAtleta");
                SqlCommand CommandAtleta = new SqlCommand(QueryAtleta, con);
                dr = CommandAtleta.ExecuteReader();
                while (dr.Read())
                {
                    IDAtleta = dr["IDAtleta"].ToString();
                    userAtleta = dr["Utilizador"].ToString();
                    passAtleta = dr["Palavra_Chave"].ToString();
                }
                dr.Close();

                //Socio
                string QuerySocio = ("SELECT IDSocio, Utilizador, Palavra_Chave FROM TblSocio");
                SqlCommand CommandSocio = new SqlCommand(QuerySocio, con);
                dr = CommandSocio.ExecuteReader();
                while (dr.Read())
                {
                    IDSocio = dr["IDSocio"].ToString();
                    userSocio = dr["Utilizador"].ToString();
                    passSocio = dr["Palavra_Chave"].ToString();
                }
                dr.Close();



                if (tb_Utilizador.Text == userAdmin && tb_Password.Text == passAdmin)
                {
                    Properties.Settings.Default.IDUser = Convert.ToInt32(IDAdmin);
                    Properties.Settings.Default.FuncaoUser = "Admin";
                    Properties.Settings.Default.Save();

                    PaginaInicial_Admin PgAdmin = new PaginaInicial_Admin();
                    this.Hide();
                    PgAdmin.ShowDialog();
                    this.Dispose();
                }
                else if (tb_Utilizador.Text == userTreinador && tb_Password.Text == passTreinador)
                {
                    Properties.Settings.Default.IDUser = Convert.ToInt32(IDTreinador);
                    Properties.Settings.Default.FuncaoUser = "Treinador";
                    Properties.Settings.Default.Save();

                    PaginaInicial_Treinador PgTrein = new PaginaInicial_Treinador();
                    this.Hide();
                    PgTrein.ShowDialog();
                    this.Dispose();
                }
                else if (tb_Utilizador.Text == userAtleta && tb_Password.Text == passAtleta)
                {
                    Properties.Settings.Default.IDUser = Convert.ToInt32(IDAtleta);
                    Properties.Settings.Default.FuncaoUser = "Atleta";
                    Properties.Settings.Default.Save();

                    PaginaInicial_Atleta PgAtl = new PaginaInicial_Atleta();
                    this.Hide();
                    PgAtl.ShowDialog();
                    this.Dispose();
                }
                else if (tb_Utilizador.Text == userSocio && tb_Password.Text == passSocio)
                {
                    Properties.Settings.Default.IDUser = Convert.ToInt32(IDSocio);
                    Properties.Settings.Default.FuncaoUser = "Socio";
                    Properties.Settings.Default.Save();

                    PaginaInicial_Socio PgSoc = new PaginaInicial_Socio();
                    this.Hide();
                    PgSoc.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    lbl_LoginError.Visible = true;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void Lbl_EsqueceuPassword_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se esqueceu-se da sua password, por favor contacte um dos administradores para alterar ou verificar a sua password. Obrigado!\nDeseja ver os contactos da Administração?","Esqueceu a sua password?",MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ContactosAdministracao Emails = new ContactosAdministracao();
                Emails.Show();
            }
        }
    }
}
