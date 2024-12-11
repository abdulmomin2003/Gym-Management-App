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
    public partial class WorkoutCreate : Form
    {
        public WorkoutCreate()
        {
            InitializeComponent();
        }
        public Boolean created = false;
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (created == false)
            {
                MessageBox.Show("First Create this workout Plan.");
            }
            else
            {
                WO_Exercise wO_Exercise = new WO_Exercise();
                wO_Exercise.Show();
            }
        }

        private void WorkoutCreate_Load(object sender, EventArgs e)
        {

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

                    // SQL INSERT statement to insert the workout plan data
                    string insertQuery = "INSERT INTO WorkoutPlan (Goals, Experience, Fees , Schedule, Privacy, Created_By, WorkoutID) " +
                                         "VALUES (@Goals, @Experience, @Fees, @Schedule, @Privacy, @CreatedBy, @WorkoutID )";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        // Generate a new UserID

                        string getMaxUserIDQuery = "SELECT MAX(WorkoutID) FROM WorkoutPlan";    
                        using (SqlCommand getMaxUserIDCmd = new SqlCommand(getMaxUserIDQuery, conn))
                        {
                            object result = getMaxUserIDCmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                GlobalVariables.WorkoutID = Convert.ToInt32(result) + 1;
                            }
                            else
                            {
                                MessageBox.Show("WorkoutPlanID is wrong");

                                GlobalVariables.WorkoutID = 1; // Set to 1 if no existing users
                            }
                        }
                        // Set parameter values
                        cmd.Parameters.AddWithValue("@Goals", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Experience", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Fees", Convert.ToInt32(textBox3.Text) * 30);
                        cmd.Parameters.AddWithValue("@Schedule", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Privacy", checkBox1.Checked ? "Private" : "Public");
                        cmd.Parameters.AddWithValue("@CreatedBy", GlobalVariables.LoggedInUserID);
                        cmd.Parameters.AddWithValue("@WorkoutID", Convert.ToInt32(GlobalVariables.WorkoutID))   ;

                        // Execute the INSERT command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Workout plan created successfully.");
                            created = true;
                            // Optionally, you can close this form after successful creation
                        }
                        else
                        {
                            MessageBox.Show("Failed to create workout plan.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
