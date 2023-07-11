using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZD1
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ZD1.Properties.Settings.Zakaz"].ConnectionString);

        private void btnViewZakaz_Click(object sender, EventArgs e)
        {
            
        }

        private void View_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string load = "Select * from Zakaz";
                sda = new SqlDataAdapter(load, conn);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка показа данных" + ex);
            }

            finally
            {
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand del = new SqlCommand("Delete from [Zakaz] Where Id = '" +textBox2.Text+"'", conn);
                del.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }

            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                string load = "Select * from Zakaz";
                sda = new SqlDataAdapter(load, conn);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка показа данных" + ex);
            }

            finally
            {
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    conn.Open();
                    scb = new SqlCommandBuilder(sda);
                    sda.Update(dt);
                    MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
                finally 
                { 
                    conn.Close(); 
                }

            }   


            try
            {
                conn.Open();
                string load = "Select * from Zakaz";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка показа данных" + ex);
            }

            finally
            {
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Gruz LIKE '%{textBox1.Text}%'";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Hide();
        }
    }
}
