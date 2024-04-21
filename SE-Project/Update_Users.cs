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
using System.Xml.Linq;

namespace SE_Project
{
    public partial class Update_Users : Form
    {
        string connstring = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";
        string query;
        int id;
        public Update_Users()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                query = "SELECT id, category, fullname,Phonenumber ,emailaddress ,username ,password FROM users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idString = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            if (!string.IsNullOrEmpty(idString) && int.TryParse(idString, out int result))
            {
                id = result;

                string fullname = dataGridView1.Rows[e.RowIndex].Cells["fullname"].Value.ToString();


                string Phonenumber = dataGridView1.Rows[e.RowIndex].Cells["Phonenumber"].Value.ToString();


                string emailaddress = dataGridView1.Rows[e.RowIndex].Cells["emailaddress"].Value.ToString();

                string password = dataGridView1.Rows[e.RowIndex].Cells["password"].Value.ToString();



                // Update the TextBox values
                txtfullName.Text = fullname;
                txtPhonenumber.Text = Phonenumber;
                txtEmail.Text = emailaddress;
                txtPassword.Text = password;
            }
            else
            {
                MessageBox.Show("Invalid ID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();
                query = "UPDATE users SET fullname = @fullname, Phonenumber = @Phonenumber, emailaddress = @emailaddress, password= @password WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@fullname", txtfullName.Text);
                command.Parameters.AddWithValue("@Phonenumber", txtPhonenumber.Text);
                command.Parameters.AddWithValue("@emailaddress", txtEmail.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connection.Close();
            }
            loadData();

            txtfullName.Clear();
            txtPhonenumber.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                query = "SELECT id, category, fullname,Phonenumber ,emailaddress ,username ,password FROM users WHERE fullname LIKE @fullname";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@fullname", txtSearchItem.Text + "%");
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_MainScreen admin_MainScreen = new Admin_MainScreen();
            admin_MainScreen.Show();
        }

        private void Update_Users_Load(object sender, EventArgs e)
        {

        }
    }
}
