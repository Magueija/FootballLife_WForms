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
    public partial class PaginaInicial_Socio : Form
    {
        public PaginaInicial_Socio()
        {
            InitializeComponent();
        }

        private void PaginaInicial_Socio_Load(object sender, EventArgs e)
        {
            JogoTodos();
        }

//==============================================================================================

        private void Img_Menu_Click(object sender, EventArgs e)
        {
            if(panel_Menu.Visible == true && btn_Menu.Visible == true)
            {
                panel_Menu.Visible = false;
                btn_Menu.Visible = false;
            }
            else
            {
                panel_Menu.Visible = true;
                btn_Menu.Visible = true;
            }
        }

//==============================================================================================

        private void Chb_Todos_Click(object sender, EventArgs e)
        {
            if (chb_Seniores.Checked == true)
            {
                chb_Seniores.Checked = false;
            }

            if (chb_Juniores.Checked == true)
            {
                chb_Juniores.Checked = false;
            }

            if (chb_Juvenis.Checked == true)
            {
                chb_Juvenis.Checked = false;
            }

            if (chb_Iniciados.Checked == true)
            {
                chb_Iniciados.Checked = false;
            }

            if (chb_Infantis.Checked == true)
            {
                chb_Infantis.Checked = false;
            }

            if (chb_Benjamins.Checked == true)
            {
                chb_Benjamins.Checked = false;
            }

            if (chb_Traquinas.Checked == true)
            {
                chb_Traquinas.Checked = false;
            }

            if (chb_Petizes.Checked == true)
            {
                chb_Petizes.Checked = false;
            }
        }

        private void Chb_Click(object sender, EventArgs e)
        {
            if (chb_Todos.Checked == true)
            {
                chb_Todos.Checked = false;
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

        private void Jogo(string IDEscalao)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();


            string IDJogo = "";
            string Escalao = "";
            string idescalao = "";
            string Data = "";

            string EquipaCasa = "";
            string GolosCasa = "";

            string EquipaFora = "";
            string GolosFora = "";

            string patch = "";


            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblJogo.IDJogo, dbo.TblJogo.Data, dbo.TblJogo.EquipaCasa, dbo.TblJogo.EquipaFora, dbo.TblJogo.GolosCasa, dbo.TblEscalao.IDEscalao, dbo.TblEscalao.Escalao, dbo.TblJogo.GolosFora, dbo.TblJogo.Path_ImgAdversario FROM dbo.TblJogo INNER JOIN dbo.TblEscalao ON dbo.TblJogo.FK_IDEscalao = dbo.TblEscalao.IDEscalao WHERE (dbo.TblJogo.Apagado = 0) AND dbo.TblJogo.FK_IDEscalao = " + IDEscalao + " ORDER BY dbo.TblJogo.Data DESC");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    IDJogo = dr["IDJogo"].ToString();
                    idescalao = dr["IDEscalao"].ToString();
                    Escalao = dr["Escalao"].ToString();
                    Data = dr["Data"].ToString();

                    EquipaCasa = dr["EquipaCasa"].ToString();
                    GolosCasa = dr["GolosCasa"].ToString();

                    EquipaFora = dr["EquipaFora"].ToString();
                    GolosFora = dr["GolosFora"].ToString();

                    patch = dr["Path_ImgAdversario"].ToString();

                    Jogo jogo = new Jogo(IDJogo, idescalao, Escalao, Data, EquipaCasa, GolosCasa, EquipaFora, GolosFora, patch);
                    flowpanel_Jogos.Controls.Add(jogo);
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void JogoTodos()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();


            string IDJogo = "";
            string Escalao = "";
            string idescalao = "";
            string Data = "";

            string EquipaCasa = "";
            string GolosCasa = "";

            string EquipaFora = "";
            string GolosFora = "";

            string patch = "";


            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblJogo.IDJogo, dbo.TblJogo.Data, dbo.TblJogo.EquipaCasa, dbo.TblJogo.EquipaFora, dbo.TblJogo.GolosCasa, dbo.TblEscalao.IDEscalao, dbo.TblEscalao.Escalao, dbo.TblJogo.GolosFora, dbo.TblJogo.Path_ImgAdversario FROM dbo.TblJogo INNER JOIN dbo.TblEscalao ON dbo.TblJogo.FK_IDEscalao = dbo.TblEscalao.IDEscalao WHERE(dbo.TblJogo.Apagado = 0) ORDER BY dbo.TblJogo.Data DESC");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    IDJogo = dr["IDJogo"].ToString();
                    idescalao = dr["IDEscalao"].ToString();
                    Escalao = dr["Escalao"].ToString();
                    Data = dr["Data"].ToString();

                    EquipaCasa = dr["EquipaCasa"].ToString();
                    GolosCasa = dr["GolosCasa"].ToString();

                    EquipaFora = dr["EquipaFora"].ToString();
                    GolosFora = dr["GolosFora"].ToString();

                    patch = dr["Path_ImgAdversario"].ToString();

                    Jogo jogo = new Jogo(IDJogo, idescalao, Escalao, Data, EquipaCasa, GolosCasa, EquipaFora, GolosFora, patch);
                    flowpanel_Jogos.Controls.Add(jogo);
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void Chb_CheckedChanged(object sender, EventArgs e)
        {
            flowpanel_Jogos.Controls.Clear();

            if (chb_Todos.Checked == true)
            {
                JogoTodos();
            }
            else
            {
                if (chb_Seniores.Checked == true)
                {
                    Jogo("1");
                }

                if (chb_Juniores.Checked == true)
                {
                    Jogo("2");
                }

                if (chb_Juvenis.Checked == true)
                {
                    Jogo("3");
                }

                if (chb_Iniciados.Checked == true)
                {
                    Jogo("4");
                }

                if (chb_Infantis.Checked == true)
                {
                    Jogo("5");
                }

                if (chb_Benjamins.Checked == true)
                {
                    Jogo("6");
                }

                if (chb_Traquinas.Checked == true)
                {
                    Jogo("7");
                }

                if (chb_Petizes.Checked == true)
                {
                    Jogo("8");
                }
            }
        }

        private void Btn_CotaSocio_Click(object sender, EventArgs e)
        {
            Cota cota = new Cota();
            this.Hide();
            cota.ShowDialog();
            this.Dispose();
        }

        private void Btn_Contactos_Click(object sender, EventArgs e)
        {
            Utilizadores Users = new Utilizadores();
            this.Hide();
            Users.ShowDialog();
        }
    }
}

