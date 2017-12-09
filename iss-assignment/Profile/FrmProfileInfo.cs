using BLL;
using Domain;
using System;
using System.Windows.Forms;

namespace iss_assignment
{
    public partial class FrmProfileInfo : Form
    {
        private static String CREATE_PROFILE = "CREATE PROFILE";
        private IProfileBLL profileBLL;

        private IPrivilegeBLL privilegeBLL;

        private UserPrincipal currentUser;

        private Profile profile;

        public FrmProfileInfo(IPrivilegeBLL privilegeBLL, IProfileBLL profileBLL, UserPrincipal currentUser)
        {
            this.privilegeBLL = privilegeBLL;
            this.profileBLL = profileBLL;
            this.currentUser = currentUser;
            InitializeComponent();
        }

        public FrmProfileInfo(IProfileBLL profileBLL, Profile profile)
        {
            this.profileBLL = profileBLL;
            this.profile = profile;
            InitializeComponent();
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.SaveProfile();
        }

        private void BtnDefault_Click(object sender, EventArgs e)
        {
            this.SetDefault();
        }

        private void SetDefault()
        {
            this.SetValue(ProfileValue.DEFAULT);
        }

        private void SetEmpty()
        {
            this.SetValue("");
        }

        private void SetUnlimited()
        {
            this.SetValue(ProfileValue.UNLIMITED);
            this.TxtPasswordVerifyFunction.Text = ProfileValue.NULL;
        }

       

        private void FrmAddProfile_Load(object sender, EventArgs e)
        {
            if (this.profile != null)
            {
                this.SetValue(this.profile);
            }
        }

        /// <summary>
        /// To create a profile, you must have the CREATE PROFILE system privilege.
        /// To specify resource limits for a user, you must:
        ///     Enable resource limits dynamically with the ALTER SYSTEM statement 
        ///     or with the initialization parameter RESOURCE_LIMIT. 
        ///     This parameter does not apply to password resources. Password resources are always enabled.
        ///     
        ///     Create a profile that defines the limits using the CREATE PROFILE statement
        ///     Assign the profile to the user using the CREATE USER or ALTER USER statement
        /// </summary>
        private void SaveProfile()
        {
            Privilege privilege = new Privilege
            {
                Name = CREATE_PROFILE
            };
            Boolean rs = this.privilegeBLL.HasSystemPrivilege(this.currentUser.UserName, privilege);
            if (rs)
            {
                ProfileBuilder builder = new ProfileBuilder(this.TxtName.Text);
                Profile profile = builder
                    .SessionsPerUser(this.TxtSessionsPerUser.Text)
                    .CPUPerSession(this.TxtCPUPerSession.Text)
                    .CPUPerCall(this.TxtCPUPerCall.Text)
                    .ConnectTime(this.TxtConnectTime.Text)
                    .IdleTime(this.TxtIdleTime.Text)
                    .LogicalReadsPerSession(this.TxtLogicalReadsPerSession.Text)
                    .LogicalReadsPerCall(this.TxtLogicalReadsPerCall.Text)
                    .PrivateSGA(this.TxtPrivateSGA.Text)
                    .CompositeLimit(this.TxtCompositeLimit.Text)
                    .FailedLoginAttemps(this.TxtFailedLoginAttemps.Text)
                    .PasswordLifeTime(this.TxtPasswordLifeTime.Text)
                    .PasswordReuseTime(this.TxtPasswordReuseTime.Text)
                    .PasswordReuseMax(this.TxtPasswordReuseMax.Text)
                    .PasswordLockTime(this.TxtPasswordLockTime.Text)
                    .PasswordGraceTime(this.TxtPasswordGraceTime.Text)
                    .PasswordVerifyFunction(this.TxtPasswordVerifyFunction.Text)
                    .Build();
                //Case: Update
                if (this.profile != null)
                {
                    this.SetEnable(false);
                    this.profileBLL.Update(profile);
                    MessageBox.Show(String.Join(" ", "Update profile", profile.Name, "sucessfull!"));
                    this.SetEnable(true);
                }
                else
                {
                    this.SetEnable(false);
                    this.profileBLL.Add(profile);
                    MessageBox.Show(String.Join(" ", "Add profile", profile.Name, "sucessfull!"));
                    this.SetEnable(true);
                }
                this.profile = profile;
            }
            else
            {
                MessageBox.Show(String.Join(" ", "You don't have ", CREATE_PROFILE , "privilege!"));
            }
        }

        private void BtnUnlimited_Click(object sender, EventArgs e)
        {
            this.SetUnlimited();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.SetEmpty();
        }

        private void SetValue(String value)
        {

            #region resource_parameters
            this.TxtSessionsPerUser.Text = value;
            this.TxtCPUPerSession.Text = value;
            this.TxtCPUPerCall.Text = value;
            this.TxtConnectTime.Text = value;
            this.TxtIdleTime.Text = value;
            this.TxtLogicalReadsPerSession.Text = value;
            this.TxtLogicalReadsPerCall.Text = value;
            this.TxtCompositeLimit.Text = value;
            this.TxtPrivateSGA.Text = value;
            #endregion resource_parameters

            #region password_parameters 
            this.TxtFailedLoginAttemps.Text = value;
            this.TxtPasswordLifeTime.Text = value;
            this.TxtPasswordReuseTime.Text = value;
            this.TxtPasswordReuseMax.Text = value;
            this.TxtPasswordLockTime.Text = value;
            this.TxtPasswordGraceTime.Text = value;
            this.TxtPasswordVerifyFunction.Text = value;
            #endregion password_parameters 

        }

        private void SetValue(Profile profile)
        {
            this.TxtName.Text = profile.Name;

            #region resource_parameters
            this.TxtSessionsPerUser.Text = profile.SessionsPerUser;
            this.TxtCPUPerSession.Text = profile.CPUPerSession;
            this.TxtCPUPerCall.Text = profile.CPUPerCall;
            this.TxtConnectTime.Text = profile.ConnectTime;
            this.TxtIdleTime.Text = profile.IdleTime;
            this.TxtLogicalReadsPerSession.Text = profile.LogicalReadsPerSession;
            this.TxtLogicalReadsPerCall.Text = profile.LogicalReadsPerCall;
            this.TxtCompositeLimit.Text = profile.CompositeLimit;
            this.TxtPrivateSGA.Text = profile.PrivateSGA;
            #endregion resource_parameters

            #region password_parameters 
            this.TxtFailedLoginAttemps.Text = profile.FailedLoginAttemps;
            this.TxtPasswordLifeTime.Text = profile.PasswordLifeTime;
            this.TxtPasswordReuseTime.Text = profile.PasswordReuseTime;
            this.TxtPasswordReuseMax.Text = profile.PasswordReuseMax;
            this.TxtPasswordLockTime.Text = profile.PasswordLockTime;
            this.TxtPasswordGraceTime.Text = profile.PasswordGraceTime;
            this.TxtPasswordVerifyFunction.Text = profile.PasswordVerifyFunction;
            #endregion password_parameters 

        }

        private void SetEnable(Boolean value)
        {
            this.TxtName.Enabled = value;

            #region resource_parameters
            this.TxtSessionsPerUser.Enabled = value;
            this.TxtCPUPerSession.Enabled = value;
            this.TxtCPUPerCall.Enabled = value;
            this.TxtConnectTime.Enabled = value;
            this.TxtIdleTime.Enabled = value;
            this.TxtLogicalReadsPerSession.Enabled = value;
            this.TxtLogicalReadsPerCall.Enabled = value;
            this.TxtCompositeLimit.Enabled = value;
            this.TxtPrivateSGA.Enabled = value;
            #endregion resource_parameters

            #region password_parameters 
            this.TxtFailedLoginAttemps.Enabled = value;
            this.TxtPasswordLifeTime.Enabled = value;
            this.TxtPasswordReuseTime.Enabled = value;
            this.TxtPasswordReuseMax.Enabled = value;
            this.TxtPasswordLockTime.Enabled = value;
            this.TxtPasswordGraceTime.Enabled = value;
            this.TxtPasswordVerifyFunction.Enabled = value;
            #endregion password_parameters 
        }
    }
}
