using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class Admin_MainScreen : Form
    {
        public Admin_MainScreen()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            RegisterSociety registerSociety = new RegisterSociety();
            registerSociety.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Societies_Admin update_Societies_Admin = new Update_Societies_Admin();
            update_Societies_Admin.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ViewSocieties viewSocieties = new ViewSocieties();
            viewSocieties.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteSociety deleteSociety = new DeleteSociety();
            deleteSociety.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            President_SignUp president_SignUp = new President_SignUp();
            president_SignUp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Users update_Users = new Update_Users();
            update_Users.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewfeedBack viewfeedBack = new ViewfeedBack();
            viewfeedBack.Show();
        }

        private void Admin_MainScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
