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
    public partial class Estadio : Form
    {
        public Estadio()
        {
            InitializeComponent();
        }

        private void Estadio_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FuncaoUser == "Admin")
            {
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;

                btn1.Text = "FINANCIAMENTO";
                btn2.Text = "INVENTÁRIO";
                btn3.Text = "UTILIZADORES";
            }
            else if (Properties.Settings.Default.FuncaoUser == "Treinador")
            {
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;

                btn1.Text = "CONVOCATÓRIA";
                btn2.Text = "INVENTÁRIO";
                btn3.Text = "CONTACTOS";
            }
            else if (Properties.Settings.Default.FuncaoUser == "Atleta")
            {
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;

                btn1.Text = "CONVOCATÓRIA";
                btn2.Text = "COTA DE ATLETA";
                btn3.Text = "CONTACTOS";
            }
            else if (Properties.Settings.Default.FuncaoUser == "Socio")
            {
                btn1.Visible = true;
                btn2.Visible = true;

                btn1.Text = "COTA DE SÓCIO";
                btn2.Text = "CONTACTOS";
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

        private void Btn_Titulos_Click(object sender, EventArgs e)
        {
            Historia hist = new Historia();
            this.Hide();
            hist.ShowDialog();
            this.Dispose();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FuncaoUser == "Admin")
            {
                PaginaInicial_Admin PgInicio = new PaginaInicial_Admin();
                this.Hide();
                PgInicio.ShowDialog();
                this.Dispose();
            }
            else if (Properties.Settings.Default.FuncaoUser == "Treinador")
            {
                PaginaInicial_Treinador PgInicio = new PaginaInicial_Treinador();
                this.Hide();
                PgInicio.ShowDialog();
                this.Dispose();
            }
            else if (Properties.Settings.Default.FuncaoUser == "Atleta")
            {
                PaginaInicial_Atleta PgInicio = new PaginaInicial_Atleta();
                this.Hide();
                PgInicio.ShowDialog();
                this.Dispose();
            }
            else if (Properties.Settings.Default.FuncaoUser == "Socio")
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

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FuncaoUser == "Admin")
            {
                Financiamento fin = new Financiamento();
                this.Hide();
                fin.ShowDialog();
                this.Dispose();
            }
            else if (Properties.Settings.Default.FuncaoUser == "Treinador" || Properties.Settings.Default.FuncaoUser == "Atleta")
            {
                Convocatoria conv = new Convocatoria();
                this.Hide();
                conv.ShowDialog();
                this.Dispose();
            }
            else if (Properties.Settings.Default.FuncaoUser == "Socio")
            {
                Cota cota = new Cota();
                this.Hide();
                cota.ShowDialog();
                this.Dispose();
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FuncaoUser == "Admin" || Properties.Settings.Default.FuncaoUser == "Treinador")
            {
                Inventario inv = new Inventario();
                this.Hide();
                inv.ShowDialog();
                this.Dispose();
            }
            else if (Properties.Settings.Default.FuncaoUser == "Atleta")
            {
                Cota ct = new Cota();
                this.Hide();
                ct.ShowDialog();
                this.Dispose();
            }
            else if (Properties.Settings.Default.FuncaoUser == "Socio")
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
    }
}

