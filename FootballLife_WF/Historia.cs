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
    public partial class Historia : Form
    {
        public Historia()
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
        private void Btn_Home_Click(object sender, EventArgs e)
        {
            PaginaInicial PgInicio = new PaginaInicial();
            this.Hide();
            PgInicio.ShowDialog();
            this.Dispose();
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

        private void Historia_Load(object sender, EventArgs e)
        {
 
        }

        //==============================================================================================
        
        
    }
}

