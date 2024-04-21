using System.Data.SqlClient;
using System.Data;

namespace SE_Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            // Adding the items to the ComboBox
            comboBox1.Items.AddRange(new object[] { "Admin", "President", "Student" });

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp main = new SignUp();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string category = comboBox1.SelectedItem?.ToString().ToLower().Trim();
            // Get the selected item from ComboBox

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Please fill in all fields.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DB db = new DB();
            SqlConnection conn = db.getConnection();

            if (conn != null)
            {
                try
                {
                    db.openConnection(); // Open the connection

                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand command = new SqlCommand("SELECT * FROM users WHERE username = @usn", conn);
                    command.Parameters.Add("@usn", SqlDbType.VarChar).Value = username;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        string actualPassword = table.Rows[0]["password"].ToString();
                        string actualCategory = table.Rows[0]["category"].ToString();
                        //iit will get the category from database

                        if (category == actualCategory)
                        // Check if selected category matches the category in the database
                        {
                            // Check password
                            if (password == actualPassword)
                            {
                                // Successful login
                                switch (category)
                                {
                                    //cases for the category
                                    case "admin":
                                        MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Hide();
                                        Admin_MainScreen admin_MainScreen = new Admin_MainScreen();
                                        admin_MainScreen.Show();
                                        break;
                                    case "president":
                                        MessageBox.Show("President login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Hide();
                                        President_MainScreen mainMenu = new President_MainScreen(username); // Pass the logged-in username to MainMenu
                                        mainMenu.Show();
                                        break;
                                    case "student":
                                        MessageBox.Show("Student login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Hide();
                                        Student_MainScreen registerSociety = new Student_MainScreen(username);
                                        registerSociety.Show();
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Category", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.closeConnection(); // Close the connection, whether an exception occurred or not
                }
            }
            else
            {
                Console.WriteLine("Connection is null. Check your DB class and getConnection method.");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
