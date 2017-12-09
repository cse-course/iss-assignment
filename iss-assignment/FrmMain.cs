using BLL;
using DAL;
using Domain;
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

        public UserPrincipal currentUser;

        public FrmMain()
        {
            InitializeComponent();
            this.currentUser = new UserPrincipal();

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
            this.LoadLogin();
        }

        private void LoadLogin()
        {
            this.StatusAll(false);
            this.SetStatus("Ready");
            FrmUserLogin login = new FrmUserLogin(this, this.userManagementBLL, this.currentUser)
            {
                MdiParent = this
            };
            login.Show();

        }

        private void UserPrifilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.currentUser.IsAdmin)
            {
                FrmUserPrivilege user = new FrmUserPrivilege(this.sysViewBLL)
                {
                    MdiParent = this
                };
                user.Show();
            }
        }

        private void UserDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.currentUser.IsLogin())
            {
                FrmUserDetail user = new FrmUserDetail(this.sysViewBLL, this.currentUser)
                {
                    MdiParent = this
                };
                user.Show();
            }

        }

        private void ProfileResourceUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.currentUser.IsAdmin)
            {
                FrmProfileResourceUser user = new FrmProfileResourceUser(this.sysViewBLL)
                {
                    MdiParent = this
                };
                user.Show();
            }
            
        }

        private void RolePrivilegeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.currentUser.IsLogin())
            {
                FrmRolePrivilegeUser user = new FrmRolePrivilegeUser(this.sysViewBLL)
                {
                    MdiParent = this
                };
                user.Show();
            }
            
        }

        private void ShowAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.currentUser.IsLogin())
            {
                FrmUserManagerment user = new FrmUserManagerment(this.userManagementBLL, this.userManagementClassicBLL)
                {
                    MdiParent = this
                };
                user.Show();
            }
            
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.currentUser.IsLogin())
            {
                FrmAddUser user = new FrmAddUser(this.privilegeBLL, this.userManagementBLL, this.userManagementClassicBLL, this.currentUser)
                {
                    MdiParent = this
                };
                user.Show();
            }
            
        }

        private void ShowAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.currentUser.IsLogin())
            {
                FrmProfile profile = new FrmProfile(this.profileBLL)
                {
                    MdiParent = this
                };
                profile.Show();
            }
            
        }

        private void AddProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.currentUser.IsLogin())
            {
                FrmProfileInfo profile = new FrmProfileInfo(this.privilegeBLL, this.profileBLL, this.currentUser)
                {
                    MdiParent = this
                };
                profile.Show();
            }
            
        }

        private void ShowAllToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.currentUser.IsLogin())
            {
                FrmRole profile = new FrmRole(this.privilegeBLL, this.roleBLL, this.currentUser)
                {
                    MdiParent = this
                };
                profile.Show();
            }
            
        }

        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.currentUser.IsLogin())
            {
                FrmAddRole profile = new FrmAddRole(this.privilegeBLL, this.roleBLL, this.currentUser)
                {
                    MdiParent = this
                };
                profile.Show();
            }
            
        }

        private void SystemPrivilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.currentUser.IsLogin())
            {
                FrmGrantSystemPrivilege frm = new FrmGrantSystemPrivilege(this.privilegeBLL, this.roleBLL, this.userManagementBLL, this.currentUser)
                {
                    MdiParent = this
                };
                frm.Show();
            }
            
        }

        private void GrantRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.currentUser.IsLogin())
            {
                FrmGrantRolePrivilege frm = new FrmGrantRolePrivilege(this.privilegeBLL, this.roleBLL, this.userManagementBLL, this.currentUser)
                {
                    MdiParent = this
                };
                frm.Show();
            }

        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StatusAll(false);
            if (this.currentUser.IsLogin())
            {
                this.currentUser.UserName = "";
                this.currentUser.IsAdmin = false;
                this.LoadLogin();
            }
        }


        private void Status(Boolean status)
        {
            this.logoutToolStripMenuItem.Enabled = status;

            this.userPrifilegeToolStripMenuItem.Enabled = status;
            this.userDetailToolStripMenuItem.Enabled = status;
            this.profileResourceUserToolStripMenuItem.Enabled = status;
            this.rolePrivilegeUserToolStripMenuItem.Enabled = status;

            this.showAllUserToolStripMenuItem.Enabled = status;
            this.addUserToolStripMenuItem.Enabled = status;

            this.showAllProfileToolStripMenuItem.Enabled = status;
            this.addProfileToolStripMenuItem.Enabled = status;

            this.showAllRoleToolStripMenuItem.Enabled = status;
            this.addRoleToolStripMenuItem.Enabled = status;

            this.systemPrivilegeToolStripMenuItem.Enabled = status;
            this.grantRoleToolStripMenuItem.Enabled = status;
        }

        public void StatusAll(Boolean status)
        {
            this.Status(status);

            if (!this.currentUser.IsAdmin)
            {
                this.userPrifilegeToolStripMenuItem.Enabled = false;
                this.profileResourceUserToolStripMenuItem.Enabled = false;
                this.rolePrivilegeUserToolStripMenuItem.Enabled = false;
            }
        }

        public void SetStatus(String status)
        {
            this.tssMain.Text = status;
        }
    }
}
