namespace iss_assignment.Profile
{
    partial class FrmAddProfile
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtPrivateSGA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCompositeLimit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtLogicalReadsPerCall = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtLogicalReadsPerSession = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtIdleTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtConnectTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCPUPerCall = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCPUPerSession = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSessionsPerUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtPasswordVerifyFunction = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtPasswordGraceTime = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtPasswordLockTime = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtPasswordReuseMax = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtPasswordReuseTime = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtPasswordLifeTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtFailedLoginAttemps = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDefault = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(206, 28);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(264, 22);
            this.TxtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtPrivateSGA);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TxtCompositeLimit);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtLogicalReadsPerCall);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxtLogicalReadsPerSession);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtIdleTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtConnectTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtCPUPerCall);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtCPUPerSession);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtSessionsPerUser);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 291);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resource Parameters";
            // 
            // TxtPrivateSGA
            // 
            this.TxtPrivateSGA.Location = new System.Drawing.Point(206, 245);
            this.TxtPrivateSGA.Name = "TxtPrivateSGA";
            this.TxtPrivateSGA.Size = new System.Drawing.Size(264, 22);
            this.TxtPrivateSGA.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Private SGA";
            // 
            // TxtCompositeLimit
            // 
            this.TxtCompositeLimit.Location = new System.Drawing.Point(206, 217);
            this.TxtCompositeLimit.Name = "TxtCompositeLimit";
            this.TxtCompositeLimit.Size = new System.Drawing.Size(264, 22);
            this.TxtCompositeLimit.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Composite Limit";
            // 
            // TxtLogicalReadsPerCall
            // 
            this.TxtLogicalReadsPerCall.Location = new System.Drawing.Point(206, 189);
            this.TxtLogicalReadsPerCall.Name = "TxtLogicalReadsPerCall";
            this.TxtLogicalReadsPerCall.Size = new System.Drawing.Size(264, 22);
            this.TxtLogicalReadsPerCall.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Logical Reads Per Call";
            // 
            // TxtLogicalReadsPerSession
            // 
            this.TxtLogicalReadsPerSession.Location = new System.Drawing.Point(206, 161);
            this.TxtLogicalReadsPerSession.Name = "TxtLogicalReadsPerSession";
            this.TxtLogicalReadsPerSession.Size = new System.Drawing.Size(264, 22);
            this.TxtLogicalReadsPerSession.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Logical Reads Per Session";
            // 
            // TxtIdleTime
            // 
            this.TxtIdleTime.Location = new System.Drawing.Point(206, 133);
            this.TxtIdleTime.Name = "TxtIdleTime";
            this.TxtIdleTime.Size = new System.Drawing.Size(264, 22);
            this.TxtIdleTime.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Idle Time";
            // 
            // TxtConnectTime
            // 
            this.TxtConnectTime.Location = new System.Drawing.Point(206, 105);
            this.TxtConnectTime.Name = "TxtConnectTime";
            this.TxtConnectTime.Size = new System.Drawing.Size(264, 22);
            this.TxtConnectTime.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Connect Time";
            // 
            // TxtCPUPerCall
            // 
            this.TxtCPUPerCall.Location = new System.Drawing.Point(206, 77);
            this.TxtCPUPerCall.Name = "TxtCPUPerCall";
            this.TxtCPUPerCall.Size = new System.Drawing.Size(264, 22);
            this.TxtCPUPerCall.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "CPU Per Call";
            // 
            // TxtCPUPerSession
            // 
            this.TxtCPUPerSession.Location = new System.Drawing.Point(206, 49);
            this.TxtCPUPerSession.Name = "TxtCPUPerSession";
            this.TxtCPUPerSession.Size = new System.Drawing.Size(264, 22);
            this.TxtCPUPerSession.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPU Per Session";
            // 
            // TxtSessionsPerUser
            // 
            this.TxtSessionsPerUser.Location = new System.Drawing.Point(206, 21);
            this.TxtSessionsPerUser.Name = "TxtSessionsPerUser";
            this.TxtSessionsPerUser.Size = new System.Drawing.Size(264, 22);
            this.TxtSessionsPerUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sessions Per User";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtPasswordVerifyFunction);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.TxtPasswordGraceTime);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.TxtPasswordLockTime);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.TxtPasswordReuseMax);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.TxtPasswordReuseTime);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.TxtPasswordLifeTime);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.TxtFailedLoginAttemps);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 241);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Password Parameters";
            // 
            // TxtPasswordVerifyFunction
            // 
            this.TxtPasswordVerifyFunction.Location = new System.Drawing.Point(206, 189);
            this.TxtPasswordVerifyFunction.Name = "TxtPasswordVerifyFunction";
            this.TxtPasswordVerifyFunction.Size = new System.Drawing.Size(264, 22);
            this.TxtPasswordVerifyFunction.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(167, 17);
            this.label17.TabIndex = 2;
            this.label17.Text = "Password Verify Function";
            // 
            // TxtPasswordGraceTime
            // 
            this.TxtPasswordGraceTime.Location = new System.Drawing.Point(206, 161);
            this.TxtPasswordGraceTime.Name = "TxtPasswordGraceTime";
            this.TxtPasswordGraceTime.Size = new System.Drawing.Size(264, 22);
            this.TxtPasswordGraceTime.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "Password Grace Time";
            // 
            // TxtPasswordLockTime
            // 
            this.TxtPasswordLockTime.Location = new System.Drawing.Point(206, 133);
            this.TxtPasswordLockTime.Name = "TxtPasswordLockTime";
            this.TxtPasswordLockTime.Size = new System.Drawing.Size(264, 22);
            this.TxtPasswordLockTime.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "Password Lock Time";
            // 
            // TxtPasswordReuseMax
            // 
            this.TxtPasswordReuseMax.Location = new System.Drawing.Point(206, 105);
            this.TxtPasswordReuseMax.Name = "TxtPasswordReuseMax";
            this.TxtPasswordReuseMax.Size = new System.Drawing.Size(264, 22);
            this.TxtPasswordReuseMax.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Password Reuse Max";
            // 
            // TxtPasswordReuseTime
            // 
            this.TxtPasswordReuseTime.Location = new System.Drawing.Point(206, 77);
            this.TxtPasswordReuseTime.Name = "TxtPasswordReuseTime";
            this.TxtPasswordReuseTime.Size = new System.Drawing.Size(264, 22);
            this.TxtPasswordReuseTime.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Password Reuse Time";
            // 
            // TxtPasswordLifeTime
            // 
            this.TxtPasswordLifeTime.Location = new System.Drawing.Point(206, 49);
            this.TxtPasswordLifeTime.Name = "TxtPasswordLifeTime";
            this.TxtPasswordLifeTime.Size = new System.Drawing.Size(264, 22);
            this.TxtPasswordLifeTime.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Password Life Time";
            // 
            // TxtFailedLoginAttemps
            // 
            this.TxtFailedLoginAttemps.Location = new System.Drawing.Point(206, 21);
            this.TxtFailedLoginAttemps.Name = "TxtFailedLoginAttemps";
            this.TxtFailedLoginAttemps.Size = new System.Drawing.Size(264, 22);
            this.TxtFailedLoginAttemps.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Failed Login Attemps";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(312, 681);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(122, 43);
            this.BtnSave.TabIndex = 19;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDefault
            // 
            this.BtnDefault.Location = new System.Drawing.Point(120, 681);
            this.BtnDefault.Name = "BtnDefault";
            this.BtnDefault.Size = new System.Drawing.Size(122, 43);
            this.BtnDefault.TabIndex = 18;
            this.BtnDefault.Text = "Default";
            this.BtnDefault.UseVisualStyleBackColor = true;
            this.BtnDefault.Click += new System.EventHandler(this.BtnDefault_Click);
            // 
            // FrmAddProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 755);
            this.Controls.Add(this.BtnDefault);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAddProfile";
            this.Text = "FrmAddProfile";
            this.Load += new System.EventHandler(this.FrmAddProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtLogicalReadsPerSession;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtIdleTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtConnectTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCPUPerCall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCPUPerSession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSessionsPerUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCompositeLimit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtLogicalReadsPerCall;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPrivateSGA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtPasswordVerifyFunction;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtPasswordGraceTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtPasswordLockTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtPasswordReuseMax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtPasswordReuseTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtPasswordLifeTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtFailedLoginAttemps;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDefault;
    }
}