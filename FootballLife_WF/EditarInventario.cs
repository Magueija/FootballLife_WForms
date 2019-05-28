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
            AdicionarMaterial();
        }

        private void AdicionarMaterial()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string NomeMaterial = "";
            string Quantidade = "";

            SqlDataReader dr;
            string Query = "";

            try
            {
                if (Properties.Settings.Default.FuncaoUser == "Admin")
                {
                    Query = "SELECT dbo.TblMaterial.IDMaterial, dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade, dbo.TblInventario.FK_IDClube FROM dbo.TblInventario INNER JOIN "
                        + "dbo.TblMaterial ON dbo.TblInventario.IDInventario = dbo.TblMaterial.FK_IDInventario WHERE(dbo.TblInventario.FK_IDClube = 1) ORDER BY dbo.TblMaterial.Nome";
                }
                else if (Properties.Settings.Default.FuncaoUser == "Treinador")
                {
                    Query = "SELECT dbo.TblMaterial.IDMaterial, dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade, dbo.TblInventario.FK_IDEscalao FROM dbo.TblInventario INNER JOIN dbo.TblMaterial ON dbo.TblInventario.IDInventario = dbo.TblMaterial.FK_IDInventario WHERE(dbo.TblInventario.FK_IDEscalao IN "
                                 + "((SELECT dbo.TblEscalao.IDEscalao FROM dbo.TblEscalao INNER JOIN dbo.TblTreinador ON dbo.TblEscalao.IDEscalao = dbo.TblTreinador.FK_IDEscalao WHERE(dbo.TblTreinador.IDTreinador = " + Properties.Settings.Default.IDUser +"))))";
                }
                else if (Properties.Settings.Default.FuncaoUser == "Atleta")
                {
                    Query = "SELECT dbo.TblMaterial.IDMaterial, dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade, dbo.TblInventario.FK_IDEscalao FROM dbo.TblInventario INNER JOIN dbo.TblMaterial ON dbo.TblInventario.IDInventario = dbo.TblMaterial.FK_IDInventario WHERE(dbo.TblInventario.FK_IDEscalao IN "
                                 + "((SELECT dbo.TblEscalao.IDEscalao FROM dbo.TblEscalao INNER JOIN dbo.TblAtleta ON dbo.TblEscalao.IDEscalao = dbo.TblAtleta.FK_IDEscalao WHERE(dbo.TblAtleta.IDAtleta = " + Properties.Settings.Default.IDUser + "))))";
                }

                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    NomeMaterial = dr["Nome"].ToString();
                    Quantidade = dr["Quantidade"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 650;
                    panel.Height = 50;
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
                    tbNome.Text = NomeMaterial;
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
                    tbQuantidade.Text = Quantidade;
                    tbQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
                    tbQuantidade.RightToLeft = RightToLeft.Yes;
                    tbQuantidade.Anchor = AnchorStyles.Top;
                    tbQuantidade.Visible = true;
                    panel.Controls.Add(tbQuantidade);
                }

                if(NomeMaterial == "")
                {
                    for(int i = 0; i < 3; i++)
                    {
                        NewColuns();
                    }
                }

                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void Img_Add_Click(object sender, EventArgs e)
        {
            NewColuns();
        }

        private void NewColuns()
        {
            Panel panel = new Panel();
            panel.Width = 650;
            panel.Height = 50;
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
            tbNome.Name = "tb_Nome";
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
            tbQuantidade.Name = "tb_Quantidade";
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

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string QueryDELETE = "";
            string QueryINSERT = "";

            try
            {
                if (Properties.Settings.Default.FuncaoUser == "Admin")
                {
                    //QueryDELETE = "DELETE FROM dbo.TblMaterial WHERE(dbo.TblMaterial.FK_IDInventario = 1)";
                    //SqlCommand CommandDELETE= new SqlCommand(QueryDELETE, con);
                    //CommandDELETE.ExecuteNonQuery();

                    for (int ctr = 0; ctr < flowpanel_material.Controls.Count; ctr++)
                    {
                        foreach (Control c in flowpanel_material.Controls[ctr].Controls)
                        {
                            //string d =flowpanel_material.Controls[ctr].;
                            //string g =    flowpanel_material.Controls[ctr + 3].Text;
                            QueryINSERT = "INSERT INTO dbo.TblMaterial (Nome, Quantidade, FK_IDInventario) VALUES (@NomeMaterial, @Quantidade, @FK_IDInventario)";

                            SqlCommand CommandINSERT = new SqlCommand(QueryINSERT, con);
                            CommandINSERT.Parameters.AddWithValue("@NomeMaterial", flowpanel_material.Controls[ctr + 1].Text);
                            CommandINSERT.Parameters.AddWithValue("@Quantidade", flowpanel_material.Controls[ctr + 3].Text);
                            CommandINSERT.Parameters.AddWithValue("@FK_IDInventario", "1");
                            CommandINSERT.ExecuteNonQuery();
                        }
                    }
                }
                else if (Properties.Settings.Default.FuncaoUser == "Treinador")
                {
                   // Query = "SELECT dbo.TblMaterial.IDMaterial, dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade, dbo.TblInventario.FK_IDEscalao FROM dbo.TblInventario INNER JOIN dbo.TblMaterial ON dbo.TblInventario.IDInventario = dbo.TblMaterial.FK_IDInventario WHERE(dbo.TblInventario.FK_IDEscalao IN "
                       //          + "((SELECT dbo.TblEscalao.IDEscalao FROM dbo.TblEscalao INNER JOIN dbo.TblTreinador ON dbo.TblEscalao.IDEscalao = dbo.TblTreinador.FK_IDEscalao WHERE(dbo.TblTreinador.IDTreinador = " + Properties.Settings.Default.IDUser + "))))";
                }
                else if (Properties.Settings.Default.FuncaoUser == "Atleta")
                {
                    //Query = "SELECT dbo.TblMaterial.IDMaterial, dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade, dbo.TblInventario.FK_IDEscalao FROM dbo.TblInventario INNER JOIN dbo.TblMaterial ON dbo.TblInventario.IDInventario = dbo.TblMaterial.FK_IDInventario WHERE(dbo.TblInventario.FK_IDEscalao IN "
                          //       + "((SELECT dbo.TblEscalao.IDEscalao FROM dbo.TblEscalao INNER JOIN dbo.TblAtleta ON dbo.TblEscalao.IDEscalao = dbo.TblAtleta.FK_IDEscalao WHERE(dbo.TblAtleta.IDAtleta = " + Properties.Settings.Default.IDUser + "))))";
                }
                

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();

            this.Dispose();
        }
    }
}
