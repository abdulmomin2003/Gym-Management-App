using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    // Move the GlobalVariables class outside the LoginForm class to make it accessible globally
    public static class GlobalVariables
    {
        // Define a public static property to store the logged-in user's UserID
        public static int LoggedInUserID { get; set; }
        public static int WorkoutID { get; set; }
        public static int DietID { get; set;}

        private const string V = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";
        public const string connectionString = V;
        
        public static int trainerid{  get; set; }

        public static int Equipmentid {  get; set; }

        public static string requested { get; set; }


    }

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter both Username and Password.");
                return;
            }

            try
            {
                
                using (SqlConnection conn = new SqlConnection(GlobalVariables. connectionString))
                {
                    conn.Open();

                    string un = textBox1.Text;
                    string pass = textBox2.Text;

                    string query = "SELECT Role FROM users WHERE Username = @Username AND Password = @Password";
                    string query1 = "SELECT User_ID FROM users WHERE Username = @Username AND Password = @Password";
                    string query2 = "SELECT Requested FROM users WHERE Username = @Username AND Password = @Password";
                    string requested;
                    using (SqlCommand cm1 = new SqlCommand(query2, conn))
                    {
                        cm1.Parameters.AddWithValue("@Username", un);
                        cm1.Parameters.AddWithValue("@Password", pass);
                        object result1 = cm1.ExecuteScalar();
                        
                        // Ensure result1 is not null before assigning

                        requested = result1?.ToString(); // Safely convert to string


                    }
                    using (SqlCommand cm = new SqlCommand(query, conn))
                    {
                        cm.Parameters.AddWithValue("@Username", un);
                        cm.Parameters.AddWithValue("@Password", pass);

                        object result = cm.ExecuteScalar();

                        string role = result?.ToString(); // Safely convert to string

                        if (result != null && role != "Role")
                        {
                            // Set the LoggedInUserID property in the GlobalVariables class
                            using (SqlCommand cm1 = new SqlCommand(query1, conn))
                            {
                                cm1.Parameters.AddWithValue("@Username", un);
                                cm1.Parameters.AddWithValue("@Password", pass);
                                object result1 = cm1.ExecuteScalar();

                                // Ensure result1 is not null before assigning
                                if (result1 != null)
                                {
                                    GlobalVariables.LoggedInUserID = Convert.ToInt32(result1);
                                }
                            }

                            MessageBox.Show($"Login successful! User role: {role}");

                            // Proceed with actions based on the user's role
                            if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                            {
                                Admin adminForm = new Admin();
                                adminForm.Show();
                            }
                            else if (role.Equals("Trainer", StringComparison.OrdinalIgnoreCase))
                            {
                                Trainer adminForm = new Trainer();
                                adminForm.Show();
                            }
                            else if (role.Equals("Member", StringComparison.OrdinalIgnoreCase))
                            {
                                Member adminForm = new Member();
                                adminForm.Show();
                            }
                            else if (role.Equals("Owner", StringComparison.OrdinalIgnoreCase))
                            {
                                Owner adminForm = new Owner();
                                adminForm.Show();
                            }
                            this.Hide();  // Hide the current form
                        }
                        else if (role.Equals("Role", StringComparison.OrdinalIgnoreCase))
                        {
                        if (requested == "" || requested==null)
                        {
                            MessageBox.Show("Invalid Username or Password.");
                            return;
                        }
                            using (SqlCommand cm1 = new SqlCommand(query1, conn))
                            {
                                cm1.Parameters.AddWithValue("@Username", un);
                                cm1.Parameters.AddWithValue("@Password", pass);
                                object result1 = cm1.ExecuteScalar();

                                // Ensure result1 is not null before assigning
                               
                                if (result1 != null)
                                {
                                    GlobalVariables.LoggedInUserID = Convert.ToInt32(result1);
                                }
                            }
                            
                            if ((requested.Equals("Member1", StringComparison.OrdinalIgnoreCase) || requested.Equals("Trainer1", StringComparison.OrdinalIgnoreCase)))
                            {
                                GlobalVariables.requested = requested;

                                GymChange gymChange = new GymChange();
                                gymChange.Show();
                                this.Hide();
                            }


                        }
                        else 
                        {
                            MessageBox.Show("Invalid Username or Password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Username or Password.");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Initialize form or perform any required actions on form load
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Perform any actions when label is clicked
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Perform any actions when text in textBox2 changes
            textBox2.UseSystemPasswordChar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Exit the application when button3 is clicked
            Application.Exit();
        }


    }
    
}
