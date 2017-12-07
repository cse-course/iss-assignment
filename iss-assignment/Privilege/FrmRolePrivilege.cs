using BLL;
using DAL;
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
    public partial class FrmRolePrivilege : Form
    {
        private readonly IPrivilegeBLL privilegeBLL;

        private readonly IRoleBLL roleBLL;

        private readonly UserManagementBLL userManagementBLL;

        private USER_MANAGEMENT currentUser;

        public FrmRolePrivilege(IPrivilegeBLL privilegeBLL, IRoleBLL roleBLL, 
            UserManagementBLL userManagementBLL, USER_MANAGEMENT currentUser)
        {
            this.privilegeBLL = privilegeBLL;
            this.roleBLL = roleBLL;
            this.userManagementBLL = userManagementBLL;
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.ClearUser();
            this.ClearRole();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.SetEnable(false);
            List<String> roles = new List<String>();
            List<String> roleAdmins = new List<String>();
            for (int i = 0; i < this.DgvRole.RowCount; i++)
            {
                Boolean isHandle = (Boolean)this.DgvRole.Rows[i].Cells[0].Value;
                if (isHandle)
                {
                    if ((Boolean)this.DgvRole.Rows[i].Cells[2].Value)
                    {
                        roleAdmins.Add((String)this.DgvRole.Rows[i].Cells[1].Value);
                    }
                    else
                    {
                        roles.Add((String)this.DgvRole.Rows[i].Cells[1].Value);
                    }
                }
            }

            if (roles.Count > 0 || roleAdmins.Count > 0)
            {
                List<String> grantee = new List<string>();
                foreach (ListViewItem item in this.LvwUsers.Items)
                {
                    if (item.Checked == true)
                    {
                        grantee.Add(item.Text);
                    }
                }
                foreach (var g in grantee)
                {
                    this.ExecuteGrant(roles, g, false);
                    this.ExecuteGrant(roleAdmins, g, true);
                }
                MessageBox.Show(String.Join(" ", "Grant ", roles.Count + roleAdmins.Count, " role to ", grantee.Count, "grantee sucessfull!"));

            }

            this.SetEnable(true);
        }

        private void ExecuteGrant(List<String> roles, String grantee, Boolean isAdmin)
        {
            if (roles.Count > 0)
            {
                foreach (String role in roles)
                {
                    RolePrivilegeBuilder builder = new RolePrivilegeBuilder(role);
                    RolePrivilege rolePrivilege = builder
                        .Grantee(new GranteeClauseBuilder().Grantee(grantee))
                        .AdminOption(isAdmin).Build();
                    this.privilegeBLL.GrantRolePrivilege(rolePrivilege);
                }
            }
        }

        private void FrmRolePrivilege_Load(object sender, EventArgs e)
        {
            this.LoadUser();
            this.LoadRole();
        }

        private void LoadUser()
        {
            this.LvwUsers.Items.Clear();
            this.LvwUsers.Columns.Clear();
            this.LvwUsers.Columns.Add("User Name", 320, HorizontalAlignment.Center);
            IEnumerable<USER_MANAGEMENT> items = this.userManagementBLL.GetAll();
            foreach (var item in items)
            {
                ListViewItem viewItem = this.LvwUsers.Items.Add(item.USERNAME);
                viewItem.SubItems.Add(item.USERNAME);
            }
        }

        /// <summary>
        /// To grant a role, 
        /// you must either have been granted the role with the ADMIN OPTION 
        /// or have been granted the GRANT ANY ROLE system privilege, 
        /// or you must have created the role.
        /// </summary>
        private void LoadRole()
        {
            List<Privilege> items;
            //Get privilege
            Privilege privilege = new Privilege()
            {
                Name = "GRANT ANY ROLE"
            };

            if (this.privilegeBLL.HasRolePrivilege(this.currentUser.USERNAME, privilege))
            {
                items = this.privilegeBLL.RolePrivileges();
            }
            else
            {
                items = this.privilegeBLL.RolePrivileges(this.currentUser.USERNAME, true);
            }

            //Setup column
            DataGridViewCheckBoxColumn privilegeColumn = new DataGridViewCheckBoxColumn()
            {
                FalseValue = 0,
                TrueValue = 1,
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            DataGridViewTextBoxColumn contentColumn = new DataGridViewTextBoxColumn()
            {
                Name = "Role",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            DataGridViewCheckBoxColumn adminColumn = new DataGridViewCheckBoxColumn()
            {
                Name = "Admin",
                FalseValue = 0,
                TrueValue = 1,
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            this.DgvRole.Columns.Add(privilegeColumn);
            this.DgvRole.Columns.Add(contentColumn);
            this.DgvRole.Columns.Add(adminColumn);
            foreach (var item in items)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCheckBoxCell cellName = new DataGridViewCheckBoxCell
                {
                    ToolTipText = item.Name,
                    Value = false
                };
                DataGridViewTextBoxCell cellPrivilege = new DataGridViewTextBoxCell()
                {
                    Value = item.Name,
                };
                DataGridViewCheckBoxCell cellAdmin = new DataGridViewCheckBoxCell
                {
                    Value = false
                };
                row.Cells.Add(cellName);
                row.Cells.Add(cellPrivilege);
                row.Cells.Add(cellAdmin);

                this.DgvRole.Rows.Add(row);
            }
            contentColumn.ReadOnly = true;
        }

        private void ClearUser()
        {
            foreach (ListViewItem item in this.LvwUsers.Items)
            {
                item.Checked = false;
            }
        }

        private void ClearRole()
        {
            for (int i = 0; i < this.DgvRole.RowCount; i++)
            {
                this.DgvRole.Rows[i].Cells[0].Value = false;
                this.DgvRole.Rows[i].Cells[2].Value = false;
            }
        }

        private void SetEnable(Boolean enable)
        {
            this.DgvRole.Enabled = enable;
            this.LvwUsers.Enabled = enable;
        }
    }
}
