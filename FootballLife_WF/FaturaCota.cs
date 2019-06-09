using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FootballLife_WF
{
    public partial class FaturaCota : Form
    {
        string Nome = "";
        string Valor = "";
        string Mes = "";
        

        string Pagamento = "";
        string User = "";
        string NIF = "";

        string NumeroEmail = "";
        string NmCartao = "";
        

        public FaturaCota(string nome, string valor, string mes, string user, string Nif, string Email_NrCartao, string nmcartao, string pagamento)
        {
            InitializeComponent();

            Nome = nome;
            Valor = valor + " €";
            Mes = mes;
            User = user;
            NIF = Nif;

            if(Pagamento != "PayPal")
            {
                Pagamento = pagamento;
                NumeroEmail = Email_NrCartao;
                NmCartao = nmcartao;
            }
            else
            {
                Pagamento = pagamento;
                NumeroEmail = Email_NrCartao;
            }
        }


        private void FaturaCota_Load(object sender, EventArgs e)
        {
            lbl_Nome.Text = Nome;
            lbl_Valor.Text = Valor;
            lbl_Mes.Text = Mes;

            lbl_Pagamento.Text = Pagamento;
            lbl_User.Text = User;
            lbl_NIF.Text = NIF;

            if (Pagamento != "PayPal")
            {
                label_NrCt.Visible = true;
                lbl_Numero.Visible = true;
                label_NmCt.Visible = true;
                lbl_NmCartao.Visible = true;

                label_PP.Visible = false;
                lbl_PayPal.Visible = false;
                

                lbl_Numero.Text = NumeroEmail;
                lbl_NmCartao.Text = NmCartao;
            }
            else
            {
                label_NrCt.Visible = false;
                lbl_Numero.Visible = false;
                label_NmCt.Visible = false;
                lbl_NmCartao.Visible = false;

                label_PP.Visible = true;
                lbl_PayPal.Visible = true;


                lbl_PayPal.Text = NumeroEmail;
            }
            
        }


        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.FileName = "Fatura Cota Palmelense - " + Mes + ".txt";
            save.Filter = "Arquivo de texto | * .txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());

                for(int i = 0; i < this.Controls.Count; i++)
                {
                    if(this.Controls[i] is Label)
                    {
                        if(Pagamento != "PayPal")
                        {
                            label_PP.Text = "";
                            lbl_PayPal.Text = "";
                        }
                        else
                        {
                            label_NrCt.Text = "";
                            lbl_Numero.Text = "";
                            label_NmCt.Text = "";
                            lbl_NmCartao.Text = "";
                        }


                        if (i == 0)
                        {
                            writer.WriteLine();
                        }
                        else if (i == 1)
                        {
                            writer.WriteLine();
                            writer.WriteLine();
                        }
                        else if (i == 7)
                        {
                            writer.WriteLine();
                        }
                        else if (Pagamento == "PayPal" && i == 13)
                        {
                            writer.WriteLine();
                        }

                        if (i % 2 != 0)
                        {
                            writer.WriteLine();
                        }

                        writer.Write(" " + this.Controls[i].Text.ToString());
                    }
                }

                writer.Dispose();
                writer.Close();
            }
            else
            {
                MessageBox.Show("Ficheiro NÂO guardado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Dispose();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
