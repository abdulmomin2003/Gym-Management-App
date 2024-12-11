namespace LoginForm
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Hide the current form
                this.Hide();

                // Show the login form
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();

                // Close the current form after login form is closedGymRegistrationRequest
                this.Close();
            }
        }

        private void gymRegistrationRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GymRegistrationRequest hr = new GymRegistrationRequest();
            hr.Show();
        }

        private void gymReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GymReports gymReports = new GymReports();
            gymReports.Show();
        }

        private void gymMembershipManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GymMembership gymMembership = new GymMembership();
            gymMembership.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the application
                Application.Exit();
            }

        }

        private void reprtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reprts = new Reports();
            reprts.Show();
        }
    }
}