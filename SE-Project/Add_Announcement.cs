using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class Add_Announcement : Form
    {
        private string loggedInUsername;
        private string connectionString = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";

        public Add_Announcement(string loggedInUsername)
        {
            InitializeComponent();
            this.loggedInUsername = loggedInUsername;
        }

        private void Add_Announcement_Load(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string announcement = txtDescription.Text.Trim();

            if (!string.IsNullOrEmpty(announcement))
            {
                // Insert the announcement into the database
                InsertAnnouncement(announcement);

                MessageBox.Show("Announcement has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the description box
                txtDescription.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an announcement.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertAnnouncement(string announcement)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Announcements (Description, AnnouncementDate, PresidentName, SocietyName) VALUES (@description, @announcementDate, @presidentName, @societyName)", connection);
                command.Parameters.AddWithValue("@description", announcement);
                command.Parameters.AddWithValue("@announcementDate", DateTime.Now);
                command.Parameters.AddWithValue("@presidentName", loggedInUsername); // Assuming loggedInUsername is the president's name
                command.Parameters.AddWithValue("@societyName", GetSocietyName(loggedInUsername)); // Assuming GetSocietyName is a method to get the society name based on the president's username
                command.ExecuteNonQuery();
            }
        }

        private string GetSocietyName(string username)
        {
            string societyName = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT name FROM societies WHERE presidentName = @username", connection);
                command.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    societyName = reader["name"].ToString();
                }
            }

            return societyName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            President_MainScreen student_MainScreen = new President_MainScreen(loggedInUsername);
            student_MainScreen.Show();
            this.Hide();
        }
    }
}
