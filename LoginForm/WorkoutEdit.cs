using LoginForm;
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
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace LoginForm
{
    public partial class WorkoutEdit : Form
    {
        int workoutID; // Declare the workoutID variable

        public WorkoutEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WO_Exercise wO_Exercise = new WO_Exercise();
            wO_Exercise.Show();
        }

        private void WorkoutEdit_Load(object sender, EventArgs e)
        {
            // Initialize workoutID variable with GlobalVariables.WorkoutID
            workoutID = GlobalVariables.WorkoutID;

            // Call the LoadWorkoutInformation method to populate text boxes
            LoadWorkoutInformation(workoutID);
        }

        // Method to populate text boxes with workout information
        private void LoadWorkoutInformation(int workoutID)
        {
            try
            {
                // Connection string
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                // SQL query to select workout information based on WorkoutID
                string query = "SELECT Goals, Experience, Fees, Schedule, Privacy FROM WorkoutPlan WHERE WorkoutID = @WorkoutID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Create a SqlCommand object
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Set parameter value
                        cmd.Parameters.AddWithValue("@WorkoutID", workoutID);

                        // Execute the query
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Check if any rows are returned
                        if (reader.Read())
                        {
                            // Extract values from the reader
                            string goals = reader["Goals"].ToString();
                            string experience = reader["Experience"].ToString();
                            int fee = Convert.ToInt32(reader["Fees"]);
                            string schedule = reader["Schedule"].ToString();
                            string privacy = reader["Privacy"].ToString(); // Read the Privacy field as a string

                            // Check if the Privacy field is "Private", then set isPrivate to true, otherwise false
                            bool isPrivate = (privacy == "Private");

                            // Populate the text boxes and checkbox with retrieved values
                            PopulateWorkoutInfo(goals, experience, fee, schedule, isPrivate);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        // Method to populate text boxes with workout information
        public void PopulateWorkoutInfo(string goals, string experience, int fee, string schedule, bool isPrivate)
        {
            textBox1.Text = goals;
            textBox4.Text = experience;
            textBox3.Text = (fee / 30).ToString();
            textBox2.Text = schedule;

            // Set the checkbox based on the isPrivate parameter
            checkBox1.Checked = isPrivate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Connection string
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL UPDATE statement to update the workout plan data
                    string updateQuery = "UPDATE WorkoutPlan SET Goals = @Goals, Experience = @Experience, Fees = @Fees, " +
                                         "Schedule = @Schedule, Privacy = @Privacy WHERE WorkoutID = @WorkoutID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        // Set parameter values
                        cmd.Parameters.AddWithValue("@Goals", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Experience", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Fees", Convert.ToInt32(textBox3.Text) * 30);
                        cmd.Parameters.AddWithValue("@Schedule", textBox2.Text);

                        // Set the "Privacy" parameter based on the checkbox
                        cmd.Parameters.AddWithValue("@Privacy", checkBox1.Checked ? "Private" : "Public");

                        cmd.Parameters.AddWithValue("@WorkoutID", GlobalVariables.WorkoutID);

                        // Execute the UPDATE command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Workout plan updated successfully.");
                            // Optionally, you can close this form after successful update
                        }
                        else
                        {
                            MessageBox.Show("Failed to update workout plan.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Connection string
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL UPDATE statement to update the workout plan data
                    string updateQuery = "UPDATE WorkoutPlan SET Goals = @Goals, Experience = @Experience, Fees = @Fees, " +
                                         "Schedule = @Schedule, Privacy = @Privacy WHERE WorkoutID = @WorkoutID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        // Set parameter values
                        cmd.Parameters.AddWithValue("@Goals", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Experience", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Fees", Convert.ToInt32(textBox3.Text) * 30);
                        cmd.Parameters.AddWithValue("@Schedule", textBox2.Text);

                        // Set the "Privacy" parameter based on the checkbox
                        cmd.Parameters.AddWithValue("@Privacy", checkBox1.Checked ? "Private" : "Public");

                        cmd.Parameters.AddWithValue("@WorkoutID", GlobalVariables.WorkoutID);

                        // Execute the UPDATE command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Workout plan updated successfully.");
                            // Optionally, you can close this form after successful update
                        }
                        else
                        {
                            MessageBox.Show("Failed to update workout plan.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }

}
