namespace iss_assignment
{
    partial class FrmRolePrivilege
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LvwUsers = new System.Windows.Forms.ListView();
            this.gro = new System.Windows.Forms.GroupBox();
            this.DgvRole = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.gro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRole)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(742, 29);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(117, 53);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(742, 115);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(117, 53);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LvwUsers);
            this.groupBox1.Location = new System.Drawing.Point(370, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(352, 692);
            this.groupBox1.TabIndex = 3;
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
            this.LvwUsers.Location = new System.Drawing.Point(3, 17);
            this.LvwUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LvwUsers.Name = "LvwUsers";
            this.LvwUsers.Size = new System.Drawing.Size(346, 673);
            this.LvwUsers.TabIndex = 0;
            this.LvwUsers.UseCompatibleStateImageBehavior = false;
            this.LvwUsers.View = System.Windows.Forms.View.Details;
            // 
            // gro
            // 
            this.gro.Controls.Add(this.DgvRole);
            this.gro.Location = new System.Drawing.Point(12, 9);
            this.gro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gro.Name = "gro";
            this.gro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gro.Size = new System.Drawing.Size(355, 692);
            this.gro.TabIndex = 7;
            this.gro.TabStop = false;
            this.gro.Text = "Role Privilege";
            // 
            // DgvRole
            // 
            this.DgvRole.AllowUserToAddRows = false;
            this.DgvRole.AllowUserToDeleteRows = false;
            this.DgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvRole.Location = new System.Drawing.Point(3, 17);
            this.DgvRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvRole.Name = "DgvRole";
            this.DgvRole.RowTemplate.Height = 24;
            this.DgvRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRole.Size = new System.Drawing.Size(349, 673);
            this.DgvRole.TabIndex = 0;
            // 
            // FrmRolePrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 711);
            this.Controls.Add(this.gro);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRolePrivilege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Role Privilege";
            this.Load += new System.EventHandler(this.FrmRolePrivilege_Load);
            this.groupBox1.ResumeLayout(false);
            this.gro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView LvwUsers;
        private System.Windows.Forms.GroupBox gro;
        private System.Windows.Forms.DataGridView DgvRole;
    }
}