using System;
using System.Collections;
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
    public partial class update_events : Form
    {
        private string loggedInUsername;
        private string connectionString = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";

        public update_events(string name)
        {
            InitializeComponent();
            loggedInUsername = name;
            DisplayEvents();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string query;
        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                query = "SELECT * FROM eventss WHERE event_name LIKE @name";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@name", txtSearchItem.Text + "%");
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }

        }


        private void txtfullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPhonenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int eventId = Convert.ToInt32(selectedRow.Cells["event_id"].Value);

                // Get the updated data from input fields
                string eventName = txtfullName.Text;
                string description = txtPhonenumber.Text;
                DateTime startDate = dateTimePicker1.Value;
                DateTime endDate = dateTimePicker2.Value;

                // Update the record in the SQL table
                UpdateEvent(eventId, eventName, startDate, endDate, description);

                // Refresh DataGridView
                DisplayEvents();

                // Display a success message
                MessageBox.Show("Event information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void DisplayEvents()
        {
            string societyName = GetSocietyName(loggedInUsername);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT event_id, event_name, starting_date, ending_date, descriptions FROM eventss WHERE society_name = @societyName", connection);
                command.Parameters.AddWithValue("@societyName", societyName);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void update_events_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is clicked
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate the input boxes with data from the selected row
                txtfullName.Text = selectedRow.Cells["event_name"].Value.ToString();
                txtPhonenumber.Text = selectedRow.Cells["descriptions"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["starting_date"].Value);
                dateTimePicker2.Value = Convert.ToDateTime(selectedRow.Cells["ending_date"].Value);
            }
        }
        private void UpdateEvent(int eventId, string eventName, DateTime startDate, DateTime endDate, string description)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE eventss SET event_name = @eventName, starting_date = @startDate, ending_date = @endDate, descriptions = @description WHERE event_id = @eventId", connection);
                command.Parameters.AddWithValue("@eventId", eventId);
                command.Parameters.AddWithValue("@eventName", eventName);
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);
                command.Parameters.AddWithValue("@description", description);

                command.ExecuteNonQuery();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            EventManagementP eventManagement = new EventManagementP(loggedInUsername);
            eventManagement.Show();
        }
    }
}