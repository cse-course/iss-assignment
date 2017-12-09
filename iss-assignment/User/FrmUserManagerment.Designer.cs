namespace iss_assignment
{
    partial class FrmUserManagerment
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
            this.LvwUserManagerment = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refeshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvwUserManagerment
            // 
            this.LvwUserManagerment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwUserManagerment.FullRowSelect = true;
            this.LvwUserManagerment.GridLines = true;
            this.LvwUserManagerment.Location = new System.Drawing.Point(0, 0);
            this.LvwUserManagerment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LvwUserManagerment.Name = "LvwUserManagerment";
            this.LvwUserManagerment.Size = new System.Drawing.Size(839, 338);
            this.LvwUserManagerment.TabIndex = 0;
            this.LvwUserManagerment.UseCompatibleStateImageBehavior = false;
            this.LvwUserManagerment.View = System.Windows.Forms.View.Details;
            this.LvwUserManagerment.SelectedIndexChanged += new System.EventHandler(this.LvwUserManagerment_SelectedIndexChanged);
            this.LvwUserManagerment.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvwUserManagerment_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refeshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 56);
            // 
            // refeshToolStripMenuItem
            // 
            this.refeshToolStripMenuItem.Name = "refeshToolStripMenuItem";
            this.refeshToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.refeshToolStripMenuItem.Text = "Refesh";
            this.refeshToolStripMenuItem.Click += new System.EventHandler(this.RefeshToolStripMenuItem_Click);
            // 
            // FrmUserManagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 338);
            this.Controls.Add(this.LvwUserManagerment);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUserManagerment";
            this.Text = "FrmUserManagerment";
            this.Load += new System.EventHandler(this.FrmUserManagerment_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvwUserManagerment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refeshToolStripMenuItem;
    }
}