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
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);

            InitializeComponent();

            if (Properties.Settings.Default.username != string.Empty)
            {
                tb_Utilizador.Text = Properties.Settings.Default.username;
                tb_Password.Text = Properties.Settings.Default.password;
                chb_Lembrar.Checked = true;
            }

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lbl_Caps.Visible = true;
                img_Caps.Visible = true;
            }
            else
            {
                lbl_Caps.Visible = false;
                img_Caps.Visible = false;
            }
        }


        //======================================================================================


        //Verificacao Login
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
            string IDEscalaoTreinador = "";

            string IDAtleta = "";
            string userAtleta = "";
            string passAtleta = "";
            string IDEscalaoAtleta = "";

            string IDSocio = "";
            string userSocio = "";
            string passSocio = "";

            try
            {

                SqlDataReader dr;
                //Administrador
                string QueryAdmin = ("SELECT IDAdministrador, Utilizador, Palavra_Chave FROM TblAdministrador WHERE Apagado = 0 AND Utilizador collate SQL_Latin1_General_CP1_CS_AS LIKE @Utilizador AND Palavra_Chave collate SQL_Latin1_General_CP1_CS_AS LIKE @Palavra_Chave");
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);

                CommandAdmin.Parameters.AddWithValue("@utilizador", tb_Utilizador.Text);
                CommandAdmin.Parameters.AddWithValue("@Palavra_Chave", tb_Password.Text);

                dr = CommandAdmin.ExecuteReader();

                while (dr.Read())
                {
                    IDAdmin = dr["IDAdministrador"].ToString();
                    userAdmin = dr["Utilizador"].ToString();
                    passAdmin = dr["Palavra_Chave"].ToString();
                }
                dr.Close();

                //Treinador
                string QueryTreinador = ("SELECT IDTreinador, Utilizador, Palavra_Chave, FK_IDEscalao FROM TblTreinador WHERE Apagado = 0 AND Utilizador collate SQL_Latin1_General_CP1_CS_AS LIKE @Utilizador AND Palavra_Chave collate SQL_Latin1_General_CP1_CS_AS LIKE @Palavra_Chave");
                SqlCommand CommandTreinador = new SqlCommand(QueryTreinador, con);

                CommandTreinador.Parameters.AddWithValue("@utilizador", tb_Utilizador.Text);
                CommandTreinador.Parameters.AddWithValue("@Palavra_Chave", tb_Password.Text);

                dr = CommandTreinador.ExecuteReader();
                while (dr.Read())
                {
                    IDTreinador = dr["IDTreinador"].ToString();
                    userTreinador = dr["Utilizador"].ToString();
                    passTreinador = dr["Palavra_Chave"].ToString();
                    IDEscalaoTreinador = dr["FK_IDEscalao"].ToString();
                }
                dr.Close();

                //Atleta
                string QueryAtleta = ("SELECT IDAtleta, Utilizador, Palavra_Chave, FK_IDEscalao FROM TblAtleta WHERE Apagado = 0 AND Utilizador collate SQL_Latin1_General_CP1_CS_AS LIKE @Utilizador AND Palavra_Chave collate SQL_Latin1_General_CP1_CS_AS LIKE @Palavra_Chave");
                SqlCommand CommandAtleta = new SqlCommand(QueryAtleta, con);

                CommandAtleta.Parameters.AddWithValue("@utilizador", tb_Utilizador.Text);
                CommandAtleta.Parameters.AddWithValue("@Palavra_Chave", tb_Password.Text);

                dr = CommandAtleta.ExecuteReader();
                while (dr.Read())
                {
                    IDAtleta = dr["IDAtleta"].ToString();
                    userAtleta = dr["Utilizador"].ToString();
                    passAtleta = dr["Palavra_Chave"].ToString();
                    IDEscalaoAtleta = dr["FK_IDEscalao"].ToString();
                }
                dr.Close();

                //Socio
                string QuerySocio = ("SELECT IDSocio, Utilizador, Palavra_Chave FROM TblSocio WHERE Apagado = 0 AND Utilizador collate SQL_Latin1_General_CP1_CS_AS LIKE @Utilizador AND Palavra_Chave collate SQL_Latin1_General_CP1_CS_AS LIKE @Palavra_Chave");
                SqlCommand CommandSocio = new SqlCommand(QuerySocio, con);

                CommandSocio.Parameters.AddWithValue("@utilizador", tb_Utilizador.Text);
                CommandSocio.Parameters.AddWithValue("@Palavra_Chave", tb_Password.Text);

                dr = CommandSocio.ExecuteReader();
                while (dr.Read())
                {
                    IDSocio = dr["IDSocio"].ToString();
                    userSocio = dr["Utilizador"].ToString();
                    passSocio = dr["Palavra_Chave"].ToString();
                }
                dr.Close();



                if (IDAdmin != "")
                {
                    Program.CurrentFuncaoUser = "Admin";
                    Program.CurrentIDUser = Convert.ToInt32(IDAdmin);
                    Program.CurrentIDEscalao = 0;

                    PaginaInicial_Admin PgAdmin = new PaginaInicial_Admin();
                    this.Hide();
                    PgAdmin.ShowDialog();
                    this.Dispose();
                }
                else if (IDTreinador != "")
                {
                    Program.CurrentFuncaoUser = "Treinador";
                    Program.CurrentIDUser = Convert.ToInt32(IDTreinador);
                    Program.CurrentIDEscalao = Convert.ToInt32(IDEscalaoTreinador);

                    PaginaInicial_Treinador PgTrein = new PaginaInicial_Treinador();
                    this.Hide();
                    PgTrein.ShowDialog();
                    this.Dispose();
                }
                else if (IDAtleta != "")
                {
                    Program.CurrentFuncaoUser = "Atleta";
                    Program.CurrentIDUser = Convert.ToInt32(IDAtleta);
                    Program.CurrentIDEscalao = Convert.ToInt32(IDEscalaoAtleta);

                    PaginaInicial_Atleta PgAtl = new PaginaInicial_Atleta();
                    this.Hide();
                    PgAtl.ShowDialog();
                    this.Dispose();
                }
                else if (IDSocio != "")
                {
                    Program.CurrentFuncaoUser = "Socio";
                    Program.CurrentIDUser = Convert.ToInt32(IDSocio);
                    Program.CurrentIDEscalao = 0;

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
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
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

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lbl_Caps.Visible = true;
                img_Caps.Visible = true;
            }
            else
            {
                lbl_Caps.Visible = false;
                img_Caps.Visible = false;
            }
        }

        private void Tb_Click(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lbl_Caps.Visible = true;
                img_Caps.Visible = true;
            }
            else
            {
                lbl_Caps.Visible = false;
                img_Caps.Visible = false;
            }
        }


        //Label "Esqueceu a sua password" click
        private void Lbl_EsqueceuPassword_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se esqueceu-se da sua password, por favor contacte um dos administradores para alterar ou verificar a sua password. Obrigado!\nDeseja ver os contactos da Administração?","Esqueceu a sua password?",MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                ContactosAdministracao Emails = new ContactosAdministracao();
                Emails.Show();
            }
        }


        //============================================================================================


        //Voltar a pagina inicialk
        private void Img_Logo_Click(object sender, EventArgs e)
        {
            PaginaInicial PagIn = new PaginaInicial();
            this.Hide();
            PagIn.ShowDialog();
            this.Dispose();
        }

        //Back Arrow
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
            PaginaInicial PgInicial = new PaginaInicial();
            this.Hide();
            PgInicial.ShowDialog();
            this.Dispose();
        }
    }
}
