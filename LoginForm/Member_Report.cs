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
    public partial class Member_Report : Form
    {
        public Member_Report()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Member_Report_Load(object sender, EventArgs e)
        {
            LoadMemberReports();
        }

        private void LoadMemberReports()
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
                    string query = "EXEC GetMemberReports @OwnerID;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter for MemberID (using the logged-in user's ID)
                        cmd.Parameters.AddWithValue("@OwnerID",GlobalVariables.LoggedInUserID);

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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                //if (string.IsNullOrEmpty(searchText))
                //{
                //    MessageBox.Show("Please enter a search term.");
                //    return;
                //}

                // SQL query to search for member reports based on the entered text
                string query = "Exec GetMemberReportsFromName @OwnerID , @MemberName";

                // Execute the query with the search parameter
                DataTable dataTable = new DataTable();

                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter for the search text
                        cmd.Parameters.AddWithValue("@OwnerID", GlobalVariables.LoggedInUserID);
                        cmd.Parameters.AddWithValue("@MemberName", searchText);

                        // Create a DataTable to hold the query results
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void BtnReset_Click(object sender, EventArgs e)
        {
            LoadMemberReports();
        }
    }
}
