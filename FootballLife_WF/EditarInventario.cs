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
    public partial class EditarInventario : Form
    {
        public EditarInventario()
        {
            InitializeComponent();
        }

        private void AdicionarMaterial()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeMaterial = "";
            string Quantidade = "";

            SqlDataReader dr;
            string Query = ("SELECT dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade FROM dbo.TblMaterial ORDER BY dbo.TblMaterial.Nome");
            SqlCommand Command = new SqlCommand(Query, con);
            dr = Command.ExecuteReader();
            while (dr.Read())
            {
                NomeMaterial = dr["Nome"].ToString();
                Quantidade = dr["Quantidade"].ToString();

                Panel panel = new Panel();
                panel.Width = 650;
                panel.Height = 40;
                panel.Anchor = AnchorStyles.Top;
                panel.BackColor = Color.Transparent;
                panel.Visible = true;
                flowpanel_material.Controls.Add(panel);

                Label Nome = new Label();
                Nome.Location = new Point(10, 6);
                Nome.Text = "Nome do Material:";
                Nome.Width = 145;
                Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Nome.Visible = true;
                panel.Controls.Add(Nome);

                TextBox tbNome = new TextBox();
                tbNome.Location = new Point(155, 5);
                tbNome.Text = NomeMaterial;
                tbNome.Width = 250;
                tbNome.Font = new Font("Arial", 10, FontStyle.Regular);
                tbNome.Anchor = AnchorStyles.Top;
                tbNome.Visible = true;
                panel.Controls.Add(tbNome);

                Label lblQuantidade = new Label();
                lblQuantidade.Location = new Point(425, 6);
                lblQuantidade.Text = "Quantidade:";
                lblQuantidade.Width = 100;
                lblQuantidade.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                lblQuantidade.Anchor = AnchorStyles.Top;
                lblQuantidade.Visible = true;
                panel.Controls.Add(lblQuantidade);

                TextBox tbQuantidade = new TextBox();
                tbQuantidade.Location = new Point(525, 5);
                tbQuantidade.Text = Quantidade;
                tbQuantidade.Width = 100;
                tbQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
                tbQuantidade.Anchor = AnchorStyles.Top;
                tbQuantidade.Visible = true;
                panel.Controls.Add(tbQuantidade);
            }

            if(dr.Read() == false)
            {
                for(int i = 0; i < 4; i++)
                {
                    Panel panel = new Panel();
                    panel.Width = 650;
                    panel.Height = 40;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    flowpanel_material.Controls.Add(panel);

                    Label Nome = new Label();
                    Nome.Location = new Point(10, 6);
                    Nome.Text = "Nome do Material:";
                    Nome.Width = 145;
                    Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                    Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    Nome.Visible = true;
                    panel.Controls.Add(Nome);

                    TextBox tbNome = new TextBox();
                    tbNome.Location = new Point(155, 5);
                    tbNome.Width = 250;
                    tbNome.Font = new Font("Arial", 10, FontStyle.Regular);
                    tbNome.Anchor = AnchorStyles.Top;
                    tbNome.Visible = true;
                    panel.Controls.Add(tbNome);

                    Label lblQuantidade = new Label();
                    lblQuantidade.Location = new Point(425, 6);
                    lblQuantidade.Text = "Quantidade:";
                    lblQuantidade.Width = 100;
                    lblQuantidade.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
                    lblQuantidade.Anchor = AnchorStyles.Top;
                    lblQuantidade.Visible = true;
                    panel.Controls.Add(lblQuantidade);

                    TextBox tbQuantidade = new TextBox();
                    tbQuantidade.Location = new Point(525, 5);
                    tbQuantidade.Width = 100;
                    tbQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
                    tbQuantidade.Anchor = AnchorStyles.Top;
                    tbQuantidade.Visible = true;
                    panel.Controls.Add(tbQuantidade);
                }
            }

            dr.Close();

            con.Close();
        }

        private void Img_Add_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Width = 650;
            panel.Height = 40;
            panel.Anchor = AnchorStyles.Top;
            panel.BackColor = Color.Transparent;
            panel.Visible = true;
            flowpanel_material.Controls.Add(panel);

            Label Nome = new Label();
            Nome.Location = new Point(10, 6);
            Nome.Text = "Nome do Material:";
            Nome.Width = 145;
            Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
            Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Nome.Visible = true;
            panel.Controls.Add(Nome);

            TextBox tbNome = new TextBox();
            tbNome.Location = new Point(155, 5);
            tbNome.Width = 250;
            tbNome.Font = new Font("Arial", 10, FontStyle.Regular);
            tbNome.Anchor = AnchorStyles.Top;
            tbNome.Visible = true;
            panel.Controls.Add(tbNome);

            Label lblQuantidade = new Label();
            lblQuantidade.Location = new Point(440, 6);
            lblQuantidade.Text = "Quantidade:";
            lblQuantidade.Width = 100;
            lblQuantidade.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
            lblQuantidade.Anchor = AnchorStyles.Top;
            lblQuantidade.Visible = true;
            panel.Controls.Add(lblQuantidade);

            TextBox tbQuantidade = new TextBox();
            tbQuantidade.Location = new Point(540, 5);
            tbQuantidade.Width = 100;
            tbQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
            tbQuantidade.RightToLeft = RightToLeft.Yes;
            tbQuantidade.Anchor = AnchorStyles.Top;
            tbQuantidade.Visible = true;
            panel.Controls.Add(tbQuantidade);
        }

        private void EditarInventario_MouseHover(object sender, EventArgs e)
        {
            img_Add.Image = Properties.Resources.Add_Hover;
        }

        private void EditarInventario_MouseLeave(object sender, EventArgs e)
        {
            img_Add.Image = Properties.Resources.Add_Normal;
        }
    }
}
