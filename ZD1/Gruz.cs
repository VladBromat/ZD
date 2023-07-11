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
    public partial class Gruz : Form
    {
        public Gruz()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gruz_Load(object sender, EventArgs e)
        {
            tbKodGr.Text = DataGruz.KodGruz;
            tbGr.Text = DataGruz.Gruz;
            tbVid.Text = DataGruz.Vid ;
            tbDesc.Text = DataGruz.Desc;
            tbBrut.Text = DataGruz.Brutto;
            tbVesGruza.Text = DataGruz.VesGruz;
            tbVesTara.Text = DataGruz.VesTara;
            tbSpec.Text = DataGruz.Spec;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DataGruz.KodGruz = tbKodGr.Text;
            DataGruz.Gruz = tbGr.Text;
            DataGruz.Vid = tbVid.Text;
            DataGruz.Desc = tbDesc.Text;
            DataGruz.Brutto = tbBrut.Text;
            DataGruz.VesGruz = tbVesGruza.Text;
            DataGruz.VesTara = tbVesTara.Text;
            DataGruz.Spec = tbSpec.Text;
            new Zakaz().Show();
            Hide();
        }

        private void ClearTB()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                        func(control.Controls);

                }
            };
            func(Controls);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTB();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Zakaz().Show();
            Hide();
        }
    }
}
