using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace FootballLife_WF
{
    static class Program
    {
        public static string CurrentFuncaoUser { get; set; }
        public static int CurrentIDUser { get; set; }
        public static int CurrentIDEscalao { get; set; }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CurrentFuncaoUser = "";
            CurrentIDUser = 0;
            CurrentIDEscalao = 0;

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            try
            {
                con.Open();

                Application.Run(new PaginaInicial());
            }
            catch (Exception x)
            {
                MessageBox.Show("Base de dados do programa com erro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               if (con.State == System.Data.ConnectionState.Open)
               {
                   con.Close();
               }
            }

            
        }
    }
}
