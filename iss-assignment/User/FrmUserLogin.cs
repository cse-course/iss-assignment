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
using System.Security.Cryptography;
using System.Diagnostics;

namespace iss_assignment
{
    public partial class FrmUserLogin : Form
    {
        private readonly UserManagementBLL view;
        public FrmUserLogin(UserManagementBLL view)
        {
            this.view = view;
            InitializeComponent();
        }

        private void FrmUserLogin_Load(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = '*';
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            String Username = txtUsername.Text;
            String Password = TxtPassword.Text;
            if (Username == "" || Password == "")
            {
                MessageBox.Show("Username and password not empty!");
            }
            else
            {
                HashPassword HP = new HashPassword();
                Password = HP.Get(Password);

                try
                {
                    IEnumerable<USER_MANAGEMENT> userList = this.view.GetUserInfo(Username);
                    USER_MANAGEMENT user = userList.First();
                    if (user.PASSWORD.Equals(Password))
                    {
                        FrmMain frm = new FrmMain
                        {
                            currentUser = user
                        };
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorect username or password!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Fail to login!");
                }
            }

        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnLogin.PerformClick();
        }
    }
}
