using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class President_MainScreen : Form
    {
        private string loggedInUsername;
        private byte[] userPhotoData;

        public President_MainScreen(string loggedInUsername)
        {
            InitializeComponent();
            this.loggedInUsername = loggedInUsername;

            // Fetch the full name of the logged-in user and display it in label2
            UpdateFullNameLabel();
            LoadUserPhoto();
        }
        private void LoadUserPhoto()
        {
            // Query the database to fetch the user's photo data based on the logged-in username
            DB db = new DB();
            SqlConnection conn = db.getConnection();
            try
            {
                db.openConnection();

                //checking the username with the photo username for the photo fetch
                SqlCommand command = new SqlCommand("SELECT photo FROM users WHERE username = @username", conn);
                command.Parameters.AddWithValue("@username", loggedInUsername);

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    // Store the fetched photo data
                    userPhotoData = (byte[])result;

                    // Load the image from the stored data and display it in pictureBox1
                    using (var ms = new System.IO.MemoryStream(userPhotoData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        // Stretch the image to fit the PictureBox so for more clear
                    }
                }
                else
                {
                    // Handle the case where photo data is not found
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
            // Query the database to fetch the full name based on the logged-in username
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
                    //it will Update the label2 with the fetched full name
                    label2.Text = "Welcome, " + result.ToString();
                }
                else
                {
                    //else case where full name is not found
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

            RegisterSociety registerSociety = new RegisterSociety(loggedInUsername);
            registerSociety.Show();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void President_MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            President_update president_Update = new President_update(loggedInUsername);
            president_Update.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Members add_Members = new Add_Members(loggedInUsername);
            add_Members.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Members view_Members = new View_Members(loggedInUsername);
            view_Members.Show();
        }

        //manage event button;
        private void button8_Click(object sender, EventArgs e)
        {
            EventManagementP x = new EventManagementP(loggedInUsername);
            this.Hide();
            x.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Add_Announcement announcement = new Add_Announcement(loggedInUsername);
            announcement.Show();
            this.Hide();
        }
    }
}
