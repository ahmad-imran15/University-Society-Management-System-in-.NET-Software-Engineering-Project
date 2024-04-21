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
    
    public partial class View_Announcements : Form
    {
        string loggedInUsername;
        private string connectionString = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";

        public View_Announcements()
        {
            InitializeComponent();
        }

        public View_Announcements(string name)
        {
            InitializeComponent();
            name = loggedInUsername;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Announcements_Load_1(object sender, EventArgs e)
        {
            // Load the announcements into the DataGridView when the form is loaded
            LoadAnnouncements();
        }

        private void LoadAnnouncements()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Description, AnnouncementDate, PresidentName, SocietyName FROM Announcements ORDER BY AnnouncementDate DESC", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns["Description"].Width = 200;
                    dataGridView1.Columns["AnnouncementDate"].Width = 200;
                    dataGridView1.Columns["PresidentName"].Width = 200;
                    dataGridView1.Columns["SocietyName"].Width = 200;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_MainScreen s = new Student_MainScreen();
            s.Show();
            
        }
    }
}
