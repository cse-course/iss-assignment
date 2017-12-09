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
    public partial class FrmRevokeRolePrivilege : Form
    {

        private String currentPrivilege;

        private readonly IPrivilegeBLL privilegeBLL;

        private UserPrincipal currentUser;


        public FrmRevokeRolePrivilege(IPrivilegeBLL privilegeBLL, UserPrincipal currentUser)
        {
            this.privilegeBLL = privilegeBLL;
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.LvwUser.CheckedItems.Count; i++)
            {
                this.Revoke(this.currentPrivilege, this.LvwUser.CheckedItems[i].Text);
            }
            MessageBox.Show(String.Join(" ", "Revoke ", this.currentPrivilege, "from ", this.LvwUser.CheckedItems.Count, "grantee sucessfull!"));

        }

        private void Revoke(String privilege, String user)
        {
            RolePrivilegeBuilder builder = new RolePrivilegeBuilder(this.currentPrivilege);
            RolePrivilege pri = builder.Grantee(new GranteeClauseBuilder().Grantee(user))
                                .Build();
            this.privilegeBLL.RevokeRolePrivilege(pri);
        }

        private void FrmRevokeRolePrivilege_Load(object sender, EventArgs e)
        {
            this.LoadRole();
        }

        private void LoadRole()
        {
            List<Privilege> items = this.privilegeBLL.RolePrivileges(this.currentUser.UserName, true);
            this.LvwRolePrivilege.Items.Clear();
            this.LvwRolePrivilege.Columns.Clear();
            this.LvwRolePrivilege.Columns.Add("Role Privilege", 320, HorizontalAlignment.Center);
            foreach (var item in items)
            {
                ListViewItem viewItem = this.LvwRolePrivilege.Items.Add(item.Name);
                viewItem.SubItems.Add(item.Name);
            }
        }

        private void LoadGrantee(String role)
        {
            var items = this.privilegeBLL.GranteeRolePrivileges(role);
            this.LvwUser.Items.Clear();
            this.LvwUser.Columns.Clear();
            this.LvwUser.Columns.Add("Roles", 320, HorizontalAlignment.Center);
            foreach (var item in items)
            {
                ListViewItem viewItem = this.LvwUser.Items.Add(item.Name);
                viewItem.SubItems.Add(item.Name);
            }
        }

        private void LvwRolePrivilege_Click(object sender, EventArgs e)
        {
            var items = this.LvwRolePrivilege.SelectedItems;
            if (items.Count >= 1)
            {
                this.LvwUser.Enabled = false;
                this.LoadGrantee(items[0].Text);
                this.LvwUser.Enabled = true;
                this.currentPrivilege = items[0].Text;
            }
        }
    }
}
