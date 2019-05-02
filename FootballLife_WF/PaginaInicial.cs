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
            InitializeComponent();
        }

//=========================================================================

        private void BtnHover_Jogos()
        {
            panel_Jogos.BackColor = Color.Gainsboro;
        }

        private void BtnHover_Equipas()
        {
            panel_Jogos.BackColor = Color.Gainsboro;
        }

        private void BtnHover_Estadio()
        {
            panel_Jogos.BackColor = Color.Gainsboro;
        }

        private void BtnHover_Titulos()
        {
            panel_Jogos.BackColor = Color.Gainsboro;
        }

//========================================

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

//========================================



//=========================================================================

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

//=========================================================================

        private void Lbl_LogIn_MouseHover(object sender, EventArgs e)
        {
            lbl_LogIn.Font = new Font("Berlin Sans FB Demi", 14, FontStyle.Underline);
        }

        private void Lbl_LogIn_MouseLeave(object sender, EventArgs e)
        {
            lbl_LogIn.Font = new Font("Berlin Sans FB Demi", 14, FontStyle.Regular);
        }
    }
}
