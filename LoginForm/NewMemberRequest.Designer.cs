using System.Windows.Forms;
using LoginForm.Properties;
namespace LoginForm
{
    partial class NewMemberRequest : Form
    {
        private DataGridView dataGridViewRequests;
        private Button buttonAccept;
        private Button buttonDecline;

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
            dataGridViewRequests = new DataGridView();
            buttonAccept = new Button();
            buttonDecline = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequests.Location = new Point(40, 217);
            dataGridViewRequests.Margin = new Padding(3, 4, 3, 4);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.RowHeadersWidth = 51;
            dataGridViewRequests.Size = new Size(630, 337);
            dataGridViewRequests.TabIndex = 0;
            // 
            // buttonAccept
            // 
            buttonAccept.Location = new Point(187, 596);
            buttonAccept.Margin = new Padding(3, 4, 3, 4);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(86, 31);
            buttonAccept.TabIndex = 1;
            buttonAccept.Text = "Accept";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // buttonDecline
            // 
            buttonDecline.Location = new Point(409, 596);
            buttonDecline.Margin = new Padding(3, 4, 3, 4);
            buttonDecline.Name = "buttonDecline";
            buttonDecline.Size = new Size(86, 31);
            buttonDecline.TabIndex = 2;
            buttonDecline.Text = "Decline";
            buttonDecline.UseVisualStyleBackColor = true;
            buttonDecline.Click += buttonDecline_Click;
            // 
            // NewMemberRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.sa;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 656);
            Controls.Add(buttonDecline);
            Controls.Add(buttonAccept);
            Controls.Add(dataGridViewRequests);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewMemberRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Member Requests";
            Load += NewMemberRequest_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
            ResumeLayout(false);
        }
    }
}
