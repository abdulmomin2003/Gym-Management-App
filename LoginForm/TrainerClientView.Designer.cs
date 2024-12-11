using System.Windows.Forms;

namespace LoginForm
{
    partial class TrainerClientView : Form
    {
        private DataGridView dataGridViewTrainerClient;
        private ComboBox comboBoxTrainers;
        private ComboBox comboBoxClients;
        private Button buttonAssign;
        private MenuStrip menuStrip;
        private ToolStripMenuItem viewByTrainerToolStripMenuItem;
        private ToolStripMenuItem viewByClientToolStripMenuItem;

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        // Inside TrainerClientView class
        private void viewByTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add code to handle the event when "View by Trainer" menu item is clicked
        }

        private void viewByClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add code to handle the event when "View by Client" menu item is clicked
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerClientView));
            dataGridViewTrainerClient = new DataGridView();
            comboBoxTrainers = new ComboBox();
            comboBoxClients = new ComboBox();
            buttonAssign = new Button();
            menuStrip = new MenuStrip();
            viewByTrainerToolStripMenuItem = new ToolStripMenuItem();
            viewByClientToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrainerClient).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTrainerClient
            // 
            dataGridViewTrainerClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrainerClient.Location = new Point(26, 60);
            dataGridViewTrainerClient.Name = "dataGridViewTrainerClient";
            dataGridViewTrainerClient.Size = new Size(578, 363);
            dataGridViewTrainerClient.TabIndex = 0;
            // 
            // comboBoxTrainers
            // 
            comboBoxTrainers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTrainers.FormattingEnabled = true;
            comboBoxTrainers.Location = new Point(12, 457);
            comboBoxTrainers.Name = "comboBoxTrainers";
            comboBoxTrainers.Size = new Size(200, 23);
            comboBoxTrainers.TabIndex = 1;
            // 
            // comboBoxClients
            // 
            comboBoxClients.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point(235, 457);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(200, 23);
            comboBoxClients.TabIndex = 2;
            // 
            // buttonAssign
            // 
            buttonAssign.Location = new Point(486, 456);
            buttonAssign.Name = "buttonAssign";
            buttonAssign.Size = new Size(75, 23);
            buttonAssign.TabIndex = 3;
            buttonAssign.Text = "Assign";
            buttonAssign.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { viewByTrainerToolStripMenuItem, viewByClientToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(642, 24);
            menuStrip.TabIndex = 4;
            menuStrip.Text = "menuStrip";
            // 
            // viewByTrainerToolStripMenuItem
            // 
            viewByTrainerToolStripMenuItem.Name = "viewByTrainerToolStripMenuItem";
            viewByTrainerToolStripMenuItem.Size = new Size(98, 20);
            viewByTrainerToolStripMenuItem.Text = "View by Trainer";
            viewByTrainerToolStripMenuItem.Click += viewByTrainerToolStripMenuItem_Click;
            // 
            // viewByClientToolStripMenuItem
            // 
            viewByClientToolStripMenuItem.Name = "viewByClientToolStripMenuItem";
            viewByClientToolStripMenuItem.Size = new Size(94, 20);
            viewByClientToolStripMenuItem.Text = "View by Client";
            viewByClientToolStripMenuItem.Click += viewByClientToolStripMenuItem_Click;
            // 
            // TrainerClientView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(642, 492);
            Controls.Add(menuStrip);
            Controls.Add(buttonAssign);
            Controls.Add(comboBoxClients);
            Controls.Add(comboBoxTrainers);
            Controls.Add(dataGridViewTrainerClient);
            DoubleBuffered = true;
            Name = "TrainerClientView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trainer Client View";
            Load += TrainerClientView_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrainerClient).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
