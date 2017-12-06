using BLL;
using Domain;
using System;
using System.Collections.Generic;
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
            this.LoadAll();
            this.LvwProfile.ContextMenuStrip = this.CmsProfile;
        }
        private void LoadAll()
        {
            this.InitHeader();
            this.LoadData();
        }
        private void InitHeader()
        {
            this.LvwProfile.Items.Clear();
            this.LvwProfile.Columns.Clear();
            this.LvwProfile.Columns.Add("Profile Name", 320, HorizontalAlignment.Center);
        }

        private void LoadData()
        {
            List<String> profiles = this.profileBLL.ListProfile();
            foreach (var item in profiles)
            {
                ListViewItem viewItem = this.LvwProfile.Items.Add(item);
                viewItem.SubItems.Add(item);
            }

        }


        private void LvwProfile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.BtnEdit_Click(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            String name = null;
            try
            {
                name = this.LvwProfile.SelectedItems?[0]?.Text;
            }
            catch { }
            
            if (name != null)
            {
                this.OpenProfileInfo(name);
            }
        }

        private void OpenProfileInfo(String name)
        {
            Profile profile = this.profileBLL.View(name);
            FrmProfileInfo frmProfile = new FrmProfileInfo(this.profileBLL, profile);
            frmProfile.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            String name = null;
            try
            {
                name = LvwProfile.SelectedItems?[0]?.Text;
            }
            catch { }

            if (name != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    ProfileBuilder builder = new ProfileBuilder(name);
                    this.profileBLL.Remove(builder.Build());
                    MessageBox.Show(String.Join(" ", "Delete profile ", name, "sucessfull!"));
                    this.LoadAll();
                }
            }
        }

        private void BtnDeleteCascade_Click(object sender, EventArgs e)
        {
            String name = null;
            try
            {
                name = LvwProfile.SelectedItems?[0]?.Text;
            }
            catch { }

            if (name != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    ProfileBuilder builder = new ProfileBuilder(name);
                    this.profileBLL.RemoveCascade(builder.Build());
                    MessageBox.Show(String.Join(" ", "Delete cascade profile ", name, "sucessfull!"));
                    this.LoadAll();
                }
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BtnEdit_Click(sender, e);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BtnDelete_Click(sender, e);
        }

        private void DeleteCascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BtnDeleteCascade_Click(sender, e);
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadAll();
        }
    }
}
