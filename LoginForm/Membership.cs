using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    partial class Membership : Form
    {
        public Membership()
        {
            InitializeComponent();
        }

        private void Membership_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-U9S8MFO\\SQLEXPRESS02;Initial Catalog=GYMDATABASE;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT Name, CNIC, User_ID AS ID, Address, member.Membership_Fee FROM users JOIN member ON users.User_ID = member.UserID WHERE users.User_ID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", GlobalVariables.LoggedInUserID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate text boxes with user information
                                textBox1.Text = reader["Name"].ToString();
                                textBox4.Text = reader["CNIC"].ToString();
                                textBox3.Text = reader["ID"].ToString();
                                textBox2.Text = reader["Address"].ToString();
                                textBox5.Text = reader["Membership_Fee"].ToString();

                                // Disable text boxes to make them non-editable
                                textBox1.ReadOnly = true;
                                textBox2.ReadOnly = true; 
                                textBox3.ReadOnly = true;
                                textBox4.ReadOnly = true;
                                textBox5.ReadOnly = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching user information: {ex.Message}");
            }
        }
    }
}
