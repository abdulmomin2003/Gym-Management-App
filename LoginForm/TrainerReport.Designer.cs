using System.Windows.Forms;

using System.Xml.Linq;
using LoginForm.Properties;

namespace LoginForm
{
    partial class TrainerReport
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewTrainers;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewTrainers = new DataGridView();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrainers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTrainers
            // 
            dataGridViewTrainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrainers.Location = new Point(14, 117);
            dataGridViewTrainers.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTrainers.Name = "dataGridViewTrainers";
            dataGridViewTrainers.RowHeadersWidth = 51;
            dataGridViewTrainers.Size = new Size(706, 503);
            dataGridViewTrainers.TabIndex = 0;
            dataGridViewTrainers.CellContentClick += dataGridViewTrainers_CellContentClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(14, 16);
            textBoxSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(171, 27);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(192, 16);
            buttonSearch.Margin = new Padding(3, 4, 3, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(86, 31);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(285, 16);
            buttonRefresh.Margin = new Padding(3, 4, 3, 4);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(86, 31);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // TrainerReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.WhatsApp_Image_2024_05_04_at_11_53_36_574ba208;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 656);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridViewTrainers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TrainerReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trainer Report";
            Load += TrainerReport_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrainers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
