using BLL;
using Domain;
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
    public partial class FrmAddRoleToUser : Form
    {
        public string frmParamUsername = "";
        private readonly UserManagementClassicBLL OracleView;

        private readonly IPrivilegeBLL privilegeBLL;
        private readonly UserPrincipal currentUser;

        public FrmAddRoleToUser(UserManagementClassicBLL OracleView, IPrivilegeBLL privilegeBLL, UserPrincipal currentUser)
        {
            this.OracleView = OracleView;
            this.privilegeBLL = privilegeBLL;
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void FrmAddRoleToUser_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        public void LoadData()
        {
            this.AddColumnLvwRole();
            this.LoadDataLvwRole();
        }
        private void AddColumnLvwRole()
        {
            LvwRole.CheckBoxes = true;
            LvwRole.GridLines = true;
            LvwRole.Items.Clear();
            LvwRole.Columns.Clear();
            LvwRole.Columns.Add("ROLES", 200);
        }
        private void LoadDataLvwRole()
        {

            AddColumnLvwRole();
            var items = this.privilegeBLL.RolePrivileges(this.currentUser.UserName, true);
            foreach (var item in items)
            {
                LvwRole.Items.Add(item.Name);
            }
        }
        private void AddRoleFromForm()
        {
            foreach (ListViewItem eachItem in LvwRole.CheckedItems)
            {
                string SelectedRole = eachItem.Text;
                this.OracleView.AddRoleToUser(frmParamUsername, SelectedRole);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.AddRoleFromForm();
            Close();
        }
    }
}
