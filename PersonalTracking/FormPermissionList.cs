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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonalTracking
{
    public partial class FormPermissionList : Form
    {
        public FormPermissionList()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtDayAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormPermission form = new FormPermission();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
            FillAllData();
            CleanFilters();
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            if (detail.PermissionID == 0)
                MessageBox.Show("please select a permission from the table");
            else
            {
                FormPermission form = new FormPermission();
                form.isUpdate = true;
                form.detail = detail;
                this.Hide();
                form.ShowDialog();
                this.Visible = true;
                FillAllData();
                CleanFilters();
            }

        }
        PermissionDTO dto = new PermissionDTO();
        private bool combofull;
        void FillAllData()
        {
            dto = PermissionBLL.GetAll();
            dataGridView1.DataSource = dto.Permissions;
            LoadDepartmentComboBox();
            comboBox1.DataSource = dto.Positions;
            comboBox1.DisplayMember = "PositionName";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = -1;
            combofull = true;
            cmbState.DataSource = dto.States;
            cmbState.DisplayMember = "StateName";
            cmbState.SelectedIndex = -1;
        }

        private void FormPermissionList_Load(object sender, EventArgs e)
        {
            FillAllData();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User Nº";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Surname";
            dataGridView1.Columns[4].Visible = false; ;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Start Date";
            dataGridView1.Columns[9].HeaderText = "End Date";
            dataGridView1.Columns[10].HeaderText = "Day Amount";
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[11].HeaderText = "State";
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            combofull = false;

        }

        private void LoadDepartmentComboBox()
        {
            var dep = new Department();
            dep.ID = 0;
            dep.DepartmentName = "--Select--";
            List<Department> listDep = new List<Department>();
            listDep.Add(dep);
            listDep.AddRange(dto.Departments);
            cmbDepartment.DataSource = listDep;
            cmbDepartment.SelectedIndex = 0;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<PermissionDetailDTO> list = dto.Permissions;
            if (txtUserNo.Text.Trim() != "")
                list = list.Where(x => x.UserNo == Convert.ToInt32(txtUserNo.Text)).ToList();
            if (txtName.Text.Trim() != "")
                list = list.Where(x => x.Name.Contains(txtName.Text.Trim())).ToList();
            if (txtSurname.Text.Trim() != "")
                list = list.Where(x => x.SurName.Contains(txtSurname.Text)).ToList();
            if (cmbDepartment.SelectedIndex != -1 && cmbDepartment.SelectedIndex != 0)
                list = list.Where(x => x.DepartmentID == Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
            if (comboBox1.SelectedIndex != -1)
                list = list.Where(x => x.PositionID == Convert.ToInt32(comboBox1.SelectedValue)).ToList();
            if (rbStartDate.Checked)
                list = list.Where(x => x.StarDate < Convert.ToDateTime(dpEnd.Value) &&
                    x.StarDate > Convert.ToDateTime(dpStat.Value)).ToList();
            else if (rbEndDate.Checked)
                list = list.Where(x => x.EndDate < Convert.ToDateTime(dpEnd.Value) &&
                x.EndDate > Convert.ToDateTime(dpStat.Value)).ToList();
            if (cmbState.SelectedIndex != -1)
                list = list.Where(x => x.State == Convert.ToInt32(cmbState.SelectedValue)).ToList();
            if (txtDayAmount.Text.Trim() != "")
                list = list.Where(x => x.PermissionDayAmout == Convert.ToInt32(txtDayAmount.Text)).ToList();
            {

            }

            dataGridView1.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanFilters();
        }

        private void CleanFilters()
        {
            txtUserNo.Clear();
            txtSurname.Clear();
            txtName.Clear();
            combofull = false;
            cmbDepartment.SelectedIndex = -1;
            comboBox1.DataSource = dto.Positions;
            comboBox1.SelectedIndex = -1;
            combofull = true;
            rbEndDate.Checked = false;
            rbStartDate.Checked = false;
            cmbState.SelectedIndex = -1;
            txtDayAmount.Clear();
            dataGridView1.DataSource = dto.Permissions;
        }
        PermissionDetailDTO detail = new PermissionDetailDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.PermissionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[14].Value);
            detail.StarDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            detail.EndDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            detail.Explanation = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            detail.UserNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            detail.State = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
            detail.PermissionDayAmout = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            PermissionBLL.UpdatePemission(detail.PermissionID, PermissionStates.Approved);
            MessageBox.Show("Approved");
            FillAllData();
            CleanFilters();
        }

        private void btnDisApproved_Click(object sender, EventArgs e)
        {
            PermissionBLL.UpdatePemission(detail.PermissionID, PermissionStates.Disapproved);
            MessageBox.Show("Disapproved");
            FillAllData();
            CleanFilters();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this permission", "warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (detail.State == PermissionStates.Approved || detail.State == PermissionStates.Disapproved)
                    MessageBox.Show("you cannot delete approved or disapproved permissions");
                else
                {
                 PermissionBLL.DeletePermission(detail.PermissionID);
                    MessageBox.Show("Permission was deleted");
                    FillAllData();
                    CleanFilters() ;
                }                
            }
        }
    }
}
