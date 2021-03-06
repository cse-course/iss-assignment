﻿using BLL;
using Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace iss_assignment
{
    public partial class FrmRole : Form
    {
        private IRoleBLL roleBLL;

        private IPrivilegeBLL privilegeBLL;

        private UserPrincipal currentUser;
        public FrmRole(IPrivilegeBLL privilegeBLL, IRoleBLL roleBLL, UserPrincipal currentUser)
        {
            this.privilegeBLL = privilegeBLL;
            this.roleBLL = roleBLL;
            this.currentUser = currentUser;
            InitializeComponent();
        }
        private void FrmRole_Load(object sender, EventArgs e)
        {
            this.LvwRole.ContextMenuStrip = this.CmsRole;
            this.LoadAll();
        }

        private void LoadAll()
        {
            this.InitHeader();
            this.LoadData();
        }
        private void InitHeader()
        {
            this.LvwRole.Items.Clear();
            this.LvwRole.Columns.Clear();
            this.LvwRole.Columns.Add("Role Name", 320, HorizontalAlignment.Center);
        }

        private void LoadData()
        {
            List<Privilege> roles = this.privilegeBLL.RolePrivileges(this.currentUser.UserName, true);
            foreach (var item in roles)
            {
                ListViewItem viewItem = this.LvwRole.Items.Add(item.Name);
                viewItem.SubItems.Add(item.Name);
            }

        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            String name = null;
            try
            {
                name = this.LvwRole.SelectedItems?[0]?.Text;
            }
            catch { }

            if (name != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    RoleBuilder buider = new RoleBuilder(name);
                    this.roleBLL.Remove(buider.Build());
                    MessageBox.Show(String.Join(" ", "Delete role ", name, "sucessfull!"));
                    this.LoadAll();
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            String name = null;
            try
            {
                name = this.LvwRole.SelectedItems?[0]?.Text;
            }
            catch { }

            if (name != null)
            {
                this.OpenRoleInfo(name);
            }
        }

        private void OpenRoleInfo(String name)
        {
            Role role = this.roleBLL.View(name);
            FrmRoleInfo frmRoleInfo = new FrmRoleInfo(this.privilegeBLL, this.roleBLL, role, this.currentUser);
            frmRoleInfo.Show();
        }

        private void RefeshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadAll();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BtnEdit_Click(sender, e);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BtnDelete_Click(sender, e);
        }

        private void LvwRole_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.BtnEdit_Click(sender, e);
        }
    }
}
