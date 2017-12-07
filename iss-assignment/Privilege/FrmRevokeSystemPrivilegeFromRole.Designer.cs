namespace iss_assignment
{
    partial class FrmRevokeSystemPrivilegeFromRole
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
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LvwRoles = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LvwSystemPrivilege = new System.Windows.Forms.ListView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(729, 40);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(117, 53);
            this.BtnClear.TabIndex = 15;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(729, 126);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(117, 53);
            this.BtnSave.TabIndex = 16;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LvwRoles);
            this.groupBox2.Location = new System.Drawing.Point(370, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(352, 692);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Role";
            // 
            // LvwRoles
            // 
            this.LvwRoles.CheckBoxes = true;
            this.LvwRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwRoles.FullRowSelect = true;
            this.LvwRoles.GridLines = true;
            this.LvwRoles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LvwRoles.Location = new System.Drawing.Point(3, 17);
            this.LvwRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LvwRoles.Name = "LvwRoles";
            this.LvwRoles.Size = new System.Drawing.Size(346, 673);
            this.LvwRoles.TabIndex = 1;
            this.LvwRoles.UseCompatibleStateImageBehavior = false;
            this.LvwRoles.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LvwSystemPrivilege);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(352, 692);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Privilege";
            // 
            // LvwSystemPrivilege
            // 
            this.LvwSystemPrivilege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwSystemPrivilege.FullRowSelect = true;
            this.LvwSystemPrivilege.GridLines = true;
            this.LvwSystemPrivilege.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LvwSystemPrivilege.Location = new System.Drawing.Point(3, 17);
            this.LvwSystemPrivilege.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LvwSystemPrivilege.Name = "LvwSystemPrivilege";
            this.LvwSystemPrivilege.Size = new System.Drawing.Size(346, 673);
            this.LvwSystemPrivilege.TabIndex = 0;
            this.LvwSystemPrivilege.UseCompatibleStateImageBehavior = false;
            this.LvwSystemPrivilege.View = System.Windows.Forms.View.Details;
            this.LvwSystemPrivilege.SelectedIndexChanged += new System.EventHandler(this.LvwSystemPrivilege_SelectedIndexChanged);
            // 
            // FrmRevokeSystemPrivilegeFromRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 738);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRevokeSystemPrivilegeFromRole";
            this.Text = "FrmRevokeSystemPrivilegeFromRole";
            this.Load += new System.EventHandler(this.FrmRevokeSystemPrivilegeFromRole_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView LvwRoles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView LvwSystemPrivilege;
    }
}