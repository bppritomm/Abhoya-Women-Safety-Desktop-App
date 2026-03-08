using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Abhoya
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=AbhoyaDB.sqlite;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Status, Remarks FROM Cases WHERE CaseNumber = @caseNo";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@caseNo", txtCaseId.Text);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            comboStatus.Text = reader["Status"].ToString();
                            txtRemark.Text = reader["Remarks"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("এই আইডিটি ডেটাবেসে নেই! সঠিক Case ID দিন।", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            comboStatus.Text = "";
                            txtRemark.Text = "";
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCaseId.Text) || string.IsNullOrWhiteSpace(comboStatus.Text))
            {
                MessageBox.Show("অনুগ্রহ করে আগে একটি Case ID দিয়ে Search করুন এবং স্ট্যাটাস সিলেক্ট করুন!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=AbhoyaDB.sqlite;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE Cases SET Status = @newStatus, Remarks = @newRemark WHERE CaseNumber = @caseNo";

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@newStatus", comboStatus.Text);
                    cmd.Parameters.AddWithValue("@newRemark", txtRemark.Text);
                    cmd.Parameters.AddWithValue("@caseNo", txtCaseId.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show($"Case ID: {txtCaseId.Text} সফলভাবে আপডেট হয়েছে!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void update_Load(object sender, EventArgs e)
        {

        }
        private void labelupdatecase_Click(object sender, EventArgs e)
        {
           
        }
    }
}
