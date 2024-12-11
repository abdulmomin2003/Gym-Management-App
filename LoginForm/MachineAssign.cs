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
    public partial class MachineAssign : Form
    {
        public MachineAssign()
        {
            InitializeComponent();
        }

        private void dataGridViewReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void load()

        {

            try
            {
                // SQL query to fetch member reports data


                // Execute the query and fill the DataGridView
                DataTable dataTable = new DataTable();

                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();

                    // Query to retrieve personal training sessions for the logged-in user
                    string query = "select * from excercise;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter for MemberID (using the logged-in user's ID)
                        //cmd.Parameters.AddWithValue("@OwnerID", GlobalVariables.LoggedInUserID);

                        // Create a DataTable to hold the query results
                        DataTable dt = new DataTable();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }

                        // Bind the DataTable to the DataGridView
                        dataGridViewReports.DataSource = dataTable;
                    }
                }

                // Bind the DataTable to the DataGridView
                dataGridViewReports.DataSource = dataTable;
                dataGridViewReports.AutoResizeColumns();
                dataGridViewReports.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void MachineAssign_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridViewReports.SelectedRows.Count > 0)
            {
                int ExerciseID = Convert.ToInt32(dataGridViewReports.SelectedRows[0].Cells["Excerciseid"].Value);
                try
                {
                    // Connection string
                    string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                    // SQL command to delete the appointment
                    string query = "insert into ExerciseMachine VALUES (@ExerciseID,@MachineID)";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Add parameters
                            cmd.Parameters.AddWithValue("@ExerciseID", ExerciseID);
                            cmd.Parameters.AddWithValue("@MachineID", GlobalVariables.Equipmentid);

                            // Execute the command
                            int rowsAffected = cmd.ExecuteNonQuery();

                            // Check if the appointment was successfully canceled
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Machine added successfully to Exercise", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refresh the DataGridView to reflect the changes
                            }
                            else
                            {
                                MessageBox.Show("Failed to adde Machine successfully to Exercise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Select an exercise");

            }
        }
    }
}
