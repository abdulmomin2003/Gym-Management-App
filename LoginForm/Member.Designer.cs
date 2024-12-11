namespace LoginForm
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            membershipToolStripMenuItem = new ToolStripMenuItem();
            sessionsToolStripMenuItem = new ToolStripMenuItem();
            workoutToolStripMenuItem = new ToolStripMenuItem();
            dietToolStripMenuItem = new ToolStripMenuItem();
            trainerToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, membershipToolStripMenuItem, sessionsToolStripMenuItem, workoutToolStripMenuItem, dietToolStripMenuItem, trainerToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(790, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.Black;
            toolStripMenuItem1.ForeColor = SystemColors.ButtonHighlight;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(27, 20);
            toolStripMenuItem1.Text = ">";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // membershipToolStripMenuItem
            // 
            membershipToolStripMenuItem.BackColor = Color.DarkGray;
            membershipToolStripMenuItem.Name = "membershipToolStripMenuItem";
            membershipToolStripMenuItem.Size = new Size(88, 20);
            membershipToolStripMenuItem.Text = "Personal Info";
            membershipToolStripMenuItem.Click += membershipToolStripMenuItem_Click;
            // 
            // sessionsToolStripMenuItem
            // 
            sessionsToolStripMenuItem.BackColor = Color.DimGray;
            sessionsToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            sessionsToolStripMenuItem.Name = "sessionsToolStripMenuItem";
            sessionsToolStripMenuItem.Size = new Size(63, 20);
            sessionsToolStripMenuItem.Text = "Sessions";
            sessionsToolStripMenuItem.Click += sessionsToolStripMenuItem_Click;
            // 
            // workoutToolStripMenuItem
            // 
            workoutToolStripMenuItem.BackColor = Color.DarkGray;
            workoutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            workoutToolStripMenuItem.Name = "workoutToolStripMenuItem";
            workoutToolStripMenuItem.Size = new Size(65, 20);
            workoutToolStripMenuItem.Text = "Workout";
            workoutToolStripMenuItem.Click += workoutToolStripMenuItem_Click;
            // 
            // dietToolStripMenuItem
            // 
            dietToolStripMenuItem.BackColor = Color.DimGray;
            dietToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            dietToolStripMenuItem.Name = "dietToolStripMenuItem";
            dietToolStripMenuItem.Size = new Size(40, 20);
            dietToolStripMenuItem.Text = "Diet";
            dietToolStripMenuItem.Click += dietToolStripMenuItem_Click;
            // 
            // trainerToolStripMenuItem
            // 
            trainerToolStripMenuItem.BackColor = Color.DarkGray;
            trainerToolStripMenuItem.Name = "trainerToolStripMenuItem";
            trainerToolStripMenuItem.Size = new Size(54, 20);
            trainerToolStripMenuItem.Text = "Trainer";
            trainerToolStripMenuItem.Click += trainerToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.BackColor = Color.DimGray;
            logoutToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(57, 20);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click_1;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.DarkGray;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(790, 498);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Member";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Member Interface";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem workoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dietToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

