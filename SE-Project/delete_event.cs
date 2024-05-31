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
    public partial class delete_event : Form
    {
        private string loggedInUsername;
        private string connectionString = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";
        public delete_event(string name)
        {
            InitializeComponent();
            loggedInUsername = name;
            DisplayEvents();
        }

        private void delete_event_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the event ID and event name from the selected row
                int eventId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["event_id"].Value);
                string eventName = GetEventName(eventId);

                // Delete the event from the DataGridView and the SQL table
                DeleteEvent(eventId);

                // Display the event name of the deleted event
                MessageBox.Show("Event '" + eventName + "' has been deleted.", "Event Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GetEventName(int eventId)
        {
            string eventName = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT event_name FROM eventss WHERE event_id = @eventId", connection);
                command.Parameters.AddWithValue("@eventId", eventId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    eventName = reader["event_name"].ToString();
                }
            }

            return eventName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //nothimg int his
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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void DeleteEvent(int eventId)
        {
            // Delete the event from the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells["event_id"].Value) == eventId)
                {
                    dataGridView1.Rows.Remove(row);
                    break;
                }
            }

            // Delete the event from the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM eventss WHERE event_id = @eventId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@eventId", eventId);
                command.ExecuteNonQuery();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            EventManagementP eventManagement = new EventManagementP(loggedInUsername);
            eventManagement.Show();
        }
    }


}