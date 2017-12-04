using BLL;
using Model;
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
    public partial class FrmAddRole : Form
    {
        private IRoleBLL roleBLL;
        public FrmAddRole(IRoleBLL roleBLL)
        {
            this.roleBLL = roleBLL;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.SetEnable(false);
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
            this.SetEnable(true);
        }

        private void SetEnable(Boolean status)
        {
            this.TxtName.Enabled = status;
            this.TxtPassword.Enabled = status;
        }
    }
}
