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
    public partial class TrainerChange : Form
    {
        public TrainerChange()
        {
            InitializeComponent();
        }

        private void dataGridViewTrainers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
        private void LoadTrainerChangeRequests()
        {
            try
            {
                // SQL query to fetch trainer change requests data
                string query = "EXEC GetTrainerChangeRequests @OwnerID";

                // Execute the query and fill the DataGridView
                DataTable dataTable = new DataTable();

                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter for GymID (assuming you have a way to retrieve the current gym's ID)
                        cmd.Parameters.AddWithValue("@OwnerID", GlobalVariables.LoggedInUserID);

                        // Create a DataTable to hold the query results
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }

                // Bind the DataTable to the DataGridView
                dataGridViewTrainers.DataSource = dataTable;
                dataGridViewTrainers.AutoResizeColumns(); //(Add in all data grid views)
                dataGridViewTrainers.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // Reload trainer change requests
            LoadTrainerChangeRequests();
        }

        private void TrainerChange_Load(object sender, EventArgs e)
        {
            LoadTrainerChangeRequests();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewTrainers.SelectedRows.Count > 0)
            {
                // Get the AppointmentID from the selected row
                int memberID = Convert.ToInt32(dataGridViewTrainers.SelectedRows[0].Cells["Member"].Value);

                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to reject this request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {

                        // SQL command to delete the appointment
                        string query = "EXEC DeclineTrainerChangeRequest @MemberID";

                        using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                        {
                            conn.Open();

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                // Add parameters
                                cmd.Parameters.AddWithValue("@MemberID", memberID);

                                // Execute the command
                                int rowsAffected = cmd.ExecuteNonQuery();

                                LoadTrainerChangeRequests();
                                // Check if the appointment was successfully canceled
                                
                                    // Refresh the DataGridView to reflect the changes
                                    
                                
                                
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
                MessageBox.Show("Please select an request to reject.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewTrainers.SelectedRows.Count > 0)
            {
                // Get the AppointmentID from the selected row
                int memberID = Convert.ToInt32(dataGridViewTrainers.SelectedRows[0].Cells["Member"].Value);
                int TrainerID = Convert.ToInt32(dataGridViewTrainers.SelectedRows[0].Cells["RequestedTrainerId"].Value);
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to approve this request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {

                        // SQL command to delete the appointment
                        string query = "EXEC AcceptTrainerChangeRequest @MemberID ,@TrainerID;";

                        using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                        {
                            conn.Open();

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                // Add parameters
                                cmd.Parameters.AddWithValue("@MemberID", memberID);
                                cmd.Parameters.AddWithValue("@TrainerID", TrainerID);

                                // Execute the command
                                int rowsAffected = cmd.ExecuteNonQuery();

                                LoadTrainerChangeRequests();
                                // Check if the appointment was successfully canceled

                                // Refresh the DataGridView to reflect the changes



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
                MessageBox.Show("Please select an request to approve.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
