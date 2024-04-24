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
    public partial class Student_MainScreen : Form
    {
        private string loggedInUsername;
        private byte[] userPhotoData; // Store the user's photo as byte array


        public Student_MainScreen(string loggedInUsername)
        {
            InitializeComponent();
            this.loggedInUsername = loggedInUsername;

            UpdateFullNameLabel();
            LoadUserPhoto();
        }

        public Student_MainScreen()
        {
            InitializeComponent();
        }

        private void LoadUserPhoto()
        {
            // Query the database to fetch the user's photo data based on the logged-in username
            DB db = new DB();
            SqlConnection conn = db.getConnection();
            try
            {
                db.openConnection();

                SqlCommand command = new SqlCommand("SELECT photo FROM users WHERE username = @username", conn);
                command.Parameters.AddWithValue("@username", loggedInUsername);

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    // Store the fetched photo data
                    userPhotoData = (byte[])result;

                    // will load the image from the stored data and display it in pictureBox1
                    using (var ms = new System.IO.MemoryStream(userPhotoData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        // Stretch the image to fit the PictureBox for great view
                    }
                }
                else
                {
                    // else case where photo data is not found
                    pictureBox1.Image = null; // Clear the PictureBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user photo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void UpdateFullNameLabel()
        {
            // Query the database to fetch the full name based on the logged in username
            DB db = new DB();
            SqlConnection conn = db.getConnection();
            try
            {
                db.openConnection();

                SqlCommand command = new SqlCommand("SELECT fullname FROM users WHERE username = @username", conn);
                command.Parameters.AddWithValue("@username", loggedInUsername);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    //it willl update the label2 with the fetched full name
                    label2.Text = "Welcome, " + result.ToString();
                }
                else
                {
                    // else case where full name is not found
                    label2.Text = "Welcome, [Full Name Not Found]";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching full name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterSociety registerSociety = new RegisterSociety();
            registerSociety.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            ViewSocieties viewSocieties = new ViewSocieties();
            viewSocieties.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteSociety deleteSociety = new DeleteSociety();
            deleteSociety.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Societies_Admin update = new Update_Societies_Admin();
            update.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Society_president var = new Update_Society_president(loggedInUsername);
            var.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Update_student update_Student = new Update_student(loggedInUsername);
            update_Student.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FeedBack feedBack = new FeedBack(loggedInUsername);
            feedBack.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            ViewMember_Student viewMember_Student = new ViewMember_Student();
            viewMember_Student.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            View_Events_by_Students viewevents = new View_Events_by_Students(loggedInUsername);
            viewevents.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            View_Announcements viewAnnouncements = new View_Announcements(loggedInUsername);
            viewAnnouncements.Show();
            this.Hide();
        }
    }
}