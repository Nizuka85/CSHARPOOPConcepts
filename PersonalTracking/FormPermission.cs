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
using DAL.DTO;

namespace PersonalTracking
{
    public partial class FormPermission : Form
    {
        public FormPermission()
        {
            InitializeComponent();
        }
        TimeSpan PermissionDay;
        public bool isUpdate= false;
        public PermissionDetailDTO detail = new PermissionDetailDTO();
        private void FormPermission_Load(object sender, EventArgs e)
        {
            txtUserNo.Text = UserStatic.UserNo.ToString();
            if (isUpdate )
            {
                dpStart.Value= detail.StarDate;
                dpEnd.Value= detail.StarDate;
                txtDayAmount.Text= detail.PermissionDayAmout.ToString();
                txtExplanation.Text= detail.Explanation;
                txtUserNo.Text= detail.UserNo.ToString();
            }
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
                if (!isUpdate)
                {
                    permission.EmployeeID = UserStatic.EmployeeID;
                    permission.PermissionState = 1;
                    permission.PermissionStarDate = dpStart.Value.Date;
                    permission.PermissionEndDate = dpEnd.Value.Date;
                    permission.PermissionDay = Convert.ToInt32(txtDayAmount.Text);
                    permission.PermissionExplanation = txtExplanation.Text;
                    PermissionBLL.AddPermission(permission);
                    MessageBox.Show("Permission was added");
                    permission = new PERMISSION();
                    dpStart.Value = DateTime.Today;
                    dpEnd.Value = DateTime.Today;
                    txtDayAmount.Clear();
                    txtExplanation.Clear();
                }
                else if (isUpdate)
                {
                    DialogResult result = MessageBox.Show("Are you sure"," Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        permission.ID = detail.PermissionID;
                        permission.PermissionExplanation = txtExplanation.Text;
                        permission.PermissionStarDate = dpStart.Value.Date;
                        permission.PermissionEndDate = dpEnd.Value.Date;
                        permission.PermissionDay = Convert.ToInt32(txtDayAmount.Text);
                        PermissionBLL.UpdatePemission(permission);
                        MessageBox.Show("Permission was Update");
                        this.Close();
                    }

                }
            }
        }
    }
}
