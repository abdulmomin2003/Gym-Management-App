using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class TrainerInfo : Form
    {
        public TrainerInfo()
        {
            InitializeComponent();
        }

        private void TrainerInfo_Load(object sender, EventArgs e)
        {
            // Retrieve trainer information associated with the logged-in member
            int loggedInMemberID = GlobalVariables.LoggedInUserID; // Assuming you have a variable storing the logged-in member's ID
            int trainerID = GetTrainerIDForMember(loggedInMemberID); // Get the trainer's ID associated with the logged-in member

            if (trainerID != -1)
            {
                // Fetch trainer information based on trainerID
                string trainerInfoQuery = "SELECT * FROM Trainer join users on trainer.user_id = users.user_id WHERE trainer.User_ID = @TrainerID";

                try
                {
                    using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(trainerInfoQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@TrainerID", trainerID);

                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                                // Populate form fields with trainer's information
                                textBox2.Text = reader["User_ID"].ToString();
                                textBox3.Text = reader["Name"].ToString();
                                textBox2.ReadOnly = true;
                                textBox3.ReadOnly = true;
                                // You can continue populating other fields as needed
                                int rating = Convert.ToInt32(reader["Rating"]);
                                // Update progress bar value based on rating
                                int progressBarValue = (int)(((double)rating / 5) * progressBar1.Maximum);
                                progressBar1.Value = progressBarValue;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Trainer information not found for the logged-in member.");
            }
        }

        private int GetTrainerIDForMember(int memberID)
        {
            int trainerID = -1;

            // Write SQL query to retrieve the trainerID associated with the memberID
            string query = "SELECT TrainerID FROM Member WHERE UserID = @MemberID";

            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            trainerID = Convert.ToInt32(result);
                            GlobalVariables.trainerid = trainerID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return trainerID;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrainerFeedback trainerFeedback = new TrainerFeedback();
            trainerFeedback.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RequestTrainer requestTrainer = new RequestTrainer();   
            requestTrainer.Show();
        }
    }
}
