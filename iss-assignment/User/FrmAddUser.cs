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
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (CbbDefaultTablespace.SelectedItem.ToString() != "select")
            {
            }
            if (CbbTemporaryTablespace.SelectedItem.ToString() != "select")
            {
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
    }
}
