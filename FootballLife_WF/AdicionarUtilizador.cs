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
    public partial class AdicionarUtilizador : Form
    {
        public AdicionarUtilizador()
        {
            InitializeComponent();
        }


        private void AdicionarUtilizador_Load(object sender, EventArgs e)
        {
            if (Program.CurrentFuncaoUser == "Treinador")
            {
                cb_Funcao.Items.Clear();
                cb_Funcao.Items.Add("Atleta");
                cb_Funcao.SelectedIndex = 0;

                panel_Escalao.Enabled = false;


                int IDEscalao = Program.CurrentIDEscalao;
                if (IDEscalao == 1)
                {
                    rb_Seniores.Checked = true;
                }
                else if (IDEscalao == 2)
                {
                    rb_Juniores.Checked = true;
                }
                else if (IDEscalao == 3)
                {
                    rb_Juvenis.Checked = true;
                }
                else if (IDEscalao == 4)
                {
                    rb_Iniciados.Checked = true;
                }
                else if (IDEscalao == 5)
                {
                    rb_Infantis.Checked = true;
                }
                else if (IDEscalao == 6)
                {
                    rb_Benjamins.Checked = true;
                }
                else if (IDEscalao == 7)
                {
                    rb_Traquinas.Checked = true;
                }
                else if (IDEscalao == 8)
                {
                    rb_Petizes.Checked = true;
                }
            }
        }


        //======================


        private void Cb_Funcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_Funcao.SelectedItem.ToString() == "Administrador" || cb_Funcao.SelectedItem.ToString() == "Sócio")
            {
                panel_Escalao.Visible = false;
            }
            else if (cb_Funcao.SelectedItem.ToString() == "Treinador")
            {
                panel_Escalao.Visible = true;
                lbl_EscalaoATreinar.Visible = true;
                lbl_Escalao.Visible = false;
            }
            else if (cb_Funcao.SelectedItem.ToString() == "Atleta")
            {
                panel_Escalao.Visible = true;
                lbl_EscalaoATreinar.Visible = false;
                lbl_Escalao.Visible = true;
            }
        }


        //======================


        private void Ckb_VerPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_VerPass.Checked == true)
            {
                tb_Password.UseSystemPasswordChar = false;
                tb_ConfPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tb_Password.UseSystemPasswordChar = true;
                tb_ConfPassword.UseSystemPasswordChar = true;
            }
        }


        //=======================================================================================


        //Gravar
        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string userAdmin = "";

            string userTreinador = "";

            string userAtleta = "";

            string userSocio = "";

            try
            {
                SqlDataReader dr;
                //Administrador
                string QueryAdmin = ("SELECT  Utilizador FROM TblAdministrador WHERE Utilizador LIKE @Utilizador");
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);

                CommandAdmin.Parameters.AddWithValue("@utilizador", tb_Utilizador.Text);
                CommandAdmin.Parameters.AddWithValue("@Palavra_Chave", tb_Password.Text);

                dr = CommandAdmin.ExecuteReader();

                while (dr.Read())
                {
                    userAdmin = dr["Utilizador"].ToString();
                }
                dr.Close();

                //Treinador
                string QueryTreinador = ("SELECT Utilizador FROM TblTreinador WHERE Utilizador LIKE @Utilizador");
                SqlCommand CommandTreinador = new SqlCommand(QueryTreinador, con);

                CommandTreinador.Parameters.AddWithValue("@utilizador", tb_Utilizador.Text);
                CommandTreinador.Parameters.AddWithValue("@Palavra_Chave", tb_Password.Text);

                dr = CommandTreinador.ExecuteReader();
                while (dr.Read())
                {
                    userTreinador = dr["Utilizador"].ToString();
                }
                dr.Close();

                //Atleta
                string QueryAtleta = ("SELECT  Utilizador FROM TblAtleta WHERE Utilizador LIKE @Utilizador");
                SqlCommand CommandAtleta = new SqlCommand(QueryAtleta, con);

                CommandAtleta.Parameters.AddWithValue("@utilizador", tb_Utilizador.Text);
                CommandAtleta.Parameters.AddWithValue("@Palavra_Chave", tb_Password.Text);

                dr = CommandAtleta.ExecuteReader();
                while (dr.Read())
                {
                    userAtleta = dr["Utilizador"].ToString();
                }
                dr.Close();

                //Socio
                string QuerySocio = ("SELECT  Utilizador FROM TblSocio WHERE Utilizador LIKE @Utilizador");
                SqlCommand CommandSocio = new SqlCommand(QuerySocio, con);

                CommandSocio.Parameters.AddWithValue("@utilizador", tb_Utilizador.Text);
                CommandSocio.Parameters.AddWithValue("@Palavra_Chave", tb_Password.Text);

                dr = CommandSocio.ExecuteReader();
                while (dr.Read())
                {
                    userSocio = dr["Utilizador"].ToString();
                }
                dr.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cb_Funcao.SelectedItem.ToString() != "Administrador" && cb_Funcao.SelectedItem.ToString() != "Treinador" && cb_Funcao.SelectedItem.ToString() != "Atleta" && cb_Funcao.SelectedItem.ToString() != "Sócio")
            {
                MessageBox.Show("Função não atribuida!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_Nome.Text == "" || tb_Email.Text == "" || tb_Utilizador.Text == "" || tb_Password.Text == "" || tb_ConfPassword.Text == "")
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_Password.Text != "" && tb_ConfPassword.Text != "" && tb_Password.Text == tb_ConfPassword.Text)
            {
                if (cb_Funcao.SelectedItem.ToString() == "Treinador" || cb_Funcao.SelectedItem.ToString() == "Atleta")
                {
                    if (rb_Seniores.Checked == false && rb_Juniores.Checked == false && rb_Juvenis.Checked == false && rb_Iniciados.Checked == false && rb_Infantis.Checked == false && rb_Benjamins.Checked == false && rb_Traquinas.Checked == false && rb_Petizes.Checked == false)
                    {
                        MessageBox.Show("Escalão não atribuido!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (userAdmin == tb_Utilizador.Text || userTreinador == tb_Utilizador.Text || userAtleta == tb_Utilizador.Text || userSocio == tb_Utilizador.Text)
                {
                    MessageBox.Show("Nome de Utilizador já usado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (cb_Funcao.SelectedItem.ToString() == "Administrador")
                    {
                        try
                        {
                            SqlCommand com = new SqlCommand();
                            com.Connection = con;
                            com.CommandText = @"INSERT INTO TblAdministrador (Nome, Email, Telemovel, Morada, CodPostal, Utilizador, Palavra_Chave) VALUES (@Nome, @Email, @Telemovel, @Morada, @CodPostal, @Utilizador, @Password)";
                            com.Parameters.AddWithValue("@Nome", tb_Nome.Text);
                            com.Parameters.AddWithValue("@Email", tb_Email.Text);
                            com.Parameters.AddWithValue("@Telemovel", tb_Telemovel.Text);
                            com.Parameters.AddWithValue("@Morada", tb_Morada.Text);
                            com.Parameters.AddWithValue("@CodPostal", tb_CodPostal.Text + " " + tb_Localidade.Text);
                            com.Parameters.AddWithValue("@Utilizador", tb_Utilizador.Text);
                            com.Parameters.AddWithValue("@Password", tb_Password.Text);
                            com.ExecuteNonQuery();
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                        this.Dispose();

                    }
                    else if (cb_Funcao.SelectedItem.ToString() == "Treinador")
                    {
                        string IDEscalao = "";
                        if (rb_Seniores.Checked == true)
                        {
                            IDEscalao = "1";
                        }
                        else if (rb_Juniores.Checked == true)
                        {
                            IDEscalao = "2";
                        }
                        else if (rb_Juvenis.Checked == true)
                        {
                            IDEscalao = "3";
                        }
                        else if (rb_Iniciados.Checked == true)
                        {
                            IDEscalao = "4";
                        }
                        else if (rb_Infantis.Checked == true)
                        {
                            IDEscalao = "5";
                        }
                        else if (rb_Benjamins.Checked == true)
                        {
                            IDEscalao = "6";
                        }
                        else if (rb_Traquinas.Checked == true)
                        {
                            IDEscalao = "7";
                        }
                        else if (rb_Petizes.Checked == true)
                        {
                            IDEscalao = "8";
                        }


                        try
                        {
                            SqlCommand com = new SqlCommand();
                            com.Connection = con;
                            com.CommandText = @"INSERT INTO TblTreinador (Nome, Email, Telemovel, Morada, CodPostal, FK_IDEscalao, Utilizador, Palavra_Chave) VALUES (@Nome, @Email, @Telemovel, @Morada, @CodPostal, @IDEscalao, @Utilizador, @Password)";
                            com.Parameters.AddWithValue("@Nome", tb_Nome.Text);
                            com.Parameters.AddWithValue("@Email", tb_Email.Text);
                            com.Parameters.AddWithValue("@Telemovel", tb_Telemovel.Text);
                            com.Parameters.AddWithValue("@Morada", tb_Morada.Text);
                            com.Parameters.AddWithValue("@CodPostal", tb_CodPostal.Text + " " + tb_Localidade.Text);
                            com.Parameters.AddWithValue("@IDEscalao", IDEscalao);
                            com.Parameters.AddWithValue("@Utilizador", tb_Utilizador.Text);
                            com.Parameters.AddWithValue("@Password", tb_Password.Text);
                            com.ExecuteNonQuery();
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                        this.Dispose();
                    }
                    else if (cb_Funcao.SelectedItem.ToString() == "Atleta")
                    {
                        string IDEscalao = "";
                        if (rb_Seniores.Checked == true)
                        {
                            IDEscalao = "1";
                        }
                        else if (rb_Juniores.Checked == true)
                        {
                            IDEscalao = "2";
                        }
                        else if (rb_Juvenis.Checked == true)
                        {
                            IDEscalao = "3";
                        }
                        else if (rb_Iniciados.Checked == true)
                        {
                            IDEscalao = "4";
                        }
                        else if (rb_Infantis.Checked == true)
                        {
                            IDEscalao = "5";
                        }
                        else if (rb_Benjamins.Checked == true)
                        {
                            IDEscalao = "6";
                        }
                        else if (rb_Traquinas.Checked == true)
                        {
                            IDEscalao = "7";
                        }
                        else if (rb_Petizes.Checked == true)
                        {
                            IDEscalao = "8";
                        }

                        try
                        {
                            SqlCommand com = new SqlCommand();
                            com.Connection = con;
                            com.CommandText = @"INSERT INTO TblAtleta (Nome, Email, Telemovel, Morada, CodPostal, FK_IDEscalao, Utilizador, Palavra_Chave) VALUES (@Nome, @Email, @Telemovel, @Morada, @CodPostal, @IDEscalao, @Utilizador, @Password)";
                            com.Parameters.AddWithValue("@Nome", tb_Nome.Text);
                            com.Parameters.AddWithValue("@Email", tb_Email.Text);
                            com.Parameters.AddWithValue("@Telemovel", tb_Telemovel.Text);
                            com.Parameters.AddWithValue("@Morada", tb_Morada.Text);
                            com.Parameters.AddWithValue("@CodPostal", tb_CodPostal.Text + " " + tb_Localidade.Text);
                            com.Parameters.AddWithValue("@IDEscalao", IDEscalao);
                            com.Parameters.AddWithValue("@Utilizador", tb_Utilizador.Text);
                            com.Parameters.AddWithValue("@Password", tb_Password.Text);
                            com.ExecuteNonQuery();
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.ToString());
                        }
                        con.Close();
                        this.Dispose();
                    }
                    else if (cb_Funcao.SelectedItem.ToString() == "Sócio")
                    {
                        try
                        {
                            SqlCommand com = new SqlCommand();
                            com.Connection = con;
                            com.CommandText = @"INSERT INTO TblSocio (Nome, Email, Telemovel, Morada, CodPostal, Utilizador, Palavra_Chave) VALUES (@Nome, @Email, @Telemovel, @Morada, @CodPostal, @Utilizador, @Password)";
                            com.Parameters.AddWithValue("@Nome", tb_Nome.Text);
                            com.Parameters.AddWithValue("@Email", tb_Email.Text);
                            com.Parameters.AddWithValue("@Telemovel", tb_Telemovel.Text);
                            com.Parameters.AddWithValue("@Morada", tb_Morada.Text);
                            com.Parameters.AddWithValue("@CodPostal", tb_CodPostal.Text + " " + tb_Localidade.Text);
                            com.Parameters.AddWithValue("@Utilizador", tb_Utilizador.Text);
                            com.Parameters.AddWithValue("@Password", tb_Password.Text);
                            com.ExecuteNonQuery();
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Necessário indicar a função do utilizador!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("As passwords não coincidem!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
