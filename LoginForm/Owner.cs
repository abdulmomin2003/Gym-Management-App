namespace LoginForm
{
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Report member = new Member_Report();
            member.Show();
        }

        private void staffReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hireNewStaffTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HireTrainer ht = new HireTrainer();
            ht.Show();
        }

        private void trainerClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainerClientView trainerClientView = new TrainerClientView();
            trainerClientView.Show();
        }

        private void trainerReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainerReport tr = new TrainerReport();
            tr.Show();
        }

        private void newMemberRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMemberRequest nmr = new NewMemberRequest();
            nmr.Show();
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

                // Close the current form after login form is closed
                this.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void equiptmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipmentGrid hr = new EquipmentGrid();
            hr.Show();
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

        private void trainerChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainerChange t = new TrainerChange();
            t.Show();
        }
    }
}