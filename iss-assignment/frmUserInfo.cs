using BLL;
using DAL;
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
    public partial class frmUserInfo : Form
    {
        private readonly UserManagementBLL view;
        public frmUserInfo(UserManagementBLL view)
        {
            this.view = view;
            InitializeComponent();
            LoadViewMode();
        }

        private void LoadEditMode()
        {
            txtAdress.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtFullname.ReadOnly = false;
            txtPhone.ReadOnly = false;
            btnEdit.Visible = false;
            btnSave.Visible = true;
        }

        private void LoadData()
        {
            IEnumerable<USER_MANAGEMENT> userList = this.view.GetUserInfo("dev");
            USER_MANAGEMENT user = userList.First();
            lblUsername.Text = user.USERNAME;
            txtEmail.Text = user.EMAIL;
            txtFullname.Text = user.FULL_NAME;
            txtPhone.Text = user.PHONE;
            txtAdress.Text = user.ADDRESS;
            lblDateJoin.Text = user.CREATE_TIME.ToString();
        }

        private void LoadViewMode()
        {
            txtAdress.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtFullname.ReadOnly = true;
            txtPhone.ReadOnly = true;
            btnEdit.Visible = true;
            btnSave.Visible = false;
        }

        private void ClearText()
        {
            txtAdress.Text = "";
            txtEmail.Text = "";
            txtFullname.Text= "";
            txtPhone.Text = "";
            lblUsername.Text = "";
            lblDateJoin.Text = "";
        }
        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            LoadEditMode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IEnumerable<USER_MANAGEMENT> userList = this.view.GetUserInfo(lblUsername.Text);
            USER_MANAGEMENT user = userList.First();
            user.ADDRESS = txtAdress.Text;
            user.EMAIL = txtEmail.Text;
            user.FULL_NAME = txtFullname.Text;
            user.PHONE = txtPhone.Text;
            this.view.Save(user);
            ClearText();
            LoadData();
            LoadViewMode();
        }
    }

}
