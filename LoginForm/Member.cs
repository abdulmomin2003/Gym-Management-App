using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
            }
        }

        private void workoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workout wo = new Workout();
            wo.Show();
        }

        private void dietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diet diet = new Diet();
            diet.Show();
        }

        private void trainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainerInfo ti = new TrainerInfo();
            ti.Show();
        }

        private void sessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sessions sessions = new Sessions();
            sessions.Show();
        }

        private void membershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Membership membership = new Membership();
            membership.Show();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Show a message box to confirm logout
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Hide the current form
                this.Hide();

                // Show the login form
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();

                // Close the current form after login form is closed
                this.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show a message box to confirm exit
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the application
                Application.Exit();
            }
        }
    }
}
