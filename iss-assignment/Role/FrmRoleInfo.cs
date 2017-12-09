using BLL;
using Domain;
using System;
using System.Windows.Forms;

namespace iss_assignment
{
    public partial class FrmRoleInfo : Form
    {
        private static string CREATE_ROLE = "CREATE ROLE";
        private Role role;

        private IRoleBLL roleBLL;

        private IPrivilegeBLL privilegeBLL;

        private UserPrincipal currentUser;

        public FrmRoleInfo(IPrivilegeBLL privilegeBLL, IRoleBLL roleBLL, Role role, UserPrincipal currentUser)
        {
            this.privilegeBLL = privilegeBLL;
            this.roleBLL = roleBLL;
            this.role = role;
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void FrmRoleInfo_Load(object sender, EventArgs e)
        {
            if (this.role != null)
            {
                this.TxtName.Text = role.Name;
                this.LblPassword.Text = role.Password;
                this.SetEnable(false);
            }
        }

        private void SetEnable(Boolean status)
        {
            this.TxtName.Enabled = status;
            this.LblPassword.Enabled = status;
        }

        /// <summary>
        /// You must have the CREATE ROLE system privilege.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Privilege privilege = new Privilege
            {
                Name = CREATE_ROLE
            };
            bool check = this.privilegeBLL.HasRolePrivilege(this.currentUser.UserName, privilege);
            if (check)
            {
                RoleBuilder builder = new RoleBuilder(this.TxtName.Text);
                Role role = builder.Password(this.TxtPassword.Text).Build();
                Boolean rs = this.roleBLL.Update(role);
                if (rs)
                {
                    MessageBox.Show(String.Join(" ", "Save role ", role.Name, "sucessfull!"));
                }
                else
                {
                    MessageBox.Show(String.Join(" ", "Cannot save role ", role.Name));
                }
            }
            else
            {
                MessageBox.Show(String.Join(" ", "You don't have ", CREATE_ROLE, "privilege!"));
            }
           
        }
    }
}
