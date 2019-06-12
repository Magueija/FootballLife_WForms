using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            Application.Run(new PaginaInicial());
        }

        //MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
