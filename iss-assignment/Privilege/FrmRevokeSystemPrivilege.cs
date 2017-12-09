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
    public partial class FrmRevokeSystemPrivilege : Form
    {
        private String currentPrivilege;

        private readonly IPrivilegeBLL privilegeBLL;

        private UserPrincipal currentUser;

        public FrmRevokeSystemPrivilege(IPrivilegeBLL privilegeBLL, UserPrincipal currentUser)
        {
            this.privilegeBLL = privilegeBLL;
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.LvwUser.Items)
            {
                item.Checked = false;
            }
        }

        private void FrmRevokeSystemPrivilegeFromUser_Load(object sender, EventArgs e)
        {
            this.LoadSystemPrivilege();
        }

        private void LvwSystemPrivilege_Click(object sender, EventArgs e)
        {
            var items = this.LvwSystemPrivilege.SelectedItems;
            if (items.Count >= 1)
            {
                this.LvwUser.Enabled = false;
                this.LoadUser(items[0].Text);
                this.LvwUser.Enabled = true;
                this.currentPrivilege = items[0].Text;
            }
        }

        /// <summary>
        /// To revoke a system privilege, you must have been granted the privilege with the ADMIN OPTION.
        /// </summary>
        private void LoadSystemPrivilege()
        {
            List<Privilege> items = this.privilegeBLL.SystemPrivileges(currentUser.UserName, true);

            this.LvwSystemPrivilege.Items.Clear();
            this.LvwSystemPrivilege.Columns.Clear();
            this.LvwSystemPrivilege.Columns.Add("System Privilege", 320, HorizontalAlignment.Center);
            foreach (var item in items)
            {
                ListViewItem viewItem = this.LvwSystemPrivilege.Items.Add(item.Name);
                viewItem.SubItems.Add(item.Name);
            }
        }

        private void LoadUser(String privilege)
        {
            var items = this.privilegeBLL.GranteeSystemPrivileges(privilege);
            this.LvwUser.Items.Clear();
            this.LvwUser.Columns.Clear();
            this.LvwUser.Columns.Add("Users", 320, HorizontalAlignment.Center);
            foreach (var item in items)
            {
                ListViewItem viewItem = this.LvwUser.Items.Add(item.Name);
                viewItem.SubItems.Add(item.Name);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            foreach (var item in this.LvwUser.CheckedItems)
            {
                this.Revoke(this.currentPrivilege, item.ToString());
            }
            MessageBox.Show(String.Join(" ", "Revoke ", this.currentPrivilege, "from ", this.LvwUser.CheckedItems.Count, "grantee sucessfull!"));
        }
        private void Revoke(String privilege, String user)
        {
            SystemPrivilegeBuilder builder = new SystemPrivilegeBuilder();
            SystemPrivilege pri = builder.Grantee(new GranteeClauseBuilder().Grantee(user))
                .Privilege(new List<string>
                {
                    privilege
                }).Build();
            this.privilegeBLL.RevokeSystemPrivilege(pri);
        }
    }
}
