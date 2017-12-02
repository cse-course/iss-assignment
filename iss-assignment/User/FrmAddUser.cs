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
    public partial class FrmAddUser : Form
    {
        private readonly UserManagementBLL view;
        private readonly UserManagementClassicBLL OracleView;

        public FrmAddUser(UserManagementBLL view, UserManagementClassicBLL OracleView)
        {
            this.view = view;
            this.OracleView = OracleView;
            InitializeComponent();
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {

        }

        public void ClearText()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            USER_MANAGEMENT user = new USER_MANAGEMENT();
            user.USERNAME = txtUsername.Text;
            user.PASSWORD = txtPassword.Text;
            this.view.Add(user);
            this.OracleView.AddOracleUser(txtUsername.Text, txtPassword.Text);
            ClearText();
        }
    }
}
