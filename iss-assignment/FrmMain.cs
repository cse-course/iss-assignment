using BLL;
using DAL;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace iss_assignment
{
    public partial class FrmMain : Form
    {
        private readonly DbContext context;

        private readonly SysViewBLL sysViewBLL;

        private readonly UserManagementBLL userManagementBLL;

        private readonly UserManagementClassicBLL userManagementClassicBLL;

        private readonly IProfileBLL profileBLL;

        private readonly IRoleBLL roleBLL;

        private readonly IPrivilegeBLL privilegeBLL;

        public FrmMain()
        {
            InitializeComponent();

            this.context = new IISEntities();
            this.sysViewBLL = new SysViewBLL(this.context);

            this.userManagementBLL = new UserManagementBLL(this.context);
            this.userManagementClassicBLL = new UserManagementClassicBLL(this.context);

            this.profileBLL = new ProfileBLL(this.context);
            this.roleBLL = new RoleBLL(this.context);
            this.privilegeBLL = new PrivilegeBLL(this.context);
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

        private void ShowAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserManagerment user = new FrmUserManagerment(this.userManagementBLL, this.userManagementClassicBLL)
            {
                MdiParent = this
            };
            user.Show();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUser user = new FrmAddUser(this.userManagementBLL, this.userManagementClassicBLL)
            {
                MdiParent = this
            };
            user.Show();
        }

        private void ShowAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProfile profile = new FrmProfile(this.profileBLL)
            {
                MdiParent = this
            };
            profile.Show();
        }

        private void AddProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfileInfo profile = new FrmProfileInfo(this.profileBLL)
            {
                MdiParent = this
            };
            profile.Show();
        }

        private void ShowAllToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmRole profile = new FrmRole(this.roleBLL)
            {
                MdiParent = this
            };
            profile.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAddRole profile = new FrmAddRole(this.roleBLL)
            {
                MdiParent = this
            };
            profile.Show();
        }

        private void SystemPrivilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSystemPrivilege frm = new FrmSystemPrivilege(this.privilegeBLL)
            {
                MdiParent = this
            };
            frm.Show();
        }
    }
}
