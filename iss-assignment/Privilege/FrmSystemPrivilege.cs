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
            this.LoadPrivilege();
            this.LoadUser();
            this.LoadRole();


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }

        private void LoadPrivilege()
        {
            
            List<Privilege> items = this.privilegeBLL.SystemPrivileges("SYS", true);
            DataGridViewCheckBoxColumn privilegeColumn = new DataGridViewCheckBoxColumn()
            {
                FalseValue = 0,
                TrueValue = 1,
                Visible = true,
            };
            DataGridViewCheckBoxColumn adminColumn = new DataGridViewCheckBoxColumn()
            {
                Name = "Admin",
                FalseValue = 0,
                TrueValue = 1,
                Visible = true
            };
            this.DgvPrivilege.Columns.Add(privilegeColumn);
            this.DgvPrivilege.Columns.Add("Privilege", "Privilege");
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
                    Value = item.Name
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
