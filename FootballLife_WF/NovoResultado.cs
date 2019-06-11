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
using System.Data.SqlClient;

namespace FootballLife_WF
{
    public partial class NovoResultado : Form
    {
        string IDEscalao = "";
        public NovoResultado()
        {
            InitializeComponent();
            LoadFrom();
        }

        private void LoadFrom()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();
            try
            {
                SqlDataReader dr;
                string QuerySelect = "SELECT dbo.TblEscalao.IDEscalao FROM dbo.TblEscalao INNER JOIN dbo.TblTreinador ON dbo.TblEscalao.IDEscalao = dbo.TblTreinador.FK_IDEscalao WHERE dbo.TblTreinador.IDTreinador = " + Properties.Settings.Default.IDUser;

                SqlCommand CommandEscalao = new SqlCommand(QuerySelect, con);
                dr = CommandEscalao.ExecuteReader();
                while (dr.Read())
                {
                    IDEscalao = dr["IDEscalao"].ToString();
                }
                dr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }


        string displayimg, filePath;
        string folderpath = @"..\Projeto_WindowsForms\LogoEquipas\";
        OpenFileDialog open = new OpenFileDialog();

        private void Btn_UploadCasa_Click(object sender, EventArgs e)
        {
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                displayimg = open.SafeFileName;
                img_LogoCasa.Image = new Bitmap(open.FileName);

                txtpathCasa.Text = open.FileName;
                filePath = open.FileName;
            }
        }

   
        private void Btn_UploadFora_Click(object sender, EventArgs e)
        {
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                displayimg = open.SafeFileName;
                img_LogoFora.Image = new Bitmap(open.FileName);

                txtpathFora.Text = open.FileName;
                filePath = open.FileName;
            }
        }


        /*private void Btn_UploadFora_Click(object sender, EventArgs e)
        {
            OpenFileDialog diretorio = new OpenFileDialog();
            FileDialog file = new OpenFileDialog();
            diretorio.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            diretorio.ShowDialog();

            try
            {
                if (diretorio.FileName != null)
                {
                    LogoAdversario = diretorio.FileName;

                    if (Path.GetPathRoot(LogoAdversario) != @"\Projeto_WindowsForms\Imagens\")
                    {
                        System.IO.File.Copy(LogoAdversario, @"\Projeto_WindowsForms\Imagens\" + Path.GetFileName(LogoAdversario));
                    }
                    
                    Bitmap bmp = new Bitmap(@"\Projeto_WindowsForms\Imagens\" + Path.GetFileName(LogoAdversario));
                    img_LogoFora.Image = bmp;
                }
                else
                {
                    MessageBox.Show("Por favor escolha o logo do adversário!", "ATENÇÃO!", MessageBoxButtons.OK);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Por favor escolha o logo do adversário!", "ATENÇÃO!", MessageBoxButtons.OK);
            }

        }*/


        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            bool gravar = true;

            for (int ctr = 0; ctr < flowpanel_Golos.Controls.Count; ctr++)
            {
                foreach (Control c in flowpanel_Golos.Controls[ctr].Controls)
                {
                    if(c.Name == "tbMinutos" && c.Text == "")
                    {
                        gravar = false;
                    }
                }
            }

            if (gravar == true)
            {
                if (tb_Data.Text == "" || tb_Hora.Text == ""  || tb_Data.Text == "DD/MM/AAAA"  || tb_Hora.Text == "HH:MM"  || tb_Divisao.Text == "" || tb_EquipaCasa.Text == "" || tb_EquipaFora.Text == "" || tb_GolosCasa.Text == "" || tb_GolosFora.Text == "")
                {
                    MessageBox.Show("Campos obrigatórios não preenchidos!", "ATENÇÃO!", MessageBoxButtons.OK);
                }
                else if (tb_EquipaCasa.Text == tb_EquipaFora.Text && img_LogoCasa.Image == Properties.Resources.Logo_Clube && img_LogoFora.Image == Properties.Resources.Logo_Clube)
                {
                    MessageBox.Show("Equipas iguais!", "ATENÇÃO!", MessageBoxButtons.OK);
                }
                else if (img_LogoCasa.Image == Properties.Resources.Logo_Clube && img_LogoFora.Image == Properties.Resources.Logo_Clube)
                {
                    MessageBox.Show("Logos das equipas iguais!", "ATENÇÃO!", MessageBoxButtons.OK);
                }
                else if (img_LogoCasa.Image == Properties.Resources.Logo_Clube && tb_EquipaCasa.Text != "Palmelense F.C." || img_LogoFora.Image == Properties.Resources.Logo_Clube && tb_EquipaFora.Text != "Palmelense F.C.")
                {
                    MessageBox.Show("A Equipa 'Palmelense F.C.' não corresponde ao logo por defeito!", "ATENÇÃO!", MessageBoxButtons.OK);
                }
                else
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
                    con.Open();

                    try
                    {
                        if (!Directory.Exists(folderpath))
                        {
                            Directory.CreateDirectory(folderpath);
                        }

                        string QueryInsert = "INSERT INTO dbo.TblJogo (Data, Divisao, EquipaCasa, EquipaFora, GolosCasa, GolosFora, Path_ImgAdversario, FK_IDEscalao) VALUES (@Data, @Divisao, @EquipaCasa, @EquipaFora, @GolosCasa, @GolosFora, @Path_ImgAdversario, @IDEscalao)";

                        SqlCommand CommandINSERT = new SqlCommand(QueryInsert, con);
                        CommandINSERT.Parameters.AddWithValue("@Data", tb_Data.Text + " " + tb_Hora.Text);
                        CommandINSERT.Parameters.AddWithValue("@Divisao", tb_Divisao.Text);
                        CommandINSERT.Parameters.AddWithValue("@EquipaCasa", tb_EquipaCasa.Text);
                        CommandINSERT.Parameters.AddWithValue("@EquipaFora", tb_EquipaFora.Text);
                        CommandINSERT.Parameters.AddWithValue("@GolosCasa", tb_GolosCasa.Text);
                        CommandINSERT.Parameters.AddWithValue("@GolosFora", tb_GolosFora.Text);
                        CommandINSERT.Parameters.AddWithValue("@Path_ImgAdversario", folderpath + Path.GetFileName(open.FileName));

                        if (!File.Exists(folderpath + Path.GetFileName(open.FileName)))
                        {
                            File.Copy(filePath, Path.Combine(folderpath, Path.GetFileName(filePath)), true);
                        }

                        CommandINSERT.Parameters.AddWithValue("@IDEscalao", IDEscalao);
                        CommandINSERT.ExecuteNonQuery();

                        string IDJogo = "";
                        SqlDataReader drJogo;
                        string QueryJogo = "SELECT MAX(IDJogo) AS MaxJogo FROM dbo.TblJogo";

                        SqlCommand CommandJogo = new SqlCommand(QueryJogo, con);
                        drJogo = CommandJogo.ExecuteReader();
                        while (drJogo.Read())
                        {
                            IDJogo = drJogo["MaxJogo"].ToString();
                        }
                        drJogo.Close();

                        for (int ctr = 0; ctr < flowpanel_Golos.Controls.Count; ctr++)
                        {
                            string Nome = "";
                            string Minutos = "";

                            foreach (Control c in flowpanel_Golos.Controls[ctr].Controls)
                            {
                                if (c.Name == "cbNome")
                                {
                                    ComboBox cb = (ComboBox)c;
                                    Nome = cb.SelectedValue.ToString();
                                }

                                if (c.Name == "tbMinutos")
                                {
                                    TextBox tb = (TextBox)c;
                                    Minutos = tb.Text;
                                }
                            }

                            string Querygolo = "INSERT INTO dbo.TblGolo (Minutos_Jogo, FK_IDAtleta, FK_IDJogo) VALUES (@Minutos_Jogo, @IDAtleta, @IDJogo)";

                            SqlCommand Commandgolo = new SqlCommand(Querygolo, con);
                            Commandgolo.Parameters.AddWithValue("@Minutos_Jogo", Minutos);
                            Commandgolo.Parameters.AddWithValue("@IDAtleta", Nome);
                            Commandgolo.Parameters.AddWithValue("@IDJogo", IDJogo);
                            Commandgolo.ExecuteNonQuery();

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
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!", "ATENÇÃO!", MessageBoxButtons.OK);
            }
        }

        
        private void GolosPalmelense(int Golo)
        {
            Golo += 1;

            Panel panel = new Panel();
            panel.Width = 640;
            panel.Height = 35;
            panel.Anchor = AnchorStyles.Top;
            panel.BackColor = Color.Transparent;
            panel.Visible = true;
            flowpanel_Golos.Controls.Add(panel);

            Label Nome = new Label();
            Nome.Location = new Point(5, 5);
            Nome.Text = Golo + "º Golo:";
            Nome.Width = 75;
            Nome.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
            Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Nome.Visible = true;
            panel.Controls.Add(Nome);

            Label Obrigatorio = new Label();
            Obrigatorio.Location = new Point(335, 4);
            Obrigatorio.Text = "*";
            Obrigatorio.Width = 10;
            Obrigatorio.ForeColor = Color.Firebrick;
            Obrigatorio.Font = new Font("Berlin Sans FB", 10, FontStyle.Regular);
            Obrigatorio.Anchor = AnchorStyles.Top;
            Obrigatorio.Visible = true;
            panel.Controls.Add(Obrigatorio);

            ComboBox cbNome = new ComboBox();
            cbNome.Location = new Point(85, 4);
            cbNome.Width = 250;
            cbNome.Name = "cbNome";
            cbNome.Font = new Font("Arial", 10, FontStyle.Regular);
            cbNome.Anchor = AnchorStyles.Top;
            cbNome.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNome.Visible = true;
            cbNome.Name = "cbNome";
            panel.Controls.Add(cbNome);

            Label lblMinutos = new Label();
            lblMinutos.Location = new Point(365, 5);
            lblMinutos.Text = "Minutos de Jogo:";
            lblMinutos.Width = 125;
            lblMinutos.Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Regular);
            lblMinutos.Anchor = AnchorStyles.Top;
            lblMinutos.Visible = true;
            panel.Controls.Add(lblMinutos);

            Label Obrigatorio2 = new Label();
            Obrigatorio2.Location = new Point(620, 4);
            Obrigatorio2.Text = "*";
            Obrigatorio2.Width = 10;
            Obrigatorio2.ForeColor = Color.Firebrick;
            Obrigatorio2.Font = new Font("Berlin Sans FB", 10, FontStyle.Regular);
            Obrigatorio2.Anchor = AnchorStyles.Top;
            Obrigatorio2.Visible = true;
            panel.Controls.Add(Obrigatorio2);

            TextBox tbMinutos = new TextBox();
            tbMinutos.Location = new Point(490, 4);
            tbMinutos.Width = 130;
            tbMinutos.Font = new Font("Arial", 10, FontStyle.Regular);
            tbMinutos.RightToLeft = RightToLeft.Yes;
            tbMinutos.Anchor = AnchorStyles.Top;
            tbMinutos.Visible = true;
            tbMinutos.Name = "tbMinutos";
            panel.Controls.Add(tbMinutos);

            

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = null;
            sql = "SELECT IDAtleta, Nome FROM dbo.TblAtleta WHERE Apagado = 0 AND FK_IDEscalao = " + IDEscalao;
            try
            {
                command = new SqlCommand(sql, con);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
               
                cbNome.DataSource = ds.Tables[0];
                cbNome.ValueMember = "IDAtleta";
                cbNome.DisplayMember = "Nome";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void Palmelense_TextChanged(object sender, EventArgs e)
        {
            flowpanel_Golos.Controls.Clear();

            if (tb_EquipaCasa.Text == "Palmelense F.C." && tb_GolosCasa.Text != "")
            {
                string Golos = tb_GolosCasa.Text;

                for (int i = 0; i < Convert.ToInt32(Golos); i++)
                {
                    GolosPalmelense(i);
                }
            }
            else if (tb_EquipaFora.Text == "Palmelense F.C." && tb_GolosFora.Text != "")
            {
                string Golos = tb_GolosFora.Text;
                for (int i = 0; i < Convert.ToInt32(Golos); i++)
                {
                    GolosPalmelense(i);
                }
            }

            if (tb_EquipaCasa.Text == "Palmelense F.C." && tb_GolosCasa.Text == "" || tb_EquipaFora.Text == "Palmelense F.C." && tb_GolosFora.Text == "")
            {
                flowpanel_Golos.Controls.Clear();
            }
        }

        private void Tb_Data_Click(object sender, EventArgs e)
        {
            tb_Data.Text = "";
        }

        private void Tb_Hora_Click(object sender, EventArgs e)
        {
            tb_Hora.Text = "";
        }
    }
}
