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
    public partial class NovaConvocatoria : Form
    {
        public NovaConvocatoria()
        {
            InitializeComponent();
        }

        private void Tb_Data_Click(object sender, EventArgs e)
        {
            tb_Data.Text = "";
        }

        private void Tb_Hora_Click(object sender, EventArgs e)
        {
            tb_Hora.Text = "";
        }

        private void NovaConvocatoria_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                Titulares();
            }

            for (int i = 0; i < 7; i++)
            {
                Suplentes();
            }

        }

        private void Titulares()
        {
            
            ComboBox CbAtleta = new ComboBox();
            CbAtleta.Location = new Point(0, 5);
            CbAtleta.Width = 159;
            CbAtleta.Font = new Font("Arial", 9, FontStyle.Regular);
            CbAtleta.Anchor = AnchorStyles.Top;
            CbAtleta.DropDownStyle = ComboBoxStyle.DropDownList;
            CbAtleta.Visible = true;
            flowpanel_Titulares.Controls.Add(CbAtleta);


            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = null;
            sql = "SELECT IDAtleta, Nome FROM dbo.TblAtleta WHERE Apagado = 0 AND FK_IDEscalao = " + Properties.Settings.Default.IDEscalao;
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();

                CbAtleta.DataSource = ds.Tables[0];
                CbAtleta.ValueMember = "IDAtleta";
                CbAtleta.DisplayMember = "Nome";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void Suplentes()
        {
            ComboBox CbAtleta = new ComboBox();
            CbAtleta.Location = new Point(0, 5);
            CbAtleta.Width = 159;
            CbAtleta.Font = new Font("Arial", 9, FontStyle.Regular);
            CbAtleta.Anchor = AnchorStyles.Top;
            CbAtleta.DropDownStyle = ComboBoxStyle.DropDownList;
            CbAtleta.Visible = true;
            flowpanel_Suplentes.Controls.Add(CbAtleta);


            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = null;
            sql = "SELECT IDAtleta, Nome FROM dbo.TblAtleta WHERE Apagado = 0 AND FK_IDEscalao = " + Properties.Settings.Default.IDEscalao;
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();

                CbAtleta.DataSource = ds.Tables[0];
                CbAtleta.ValueMember = "IDAtleta";
                CbAtleta.DisplayMember = "Nome";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            con.Close();
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_451.Checked == true)
            {
                P1.Text = "GR";
                P1.ForeColor = Color.ForestGreen;

                P2.Text = "DC";
                P2.ForeColor = Color.DarkBlue;

                P3.Text = "DC";
                P3.ForeColor = Color.DarkBlue;

                P4.Text = "DE";
                P4.ForeColor = Color.DarkBlue;

                P5.Text = "DD";
                P5.ForeColor = Color.DarkBlue;

                P6.Text = "MDC";
                P6.ForeColor = Color.Gold;

                P7.Text = "MC";
                P7.ForeColor = Color.Gold;

                P8.Text = "MC";
                P8.ForeColor = Color.Gold;

                P9.Text = "MOE";
                P9.ForeColor = Color.Gold;

                P10.Text = "MOD";
                P10.ForeColor = Color.Gold;

                P11.Text = "PL";
                P11.ForeColor = Color.Firebrick;
            }
            else if (rb_433.Checked == true)
            {
                P1.Text = "GR";
                P1.ForeColor = Color.ForestGreen;

                P2.Text = "DC";
                P2.ForeColor = Color.DarkBlue;

                P3.Text = "DC";
                P3.ForeColor = Color.DarkBlue;

                P4.Text = "DE";
                P4.ForeColor = Color.DarkBlue;

                P5.Text = "DD";
                P5.ForeColor = Color.DarkBlue;

                P6.Text = "MDC";
                P6.ForeColor = Color.Gold;

                P7.Text = "MC";
                P7.ForeColor = Color.Gold;

                P8.Text = "MC";
                P8.ForeColor = Color.Gold;

                P9.Text = "PL";
                P9.ForeColor = Color.Firebrick;

                P10.Text = "EE";
                P10.ForeColor = Color.Firebrick;

                P11.Text = "ED";
                P11.ForeColor = Color.Firebrick;
            }
            else if (rb_442.Checked == true)
            {
                P1.Text = "GR";
                P1.ForeColor = Color.ForestGreen;

                P2.Text = "DC";
                P2.ForeColor = Color.DarkBlue;

                P3.Text = "DC";
                P3.ForeColor = Color.DarkBlue;

                P4.Text = "DE";
                P4.ForeColor = Color.DarkBlue;

                P5.Text = "DD";
                P5.ForeColor = Color.DarkBlue;

                P6.Text = "MC";
                P6.ForeColor = Color.Gold;

                P7.Text = "MC";
                P7.ForeColor = Color.Gold;

                P8.Text = "ME";
                P8.ForeColor = Color.Gold;

                P9.Text = "MD";
                P9.ForeColor = Color.Gold;

                P10.Text = "PL";
                P10.ForeColor = Color.Firebrick;

                P11.Text = "PL";
                P11.ForeColor = Color.Firebrick;
            }
            else if (rb_352.Checked == true)
            {
                P1.Text = "GR";
                P1.ForeColor = Color.ForestGreen;

                P2.Text = "DC";
                P2.ForeColor = Color.DarkBlue;

                P3.Text = "DC";
                P3.ForeColor = Color.DarkBlue;

                P4.Text = "DC";
                P4.ForeColor = Color.DarkBlue;

                P5.Text = "MDC";
                P5.ForeColor = Color.Gold;

                P6.Text = "MC";
                P6.ForeColor = Color.Gold;

                P7.Text = "MC";
                P7.ForeColor = Color.Gold;

                P8.Text = "ME";
                P8.ForeColor = Color.Gold;

                P9.Text = "MD";
                P9.ForeColor = Color.Gold;

                P10.Text = "PL";
                P10.ForeColor = Color.Firebrick;

                P11.Text = "PL";
                P11.ForeColor = Color.Firebrick;
            }
            else if (rb_343.Checked == true)
            {
                P1.Text = "GR";
                P1.ForeColor = Color.ForestGreen;

                P2.Text = "DC";
                P2.ForeColor = Color.DarkBlue;

                P3.Text = "DC";
                P3.ForeColor = Color.DarkBlue;

                P4.Text = "DC";
                P4.ForeColor = Color.DarkBlue;

                P5.Text = "MC";
                P5.ForeColor = Color.Gold;

                P6.Text = "MC";
                P6.ForeColor = Color.Gold;

                P7.Text = "ME";
                P7.ForeColor = Color.Gold;

                P8.Text = "MD";
                P8.ForeColor = Color.Gold;

                P9.Text = "PL";
                P9.ForeColor = Color.Gold;

                P10.Text = "EE";
                P10.ForeColor = Color.Firebrick;

                P11.Text = "ED";
                P11.ForeColor = Color.Firebrick;
            }
        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {

            if (tb_Data.Text == "" || tb_Hora.Text == "" || tb_Data.Text == "DD/MM/AAAA" || tb_Hora.Text == "HH:MM" || tb_Adversario.Text == "")
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!", "ATENÇÃO!", MessageBoxButtons.OK);
            }
            else
            {
                string IDTatica = "";
                if (rb_451.Checked == true)
                {
                    IDTatica = "1";
                }
                else if (rb_433.Checked == true)
                {
                    IDTatica = "2";
                }
                else if (rb_442.Checked == true)
                {
                    IDTatica = "3";
                }
                else if (rb_352.Checked == true)
                {
                    IDTatica = "4";
                }
                else if (rb_343.Checked == true)
                {
                    IDTatica = "5";
                }

                SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
                con.Open();

                try
                {
                    string IDLastConv = "";
                    SqlDataReader drLastConv;
                    string QueryLastConv = "SELECT IDConvocatoria FROM dbo.TblConvocatoria WHERE FK_IDEscalao = " + Properties.Settings.Default.IDEscalao;

                    SqlCommand CommandLastConv = new SqlCommand(QueryLastConv, con);
                    drLastConv = CommandLastConv.ExecuteReader();
                    while (drLastConv.Read())
                    {
                        IDLastConv = drLastConv["IDConvocatoria"].ToString();
                    }
                    drLastConv.Close();

                    string QueryDeleteTitulates = "DELETE FROM TblTitular WHERE FK_IDConvocatoria = " + IDLastConv;
                    SqlCommand CommandDeleteTitulates = new SqlCommand(QueryDeleteTitulates, con);
                    CommandDeleteTitulates.ExecuteNonQuery();


                    string QueryDeleteSuplentes = "DELETE FROM TblSuplente WHERE FK_IDConvocatoria = " + IDLastConv;
                    SqlCommand CommandDeleteSuplentes = new SqlCommand(QueryDeleteSuplentes, con);
                    CommandDeleteSuplentes.ExecuteNonQuery();


                    string QueryDeleteConv = "DELETE FROM TblConvocatoria WHERE FK_IDEscalao = " + Properties.Settings.Default.IDEscalao;
                    SqlCommand CommandDeleteConv = new SqlCommand(QueryDeleteConv, con);
                    CommandDeleteConv.ExecuteNonQuery();

                    //==================================


                    string QueryInsert = "INSERT INTO dbo.TblConvocatoria (DataJogo, Adversario, FK_IDEscalao, FK_IDTatica) VALUES (@DataJogo, @Adversario, @IDEscalao, @IDTatica)";

                    SqlCommand CommandINSERT = new SqlCommand(QueryInsert, con);
                    CommandINSERT.Parameters.AddWithValue("@DataJogo", tb_Data.Text + " " + tb_Hora.Text);
                    CommandINSERT.Parameters.AddWithValue("@Adversario", tb_Adversario.Text);
                    CommandINSERT.Parameters.AddWithValue("@IDEscalao", Properties.Settings.Default.IDEscalao);
                    CommandINSERT.Parameters.AddWithValue("@IDTatica", IDTatica);
                    CommandINSERT.ExecuteNonQuery();



                    string IDConvocatoria = "";
                    SqlDataReader drConv;
                    string QueryConv = "SELECT MAX(IDConvocatoria) AS MaxConvocatoria FROM dbo.TblConvocatoria";

                    SqlCommand CommandConv = new SqlCommand(QueryConv, con);
                    drConv = CommandConv.ExecuteReader();
                    while (drConv.Read())
                    {
                        IDConvocatoria = drConv["MaxConvocatoria"].ToString();
                    }
                    drConv.Close();

                    string Nome = "";
                    for (int ctr = 0; ctr < flowpanel_Titulares.Controls.Count; ctr++)
                    {
                        
                        Control c = flowpanel_Titulares.Controls[ctr];
                        ComboBox cb = (ComboBox)c;
                        Nome = cb.SelectedValue.ToString();

                        string Querygolo = "INSERT INTO dbo.TblTitular (FK_IDAtleta, FK_IDConvocatoria) VALUES (@IDAtleta, @IDConvocatoria)";

                        SqlCommand Commandgolo = new SqlCommand(Querygolo, con);
                        Commandgolo.Parameters.AddWithValue("@IDAtleta", Nome);
                        Commandgolo.Parameters.AddWithValue("@IDConvocatoria", IDConvocatoria);
                        Commandgolo.ExecuteNonQuery();
                        
                    }

                    for (int ctr = 0; ctr < flowpanel_Suplentes.Controls.Count; ctr++)
                    {
                        Control c = flowpanel_Suplentes.Controls[ctr];
                        ComboBox cb = (ComboBox)c;
                        Nome = cb.SelectedValue.ToString();

                        string Querygolo = "INSERT INTO dbo.TblSuplente (FK_IDAtleta, FK_IDConvocatoria) VALUES (@IDAtleta, @IDConvocatoria)";

                        SqlCommand Commandgolo = new SqlCommand(Querygolo, con);
                        Commandgolo.Parameters.AddWithValue("@IDAtleta", Nome);
                        Commandgolo.Parameters.AddWithValue("@IDConvocatoria", IDConvocatoria);
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
    }
}
