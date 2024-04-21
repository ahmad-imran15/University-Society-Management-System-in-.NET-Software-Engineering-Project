using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO; // Add this using directive for file operations
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SE_Project
{
    public partial class Add_Members : Form
    {
        private string connstring = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";
        private string loggedInUsername;
        private byte[] userPhotoData;
        private string photoPath;

        public Add_Members(string loggedInUsername)
        {
            InitializeComponent();
            this.loggedInUsername = loggedInUsername;
            PopulateSocietyComboBox();

        }

        private void Add_Members_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtfullname.Text) ||
                string.IsNullOrWhiteSpace(txtphonenumber.Text) ||
                string.IsNullOrWhiteSpace(txtemail.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtBatch.Text) ||
                string.IsNullOrWhiteSpace(txtDiscipline.Text) ||
                string.IsNullOrWhiteSpace(txtExperience.Text) ||
                comboBox1.SelectedItem == null ||
                pictureBox1.Image == null)
            {
                MessageBox.Show("Please fill in all fields and select a picture.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert member details into the database
            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    connection.Open();
                    string query = "INSERT INTO Society_Members (SocietyName, Fullname, Phonenumber, Email, Username, Password, Batch, Discipline, Experience, PictureData) VALUES (@SocietyName, @Fullname, @Phonenumber, @Email, @Username, @Password, @Batch, @Discipline, @Experience, @PictureData)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SocietyName", comboBox1.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Fullname", txtfullname.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", txtphonenumber.Text);
                        command.Parameters.AddWithValue("@Email", txtemail.Text);
                        command.Parameters.AddWithValue("@Username", txtUsername.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);
                        command.Parameters.AddWithValue("@Batch", txtBatch.Text);
                        command.Parameters.AddWithValue("@Discipline", txtDiscipline.Text);
                        command.Parameters.AddWithValue("@Experience", txtExperience.Text);

                        // Convert image to byte array and add as parameter
                        byte[] photoData = null;
                        if (!string.IsNullOrEmpty(photoPath))
                        {
                            using (FileStream fs = new FileStream(photoPath, FileMode.Open, FileAccess.Read))
                            {
                                photoData = new byte[fs.Length];
                                fs.Read(photoData, 0, (int)fs.Length);
                            }
                        }
                        command.Parameters.AddWithValue("@PictureData", photoData);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear input fields
                            txtfullname.Clear();
                            txtemail.Clear();
                            txtphonenumber.Clear();
                            txtUsername.Clear();
                            txtPassword.Clear();
                            txtDiscipline.Clear();
                            txtExperience.Clear();
                            txtBatch.Clear();

                            pictureBox1.Image = null;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add member. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                photoPath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(photoPath);
            }
        }

        private void PopulateSocietyComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    connection.Open();
                    string query = "SELECT name FROM societies WHERE presidentName = @PresidentName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PresidentName", loggedInUsername);
                        SqlDataReader reader = command.ExecuteReader();

                        // Check if any societies are found
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                comboBox1.Items.Add(reader["name"].ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("You are not the president of any societies.", "No Societies", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching society names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            
            President_MainScreen president_MainScreen = new President_MainScreen(loggedInUsername);
            president_MainScreen.Show();
        }
    }
}
