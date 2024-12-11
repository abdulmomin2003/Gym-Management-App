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

namespace LoginForm
{
    public partial class CreateWO : Form
    {
        public CreateWO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                // Show error message if any TextBox is empty
                MessageBox.Show("Required fields are missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // All TextBoxes are filled, show success message
                MessageBox.Show("Workout Plan Creation successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CreateWO_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
