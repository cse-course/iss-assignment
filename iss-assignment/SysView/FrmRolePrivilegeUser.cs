using BLL;
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
    public partial class FrmRolePrivilegeUser : Form
    {
        private readonly SysViewBLL view;
        public FrmRolePrivilegeUser(SysViewBLL view)
        {
            this.view = view;
            InitializeComponent();
        }

        private void FrmRolePrivilegeUser_Load(object sender, EventArgs e)
        {
            DataSet data = this.view.RolePrivilegeUser();
            this.DgvRolePrivilegeUser.DataSource = data.Tables[0];
        }

        private void DgvRolePrivilegeUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
