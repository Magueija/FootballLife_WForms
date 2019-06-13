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
using System.IO;

namespace FootballLife_WF
{
    public partial class Jogos : Form
    {
        public Jogos()
        {
            InitializeComponent();

            if(Program.CurrentFuncaoUser == "Treinador")
            {
                btn_NovoResultado.Visible = true;
                lbl_NovoResultado.Visible = true;
                img_NovoResultado.Visible = true;
            }
            else
            {
                btn_NovoResultado.Visible = false;
                lbl_NovoResultado.Visible = false;
                img_NovoResultado.Visible = false;
            }
        }

        //Verifica se é o current User ou se é um adepto
        private void Jogos_Load(object sender, EventArgs e)
        {
            JogoTodos();

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

            if(Program.CurrentFuncaoUser != "")
            {
                btn_LogOut.Visible = true;
                img_LogOut.Visible = true;
                lbl_Terminar.Visible = true;
                lbl_Sessao.Visible = true;
            }
        }


        //==============================================================================================


        private void NovoResultado_MouseHover(object sender, EventArgs e)
        {
            lbl_NovoResultado.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Underline);
        }
        private void NovoResultado_MouseLeave(object sender, EventArgs e)
        {
            lbl_NovoResultado.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Regular);
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


        //==============================================================================================


        private void Jogo(string IDEscalao)
        {
            flowpanel_Jogos.Controls.Clear();

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
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void JogoTodos()
        {
            flowpanel_Jogos.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();


            string IDJogo = "";
            string IDEscalao = "";
            string Escalao = "";
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
                    IDEscalao = dr["IDEscalao"].ToString();
                    Escalao = dr["Escalao"].ToString();
                    Data = dr["Data"].ToString();

                    EquipaCasa = dr["EquipaCasa"].ToString();
                    GolosCasa = dr["GolosCasa"].ToString();

                    EquipaFora = dr["EquipaFora"].ToString();
                    GolosFora = dr["GolosFora"].ToString();

                    patch = dr["Path_ImgAdversario"].ToString();

                    Jogo jogo = new Jogo(IDJogo, IDEscalao, Escalao, Data, EquipaCasa, GolosCasa, EquipaFora, GolosFora, patch);
                    flowpanel_Jogos.Controls.Add(jogo);
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
       

        //==============================================================================================


        //Side Menu
        private void Img_Menu_Click(object sender, EventArgs e)
        {
            if (panel_Menu.Visible == true && btn_Menu.Visible == true)
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



        private void NovoResultado_Click(object sender, EventArgs e)
        {
            NovoResultado jogo = new NovoResultado();
            jogo.ShowDialog();

            JogoTodos();
        }


        //Side Menu buttons click
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
            else
            {
                PaginaInicial PgInicio = new PaginaInicial();
                this.Hide();
                PgInicio.ShowDialog();
                this.Dispose();
            }

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

        //Side menu buttons click, se nao for adepto
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

        private void Btn3_Click(object sender, EventArgs e)
        {
            Utilizadores users = new Utilizadores();
            this.Hide();
            users.ShowDialog();
            this.Dispose();
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
    }
}

