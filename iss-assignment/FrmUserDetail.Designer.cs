namespace iss_assignment
{
    partial class FrmUserDetail
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
            this.DgvUserDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvUserDetail
            // 
            this.DgvUserDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUserDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvUserDetail.Location = new System.Drawing.Point(0, 0);
            this.DgvUserDetail.Name = "DgvUserDetail";
            this.DgvUserDetail.RowTemplate.Height = 24;
            this.DgvUserDetail.Size = new System.Drawing.Size(710, 457);
            this.DgvUserDetail.TabIndex = 0;
            // 
            // FrmUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 457);
            this.Controls.Add(this.DgvUserDetail);
            this.Name = "FrmUserDetail";
            this.Text = "FrmUserDetail";
            this.Load += new System.EventHandler(this.FrmUserDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUserDetail;
    }
}