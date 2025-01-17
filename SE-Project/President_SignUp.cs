﻿using System;
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
    public partial class President_SignUp : Form
    {
        private string photoPath;
        public President_SignUp()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_user(string fullname, string username, string password, string email, int phonenumber)
        {




        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [users] ([fullname], [Phonenumber], [emailaddress], [username], [password], [category], [photo]) VALUES (@fn, @ln, @email, @usn, @pass, @category, @photo)", connection);

                command.Parameters.AddWithValue("@fn", textBoxName.Text);
                command.Parameters.AddWithValue("@ln", textBoxPhonenumber.Text);
                command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                command.Parameters.AddWithValue("@usn", txtUsername.Text);
                command.Parameters.AddWithValue("@pass", textPassword.Text);
                command.Parameters.AddWithValue("@category", "president");
                //here i am Seting category to "president"

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
                command.Parameters.AddWithValue("@photo", photoData);

                try
                {
                    connection.Open();

                    if (!checkTextBoxesValues())
                    {
                        if (checkUsername())
                        {
                            MessageBox.Show("This Username already exists, select another username", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (command.ExecuteNonQuery() == 1)
                            {
                                this.Hide();
                                login main = new login();
                                main.Show();
                                MessageBox.Show("Your Account has been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error occurred while creating the account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //all done 
        public Boolean checkUsername()
        {

            DB db = new DB();

            String username = txtUsername.Text;


            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM users WHERE username = @usn", db.getConnection());

            command.Parameters.Add("@usn", SqlDbType.VarChar).Value = username;



            adapter.SelectCommand = command;

            adapter.Fill(table);

            //check if this username already exists int the database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        public Boolean checkTextBoxesValues()
        {
            String fname = textBoxName.Text;
            String phonenumber = textBoxPhonenumber.Text;
            String email = textBoxEmail.Text;
            String uname = txtUsername.Text;
            String pass = textPassword.Text;

            if (fname.Equals("Enter Name") || phonenumber.Equals("Enter Phone Number") || email.Equals("Enter Email")
                || uname.Equals("Enter Username") || pass.Equals("Enter Password"))
            {
                MessageBox.Show("Please fill in all fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (!Regex.IsMatch(fname, @"^[A-Z][a-zA-Z]*((\s|-)[A-Z][a-zA-Z]*)*$"))
            {
                MessageBox.Show("Invalid full name format. Please enter the full name with the first letter of each name capitalized and without any special characters.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            // Check phone number format
            if (!Regex.IsMatch(phonenumber, @"^03\d{9}$"))
            {
                MessageBox.Show("Phone number must start with '03' and be 11 digits long including '03'.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            // Check email format
            if (!Regex.IsMatch(email, @"^[a-z][a-zA-Z0-9._%+-]*@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            // Check username format
            if (uname.Contains(" "))
            {
                MessageBox.Show("Username cannot contain spaces.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (!Regex.IsMatch(uname, @"^[a-z]"))
            {
                MessageBox.Show("Username must start with a lowercase letter.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            // Check password length
            if (pass.Length < 8 || pass.Length > 15)
            {
                MessageBox.Show("Password must be between 8 and 15 characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }


            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Admin_MainScreen admin_MainScreen = new Admin_MainScreen();
            admin_MainScreen.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
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

        private void President_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
