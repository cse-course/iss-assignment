namespace iss_assignment
{
    partial class FrmRevokeSystemPrivilege
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LvwUser = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LvwSystemPrivilege = new System.Windows.Forms.ListView();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LvwUser);
            this.groupBox2.Location = new System.Drawing.Point(370, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(352, 692);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uses";
            // 
            // LvwUser
            // 
            this.LvwUser.CheckBoxes = true;
            this.LvwUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwUser.FullRowSelect = true;
            this.LvwUser.GridLines = true;
            this.LvwUser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LvwUser.Location = new System.Drawing.Point(3, 17);
            this.LvwUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LvwUser.Name = "LvwUser";
            this.LvwUser.Size = new System.Drawing.Size(346, 673);
            this.LvwUser.TabIndex = 1;
            this.LvwUser.UseCompatibleStateImageBehavior = false;
            this.LvwUser.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LvwSystemPrivilege);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(352, 692);
            this.groupBox1.TabIndex = 9;
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
            this.LvwSystemPrivilege.MultiSelect = false;
            this.LvwSystemPrivilege.Name = "LvwSystemPrivilege";
            this.LvwSystemPrivilege.Size = new System.Drawing.Size(346, 673);
            this.LvwSystemPrivilege.TabIndex = 0;
            this.LvwSystemPrivilege.UseCompatibleStateImageBehavior = false;
            this.LvwSystemPrivilege.View = System.Windows.Forms.View.Details;
            this.LvwSystemPrivilege.Click += new System.EventHandler(this.LvwSystemPrivilege_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(729, 28);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(117, 53);
            this.BtnClear.TabIndex = 11;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(729, 114);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(117, 53);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Revoke";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmRevokeSystemPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 738);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRevokeSystemPrivilege";
            this.Text = "Revoke System Privilege";
            this.Load += new System.EventHandler(this.FrmRevokeSystemPrivilegeFromUser_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView LvwUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView LvwSystemPrivilege;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSave;
    }
}