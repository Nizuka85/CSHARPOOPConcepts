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
    public partial class FormEmployeeList : Form
    {
        public FormEmployeeList()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormEmployee form = new FormEmployee();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
            FillAllData();
            CleanFilters();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            if (detail.EmployeeID == 0)
                MessageBox.Show("Please select an employee on table");
            else
            {
                FormEmployee form = new FormEmployee();
                form.isupdate = true;
                form.detail = detail;
                this.Hide();
                form.ShowDialog();
                this.Visible = true;
                FillAllData();
                CleanFilters();
            }

        }
        EmployeeDTO dto = new EmployeeDTO();
        private bool combofull = false;
        public EmployeeDetailDTO detail = new EmployeeDetailDTO();
        void FillAllData()
        {
            dto = EmployeeBLL.GetAll();
            dataGridView1.DataSource = dto.Employees;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User Nº";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Surname";
            dataGridView1.Columns[4].HeaderText = "Department";
            dataGridView1.Columns[5].HeaderText = "Position";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Salary";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            combofull = false;
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbPosition.DataSource = dto.positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
        }
        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                cmbPosition.DataSource = dto.positions.Where(x => x.DepartmentID ==
                Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
            }
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
            cmbPosition.DataSource = dto.positions;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
            dataGridView1.DataSource = dto.Employees;
        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {
            FillAllData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<EmployeeDetailDTO> list = dto.Employees;
            if (txtUserNo.Text.Trim() != "")
                list = list.Where(x => x.UserNo == Convert.ToInt32(txtUserNo.Text)).ToList();
            if (txtName.Text.Trim() != "")
                list = list.Where(x => x.Name.Contains(txtName.Text.Trim())).ToList();
            if (txtSurname.Text.Trim() != "")
                list = list.Where(x => x.SurName.Contains(txtSurname.Text)).ToList();
            if (cmbDepartment.SelectedIndex != -1)
                list = list.Where(x => x.DepartmentID == Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
            if (cmbPosition.SelectedIndex != -1)
                list = list.Where(x => x.PositionID == Convert.ToInt32(cmbPosition.SelectedValue)).ToList();
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.Name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            detail.SurName = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            detail.Password = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            detail.ImagemPath = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            detail.Adress = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            detail.isAdmin = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            detail.BrirtDay = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[13].Value);
            detail.UserNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            detail.DepartmentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            detail.PositionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            detail.EmployeeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.Salary = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this Employee", "warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                EmployeeBLL.DeleteEmployee(detail.EmployeeID);
                MessageBox.Show("Employee was Deleted");
                FillAllData();
                CleanFilters();
        }   }
    }
}
