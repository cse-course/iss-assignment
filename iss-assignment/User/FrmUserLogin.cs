using BLL;
using DAL;
using Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Domain;

namespace iss_assignment
{
    public partial class FrmUserLogin : Form
    {
        private readonly UserManagementBLL view;

        private UserPrincipal currentUser;

        private FrmMain main;
        public FrmUserLogin(FrmMain main, UserManagementBLL view, UserPrincipal currentUser)
        {
            this.main = main;
            this.view = view;
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void FrmUserLogin_Load(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = '*';
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            main.SetStatus("Loging...");
            String Username = txtUsername.Text;
            String Password = TxtPassword.Text;
            if (Username == "" || Password == "")
            {
                MessageBox.Show("Username and password not empty!");
            }
            else
            {
                Password = PasswordUtils.Get(Password);

                try
                {
                    IEnumerable<USER_MANAGEMENT> userList = this.view.GetUserInfo(Username);
                    USER_MANAGEMENT user = userList.First();
                    if (user.PASSWORD.Equals(Password))
                    {

                        this.currentUser.UserName = user.USERNAME;
                        if (user.ADMIN_OPTION != null && user.ADMIN_OPTION.Equals("Y"))
                            {
                            this.currentUser.IsAdmin = true;
                        }
                        else
                        {
                            this.currentUser.IsAdmin = false;

                        }
                        main.SetStatus(String.Join(" ", "Hello,", currentUser.UserName));
                        main.StatusAll(true);
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
