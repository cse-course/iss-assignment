namespace iss_assignment
{
    partial class FrmSystemPrivilege
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LvwUsers = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LvwRole = new System.Windows.Forms.ListView();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LvwSelectedGrantee = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LvwSelectedPrivilege = new System.Windows.Forms.ListView();
            this.BtnClear = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LvwPrivilege = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LvwUsers);
            this.groupBox1.Location = new System.Drawing.Point(311, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 471);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // LvwUsers
            // 
            this.LvwUsers.CheckBoxes = true;
            this.LvwUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwUsers.FullRowSelect = true;
            this.LvwUsers.GridLines = true;
            this.LvwUsers.Location = new System.Drawing.Point(3, 18);
            this.LvwUsers.Name = "LvwUsers";
            this.LvwUsers.Size = new System.Drawing.Size(287, 450);
            this.LvwUsers.TabIndex = 0;
            this.LvwUsers.UseCompatibleStateImageBehavior = false;
            this.LvwUsers.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LvwRole);
            this.groupBox2.Location = new System.Drawing.Point(610, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 471);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roles";
            // 
            // LvwRole
            // 
            this.LvwRole.CheckBoxes = true;
            this.LvwRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwRole.FullRowSelect = true;
            this.LvwRole.GridLines = true;
            this.LvwRole.Location = new System.Drawing.Point(3, 18);
            this.LvwRole.Name = "LvwRole";
            this.LvwRole.Size = new System.Drawing.Size(287, 450);
            this.LvwRole.TabIndex = 1;
            this.LvwRole.UseCompatibleStateImageBehavior = false;
            this.LvwRole.View = System.Windows.Forms.View.Details;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(950, 445);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(102, 35);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LvwSelectedGrantee);
            this.groupBox3.Location = new System.Drawing.Point(909, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 209);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Grantee";
            // 
            // LvwSelectedGrantee
            // 
            this.LvwSelectedGrantee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwSelectedGrantee.FullRowSelect = true;
            this.LvwSelectedGrantee.GridLines = true;
            this.LvwSelectedGrantee.Location = new System.Drawing.Point(3, 18);
            this.LvwSelectedGrantee.Name = "LvwSelectedGrantee";
            this.LvwSelectedGrantee.Size = new System.Drawing.Size(311, 188);
            this.LvwSelectedGrantee.TabIndex = 2;
            this.LvwSelectedGrantee.UseCompatibleStateImageBehavior = false;
            this.LvwSelectedGrantee.View = System.Windows.Forms.View.Details;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LvwSelectedPrivilege);
            this.groupBox4.Location = new System.Drawing.Point(909, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 205);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Selected Privilege";
            // 
            // LvwSelectedPrivilege
            // 
            this.LvwSelectedPrivilege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwSelectedPrivilege.FullRowSelect = true;
            this.LvwSelectedPrivilege.GridLines = true;
            this.LvwSelectedPrivilege.Location = new System.Drawing.Point(3, 18);
            this.LvwSelectedPrivilege.Name = "LvwSelectedPrivilege";
            this.LvwSelectedPrivilege.Size = new System.Drawing.Size(311, 184);
            this.LvwSelectedPrivilege.TabIndex = 2;
            this.LvwSelectedPrivilege.UseCompatibleStateImageBehavior = false;
            this.LvwSelectedPrivilege.View = System.Windows.Forms.View.Details;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(1092, 445);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(102, 35);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LvwPrivilege);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(293, 471);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "System Privilege";
            // 
            // LvwPrivilege
            // 
            this.LvwPrivilege.CheckBoxes = true;
            this.LvwPrivilege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwPrivilege.FullRowSelect = true;
            this.LvwPrivilege.GridLines = true;
            this.LvwPrivilege.Location = new System.Drawing.Point(3, 18);
            this.LvwPrivilege.Name = "LvwPrivilege";
            this.LvwPrivilege.Size = new System.Drawing.Size(287, 450);
            this.LvwPrivilege.TabIndex = 0;
            this.LvwPrivilege.UseCompatibleStateImageBehavior = false;
            this.LvwPrivilege.View = System.Windows.Forms.View.Details;
            // 
            // FrmRolePrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 495);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRolePrivilege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "System Privilege";
            this.Load += new System.EventHandler(this.FrmRolePrivilege_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView LvwUsers;
        private System.Windows.Forms.ListView LvwRole;
        private System.Windows.Forms.ListView LvwSelectedGrantee;
        private System.Windows.Forms.ListView LvwSelectedPrivilege;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView LvwPrivilege;
    }
}