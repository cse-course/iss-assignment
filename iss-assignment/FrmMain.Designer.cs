﻿namespace iss_assignment
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPrifilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileResourceUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolePrivilegeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userPrifilegeToolStripMenuItem,
            this.userDetailToolStripMenuItem,
            this.profileResourceUserToolStripMenuItem,
            this.rolePrivilegeUserToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // userPrifilegeToolStripMenuItem
            // 
            this.userPrifilegeToolStripMenuItem.Name = "userPrifilegeToolStripMenuItem";
            this.userPrifilegeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.userPrifilegeToolStripMenuItem.Text = "User Privilege";
            this.userPrifilegeToolStripMenuItem.Click += new System.EventHandler(this.UserPrifilegeToolStripMenuItem_Click);
            // 
            // userDetailToolStripMenuItem
            // 
            this.userDetailToolStripMenuItem.Name = "userDetailToolStripMenuItem";
            this.userDetailToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.userDetailToolStripMenuItem.Text = "User Detail";
            this.userDetailToolStripMenuItem.Click += new System.EventHandler(this.UserDetailToolStripMenuItem_Click);
            // 
            // profileResourceUserToolStripMenuItem
            // 
            this.profileResourceUserToolStripMenuItem.Name = "profileResourceUserToolStripMenuItem";
            this.profileResourceUserToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.profileResourceUserToolStripMenuItem.Text = "Profile Resource User";
            this.profileResourceUserToolStripMenuItem.Click += new System.EventHandler(this.ProfileResourceUserToolStripMenuItem_Click);
            // 
            // rolePrivilegeUserToolStripMenuItem
            // 
            this.rolePrivilegeUserToolStripMenuItem.Name = "rolePrivilegeUserToolStripMenuItem";
            this.rolePrivilegeUserToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rolePrivilegeUserToolStripMenuItem.Text = "Role Privilege User";
            this.rolePrivilegeUserToolStripMenuItem.Click += new System.EventHandler(this.RolePrivilegeUserToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 547);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "IIS Assignment";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPrifilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileResourceUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolePrivilegeUserToolStripMenuItem;
    }
}
