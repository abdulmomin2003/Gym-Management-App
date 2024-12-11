using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class NewSession : Form
    {
        public NewSession()
        {
            InitializeComponent();
            LoadTrainers(); // Call the method to load trainers when the form is initialized
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
        }

        private void NewSession_Load(object sender, EventArgs e)
        {
            // Optional: Any additional initialization code can go here
           // PopulateTrainers();
        }

        private void LoadTrainers()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT trainer.user_ID, users.Name FROM trainer JOIN users ON users.user_id = trainer.User_ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Clear existing items from the ComboBox
                        comboBox1.Items.Clear();

                        // Loop through the data and add items to the ComboBox
                        while (reader.Read())
                        {
                            // Construct the display text for each item (ID + Name)
                            string trainerInfo = $"{reader["User_ID"]} - {reader["Name"]}";

                            // Add the item to the ComboBox
                            comboBox1.Items.Add(trainerInfo);
                        }

                        // Select the first item by default (if ComboBox is not empty)
                        if (comboBox1.Items.Count > 0)
                        {
                            comboBox1.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading trainers: {ex.Message}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected in the ComboBox
            if (comboBox1.SelectedItem != null)
            {
                // Get the selected item from the ComboBox
                string selectedTrainer = comboBox1.SelectedItem.ToString();

                // Split the selected item to extract TrainerID
                string[] parts = selectedTrainer.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                // Ensure that TrainerID is extracted successfully
                if (parts.Length == 2 && int.TryParse(parts[0].Trim(), out int trainerID))
                {
                    // Now you have the TrainerID, you can use it as needed
                    MessageBox.Show($"Selected TrainerID: {trainerID}");
                }
                else
                {
                    MessageBox.Show("Invalid selection. Please select a valid trainer.");
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public class TrainerItem
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Get the duration from the textBox1 control
            if (!int.TryParse(textBox1.Text, out int duration))
            {
                MessageBox.Show("Please enter a valid duration.");
                return;
            }

            // Get the trainer ID from the comboBox1 control
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a trainer.");
                return;
            }

            // Extract TrainerID from the selected item in comboBox1
            string selectedTrainer = comboBox1.SelectedItem.ToString();
            string[] parts = selectedTrainer.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 2 || !int.TryParse(parts[0].Trim(), out int trainerID))
            {
                MessageBox.Show("Invalid selection. Please select a valid trainer.");
                return;
            }

            // Get the start time from the dateTimePicker1 control
            DateTime startTime = dateTimePicker1.Value;

            // Calculate the end time based on start time and duration
            DateTime endTime = startTime.AddMinutes(duration);

            // Insert the session into the database
            try
            {
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    int newUserID;

                    string getMaxUserIDQuery = "SELECT MAX(AppointmentID) FROM AppointmentWithClients";
                    using (SqlCommand getMaxUserIDCmd = new SqlCommand(getMaxUserIDQuery, conn))
                    {
                        object result = getMaxUserIDCmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            newUserID = Convert.ToInt32(result) + 1;
                        }
                        else
                        {
                            newUserID = 1; // Set to 1 if no existing users
                        }
                    }
                    string query = "INSERT INTO AppointmentWithClients (AppointmentID,Trainer_ID,Member_id, Active_Time, fee) " +
                                       "VALUES (@AppointmentID, @TrainerID, @MemberID, @StartTime, @fee)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", newUserID);
                        cmd.Parameters.AddWithValue("@StartTime", startTime);
                        cmd.Parameters.AddWithValue("@TrainerID", trainerID);
                        cmd.Parameters.AddWithValue("@MemberID", GlobalVariables.LoggedInUserID);
                        cmd.Parameters.AddWithValue("@fee", duration * 10);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Session booked successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to book session.");
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
