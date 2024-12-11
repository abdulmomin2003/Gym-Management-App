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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox4.Text;
            string cnic = textBox5.Text;
            string username = textBox1.Text;
            string password = textBox2.Text;
            string address = textBox3.Text;
            string requested = comboBox1.Text;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(cnic) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }

            try
            {
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Generate a new UserID
                    int newUserID;
                    string getMaxUserIDQuery = "SELECT MAX(User_ID) FROM Users";
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

                    // Hash the password before storing it in the database
                    string hashedPassword = password;

                    string query = "INSERT INTO Users (User_ID, Name, CNIC, Username, Password, Address, Role, Requested) VALUES (@UserID, @Name, @CNIC, @Username, @Password, @Address, @Role, @Requested)";

                    using (SqlCommand cm = new SqlCommand(query, conn))
                    {
                        cm.Parameters.AddWithValue("@UserID", newUserID);
                        cm.Parameters.AddWithValue("@Name", name);
                        cm.Parameters.AddWithValue("@CNIC", cnic);
                        cm.Parameters.AddWithValue("@Username", username);
                        cm.Parameters.AddWithValue("@Password", hashedPassword);
                        cm.Parameters.AddWithValue("@Address", address);
                        cm.Parameters.AddWithValue("@Role", "Role"); // Change "role" to your desired default role
                        cm.Parameters.AddWithValue("@Requested", requested); // Change "role" to your desired default role

                        cm.ExecuteNonQuery();

                        MessageBox.Show("User registered successfully.");

                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during registration: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
