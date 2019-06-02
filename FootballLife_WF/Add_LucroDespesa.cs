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
    public partial class Add_LucroDespesa : Form
    {
        string LucroDespesa;

        public Add_LucroDespesa(string Nome)
        {
            InitializeComponent();
            this.Text = "Adicionar " + Nome;
            lbl_Titulo.Text = "Adicionar " + Nome;
            LucroDespesa = Nome;
            if(Nome == "Despesas")
            {
                rb_Utilizadores.Visible = false;
                rb_Outros.Visible = false;

                panel_Outros.Visible = true;
                panel_Utilizador.Visible = false;
            }
        }

        private void Add_LucroDespesa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'footballLife_DBLucro.TblMes' table. You can move, or remove it, as needed.
            this.tblMesTableAdapter.Fill(this.footballLife_DBLucro.TblMes);
            // TODO: This line of code loads data into the 'footballLife_DBLucro.TblSocio' table. You can move, or remove it, as needed.
            this.tblSocioTableAdapter.Fill(this.footballLife_DBLucro.TblSocio);
            // TODO: This line of code loads data into the 'footballLife_DBLucro.TblAtleta' table. You can move, or remove it, as needed.
            this.tblAtletaTableAdapter.Fill(this.footballLife_DBLucro.TblAtleta);
            // TODO: This line of code loads data into the 'footballLife_DBLucro.TblAtleta' table. You can move, or remove it, as needed.
            this.tblAtletaTableAdapter.Fill(this.footballLife_DBLucro.TblAtleta);
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Utilizadores.Checked == true)
            {
                panel_Outros.Visible = false;
                panel_Utilizador.Visible = true;
            }
            else if (rb_Outros.Checked == true)
            {
                panel_Outros.Visible = true;
                panel_Utilizador.Visible = false;
            }
        }

        private void Btn_GravarOutros_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string Query = "";

            if (tb_ONome.Text == "" || tb_OMontante.Text == "")
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!", "ATENÇÃO!", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    Query = "INSERT INTO dbo.Tbl" + LucroDespesa + " (Nome, Valor, Descricao, FK_IDClube) VALUES (@Nome, @Valor, @Descricao, @IDClube)";

                    SqlCommand CommandINSERT = new SqlCommand(Query, con);
                    CommandINSERT.Parameters.AddWithValue("@Nome", tb_ONome.Text);
                    CommandINSERT.Parameters.AddWithValue("@Valor", tb_OMontante.Text);
                    CommandINSERT.Parameters.AddWithValue("@Descricao", tb_ODescricao.Text);
                    CommandINSERT.Parameters.AddWithValue("@IDClube", "1");
                    CommandINSERT.ExecuteNonQuery();


                    string saldo = "";
                    SqlDataReader dr2;
                    string Query2 = ("SELECT Saldo FROM dbo.TblClube WHERE IDClube = 1");
                    SqlCommand Command2 = new SqlCommand(Query2, con);
                    dr2 = Command2.ExecuteReader();
                    while (dr2.Read())
                    {
                        saldo = dr2["Saldo"].ToString();
                    }
                    dr2.Close();


                    int novoSaldo = Convert.ToInt32(saldo);
                    if (LucroDespesa == "Lucros")
                    {
                        novoSaldo = Convert.ToInt32(saldo) + Convert.ToInt32(tb_OMontante.Text);
                    }
                    else if(LucroDespesa == "Despesas")
                    {
                        novoSaldo = Convert.ToInt32(saldo) - Convert.ToInt32(tb_OMontante.Text);
                    }

                    string Querysaldo = "UPDATE TblClube SET Saldo = @NovoSaldo WHERE IDClube = 1";
                    SqlCommand Commandsaldo = new SqlCommand(Querysaldo, con);
                    Commandsaldo.Parameters.AddWithValue("@NovoSaldo", novoSaldo);
                    Commandsaldo.ExecuteNonQuery();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                con.Close();
                this.Dispose();
            }
            
        }

        private void Btn_GravarUtilizador_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string QueryLucro = "";
            string QueryCota = "";

            string IDLucro = "";

            if(tb_UNome.Text == "" || cb_UFuncao.SelectedItem == "")
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!", "ATENÇÃO!", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    if(tb_UMontante.Text == "" && cb_UFuncao.SelectedItem == "Atleta")
                    {
                        tb_UMontante.Text = "30";
                    }
                    else if(tb_UMontante.Text == "" && cb_UFuncao.SelectedItem == "Sócio")
                    {
                        tb_UMontante.Text = "5";
                    }

                    QueryLucro = "INSERT INTO dbo.TblLucros (Nome, Valor, Descricao, FK_IDClube) VALUES (@Nome, @Valor, @Descricao, @IDClube)";

                    SqlCommand CommandLucro = new SqlCommand(QueryLucro, con);
                    CommandLucro.Parameters.AddWithValue("@Nome", tb_UNome.Text);
                    CommandLucro.Parameters.AddWithValue("@Valor", tb_UMontante.Text);
                    CommandLucro.Parameters.AddWithValue("@Descricao", tb_UDescricao.Text);
                    CommandLucro.Parameters.AddWithValue("@IDClube", "1");
                    CommandLucro.ExecuteNonQuery();

                    SqlDataReader dr;
                    string Query = ("SELECT MAX(IDLucro) AS MaxLucro FROM dbo.TblLucros");
                    SqlCommand Command = new SqlCommand(Query, con);
                    dr = Command.ExecuteReader();
                    while (dr.Read())
                    {
                        IDLucro = dr["MaxLucro"].ToString();
                    }
                    dr.Close();


                    if (cb_UFuncao.SelectedItem == "Atleta")
                    {
                        QueryCota = "INSERT INTO dbo.TblCotaAtleta (Valor, FK_IDMes, FK_IDAtleta, FK_IDLucro) VALUES (@Valor, @IDMes, @IDAtleta, @IDLucro)";

                        SqlCommand CommandCota = new SqlCommand(QueryCota, con);
                        CommandCota.Parameters.AddWithValue("@Valor", tb_UMontante.Text);
                        CommandCota.Parameters.AddWithValue("@IDMes", cb_UMes.SelectedValue.ToString());
                        CommandCota.Parameters.AddWithValue("@IDAtleta", cb_UNomeAtleta.SelectedValue.ToString());
                        CommandCota.Parameters.AddWithValue("@IDLucro", IDLucro);
                        CommandCota.ExecuteNonQuery();
                    }
                    else if (cb_UFuncao.SelectedItem == "Sócio")
                    {
                        QueryCota = "INSERT INTO dbo.TblCotaSocio (Valor, FK_IDMes, FK_IDSocio, FK_IDLucro) VALUES (@Valor, @IDMes, @IDSocio, @IDLucro)";

                        SqlCommand CommandCota = new SqlCommand(QueryCota, con);
                        CommandCota.Parameters.AddWithValue("@Valor", tb_UMontante.Text);
                        CommandCota.Parameters.AddWithValue("@IDMes", cb_UMes.SelectedValue.ToString());
                        CommandCota.Parameters.AddWithValue("@IDSocio", cb_UNomeSocio.SelectedValue.ToString());
                        CommandCota.Parameters.AddWithValue("@IDLucro", IDLucro);
                        CommandCota.ExecuteNonQuery();
                    }

                    string saldo = "";
                    SqlDataReader dr2;
                    string Query2 = ("SELECT Saldo FROM dbo.TblClube WHERE IDClube = 1");
                    SqlCommand Command2 = new SqlCommand(Query2, con);
                    dr2 = Command2.ExecuteReader();
                    while (dr2.Read())
                    {
                        saldo = dr2["Saldo"].ToString();
                    }
                    dr2.Close();

                    int novoSaldo = Convert.ToInt32(saldo) + Convert.ToInt32(tb_UMontante.Text);

                    string Querysaldo = "UPDATE TblClube SET Saldo = @NovoSaldo WHERE IDClube = 1";
                    SqlCommand Commandsaldo = new SqlCommand(Querysaldo, con);
                    Commandsaldo.Parameters.AddWithValue("@NovoSaldo", novoSaldo);
                    Commandsaldo.ExecuteNonQuery();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                con.Close();
                this.Dispose();
            }
        }

        private void Cb_UFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_UFuncao.SelectedItem == "Atleta")
            {
                cb_UNomeAtleta.Visible = true;
                cb_UNomeSocio.Visible = false;
            }
            else if(cb_UFuncao.SelectedItem == "Sócio")
            {
                cb_UNomeAtleta.Visible = false;
                cb_UNomeSocio.Visible = true;
            }
        }
    }
}
