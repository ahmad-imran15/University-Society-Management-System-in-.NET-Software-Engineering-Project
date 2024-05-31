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
    public partial class newformrandom : Form
    {
        public newformrandom()
        {
            InitializeComponent();
            PopulateSocietyNames(); // Populate society names when the form loads
        }

        private void PopulateSocietyNames()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True;"))
                {
                    connection.Open();
                    string selectQuery = "SELECT DISTINCT name FROM societies";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string societyName = reader["name"].ToString();
                                comboBox1.Items.Add(societyName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching society names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSocietyName = comboBox1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedSocietyName))
            {
                FetchPresidentName(selectedSocietyName);
            }
        }
        private void FetchPresidentName(string societyName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True;"))
                {
                    connection.Open();
                    string selectQuery = "SELECT presidentName FROM societies WHERE name = @societyName";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@societyName", societyName);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            txtname.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("President's name not found for the selected society.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching president's name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpurpose_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfeedback_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True;"))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO randomtable (society_name, name, purpose, feedback) VALUES (@societyName, @name, @purpose, @feedback)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@societyName", comboBox1.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@name", txtname.Text);
                        command.Parameters.AddWithValue("@purpose", txtpurpose.Text);
                        command.Parameters.AddWithValue("@feedback", txtfeedback.Text);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear the textboxes after saving
                txtname.Clear();
                txtpurpose.Clear();
                txtfeedback.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
