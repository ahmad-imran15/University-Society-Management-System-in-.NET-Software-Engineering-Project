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
    public partial class EventManagementP : Form
    {
        private string loggedInUsername;
        public EventManagementP(string name)
        {
            InitializeComponent();
            loggedInUsername = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_event x = new add_event(loggedInUsername);
            this.Hide();
            x.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            update_events x = new update_events(loggedInUsername);
            this.Hide();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delete_event x = new delete_event(loggedInUsername);
            this.Hide();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            President_MainScreen mainscreen = new President_MainScreen(loggedInUsername);
            mainscreen.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
