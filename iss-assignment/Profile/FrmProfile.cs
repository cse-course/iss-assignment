using BLL;
using Model;
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
        private readonly IProfileBLL profileBLL;

        public FrmProfile(IProfileBLL profileBLL)
        {
            this.profileBLL = profileBLL;
            InitializeComponent();
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            this.InitHeader();
            this.LoadData();
        }

        private void InitHeader()
        {
            this.LvwProfile.Items.Clear();
            this.LvwProfile.Columns.Clear();
            this.LvwProfile.Columns.Add("Name", 300, HorizontalAlignment.Center);
        }

        private void LoadData()
        {
            List<String> profiles = this.profileBLL.ListProfile();
            foreach (var item in profiles)
            {
                Console.WriteLine(item);
                ListViewItem viewItem = this.LvwProfile.Items.Add(item);
                viewItem.SubItems.Add(item);
            }

        }


        private void LvwProfile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String name = LvwProfile.SelectedItems[0].Text;
            Console.WriteLine(name);
            Profile profile = this.profileBLL.View(name);
            FrmProfileInfo frmProfile = new FrmProfileInfo(this.profileBLL, profile);
            frmProfile.Show();
        }
    }
}
