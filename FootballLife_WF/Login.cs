using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballLife_WF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Img_Logo_Click(object sender, EventArgs e)
        {
            PaginaInicial PagIn = new PaginaInicial();
            this.Hide();
            PagIn.ShowDialog();
            this.Dispose();
        }

        private void Img_BackArrow_MouseHover(object sender, EventArgs e)
        {
            img_BackArrow.Image = Properties.Resources.BackArrow_Login_Hover;
        }

        private void Img_BackArrow_MouseLeave(object sender, EventArgs e)
        {
            img_BackArrow.Image = Properties.Resources.BackArrow_Login_Normal;
        }

        private void Img_BackArrow_Click(object sender, EventArgs e)
        {
            PaginaInicial PagIn = new PaginaInicial();
            this.Hide();
            PagIn.ShowDialog();
            this.Dispose();
        }
    }
}
