using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class ViewMeal : Form
    {
        public ViewMeal()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Your label6 click event handler code here
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            // Your button3 click event handler code here
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Your dataGridView1 cell content click event handler code here
        }

        private void ViewMeal_Load(object sender, EventArgs e)
        {
            LoadMeals(); // Load meals when the form is loaded
        }

        private void LoadMeals()
        {
            int DietID = GlobalVariables.DietID;

            try
            {
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";
                string query = "SELECT * " +
                               "FROM meal " +
                               "INNER JOIN DP_meal ON meal.ID = DP_meal.Meal_ID " +
                               "WHERE DP_meal.Diet_ID = @DietID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DietID", DietID);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
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
