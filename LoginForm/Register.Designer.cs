namespace LoginForm;

partial class Register
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
        textBox2 = new TextBox();
        textBox1 = new TextBox();
        button1 = new Button();
        dateTimePicker2 = new DateTimePicker();
        dateTimePicker1 = new DateTimePicker();
        label6 = new Label();
        label2 = new Label();
        label1 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        textBox3 = new TextBox();
        textBox4 = new TextBox();
        comboBox1 = new ComboBox();
        textBox5 = new TextBox();
        label7 = new Label();
        dateTimePicker3 = new DateTimePicker();
        button2 = new Button();
        SuspendLayout();
        // 
        // textBox2
        // 
        textBox2.Location = new Point(251, 178);
        textBox2.Margin = new Padding(3, 4, 3, 4);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(100, 27);
        textBox2.TabIndex = 58;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(251, 117);
        textBox1.Margin = new Padding(3, 4, 3, 4);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 27);
        textBox1.TabIndex = 57;
        // 
        // button1
        // 
        button1.Location = new Point(251, 480);
        button1.Margin = new Padding(3, 4, 3, 4);
        button1.Name = "button1";
        button1.Size = new Size(75, 29);
        button1.TabIndex = 56;
        button1.Text = "Register";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // dateTimePicker2
        // 
        dateTimePicker2.Location = new Point(189, 329);
        dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
        dateTimePicker2.Name = "dateTimePicker2";
        dateTimePicker2.Size = new Size(0, 27);
        dateTimePicker2.TabIndex = 55;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new Point(206, 243);
        dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(0, 27);
        dateTimePicker1.TabIndex = 54;
        // 
        // label6
        // 
        label6.BackColor = Color.Transparent;
        label6.Dock = DockStyle.Top;
        label6.Font = new Font("Century Schoolbook", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label6.ForeColor = Color.FromArgb(255, 128, 0);
        label6.Location = new Point(0, 0);
        label6.Name = "label6";
        label6.Size = new Size(622, 113);
        label6.TabIndex = 53;
        label6.Text = "Register";
        label6.TextAlign = ContentAlignment.MiddleCenter;
        label6.Click += label6_Click;
        // 
        // label2
        // 
        label2.BorderStyle = BorderStyle.Fixed3D;
        label2.Font = new Font("Arial Narrow", 12F);
        label2.Location = new Point(83, 165);
        label2.Name = "label2";
        label2.Size = new Size(101, 51);
        label2.TabIndex = 52;
        label2.Text = "Password";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.BorderStyle = BorderStyle.Fixed3D;
        label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(83, 104);
        label1.Name = "label1";
        label1.Size = new Size(101, 51);
        label1.TabIndex = 51;
        label1.Text = "Username";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.BorderStyle = BorderStyle.Fixed3D;
        label3.Font = new Font("Arial Narrow", 12F);
        label3.Location = new Point(83, 407);
        label3.Name = "label3";
        label3.Size = new Size(101, 51);
        label3.TabIndex = 60;
        label3.Text = "Role";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.BorderStyle = BorderStyle.Fixed3D;
        label4.Font = new Font("Arial Narrow", 12F);
        label4.Location = new Point(82, 331);
        label4.Name = "label4";
        label4.Size = new Size(101, 51);
        label4.TabIndex = 61;
        label4.Text = "Address";
        label4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label5
        // 
        label5.BorderStyle = BorderStyle.Fixed3D;
        label5.Font = new Font("Arial Narrow", 12F);
        label5.Location = new Point(83, 219);
        label5.Name = "label5";
        label5.Size = new Size(101, 51);
        label5.TabIndex = 62;
        label5.Text = "Name";
        label5.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(251, 344);
        textBox3.Margin = new Padding(3, 4, 3, 4);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(100, 27);
        textBox3.TabIndex = 63;
        // 
        // textBox4
        // 
        textBox4.Location = new Point(251, 232);
        textBox4.Margin = new Padding(3, 4, 3, 4);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(100, 27);
        textBox4.TabIndex = 64;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Trainer", "Member", "Owner" });
        comboBox1.Location = new Point(251, 420);
        comboBox1.Margin = new Padding(3, 4, 3, 4);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(100, 28);
        comboBox1.TabIndex = 65;
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // textBox5
        // 
        textBox5.Location = new Point(251, 283);
        textBox5.Margin = new Padding(3, 4, 3, 4);
        textBox5.Name = "textBox5";
        textBox5.Size = new Size(100, 27);
        textBox5.TabIndex = 68;
        // 
        // label7
        // 
        label7.BorderStyle = BorderStyle.Fixed3D;
        label7.Font = new Font("Arial Narrow", 12F);
        label7.Location = new Point(82, 270);
        label7.Name = "label7";
        label7.Size = new Size(101, 51);
        label7.TabIndex = 67;
        label7.Text = "CNIC";
        label7.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // dateTimePicker3
        // 
        dateTimePicker3.Location = new Point(189, 278);
        dateTimePicker3.Margin = new Padding(3, 4, 3, 4);
        dateTimePicker3.Name = "dateTimePicker3";
        dateTimePicker3.Size = new Size(0, 27);
        dateTimePicker3.TabIndex = 66;
        // 
        // button2
        // 
        button2.Location = new Point(485, 480);
        button2.Margin = new Padding(3, 4, 3, 4);
        button2.Name = "button2";
        button2.Size = new Size(75, 29);
        button2.TabIndex = 69;
        button2.Text = "Exit";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // Register
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(622, 605);
        Controls.Add(button2);
        Controls.Add(textBox5);
        Controls.Add(label7);
        Controls.Add(dateTimePicker3);
        Controls.Add(comboBox1);
        Controls.Add(textBox4);
        Controls.Add(textBox3);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Controls.Add(dateTimePicker2);
        Controls.Add(dateTimePicker1);
        Controls.Add(label6);
        Controls.Add(label2);
        Controls.Add(label1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "Register";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Register";
        Load += Register_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DateTimePicker dateTimePicker2;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.ComboBox comboBox1;
    private TextBox textBox5;
    private Label label7;
    private DateTimePicker dateTimePicker3;
    private Button button2;
}