using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class DeleteSociety : Form
    {
        string connstring = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=SE_Project;Integrated Security=True";
        string query;
        int id;
        public DeleteSociety()
        {

            InitializeComponent();
            RefreshData();
        }
        string username;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_MainScreen login = new Admin_MainScreen();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idLocRemv;

            //checking the data fgrid view 

            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null &&
                int.TryParse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), out idLocRemv))
            {
                try
                {
                    //establsihing the connections
                    using (SqlConnection connection = new SqlConnection(connstring))
                    {
                        connection.Open();

                        //here using the sql command 
                        using (SqlCommand command = new SqlCommand("DELETE FROM societies WHERE id = @id", connection))
                        {
                            command.Parameters.Add("@id", SqlDbType.Int).Value = idLocRemv;
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Row with ID " + idLocRemv + " got removed.", "Removed Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData();
                }
                //here seeing the excaption 
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing row: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid row.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //after delet it will refrsh the datagrid view table

        private void RefreshData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM societies", connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Check if datagridview has data
                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DeleteSociety_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                query = @"SELECT id, name AS Name, presidentName AS President_Name, 
                        Department, batch, date, Description 
                 FROM societies 
                 WHERE id LIKE @searchText OR 
                       name LIKE @searchText OR 
                       presidentName LIKE @searchText OR 
                       Department LIKE @searchText OR 
                       batch LIKE @searchText OR 
                       date LIKE @searchText OR 
                       Description LIKE @searchText";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" + txtSearchItem.Text + "%");
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                // Set AutoSizeMode to Fill for each column
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void DeleteSociety_Load_1(object sender, EventArgs e)
        {

        }
    }
}
