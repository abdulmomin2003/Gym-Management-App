using System;
using System.Windows.Forms;
using System.Drawing;

namespace LoginForm;

partial class GymMembership : Form
{
    private Label labelTitle;
    private Button buttonRevokeMembership;

    public GymMembership()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GymMembership));
        labelTitle = new Label();
        buttonRevokeMembership = new Button();
        dataGridView1 = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.BackColor = Color.Transparent;
        labelTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
        labelTitle.ForeColor = Color.Coral;
        labelTitle.Location = new Point(-42, 24);
        labelTitle.Margin = new Padding(5, 0, 5, 0);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(878, 47);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Gym Membership";
        labelTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // buttonRevokeMembership
        // 
        buttonRevokeMembership.Location = new Point(255, 582);
        buttonRevokeMembership.Margin = new Padding(5, 4, 5, 4);
        buttonRevokeMembership.Name = "buttonRevokeMembership";
        buttonRevokeMembership.Size = new Size(266, 61);
        buttonRevokeMembership.TabIndex = 2;
        buttonRevokeMembership.Text = "Revoke Membership";
        buttonRevokeMembership.Click += buttonRevokeMembership_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(119, 371);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(513, 188);
        dataGridView1.TabIndex = 3;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // GymMembership
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(734, 656);
        Controls.Add(dataGridView1);
        Controls.Add(labelTitle);
        Controls.Add(buttonRevokeMembership);
        Margin = new Padding(5, 4, 5, 4);
        Name = "GymMembership";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gym Membership";
        Load += GymMembership_Load_1;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    
    private DataGridView dataGridView1;
}
