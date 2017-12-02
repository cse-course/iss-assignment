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
            this.DgvUserManagerment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserManagerment)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvUserManagerment
            // 
            this.DgvUserManagerment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUserManagerment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvUserManagerment.Location = new System.Drawing.Point(0, 0);
            this.DgvUserManagerment.Name = "DgvUserManagerment";
            this.DgvUserManagerment.Size = new System.Drawing.Size(629, 275);
            this.DgvUserManagerment.TabIndex = 0;
            // 
            // FrmUserManagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 275);
            this.Controls.Add(this.DgvUserManagerment);
            this.Name = "FrmUserManagerment";
            this.Text = "FrmUserManagerment";
            this.Load += new System.EventHandler(this.FrmUserManagerment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserManagerment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUserManagerment;
    }
}