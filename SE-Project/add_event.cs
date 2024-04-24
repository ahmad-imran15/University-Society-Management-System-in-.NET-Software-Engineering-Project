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
    public partial class add_event : Form
    {
        private string loggedInUsername;
        private string connectionString = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";

        public add_event(string name)
        {
            InitializeComponent();
            loggedInUsername = name;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtfeedback_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

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

        private bool EventExists(string eventName, DateTime startingDate)
        {
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM eventss WHERE event_name = @eventName AND starting_date = @startingDate", connection);
                command.Parameters.AddWithValue("@eventName", eventName);
                command.Parameters.AddWithValue("@startingDate", startingDate);
                object result = command.ExecuteScalar();

                // Check if the result is null or DBNull
                if (result != null && result != DBNull.Value)
                {
                    int count = Convert.ToInt32(result);
                    exists = count > 0;
                }
            }

            return exists;
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string eventName = textBoxName.Text.Trim();

            // Check if the event name is not empty
            if (!string.IsNullOrEmpty(eventName))
            {
                DateTime startingDate = dateTimePicker1.Value.Date;

                // Check if an event with the same name and starting date already exists
                if (EventExists(eventName, startingDate))
                {
                    MessageBox.Show("An event with the same name and starting date already exists. Please choose a different name or starting date.", "Duplicate Event", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Proceed with adding the event to the database
                    string endingDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    string description = txtfeedback.Text.Trim();
                    string societyName = GetSocietyName(loggedInUsername);

                    // Insert the event into the database
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO eventss (event_name, starting_date, ending_date, descriptions, society_name) VALUES (@eventName, @startingDate, @endingDate, @description, @societyName)", connection);
                        command.Parameters.AddWithValue("@eventName", eventName);
                        command.Parameters.AddWithValue("@startingDate", startingDate);
                        command.Parameters.AddWithValue("@endingDate", endingDate);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@societyName", societyName);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Event added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid event name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textBoxName.Clear();
            txtfeedback.Clear();




        }

        private void add_event_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventManagementP eventManagement = new EventManagementP(loggedInUsername);
            eventManagement.Show();

        }
    }

}