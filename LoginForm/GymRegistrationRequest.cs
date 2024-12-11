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
using Microsoft.VisualBasic.ApplicationServices;

namespace LoginForm
{
    public partial class GymRegistrationRequest : Form
    {
        public GymRegistrationRequest()
        {
            InitializeComponent();
        }

        private void GymRegistrationRequest_Load(object sender, EventArgs e)
        {
            LL();
        }


        private void dataGridViewRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();


                    string query = "select * from users where Role = 'Role' and Requested = 'Owner';";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        // Create a DataTable to hold the query results
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the query results
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }


                        // Bind the DataTable to the DataGridView
                        dataGridViewRequests.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void LL()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();


                    string query = "select * from users where Role = 'Role' and Requested = 'Owner';";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        // Create a DataTable to hold the query results
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the query results
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }


                        // Bind the DataTable to the DataGridView
                        dataGridViewRequests.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
        private void GymRegistrationRequest_Load_1(object sender, EventArgs e)
        {
            LL();
        }
        private void AcceptRequest(int userID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();

                    string query = "EXEC AddGymAndReport  'ISLAMABAD', @UserID;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Refresh the DataGridView after accepting the request
                LL();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while accepting the request: {ex.Message}");
            }
        }

        private void DeclineRequest(int userID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();

                    string query = "UPDATE Users SET Requested = NULL, Role = 'Role' WHERE User_ID = @UserID;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Refresh the DataGridView after declining the request
                LL();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while declining the request: {ex.Message}");
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            // Get the selected row
            DataGridViewRow selectedRow = dataGridViewRequests.SelectedRows[0];
            // Get the User_ID from the selected row
            int userID = Convert.ToInt32(selectedRow.Cells["User_ID"].Value);
            // Accept the request for the selected user
            AcceptRequest(userID);
        }

        private void buttonDeny_Click(object sender, EventArgs e)
        {
            // Get the selected row
            DataGridViewRow selectedRow = dataGridViewRequests.SelectedRows[0];
            // Get the User_ID from the selected row
            int userID = Convert.ToInt32(selectedRow.Cells["User_ID"].Value);
            // Decline the request for the selected user
            DeclineRequest(userID);
        }
    }

}

