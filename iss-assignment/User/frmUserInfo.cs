using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace iss_assignment
{
    public partial class frmUserInfo : Form
    {
        private readonly UserManagementBLL view;
        private readonly UserManagementClassicBLL OracleView;
        public frmUserInfo(UserManagementBLL view, UserManagementClassicBLL OracleView)
        {
            this.view = view;
            this.OracleView = OracleView;
            InitializeComponent();
        }

        public string frmParamUsername = "";
        private void LoadEditMode()
        {
            txtAdress.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtFullname.ReadOnly = false;
            txtPhone.ReadOnly = false;
            btnEdit.Visible = false;
            btnSave.Visible = true;
            BtnDelete.Visible = true;
            CbxAccountLock.AutoCheck = true;
            BtnRemoveRole.Enabled = true;
            BtnAddRole.Enabled = true;
            BtnChangeProfile.Enabled = true;
        }

        private void LoadData()
        {
            //Load userinfo
            IEnumerable<USER_MANAGEMENT> userList = this.view.GetUserInfo(frmParamUsername);
            USER_MANAGEMENT user = userList.First();
            lblUsername.Text = user.USERNAME;
            txtEmail.Text = user.EMAIL;
            txtFullname.Text = user.FULL_NAME;
            txtPhone.Text = user.PHONE;
            txtAdress.Text = user.ADDRESS;
            lblDateJoin.Text = user.CREATE_TIME.ToString();
            //load checbox
            CbxAccountLock.Checked = OracleView.IsLock(frmParamUsername);
            //Load granted role
            LoadDataLvwRole();
            //Load granted profile
            LoadDataLvwProfile();
        }

        private void LoadViewMode()
        {
            txtAdress.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtFullname.ReadOnly = true;
            txtPhone.ReadOnly = true;
            btnEdit.Visible = true;
            btnSave.Visible = false;
            BtnDelete.Visible = false;
            CbxAccountLock.AutoCheck = false;
            BtnRemoveRole.Enabled = false;
            BtnAddRole.Enabled = false;
            BtnChangeProfile.Enabled = false;
        }

        private void ClearText()
        {
            txtAdress.Text = "";
            txtEmail.Text = "";
            txtFullname.Text= "";
            txtPhone.Text = "";
            lblUsername.Text = "";
            lblDateJoin.Text = "";
        }
        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            LoadViewMode();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            LoadEditMode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IEnumerable<USER_MANAGEMENT> userList = this.view.GetUserInfo(lblUsername.Text);
            USER_MANAGEMENT user = userList.First();
            user.ADDRESS = txtAdress.Text;
            user.EMAIL = txtEmail.Text;
            user.FULL_NAME = txtFullname.Text;
            user.PHONE = txtPhone.Text;
            this.view.Update(user);
            if (CbxAccountLock.Checked)
            {
                if (!OracleView.IsLock(lblUsername.Text))
                {
                    OracleView.LockAccount(lblUsername.Text);
                }
            }
            else
            {
                if (OracleView.IsLock(lblUsername.Text))
                {
                    OracleView.UnLockAccount(lblUsername.Text);
                }
            }
            ClearText();
            LoadData();
            LoadViewMode();
        }
        private void AddColumnLvwRole()
        {
            LvwRole.GridLines = true;
            LvwRole.CheckBoxes = true;
            LvwRole.Items.Clear();
            LvwRole.Columns.Clear();
            LvwRole.Columns.Add("GRANTED_ROLE", 200);
        }
        private void LoadDataLvwRole()
        {

            AddColumnLvwRole();
            DataSet ds = OracleView.GetGrantedRoleToUser(frmParamUsername);
            DataTable dt = ds.Tables[0];
            ListViewItem it;
            foreach (DataRow dr in dt.Rows)
            {

                it = LvwRole.Items.Add(dr[0].ToString());
            }
        }
        
        private void AddColumnLvwProfile()
        {
            LvwProfile.GridLines = true;
            LvwProfile.Items.Clear();
            LvwProfile.Columns.Clear();
            LvwProfile.Columns.Add("GRANTED_PROFILES", 200);
        }
        private void LoadDataLvwProfile()
        {

            AddColumnLvwProfile();
            DataSet ds = OracleView.GetGrantedProfileToUser(frmParamUsername);
            DataTable dt = ds.Tables[0];
            ListViewItem it;
            foreach (DataRow dr in dt.Rows)
            {

                it = LvwProfile.Items.Add(dr[0].ToString());
    
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            IEnumerable<USER_MANAGEMENT> userList = this.view.GetUserInfo(lblUsername.Text);
            USER_MANAGEMENT user = userList.First();
            this.view.Remove(user);
            this.OracleView.DropOracleUser(lblUsername.Text);
            Hide();
        }

        private void frmUserInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmUserManagerment owner = new FrmUserManagerment(view,  OracleView);
            owner.LoadData();
        }

        private void BtnAddRole_Click(object sender, EventArgs e)
        {
            String Username = lblUsername.Text;
            FrmAddRoleToUser FrmChild_AddRole = new FrmAddRoleToUser(OracleView);
            FrmChild_AddRole.frmParamUsername = Username;
            FrmChild_AddRole.FormClosed += new FormClosedEventHandler(FrmChild_FormClosed);
            FrmChild_AddRole.Show();
        }

        private void FrmChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.LoadData();
        }

        private void BtnChangeProfile_Click(object sender, EventArgs e)
        {
            String Username = lblUsername.Text;
            DataTable dt = this.OracleView.GetGrantedProfileToUser(Username).Tables[0];
            DataRow dr = dt.Rows[0];
            String CurrentProfile = dr[0].ToString();
            FrmAddProfileToUser FrmChild_AddProfile = new FrmAddProfileToUser(OracleView);
            FrmChild_AddProfile.frmParamUsername = Username;
            FrmChild_AddProfile.frmParamProfile = CurrentProfile;
            FrmChild_AddProfile.FormClosed += new FormClosedEventHandler(FrmChild_FormClosed);
            FrmChild_AddProfile.Show();
        }

        private void BtnRemoveRole_Click(object sender, EventArgs e)
        {
            RemoveRoleFromForm();
            LoadData();
        }

        private void RemoveRoleFromForm()
        {
            foreach (ListViewItem eachItem in LvwRole.CheckedItems)
            {
                string SelectedRole = eachItem.Text;
                this.OracleView.RemoveRoleFromUser(frmParamUsername, SelectedRole);
                MessageBox.Show("Removed!");
            }
        }
    }

}
