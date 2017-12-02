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
    public partial class FrmUserManagerment : Form
    {
        private readonly UserManagementBLL view;
        public FrmUserManagerment(UserManagementBLL view)
        {
            this.view = view;
            InitializeComponent();
        }

        private void FrmUserManagerment_Load(object sender, EventArgs e)
        {
            //this.DgvUserManagerment.DataSource = this.view.GetAll();
            this.DgvUserManagerment.DataSource = this.view.GetUserInfo();
        }
    }
}
