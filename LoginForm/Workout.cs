using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Workout : Form
    {
        public Workout()
        {
            InitializeComponent();
            LoadWorkoutPlans();
        }
        private void LoadWorkoutPlans()
        {
            try
            {
                // Connection string
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                // SQL command to fetch public workout plans
                string publicQuery = "SELECT * FROM WorkoutPlan WHERE Privacy = 'Public'";



                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Combine the two queries into one command

                    using (SqlCommand cmd = new SqlCommand(publicQuery, conn))
                    {
                        // Add parameter for UserID
                        cmd.Parameters.AddWithValue("@UserID", GlobalVariables.LoggedInUserID);

                        DataTable dt = new DataTable();

                        // Fill the DataTable with the query results
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                        // Display the DataTable in the DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading workout plans: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkoutCreate createwo = new WorkoutCreate();
            createwo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyWorkouts mywo = new MyWorkouts();
            mywo.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Workout_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Connection string
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                // SQL command to fetch public workout plans
                string publicQuery = "SELECT * FROM WorkoutPlan WHERE Privacy = 'Public'";

               

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Combine the two queries into one command
                    
                    using (SqlCommand cmd = new SqlCommand(publicQuery, conn))
                    {
                        // Add parameter for UserID
                        cmd.Parameters.AddWithValue("@UserID", GlobalVariables.LoggedInUserID);

                        DataTable dt = new DataTable();

                        // Fill the DataTable with the query results
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                        // Display the DataTable in the DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading workout plans: {ex.Message}");
            }
        }
    }
}
