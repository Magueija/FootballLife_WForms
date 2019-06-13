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
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);

            InitializeComponent();
        }

        private void Cota_Load(object sender, EventArgs e)
        {
            tb_data.MinDate = DateTime.Now;
            CotaAPagar();

            if (Program.CurrentFuncaoUser == "Atleta")
            {
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;

                btn1.Text = "CONVOCATÓRIA";
                btn2.Text = "COTA DE ATLETA";
                btn3.Text = "CONTACTOS";
            }
            else if (Program.CurrentFuncaoUser == "Socio")
            {
                btn1.Visible = true;
                btn2.Visible = true;

                btn1.Text = "COTA DE SÓCIO";
                btn2.Text = "CONTACTOS";
            }
        }

        private void CotaAPagar()
        {
            tb_PPPass.Text = "";
            tb_CVV.Text = "";


            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            int Cota = 0;
            string valor = "";

            try
            {
                if (Program.CurrentFuncaoUser == "Atleta")
                {
                    SqlDataReader dr;
                    string Query = ("SELECT dbo.TblValorCota.Valor FROM dbo.TblCotaAtleta INNER JOIN dbo.TblValorCota ON dbo.TblCotaAtleta.FK_IDValorCota = dbo.TblValorCota.IDValorCota " +
                        "WHERE dbo.TblCotaAtleta.Pago = 0 AND dbo.TblCotaAtleta.FK_IDAtleta = " + Program.CurrentIDUser);
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
                else if (Program.CurrentFuncaoUser == "Socio")
                {
                    SqlDataReader dr;
                    string Query = ("SELECT dbo.TblValorCota.Valor FROM dbo.TblCotaSocio INNER JOIN dbo.TblValorCota ON dbo.TblCotaSocio.FK_IDValorCota = dbo.TblValorCota.IDValorCota " +
                        "WHERE dbo.TblCotaSocio.Pago = 0 AND dbo.TblCotaSocio.FK_IDSocio = " + Program.CurrentIDUser);
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
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        
        //==============================================================================================


        //Indica o metodo de pagamento e mostra as caixas de texto correspondentes
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

            lbl_NIF.Visible = true;
            tb_NIF.Visible = true;
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

            lbl_NIF.Visible = true;
            tb_NIF.Visible = true;

            tb_NumeroCartao.Text = "";
            tb_CVV.Text = "";
            tb_NomeCartao.Text = "";
            tb_data.Text = DateTime.Now.ToString();
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

            lbl_NIF.Visible = true;
            tb_NIF.Visible = true;

            tb_NumeroCartao.Text = "";
            tb_CVV.Text = "";
            tb_NomeCartao.Text = "";
            tb_data.Text = DateTime.Now.ToString();
        }


        //==============================================================================================


        //Gravar
        private void Btn_Pagar_Click(object sender, EventArgs e)
        {
            if (panel_Paypal.Visible == true && tb_PPEmail.Text == string.Empty || panel_Paypal.Visible == true && tb_PPPass.Text == string.Empty)
            {
                MessageBox.Show("Campos não preenchidos!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (panel_cartao.Visible == true && tb_NumeroCartao.Text == string.Empty ||
                    panel_cartao.Visible == true && tb_CVV.Text == string.Empty ||
                    panel_cartao.Visible == true && tb_NomeCartao.Text == string.Empty)
                 {
                    MessageBox.Show("Campos não preenchidos!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
            else if (panel_cartao.Visible == false && panel_Paypal.Visible == false)
            {
                MessageBox.Show("Por favor insira um método de pagamento!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
                con.Open();

                double SaldoClube = 0;

                string Nome = "";
                string Valor = "";
                string IDMes = "";
                string Mes = "";
                string MaxLucro = "";


                try
                {
                    if (Program.CurrentFuncaoUser == "Atleta")
                    {
                        //SELECIONA O NOME DO ATLETA PARA INSERIR NA TABELA LUCROS
                        SqlDataReader drAtleta;
                        string QueryAtleta = ("SELECT Nome FROM dbo.TblAtleta WHERE IDAtleta = " + Program.CurrentIDUser);
                        SqlCommand CommandAtleta = new SqlCommand(QueryAtleta, con);
                        drAtleta = CommandAtleta.ExecuteReader();
                        while (drAtleta.Read())
                        {
                            Nome = drAtleta["Nome"].ToString();
                        }
                        drAtleta.Close();


                        //SELECIONA O MES A PAGAR (O MAIS ANTIGO)
                        SqlDataReader drMes;
                        string QueryMes = ("SELECT dbo.TblMes.IDMes, dbo.TblMes.Mes FROM dbo.TblMes RIGHT OUTER JOIN dbo.TblCotaAtleta ON dbo.TblMes.IDMes = dbo.TblCotaAtleta.FK_IDMes WHERE " +
                            "dbo.TblCotaAtleta.Pago = 0 AND dbo.TblCotaAtleta.FK_IDAtleta = " + Program.CurrentIDUser);
                        SqlCommand CommandMes = new SqlCommand(QueryMes, con);
                        drMes = CommandMes.ExecuteReader();

                        if (drMes.Read())
                        {
                            IDMes = drMes["IDMes"].ToString();
                            Mes = drMes["Mes"].ToString();
                        }
                       
                        drMes.Close();


                        //SELECIONA O VALOR DA COTA DO ATLETA
                        SqlDataReader drValor;
                        string QueryValor = ("SELECT Valor FROM dbo.TblValorCota WHERE(IDValorCota = 1)");
                        SqlCommand CommandValor = new SqlCommand(QueryValor, con);
                        drValor = CommandValor.ExecuteReader();
                        while (drValor.Read())
                        {
                            Valor = drValor["Valor"].ToString();
                        }
                        drValor.Close();


                        //INSERE UM LUCRO
                        string QueryLucro = "INSERT INTO dbo.TblLucros (Nome, Valor, FK_IDClube) VALUES (@Nome, @Valor, @IDClub)";

                        SqlCommand CommandLucro = new SqlCommand(QueryLucro, con);
                        CommandLucro.Parameters.AddWithValue("@Nome", Nome + " - " + Mes);
                        CommandLucro.Parameters.AddWithValue("@Valor", Valor);
                        CommandLucro.Parameters.AddWithValue("@IDClub", "1");
                        CommandLucro.ExecuteNonQuery();


                        //SELECIONA O ULTIMO LUCRO CRIADO PARA INSERIR NA TABELA COTAATLETA
                        SqlDataReader drMaxLucro;
                        string QueryMaxLucro = ("SELECT MAX(IDLucro) AS MaxLucro FROM dbo.TblLucros");
                        SqlCommand CommandMaxLucro = new SqlCommand(QueryMaxLucro, con);
                        drMaxLucro = CommandMaxLucro.ExecuteReader();
                        while (drMaxLucro.Read())
                        {
                            MaxLucro = drMaxLucro["MaxLucro"].ToString();
                        }
                        drMaxLucro.Close();


                        //ATULIZA A COTA DO ATLETA PARA PAGA DO MES MAIS ANTIGO
                        string QueryCotaAtleta = "UPDATE dbo.TblCotaAtleta SET Pago = @Pago, FK_IDLucro = @IDLucro WHERE FK_IDMes = @IDMes AND FK_IDAtleta = @IDAtleta";

                        SqlCommand CommandCotaAtleta = new SqlCommand(QueryCotaAtleta, con);
                        CommandCotaAtleta.Parameters.AddWithValue("@Pago", "1");
                        CommandCotaAtleta.Parameters.AddWithValue("@IDAtleta", Program.CurrentIDUser);
                        CommandCotaAtleta.Parameters.AddWithValue("@IDMes", IDMes);
                        CommandCotaAtleta.Parameters.AddWithValue("@IDLucro", MaxLucro);
                        CommandCotaAtleta.ExecuteNonQuery();


                        
                    }
                    else if (Program.CurrentFuncaoUser == "Socio")
                    {
                        //SELECIONA O NOME DO Socio PARA INSERIR NA TABELA LUCROS
                        SqlDataReader drSocio;
                        string QuerySocio = ("SELECT Nome FROM dbo.TblSocio WHERE IDSocio = " + Program.CurrentIDUser);
                        SqlCommand CommandSocio = new SqlCommand(QuerySocio, con);
                        drSocio = CommandSocio.ExecuteReader();
                        while (drSocio.Read())
                        {
                            Nome = drSocio["Nome"].ToString();
                        }
                        drSocio.Close();


                        //SELECIONA O MES A PAGAR (O MAIS ANTIGO)
                        SqlDataReader drMes;
                        string QueryMes = ("SELECT dbo.TblMes.IDMes, dbo.TblMes.Mes FROM dbo.TblMes RIGHT OUTER JOIN dbo.TblCotaSocio ON dbo.TblMes.IDMes = dbo.TblCotaSocio.FK_IDMes WHERE " +
                            "dbo.TblCotaSocio.Pago = 0 AND dbo.TblCotaSocio.FK_IDSocio = " + Program.CurrentIDUser);
                        SqlCommand CommandMes = new SqlCommand(QueryMes, con);
                        drMes = CommandMes.ExecuteReader();

                        if (drMes.Read())
                        {
                            IDMes = drMes["IDMes"].ToString();
                            Mes = drMes["Mes"].ToString();
                        }

                        drMes.Close();


                        //SELECIONA O VALOR DA COTA DO Socio
                        SqlDataReader drValor;
                        string QueryValor = ("SELECT Valor FROM dbo.TblValorCota WHERE(IDValorCota = 2)");
                        SqlCommand CommandValor = new SqlCommand(QueryValor, con);
                        drValor = CommandValor.ExecuteReader();
                        while (drValor.Read())
                        {
                            Valor = drValor["Valor"].ToString();
                        }
                        drValor.Close();


                        //INSERE UM LUCRO
                        string QueryLucro = "INSERT INTO dbo.TblLucros (Nome, Valor, FK_IDClube) VALUES (@Nome, @Valor, @IDClub)";

                        SqlCommand CommandLucro = new SqlCommand(QueryLucro, con);
                        CommandLucro.Parameters.AddWithValue("@Nome", Nome + " - " + Mes);
                        CommandLucro.Parameters.AddWithValue("@Valor", Valor);
                        CommandLucro.Parameters.AddWithValue("@IDClub", "1");
                        CommandLucro.ExecuteNonQuery();


                        //SELECIONA O ULTIMO LUCRO CRIADO PARA INSERIR NA TABELA COTASocio
                        SqlDataReader drMaxLucro;
                        string QueryMaxLucro = ("SELECT MAX(IDLucro) AS MaxLucro FROM dbo.TblLucros");
                        SqlCommand CommandMaxLucro = new SqlCommand(QueryMaxLucro, con);
                        drMaxLucro = CommandMaxLucro.ExecuteReader();
                        while (drMaxLucro.Read())
                        {
                            MaxLucro = drMaxLucro["MaxLucro"].ToString();
                        }
                        drMaxLucro.Close();


                        //ATULIZA A COTA DO Socio PARA PAGA DO MES MAIS ANTIGO
                        string QueryCotaSocio = "UPDATE dbo.TblCotaSocio SET Pago = @Pago, FK_IDLucro = @IDLucro WHERE FK_IDMes = @IDMes AND FK_IDSocio = @IDSocio";

                        SqlCommand CommandCotaSocio = new SqlCommand(QueryCotaSocio, con);
                        CommandCotaSocio.Parameters.AddWithValue("@Pago", "1");
                        CommandCotaSocio.Parameters.AddWithValue("@IDSocio", Program.CurrentIDUser);
                        CommandCotaSocio.Parameters.AddWithValue("@IDMes", IDMes);
                        CommandCotaSocio.Parameters.AddWithValue("@IDLucro", MaxLucro);
                        CommandCotaSocio.ExecuteNonQuery();

                    }

                    //SELECIONA O SALDO DO CLUBE PARA SOMAR COM A COTA DO Socio
                    SqlDataReader drSaldoClube;
                    string QuerySaldoClube = ("SELECT Saldo FROM dbo.TblClube WHERE (IDClube = 1)");
                    SqlCommand CommandSaldoClube = new SqlCommand(QuerySaldoClube, con);
                    drSaldoClube = CommandSaldoClube.ExecuteReader();
                    while (drSaldoClube.Read())
                    {
                        SaldoClube = Convert.ToDouble(drSaldoClube["Saldo"]);
                    }
                    drSaldoClube.Close();


                    //ATUALIZA O NOVO SALDO
                    double Novosaldo = SaldoClube + Convert.ToDouble(Valor);
                    string QueryNovoSaldo = "UPDATE dbo.TblClube SET Saldo = @NovoSaldo WHERE IDClube = 1";

                    SqlCommand CommandNovoSaldo = new SqlCommand(QueryNovoSaldo, con);
                    CommandNovoSaldo.Parameters.AddWithValue("@NovoSaldo", Math.Round(Novosaldo, 2));
                    CommandNovoSaldo.ExecuteNonQuery();


                    MessageBox.Show($"Cota do mês de {Mes} paga!", "Cota Paga", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

                if (panel_Paypal.Visible == true)
                {
                    FaturaCota Fatura = new FaturaCota((Nome + " - " + Mes), Valor, Mes, Nome, tb_NIF.Text, tb_PPEmail.Text, "", "PayPal");
                    Fatura.Show();
                }
                else if (panel_cartao.Visible == true)
                {
                    if (img_Visa.BorderStyle == BorderStyle.FixedSingle)
                    {
                        FaturaCota Fatura = new FaturaCota((Nome + " - " + Mes), Valor, Mes, Nome, tb_NIF.Text, tb_NumeroCartao.Text, tb_NomeCartao.Text, "VISA");
                        Fatura.Show();
                    }
                    else if (img_MasterCard.BorderStyle == BorderStyle.FixedSingle)
                    {
                        FaturaCota Fatura = new FaturaCota((Nome + " - " + Mes), Valor, Mes, Nome, tb_NIF.Text, tb_NumeroCartao.Text, tb_NomeCartao.Text, "MasterCard");
                        Fatura.Show();
                    }

                }
                CotaAPagar();
            }
        }


        //==============================================================================================


        //Side Menu
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


        //===============================================================================


        //Side Menu button click
        private void Btn_Home_Click(object sender, EventArgs e)
        {
            if (Program.CurrentFuncaoUser == "Atleta")
            {
                PaginaInicial_Atleta PgInicio = new PaginaInicial_Atleta();
                this.Hide();
                PgInicio.ShowDialog();
                this.Dispose();
            }
            else if (Program.CurrentFuncaoUser == "Socio")
            {
                PaginaInicial_Socio PgInicio = new PaginaInicial_Socio();
                this.Hide();
                PgInicio.ShowDialog();
                this.Dispose();
            }
        }

        private void Btn_Jogos_Click(object sender, EventArgs e)
        {
            Jogos jgs = new Jogos();
            this.Hide();
            jgs.ShowDialog();
            this.Dispose();
        }

        private void Btn_Equipas_Click(object sender, EventArgs e)
        {
            Equipas Equipa = new Equipas();
            this.Hide();
            Equipa.ShowDialog();
            this.Dispose();
        }

        private void Btn_Estadio_Click(object sender, EventArgs e)
        {
            Estadio Estadio = new Estadio();
            this.Hide();
            Estadio.ShowDialog();
            this.Dispose();
        }

        private void Btn_Titulos_Click(object sender, EventArgs e)
        {
            Historia Hist = new Historia();
            this.Hide();
            Hist.ShowDialog();
            this.Dispose();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Program.CurrentFuncaoUser == "Atleta")
            {
                Convocatoria conv = new Convocatoria();
                this.Hide();
                conv.ShowDialog();
                this.Dispose();
            }
            else if (Program.CurrentFuncaoUser == "Socio")
            {
                Cota cota = new Cota();
                this.Hide();
                cota.ShowDialog();
                this.Dispose();
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (Program.CurrentFuncaoUser == "Atleta")
            {
                Cota ct = new Cota();
                this.Hide();
                ct.ShowDialog();
                this.Dispose();
            }
            else if (Program.CurrentFuncaoUser == "Socio")
            {
                Utilizadores users = new Utilizadores();
                this.Hide();
                users.ShowDialog();
                this.Dispose();
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Utilizadores users = new Utilizadores();
            this.Hide();
            users.ShowDialog();
            this.Dispose();
        }
        
        
        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            Program.CurrentFuncaoUser = "";
            Program.CurrentIDUser = 0;
            Program.CurrentIDEscalao = 0;

            PaginaInicial PgInicio = new PaginaInicial();
            this.Hide();
            PgInicio.ShowDialog();
            this.Dispose();
        }
    }
}

