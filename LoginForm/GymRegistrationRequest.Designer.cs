using System;
using System.Windows.Forms;
using System.Drawing;

namespace LoginForm
{
    partial class GymRegistrationRequest : Form
    {
        private Label labelTitle;
        private DataGridView dataGridViewRequests;
        private Button buttonAccept;
        private Button buttonDeny;


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GymRegistrationRequest));
            labelTitle = new Label();
            dataGridViewRequests = new DataGridView();
            buttonAccept = new Button();
            buttonDeny = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.DarkOrange;
            labelTitle.Location = new Point(-41, 35);
            labelTitle.Margin = new Padding(5, 0, 5, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(878, 47);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Gym Registration Requests";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.ColumnHeadersHeight = 29;
            dataGridViewRequests.Location = new Point(42, 109);
            dataGridViewRequests.Margin = new Padding(5, 4, 5, 4);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.RowHeadersWidth = 51;
            dataGridViewRequests.Size = new Size(653, 399);
            dataGridViewRequests.TabIndex = 1;
            dataGridViewRequests.CellContentClick += dataGridViewRequests_CellContentClick;
            // 
            // buttonAccept
            // 
            buttonAccept.Location = new Point(164, 533);
            buttonAccept.Margin = new Padding(5, 4, 5, 4);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(134, 47);
            buttonAccept.TabIndex = 2;
            buttonAccept.Text = "Accept";
            buttonAccept.Click += buttonAccept_Click;
            // 
            // buttonDeny
            // 
            buttonDeny.Location = new Point(419, 533);
            buttonDeny.Margin = new Padding(5, 4, 5, 4);
            buttonDeny.Name = "buttonDeny";
            buttonDeny.Size = new Size(134, 47);
            buttonDeny.TabIndex = 4;
            buttonDeny.Text = "Deny";
            buttonDeny.Click += buttonDeny_Click;
            // 
            // GymRegistrationRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(734, 656);
            Controls.Add(labelTitle);
            Controls.Add(dataGridViewRequests);
            Controls.Add(buttonAccept);
            Controls.Add(buttonDeny);
            Margin = new Padding(5, 4, 5, 4);
            Name = "GymRegistrationRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gym Registration Requests";
            Load += GymRegistrationRequest_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
            ResumeLayout(false);
        }

        
    }
}
