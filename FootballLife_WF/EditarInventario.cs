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

        //=========

        private void EditarInventario_MouseHover(object sender, EventArgs e)
        {
            img_Add.Image = Properties.Resources.Add_Hover;
        }

        private void EditarInventario_MouseLeave(object sender, EventArgs e)
        {
            img_Add.Image = Properties.Resources.Add_Normal;
        }

        //=========

        private void EditarInventario_Load(object sender, EventArgs e)
        {
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
                if (Program.CurrentFuncaoUser == "Admin")
                {
                    Query = "SELECT dbo.TblMaterial.IDMaterial, dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade, dbo.TblInventario.FK_IDClube FROM dbo.TblInventario INNER JOIN "
                        + "dbo.TblMaterial ON dbo.TblInventario.IDInventario = dbo.TblMaterial.FK_IDInventario WHERE(dbo.TblInventario.FK_IDClube = 1) ORDER BY dbo.TblMaterial.Nome";
                }
                else if (Program.CurrentFuncaoUser == "Treinador")
                {
                    Query = "SELECT dbo.TblMaterial.IDMaterial, dbo.TblMaterial.Nome, dbo.TblMaterial.Quantidade, dbo.TblInventario.FK_IDEscalao FROM dbo.TblInventario INNER JOIN dbo.TblMaterial ON dbo.TblInventario.IDInventario = dbo.TblMaterial.FK_IDInventario WHERE(dbo.TblInventario.FK_IDEscalao IN "
                                 + "((SELECT dbo.TblEscalao.IDEscalao FROM dbo.TblEscalao INNER JOIN dbo.TblTreinador ON dbo.TblEscalao.IDEscalao = dbo.TblTreinador.FK_IDEscalao WHERE (dbo.TblEscalao.IDEscalao = " + Program.CurrentIDEscalao +"))))";
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
                    tbNome.Name = "tb_Nome";
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
                    tbQuantidade.Name = "tb_Quantidade";
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
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }


        //=======================================================================================


        //Imagem add click
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


        //================================================================================


        //Gravar
        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            string QueryDELETE = "";
            string QueryINSERT = "";

            try
            {
                if (Program.CurrentFuncaoUser == "Admin")
                {
                    QueryDELETE = "DELETE FROM dbo.TblMaterial WHERE (dbo.TblMaterial.FK_IDInventario = 1)";
                    SqlCommand CommandDELETE = new SqlCommand(QueryDELETE, con);
                    CommandDELETE.ExecuteNonQuery();


                    for (int ctr = 0; ctr < flowpanel_material.Controls.Count; ctr++)
                    {
                        string NomeMaterial = "";
                        string QuantidadeMaterial = "";



                        bool intsert = true;

                        foreach (Control c in flowpanel_material.Controls[ctr].Controls)
                        {
                            if (c.Name == "tb_Nome" && c.Text != string.Empty)
                            {
                                TextBox tb = (TextBox)c;
                                NomeMaterial = tb.Text;
                            }
                            else if (c.Name == "tb_Quantidade" && c.Text != string.Empty)
                            {
                                TextBox tb = (TextBox)c;
                                QuantidadeMaterial = tb.Text;
                            }
                            else if (c.Name == "tb_Nome" && c.Text == string.Empty || c.Name == "tb_Quantidade" && c.Text == string.Empty)
                            {
                                intsert = false;
                            }
                        }

                        /*int v = 0;
                        SqlDataReader dr;
                        string Query = "SELECT IDMaterial, Nome, Quantidade FROM TblMaterial WHERE Nome = '" + NomeMaterial + "' OR Quantidade = " + QuantidadeMaterial;

                        SqlCommand Command = new SqlCommand(Query, con);
                        dr = Command.ExecuteReader();
                        while (dr.Read())
                        {
                            IDMaterial[v] = dr["IDMaterial"].ToString();
                            nome[v] = dr["Nome"].ToString();
                            quantidade[v] = dr["Quantidade"].ToString();
                            v++;
                        }
                        dr.Close();

                        for(int i = 0; i < v; i++)
                        {
                            if (NomeMaterial == nome[i] || QuantidadeMaterial == quantidade[i])
                            {
                                QueryUPDATE = "UPDATE dbo.TblMaterial SET Nome = @NomeMaterial, Quantidade =  @Quantidade WHERE FK_IDInventario = 1 AND IDMaterial = @IDMaterial";

                                SqlCommand CommandUPDATE = new SqlCommand(QueryUPDATE, con);
                                CommandUPDATE.Parameters.AddWithValue("@NomeMaterial", NomeMaterial);
                                CommandUPDATE.Parameters.AddWithValue("@Quantidade", QuantidadeMaterial);
                                CommandUPDATE.Parameters.AddWithValue("@IDMaterial", IDMaterial);
                                CommandUPDATE.ExecuteNonQuery();
                            }
                        }*/


                        if (intsert == true)
                        {
                            QueryINSERT = "INSERT INTO dbo.TblMaterial (Nome, Quantidade, FK_IDInventario) VALUES (@NomeMaterial, @Quantidade, @FK_IDInventario)";

                            SqlCommand CommandINSERT = new SqlCommand(QueryINSERT, con);
                            CommandINSERT.Parameters.AddWithValue("@NomeMaterial", NomeMaterial);
                            CommandINSERT.Parameters.AddWithValue("@Quantidade", QuantidadeMaterial);
                            CommandINSERT.Parameters.AddWithValue("@FK_IDInventario", "1");
                            CommandINSERT.ExecuteNonQuery();

                        }
                    }
                }
                else if (Program.CurrentFuncaoUser == "Treinador")
                {
                    int IDEscalao = Program.CurrentIDEscalao;
                    int IDInventario = IDEscalao + 1;

                    QueryDELETE = "DELETE FROM dbo.TblMaterial WHERE (dbo.TblMaterial.FK_IDInventario = " + IDInventario + ")";
                    SqlCommand CommandDELETE = new SqlCommand(QueryDELETE, con);
                    CommandDELETE.ExecuteNonQuery();


                    for (int ctr = 0; ctr < flowpanel_material.Controls.Count; ctr++)
                    {
                        string NomeMaterial = "";
                        string QuantidadeMaterial = "";


                        bool intsert = true;

                        foreach (Control c in flowpanel_material.Controls[ctr].Controls)
                        {
                            if (c.Name == "tb_Nome" && c.Text != string.Empty)
                            {
                                TextBox tb = (TextBox)c;
                                NomeMaterial = tb.Text;
                            }
                            else if (c.Name == "tb_Quantidade" && c.Text != string.Empty)
                            {
                                TextBox tb = (TextBox)c;
                                QuantidadeMaterial = tb.Text;
                            }
                            else if (c.Name == "tb_Nome" && c.Text == string.Empty || c.Name == "tb_Quantidade" && c.Text == string.Empty)
                            {
                                intsert = false;
                            }
                        }

                        if (intsert == true)
                        {
                            QueryINSERT = "INSERT INTO dbo.TblMaterial (Nome, Quantidade, FK_IDInventario) VALUES (@NomeMaterial, @Quantidade, @FK_IDInventario)";

                            SqlCommand CommandINSERT = new SqlCommand(QueryINSERT, con);
                            CommandINSERT.Parameters.AddWithValue("@NomeMaterial", NomeMaterial);
                            CommandINSERT.Parameters.AddWithValue("@Quantidade", QuantidadeMaterial);
                            CommandINSERT.Parameters.AddWithValue("@FK_IDInventario", IDInventario);
                            CommandINSERT.ExecuteNonQuery();

                        }
                    }
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
