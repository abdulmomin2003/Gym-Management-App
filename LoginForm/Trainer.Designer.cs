using LoginForm.Properties;
namespace LoginForm
{
    partial class Trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainer));
            menuStrip1 = new MenuStrip();
            aPPOINTMENTSCHEDULINGToolStripMenuItem = new ToolStripMenuItem();
            wORKOUTPLANSToolStripMenuItem = new ToolStripMenuItem();
            vIEWCLIENTSToolStripMenuItem = new ToolStripMenuItem();
            dIETPLANSToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 128, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aPPOINTMENTSCHEDULINGToolStripMenuItem, wORKOUTPLANSToolStripMenuItem, vIEWCLIENTSToolStripMenuItem, dIETPLANSToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1014, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aPPOINTMENTSCHEDULINGToolStripMenuItem
            // 
            aPPOINTMENTSCHEDULINGToolStripMenuItem.Name = "aPPOINTMENTSCHEDULINGToolStripMenuItem";
            aPPOINTMENTSCHEDULINGToolStripMenuItem.Size = new Size(216, 24);
            aPPOINTMENTSCHEDULINGToolStripMenuItem.Text = "APPOINTMENT SCHEDULING";
            aPPOINTMENTSCHEDULINGToolStripMenuItem.Click += aPPOINTMENTSCHEDULINGToolStripMenuItem_Click;
            // 
            // wORKOUTPLANSToolStripMenuItem
            // 
            wORKOUTPLANSToolStripMenuItem.Name = "wORKOUTPLANSToolStripMenuItem";
            wORKOUTPLANSToolStripMenuItem.Size = new Size(142, 24);
            wORKOUTPLANSToolStripMenuItem.Text = "WORKOUT PLANS";
            wORKOUTPLANSToolStripMenuItem.Click += wORKOUTPLANSToolStripMenuItem_Click;
            // 
            // vIEWCLIENTSToolStripMenuItem
            // 
            vIEWCLIENTSToolStripMenuItem.Name = "vIEWCLIENTSToolStripMenuItem";
            vIEWCLIENTSToolStripMenuItem.Size = new Size(117, 24);
            vIEWCLIENTSToolStripMenuItem.Text = "VIEW CLIENTS";
            vIEWCLIENTSToolStripMenuItem.Click += vIEWCLIENTSToolStripMenuItem_Click;
            // 
            // dIETPLANSToolStripMenuItem
            // 
            dIETPLANSToolStripMenuItem.Name = "dIETPLANSToolStripMenuItem";
            dIETPLANSToolStripMenuItem.Size = new Size(102, 24);
            dIETPLANSToolStripMenuItem.Text = "DIET PLANS";
            dIETPLANSToolStripMenuItem.Click += dIETPLANSToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(79, 24);
            logoutToolStripMenuItem.Text = "LOGOUT";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(52, 24);
            exitToolStripMenuItem.Text = "EXIT";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(974, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(49, 35);
            button1.TabIndex = 45;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Trainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1014, 841);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Trainer";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aPPOINTMENTSCHEDULINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wORKOUTPLANSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWCLIENTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dIETPLANSToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}

