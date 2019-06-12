using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballLife_WF
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);

            InitializeComponent();
        }

        //==============================================================================================

        private void Lbl_LogIn_MouseHover(object sender, EventArgs e)
        {
            lbl_LogIn.Font = new Font("Berlin Sans FB Demi", 14, FontStyle.Underline);
        }

        private void Lbl_LogIn_MouseLeave(object sender, EventArgs e)
        {
            lbl_LogIn.Font = new Font("Berlin Sans FB Demi", 14, FontStyle.Regular);
        }

        private void Lbl_LogIn_Click(object sender, EventArgs e)
        {
            Login Lg = new Login();
            this.Hide();
            Lg.ShowDialog();
            this.Dispose();
        }

//==============================================================================================

        private void BtnHover_Jogos()
        {
            panel_Jogos.BackColor = Color.Gainsboro;
        }

        private void Btn_Jogos_MouseHover(object sender, EventArgs e)
        {
            BtnHover_Jogos();
        }

        private void Img_Jogos_MouseHover(object sender, EventArgs e)
        {
            BtnHover_Jogos();
        }

        private void Lbl_Jogos_MouseHover(object sender, EventArgs e)
        {
            BtnHover_Jogos();
        }

        //============

        private void BtnHover_Equipas()
        {
            panel_Equipas.BackColor = Color.Gainsboro;
        }

        private void Btn_Equipas_MouseHover(object sender, EventArgs e)
        {
            BtnHover_Equipas();
        }

        private void Img_Equipas_MouseHover(object sender, EventArgs e)
        {
            BtnHover_Equipas();
        }

        private void Lbl_Equipas_MouseHover(object sender, EventArgs e)
        {
            BtnHover_Equipas();
        }

        //============

        private void BtnHover_Estadio()
        {
            panel_Estadio.BackColor = Color.Gainsboro;
        }

        private void Btn_Estadio_MouseHover(object sender, EventArgs e)
        {
            BtnHover_Estadio();
        }

        private void Img_Estadio_MouseHover(object sender, EventArgs e)
        {
            BtnHover_Estadio();
        }

        private void Lbl_Estadio_MouseHover(object sender, EventArgs e)
        {
            BtnHover_Estadio();
        }

        //============

        private void BtnHover_Titulos()
        {
            panel_Titulos.BackColor = Color.Gainsboro;
        }
        private void Btn_Titulos_MouseHover(object sender, EventArgs e)
        {
            BtnHover_Titulos();
        }

        private void Img_Titulos_MouseHover(object sender, EventArgs e)
        {
            BtnHover_Titulos();
        }

        private void Lbl_Titulos_MouseHover(object sender, EventArgs e)
        {
            BtnHover_Titulos();
        }

//========================================

        private void BtnLeave_Jogos()
        {
            panel_Jogos.BackColor = Color.White;
        }

        private void Btn_Jogos_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave_Jogos();
        }

        private void Img_Jogos_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave_Jogos();
        }

        private void Lbl_Jogos_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave_Jogos();
        }

        //============

        private void BtnLeave_Equipas()
        {
            panel_Equipas.BackColor = Color.White;
        }

        private void Btn_Equipas_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave_Equipas();
        }

        private void Img_Equipas_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave_Equipas();
        }

        private void Lbl_Equipas_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave_Equipas();
        }

        //============

        private void BtnLeave_Estadio()
        {
            panel_Estadio.BackColor = Color.White;
        }

        private void Btn_Estadio_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave_Estadio();
        }

        private void Img_Estadio_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave_Estadio();
        }

        private void Lbl_Estadio_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave_Estadio();
        }

        //============

        private void BtnLeave_Titulos()
        {
            panel_Titulos.BackColor = Color.White;
        }

        private void Btn_Titulos_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave_Titulos();
        }

        private void Img_Titulos_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave_Titulos();
        }

        private void Lbl_Titulos_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave_Titulos();
        }

        private void Btn_Jogos_Click(object sender, EventArgs e)
        {
            Jogos Jogo = new Jogos();
            this.Hide();
            Jogo.ShowDialog();
            this.Dispose();
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

        private void Btn_Titulos_Click(object sender, EventArgs e)
        {
            Historia historia = new Historia();
            this.Hide();
            historia.Show();
        }
    }
}
