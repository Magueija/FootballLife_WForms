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

        private void Emails()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeAdmin = "";
            string EmailAdmin = "";

            SqlDataReader dr;
            string Query = ("SELECT dbo.TblAdministrador.Nome, dbo.TblAdministrador.Email FROM dbo.TblAdministrador.Nome ORDER BY dbo.TblAdministrador.Nome");
            SqlCommand Command = new SqlCommand(Query, con);
            dr = Command.ExecuteReader();
            while (dr.Read())
            {
                NomeAdmin = dr["Nome"].ToString();
                EmailAdmin = dr["Email"].ToString();

                Panel panel = new Panel();
                panel.Width = 460;
                panel.Height = 30;
                panel.Anchor = AnchorStyles.Top;
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.BackColor = Color.Transparent;
                panel.Visible = true;
                flowpanel_Emails.Controls.Add(panel);


                Label Nome = new Label();
                Nome.Location = new Point(10, 5);
                Nome.Text = NomeAdmin;
                Nome.Width = 170;
                Nome.Font = new Font("Berlin Sans FB Demi", 12, FontStyle.Regular);
                Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Nome.Visible = true;
                panel.Controls.Add(Nome);

                Label Email = new Label();
                Email.Location = new Point(180, 5);
                Email.Text = EmailAdmin;
                Email.Width = 280;
                Email.Font = new Font("Berlin Sans FB", 12, FontStyle.Regular);
                Email.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Email.Visible = true;
                panel.Controls.Add(Email);
            }
            dr.Close();

            con.Close();
        }
    }
}
