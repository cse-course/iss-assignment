using BLL;
using Domain;
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
        private UserPrincipal currentUser;

        private readonly SysViewBLL view;
        public FrmUserDetail(SysViewBLL view, UserPrincipal currentUser)
        {
            this.view = view;
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void FrmUserDetail_Load(object sender, EventArgs e)
        {
            if (currentUser.IsAdmin)
            {
                DataSet data = this.view.UserDetail();
                this.DgvUserDetail.DataSource = data.Tables[0];
            }
            else
            {
                DataSet data = this.view.UserDetail(this.currentUser.UserName);
                this.DgvUserDetail.DataSource = data.Tables[0];
            }
            
        }
    }
}
