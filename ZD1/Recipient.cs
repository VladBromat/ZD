using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZD1
{
    public partial class Recipient : Form
    {
        public Recipient()
        {
            InitializeComponent();
        }

        private void Recipient_Load(object sender, EventArgs e)
        {
            tbKodStr.Text = DataResipient.ResCodStr;
            tbStr.Text = DataResipient.ResStr;
            tbKodStn.Text = DataResipient.ResCodStn;
            tbStn.Text = DataResipient.ResStn;
            tbName.Text = DataResipient.Res;
            tbAddress.Text = DataResipient.ResAddr;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DataResipient.ResCodStr = tbKodStr.Text;
            DataResipient.ResStr = tbStr.Text;
            DataResipient.ResCodStn = tbKodStn.Text;
            DataResipient.ResStn = tbStn.Text;
            DataResipient.Res = tbName.Text;
            DataResipient.ResAddr = tbAddress.Text;
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
