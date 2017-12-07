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
            this.BtnClear = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DgvPrivilege = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrivilege)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LvwUsers);
            this.groupBox1.Location = new System.Drawing.Point(463, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(264, 562);
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
            this.LvwUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LvwUsers.Location = new System.Drawing.Point(2, 15);
            this.LvwUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LvwUsers.Name = "LvwUsers";
            this.LvwUsers.Size = new System.Drawing.Size(260, 545);
            this.LvwUsers.TabIndex = 0;
            this.LvwUsers.UseCompatibleStateImageBehavior = false;
            this.LvwUsers.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LvwRole);
            this.groupBox2.Location = new System.Drawing.Point(734, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(264, 562);
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
            this.LvwRole.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LvwRole.Location = new System.Drawing.Point(2, 15);
            this.LvwRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LvwRole.Name = "LvwRole";
            this.LvwRole.Size = new System.Drawing.Size(260, 545);
            this.LvwRole.TabIndex = 1;
            this.LvwRole.UseCompatibleStateImageBehavior = false;
            this.LvwRole.View = System.Windows.Forms.View.Details;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(1010, 94);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(88, 43);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(1010, 24);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(88, 43);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DgvPrivilege);
            this.groupBox5.Location = new System.Drawing.Point(9, 10);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(449, 565);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "System Privilege";
            // 
            // DgvPrivilege
            // 
            this.DgvPrivilege.AllowUserToAddRows = false;
            this.DgvPrivilege.AllowUserToDeleteRows = false;
            this.DgvPrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPrivilege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPrivilege.Location = new System.Drawing.Point(2, 15);
            this.DgvPrivilege.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvPrivilege.Name = "DgvPrivilege";
            this.DgvPrivilege.RowTemplate.Height = 24;
            this.DgvPrivilege.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPrivilege.Size = new System.Drawing.Size(445, 548);
            this.DgvPrivilege.TabIndex = 0;
            // 
            // FrmSystemPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 584);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmSystemPrivilege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "System Privilege";
            this.Load += new System.EventHandler(this.FrmRolePrivilege_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrivilege)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ListView LvwUsers;
        private System.Windows.Forms.ListView LvwRole;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DgvPrivilege;
    }
}