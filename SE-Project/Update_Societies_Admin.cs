using System;
using System.Collections;
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
    public partial class Update_Societies_Admin : Form
    {
        string connstring = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";
        string query;
        int id;
        public Update_Societies_Admin()
        {
            InitializeComponent();
            loadData();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void Update_Societies_Admin_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                query = "SELECT * FROM societies";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();
                query = "UPDATE societies SET name = @name, presidentName = @presidentName, Description = @description WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", txtName.Text);
                command.Parameters.AddWithValue("@presidentName", txtPresidentName.Text);
                command.Parameters.AddWithValue("@description", txtDescription.Text);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connection.Close();
            }

            loadData();

            txtName.Clear();
            txtPresidentName.Clear();
            txtDescription.Clear();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idString = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            if (!string.IsNullOrEmpty(idString) && int.TryParse(idString, out int result))
            {
                id = result;

                string name = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();


                string presidentName = dataGridView1.Rows[e.RowIndex].Cells["presidentName"].Value.ToString();


                string description = dataGridView1.Rows[e.RowIndex].Cells["Description"].Value.ToString();

                // Update the TextBox values
                txtName.Text = name;
                txtPresidentName.Text = presidentName;
                txtDescription.Text = description;
            }
            else
            {
                MessageBox.Show("Invalid ID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                query = "SELECT * FROM societies WHERE name LIKE @name";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@name", txtSearchItem.Text + "%");
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        string username;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_MainScreen mainMenu = new Admin_MainScreen();
            mainMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Update_Societies_Admin_Load_1(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
