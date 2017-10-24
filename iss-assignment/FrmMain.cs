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
        public FrmMain()
        {
            InitializeComponent();

            this.context = new IISEntities();
            this.sysViewBLL = new SysViewBLL(this.context);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmUserPrivilege user = new FrmUserPrivilege(this.sysViewBLL)
            {
                MdiParent = this
            };
            user.Show();
        }
    }
}
