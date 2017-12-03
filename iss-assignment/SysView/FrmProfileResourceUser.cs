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
    public partial class FrmProfileResourceUser : Form
    {
        private readonly SysViewBLL view;
        public FrmProfileResourceUser(SysViewBLL view)
        {
            this.view = view;
            InitializeComponent();
        }

        private void FrmProfileResourceUser_Load(object sender, EventArgs e)
        {
            DataSet data = this.view.ProfileResourceUser();
            this.DgvProfileResourceUser.DataSource = data.Tables[0];
        }
    }
}
