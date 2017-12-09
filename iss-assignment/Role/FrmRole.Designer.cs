namespace iss_assignment
{
    partial class FrmRole
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LvwRole = new System.Windows.Forms.ListView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.CmsRole = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refeshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.CmsRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LvwRole);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 517);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Role";
            // 
            // LvwRole
            // 
            this.LvwRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwRole.FullRowSelect = true;
            this.LvwRole.Location = new System.Drawing.Point(3, 18);
            this.LvwRole.Name = "LvwRole";
            this.LvwRole.Size = new System.Drawing.Size(465, 496);
            this.LvwRole.TabIndex = 0;
            this.LvwRole.Tag = "0";
            this.LvwRole.UseCompatibleStateImageBehavior = false;
            this.LvwRole.View = System.Windows.Forms.View.Details;
            this.LvwRole.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvwRole_MouseDoubleClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(66, 553);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(113, 43);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Tag = "1";
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(266, 553);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(113, 43);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Tag = "2";
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // CmsRole
            // 
            this.CmsRole.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsRole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refeshToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.CmsRole.Name = "CmsRole";
            this.CmsRole.Size = new System.Drawing.Size(123, 76);
            // 
            // refeshToolStripMenuItem
            // 
            this.refeshToolStripMenuItem.Name = "refeshToolStripMenuItem";
            this.refeshToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.refeshToolStripMenuItem.Text = "Refesh";
            this.refeshToolStripMenuItem.Click += new System.EventHandler(this.RefeshToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // FrmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 620);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Role";
            this.Load += new System.EventHandler(this.FrmRole_Load);
            this.groupBox1.ResumeLayout(false);
            this.CmsRole.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView LvwRole;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.ContextMenuStrip CmsRole;
        private System.Windows.Forms.ToolStripMenuItem refeshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}