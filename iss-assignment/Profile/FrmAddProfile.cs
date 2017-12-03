using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iss_assignment.Profile
{
    public partial class FrmAddProfile : Form
    {
        private IProfileBLL profileBLL;
        public FrmAddProfile(IProfileBLL profileBLL)
        {
            this.profileBLL = profileBLL;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnDefault_Click(object sender, EventArgs e)
        {
            this.SetDefault();
        }

        private void SetDefault()
        {
            this.TxtName.Text = "";
            this.SetValue("DEFAULT");
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

        private void FrmAddProfile_Load(object sender, EventArgs e)
        {
            
        }
    }
}
