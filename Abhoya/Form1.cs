using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;
using System.IO;
namespace Abhoya
{
    public partial class Login_Screen : Form
    {
        string connectionString = "Data Source=AbhoyaDB.sqlite;Version=3;";
        public Login_Screen()
        {
            InitializeComponent();
            SetupDatabase();
        }
        private void SetupDatabase()
        {
            if (!File.Exists("AbhoyaDB.sqlite"))
            {
                SQLiteConnection.CreateFile("AbhoyaDB.sqlite");
            }


            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Cases (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        CaseNumber TEXT,
                        District TEXT,
                        AgeGroup TEXT,
                        IncidentDate TEXT,
                        Status TEXT,
                        Remarks TEXT
                    )";
                SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn);
                cmd.ExecuteNonQuery();
            }
        }
        private void pictureBoxlogo_Click(object sender, EventArgs e)
        {

        }

        private void labellogin_Click(object sender, EventArgs e)
        {
            if (textBoxusername.Text == "admin_pritom" && textBoxpassword.Text == "1234")
            {
                Dashboard.LoggedInUser = "Admin";
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password. Try again!", "Error");
            }
        }

        private void labelusername_Click(object sender, EventArgs e)
        {

        }

        private void Login_Screen_Load(object sender, EventArgs e)
        {

        }

        private void labelpublic_Click(object sender, EventArgs e)
        {
            Dashboard.LoggedInUser = "Public";
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
