namespace LoginForm
{
    partial class Reports
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(295, 34);
            label1.Name = "label1";
            label1.Size = new Size(195, 54);
            label1.TabIndex = 12;
            label1.Text = "REPORTS";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "GetMembersForTrainerAndGym", "GetMembersForGymAndDietPlan", "GetMembersForTrainerAndDietPlan", "GetMachineUsageCount", "DietLowCalorieBreakfast", "GetDietPlansWithLowCarbohydrateIntake", "GetWorkoutPlansWithoutSpecificMachine", "GetDietPlansWithoutPeanutsAllergen 'Peanuts'", "GetNewMembershipsLast3Months", "CompareTotalMembersInGymsPast6Months ", "NewMembersByMonth", "TopRatedTrainers", "TrainersWithNoFeedback", "GetAppointmentDetails", "GetGymMemberCount", "GetWorkoutPlansForWeightLoss", "GetDietPlansWithMealsOrderedByCalories", "GetDietPlansWithSpecificMealAndNoEggs", "GetGymsWithProfitFromMembershipsGreaterThan1000", "GetGymsWithFeesGreaterThan56" });
            comboBox1.Location = new Point(101, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(634, 28);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(101, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(634, 327);
            dataGridView1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(354, 502);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "VIEW";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Reports";
            Text = "Reports";
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button button1;
    }
}