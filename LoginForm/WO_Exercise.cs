using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class WO_Exercise : Form
    {
        public WO_Exercise()
        {
            InitializeComponent();
            SetWorkoutID();

        }
        private int currentWorkoutID;

        // Setter for setting the current workout ID
        public void SetWorkoutID()
        {
            currentWorkoutID = GlobalVariables.WorkoutID;
        }
        private void WO_Exercise_Load(object sender, EventArgs e)
        {
            try
            {
                // Connection string
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                // SQL query to select all exercises
                string query = "SELECT * FROM Excercise";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Create a SqlCommand object
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Create a DataTable to hold the query results
                        DataTable dt = new DataTable();

                        // Fill the DataTable with the results of the query
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected exercise
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int exerciseID = Convert.ToInt32(selectedRow.Cells["ExcerciseID"].Value);

                // Connection string
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the exercise is already associated with the current workout
                    string checkQuery = "SELECT COUNT(*) FROM WOExercise WHERE Workout_ID = @WorkoutID AND EXERCISE_ID = @ExerciseID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@WorkoutID", currentWorkoutID);
                        checkCmd.Parameters.AddWithValue("@ExerciseID", exerciseID);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count == 0)
                        {
                            // If the exercise is not associated, insert it into the WO_Exercise table
                            string insertQuery = "INSERT INTO WOExercise (Workout_ID, EXERCISE_ID) VALUES (@WorkoutID, @ExerciseID)";
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@WorkoutID", currentWorkoutID);
                                insertCmd.Parameters.AddWithValue("@ExerciseID", exerciseID);

                                int rowsAffected = insertCmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Exercise added to workout successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to add exercise to workout.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Exercise already exists in the workout.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
