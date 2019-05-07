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
    public partial class PaginaInicial_Admin : Form
    {
        public PaginaInicial_Admin()
        {
            InitializeComponent();
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

        private void NovaDiscussao_Hover()
        {
            lbl_Novadiscussao.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Underline);
        }

        private void Lbl_Novadiscussao_MouseHover(object sender, EventArgs e)
        {
            NovaDiscussao_Hover();
        }

        private void Img_NovaDiscussao_MouseHover(object sender, EventArgs e)
        {
            NovaDiscussao_Hover();
        }

        private void Btn_NovaDiscussao_MouseHover(object sender, EventArgs e)
        {
            NovaDiscussao_Hover();
        }

        //============

        private void NovaDiscussao_Leave()
        {
            lbl_Novadiscussao.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Regular);
        }

        private void Lbl_Novadiscussao_MouseLeave(object sender, EventArgs e)
        {
            NovaDiscussao_Leave();
        }
        private void Img_NovaDiscussao_MouseLeave(object sender, EventArgs e)
        {
            NovaDiscussao_Leave();
        }
        private void Btn_NovaDiscussao_MouseLeave(object sender, EventArgs e)
        {
            NovaDiscussao_Leave();
        }
        
//==============================================================================================
    }
}

