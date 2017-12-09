namespace iss_assignment
{
    partial class FrmRolePrivilegeUser
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
            this.DgvRolePrivilegeUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRolePrivilegeUser)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvRolePrivilegeUser
            // 
            this.DgvRolePrivilegeUser.AllowUserToAddRows = false;
            this.DgvRolePrivilegeUser.AllowUserToDeleteRows = false;
            this.DgvRolePrivilegeUser.AllowUserToOrderColumns = true;
            this.DgvRolePrivilegeUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRolePrivilegeUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvRolePrivilegeUser.Location = new System.Drawing.Point(0, 0);
            this.DgvRolePrivilegeUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvRolePrivilegeUser.Name = "DgvRolePrivilegeUser";
            this.DgvRolePrivilegeUser.ReadOnly = true;
            this.DgvRolePrivilegeUser.RowTemplate.Height = 24;
            this.DgvRolePrivilegeUser.Size = new System.Drawing.Size(895, 502);
            this.DgvRolePrivilegeUser.TabIndex = 0;
            this.DgvRolePrivilegeUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRolePrivilegeUser_CellContentClick);
            // 
            // FrmRolePrivilegeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 502);
            this.Controls.Add(this.DgvRolePrivilegeUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRolePrivilegeUser";
            this.Text = "Role Privilege User";
            this.Load += new System.EventHandler(this.FrmRolePrivilegeUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRolePrivilegeUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRolePrivilegeUser;
    }
}