﻿namespace iss_assignment
{
    partial class FrmAddUser
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxIsAdmin = new System.Windows.Forms.CheckBox();
            this.CbxBlockAccount = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CbbTemporaryTablespace = new System.Windows.Forms.ComboBox();
            this.CbbDefaultTablespace = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxUsers = new System.Windows.Forms.CheckBox();
            this.CbxSystem = new System.Windows.Forms.CheckBox();
            this.CbxSysaux = new System.Windows.Forms.CheckBox();
            this.CbxExample = new System.Windows.Forms.CheckBox();
            this.TxtExample = new System.Windows.Forms.TextBox();
            this.TxtUsers = new System.Windows.Forms.TextBox();
            this.TxtSysaux = new System.Windows.Forms.TextBox();
            this.TxtSystem = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LvwRole = new System.Windows.Forms.ListView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LvwProfile = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(733, 590);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(865, 590);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(184, 58);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(243, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(184, 92);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(243, 22);
            this.txtPassword2.TabIndex = 3;
            this.txtPassword2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Comfirm Passowrd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(184, 23);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(243, 22);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbxIsAdmin);
            this.groupBox1.Controls.Add(this.CbxBlockAccount);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword2);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(471, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // CbxIsAdmin
            // 
            this.CbxIsAdmin.AutoSize = true;
            this.CbxIsAdmin.Location = new System.Drawing.Point(184, 143);
            this.CbxIsAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxIsAdmin.Name = "CbxIsAdmin";
            this.CbxIsAdmin.Size = new System.Drawing.Size(91, 21);
            this.CbxIsAdmin.TabIndex = 19;
            this.CbxIsAdmin.Text = "Is Admin?";
            this.CbxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // CbxBlockAccount
            // 
            this.CbxBlockAccount.AutoSize = true;
            this.CbxBlockAccount.Location = new System.Drawing.Point(12, 143);
            this.CbxBlockAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxBlockAccount.Name = "CbxBlockAccount";
            this.CbxBlockAccount.Size = new System.Drawing.Size(140, 21);
            this.CbxBlockAccount.TabIndex = 4;
            this.CbxBlockAccount.Text = "Account is block?";
            this.CbxBlockAccount.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CbbTemporaryTablespace);
            this.groupBox2.Controls.Add(this.CbbDefaultTablespace);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(499, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(471, 97);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tablespaces";
            // 
            // CbbTemporaryTablespace
            // 
            this.CbbTemporaryTablespace.FormattingEnabled = true;
            this.CbbTemporaryTablespace.Location = new System.Drawing.Point(208, 62);
            this.CbbTemporaryTablespace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbbTemporaryTablespace.Name = "CbbTemporaryTablespace";
            this.CbbTemporaryTablespace.Size = new System.Drawing.Size(243, 24);
            this.CbbTemporaryTablespace.TabIndex = 6;
            // 
            // CbbDefaultTablespace
            // 
            this.CbbDefaultTablespace.FormattingEnabled = true;
            this.CbbDefaultTablespace.Location = new System.Drawing.Point(208, 28);
            this.CbbDefaultTablespace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbbDefaultTablespace.Name = "CbbDefaultTablespace";
            this.CbbDefaultTablespace.Size = new System.Drawing.Size(243, 24);
            this.CbbDefaultTablespace.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Temporary Tablespace";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Default Tablespace";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.CbxUsers);
            this.groupBox3.Controls.Add(this.CbxSystem);
            this.groupBox3.Controls.Add(this.CbxSysaux);
            this.groupBox3.Controls.Add(this.CbxExample);
            this.groupBox3.Controls.Add(this.TxtExample);
            this.groupBox3.Controls.Add(this.TxtUsers);
            this.groupBox3.Controls.Add(this.TxtSysaux);
            this.groupBox3.Controls.Add(this.TxtSystem);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(499, 119);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(471, 226);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quotas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Unlimited";
            // 
            // CbxUsers
            // 
            this.CbxUsers.AutoSize = true;
            this.CbxUsers.Location = new System.Drawing.Point(143, 192);
            this.CbxUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxUsers.Name = "CbxUsers";
            this.CbxUsers.Size = new System.Drawing.Size(18, 17);
            this.CbxUsers.TabIndex = 17;
            this.CbxUsers.UseVisualStyleBackColor = true;
            this.CbxUsers.CheckedChanged += new System.EventHandler(this.CbxUsers_CheckedChanged);
            // 
            // CbxSystem
            // 
            this.CbxSystem.AutoSize = true;
            this.CbxSystem.Location = new System.Drawing.Point(143, 159);
            this.CbxSystem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxSystem.Name = "CbxSystem";
            this.CbxSystem.Size = new System.Drawing.Size(18, 17);
            this.CbxSystem.TabIndex = 11;
            this.CbxSystem.UseVisualStyleBackColor = true;
            this.CbxSystem.CheckedChanged += new System.EventHandler(this.CbxSystem_CheckedChanged);
            // 
            // CbxSysaux
            // 
            this.CbxSysaux.AutoSize = true;
            this.CbxSysaux.Location = new System.Drawing.Point(143, 116);
            this.CbxSysaux.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxSysaux.Name = "CbxSysaux";
            this.CbxSysaux.Size = new System.Drawing.Size(18, 17);
            this.CbxSysaux.TabIndex = 9;
            this.CbxSysaux.UseVisualStyleBackColor = true;
            this.CbxSysaux.CheckedChanged += new System.EventHandler(this.CbxSysaux_CheckedChanged);
            // 
            // CbxExample
            // 
            this.CbxExample.AutoSize = true;
            this.CbxExample.Location = new System.Drawing.Point(143, 75);
            this.CbxExample.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxExample.Name = "CbxExample";
            this.CbxExample.Size = new System.Drawing.Size(18, 17);
            this.CbxExample.TabIndex = 7;
            this.CbxExample.UseVisualStyleBackColor = true;
            this.CbxExample.CheckedChanged += new System.EventHandler(this.CbxExample_CheckedChanged);
            // 
            // TxtExample
            // 
            this.TxtExample.Location = new System.Drawing.Point(208, 68);
            this.TxtExample.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtExample.Name = "TxtExample";
            this.TxtExample.Size = new System.Drawing.Size(243, 22);
            this.TxtExample.TabIndex = 8;
            // 
            // TxtUsers
            // 
            this.TxtUsers.Location = new System.Drawing.Point(208, 192);
            this.TxtUsers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtUsers.Name = "TxtUsers";
            this.TxtUsers.Size = new System.Drawing.Size(243, 22);
            this.TxtUsers.TabIndex = 18;
            // 
            // TxtSysaux
            // 
            this.TxtSysaux.Location = new System.Drawing.Point(208, 108);
            this.TxtSysaux.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtSysaux.Name = "TxtSysaux";
            this.TxtSysaux.Size = new System.Drawing.Size(243, 22);
            this.TxtSysaux.TabIndex = 10;
            // 
            // TxtSystem
            // 
            this.TxtSystem.Location = new System.Drawing.Point(208, 151);
            this.TxtSystem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtSystem.Name = "TxtSystem";
            this.TxtSystem.Size = new System.Drawing.Size(243, 22);
            this.TxtSystem.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 36);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tablespace";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(204, 36);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Quota(M)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 117);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "SYSAUX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "USERS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "SYSTEM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "EXAMPLE";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LvwRole);
            this.groupBox4.Location = new System.Drawing.Point(16, 193);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(471, 425);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Roles";
            // 
            // LvwRole
            // 
            this.LvwRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwRole.FullRowSelect = true;
            this.LvwRole.GridLines = true;
            this.LvwRole.Location = new System.Drawing.Point(4, 19);
            this.LvwRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LvwRole.Name = "LvwRole";
            this.LvwRole.Size = new System.Drawing.Size(463, 402);
            this.LvwRole.TabIndex = 20;
            this.LvwRole.UseCompatibleStateImageBehavior = false;
            this.LvwRole.View = System.Windows.Forms.View.Details;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LvwProfile);
            this.groupBox5.Location = new System.Drawing.Point(495, 347);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(475, 235);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Profiles";
            // 
            // LvwProfile
            // 
            this.LvwProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwProfile.FullRowSelect = true;
            this.LvwProfile.GridLines = true;
            this.LvwProfile.Location = new System.Drawing.Point(4, 19);
            this.LvwProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LvwProfile.MultiSelect = false;
            this.LvwProfile.Name = "LvwProfile";
            this.LvwProfile.Size = new System.Drawing.Size(467, 212);
            this.LvwProfile.TabIndex = 19;
            this.LvwProfile.UseCompatibleStateImageBehavior = false;
            this.LvwProfile.View = System.Windows.Forms.View.Details;
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 633);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAddUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.FrmAddUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CbxBlockAccount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CbbTemporaryTablespace;
        private System.Windows.Forms.ComboBox CbbDefaultTablespace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView LvwRole;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView LvwProfile;
        private System.Windows.Forms.TextBox TxtExample;
        private System.Windows.Forms.TextBox TxtUsers;
        private System.Windows.Forms.TextBox TxtSysaux;
        private System.Windows.Forms.TextBox TxtSystem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CbxUsers;
        private System.Windows.Forms.CheckBox CbxSystem;
        private System.Windows.Forms.CheckBox CbxSysaux;
        private System.Windows.Forms.CheckBox CbxExample;
        private System.Windows.Forms.CheckBox CbxIsAdmin;
    }
}