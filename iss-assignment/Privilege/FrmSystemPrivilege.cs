using BLL;
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
    public partial class FrmSystemPrivilege : Form
    {
        private readonly IPrivilegeBLL privilegeBLL;

        private readonly IRoleBLL roleBLL;
        
        public FrmSystemPrivilege(IPrivilegeBLL privilegeBLL, IRoleBLL roleBLL)
        {
            this.privilegeBLL = privilegeBLL;
            this.roleBLL = roleBLL;
            InitializeComponent();
        }

        private void FrmRolePrivilege_Load(object sender, EventArgs e)
        {
            this.LoadPrivilige();
            this.LoadUser();
            this.LoadRole();


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }

        private void LoadPrivilige()
        {
            this.LvwPrivilege.Items.Clear();
            this.LvwPrivilege.Columns.Clear();
            this.LvwPrivilege.Columns.Add("Privilege Name", 320, HorizontalAlignment.Center);
            List<Privilege> items = this.privilegeBLL.SystemPrivileges("SYS", true);
            foreach (var item in items)
            {
                ListViewItem viewItem = this.LvwPrivilege.Items.Add(item.Name);
                viewItem.SubItems.Add(item.Name);
            }
        }

        private void LoadUser()
        {
            this.LvwUsers.Items.Clear();
            this.LvwUsers.Columns.Clear();
            this.LvwUsers.Columns.Add("User Name", 320, HorizontalAlignment.Center);
            List<Privilege> items = this.privilegeBLL.SystemPrivileges("SYS", true);
            foreach (var item in items)
            {
                ListViewItem viewItem = this.LvwUsers.Items.Add(item.Name);
                viewItem.SubItems.Add(item.Name);
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

        private void LvwPrivilege_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            Debug.WriteLine("LvwUsers");
        }
    }
}
