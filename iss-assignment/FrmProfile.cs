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
    public partial class FrmProfile : Form
    {
        private readonly ProfileBLL profileBLL;

        public FrmProfile(ProfileBLL profileBLL)
        {
            this.profileBLL = profileBLL;
            InitializeComponent();
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
