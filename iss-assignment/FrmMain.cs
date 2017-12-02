using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iss_assignment
{
    public partial class FrmMain : Form
    {
        private readonly DbContext context;

        private readonly SysViewBLL sysViewBLL;

        private readonly UserManagementBLL userManagementBLL;

        public FrmMain()
        {
            InitializeComponent();

            this.context = new IISEntities();
            this.sysViewBLL = new SysViewBLL(this.context);

            this.userManagementBLL = new UserManagementBLL(this.context);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //full screen
            this.WindowState = FormWindowState.Maximized;

            FrmUserLogin login = new FrmUserLogin
            {
                MdiParent = this
            };
            login.Show();

        }

        private void UserPrifilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserPrivilege user = new FrmUserPrivilege(this.sysViewBLL)
            {
                MdiParent = this
            };
            user.Show();
        }

        private void UserDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserDetail user = new FrmUserDetail(this.sysViewBLL)
            {
                MdiParent = this
            };
            user.Show();
        }

        private void ProfileResourceUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfileResourceUser user = new FrmProfileResourceUser(this.sysViewBLL)
            {
                MdiParent = this
            };
            user.Show();
        }

        private void RolePrivilegeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRolePrivilegeUser user = new FrmRolePrivilegeUser(this.sysViewBLL)
            {
                MdiParent = this
            };
            user.Show();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserManagerment user = new FrmUserManagerment(this.userManagementBLL)
            {
                MdiParent = this
            };
            user.Show();
        }

        private void oneUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo user = new frmUserInfo(this.userManagementBLL)
            {
                MdiParent = this
            };
            user.Show();

        }
    }
}
