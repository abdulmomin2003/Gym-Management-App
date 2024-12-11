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
    public partial class Reports : Form
    {
        private string selectedReport;

        public Reports()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected report from the combo box
            selectedReport = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if a report is selected
            if (!string.IsNullOrEmpty(selectedReport))
            {
                // Call a method to execute the selected report
                ExecuteReport(selectedReport);
            }
            else
            {
                MessageBox.Show("Please select a report from the dropdown list.");
            }
        }

        private void ExecuteReport(string reportName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();


                    string query;

                    // Execute the selected report query based on the report name
                    switch (reportName)
                    {
                        case "GetMembersForTrainerAndGym":
                            query = "Exec " + reportName + " 4, 1";
                            break;
                        case "GetMembersForGymAndDietPlan":
                            query = "Exec " + reportName + " 1, 2"; break;
                        case "GetMembersForTrainerAndDietPlan":
                            query = "Exec " + reportName + " 4, 2"; break;

                        case "GetMachineUsageCount":
                            query = "Exec " + reportName + " 1, '2024-04-14', 4"; break;

                        case "DietLowCalorieBreakfast":
                            query = "Exec " + reportName + " 500"; break;

                        case "GetDietPlansWithLowCarbohydrateIntake":
                            query = "Exec " + reportName + " 300"; break;

                        case "GetWorkoutPlansWithoutSpecificMachine":
                            query = "Exec " + reportName + " 3"; break;


                        case "GetDietPlansWithoutPeanutsAllergen 'Peanuts'":
                            query = "Exec " + reportName; break;


                        case "GetNewMembershipsLast3Months":
                            query = "Exec " + reportName + " 2"; break;


                        case "CompareTotalMembersInGymsPast6Months ":
                            query = "Exec " + reportName; break;

                        case "NewMembersByMonth":
                            query = "Exec " + reportName; break;

                        case "TopRatedTrainers":
                            query = "Exec " + reportName; break;


                        case "TrainersWithNoFeedback":
                            query = "Exec " + reportName; break;

                        case "GetAppointmentDetails":
                            query = "Exec " + reportName; break;
                        case "GetGymMemberCount":
                            query = "Exec " + reportName; break;
                        case "GetWorkoutPlansForWeightLoss":
                            query = "Exec " + reportName; break;
                        case "GetDietPlansWithMealsOrderedByCalories":
                            query = "Exec " + reportName; break;
                        case "GetDietPlansWithSpecificMealAndNoEggs":
                            query = "Exec " + reportName; break;
                        case "GetGymsWithProfitFromMembershipsGreaterThan1000":
                            query = "Exec " + reportName; break;
                        case "GetGymsWithFeesGreaterThan56":
                            query = "Exec " + reportName; break;

                        //Remaing reports
                        // Add cases for other report queries
                        default:
                            MessageBox.Show("Invalid report selected.");
                            return;
                    }

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

        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
