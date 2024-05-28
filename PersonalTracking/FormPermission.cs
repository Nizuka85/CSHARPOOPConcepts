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
using DAL;

namespace PersonalTracking
{
    public partial class FormPermission : Form
    {
        public FormPermission()
        {
            InitializeComponent();
        }
        TimeSpan PermissionDay;
        private void FormPermission_Load(object sender, EventArgs e)
        {
            txtUserNo.Text = UserStatic.UserNo.ToString();
        }

        private void dpFinish_ValueChanged(object sender, EventArgs e)
        {
            PermissionDay = dpEnd.Value - dpStart.Value.Date;
            txtDayAmount.Text = PermissionDay.TotalDays.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dpStat_ValueChanged(object sender, EventArgs e)
        {
            PermissionDay = dpEnd.Value - dpStart.Value.Date;
            txtDayAmount.Text = PermissionDay.TotalDays.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDayAmount.Text.Trim() == "")
                MessageBox.Show("please change end or start date");
            else if (Convert.ToInt32(txtDayAmount.Text) <= 0)
                MessageBox.Show("Permission day must be bigger than 0");
            else if (txtExplanation.Text.Trim() == "")
                MessageBox.Show("Explanetion is empty");
            else
            {
                PERMISSION permission = new PERMISSION();
                permission.EmployeeID = UserStatic.EmployeeID;
                permission.PermissionState = 1;
                permission.PermissionStarDate= dpStart.Value.Date;
                permission.PermissionEndDate = dpEnd.Value.Date;
                permission.PermissionDay = Convert.ToInt32(txtDayAmount.Text);
                permission.PermissionExplanation = txtExplanation.Text;
                PermissionBLL.AddPermission(permission);
                MessageBox.Show("Permission was added");
                permission = new PERMISSION();
                dpStart.Value= DateTime.Today;
                dpEnd.Value= DateTime.Today;
                txtDayAmount.Clear();
                txtExplanation.Clear();
            }
        }
    }
}
