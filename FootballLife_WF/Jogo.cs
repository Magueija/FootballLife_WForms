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
using System.IO;

namespace FootballLife_WF
{
    public partial class Jogo : UserControl
    {
        string IDJogo = "";
        string IDEscalao = "";


        public Jogo(string IDjogo, string IDescalao, string Escalao, string Data, string EquipaCasa, string GolosCasa, string EquipaFora, string GolosFora, string patch)
        {
            InitializeComponent();

            IDJogo = IDjogo;
            IDEscalao = IDescalao;

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
                Bitmap bmp = new Bitmap(patch);
                img_Casa.Image = Properties.Resources.Logo_Clube;
                img_Fora.Image = bmp;
            }
            else if (EquipaFora == "Palmelense F.C.")
            {
                Bitmap bmp = new Bitmap(patch);
                img_Casa.Image = bmp;
                img_Fora.Image = Properties.Resources.Logo_Clube;
            }

            if (Program.CurrentFuncaoUser == "Treinador")
            {
                DeleteGame();
            }
        }

        private void DeleteGame()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();


            string IDTreinador = "";

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT IDTreinador FROM dbo.TblTreinador WHERE Apagado = 0 AND FK_IDEscalao = " + IDEscalao);
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    IDTreinador = dr["IDTreinador"].ToString();

                    if (Program.CurrentIDUser == Convert.ToInt32(IDTreinador))
                    {
                        pb_Delete.Visible = true;
                    }
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void Btn_VerJogo_Click(object sender, EventArgs e)
        {
            VerJogo verjg = new VerJogo(IDJogo);
            verjg.Show();
        }

        private void Pb_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            try
            {
                string Query = ("UPDATE TblJogo SET Apagado = 1 WHERE IDJogo = @IDJogo");
                SqlCommand Command = new SqlCommand(Query, con);
                Command.Parameters.AddWithValue("@IDJogo", IDJogo);
                Command.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();

            this.Dispose();
        }
    }
}

