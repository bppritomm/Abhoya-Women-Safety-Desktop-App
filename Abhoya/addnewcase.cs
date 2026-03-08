using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Abhoya
{
    public partial class addnewcase : Form
    {
        public addnewcase()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labeldistict_Click(object sender, EventArgs e)
        {

        }

        private void labelage_Click(object sender, EventArgs e)
        {

        }

        private void addnewcase_Load(object sender, EventArgs e)
        {

        }

        private void labelcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelsavecase_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=AbhoyaDB.sqlite;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string insertQuery = "INSERT INTO Cases (CaseNumber, District, AgeGroup, IncidentDate, Status, Remarks) VALUES (@caseNo, @district, @age, @date, @status, @remarks)";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                {

                    cmd.Parameters.AddWithValue("@caseNo", textBoxcaseno.Text);
                    cmd.Parameters.AddWithValue("@district", comboBoxdistrict.Text);
                    cmd.Parameters.AddWithValue("@age", comboBoxagegroup.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePickerdate.Text);
                    cmd.Parameters.AddWithValue("@status", comboBoxcasestatus.Text);
                    cmd.Parameters.AddWithValue("@remarks", textBoxupdate.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Case Saved Successfully!", "Success");
            this.Close();
        }

        private void labelcasedetails_Click(object sender, EventArgs e)
        {

        }
    }
}
