//susing static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LoginForm
{
    partial class Owner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner));
            menuStrip1 = new MenuStrip();
            mToolStripMenuItem = new ToolStripMenuItem();
            trainerReportsToolStripMenuItem = new ToolStripMenuItem();
            newMemberRequestToolStripMenuItem = new ToolStripMenuItem();
            equiptmentToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            trainerChangeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mToolStripMenuItem, trainerReportsToolStripMenuItem, newMemberRequestToolStripMenuItem, equiptmentToolStripMenuItem, trainerChangeToolStripMenuItem, logOutToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1090, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mToolStripMenuItem
            // 
            mToolStripMenuItem.BackColor = Color.DimGray;
            mToolStripMenuItem.ImageAlign = ContentAlignment.TopRight;
            mToolStripMenuItem.Name = "mToolStripMenuItem";
            mToolStripMenuItem.Size = new Size(134, 24);
            mToolStripMenuItem.Text = "Member Reports";
            mToolStripMenuItem.Click += mToolStripMenuItem_Click;
            // 
            // trainerReportsToolStripMenuItem
            // 
            trainerReportsToolStripMenuItem.BackColor = Color.DarkGray;
            trainerReportsToolStripMenuItem.Name = "trainerReportsToolStripMenuItem";
            trainerReportsToolStripMenuItem.Size = new Size(123, 24);
            trainerReportsToolStripMenuItem.Text = "Trainer Reports";
            trainerReportsToolStripMenuItem.Click += trainerReportsToolStripMenuItem_Click;
            // 
            // newMemberRequestToolStripMenuItem
            // 
            newMemberRequestToolStripMenuItem.BackColor = Color.DimGray;
            newMemberRequestToolStripMenuItem.BackgroundImageLayout = ImageLayout.Center;
            newMemberRequestToolStripMenuItem.Name = "newMemberRequestToolStripMenuItem";
            newMemberRequestToolStripMenuItem.Size = new Size(116, 24);
            newMemberRequestToolStripMenuItem.Text = "New Requests";
            newMemberRequestToolStripMenuItem.Click += newMemberRequestToolStripMenuItem_Click;
            // 
            // equiptmentToolStripMenuItem
            // 
            equiptmentToolStripMenuItem.BackColor = Color.DarkGray;
            equiptmentToolStripMenuItem.Name = "equiptmentToolStripMenuItem";
            equiptmentToolStripMenuItem.Size = new Size(95, 24);
            equiptmentToolStripMenuItem.Text = "Equipment";
            equiptmentToolStripMenuItem.Click += equiptmentToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.BackColor = Color.DimGray;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(74, 24);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.LightGray;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // trainerChangeToolStripMenuItem
            // 
            trainerChangeToolStripMenuItem.BackColor = Color.DimGray;
            trainerChangeToolStripMenuItem.Name = "trainerChangeToolStripMenuItem";
            trainerChangeToolStripMenuItem.Size = new Size(122, 24);
            trainerChangeToolStripMenuItem.Text = "Trainer Change";
            trainerChangeToolStripMenuItem.Click += trainerChangeToolStripMenuItem_Click;
            // 
            // Owner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1090, 663);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Owner";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mToolStripMenuItem;
        private ToolStripMenuItem trainerReportsToolStripMenuItem;
        private ToolStripMenuItem newMemberRequestToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem equiptmentToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem trainerChangeToolStripMenuItem;
    }
}