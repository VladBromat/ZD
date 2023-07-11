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
    public partial class Sender : Form
    {
        public Sender()
        {
            InitializeComponent();
        }

        private void Sender_Load(object sender, EventArgs e)
        {
            tbName.Text = DataSender.Send;
            tbKodStr.Text = DataSender.SendCodStr;
            tbStr.Text = DataSender.SendStr;
            tbKodStn.Text = DataSender.SendCodStn;
            tbStn.Text = DataSender.SendStn;
            tbAddress.Text = DataSender.SendAddr;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DataSender.SendCodStr = tbKodStr.Text;
            DataSender.SendStr = tbStr.Text;
            DataSender.SendCodStn = tbKodStn.Text;
            DataSender.SendStn = tbStn.Text;
            DataSender.Send = tbName.Text;
            DataSender.SendAddr = tbAddress.Text;
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
