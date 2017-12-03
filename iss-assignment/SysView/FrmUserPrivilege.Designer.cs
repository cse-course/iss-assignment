namespace iss_assignment
{
    partial class FrmUserPrivilege
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
            this.DgvUserPrivilege = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserPrivilege)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvUserPrivilege
            // 
            this.DgvUserPrivilege.AllowUserToAddRows = false;
            this.DgvUserPrivilege.AllowUserToDeleteRows = false;
            this.DgvUserPrivilege.AllowUserToOrderColumns = true;
            this.DgvUserPrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUserPrivilege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvUserPrivilege.Location = new System.Drawing.Point(0, 0);
            this.DgvUserPrivilege.Name = "DgvUserPrivilege";
            this.DgvUserPrivilege.ReadOnly = true;
            this.DgvUserPrivilege.RowTemplate.Height = 24;
            this.DgvUserPrivilege.Size = new System.Drawing.Size(941, 547);
            this.DgvUserPrivilege.TabIndex = 0;
            // 
            // FrmUserPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 547);
            this.Controls.Add(this.DgvUserPrivilege);
            this.Name = "FrmUserPrivilege";
            this.Text = "FrmUserPrivilege";
            this.Load += new System.EventHandler(this.FrmUserPrivilege_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserPrivilege)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUserPrivilege;
    }
}