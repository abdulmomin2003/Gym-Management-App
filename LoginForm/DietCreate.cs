using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class DietCreate : Form
    {
        public DietCreate()
        {
            InitializeComponent();
        }

        public Boolean created = false;
        private void DietCreate_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Connection string
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL INSERT statement to insert the workout plan data
                    string insertQuery = "INSERT INTO DietPlan (Goal, Requirements, Description ,ID, Created_by) " +
                                         "VALUES (@Goals, @Requirements, @Description, @ID, @TrainerID)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        // Generate a new DietID
                        string getMaxDietIDQuery = "SELECT ISNULL(MAX(ID), 0) FROM DietPlan";
                        using (SqlCommand getMaxDietIDCmd = new SqlCommand(getMaxDietIDQuery, conn))
                        {
                            int maxDietID = Convert.ToInt32(  getMaxDietIDCmd.ExecuteScalar());
                            GlobalVariables.DietID = maxDietID + 1;
                        }

                        // Set parameter values
                        cmd.Parameters.AddWithValue("@Goals", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Requirements", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Description", textBox2.Text);
                        cmd.Parameters.AddWithValue("@TrainerID", GlobalVariables.LoggedInUserID);
                        cmd.Parameters.AddWithValue("@ID", GlobalVariables.DietID);

                        // Execute the INSERT command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Diet plan created successfully.");
                            created = true;
                            // Optionally, you can close this form after successful creation
                        }
                        else
                        {
                            MessageBox.Show("Failed to create Diet plan.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (created == false)
            {
                MessageBox.Show("First Create this Diet Plan.");
            }
            else
            {
                DietMeal dietMeal = new DietMeal();
                dietMeal.Show();
            }
        }
    }
}
