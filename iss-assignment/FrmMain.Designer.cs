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
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPrifilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileResourceUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolePrivilegeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemPrivilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grantRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revokeSystemPrivilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.tssMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.revokeRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.userToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.roleToolStripMenuItem,
            this.privilegeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1165, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userPrifilegeToolStripMenuItem,
            this.userDetailToolStripMenuItem,
            this.profileResourceUserToolStripMenuItem,
            this.rolePrivilegeUserToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.viewToolStripMenuItem.Text = "Management";
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
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllUserToolStripMenuItem,
            this.addUserToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.userToolStripMenuItem.Text = "User";
            // 
            // showAllUserToolStripMenuItem
            // 
            this.showAllUserToolStripMenuItem.Name = "showAllUserToolStripMenuItem";
            this.showAllUserToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.showAllUserToolStripMenuItem.Text = "Show All";
            this.showAllUserToolStripMenuItem.Click += new System.EventHandler(this.ShowAllToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllProfileToolStripMenuItem,
            this.addProfileToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // showAllProfileToolStripMenuItem
            // 
            this.showAllProfileToolStripMenuItem.Name = "showAllProfileToolStripMenuItem";
            this.showAllProfileToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.showAllProfileToolStripMenuItem.Text = "Show All";
            this.showAllProfileToolStripMenuItem.Click += new System.EventHandler(this.ShowAllToolStripMenuItem1_Click);
            // 
            // addProfileToolStripMenuItem
            // 
            this.addProfileToolStripMenuItem.Name = "addProfileToolStripMenuItem";
            this.addProfileToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.addProfileToolStripMenuItem.Text = "Add Profile";
            this.addProfileToolStripMenuItem.Click += new System.EventHandler(this.AddProfileToolStripMenuItem_Click);
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllRoleToolStripMenuItem,
            this.addRoleToolStripMenuItem});
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.roleToolStripMenuItem.Text = "Role";
            // 
            // showAllRoleToolStripMenuItem
            // 
            this.showAllRoleToolStripMenuItem.Name = "showAllRoleToolStripMenuItem";
            this.showAllRoleToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.showAllRoleToolStripMenuItem.Text = "Show All";
            this.showAllRoleToolStripMenuItem.Click += new System.EventHandler(this.ShowAllToolStripMenuItem2_Click);
            // 
            // addRoleToolStripMenuItem
            // 
            this.addRoleToolStripMenuItem.Name = "addRoleToolStripMenuItem";
            this.addRoleToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.addRoleToolStripMenuItem.Text = "Add Role";
            this.addRoleToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem1_Click);
            // 
            // privilegeToolStripMenuItem
            // 
            this.privilegeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemPrivilegeToolStripMenuItem,
            this.grantRoleToolStripMenuItem,
            this.revokeSystemPrivilegeToolStripMenuItem,
            this.revokeRoleToolStripMenuItem});
            this.privilegeToolStripMenuItem.Name = "privilegeToolStripMenuItem";
            this.privilegeToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.privilegeToolStripMenuItem.Text = "Privilege";
            // 
            // systemPrivilegeToolStripMenuItem
            // 
            this.systemPrivilegeToolStripMenuItem.Name = "systemPrivilegeToolStripMenuItem";
            this.systemPrivilegeToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.systemPrivilegeToolStripMenuItem.Text = "Grant System Privilege";
            this.systemPrivilegeToolStripMenuItem.Click += new System.EventHandler(this.SystemPrivilegeToolStripMenuItem_Click);
            // 
            // grantRoleToolStripMenuItem
            // 
            this.grantRoleToolStripMenuItem.Name = "grantRoleToolStripMenuItem";
            this.grantRoleToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.grantRoleToolStripMenuItem.Text = "Grant Role";
            this.grantRoleToolStripMenuItem.Click += new System.EventHandler(this.GrantRoleToolStripMenuItem_Click);
            // 
            // revokeSystemPrivilegeToolStripMenuItem
            // 
            this.revokeSystemPrivilegeToolStripMenuItem.Name = "revokeSystemPrivilegeToolStripMenuItem";
            this.revokeSystemPrivilegeToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.revokeSystemPrivilegeToolStripMenuItem.Text = "Revoke System Privilege";
            this.revokeSystemPrivilegeToolStripMenuItem.Click += new System.EventHandler(this.RevokeSystemPrivilegeToolStripMenuItem_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMain});
            this.statusStripMain.Location = new System.Drawing.Point(0, 521);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1165, 25);
            this.statusStripMain.TabIndex = 3;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // tssMain
            // 
            this.tssMain.Name = "tssMain";
            this.tssMain.Size = new System.Drawing.Size(42, 20);
            this.tssMain.Text = "Main";
            // 
            // revokeRoleToolStripMenuItem
            // 
            this.revokeRoleToolStripMenuItem.Name = "revokeRoleToolStripMenuItem";
            this.revokeRoleToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.revokeRoleToolStripMenuItem.Text = "Revoke Role";
            this.revokeRoleToolStripMenuItem.Click += new System.EventHandler(this.RevokeRoleToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 546);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "IIS Assignment";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem showAllUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemPrivilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grantRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel tssMain;
        private System.Windows.Forms.ToolStripMenuItem revokeSystemPrivilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revokeRoleToolStripMenuItem;
    }
}

