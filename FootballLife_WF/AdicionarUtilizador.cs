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
    public partial class AdicionarUtilizador : Form
    {
        public AdicionarUtilizador()
        {
            InitializeComponent();
        }

        private void Cb_Funcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((cb_Funcao.SelectedItem).ToString() == "Administrador" || (cb_Funcao.SelectedItem).ToString() == "Sócio")
            {
                panel_Escalao.Visible = false;
            }
            else if ((cb_Funcao.SelectedItem).ToString() == "Treinador")
            {
                panel_Escalao.Visible = true;
                lbl_EscalaoATreinar.Visible = true;
                lbl_Escalao.Visible = false;
            }
            else if ((cb_Funcao.SelectedItem).ToString() == "Atleta")
            {
                panel_Escalao.Visible = true;
                lbl_EscalaoATreinar.Visible = false;
                lbl_Escalao.Visible = true;
            }
        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {


            this.Dispose();
        }
    }
}
