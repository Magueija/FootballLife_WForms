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
    public partial class NovaDiscussão : Form
    {
        public NovaDiscussão()
        {
            InitializeComponent();
        }
        

        //Button Gravar click
        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            if (tb_Nome.Text == "" || tb_Mensagem.Text == "")
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandText = @"INSERT INTO TblDiscussao (NomeDiscussao, Descricao, FK_IDAdministrador) VALUES (@Nome, @Mensagem, @IDAdmin)";
                    com.Parameters.AddWithValue("@Nome", tb_Nome.Text);
                    com.Parameters.AddWithValue("@Mensagem", tb_Mensagem.Text);
                    com.Parameters.AddWithValue("@IDAdmin", Program.CurrentIDUser);
                    com.ExecuteNonQuery();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            con.Close();
            this.Dispose();
        }
    }
}
