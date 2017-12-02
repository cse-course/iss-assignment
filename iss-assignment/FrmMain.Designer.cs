namespace iss_assignment
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
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
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
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // userPrifilegeToolStripMenuItem
            // 
            this.userPrifilegeToolStripMenuItem.Name = "userPrifilegeToolStripMenuItem";
            this.userPrifilegeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.userPrifilegeToolStripMenuItem.Text = "User Privilege";
            this.userPrifilegeToolStripMenuItem.Click += new System.EventHandler(this.UserPrifilegeToolStripMenuItem_Click);
            // 
            // userDetailToolStripMenuItem
            // 
            this.userDetailToolStripMenuItem.Name = "userDetailToolStripMenuItem";
            this.userDetailToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.userDetailToolStripMenuItem.Text = "User Detail";
            this.userDetailToolStripMenuItem.Click += new System.EventHandler(this.UserDetailToolStripMenuItem_Click);
            // 
            // profileResourceUserToolStripMenuItem
            // 
            this.profileResourceUserToolStripMenuItem.Name = "profileResourceUserToolStripMenuItem";
            this.profileResourceUserToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.profileResourceUserToolStripMenuItem.Text = "Profile Resource User";
            this.profileResourceUserToolStripMenuItem.Click += new System.EventHandler(this.ProfileResourceUserToolStripMenuItem_Click);
            // 
            // rolePrivilegeUserToolStripMenuItem
            // 
            this.rolePrivilegeUserToolStripMenuItem.Name = "rolePrivilegeUserToolStripMenuItem";
            this.rolePrivilegeUserToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.rolePrivilegeUserToolStripMenuItem.Text = "Role Privilege User";
            this.rolePrivilegeUserToolStripMenuItem.Click += new System.EventHandler(this.RolePrivilegeUserToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllToolStripMenuItem,
            this.oneUserToolStripMenuItem,
            this.addToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showAllToolStripMenuItem.Text = "Show All";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // oneUserToolStripMenuItem
            // 
            this.oneUserToolStripMenuItem.Name = "oneUserToolStripMenuItem";
            this.oneUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oneUserToolStripMenuItem.Text = "One User";
            this.oneUserToolStripMenuItem.Click += new System.EventHandler(this.oneUserToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 444);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}

