using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class NewMemberRequest : Form
    {
        public NewMemberRequest()
        {
            InitializeComponent();
        }

        private void NewMemberRequest_Load(object sender, EventArgs e)
        {
            // Call method to load requests data
            LoadRequestsData();
        }

        private void LoadRequestsData()
        {
            try
            {
                // Database connection string
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                // SQL query to fetch user requests data
                string query = "SELECT User_ID, Name, CNIC, Address,  Role, Requested  FROM Users where role = 'role' and requested is not null and requested !='Owner'; ";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Execute the query
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Create a DataTable to hold the results
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the data from the query
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

        private void NewMemberRequest_Load_1(object sender, EventArgs e)
        {
            LoadRequestsData();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            // Get the selected user's information
            DataGridViewRow selectedRow = dataGridViewRequests.SelectedRows[0];
            int userID = Convert.ToInt32(selectedRow.Cells["User_ID"].Value);
            string requestedRole = selectedRow.Cells["requested"].Value.ToString();

            try
            {
                // Database connection string
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    int gymID = 1;
                    conn.Open();

                    // Update user's role and set "Requested" column to null
                    string updateQuery = "UPDATE Users SET Role = @Role, Requested = NULL WHERE User_ID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Role", requestedRole);
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.ExecuteNonQuery();
                    }
                    string query = "SELECT ID FROM Gym WHERE OwnerID = @LoggedInUser";
                    object result1;
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LoggedInUser", GlobalVariables.LoggedInUserID);

                        // Execute the query
                        result1 = cmd.ExecuteScalar();

                        if (result1 != null)
                        {
                            // Successfully retrieved gymID
                            gymID = Convert.ToInt32(result1);
                            MessageBox.Show($"GymID: {gymID}");
                        }
                        else
                        {
                            // No gymID found for the logged-in user
                            MessageBox.Show("No gymID found for the logged-in user.");
                        }
                    }
                    // Insert into the specific table based on role
                    string insertQuery = "";
                    switch (requestedRole)
                    {
                        case "Member":
                            insertQuery = "INSERT INTO Member (UserID, Membership_Fee, GymID) VALUES (@UserID, @mfee, @GymID)";
                            break;
                        case "Trainer":
                            insertQuery = "INSERT INTO Trainer (User_ID, Rating, Monthly_Salary, GymID, hours_worked, start_date) VALUES ( @UserID, @Rating, @Monthly_Salary, @GymID, @hours_worked, @start_date)";
                            break;
                        default:
                            MessageBox.Show("Invalid role.");
                            return;
                    }

                    // Execute the insert query
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@mfee", 0);
                        cmd.Parameters.AddWithValue("@GymID", gymID);
                        cmd.Parameters.AddWithValue("@Rating", 5);
                        cmd.Parameters.AddWithValue("@Monthly_Salary", 3000);
                        cmd.Parameters.AddWithValue("@hours_worked", 0);
                        cmd.Parameters.AddWithValue("@start_date", DateTime.Now.ToString());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("User entry accepted and added to the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void buttonDecline_Click(object sender, EventArgs e)
        {
            // Get the selected user's information
            DataGridViewRow selectedRow = dataGridViewRequests.SelectedRows[0];
            int userID = Convert.ToInt32(selectedRow.Cells["User_ID"].Value);

            try
            {
                // Database connection string
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Update the user's request to null
                    string updateQuery = "UPDATE Users SET Requested = NULL WHERE User_ID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("User entry declined.");
                    // Refresh the DataGridView to reflect the changes
                    LoadRequestsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}

    
