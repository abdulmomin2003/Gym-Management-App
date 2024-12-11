using System;
using System.Windows.Forms;
using System.Drawing;

namespace LoginForm
{
    partial class GymReports : Form
    {
        private Label labelTitle;
        private DataGridView dataGridViewReports;

        public GymReports()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GymReports));
            labelTitle = new Label();
            dataGridViewReports = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Coral;
            labelTitle.Location = new Point(-79, 66);
            labelTitle.Margin = new Padding(5, 0, 5, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(878, 47);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Gym Reports";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewReports
            // 
            dataGridViewReports.ColumnHeadersHeight = 29;
            dataGridViewReports.Location = new Point(41, 138);
            dataGridViewReports.Margin = new Padding(5, 4, 5, 4);
            dataGridViewReports.Name = "dataGridViewReports";
            dataGridViewReports.RowHeadersWidth = 51;
            dataGridViewReports.Size = new Size(650, 408);
            dataGridViewReports.TabIndex = 4;
            // 
            // GymReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(734, 656);
            Controls.Add(labelTitle);
            Controls.Add(dataGridViewReports);
            Margin = new Padding(5, 4, 5, 4);
            Name = "GymReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gym Reports";
            Load += GymReports_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).EndInit();
            ResumeLayout(false);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Handle search button click
        }
    }
}
