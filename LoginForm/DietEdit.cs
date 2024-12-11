using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
    {
    public partial class DietEdit : Form
    {

        public DietEdit()
        {
            InitializeComponent();
        }

        private void DietEdit_Load(object sender, EventArgs e)
        {
            // Load the diet plan details into the textboxes
            LoadDietDetails();
        }

        private void LoadDietDetails()
        {
            try
            {
                // Connection string
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL SELECT statement to retrieve diet plan details
                    string selectQuery = "SELECT Goal, Requirements, Description FROM DietPlan WHERE ID = @DietID";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@DietID", GlobalVariables.DietID);

                        // Execute the SELECT command
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Check if there are rows returned
                            if (reader.Read())
                            {
                                // Set the textbox values with the retrieved diet plan details
                                textBox3.Text = reader["Goal"].ToString();
                                textBox4.Text = reader["Requirements"].ToString();
                                textBox2.Text = reader["Description"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Diet plan not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Connection string
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL UPDATE statement to update the diet plan data
                    string updateQuery = "UPDATE DietPlan SET Goal = @Goals, Requirements = @Requirements, Description = @Description " +
                                         "WHERE ID = @DietID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        // Set parameter values
                        cmd.Parameters.AddWithValue("@Goals", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Requirements", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Description", textBox2.Text);
                        cmd.Parameters.AddWithValue("@DietID", GlobalVariables.DietID);

                        // Execute the UPDATE command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Diet plan updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Diet plan.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DietMeal dietMeal = new DietMeal();
            dietMeal.Show();
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

                    // SQL UPDATE statement to update the diet plan data
                    string updateQuery = "UPDATE DietPlan SET Goal = @Goals, Requirements = @Requirements, Description = @Description " +
                                         "WHERE ID = @DietID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        // Set parameter values
                        cmd.Parameters.AddWithValue("@Goals", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Requirements", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Description", textBox2.Text);
                        cmd.Parameters.AddWithValue("@DietID", GlobalVariables.DietID);

                        // Execute the UPDATE command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Diet plan updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Diet plan.");
                        }
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



