using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Diet : Form
    {
        public Diet()
        {
            InitializeComponent();
            LoadDietPlans();
        }

        private void LoadDietPlans()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";
                string query = "SELECT * FROM dietPlan";


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            LoadDietPlans();
            // Your event handling code here
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyDietPlans myDP = new MyDietPlans();
            myDP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DietModifier dm = new DietModifier();
            dm.Show();
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

        private void Diet_Load(object sender, EventArgs e)
        {

        }
    }
}
