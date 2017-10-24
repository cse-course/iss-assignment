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
    public partial class FrmUserDetail : Form
    {
        private readonly SysViewBLL view;
        public FrmUserDetail(SysViewBLL view)
        {
            this.view = view;
            InitializeComponent();
        }

        private void FrmUserDetail_Load(object sender, EventArgs e)
        {
            DataSet data = this.view.UserDetail();
            this.DgvUserDetail.DataSource = data.Tables[0];
        }
    }
}
