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
    public partial class FrmAddProfileToUser : Form
    {
        private readonly UserManagementClassicBLL OracleView;
        public string frmParamUsername = "";
        public string frmParamProfile = "";
        public FrmAddProfileToUser(UserManagementClassicBLL OracleView)
        {
            this.OracleView = OracleView;
            InitializeComponent();
        }

        private void FrmAddProfileToUser_Load(object sender, EventArgs e)
        {
            LoadData();
            LblCaution.Text = "Current profile user " + frmParamUsername + " : " + frmParamProfile;
        }

        private void LoadData()
        {
            LoadDataLvwProfile();
        }

        private void LoadDataLvwProfile()
        {
            this.AddColumnLvwProfile();
            DataSet ds = OracleView.GetDistincProfileName();
            DataTable dt = ds.Tables[0];
            ListViewItem it;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString() != frmParamProfile)
                {
                    it = LvwProfile.Items.Add(dr[0].ToString());
                }
            }
        }
        private void AddColumnLvwProfile()
        {
            LvwProfile.CheckBoxes = true;
            LvwProfile.GridLines = true;
            LvwProfile.Items.Clear();
            LvwProfile.Columns.Clear();
            LvwProfile.Columns.Add("Profile", 300);
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            this.AddProfileFromForm();
            Close();
        }

        private void AddProfileFromForm()
        {
            foreach (ListViewItem eachItem in LvwProfile.CheckedItems)
            {
                string SelectedProfile = eachItem.Text;
                this.OracleView.AddProfileToUser(frmParamUsername, SelectedProfile);
            }
        }
    }
}
