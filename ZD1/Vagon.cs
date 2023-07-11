using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ZD1
{
    public partial class Vagon : Form
    {
        public Vagon()
        {
            InitializeComponent();
        }
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ZD1.Properties.Settings.Zakaz"].ConnectionString);

        private void Vagon_Load(object sender, EventArgs e)
        {


           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand quary = new SqlCommand($"INSERT INTO Vagon (FactureNumber, VagonNumber, Rod, LoadCapacity, NumberAxes, NumberSeats)" +
                    "VALUES (@FactureNumber, @VagonNumber, @Rod, @LoadCapacity, @NumberAxes, @NumberSeats)", conn);

                quary.Parameters.AddWithValue("FactureNumber", tbFacture.Text);
                quary.Parameters.AddWithValue("VagonNumber", tbVagon.Text);
                quary.Parameters.AddWithValue("Rod", tbRod.Text);
                quary.Parameters.AddWithValue("LoadCapacity", tbLoad.Text);
                quary.Parameters.AddWithValue("NumberAxes", tbAxes.Text);
                quary.Parameters.AddWithValue("NumberSeats", tbSeats.Text);


                quary.ExecuteNonQuery().ToString();
                MessageBox.Show("Добавлено");

                ClearTB();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }

            finally
            {
                conn.Close();
            }
        }

        

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTB();

        }
    }
}
