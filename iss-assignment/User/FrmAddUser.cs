using BLL;
using DAL;
using Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iss_assignment
{
    public partial class FrmAddUser : Form
    {
        private readonly UserManagementBLL view;
        private readonly UserManagementClassicBLL OracleView;

        public FrmAddUser(UserManagementBLL view, UserManagementClassicBLL OracleView)
        {
            this.view = view;
            this.OracleView = OracleView;
            InitializeComponent();
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            AddColumnLvwProfile();
            AddColumnLvwRole();
            LoadDataLvwProfile();
            LoadDataLvwRole();
            LoadDataCbbDefaultTablespace();
            LoadDataCbbTemporaryTablespace();
            DeActiveAdvanceMode();
            txtPassword.PasswordChar = '*';
            txtPassword2.PasswordChar = '*';
        }

        public void ClearText()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
            TxtSysaux.Text = "";
            TxtSystem.Text = "";
            TxtUsers.Text = "";
            TxtExample.Text = "";
        }

        public void AddRoleFromForm()
        {
            foreach (ListViewItem eachItem in LvwRole.CheckedItems)
            {
                string SelectedRole = eachItem.Text;
                this.OracleView.AddRoleToUser(txtUsername.Text, SelectedRole);
            }
        }
        public void AddProfileFromForm()
        {
            foreach (ListViewItem eachItem in LvwProfile.CheckedItems)
            {
                string SelectedProfileList = eachItem.Text;
                this.OracleView.AddProfileToUser(txtUsername.Text, SelectedProfileList);
            }
        }
        public void CheckLockAccountFromForm()
        {
            if (CbxBlockAccount.Checked)
            {
                this.OracleView.LockAccount(txtUsername.Text);
            }
        }
        public void AddTableSpaceFromForm()
        {
            String DefaultTablespaceSelected = CbbDefaultTablespace.SelectedItem.ToString();
            String TemporaryTablespaceSeleted = CbbTemporaryTablespace.SelectedItem.ToString();
            OracleView.UpdateDefaultTablespace(txtUsername.Text, DefaultTablespaceSelected);
            OracleView.UpdateTemporaryTablespace(txtUsername.Text, TemporaryTablespaceSeleted);
        }
        public void UpdateQoutaDromform()
        {
            String Example = "";
            String Sysaux = "";
            String System = "";
            //String Temp = "";
            //String Undotps1 = "";
            String Users = "";
            if (CbxExample.Checked)
            {
                Example = "UNLIMITED";
            }
            else
            {
                if (TxtExample.Text != "")
                {
                    Example = TxtExample.Text + "M";
                }
            }

            if (CbxSysaux.Checked)
            {
                Sysaux = "UNLIMITED";
            }
            else
            {
                if (TxtSysaux.Text != "")
                {
                    Sysaux = TxtSysaux.Text + "M";
                }
            }

            if (CbxSystem.Checked)
            {
                System = "UNLIMITED";
            }
            else
            {
                if (TxtSystem.Text != "")
                {
                    System = TxtSystem.Text + "M";
                }
            }

            /*if (CbxTemp.Checked)
            {
                Temp = "UNLIMITED";
            }
            else
            {
                if (TxtTemp.Text != "")
                {
                    Temp = TxtTemp.Text + "M";
                }
            }

            if (CbxUndotps1.Checked)
            {
                Undotps1 = "UNLIMITED";
            }
            else
            {
                if (TxtUndotps1.Text != "")
                {
                    Undotps1 = TxtUndotps1.Text + "M";
                }
            }*/

            if (CbxUsers.Checked)
            {
                Users = "UNLIMITED";
            }
            else
            {
                if (TxtUsers.Text != "")
                {
                    Users = TxtUsers.Text + "M";
                }
            }

            if (Example != "")
            {
                OracleView.UpdateQuota(txtUsername.Text, Example, "EXAMPLE");
            }
            if (System != "")
            {
                OracleView.UpdateQuota(txtUsername.Text, System, "SYSTEM");
            }
            if (Sysaux != "")
            {
                OracleView.UpdateQuota(txtUsername.Text, Sysaux, "SYSAUX");
            }
            /*if (Temp != "")
            {
                OracleView.UpdateQuota(txtUsername.Text, Temp, "TEMP");
            }
            if (Undotps1 != "")
            {
                OracleView.UpdateQuota(txtUsername.Text, Undotps1, "UNDOTPS1");
            }*/
            if (Users != "")
            {
                OracleView.UpdateQuota(txtUsername.Text, Users, "USERS");
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            String Username = txtUsername.Text;
            String Password = txtPassword.Text;
            String Password2 = txtPassword2.Text;
            if (Username == "" || Password == "" || Password2 == "")
            {
                MessageBox.Show("Username and password not empty!");
            }
            else
            {
                Boolean flag = false;
                foreach (USER_MANAGEMENT ExistUser in this.view.GetAll())
                {
                    if (ExistUser.USERNAME == Username)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    MessageBox.Show("Username  is realy exist!");
                }
                else
                {
                    String HashPassword = PasswordUtils.Get(Password);
                    DateTime now = DateTime.Now;
                    USER_MANAGEMENT user = new USER_MANAGEMENT
                    {
                        USERNAME = Username,
                        PASSWORD = HashPassword,
                        CREATE_TIME = now
                    };
                    //Rat tiec khong them thi khomg save duoc
                    this.view.Add(user); //Khong dc them cai nay? vi dang save bang OracleView khong phai save view 
                    this.OracleView.AddOracleUser(Username, Password);
                    UpdateQoutaDromform();
                    AddProfileFromForm();
                    AddRoleFromForm();
                    AddTableSpaceFromForm();
                    CheckLockAccountFromForm();
                    ClearText();
                    MessageBox.Show("User created!");
                    Hide();
                }
            }
                
        }
        private void AddColumnLvwProfile()
        {
            LvwProfile.Items.Clear();
            LvwProfile.Columns.Clear();
            LvwProfile.Columns.Add("Profile", 300);
        }
        private void AddColumnLvwRole()
        {
            LvwRole.Items.Clear();
            LvwRole.Columns.Clear();
            LvwRole.Columns.Add("Role", 300);
        }
        private void LoadDataLvwProfile()
        {
            DataSet ds = OracleView.GetDistincProfileName();
            DataTable dt = ds.Tables[0];
            ListViewItem it;
            foreach (DataRow dr in dt.Rows)
            {

                it = LvwProfile.Items.Add(dr[0].ToString());
            }
        }
        private void LoadDataLvwRole()
        {
            DataSet ds = OracleView.GetDistincRoleName();
            DataTable dt = ds.Tables[0];
            ListViewItem it;
            foreach (DataRow dr in dt.Rows)
            {

                it = LvwRole.Items.Add(dr[0].ToString());
            }

        }
        private void LoadDataCbbDefaultTablespace()
        {
            CbbDefaultTablespace.Items.Add("USERS");
            DataSet ds = OracleView.GetDistincTablespaceName();
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString() != "TEMP" && dr[0].ToString() != "UNDOTBS1")
                CbbDefaultTablespace.Items.Add(dr[0].ToString());
            }
            CbbDefaultTablespace.SelectedIndex = 0;
        }
        private void LoadDataCbbTemporaryTablespace()
        {
            CbbTemporaryTablespace.Items.Add("TEMP");
            CbbTemporaryTablespace.SelectedIndex = 0;
        }

        private void CbxExample_CheckedChanged(object sender, EventArgs e)
        {
            TxtExample.Text = "";
        }

        private void CbxSysaux_CheckedChanged(object sender, EventArgs e)
        {
            TxtSysaux.Text = "";
        }

        private void CbxSystem_CheckedChanged(object sender, EventArgs e)
        {
            TxtSystem.Text = "";
        }

        private void CbxUsers_CheckedChanged(object sender, EventArgs e)
        {
            TxtUsers.Text = "";
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckUserInputNotNull();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckUserInputNotNull();
        }

        private void txtPassword2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckUserInputNotNull();
        }

        private void CheckUserInputNotNull()
        {
            if (txtUsername.Text != "" && txtPassword.Text != "" && txtPassword2.Text != "")
            {
                ActiveAdvanceMode();
            }
            else
            {
                DeActiveAdvanceMode();
            }
        }

        private void ActiveAdvanceMode()
        {
            btnSave.Enabled = true;
            LvwProfile.CheckBoxes = true;
            LvwProfile.Enabled = true;
            LvwRole.CheckBoxes = true;
            LvwRole.Enabled = true;
            CbbDefaultTablespace.Enabled = true;
            CbbTemporaryTablespace.Enabled = true;
            CbxExample.AutoCheck = true;
            CbxSysaux.AutoCheck = true;
            CbxSystem.AutoCheck = true;
            //CbxTemp.AutoCheck = false;
            //CbxUndotps1.AutoCheck = false;
            CbxUsers.AutoCheck = true;
            TxtExample.Enabled = true;
            TxtSysaux.Enabled = true;
            TxtSystem.Enabled = true;
            //TxtTemp.Enabled = true;
            //TxtUndotps1.Enabled = true;
            TxtUsers.Enabled = true;
        }

        private void DeActiveAdvanceMode()
        {
            btnSave.Enabled = false;
            LvwProfile.CheckBoxes = false;
            LvwProfile.Enabled = false;
            LvwRole.CheckBoxes = false;
            LvwRole.Enabled = false;
            CbbDefaultTablespace.Enabled = false;
            CbbTemporaryTablespace.Enabled = false;
            CbxExample.AutoCheck = true;
            CbxSysaux.AutoCheck = true;
            CbxSystem.AutoCheck = true;
            //CbxTemp.AutoCheck = true;
            //CbxUndotps1.AutoCheck = true;
            CbxUsers.AutoCheck = true;
            TxtExample.Enabled = false;
            TxtSysaux.Enabled = false;
            TxtSystem.Enabled = false;
            //TxtTemp.Enabled = false;
            //TxtUndotps1.Enabled = false;
            TxtUsers.Enabled = false;
        }
    }
}
