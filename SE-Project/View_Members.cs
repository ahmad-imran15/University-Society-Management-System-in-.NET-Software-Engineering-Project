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
    public partial class View_Members : Form
    {
        string loggedInUsername;
        string connstring = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";
        string query;
        int id;
        public View_Members(string loggedInUsername)
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.loggedInUsername = loggedInUsername;
            LoadData();
        }

        public void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                string query = "SELECT ID, SocietyName, Fullname, Phonenumber, Email, Batch, Discipline FROM Society_members";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    connection.Open();

                    // Select all items from the Items table
                    string selectQuery = "SELECT * FROM Society_members";
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

        private void RemoveMember(int memberId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Society_Members WHERE ID = @id";
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", memberId);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Refresh the data grid after removal
                        }
                        else
                        {
                            MessageBox.Show("No member found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to remove member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int memberId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                if (MessageBox.Show("Are you sure you want to remove this member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RemoveMember(memberId);
                }
            }
            else
            {
                MessageBox.Show("Please select a member to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            President_MainScreen president_MainScreen = new President_MainScreen(loggedInUsername);
            president_MainScreen.Show();
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                string query = "SELECT ID, SocietyName, Fullname, Phonenumber, Email, Batch, Discipline FROM Society_Members WHERE SocietyName LIKE @searchText OR Fullname LIKE @searchText OR Phonenumber LIKE @searchText OR Email LIKE @searchText OR Batch LIKE @searchText OR Discipline LIKE @searchText";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" + txtSearchItem.Text + "%");
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void View_Members_Load(object sender, EventArgs e)
        {

        }
    }
}
