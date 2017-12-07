using BLL;
using DAL;
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
        }

        public void ClearText()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
        }

        private void AddRoleFromForm()
        {
            foreach (ListViewItem eachItem in LvwRole.CheckedItems)
            {
                string SelectedRole = eachItem.Text;
                MessageBox.Show(SelectedRole);
                this.OracleView.AddRoleToUser("aaa", SelectedRole);
            }
        }
        private void AddProfileFromForm()
        {
            foreach (ListViewItem eachItem in LvwProfile.CheckedItems)
            {
                string SelectedProfileList = eachItem.Text;
                MessageBox.Show(SelectedProfileList);
                this.OracleView.AddProfileToUser("aaa", SelectedProfileList);
            }
        }
        private void CheckLockAccountFromForm()
        {
            if (CbxBlockAccount.Checked)
            {
                this.OracleView.LockAccount("aaa");
            }
        }
        private void SaveTableSpaceFromForm()
        {
            String DefaultTablespaceSelected = CbbDefaultTablespace.SelectedItem.ToString();
            String TemporaryTablespaceSeleted = CbbTemporaryTablespace.SelectedItem.ToString();
            OracleView.UpdateDefaultTablespace(txtUsername.Text, DefaultTablespaceSelected);
            OracleView.UpdateTemporaryTablespace(txtUsername.Text, TemporaryTablespaceSeleted);
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            String Example = "";
            String Sysaux = "";
            String System = "";
            String Temp = "";
            String Undotps1 = "";
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

            if (CbxTemp.Checked)
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
            }

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
                MessageBox.Show("EXAMPLE " + Example);
            }
            if (System != "")
            {
                MessageBox.Show("SYSTEM" + System);
            }
            if (Sysaux != "")
            {
                MessageBox.Show("SYSAUX " + Sysaux);
            }
            if (Temp != "")
            {
                MessageBox.Show("TEMP" + Temp);
            }
            if (Undotps1 != "")
            {
                MessageBox.Show("UNDOTPS1" + Undotps1);
            }
            if (Users != "")
            {
                MessageBox.Show("USERS" + Users);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            USER_MANAGEMENT user = new USER_MANAGEMENT
            {
                USERNAME = txtUsername.Text,
                PASSWORD = txtPassword.Text
            };
            //Rat tiec khong them thi khomg save duoc
            this.view.Add(user); //Khong dc them cai nay? vi dang save bang OracleView khong phai save view 
            this.OracleView.AddOracleUser(txtUsername.Text, txtPassword.Text);
            ClearText();
            MessageBox.Show("User created!");
            Hide();
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

        private void CbxTemp_CheckedChanged(object sender, EventArgs e)
        {
            TxtTemp.Text = "";
        }

        private void CbxUndotps1_CheckedChanged(object sender, EventArgs e)
        {
            TxtUndotps1.Text = "";
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
            ActiveAdvanceMode();
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
            CbxExample.AutoCheck = false;
            CbxSysaux.AutoCheck = false;
            CbxSystem.AutoCheck = false;
            CbxTemp.AutoCheck = false;
            CbxUndotps1.AutoCheck = false;
            CbxUsers.AutoCheck = false;
            TxtExample.Enabled = true;
            TxtSysaux.Enabled = true;
            TxtSystem.Enabled = true;
            TxtTemp.Enabled = true;
            TxtUndotps1.Enabled = true;
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
            CbxTemp.AutoCheck = true;
            CbxUndotps1.AutoCheck = true;
            CbxUsers.AutoCheck = true;
            TxtExample.Enabled = false;
            TxtSysaux.Enabled = false;
            TxtSystem.Enabled = false;
            TxtTemp.Enabled = false;
            TxtUndotps1.Enabled = false;
            TxtUsers.Enabled = false;
        }
    }
}
