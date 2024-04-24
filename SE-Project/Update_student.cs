using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class Update_student : Form

    {
        private string loggedInUsername;
        private byte[] userPhotoData;
        public Update_student(string loggedInUsername)
        {
            InitializeComponent();
            this.loggedInUsername = loggedInUsername;
            PopulateUserInfo();
        }



        private void PopulateUserInfo()
        {
            string connectionString = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM users WHERE username = @username", connection);
                    command.Parameters.AddWithValue("@username", loggedInUsername);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        textBoxName.Text = reader["fullname"].ToString();
                        textBoxPhonenumber.Text = reader["Phonenumber"].ToString();
                        textBoxEmail.Text = reader["emailaddress"].ToString();
                        txtUsername.Text = reader["username"].ToString();
                        textPassword.Text = reader["password"].ToString(); // Password should not be retrieved from the database for security reasons

                        // Retrieve user photo if available
                        if (reader["photo"] != DBNull.Value)
                        {
                            userPhotoData = (byte[])reader["photo"];
                            using (MemoryStream ms = new MemoryStream(userPhotoData))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching user information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Student_MainScreen student_MainScreen = new Student_MainScreen(loggedInUsername);
            student_MainScreen.Show();
        }

        private bool ValidateInputs()
        {
            if (textBoxName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter full name.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(textBoxName.Text, @"^[A-Z][a-zA-Z]*(\s[A-Z][a-zA-Z]*)*$"))
            {
                MessageBox.Show("Invalid full name format. Please enter the full name with the first letter of each name capitalized and without any special characters.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(textBoxPhonenumber.Text, @"^03\d{9}$"))
            {
                MessageBox.Show("Phone number must start with '03' and be 11 digits long including '03'.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(textBoxEmail.Text, @"^[a-z][a-zA-Z0-9._%+-]*@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Please enter username.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtUsername.Text, @"^[a-z]"))
            {
                MessageBox.Show("Username must start with a lowercase letter.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textPassword.Text.Length < 8 || textPassword.Text.Length > 15)
            {
                MessageBox.Show("Password must be between 8 and 15 characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

            private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhonenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string photoPath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(photoPath);
                userPhotoData = File.ReadAllBytes(photoPath);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return; // Exit if inputs are not valid
            }
            string connectionString = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE users SET fullname = @fullname, Phonenumber = @phonenumber, emailaddress = @email, password = @password, photo = @photo WHERE username = @username", connection);

                    command.Parameters.AddWithValue("@fullname", textBoxName.Text);
                    command.Parameters.AddWithValue("@phonenumber", textBoxPhonenumber.Text);
                    command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    command.Parameters.AddWithValue("@username", txtUsername.Text);
                    command.Parameters.AddWithValue("@password", textPassword.Text);

                    // Update user photo if available
                    if (userPhotoData != null)
                    {
                        command.Parameters.AddWithValue("@photo", userPhotoData);
                    }
                    else
                    {
                        // Set photo column to NULL if no photo is provided
                        command.Parameters.AddWithValue("@photo", DBNull.Value);
                    }

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User information updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBoxName.Clear();
                        textBoxPhonenumber.Clear();
                        textBoxEmail.Clear();
                        txtUsername.Clear();
                        textPassword.Clear();
                        pictureBox1.Image = null;


                    }


                    else
                    {
                        MessageBox.Show("No rows were affected. Update operation failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating user information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Update_student_Load(object sender, EventArgs e)
        {

        }
    }
}
