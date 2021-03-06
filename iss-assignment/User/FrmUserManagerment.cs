﻿using BLL;
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
    public partial class FrmUserManagerment : Form
    {
        private readonly UserManagementBLL view;
        private readonly UserManagementClassicBLL OracleView;

        private readonly IPrivilegeBLL privilegeBLL;
        private readonly UserPrincipal currentUser;

        public FrmUserManagerment(UserManagementBLL view, UserManagementClassicBLL OracleView, IPrivilegeBLL privilegeBLL, UserPrincipal currentUser)
        {
            this.view = view;
            this.OracleView = OracleView;
            this.privilegeBLL = privilegeBLL;
            this.currentUser = currentUser;
            InitializeComponent();
        }
        private void AddColumnListviewUserManagement()
        {
            LvwUserManagerment.Items.Clear();
            LvwUserManagerment.Columns.Clear();
            LvwUserManagerment.Columns.Add("Username", 100);
            LvwUserManagerment.Columns.Add("Full name", 100);
            LvwUserManagerment.Columns.Add("Phone", 100);
            LvwUserManagerment.Columns.Add("Address", 100);
            LvwUserManagerment.Columns.Add("Email", 100);
            LvwUserManagerment.Columns.Add("Date join", 100);
        }

        private void LoadListviewUserManagement()
        {
            ListViewItem lvwUser;
            foreach (USER_MANAGEMENT user in this.view.GetAll())
            {
                lvwUser = new ListViewItem();
                lvwUser = LvwUserManagerment.Items.Add(user.USERNAME);
                lvwUser.SubItems.Add(user.FULL_NAME);
                lvwUser.SubItems.Add(user.PHONE);
                lvwUser.SubItems.Add(user.ADDRESS);
                lvwUser.SubItems.Add(user.EMAIL);
                lvwUser.SubItems.Add(user.CREATE_TIME.ToString());
            }
        }

        public void LoadData()
        {
            AddColumnListviewUserManagement();
            LoadListviewUserManagement();
        }
        private void FrmUserManagerment_Load(object sender, EventArgs e)
        {
            this.LvwUserManagerment.ContextMenuStrip = this.contextMenuStrip1;
            LoadData();
        }

        private void LvwUserManagerment_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String text = LvwUserManagerment.SelectedItems[0].Text;
            frmUserInfo frm = new frmUserInfo(view, OracleView, this.privilegeBLL, this.currentUser);
            frm.frmParamUsername = text;
            frm.FormClosed += new FormClosedEventHandler(frmUserInfo_FormClosed);
            frm.Show();
        }

        private void frmUserInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void LvwUserManagerment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefeshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
