using LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class MyDietPlans : Form
    {
        public MyDietPlans()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DietModifier deitm = new DietModifier();
            deitm.Show();
        }
    }
}
