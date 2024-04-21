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
    public partial class ViewfeedBack : Form
    {
        string connstring = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";
        string query;
        int id;
        public ViewfeedBack()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    connection.Open();

                    // Select all items from the Items table
                    string selectQuery = "SELECT * FROM Feedback";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Set the DataGridView's data source to the retrieved data
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to retrieve items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadData()
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                query = "SELECT ID, fullname, purpose, societyname, feedback_text FROM feedback";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }


        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                query = "SELECT ID, fullname, purpose, societyname, feedback_text FROM feedback WHERE fullname LIKE @searchText OR purpose LIKE @searchText OR societyname LIKE @searchText OR feedback_text LIKE @searchText";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" + txtSearchItem.Text + "%");
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
            this.Hide();
            Admin_MainScreen admin_MainScreen = new Admin_MainScreen();
            admin_MainScreen.Show();
        }

        private void RemoveFeedback(int feedbackId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM feedback WHERE ID = @id";
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", feedbackId);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Feedback removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData(); // Refresh the data grid after removal
                        }
                        else
                        {
                            MessageBox.Show("No feedback found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to remove feedback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int feedbackId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                if (MessageBox.Show("Are you sure you want to remove this feedback?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RemoveFeedback(feedbackId);
                }
            }
            else
            {
                MessageBox.Show("Please select a feedback to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ViewfeedBack_Load(object sender, EventArgs e)
        {

        }
    }
}
