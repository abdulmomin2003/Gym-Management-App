using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class RequestTrainer : Form
    {
        private string connectionString = "YourConnectionString"; // Update with your connection string
        private int currentUserId; // Store the ID of the current logged-in user here

        public RequestTrainer()
        {
            InitializeComponent();
        }

        private void LoadTrainersData()
        {
            // Retrieve the logged-in user's ID
            int loggedInUserID = GlobalVariables.LoggedInUserID;

            try
            {
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to retrieve personal training sessions for the logged-in user
                    string query = "EXEC GetTrainersExceptUser @memberID;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter for MemberID (using the logged-in user's ID)
                        cmd.Parameters.AddWithValue("@memberid", GlobalVariables.LoggedInUserID);

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

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = searchBox.Text.Trim();

                // SQL query to search for trainers based on the search term
                string query = "SELECT u.user_ID,u.CNIC,u.name,t.GYMID,t.Rating FROM Trainer as t join users as u on t.user_id = u.user_id WHERE u.Name LIKE '%" + searchTerm + "%';";

                // Execute the query and fill the DataGridView
                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dataTable);
                }

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the ID of the selected trainer

            // Perform the request
        }
        private int GetRequestID(int memberID)
        {
            int trainerID = 1;

            // Write SQL query to retrieve the trainerID associated with the memberID
            string query = "SELECT MAX(RequestID) FROM TrainerChangeRequest";

            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            trainerID = Convert.ToInt32(result) + 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An s error occurred: {ex.Message}");
            }

            return trainerID;
        }

        private void RequestTrainerfunc(int trainerId)
        {
            try
            {
                // SQL query to insert a new record in the trainerRequest table
                string query = "INSERT INTO trainerChangeRequest (MemberID, TrainerID, RequestID, Status) VALUES (@MemberID, @TrainerID, @RequestID, @Status);";

                using (SqlConnection conn = new SqlConnection(GlobalVariables. connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Set the parameters
                        cmd.Parameters.AddWithValue("@MemberID", GlobalVariables.LoggedInUserID);
                        cmd.Parameters.AddWithValue("@TrainerID", trainerId);
                        cmd.Parameters.AddWithValue("@Status", "Pending");
                        cmd.Parameters.AddWithValue("@RequestID", GetRequestID(GlobalVariables.LoggedInUserID));

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Request sent successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to send request.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            // Perform any additional actions when the search box text changes
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Handle button click event if needed
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedTrainerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["User_ID"].Value);
                RequestTrainerfunc(selectedTrainerId);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an Trainer to request.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RequestTrainer_Load(object sender, EventArgs e)
        {
            LoadTrainersData();
        }
    }
}
