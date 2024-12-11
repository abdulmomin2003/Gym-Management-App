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
    public partial class DietPlan2 : Form
    {
        public DietPlan2()
        {
            InitializeComponent();
        }

        private void DietPlan2_Load(object sender, EventArgs e)
        {
            load();

        }
        private void load()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to retrieve personal training sessions for the logged-in user
                    string query = "select * from DietPlan where Created_by = @LoggedInUserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter for MemberID (using the logged-in user's ID)
                        cmd.Parameters.AddWithValue("@LoggedInUserID", GlobalVariables.LoggedInUserID);

                        // Create a DataTable to hold the query results
                        DataTable dt = new DataTable();

                        // Fill the DataTable with the query results
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                        // Display the query results in the DataGridView
                        dataGridView1.DataSource = dt;
                    }
                    string query1 = "select * from DietPlan where Created_by = @LoggedInUserID";

                    using (SqlCommand cmd = new SqlCommand(query1, conn))
                    {
                        // Add parameter for MemberID (using the logged-in user's ID)
                        cmd.Parameters.AddWithValue("@LoggedInUserID", GlobalVariables.LoggedInUserID);

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                GlobalVariables.DietID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                ViewMeal meal = new ViewMeal();
                meal.Show();
            }
            else
            {
                MessageBox.Show("Please select a diet to view", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalVariables.DietID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            DietEdit dietEdit = new DietEdit();
            dietEdit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DietCreate dietCreate = new DietCreate();
            dietCreate.Show();
        }
    }
}
