using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class TrainerFeedback : Form
    {
        public TrainerFeedback()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please write some description.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Get the rating from the RatingControl
                int rating = Convert.ToInt32(ratingControl1.Value);
                // Get the description from the TextBox
                string description = textBox1.Text;
                SaveFeedbackToDatabase(rating, description);
                this.Close();
            }

        }

        private int GetFeedbackID(int memberID)
        {
            int trainerID = -1;

            // Write SQL query to retrieve the trainerID associated with the memberID
            string query = "SELECT MAX(Feedback_id) FROM TrainerFeedback";

            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            trainerID = Convert.ToInt32(result) + 1;
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

        private void SaveFeedbackToDatabase(int rating, string description)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GlobalVariables.connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO TrainerFeedback (Rating, Feedback, trainer_id, Member_id, feedback_id) VALUES (@Rating, @Description, @Trainerid, @memberid, @Feedback_id)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Rating", rating);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@trainerid", GlobalVariables.trainerid);
                        command.Parameters.AddWithValue("@Feedback_id", GetFeedbackID(GlobalVariables.LoggedInUserID));
                        command.Parameters.AddWithValue("@memberid", GlobalVariables.LoggedInUserID);
                        command.ExecuteNonQuery();
                    }
                    string query2 ="EXEC UpdateTrainerRatings";
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Feedback saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void ratingControl1_Click(object sender, EventArgs e)
        {

        }

        private void TrainerFeedback_Load(object sender, EventArgs e)
        {
            ratingControl1.Value = 5;

        }
    }
}
