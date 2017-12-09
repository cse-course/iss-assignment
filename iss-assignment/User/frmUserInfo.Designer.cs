namespace iss_assignment
{
    partial class frmUserInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.CbxAccountLock = new System.Windows.Forms.CheckBox();
            this.lblDateJoin = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LvwProfile = new System.Windows.Forms.ListView();
            this.BtnChangeProfile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAddRole = new System.Windows.Forms.Button();
            this.LvwRole = new System.Windows.Forms.ListView();
            this.BtnRemoveRole = new System.Windows.Forms.Button();
            this.CbxIsAdmin = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbxIsAdmin);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.CbxAccountLock);
            this.groupBox1.Controls.Add(this.lblDateJoin);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.txtFullname);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtAdress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(128, 287);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // CbxAccountLock
            // 
            this.CbxAccountLock.AutoSize = true;
            this.CbxAccountLock.Location = new System.Drawing.Point(21, 257);
            this.CbxAccountLock.Name = "CbxAccountLock";
            this.CbxAccountLock.Size = new System.Drawing.Size(92, 17);
            this.CbxAccountLock.TabIndex = 8;
            this.CbxAccountLock.Text = "Account lock.";
            this.CbxAccountLock.UseVisualStyleBackColor = true;
            // 
            // lblDateJoin
            // 
            this.lblDateJoin.AutoSize = true;
            this.lblDateJoin.Location = new System.Drawing.Point(98, 229);
            this.lblDateJoin.Name = "lblDateJoin";
            this.lblDateJoin.Size = new System.Drawing.Size(49, 13);
            this.lblDateJoin.TabIndex = 14;
            this.lblDateJoin.Text = "Date join";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(209, 286);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(209, 286);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(98, 37);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(101, 65);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(183, 20);
            this.txtFullname.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(101, 108);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(101, 144);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(183, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(101, 189);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(183, 20);
            this.txtAdress.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Join";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fullname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LvwProfile);
            this.groupBox2.Controls.Add(this.BtnChangeProfile);
            this.groupBox2.Location = new System.Drawing.Point(334, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 316);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profiles";
            // 
            // LvwProfile
            // 
            this.LvwProfile.Location = new System.Drawing.Point(6, 16);
            this.LvwProfile.Name = "LvwProfile";
            this.LvwProfile.Size = new System.Drawing.Size(194, 271);
            this.LvwProfile.TabIndex = 11;
            this.LvwProfile.UseCompatibleStateImageBehavior = false;
            this.LvwProfile.View = System.Windows.Forms.View.Details;
            // 
            // BtnChangeProfile
            // 
            this.BtnChangeProfile.Location = new System.Drawing.Point(140, 287);
            this.BtnChangeProfile.Name = "BtnChangeProfile";
            this.BtnChangeProfile.Size = new System.Drawing.Size(54, 23);
            this.BtnChangeProfile.TabIndex = 12;
            this.BtnChangeProfile.Text = "Change";
            this.BtnChangeProfile.UseVisualStyleBackColor = true;
            this.BtnChangeProfile.Click += new System.EventHandler(this.BtnChangeProfile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnAddRole);
            this.groupBox3.Controls.Add(this.LvwRole);
            this.groupBox3.Controls.Add(this.BtnRemoveRole);
            this.groupBox3.Location = new System.Drawing.Point(540, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 316);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Roles";
            // 
            // BtnAddRole
            // 
            this.BtnAddRole.Location = new System.Drawing.Point(136, 286);
            this.BtnAddRole.Name = "BtnAddRole";
            this.BtnAddRole.Size = new System.Drawing.Size(54, 23);
            this.BtnAddRole.TabIndex = 14;
            this.BtnAddRole.Text = "Add";
            this.BtnAddRole.UseVisualStyleBackColor = true;
            this.BtnAddRole.Click += new System.EventHandler(this.BtnAddRole_Click);
            // 
            // LvwRole
            // 
            this.LvwRole.Location = new System.Drawing.Point(0, 16);
            this.LvwRole.Name = "LvwRole";
            this.LvwRole.Size = new System.Drawing.Size(194, 268);
            this.LvwRole.TabIndex = 13;
            this.LvwRole.UseCompatibleStateImageBehavior = false;
            this.LvwRole.View = System.Windows.Forms.View.Details;
            // 
            // BtnRemoveRole
            // 
            this.BtnRemoveRole.Location = new System.Drawing.Point(72, 287);
            this.BtnRemoveRole.Name = "BtnRemoveRole";
            this.BtnRemoveRole.Size = new System.Drawing.Size(58, 23);
            this.BtnRemoveRole.TabIndex = 15;
            this.BtnRemoveRole.Text = "Remove";
            this.BtnRemoveRole.UseVisualStyleBackColor = true;
            this.BtnRemoveRole.Click += new System.EventHandler(this.BtnRemoveRole_Click);
            // 
            // CbxIsAdmin
            // 
            this.CbxIsAdmin.AutoSize = true;
            this.CbxIsAdmin.Location = new System.Drawing.Point(143, 257);
            this.CbxIsAdmin.Name = "CbxIsAdmin";
            this.CbxIsAdmin.Size = new System.Drawing.Size(69, 17);
            this.CbxIsAdmin.TabIndex = 15;
            this.CbxIsAdmin.Text = "Is Admin.";
            this.CbxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 343);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUserInfo";
            this.Text = "frmUserInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUserInfo_FormClosing);
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDateJoin;
        private System.Windows.Forms.ListView LvwProfile;
        private System.Windows.Forms.ListView LvwRole;
        private System.Windows.Forms.CheckBox CbxAccountLock;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnChangeProfile;
        private System.Windows.Forms.Button BtnAddRole;
        private System.Windows.Forms.Button BtnRemoveRole;
        private System.Windows.Forms.CheckBox CbxIsAdmin;
    }
}