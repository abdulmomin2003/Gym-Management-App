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
    public partial class GymReports : Form
    {
        //public GymReports()
        //{
        //    InitializeComponent();
        //}

        private void GymReports_Load(object sender, EventArgs e)
        {
            ll();
        }

        private void GymReports_Load_1(object sender, EventArgs e)
        {
            ll();
        }
        private void ll()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();


                    string query = "select GymReports.* , OwnerID,gym.Location,ActiveMembers,Trainers,Profit from GymReports join gym on GymReports.GYM_ID=gym.ID where gym.Activity='Active';";



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
                        dataGridViewReports.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
