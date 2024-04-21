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
    public partial class FeedBack : Form
    {
        string loggedInUsername;
        public FeedBack(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
            FetchUserName();
            PopulateSocietyNames();
        }

        private void FetchUserName()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True"))
                {
                    connection.Open();
                    string selectQuery = "SELECT fullname FROM users WHERE username = @username";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", loggedInUsername);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            txtname.Text = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching user information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {

            string selectedSocietyName = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedSocietyName))
            {
                MessageBox.Show("Please select a society name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFeedbackToDatabase(txtname.Text, txtpurpose.Text, selectedSocietyName, txtfeedback.Text);

        }

        private void SaveFeedbackToDatabase(string name, string purpose, string societyname, string feedback)
        {
            try

            {
                using (SqlConnection connection = new SqlConnection("Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True"))
                {



                    connection.Open();

                    string insertQuery = "INSERT INTO feedback (fullname, purpose,societyname, feedback_text) VALUES (@fullname, @purpose ,@societyname, @feedback_text)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@fullname", name);
                        command.Parameters.AddWithValue("@purpose", purpose);
                        command.Parameters.AddWithValue("@societyname", societyname);
                        command.Parameters.AddWithValue("@feedback_text", feedback);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Feedback saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname.Clear();
                txtpurpose.Clear();
                txtfeedback.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateSocietyNames()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True;" +
                    ""))
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


        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_MainScreen student_MainScreen = new Student_MainScreen(loggedInUsername);
            student_MainScreen.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FeedBack_Load(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
