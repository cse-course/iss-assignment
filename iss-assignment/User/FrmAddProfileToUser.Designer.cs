namespace iss_assignment
{
    partial class FrmAddProfileToUser
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
            this.LvwProfile = new System.Windows.Forms.ListView();
            this.BtnChange = new System.Windows.Forms.Button();
            this.LblCaution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LvwProfile
            // 
            this.LvwProfile.CheckBoxes = true;
            this.LvwProfile.Location = new System.Drawing.Point(5, 51);
            this.LvwProfile.MultiSelect = false;
            this.LvwProfile.Name = "LvwProfile";
            this.LvwProfile.Size = new System.Drawing.Size(404, 250);
            this.LvwProfile.TabIndex = 0;
            this.LvwProfile.UseCompatibleStateImageBehavior = false;
            this.LvwProfile.View = System.Windows.Forms.View.Details;
            // 
            // BtnChange
            // 
            this.BtnChange.Location = new System.Drawing.Point(334, 25);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(75, 23);
            this.BtnChange.TabIndex = 1;
            this.BtnChange.Text = "Change";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // LblCaution
            // 
            this.LblCaution.AutoSize = true;
            this.LblCaution.Location = new System.Drawing.Point(2, 9);
            this.LblCaution.Name = "LblCaution";
            this.LblCaution.Size = new System.Drawing.Size(35, 13);
            this.LblCaution.TabIndex = 2;
            this.LblCaution.Text = "label1";
            // 
            // FrmAddProfileToUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 306);
            this.Controls.Add(this.LblCaution);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.LvwProfile);
            this.Name = "FrmAddProfileToUser";
            this.Text = "FrmAddProfileToUser";
            this.Load += new System.EventHandler(this.FrmAddProfileToUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LvwProfile;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Label LblCaution;
    }
}