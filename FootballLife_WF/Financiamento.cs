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
    public partial class Financiamento : Form
    {
        public Financiamento()
        {
            InitializeComponent();
        }

//==============================================================================================

        private void Img_Menu_Click(object sender, EventArgs e)
        {
            if (panel_Menu.Visible == true && btn_Menu.Visible == true)
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

        private void Financiamento_Load(object sender, EventArgs e)
        {
            Saldo();
            Lucros();
            Despesas();
        }

        private void Saldo()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            int Saldo = 0;

            try
            {
                SqlDataReader dr;
                string Query = ("SELECT IDClube, Saldo FROM dbo.TblClube WHERE(IDClube = 1)");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    Saldo = Convert.ToInt32(dr["Saldo"]);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();

            if(Saldo > 0)
            {
                lbl_Saldo.ForeColor = Color.ForestGreen;
            }
            else
            {
                lbl_Saldo.ForeColor = Color.Firebrick;
            }

            lbl_Saldo.Text = Saldo.ToString() +" €";
        }

        private void Lucros()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeLucro = "";
            string Valor = "";

            try
            {
                SqlDataReader dr;
                string Query = ("[dbo].[LucrosPesquisa] '%'");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    NomeLucro = dr["Nome"].ToString();
                    Valor = dr["Valor"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 345;
                    panel.Height = 30;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    panel.Name = "Panel";
                    flowpanel_Lucros.Controls.Add(panel);

                    Label Nome = new Label();
                    Nome.Location = new Point(10, 5);
                    Nome.Text = NomeLucro += ":";
                    Nome.Width = 230;
                    Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                    Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Nome.Visible = true;
                    panel.Controls.Add(Nome);

                    Label lblValor = new Label();
                    lblValor.Location = new Point(250, 5);
                    lblValor.Text = Valor + " +";
                    lblValor.Width = 90;
                    lblValor.ForeColor = Color.ForestGreen;
                    lblValor.RightToLeft = RightToLeft.Yes;
                    lblValor.Font = new Font("Arial", 10, FontStyle.Regular);
                    lblValor.Anchor = AnchorStyles.Top;
                    lblValor.Visible = true;
                    panel.Controls.Add(lblValor);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void Despesas()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeLucro = "";
            string Valor = "";

            try
            {
                SqlDataReader dr;
                string Query = ("[dbo].[DespesasPesquisa] '%'");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    NomeLucro = dr["Nome"].ToString();
                    Valor = dr["Valor"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 345;
                    panel.Height = 30;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    panel.Name = "Panel";
                    flowpanel_Despesas.Controls.Add(panel);

                    Label Nome = new Label();
                    Nome.Location = new Point(10, 5);
                    Nome.Text = NomeLucro += ":";
                    Nome.Width = 230;
                    Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                    Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Nome.Visible = true;
                    panel.Controls.Add(Nome);

                    Label lblValor = new Label();
                    lblValor.Location = new Point(250, 5);
                    lblValor.Text = Valor + " -";
                    lblValor.Width = 90;
                    lblValor.ForeColor = Color.Firebrick;
                    lblValor.RightToLeft = RightToLeft.Yes;
                    lblValor.Font = new Font("Arial", 10, FontStyle.Regular);
                    lblValor.Anchor = AnchorStyles.Top;
                    lblValor.Visible = true;
                    panel.Controls.Add(lblValor);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void Btn_Lupa_Click(object sender, EventArgs e)
        {
            flowpanel_Lucros.Controls.Clear();
            flowpanel_Despesas.Controls.Clear();

            if (tb_Pesquisar.Text == "")
            {
                Lucros();
                Despesas();
            }
            else
            {
                PesquisaDespesas();
                PesquisaLucros();
            }
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                flowpanel_Lucros.Controls.Clear();
                flowpanel_Despesas.Controls.Clear();

                if (tb_Pesquisar.Text == "")
                {
                    Lucros();
                    Despesas();

                    lbl_SemResultados_Lucros.Visible = false;
                    lbl_SemResultados_Despesas.Visible = false;
                }
                else
                {
                    PesquisaDespesas();
                    PesquisaLucros();
                }
            }
        }

        private void PesquisaDespesas()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeLucro = "";
            string Valor = "";

            
            try
            {
                SqlDataReader dr;
                string Query = ("[dbo].[DespesasPesquisa] '" + tb_Pesquisar.Text + "'");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                flowpanel_Despesas.Controls.Clear();

                while (dr.Read())
                {

                    NomeLucro = dr["Nome"].ToString();
                    Valor = dr["Valor"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 345;
                    panel.Height = 30;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    flowpanel_Despesas.Controls.Add(panel);

                    Label Nome = new Label();
                    Nome.Location = new Point(10, 5);
                    Nome.Text = NomeLucro += ":";
                    Nome.Width = 230;
                    Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                    Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Nome.Visible = true;
                    panel.Controls.Add(Nome);

                    Label lblValor = new Label();
                    lblValor.Location = new Point(250, 5);
                    lblValor.Text = Valor + " -";
                    lblValor.Width = 90;
                    lblValor.ForeColor = Color.Firebrick;
                    lblValor.RightToLeft = RightToLeft.Yes;
                    lblValor.Font = new Font("Arial", 10, FontStyle.Regular);
                    lblValor.Anchor = AnchorStyles.Top;
                    lblValor.Visible = true;
                    panel.Controls.Add(lblValor);
                }


                if (flowpanel_Despesas.Controls.Count == 0)
                {
                    lbl_SemResultados_Despesas.Visible = true;
                }
                else
                {
                    lbl_SemResultados_Despesas.Visible = false;
                }
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            
            
            con.Close();
        }

        private void PesquisaLucros()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeLucro = "";
            string Valor = "";

            
            try
            {
                SqlDataReader dr;
                string Query = ("[dbo].[LucrosPesquisa] '" + tb_Pesquisar.Text + "'");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();

                flowpanel_Lucros.Controls.Clear();

                while (dr.Read())
                {

                    NomeLucro = dr["Nome"].ToString();
                    Valor = dr["Valor"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 345;
                    panel.Height = 30;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    flowpanel_Lucros.Controls.Add(panel);

                    Label Nome = new Label();
                    Nome.Location = new Point(10, 5);
                    Nome.Text = NomeLucro += ":";
                    Nome.Width = 230;
                    Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                    Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Nome.Visible = true;
                    panel.Controls.Add(Nome);

                    Label lblValor = new Label();
                    lblValor.Location = new Point(250, 5);
                    lblValor.Text =  Valor + " +";
                    lblValor.Width = 90;
                    lblValor.ForeColor = Color.ForestGreen;
                    lblValor.RightToLeft = RightToLeft.Yes;
                    lblValor.Font = new Font("Arial", 10, FontStyle.Regular);
                    lblValor.Anchor = AnchorStyles.Top;
                    lblValor.Visible = true;
                    panel.Controls.Add(lblValor);
                }
                    
                    
                if(flowpanel_Lucros.Controls.Count == 0)
                {
                    lbl_SemResultados_Lucros.Visible = true;
                }
                else
                {
                    lbl_SemResultados_Lucros.Visible = false;
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            
        }

        private void Tb_Pesquisar_TextChanged(object sender, EventArgs e)
        {
            if (tb_Pesquisar.Text == "")
            {
                flowpanel_Lucros.Controls.Clear();
                flowpanel_Despesas.Controls.Clear();

                Lucros();
                Despesas();

                lbl_SemResultados_Lucros.Visible = false;
                lbl_SemResultados_Despesas.Visible = false;
            }
        }

        private void Btn_AddLucros_MouseHover(object sender, EventArgs e)
        {
            lbl_AddLucros.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Underline);
        }

        private void Btn_AddLucros_MouseLeave(object sender, EventArgs e)
        {
            lbl_AddLucros.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Regular);
        }

        private void Btn_AddDespesas_MouseHover(object sender, EventArgs e)
        {
            lbl_AddDespesas.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Underline);
        }

        private void Btn_AddDespesas_MouseLeave(object sender, EventArgs e)
        {
            lbl_AddDespesas.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Regular);
        }

        private void Btn_AddLucros_Click(object sender, EventArgs e)
        {
            Add_LucroDespesa AddLucro = new Add_LucroDespesa("Lucros");
            AddLucro.Show();
        }

        private void Btn_AddDespesas_Click(object sender, EventArgs e)
        {
            Add_LucroDespesa AddDespesas = new Add_LucroDespesa("Despesas");
            AddDespesas.Show();
        }

        private void Btn_DeletePesquisa_Click(object sender, EventArgs e)
        {
            tb_Pesquisar.Text = "";
        }


        //==============================================================================================
    }
}
