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
    public partial class FrmRolePrivilege : Form
    {
        private IPrivilegeBLL privilegeBLL;
        public FrmRolePrivilege(IPrivilegeBLL privilegeBLL)
        {
            this.privilegeBLL = privilegeBLL;
            InitializeComponent();
        }

        private void FrmRolePrivilege_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
