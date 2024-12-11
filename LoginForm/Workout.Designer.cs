namespace LoginForm;

partial class Workout
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workout));
        label1 = new Label();
        label2 = new Label();
        dataGridView1 = new DataGridView();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.BackColor = Color.Transparent;
        label1.Dock = DockStyle.Top;
        label1.Font = new Font("Century Schoolbook", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = Color.FromArgb(255, 128, 0);
        label1.Location = new Point(0, 0);
        label1.Name = "label1";
        label1.Size = new Size(640, 113);
        label1.TabIndex = 0;
        label1.Text = "Workout";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(119, 207);
        label2.Name = "label2";
        label2.Size = new Size(0, 20);
        label2.TabIndex = 1;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(11, 129);
        dataGridView1.Margin = new Padding(3, 4, 3, 4);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.RowTemplate.Height = 24;
        dataGridView1.Size = new Size(609, 358);
        dataGridView1.TabIndex = 4;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // button1
        // 
        button1.Location = new Point(518, 525);
        button1.Margin = new Padding(3, 4, 3, 4);
        button1.Name = "button1";
        button1.Size = new Size(75, 29);
        button1.TabIndex = 5;
        button1.Text = "create ";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(341, 525);
        button2.Margin = new Padding(3, 4, 3, 4);
        button2.Name = "button2";
        button2.Size = new Size(134, 29);
        button2.TabIndex = 6;
        button2.Text = "My Workouts";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(518, 52);
        button3.Margin = new Padding(3, 4, 3, 4);
        button3.Name = "button3";
        button3.Size = new Size(75, 29);
        button3.TabIndex = 7;
        button3.Text = "Refresh";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // Workout
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(640, 605);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(dataGridView1);
        Controls.Add(label2);
        Controls.Add(label1);
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Workout";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Workout";
        Load += Workout_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private Button button3;
}