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
    public partial class RegisterSociety : Form
    {
        private string loggedInUsername;
        public RegisterSociety(string loggedInUsername)
        {
            InitializeComponent();
            this.loggedInUsername = loggedInUsername;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        string username;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Check if any of the text fields are empty
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPresidentName.Text) ||
                string.IsNullOrWhiteSpace(txtDepartment.Text) ||
                string.IsNullOrWhiteSpace(txtBatch.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Initialize connection string
            string connectionString = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";

            // Create SqlConnection object and open connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the society name already exists
                string checkQuery = "SELECT COUNT(*) FROM dbo.societies WHERE name = @Name";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtName.Text;
                    int existingSocietyCount = (int)checkCommand.ExecuteScalar();
                    if (existingSocietyCount > 0)
                    {
                        MessageBox.Show("Society with this name already exists. Please choose a different name.", "Duplicate Society Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Insert new society record
                string query = "INSERT INTO dbo.societies (name, presidentName, Department, Batch, Date, Description) VALUES (@Name, @presidentName, @department, @batch, @date, @description)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtName.Text;
                    command.Parameters.Add("@presidentName", SqlDbType.VarChar).Value = txtPresidentName.Text;
                    command.Parameters.Add("@department", SqlDbType.VarChar).Value = txtDepartment.Text;
                    command.Parameters.Add("@batch", SqlDbType.VarChar).Value = txtBatch.Text;
                    command.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@description", SqlDbType.VarChar).Value = txtDescription.Text;

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Society Registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear the input fields after successful insertion
                        txtName.Clear();
                        txtPresidentName.Clear();
                        txtDepartment.Clear();
                        txtBatch.Clear();
                        txtcurrent_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Update the current time TextBox
                        txtDescription.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to register society. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterSociety_Load(object sender, EventArgs e)
        {
            // When the form loads, set the current date and time in txtcurrent_time TextBox
            txtcurrent_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

//            txtPresidentName.Text = loggedInUsername;
        }

        private void txtcurrent_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPresidentName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
