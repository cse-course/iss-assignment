using BLL;
using Domain;
using System;
using System.Windows.Forms;

namespace iss_assignment
{
    public partial class FrmAddRole : Form
    {
        private static string CREATE_ROLE = "CREATE ROLE";


        private IRoleBLL roleBLL;

        private IPrivilegeBLL privilegeBLL;

        private UserPrincipal currentUser;


        public FrmAddRole(IPrivilegeBLL privilegeBLL, IRoleBLL roleBLL, UserPrincipal currentUser)
        {
            this.privilegeBLL = privilegeBLL;
            this.roleBLL = roleBLL;
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.SetEnable(false);
            Privilege privilege = new Privilege
            {
                Name = CREATE_ROLE
            };
            bool check = this.privilegeBLL.HasRolePrivilege(this.currentUser.UserName, privilege);
            if (check)
            {
                RoleBuilder builder = new RoleBuilder(this.TxtName.Text);
                if (this.TxtPassword.Text != null && this.TxtPassword.Text != "")
                {
                    builder = builder.Password(this.TxtPassword.Text);
                }
                Role role = builder.Build();
                Boolean rs = this.roleBLL.Add(role);
                if (rs)
                {
                    MessageBox.Show(String.Join(" ", "Add role ", role.Name, "sucessfull!"));
                }
                else
                {
                    MessageBox.Show(String.Join(" ", "Add role ", role.Name, "failed!"));
                }
            }
            else
            {
                MessageBox.Show(String.Join(" ", "You don't have ", CREATE_ROLE, "privilege!"));
            }
                
            this.SetEnable(true);
        }

        private void SetEnable(Boolean status)
        {
            this.TxtName.Enabled = status;
            this.TxtPassword.Enabled = status;
        }
    }
}
