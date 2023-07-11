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
using System.Net;
using System.Xml.Linq;

namespace ZD1
{
    public partial class Zakaz : Form
    {
        
        public Zakaz()
        {
            InitializeComponent();
        }
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ZD1.Properties.Settings.Zakaz"].ConnectionString);

        private void Zakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet1.Vagon". При необходимости она может быть перемещена или удалена.
            this.vagonTableAdapter1.Fill(this._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet1.Vagon);

            tbSender.Text = DataSender.Send;
            tbKodSenstr.Text = DataSender.SendCodStr;
            tbSenStr.Text = DataSender.SendStr;
            tbKodStnSen.Text = DataSender.SendCodStn;
            tbStnSen.Text = DataSender.SendStn;
            tbAddrSen.Text = DataSender.SendAddr;

            tbKodStrRes.Text = DataResipient.ResCodStr;
            tbStrRes.Text = DataResipient.ResStr;
            tbKodStnRes.Text = DataResipient.ResCodStn;
            tbStnRes.Text = DataResipient.ResStn;
            tbRecipient.Text = DataResipient.Res;
            tbAddrRes.Text = DataResipient.ResAddr;

            tbKodGr.Text = DataGruz.KodGruz;
            tbGr.Text = DataGruz.Gruz;
            tbVid.Text = DataGruz.Vid;
            tbDesc.Text = DataGruz.Desc;
            tbBrut.Text = DataGruz.Brutto;
            tbVesGruza.Text = DataGruz.VesGruz;
            tbVesTara.Text = DataGruz.VesTara;
            tbSpec.Text = DataGruz.Spec;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Hide();
        }

        private void btnSender_Click(object sender, EventArgs e)
        {
            DataSender.Send = tbSender.Text;
            DataSender.SendCodStr = tbKodSenstr.Text;
            DataSender.SendStr = tbSenStr.Text ;
            DataSender.SendCodStn = tbKodStnSen.Text;
            DataSender.SendStn = tbStnSen.Text;
            DataSender.SendAddr = tbAddrSen.Text;
            new Sender().Show();
            Hide();
        }

        private void btnRecipient_Click(object sender, EventArgs e)
        {
            DataResipient.ResCodStr = tbKodStrRes.Text;
            DataResipient.ResStr = tbStrRes.Text;
            DataResipient.ResCodStn = tbKodStnRes.Text;
            DataResipient.ResStn = tbStnRes.Text ;
            DataResipient.Res = tbRecipient.Text;
            DataResipient.ResAddr = tbAddrRes.Text;
            new Recipient().Show();
            Hide();
        }

        private void btnGruz_Click(object sender, EventArgs e)
        {
            DataGruz.KodGruz = tbKodGr.Text;
            DataGruz.Gruz = tbGr.Text;
            DataGruz.Vid = tbVid.Text;
            DataGruz.Desc = tbDesc.Text;
            DataGruz.Brutto = tbBrut.Text;
            DataGruz.VesGruz = tbVesGruza.Text;
            DataGruz.VesTara = tbVesTara.Text;
            DataGruz.Spec = tbSpec.Text;
            new Gruz().Show();
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

                SqlCommand quary = new SqlCommand($"INSERT INTO Gruz (KodGruza, GruzName, VidPackaging, Description, SpecialMarks, GrossWeight, WeightGruza, WeightTara)" +
                    "VALUES (@KodGruza, @GruzName, @VidPackaging, @Description, @SpecialMarks, @GrossWeight, @WeightGruza, @WeightTara)", conn);

                SqlCommand quary1 = new SqlCommand($"INSERT INTO Sender (KodСountry, Сountry, StationCode, StationName, SenderName, SenderAddress)" +
                    "VALUES (@KodСountry, @Сountry, @StationCode, @StationName, @SenderName, @SenderAddress)", conn);

                SqlCommand quary2 = new SqlCommand($"INSERT INTO Recipient (KodСountry, Сountry, StationCode, StationName, RecipientName, RecipientAddress)" +
                    "VALUES (@KodСountry, @Сountry, @StationCode, @StationName, @RecipientName, @RecipientAddress)", conn);

                SqlCommand quary3 = new SqlCommand($"INSERT INTO Zakaz (VagonNumber, Gruz, Description, SenderName, RecipientName, ResponsiblePerson, DateOrder, DateIssue, Status)" +
                    "VALUES (@VagonNumber, @Gruz, @Description, @SenderName, @RecipientName, @ResponsiblePerson, @DateOrder, @DateIssue, @Status)", conn);


                quary.Parameters.AddWithValue("KodGruza", tbKodGr.Text);
                quary.Parameters.AddWithValue("GruzName", tbGr.Text);
                quary.Parameters.AddWithValue("VidPackaging", tbVid.Text);
                quary.Parameters.AddWithValue("Description", tbDesc.Text);
                quary.Parameters.AddWithValue("SpecialMarks", tbSpec.Text);
                quary.Parameters.AddWithValue("GrossWeight", tbBrut.Text);
                quary.Parameters.AddWithValue("WeightGruza", tbVesGruza.Text);
                quary.Parameters.AddWithValue("WeightTara", tbVesTara.Text);

                quary1.Parameters.AddWithValue("KodСountry", tbKodSenstr.Text);
                quary1.Parameters.AddWithValue("Сountry", tbSenStr.Text);
                quary1.Parameters.AddWithValue("StationCode", tbKodStnSen.Text);
                quary1.Parameters.AddWithValue("StationName", tbStnSen.Text);
                quary1.Parameters.AddWithValue("SenderName", tbSender.Text);
                quary1.Parameters.AddWithValue("SenderAddress", tbAddrSen.Text);

                quary2.Parameters.AddWithValue("KodСountry", tbKodStrRes.Text);
                quary2.Parameters.AddWithValue("Сountry", tbStrRes.Text);
                quary2.Parameters.AddWithValue("StationCode", tbKodStnRes.Text);
                quary2.Parameters.AddWithValue("StationName", tbStnRes.Text);
                quary2.Parameters.AddWithValue("RecipientName", tbRecipient.Text);
                quary2.Parameters.AddWithValue("RecipientAddress", tbAddrRes.Text);

                quary3.Parameters.AddWithValue("VagonNumber", cbVagon.Text);
                quary3.Parameters.AddWithValue("Gruz", tbGr.Text);
                quary3.Parameters.AddWithValue("Description", tbDesc.Text);
                quary3.Parameters.AddWithValue("SenderName", tbSender.Text);
                quary3.Parameters.AddWithValue("RecipientName", tbRecipient.Text);
                quary3.Parameters.AddWithValue("ResponsiblePerson", tbRespPers.Text);
                quary3.Parameters.AddWithValue("DateOrder", dateTimePicker1.Text);
                quary3.Parameters.AddWithValue("DateIssue", dateTimePicker2.Text);
                quary3.Parameters.AddWithValue("Status", tbStatus.Text);

                quary.ExecuteNonQuery().ToString();
                quary1.ExecuteNonQuery().ToString();
                quary2.ExecuteNonQuery().ToString();
                quary3.ExecuteNonQuery().ToString();
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
