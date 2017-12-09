using BLL;
using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iss_assignment
{
    public partial class FrmGrantSystemPrivilege : Form
    {
        private readonly IPrivilegeBLL privilegeBLL;

        private readonly IRoleBLL roleBLL;

        private readonly UserManagementBLL userManagementBLL;

        private readonly UserPrincipal currentUser;

        public FrmGrantSystemPrivilege(IPrivilegeBLL privilegeBLL, IRoleBLL roleBLL, 
            UserManagementBLL userManagementBLL, UserPrincipal currentUser)
        {
            this.privilegeBLL = privilegeBLL;
            this.roleBLL = roleBLL;
            this.userManagementBLL = userManagementBLL;
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void FrmRolePrivilege_Load(object sender, EventArgs e)
        {
            this.LoadPrivilege();
            this.LoadUser();
            this.LoadRole();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.SetEnable(false);

            List<String> privileges = new List<String>();
            List<String> privilegesAdmin = new List<String>();
            for (int i = 0; i < this.DgvPrivilege.RowCount; i++)
            {
                Boolean isHandle = (Boolean)this.DgvPrivilege.Rows[i].Cells[0].Value;
                if (isHandle)
                {
                    if ((Boolean)this.DgvPrivilege.Rows[i].Cells[2].Value)
                    {
                        privilegesAdmin.Add((String)this.DgvPrivilege.Rows[i].Cells[1].Value);
                    }
                    else
                    {
                        privileges.Add((String)this.DgvPrivilege.Rows[i].Cells[1].Value);
                    }
                }
            }

            if (privileges.Count > 0 || privilegesAdmin.Count > 0)
            {
                List<String> grantee = new List<string>();
                foreach (ListViewItem item in this.LvwUsers.Items)
                {
                    if (item.Checked == true)
                    {
                        grantee.Add(item.Text);
                    }
                }
                foreach (ListViewItem item in this.LvwRole.Items)
                {
                    if (item.Checked == true)
                    {
                        grantee.Add(item.Text);
                    }
                }
                foreach (var g in grantee)
                {
                    this.ExecuteGrant(privileges, g, false);
                    this.ExecuteGrant(privilegesAdmin, g, true);
                }
                MessageBox.Show(String.Join(" ", "Grant ", privileges.Count + privilegesAdmin.Count, " privilege to ", grantee.Count, "grantee sucessfull!"));
            }
            this.SetEnable(true);

        }

        private void ExecuteGrant(List<String> privileges, String grantee, Boolean isAdmin)
        {
            if (privileges.Count > 0)
            {
                SystemPrivilegeBuilder builder = new SystemPrivilegeBuilder();
                SystemPrivilege privilege = builder
                    .Privilege(privileges)
                    .Grantee(new GranteeClauseBuilder().Grantee(grantee))
                    .AdminOption(isAdmin).Build();
                this.privilegeBLL.GrantSystemPrivilege(privilege);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.ClearPrivilege();
            this.ClearUser();
            this.ClearRole();
        }

        /// <summary>
        /// To grant a system privilege, 
        /// you must either have been granted the system privilege with the ADMIN OPTION 
        /// or 
        /// have been granted the GRANT ANY PRIVILEGE system privilege.
        /// </summary>
        private void LoadPrivilege()
        {
            //Get privilege
            Privilege privilege = new Privilege()
            {
                Name = "GRANT ANY PRIVILEGE"
            };
            List<Privilege> items;
            if (this.privilegeBLL.HasSystemPrivilege(this.currentUser.UserName, privilege))
            {
                items = this.privilegeBLL.SystemPrivileges();
            } 
            else
            {
                items  = this.privilegeBLL.SystemPrivileges(this.currentUser.UserName, true);
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
                Name = "Privilege",
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
            this.DgvPrivilege.Columns.Add(privilegeColumn);
            this.DgvPrivilege.Columns.Add(contentColumn);
            this.DgvPrivilege.Columns.Add(adminColumn);
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

                this.DgvPrivilege.Rows.Add(row);
            }
            contentColumn.ReadOnly = true;
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

        private void LoadRole()
        {
            this.LvwRole.Items.Clear();
            this.LvwRole.Columns.Clear();
            this.LvwRole.Columns.Add("Role Name", 320, HorizontalAlignment.Center);
            List<Role> items = this.roleBLL.View();
            foreach (var item in items)
            {
                ListViewItem viewItem = this.LvwRole.Items.Add(item.Name);
                viewItem.SubItems.Add(item.Name);
            }
        }

        private void ClearPrivilege()
        {
            for (int i = 0; i < this.DgvPrivilege.RowCount; i++)
            {
                this.DgvPrivilege.Rows[i].Cells[0].Value = false;
                this.DgvPrivilege.Rows[i].Cells[2].Value = false;
            }
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
            foreach (ListViewItem item in this.LvwRole.Items)
            {
                item.Checked = false;
            }
        }

        private void SetEnable(Boolean enable)
        {
            this.DgvPrivilege.Enabled = enable;
            this.LvwRole.Enabled = enable;
            this.LvwUsers.Enabled = enable;
        }
    }
}
