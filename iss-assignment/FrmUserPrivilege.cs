using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
namespace iss_assignment
{
    public partial class FrmUserPrivilege : Form
    {
        private readonly SysViewBLL view; 
        public FrmUserPrivilege(SysViewBLL view)
        {
            this.view = view;
            InitializeComponent();
        }

        private void FrmUserPrivilege_Load(object sender, EventArgs e)
        {
            DataSet data = this.view.UserPrivilege();
            this.DgvUserPrivilege.DataSource = data.Tables[0];
        }
    }
}
