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
            this.LvwUserManagerment = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // LvwUserManagerment
            // 
            this.LvwUserManagerment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwUserManagerment.FullRowSelect = true;
            this.LvwUserManagerment.GridLines = true;
            this.LvwUserManagerment.Location = new System.Drawing.Point(0, 0);
            this.LvwUserManagerment.Name = "LvwUserManagerment";
            this.LvwUserManagerment.Size = new System.Drawing.Size(629, 275);
            this.LvwUserManagerment.TabIndex = 0;
            this.LvwUserManagerment.UseCompatibleStateImageBehavior = false;
            this.LvwUserManagerment.View = System.Windows.Forms.View.Details;
            this.LvwUserManagerment.SelectedIndexChanged += new System.EventHandler(this.LvwUserManagerment_SelectedIndexChanged);
            this.LvwUserManagerment.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvwUserManagerment_MouseDoubleClick);
            // 
            // FrmUserManagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 275);
            this.Controls.Add(this.LvwUserManagerment);
            this.Name = "FrmUserManagerment";
            this.Text = "FrmUserManagerment";
            this.Load += new System.EventHandler(this.FrmUserManagerment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvwUserManagerment;
    }
}