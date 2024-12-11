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
    public partial class EquipmentGrid : Form
    {
        public EquipmentGrid()
        {
            InitializeComponent();
        }

        private void dataGridViewReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equipment hr = new Equipment();
            hr.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EquipmentGrid_Load(object sender, EventArgs e)
        {
            load();
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
                    string query = "select * from machine;";
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
    }
}
