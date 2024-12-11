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
    public partial class MyWorkouts : Form
    {
        public MyWorkouts()
        {
            InitializeComponent();
        }

        private void MyWorkouts_Load(object sender, EventArgs e)
        {
            try
            {
                // Connection string
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                // SQL command to fetch user's own workout plans
                string ownQuery = "SELECT * FROM WorkoutPlan WHERE Created_By = @UserID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Execute the query to fetch user's own workout plans
                    using (SqlCommand cmd = new SqlCommand(ownQuery, conn))
                    {
                        // Add parameter for UserID
                        cmd.Parameters.AddWithValue("@UserID", GlobalVariables.LoggedInUserID);

                        // Create a DataTable to hold the query results
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


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if(dataGridView1.SelectedRows.Count>0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                GlobalVariables.WorkoutID = Convert.ToInt32(selectedRow.Cells["WorkoutID"].Value);
                WorkoutEdit editwo = new WorkoutEdit();
                editwo.Show();
            }
            else
            {
                MessageBox.Show("Please select a workout to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Connection string
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                // SQL command to fetch user's own workout plans
                string ownQuery = "SELECT * FROM WorkoutPlan WHERE Created_By = @UserID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Execute the query to fetch user's own workout plans
                    using (SqlCommand cmd = new SqlCommand(ownQuery, conn))
                    {
                        // Add parameter for UserID
                        cmd.Parameters.AddWithValue("@UserID", GlobalVariables.LoggedInUserID);

                        // Create a DataTable to hold the query results
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
