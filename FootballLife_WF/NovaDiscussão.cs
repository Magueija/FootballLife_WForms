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
        
        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();


            try {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = @"INSERT INTO TblDiscussao (NomeDiscussao, Descricao, FK_IDAdministrador) VALUES (@Nome, @Mensagem, @IDAdmin)";
                com.Parameters.AddWithValue("@Nome", tb_Nome.Text);
                com.Parameters.AddWithValue("@Mensagem", tb_Mensagem.Text);
                com.Parameters.AddWithValue("@IDAdmin", Properties.Settings.Default.IDUser);
                com.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();

            this.Dispose();
        }

        private void NovaDiscussão_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem a certeza que pretende sair?","AVISO!", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                this.Dispose();
            }
            else if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
