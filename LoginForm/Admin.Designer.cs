//using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LoginForm
{
    partial class Admin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            menuStrip1 = new MenuStrip();
            gymRegistrationRequestToolStripMenuItem = new ToolStripMenuItem();
            gymReportsToolStripMenuItem = new ToolStripMenuItem();
            gymMembershipManagementToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            reprtsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gymRegistrationRequestToolStripMenuItem, gymReportsToolStripMenuItem, gymMembershipManagementToolStripMenuItem, reprtsToolStripMenuItem, logOutToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gymRegistrationRequestToolStripMenuItem
            // 
            gymRegistrationRequestToolStripMenuItem.BackColor = Color.DarkGray;
            gymRegistrationRequestToolStripMenuItem.Name = "gymRegistrationRequestToolStripMenuItem";
            gymRegistrationRequestToolStripMenuItem.Size = new Size(194, 24);
            gymRegistrationRequestToolStripMenuItem.Text = "Gym Registration Request";
            gymRegistrationRequestToolStripMenuItem.Click += gymRegistrationRequestToolStripMenuItem_Click;
            // 
            // gymReportsToolStripMenuItem
            // 
            gymReportsToolStripMenuItem.BackColor = Color.DimGray;
            gymReportsToolStripMenuItem.Name = "gymReportsToolStripMenuItem";
            gymReportsToolStripMenuItem.Size = new Size(108, 24);
            gymReportsToolStripMenuItem.Text = "Gym Reports";
            gymReportsToolStripMenuItem.Click += gymReportsToolStripMenuItem_Click;
            // 
            // gymMembershipManagementToolStripMenuItem
            // 
            gymMembershipManagementToolStripMenuItem.BackColor = Color.DarkGray;
            gymMembershipManagementToolStripMenuItem.Name = "gymMembershipManagementToolStripMenuItem";
            gymMembershipManagementToolStripMenuItem.Size = new Size(232, 24);
            gymMembershipManagementToolStripMenuItem.Text = "Gym Membership Management";
            gymMembershipManagementToolStripMenuItem.Click += gymMembershipManagementToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.BackColor = Color.DarkGray;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(76, 24);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.DimGray;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // reprtsToolStripMenuItem
            // 
            reprtsToolStripMenuItem.BackColor = Color.DimGray;
            reprtsToolStripMenuItem.Name = "reprtsToolStripMenuItem";
            reprtsToolStripMenuItem.Size = new Size(74, 24);
            reprtsToolStripMenuItem.Text = "Reports";
            reprtsToolStripMenuItem.Click += reprtsToolStripMenuItem_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Admin";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gymRegistrationRequestToolStripMenuItem;
        private ToolStripMenuItem gymReportsToolStripMenuItem;
        private ToolStripMenuItem gymMembershipManagementToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem reprtsToolStripMenuItem;
    }
}