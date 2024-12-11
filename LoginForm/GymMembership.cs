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
using System.Collections;
namespace LoginForm
{
    public partial class GymMembership : Form
    {
        /*
        public GymMembership()
        {
            InitializeComponent();
        }
        */
        int GYMID;

        private void GymMembership_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            load();

        }
        private void load()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();


                    string query = "select * from gym where  activity='Active';";



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
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void GymMembership_Load_1(object sender, EventArgs e)
        {
            load();
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the ID of the selected gym
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                GYMID = Convert.ToInt32(row.Cells["ID"].Value);
            }
        }
        private void buttonRevokeMembership_Click(object sender, EventArgs e)
        {
            GYMID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

            try
            {

                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();
                    // Execute the stored procedure 'deletegym' with the selected GYMID
                    string query = "EXEC deletegym @gymID;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@gymID", GYMID);
                        cmd.ExecuteNonQuery();
                    }
// Reload data after revoking membership
                        load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}