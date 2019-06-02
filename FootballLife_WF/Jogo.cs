using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FootballLife_WF
{
    public partial class Jogo : UserControl
    {
        string ID = "";
        public Jogo(string IDJogo, string Escalao, string Data, string EquipaCasa, string GolosCasa, string EquipaFora, string GolosFora)
        {
            InitializeComponent();

            ID = IDJogo;

            lbl_Escalao.Text = Escalao;
            lbl_Data.Text = Data.Replace("-", "/");

            lbl_CEquipa.Text = EquipaCasa;
            lbl_CGolos.Text = GolosCasa;

            lbl_FEquipa.Text = EquipaFora;
            lbl_FGolos.Text = GolosFora;

            if (EquipaCasa == "Palmelense F.C." && Convert.ToInt32(GolosCasa) > Convert.ToInt32(GolosFora))
            {
                lbl_VitoriaDerrota.Text = "VITÓRIA!";
                lbl_VitoriaDerrota.ForeColor = Color.ForestGreen;
            }
            else if (EquipaFora == "Palmelense F.C." && Convert.ToInt32(GolosFora) > Convert.ToInt32(GolosCasa))
            {
                lbl_VitoriaDerrota.Text = "VITÓRIA!";
                lbl_VitoriaDerrota.ForeColor = Color.ForestGreen;
            }
            else if (Convert.ToInt32(GolosFora) == Convert.ToInt32(GolosCasa))
            {
                lbl_VitoriaDerrota.Text = "EMPATE!";
                lbl_VitoriaDerrota.ForeColor = Color.Gold;
            }
            else
            {
                lbl_VitoriaDerrota.Text = "DERROTA!";
                lbl_VitoriaDerrota.ForeColor = Color.Firebrick;
            }

            if (EquipaCasa == "Palmelense F.C.")
            {
                img_Casa.Image = Properties.Resources.Logo_Clube;
                img_Fora.Image = Properties.Resources.LogoAtleta;
            }
            else if (EquipaFora == "Palmelense F.C.")
            {
                img_Casa.Image = Properties.Resources.LogoAtleta;
                img_Fora.Image = Properties.Resources.Logo_Clube;
            }
        }

        private void Btn_VerJogo_Click(object sender, EventArgs e)
        {
            VerJogo verjg = new VerJogo(ID);
            verjg.Show();
        }
    }
}

