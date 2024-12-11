using System.Windows.Forms;
using LoginForm.Properties;
namespace LoginForm
{
    partial class HireTrainer : Form
    {
        private DataGridView dataGridViewApplicants;
        private Button buttonViewDetails;
        private Button buttonHire;
        private ComboBox comboBoxStatus;
        private Label labelStatus;

        private System.ComponentModel.IContainer components = null;

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
            dataGridViewApplicants = new DataGridView();
            buttonViewDetails = new Button();
            buttonHire = new Button();
            comboBoxStatus = new ComboBox();
            labelStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApplicants).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewApplicants
            // 
            dataGridViewApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewApplicants.Location = new Point(87, 64);
            dataGridViewApplicants.Name = "dataGridViewApplicants";
            dataGridViewApplicants.Size = new Size(522, 362);
            dataGridViewApplicants.TabIndex = 0;
            dataGridViewApplicants.CellContentClick += dataGridViewApplicants_CellContentClick;
            // 
            // buttonViewDetails
            // 
            buttonViewDetails.Location = new Point(350, 456);
            buttonViewDetails.Name = "buttonViewDetails";
            buttonViewDetails.Size = new Size(100, 23);
            buttonViewDetails.TabIndex = 1;
            buttonViewDetails.Text = "View Details";
            buttonViewDetails.UseVisualStyleBackColor = true;
            // 
            // buttonHire
            // 
            buttonHire.Location = new Point(546, 457);
            buttonHire.Name = "buttonHire";
            buttonHire.Size = new Size(75, 23);
            buttonHire.TabIndex = 2;
            buttonHire.Text = "Hire";
            buttonHire.UseVisualStyleBackColor = true;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Pending", "Hired", "Rejected" });
            comboBoxStatus.Location = new Point(184, 457);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(121, 23);
            comboBoxStatus.TabIndex = 3;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(106, 460);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(42, 15);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Status:";
            // 
            // HireTrainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.GYM_APP1;
            ClientSize = new Size(665, 492);
            Controls.Add(labelStatus);
            Controls.Add(comboBoxStatus);
            Controls.Add(buttonHire);
            Controls.Add(buttonViewDetails);
            Controls.Add(dataGridViewApplicants);
            Name = "HireTrainer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hire Trainer";
            ((System.ComponentModel.ISupportInitialize)dataGridViewApplicants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
