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
    public partial class FrmAddRoleToUser : Form
    {
        public string frmParamUsername = "";
        private readonly UserManagementClassicBLL OracleView;
        public FrmAddRoleToUser(UserManagementClassicBLL OracleView)
        {
            this.OracleView = OracleView;
            InitializeComponent();
        }

        private void FrmAddRoleToUser_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        public void LoadData()
        {
            this.AddColumnLvwRole();
            this.LoadDataLvwRole();
        }
        private void AddColumnLvwRole()
        {
            LvwRole.CheckBoxes = true;
            LvwRole.GridLines = true;
            LvwRole.Items.Clear();
            LvwRole.Columns.Clear();
            LvwRole.Columns.Add("ROLES", 200);
        }
        private void LoadDataLvwRole()
        {

            AddColumnLvwRole();
            DataSet ds = OracleView.GetDistincRoleName();
            DataTable dt = ds.Tables[0];
            ListViewItem it;
            foreach (DataRow dr in dt.Rows)
            {

                it = LvwRole.Items.Add(dr[0].ToString());
            }
        }
        private void AddRoleFromForm()
        {
            foreach (ListViewItem eachItem in LvwRole.CheckedItems)
            {
                string SelectedRole = eachItem.Text;
                this.OracleView.AddRoleToUser(frmParamUsername, SelectedRole);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.AddRoleFromForm();
            Close();
        }
    }
}
