﻿namespace iss_assignment
{
    partial class FrmProfileResourceUser
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
            this.DgvProfileResourceUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfileResourceUser)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProfileResourceUser
            // 
            this.DgvProfileResourceUser.AllowUserToAddRows = false;
            this.DgvProfileResourceUser.AllowUserToDeleteRows = false;
            this.DgvProfileResourceUser.AllowUserToOrderColumns = true;
            this.DgvProfileResourceUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProfileResourceUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvProfileResourceUser.Location = new System.Drawing.Point(0, 0);
            this.DgvProfileResourceUser.Name = "DgvProfileResourceUser";
            this.DgvProfileResourceUser.ReadOnly = true;
            this.DgvProfileResourceUser.RowTemplate.Height = 24;
            this.DgvProfileResourceUser.Size = new System.Drawing.Size(772, 451);
            this.DgvProfileResourceUser.TabIndex = 0;
            // 
            // FrmProfileResourceUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 451);
            this.Controls.Add(this.DgvProfileResourceUser);
            this.Name = "FrmProfileResourceUser";
            this.Text = "Profile Resource User";
            this.Load += new System.EventHandler(this.FrmProfileResourceUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfileResourceUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProfileResourceUser;
    }
}