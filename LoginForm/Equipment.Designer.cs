using System;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using System.Data.SqlClient;
using LoginForm.Properties;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Microsoft.IdentityModel.Tokens;
namespace LoginForm
{
    public partial class Equipment : Form
    {
        private System.ComponentModel.IContainer equipmentComponents = null;
        private Label labelName;
        private TextBox textBoxName;
        private Button buttonAdd;
        private Button buttonAssign;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (equipmentComponents != null))
            {
                equipmentComponents.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelName = new Label();
            textBoxName = new TextBox();
            buttonAdd = new Button();
            buttonAssign = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.DarkGray;
            labelName.Location = new Point(219, 263);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(361, 260);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(171, 27);
            textBoxName.TabIndex = 3;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(219, 503);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(86, 31);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Add";
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonAssign
            // 
            buttonAssign.Location = new Point(434, 503);
            buttonAssign.Margin = new Padding(3, 4, 3, 4);
            buttonAssign.Name = "buttonAssign";
            buttonAssign.Size = new Size(86, 31);
            buttonAssign.TabIndex = 11;
            buttonAssign.Text = "Assign";
            buttonAssign.Click += buttonAssign_Click;
            // 
            // Equipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.GYM_APP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 656);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(buttonAdd);
            Controls.Add(buttonAssign);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Equipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipment";
            Load += Equipment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.IsNullOrEmpty())
            {
                MessageBox.Show($"Please enter a name of the machine.", "Warning");
                return;
            }
            try
            {
                // Establish a connection to your SQL Server database
                using (SqlConnection conn = new SqlConnection(GlobalVariables.connectionString))
                {
                    conn.Open();

                    // Retrieve the machine name from the textbox
                    string machineName = textBoxName.Text;

                    // Prepare the SQL query to insert a new record
                    string query = "INSERT INTO machine(machine_id, machine_name, lastused) VALUES((SELECT ISNULL(MAX(machine_id), 0) + 1 FROM machine), @machinename, GETDATE())";
                    string query1 = "SELECT ISNULL(MAX(machine_id), 0) FROM machine";

                    // Create a SqlCommand object with the SQL query and connection
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter for machine name
                        cmd.Parameters.AddWithValue("@machinename", machineName);

                        // Execute the first query to add the machine
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the query executed successfully
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Machine added successfully.");

                            // Execute the second query to retrieve the last inserted machine ID
                            using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                            {
                                object result = cmd1.ExecuteScalar();

                                // Check if the query executed successfully
                                if (result != null)
                                {
                                    GlobalVariables.Equipmentid = Convert.ToInt32(result);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to add machine.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Add your logic for handling the edit button click event here
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Add your logic for handling the delete button click event here
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            MachineAssign machineAssign = new MachineAssign();
            machineAssign.Show();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
                // Add your logic for initializing the form here
        }
    }
}
