namespace LoginForm
{
    partial class TrainerChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerChange));
            buttonRefresh = new Button();
            dataGridViewTrainers = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrainers).BeginInit();
            SuspendLayout();
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(309, 51);
            buttonRefresh.Margin = new Padding(3, 4, 3, 4);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(86, 31);
            buttonRefresh.TabIndex = 7;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // dataGridViewTrainers
            // 
            dataGridViewTrainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrainers.Location = new Point(12, 108);
            dataGridViewTrainers.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTrainers.Name = "dataGridViewTrainers";
            dataGridViewTrainers.RowHeadersWidth = 51;
            dataGridViewTrainers.Size = new Size(706, 503);
            dataGridViewTrainers.TabIndex = 4;
            dataGridViewTrainers.CellContentClick += dataGridViewTrainers_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 51);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 8;
            button1.Text = "Approve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(636, 51);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 9;
            button2.Text = "Reject";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TrainerChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 656);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonRefresh);
            Controls.Add(dataGridViewTrainers);
            Name = "TrainerChange";
            Text = "TrainerChange";
            Load += TrainerChange_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrainers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRefresh;
        private DataGridView dataGridViewTrainers;
        private Button button1;
        private Button button2;
    }
}