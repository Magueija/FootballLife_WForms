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
    public partial class Equipas : Form
    {
        public Equipas()
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

//==============================================================================================


    }
}

