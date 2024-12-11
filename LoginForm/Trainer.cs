using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Trainer : Form
    {
        public Trainer()
        {
            InitializeComponent();
        }

        private void aPPOINTMENTSCHEDULINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sCHEDULEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedule sc = new Schedule();
            sc.Show();
        }

        private void rESCHEDULEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reschedule sc = new Reschedule();
            sc.Show();
        }

        private void cANCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancel sc = new Cancel();
            sc.Show();
        }

        private void wORKOUTPLANSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workout wo = new Workout();
            wo.Show();
        }

        private void cREATEWORKOUTPLANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateWO sc = new CreateWO();
            sc.Show();
        }

        private void vIEWWORKOUTPLANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewWO sc = new viewWO();
            sc.Show();
        }

        private void vIEWCLIENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchClients sc = new searchClients();
            sc.Show();
        }

        private void cREATEDIETPLANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createDP sc = new createDP();
            sc.Show();
        }

        private void vIEWDIETPLANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewDP sc = new viewDP();
            sc.Show();
        }

        private void eDITDIETPLANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyDP sc = new modifyDP();
            sc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vIEWPASTREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pastReports sc = new pastReports();
            sc.Show();
        }

        private void eDITWORKOUTPLANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkoutEdit sc = new WorkoutEdit();
            sc.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void dIETPLANSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DietPlan2 dietPlan2 = new DietPlan2();
            dietPlan2.Show();
        }
    }
}



