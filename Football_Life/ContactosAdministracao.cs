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
    public partial class ContactosAdministracao : Form
    {
        public ContactosAdministracao()
        {
            InitializeComponent();
            Emails();
        }

        int i = 5;
        private void Emails()
        {
            flowpanel_Emails.Controls.Clear();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeAdmin = "";
            string EmailAdmin = "";
            try
            {
                SqlDataReader dr;
                string Query = ("SELECT TOP (" + i + ") IDAdministrador, Nome, Email FROM dbo.TblAdministrador");
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    NomeAdmin = dr["Nome"].ToString();
                    EmailAdmin = dr["Email"].ToString();

                    Panel panel = new Panel();
                    panel.Margin = new Padding(5, 5, 5, 5);
                    panel.Width = 460;
                    panel.Height = 35;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    flowpanel_Emails.Controls.Add(panel);


                    Label Nome = new Label();
                    Nome.Location = new Point(10, 5);
                    Nome.Text = NomeAdmin + ":";
                    Nome.Width = 200;
                    Nome.Font = new Font("Berlin Sans FB Demi", 12, FontStyle.Regular);
                    Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Nome.Visible = true;
                    panel.Controls.Add(Nome);

                    Label Email = new Label();
                    Email.Location = new Point(210, 5);
                    Email.Text = EmailAdmin;
                    Email.Width = 280;
                    Email.Font = new Font("Berlin Sans FB", 12, FontStyle.Regular);
                    Email.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Email.Visible = true;
                    panel.Controls.Add(Email);
                }
                dr.Close();
                i += 5;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddMore5Contactos_Click(object sender, EventArgs e)
        {
            Emails();
        }
    }
}
