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
    public partial class Cota : Form
    {
        public Cota()
        {
            InitializeComponent();
        }

        private void Cota_Load(object sender, EventArgs e)
        {
            CotaAPagar();
        }

        private void CotaAPagar()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            int Cota = 0;
            string valor = "";

            try
            {
                if (Properties.Settings.Default.FuncaoUser == "Atleta")
                {
                    SqlDataReader dr;
                    string Query = ("SELECT dbo.TblCotaAtleta.Valor FROM dbo.TblCotaAtleta INNER JOIN dbo.TblAtleta ON dbo.TblCotaAtleta.FK_IDAtleta = dbo.TblAtleta.IDAtleta INNER JOIN " +
                        "dbo.TblMes ON dbo.TblCotaAtleta.FK_IDMes = dbo.TblMes.IDMes WHERE (dbo.TblCotaAtleta.Pago = 0) AND (dbo.TblAtleta.Apagado = 0) AND (dbo.TblAtleta.IDAtleta = " + Properties.Settings.Default.IDUser + ")");
                    SqlCommand Command = new SqlCommand(Query, con);
                    dr = Command.ExecuteReader();
                    while (dr.Read())
                    {
                        valor = dr["Valor"].ToString();

                        Cota += Convert.ToInt32(valor);
                    }
                    

                    if (Cota != 0)
                    {
                        lbl_CotaPagar.Text = Cota.ToString() + " €";

                        panel_APagar.Visible = true;
                        panel_Pago.Visible = false;
                    }
                    else
                    {
                        panel_APagar.Visible = false;
                        panel_Pago.Visible = true;
                    }
                    dr.Close();
                }
                else if (Properties.Settings.Default.FuncaoUser == "Socio")
                {
                    SqlDataReader dr;
                    string Query = ("SELECT dbo.TblCotaSocio.Valor FROM dbo.TblMes INNER JOIN dbo.TblCotaSocio ON dbo.TblMes.IDMes = dbo.TblCotaSocio.FK_IDMes INNER JOIN dbo.TblSocio ON " +
                        "dbo.TblCotaSocio.FK_IDSocio = dbo.TblSocio.IDSocio WHERE (dbo.TblCotaSocio.Pago = 0) AND (dbo.TblSocio.Apagado = 0) AND (dbo.TblSocio.IDSocio = " + Properties.Settings.Default.IDUser + ")");
                    SqlCommand Command = new SqlCommand(Query, con);
                    dr = Command.ExecuteReader();
                    while (dr.Read())
                    {
                        valor = dr["Valor"].ToString();

                        Cota += Convert.ToInt32(valor);
                    }
                    

                    if (Cota != 0)
                    {
                        lbl_CotaPagar.Text = Cota.ToString() + " €";

                        panel_APagar.Visible = true;
                        panel_Pago.Visible = false;
                    }
                    else
                    {
                        panel_APagar.Visible = false;
                        panel_Pago.Visible = true;
                    }
                    dr.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
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

    
        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            PaginaInicial PgInicio = new PaginaInicial();
            this.Hide();
            PgInicio.ShowDialog();
            this.Dispose();
        }

        private void Tb_ValMes_Click(object sender, EventArgs e)
        {
            if(tb_ValMes.Text == "MM")
            {
                tb_ValMes.Text = "";
            }
        }

        private void Tb_ValAno_Click(object sender, EventArgs e)
        {
            if (tb_ValAno.Text == "AA")
            {
                tb_ValAno.Text = "";
            }
        }

        private void Img_PayPal_Click(object sender, EventArgs e)
        {
            img_Visa.Width = 50;
            img_Visa.BorderStyle = BorderStyle.None;
            img_MasterCard.Width = 50;
            img_MasterCard.BorderStyle = BorderStyle.None;

            img_PayPal.Width = 80;
            img_PayPal.BorderStyle = BorderStyle.FixedSingle;

            panel_Paypal.Visible = true;
            panel_cartao.Visible = false;
        }
       

        private void Img_Visa_Click(object sender, EventArgs e)
        {
            img_PayPal.Width = 50;
            img_PayPal.BorderStyle = BorderStyle.None;
            img_MasterCard.Width = 50;
            img_MasterCard.BorderStyle = BorderStyle.None;

            img_Visa.Width = 80;
            img_Visa.BorderStyle = BorderStyle.FixedSingle;

            panel_cartao.Visible = true;
            panel_Paypal.Visible = false;
        }

        private void Img_MasterCard_Click(object sender, EventArgs e)
        {
            img_PayPal.Width = 50;
            img_PayPal.BorderStyle = BorderStyle.None;
            img_Visa.Width = 50;
            img_Visa.BorderStyle = BorderStyle.None;

            img_MasterCard.Width = 80;
            img_MasterCard.BorderStyle = BorderStyle.FixedSingle;

            panel_cartao.Visible = true;
            panel_Paypal.Visible = false;
        }

        private void Btn_Pagar_Click(object sender, EventArgs e)
        {
            if (panel_Paypal.Visible == true && tb_PPEmail.Text == string.Empty || panel_Paypal.Visible == true && tb_PPPass.Text == string.Empty)
            {
                MessageBox.Show("Campos não preenchidos!", "ATENÇÃO!", MessageBoxButtons.OK);
            }
            else if (panel_cartao.Visible == true && tb_NumeroCartao.Text == string.Empty ||
                    panel_cartao.Visible == true && tb_CVV.Text == string.Empty ||
                    panel_cartao.Visible == true && tb_NomeCartao.Text == string.Empty ||
                    panel_cartao.Visible == true && tb_ValMes.Text == string.Empty ||
                    panel_cartao.Visible == true && tb_ValMes.Text == "MM" ||
                    panel_cartao.Visible == true && tb_ValAno.Text == string.Empty ||
                    panel_cartao.Visible == true && tb_ValAno.Text == "AA")
                 {
                    MessageBox.Show("Campos não preenchidos!", "ATENÇÃO!", MessageBoxButtons.OK);
                 }
            else if (panel_cartao.Visible == false && panel_Paypal.Visible == false)
            {
                MessageBox.Show("Por favor insira um método de pagamento!", "ATENÇÃO!", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
                con.Open();

                int Cota = 0;
                string valor = "";

                try
                {
                    SqlDataReader dr;
                    string Query = ("SELECT dbo.TblCotaAtleta.Valor FROM dbo.TblCotaAtleta INNER JOIN dbo.TblAtleta ON dbo.TblCotaAtleta.FK_IDAtleta = dbo.TblAtleta.IDAtleta INNER JOIN " +
                        "dbo.TblMes ON dbo.TblCotaAtleta.FK_IDMes = dbo.TblMes.IDMes WHERE (dbo.TblCotaAtleta.Pago = 0) AND (dbo.TblAtleta.IDAtleta = " + Properties.Settings.Default.IDUser + ")");
                    SqlCommand Command = new SqlCommand(Query, con);
                    dr = Command.ExecuteReader();
                    while (dr.Read())
                    {
                        valor = dr["Valor"].ToString();

                        Cota += Convert.ToInt32(valor);
                    }
                    dr.Close();

                    lbl_CotaPagar.Text = Cota.ToString();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                con.Close();
            }
        }




        //==============================================================================================


    }
}

