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
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            USER_MANAGEMENT user = new USER_MANAGEMENT
            {
                USERNAME = txtUsername.Text,
                PASSWORD = txtPassword.Text
            };
            //this.view.Add(user); //Khong dc them cai nay? vi dang save bang OracleView khong phai save view 
            this.OracleView.AddOracleUser(txtUsername.Text, txtPassword.Text);
            ClearText();
        }
    }
}
