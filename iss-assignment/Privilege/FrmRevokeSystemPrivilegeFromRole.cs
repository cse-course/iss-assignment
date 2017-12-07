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
    public partial class FrmRevokeSystemPrivilegeFromRole : Form
    {
        private readonly IPrivilegeBLL privilegeBLL;

        private USER_MANAGEMENT currentUser;


        public FrmRevokeSystemPrivilegeFromRole(IPrivilegeBLL privilegeBLL, USER_MANAGEMENT currentUser)
        {
            this.privilegeBLL = privilegeBLL;
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.LvwRoles.Items)
            {
                item.Checked = false;
            }
        }

        

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void FrmRevokeSystemPrivilegeFromRole_Load(object sender, EventArgs e)
        {
            this.LoadSystemPrivilege();
        }

        /// <summary>
        /// To revoke a system privilege, you must have been granted the privilege with the ADMIN OPTION.
        /// </summary>
        private void LoadSystemPrivilege()
        {
            List<Privilege> items = this.privilegeBLL.SystemPrivileges(currentUser.USERNAME, true);

            this.LvwSystemPrivilege.Items.Clear();
            this.LvwSystemPrivilege.Columns.Clear();
            this.LvwSystemPrivilege.Columns.Add("System Privilege", 320, HorizontalAlignment.Center);
            foreach (var item in items)
            {
                ListViewItem viewItem = this.LvwSystemPrivilege.Items.Add(item.Name);
                viewItem.SubItems.Add(item.Name);
            }
        }

        private void LoadRole(String privilege)
        {
            var items = this.privilegeBLL.GranteeSystemPrivileges(privilege, true);
            this.LvwRoles.Items.Clear();
            this.LvwRoles.Columns.Clear();
            this.LvwRoles.Columns.Add("Roles", 320, HorizontalAlignment.Center);
            foreach (var item in items)
            {
                ListViewItem viewItem = this.LvwRoles.Items.Add(item.Name);
                viewItem.SubItems.Add(item.Name);
            }
        }

        private void LvwSystemPrivilege_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = this.LvwSystemPrivilege.SelectedItems;
            if (items.Count >= 1)
            {
                this.LoadRole(items[0].Text);
            }
        }
    }
}
