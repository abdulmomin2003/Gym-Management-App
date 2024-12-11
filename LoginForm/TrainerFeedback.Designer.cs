namespace LoginForm
{
    partial class TrainerFeedback
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
            Syncfusion.Windows.Forms.Tools.CustomImageCollection customImageCollection1 = new Syncfusion.Windows.Forms.Tools.CustomImageCollection();
            Syncfusion.Windows.Forms.Tools.ResetButton resetButton1 = new Syncfusion.Windows.Forms.Tools.ResetButton();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            ratingControl1 = new Syncfusion.Windows.Forms.Tools.RatingControl();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Century Schoolbook", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(622, 114);
            label2.TabIndex = 18;
            label2.Text = "Trainer Feedback";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 139);
            label4.Name = "label4";
            label4.Size = new Size(112, 38);
            label4.TabIndex = 33;
            label4.Text = "Ratings";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 221);
            label1.Name = "label1";
            label1.Size = new Size(112, 38);
            label1.TabIndex = 35;
            label1.Text = "Description";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 229);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 226);
            textBox1.TabIndex = 36;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(315, 511);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 37;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ratingControl1
            // 
            ratingControl1.Images = customImageCollection1;
            ratingControl1.Location = new Point(277, 139);
            ratingControl1.Name = "ratingControl1";
            ratingControl1.ResetButton = resetButton1;
            ratingControl1.Size = new Size(273, 41);
            ratingControl1.TabIndex = 38;
            ratingControl1.Text = "ratingControl1";
            ratingControl1.Click += ratingControl1_Click;
            // 
            // TrainerFeedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 605);
            Controls.Add(ratingControl1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TrainerFeedback";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "v";
            Load += TrainerFeedback_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Button button1;
        private Syncfusion.Windows.Forms.Tools.RatingControl ratingControl1;
    }
}