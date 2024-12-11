using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class DietMeal : Form
    {
        public DietMeal()
        {
            InitializeComponent();
        }

        private void DietMeal_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {

            try
            {
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to retrieve personal training sessions for the logged-in user
                    string query = "select * from MEAL";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter for MemberID (using the logged-in user's ID)
                        // Create a DataTable to hold the query results
                        DataTable dt = new DataTable();

                        // Fill the DataTable with the query results
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                        // Display the query results in the DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching personal training sessions: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the AppointmentID from the selected row
                int mealID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to add this meal?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Connection string
                        string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                        // SQL command to delete the appointment
                        string query = "insert into DP_MEAL values(@Dietid,@mealid)";

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                // Add parameters
                                cmd.Parameters.AddWithValue("@Dietid", GlobalVariables.DietID) ;
                                cmd.Parameters.AddWithValue("@mealid", mealID);

                                // Execute the command
                                int rowsAffected = cmd.ExecuteNonQuery();

                                // Check if the appointment was successfully canceled
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Meal added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Refresh the DataGridView to reflect the changes
                                    load();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to add meal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a meal to add.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
