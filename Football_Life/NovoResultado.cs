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
using System.Media;

namespace FootballLife_WF
{
    public partial class NovoResultado : Form
    {
        public NovoResultado()
        {
            InitializeComponent();
            LoadFrom();
        }

        private void LoadFrom()
        {
            dt_Data.MaxDate = DateTime.Now;
        }


        //================================================================================================


        //Upload Imagens
        string displayimg, filePath;
        string folderpath = @"..\LogoEquipas\";
        OpenFileDialog open = new OpenFileDialog();

        private void Btn_UploadCasa_Click(object sender, EventArgs e)
        {
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                displayimg = open.SafeFileName;
                img_LogoCasa.Image = new Bitmap(open.FileName);

                txtpathCasa.Text = Path.GetFileName(open.FileName);
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

                txtpathFora.Text = Path.GetFileName(open.FileName);
                filePath = open.FileName;
            }
        }


        //================================================================================================


        //Hora Click (tirar o "HH:MM")
        private void Tb_Hora_Click(object sender, EventArgs e)
        {
            tb_Hora.Text = "";
        }

        //Adiciona golos ao flowlayoutpanel
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
            sql = "SELECT dbo.TblAtleta.IDAtleta, dbo.TblAtleta.Nome FROM dbo.TblAtleta LEFT OUTER JOIN dbo.TblSuplente ON dbo.TblAtleta.IDAtleta = dbo.TblSuplente.FK_IDAtleta LEFT OUTER JOIN " +
                "dbo.TblTitular ON dbo.TblAtleta.IDAtleta = dbo.TblTitular.FK_IDAtleta WHERE(dbo.TblTitular.FK_IDAtleta IS NOT NULL) OR (dbo.TblSuplente.FK_IDAtleta IS NOT NULL) AND(dbo.TblAtleta.Apagado = 0) " +
                "AND dbo.TblAtleta.FK_IDEscalao = " + Program.CurrentIDEscalao + "  ORDER BY dbo.TblAtleta.Nome";
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
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }


        //Adiciona o numero de golos no flowlayoutpanel consoante o numero de golos inserido na textbox do palmelense
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

        private void Tb_GolosCasa_KeyDown(object sender, KeyEventArgs e)
        {
            bool naoNumero = false;

            // é um número do topo do teclado
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // é um numero do teclado numerico
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // teclas autorizadas
                    if (
                        (e.KeyCode != Keys.Back) &&
                        (e.KeyCode != Keys.Left) &&
                        (e.KeyCode != Keys.Right) &&
                        (e.KeyCode != Keys.Home) &&
                        (e.KeyCode != Keys.End)
                        )
                    {
                        naoNumero = true;
                    }
                }
            }

            if (Control.ModifierKeys != Keys.None)
            {
                naoNumero = true;
            }

            if (naoNumero)
            {
                e.SuppressKeyPress = true;

                SystemSounds.Beep.Play();
            }
        }

        private void Tb_Hora_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.OemPeriod) || (e.KeyCode == Keys.Decimal))
            {
                e.SuppressKeyPress = true;

                int posicaoCursor = tb_Hora.SelectionStart;
                tb_Hora.Text = tb_Hora.Text.Insert(posicaoCursor, ":");
                tb_Hora.SelectionStart = posicaoCursor + 1;
            }
            else
            {
                bool naoNumero = false;

                // é um número do topo do teclado
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {
                    // é um numero do teclado numerico
                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    {
                        // teclas autorizadas
                        if (
                            (e.KeyCode != Keys.Back) &&
                            (e.KeyCode != Keys.Left) &&
                            (e.KeyCode != Keys.Right) &&
                            (e.KeyCode != Keys.Home) &&
                            (e.KeyCode != Keys.End) &&
                            (e.KeyCode != Keys.Shift) &&
                            (e.KeyCode != Keys.OemPeriod)
                           )
                        {
                            naoNumero = true;
                        }
                    }
                }

                if (Control.ModifierKeys != Keys.None)
                {
                    naoNumero = true;
                }

                if (naoNumero)
                {
                    e.SuppressKeyPress = true;

                    SystemSounds.Beep.Play();
                }
            }
        }


        //================================================================================================


        //Gravar button click
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
                if (tb_Hora.Text == ""  || tb_Hora.Text == "HH:MM"  || tb_Divisao.Text == "" || tb_EquipaCasa.Text == "" || tb_EquipaFora.Text == "" || tb_GolosCasa.Text == "" || tb_GolosFora.Text == "")
                {
                    MessageBox.Show("Campos obrigatórios não preenchidos!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtpathCasa.Text == "" && txtpathFora.Text == "")
                {
                    MessageBox.Show("Logo de equipa adversária não escolhido!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tb_EquipaCasa.Text == tb_EquipaFora.Text)
                {
                    MessageBox.Show("Equipas Iguais!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tb_EquipaCasa.Text == tb_EquipaFora.Text && img_LogoCasa.Image == Properties.Resources.Logo_Clube && img_LogoFora.Image == Properties.Resources.Logo_Clube)
                {
                    MessageBox.Show("Equipas iguais!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (img_LogoCasa.Image == Properties.Resources.Logo_Clube && img_LogoFora.Image == Properties.Resources.Logo_Clube)
                {
                    MessageBox.Show("Logos das equipas iguais!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtpathCasa.Text != "" && tb_EquipaCasa.Text == "Palmelense F.C." || txtpathFora.Text != "" && tb_EquipaFora.Text == "Palmelense F.C." || txtpathCasa.Text != "" && tb_EquipaCasa.Text == "Palmelense F.C." || txtpathFora.Text != "" && tb_EquipaFora.Text == "Palmelense F.C.")
                {
                    MessageBox.Show("A Equipa 'Palmelense F.C.' não corresponde ao logo por defeito!\nTente reabrir o novo resultado.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                        DateTime data = Convert.ToDateTime(dt_Data.Text + " " + tb_Hora.Text);

                        SqlCommand CommandINSERT = new SqlCommand(QueryInsert, con);
                        CommandINSERT.Parameters.AddWithValue("@Data", data);
                        CommandINSERT.Parameters.AddWithValue("@Divisao", tb_Divisao.Text);
                        CommandINSERT.Parameters.AddWithValue("@EquipaCasa", tb_EquipaCasa.Text);
                        CommandINSERT.Parameters.AddWithValue("@EquipaFora", tb_EquipaFora.Text);
                        CommandINSERT.Parameters.AddWithValue("@GolosCasa", tb_GolosCasa.Text);
                        CommandINSERT.Parameters.AddWithValue("@GolosFora", tb_GolosFora.Text);
                        CommandINSERT.Parameters.AddWithValue("@Path_ImgAdversario", folderpath + Path.GetFileName(open.FileName));

                        string fileName = Path.Combine(folderpath, Path.GetFileName(filePath));

                        if (!File.Exists(fileName))
                        {
                            File.Copy(filePath, fileName, true);
                        }

                        CommandINSERT.Parameters.AddWithValue("@IDEscalao", Program.CurrentIDEscalao);
                        CommandINSERT.ExecuteNonQuery();

                        string IDJogo = "";
                        SqlDataReader drJogo;
                        string QueryJogo = "SELECT MAX(IDJogo) AS MaxJogo FROM dbo.TblJogo WHERE Apagado = 0";

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
                        MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
