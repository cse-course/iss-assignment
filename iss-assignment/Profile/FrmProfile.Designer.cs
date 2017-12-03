namespace iss_assignment
{
    partial class FrmProfile
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnDeleteCascade = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvwProfile
            // 
            this.LvwProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwProfile.FullRowSelect = true;
            this.LvwProfile.GridLines = true;
            this.LvwProfile.Location = new System.Drawing.Point(3, 18);
            this.LvwProfile.Name = "LvwProfile";
            this.LvwProfile.Size = new System.Drawing.Size(448, 396);
            this.LvwProfile.TabIndex = 1;
            this.LvwProfile.UseCompatibleStateImageBehavior = false;
            this.LvwProfile.View = System.Windows.Forms.View.Details;
            this.LvwProfile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvwProfile_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LvwProfile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 417);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Profile";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(344, 456);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(113, 43);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(15, 456);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(113, 43);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnDeleteCascade
            // 
            this.BtnDeleteCascade.Location = new System.Drawing.Point(164, 456);
            this.BtnDeleteCascade.Name = "BtnDeleteCascade";
            this.BtnDeleteCascade.Size = new System.Drawing.Size(133, 43);
            this.BtnDeleteCascade.TabIndex = 3;
            this.BtnDeleteCascade.Text = "Delete Cascade";
            this.BtnDeleteCascade.UseVisualStyleBackColor = true;
            this.BtnDeleteCascade.Click += new System.EventHandler(this.BtnDeleteCascade_Click);
            // 
            // FrmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 525);
            this.Controls.Add(this.BtnDeleteCascade);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProfile";
            this.Text = "FrmProfile";
            this.Load += new System.EventHandler(this.FrmProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvwProfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnDeleteCascade;
    }
}