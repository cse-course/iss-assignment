using BLL;
using Domain;
using System;
using System.Windows.Forms;

namespace iss_assignment
{
    public partial class FrmRoleInfo : Form
    {
        private Role role;
        private IRoleBLL roleBLL;
        public FrmRoleInfo(IRoleBLL roleBLL, Role role)
        {
            this.roleBLL = roleBLL;
            this.role = role;
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

        private void BtnSave_Click(object sender, EventArgs e)
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
    }
}
