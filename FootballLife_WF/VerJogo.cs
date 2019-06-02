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
    public partial class VerJogo : Form
    {
        string IDJogo;
        public VerJogo(string ID)
        {
            IDJogo = ID;
            InitializeComponent();
        }

        private void VerJogo_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();


            string Escalao = "";
            string Data = "";
            string Divisao = "";

            string EquipaCasa = "";
            string GolosCasa = "";

            string EquipaFora = "";
            string GolosFora = "";


            try
            {
                SqlDataReader dr;
                string Query = ("SELECT dbo.TblJogo.IDJogo, dbo.TblJogo.Data, dbo.TblJogo.Divisao, dbo.TblJogo.EquipaCasa, dbo.TblJogo.EquipaFora, dbo.TblJogo.GolosCasa, dbo.TblEscalao.Escalao, dbo.TblJogo.GolosFora FROM dbo.TblJogo INNER JOIN dbo.TblEscalao ON dbo.TblJogo.FK_IDEscalao = dbo.TblEscalao.IDEscalao WHERE dbo.TblJogo.IDJogo = " + IDJogo);
                SqlCommand Command = new SqlCommand(Query, con);
                dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    Escalao = dr["Escalao"].ToString();
                    Data = dr["Data"].ToString();
                    Divisao = dr["Divisao"].ToString();

                    EquipaCasa = dr["EquipaCasa"].ToString();
                    GolosCasa = dr["GolosCasa"].ToString();

                    EquipaFora = dr["EquipaFora"].ToString();
                    GolosFora = dr["GolosFora"].ToString();

                    lbl_Titulo.Text = "Jogos dos " + Escalao;
                    lbl_Escalao.Text = Escalao;
                    lbl_Data.Text = Data;
                    lbl_Divisao.Text = Divisao;

                    lbl_EquipaCasa.Text = EquipaCasa;
                    lbl_GolosCasa.Text = GolosCasa;

                    lbl_EquipaFora.Text = EquipaFora;
                    lbl_GolosFora.Text = GolosFora;

                    if (EquipaCasa == "Palmelense F.C.")
                    {
                        img_LogoCasa.Image = Properties.Resources.Logo_Clube;
                        img_LogoFora.Image = Properties.Resources.LogoAtleta;
                    }
                    else if (EquipaFora == "Palmelense F.C.")
                    {
                        img_LogoCasa.Image = Properties.Resources.LogoAtleta;
                        img_LogoFora.Image = Properties.Resources.Logo_Clube;
                    }
                }
                dr.Close();

                int i = 0;

                SqlDataReader drgolos;
                string Querygolos = ("SELECT dbo.TblGolo.Minutos_Jogo, dbo.TblAtleta.Nome FROM dbo.TblGolo INNER JOIN dbo.TblJogo ON dbo.TblGolo.FK_IDJogo = dbo.TblJogo.IDJogo" +
                    " INNER JOIN dbo.TblAtleta ON dbo.TblGolo.FK_IDAtleta = dbo.TblAtleta.IDAtleta WHERE dbo.TblJogo.IDJogo = " + IDJogo + " ORDER BY dbo.TblGolo.Minutos_Jogo");
                SqlCommand Commandgolos = new SqlCommand(Querygolos, con);
                drgolos = Commandgolos.ExecuteReader();
                while (drgolos.Read())
                {
                    string MinutosJogo = drgolos["Minutos_Jogo"].ToString();
                    string NomeAtleta = drgolos["Nome"].ToString();

                    Panel panel = new Panel();
                    panel.Width = 465;
                    panel.Height = 30;
                    panel.Anchor = AnchorStyles.Top;
                    panel.BackColor = Color.Transparent;
                    panel.Visible = true;
                    flowpanel_Golos.Controls.Add(panel);

                    Label lblNome = new Label();
                    lblNome.Location = new Point(5, 5);
                    lblNome.Text = i + "º Golo:";
                    lblNome.Width = 70;
                    lblNome.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Regular);
                    lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lblNome.Visible = true;
                    panel.Controls.Add(lblNome);
                    i++;

                    Label tbNome = new Label();
                    tbNome.Location = new Point(75, 6);
                    tbNome.Width = 220;
                    tbNome.Text = NomeAtleta;
                    tbNome.Font = new Font("Arial", 9, FontStyle.Regular);
                    tbNome.Anchor = AnchorStyles.Top;
                    tbNome.Visible = true;
                    panel.Controls.Add(tbNome);

                    Label lblMinutos = new Label();
                    lblMinutos.Location = new Point(300, 5);
                    lblMinutos.Text = "Minutos de Jogo:";
                    lblMinutos.Width = 115;
                    lblMinutos.Font = new Font("Berlin Sans FB Demi", 10, FontStyle.Regular);
                    lblMinutos.Anchor = AnchorStyles.Top;
                    lblMinutos.Visible = true;
                    panel.Controls.Add(lblMinutos);

                    Label tbMinutos = new Label();
                    tbMinutos.Location = new Point(410, 6);
                    tbMinutos.Width = 40;
                    tbMinutos.Text = MinutosJogo;
                    tbMinutos.Font = new Font("Arial", 9, FontStyle.Regular);
                    tbMinutos.RightToLeft = RightToLeft.Yes;
                    tbMinutos.Anchor = AnchorStyles.Top;
                    tbMinutos.RightToLeft = RightToLeft.Yes;
                    tbMinutos.Visible = true;
                    panel.Controls.Add(tbMinutos);

                }
                drgolos.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();


        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
