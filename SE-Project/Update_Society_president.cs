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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SE_Project
{
    public partial class Update_Society_president : Form
    {

        private string connstring = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";
        private int id;
        private string username;
        public Update_Society_president(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadSocietyData();



        }

        private void LoadSocietyData()
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                string query = "SELECT ID, Name, Department, Description " +
                               "FROM societies " +
                               "WHERE presidentName = (SELECT fullname FROM users WHERE username = @username)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    // Set the DataGridView auto size mode
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading society data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Update_Society_president_Load(object sender, EventArgs e)
        {
            FetchSocietyDetails();
            LoadSocietyData();
        }

        private void FetchSocietyDetails()
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                string query = "SELECT s.name, s.Department, s.Description " +
                              "FROM societies s " +
                              "INNER JOIN users u ON s.presidentName = u.fullname " +
                              "WHERE u.username = @username";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtName.Text = reader["name"].ToString();
                        txtPresidentName.Text = reader["Department"].ToString();
                        txtDescription.Text = reader["Description"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No society details found for the current user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching society details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            UpdateSocietyDetails();

        }

        private void UpdateSocietyDetails()
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                string query = "UPDATE societies " +
                               "SET name = @name, Department = @Department, Description = @description " +
                               "WHERE id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", txtName.Text);
                command.Parameters.AddWithValue("@Department", txtPresidentName.Text);
                command.Parameters.AddWithValue("@description", txtDescription.Text);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {

                        MessageBox.Show("Society details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSocietyData();
                    }
                    else
                    {
                        MessageBox.Show("No changes were made to society details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating society details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtPresidentName.Text = row.Cells["Department"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                id = Convert.ToInt32(row.Cells["ID"].Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            President_MainScreen m = new President_MainScreen(username);
            m.Show();
        }

        private void Update_Society_president_Load_1(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
