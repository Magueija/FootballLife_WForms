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

        private void Btn_Estadio_Click(object sender, EventArgs e)
        {
            Estadio Estadio = new Estadio();
            this.Hide();
            Estadio.ShowDialog();
        }

        private void Btn_Titulos_Click(object sender, EventArgs e)
        {

        }
    }
}

