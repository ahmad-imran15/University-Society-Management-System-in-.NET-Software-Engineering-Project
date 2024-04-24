using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class View_Events_by_Students : Form
    {
        string loggedInUsername;
        private string connectionString = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";

        public View_Events_by_Students(string loggedInUsername)
        {
            InitializeComponent();
            this.loggedInUsername = loggedInUsername;
        }


        private void View_Events_by_Students_Load(object sender, EventArgs e)
        {
            // Load events into DataGridView
            DisplayEvents();
        }

        private void DisplayEvents()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT event_name, starting_date, ending_date, descriptions FROM eventss", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Student_MainScreen mainscrreen1 = new Student_MainScreen(loggedInUsername);
            mainscrreen1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
