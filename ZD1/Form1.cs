using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZakaz_Click(object sender, EventArgs e)
        {
            Zakaz zakaz = new Zakaz();
            zakaz.Show();
            Hide();
        }

        private void btnVagon_Click(object sender, EventArgs e)
        {
            Vagon vagon = new Vagon();
            vagon.Show();
            Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
