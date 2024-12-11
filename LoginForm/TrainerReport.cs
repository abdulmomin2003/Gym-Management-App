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
    public partial class TrainerReport : Form
    {
        public TrainerReport()
        {
            InitializeComponent();
        }

        

        private void TrainerReport_Load_1(object sender, EventArgs e)
        {
            LoadTrainerReports();
        }

        private void dataGridViewTrainers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void LoadTrainerReports()
        {
            try
            {
                // SQL query to fetch trainer reports data
                string query = "EXEC TrainerReports @ownerID";

                // Execute the query and fill the DataGridView
                DataTable dataTable = new DataTable();

                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            try
            {
                

                // SQL query to fetch trainer reports data
                string query = "EXEC TrainerReportsWithName @ownerID , @TrainerName";

                // Execute the query and fill the DataGridView
                DataTable dataTable = new DataTable();

                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ownerID", GlobalVariables.LoggedInUserID);
                        cmd.Parameters.AddWithValue("@TrainerName", searchText);
                        // Create a DataTable to hold the query results
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }

                // Bind the DataTable to the DataGridView
                dataGridViewTrainers.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // Reload trainer reports
            LoadTrainerReports();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
