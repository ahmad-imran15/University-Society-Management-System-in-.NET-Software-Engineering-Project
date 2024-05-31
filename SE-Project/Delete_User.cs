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
    public partial class Delete_User : Form
    {
        string connstring = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";
        string query;
        public Delete_User()
        {
            InitializeComponent();
            RefreshData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                query = @"SELECT id, fullname AS Full_Name, Phonenumber AS Phone_Number, 
                        emailaddress AS Email_Address, username AS Username, category AS Category
                        FROM users 
                        WHERE id LIKE @searchText OR 
                            fullname LIKE @searchText OR 
                            Phonenumber LIKE @searchText OR 
                            emailaddress LIKE @searchText OR 
                            username LIKE @searchText OR 
                            category LIKE @searchText";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" + txtSearchItem.Text + "%");
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idToRemove;

            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null &&
                int.TryParse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), out idToRemove))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connstring))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("DELETE FROM users WHERE id = @id", connection))
                        {
                            command.Parameters.Add("@id", SqlDbType.Int).Value = idToRemove;
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("User with ID " + idToRemove + " has been removed.", "User Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid user.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RefreshData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM users", connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No users found.", "No Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_MainScreen login = new Admin_MainScreen();
            login.Show();
        }

        private void Delete_User_Load(object sender, EventArgs e)
        {

        }
    }
}
