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
    public partial class GymChange : Form
    {
        public GymChange()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }
        private int selectedGymID;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedGymID = Convert.ToInt32(row.Cells["ID"].Value);
            }
        }


        private void LoadGyms()
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
                    string query = "select * from gym where activity = 'Active'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        
                        // Create a DataTable to hold the query results
                        DataTable dt = new DataTable();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoResizeColumns();
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void GymChange_Load(object sender, EventArgs e)
        {
            LoadGyms();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();

                    string query;
                    if (GlobalVariables.requested.Equals("Member1", StringComparison.OrdinalIgnoreCase))
                    {
                        // Query to retrieve personal training sessions for the logged-in user
                        query = "exec deletemember @userID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@userID", GlobalVariables.LoggedInUserID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show($"Membership revoked");
                        }
                    }
                    else
                    {
                        query = "exec deleteTrainer @userID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@userID", GlobalVariables.LoggedInUserID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show($"TrainerShip revoked");
                        }

                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            this.Close();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the AppointmentID from the selected row
                int selectedGymID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to join this request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (GlobalVariables.requested.Equals("Member1", StringComparison.OrdinalIgnoreCase))
                        {
                            // SQL command to delete the appointment
                            string query = "exec UpdateMemberGym @memberID,@GymID";

                            using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                            {
                                conn.Open();

                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    // Add parameters
                                    cmd.Parameters.AddWithValue("@MemberID", GlobalVariables.LoggedInUserID);
                                    cmd.Parameters.AddWithValue("@GymID", selectedGymID);

                                    // Execute the command
                                    int rowsAffected = cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        else
                        {
                            string query = "exec UpdateTrainergym @memberID,@GymID";

                            using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                            {
                                conn.Open();

                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    // Add parameters
                                    cmd.Parameters.AddWithValue("@MemberID", GlobalVariables.LoggedInUserID);
                                    cmd.Parameters.AddWithValue("@GymID", selectedGymID);

                                    // Execute the command
                                    int rowsAffected = cmd.ExecuteNonQuery();
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
                MessageBox.Show("Please select an request to reject.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
