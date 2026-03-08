using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SQLite;


namespace Abhoya
{
    public partial class Dashboard : Form

    {
        public static string LoggedInUser = "";

        string connectionString = "Data Source=AbhoyaDB.sqlite;Version=3;";

        public Dashboard()
        {
            InitializeComponent();
            CreateDatabaseIfNotExist();
            LoadCases();
            UpdateDashboardCounters();
            if (LoggedInUser == "Public")
            {

                labelupdatecase.Visible = false;
                labeladdnew.Visible = false;
            }
        }
        private void CreateDatabaseIfNotExist()
        {
            string dbName = "AbhoyaDB.sqlite";


            if (!System.IO.File.Exists(dbName))
            {
                SQLiteConnection.CreateFile(dbName);

                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + dbName + ";Version=3;"))
                {
                    conn.Open();

                    string createTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Cases (
                            CaseNumber TEXT PRIMARY KEY,
                            District TEXT,
                            VictimAgeGroup TEXT,
                            IncidentDate TEXT,
                            Status TEXT,
                            Remarks TEXT
                        )";

                    using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void LoadCases()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Cases";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void UpdateDashboardCounters()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string totalQuery = "SELECT COUNT(*) FROM Cases";
                using (SQLiteCommand cmd = new SQLiteCommand(totalQuery, conn))
                {
                    int total = Convert.ToInt32(cmd.ExecuteScalar());
                    labeltotalcase.Text = "Total Cases : " + total.ToString();
                }

                string resolvedQuery = "SELECT COUNT(*) FROM Cases WHERE Status = 'Resolved'";
                using (SQLiteCommand cmd = new SQLiteCommand(resolvedQuery, conn))
                {
                    int resolved = Convert.ToInt32(cmd.ExecuteScalar());
                    labelresolvedcase.Text = "Resolved Cases : " + resolved.ToString();
                }
            }
        }


        private void labeldashboard_Click(object sender, EventArgs e)
        {

        }

        private void labelsearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=AbhoyaDB.sqlite;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();


                string searchQuery = "SELECT * FROM Cases WHERE CaseNumber LIKE @searchKeyword OR District LIKE @searchKeyword";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(searchQuery, conn);

                adapter.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" + textcaseid.Text + "%");

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }


        }

        private void labellogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void labeladdnew_Click(object sender, EventArgs e)
        {
            addnewcase addCaseForm = new addnewcase();
            addCaseForm.ShowDialog();

            LoadCases();
            UpdateDashboardCounters();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string helpMessage = "🚨 জরুরী সেবার নাম্বারসমূহ:\n\n" +
                                 "📞 জাতীয় জরুরী সেবা: ৯৯৯ (999)\n" +
                                 "📞 নারী ও শিশু নির্যাতন প্রতিরোধ: ১০৯ (109)\n" +
                                 "📞 সরকারি আইনি সহায়তা: ১৬৪৩০ (16430)\n\n" +
                                 "**ধর্ষণ প্রতিরোধে করণীয়**\r\n\r\n1. নির্জন বা ঝুঁকিপূর্ণ জায়গা এড়িয়ে চলা।\r\n2. কোথায় যাচ্ছেন তা পরিবার বা বিশ্বস্ত কাউকে জানানো।\r\n3. আত্মরক্ষার মৌলিক কৌশল (self-defense) শেখা।\r\n4. বিপদের আশঙ্কা হলে জোরে চিৎকার করে আশেপাশের মানুষের দৃষ্টি আকর্ষণ করা।\r\n5. সম্ভব হলে বন্ধু বা পরিচিত কারও সাথে চলাফেরা করা।\r\n6. মোবাইলে জরুরি নম্বর বা SOS ব্যবস্থা চালু রাখা।\r\n7. সমাজে পারস্পরিক সচেতনতা ও সহযোগিতা বৃদ্ধি করা।\r\n\n\n" +
                                 "আপনার লোকেশন ট্র্যাক করা হচ্ছে। সাবধানে থাকুন!";

            MessageBox.Show(helpMessage, "Ask for Help (SOS)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void labelhighriskzones_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {

                Console.Beep(2000, 500);
                System.Threading.Thread.Sleep(100);
            }


            string connectionString = "Data Source=AbhoyaDB.sqlite;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT District, COUNT(*) as TotalCases FROM Cases GROUP BY District ORDER BY TotalCases DESC LIMIT 1";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string riskyDistrict = reader["District"].ToString();
                            string caseCount = reader["TotalCases"].ToString();

                            string alertMessage = $"⚠️ সতর্কবার্তা!\n\nবর্তমানে সবচেয়ে ঝুঁকিপূর্ণ এলাকা (High Risk Zone) হলো: {riskyDistrict}\n\nএই এলাকায় মোট {caseCount} টি কেস রেকর্ড করা হয়েছে।";

                            MessageBox.Show(alertMessage, "High Risk Zone Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("এখনো কোনো কেস ডেটাবেসে নেই! চারপাশ নিরাপদ। 🌿", "Safe Zone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelupdatecase_Click(object sender, EventArgs e)
        {
            update updateForm = new update();
            updateForm.ShowDialog();

       
            LoadCases();
            UpdateDashboardCounters();
        }
    }
}
