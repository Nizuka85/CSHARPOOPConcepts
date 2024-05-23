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
    public partial class FormTaskList : Form
    {
        public FormTaskList()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanFilter();

            
        }
        private void CleanFilter()
        {
            txtUserNo.Clear();
            txtSurname.Clear();
            txtName.Clear();
            combofull = false;
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
            rbDeliveryDate.Checked = false;
            rbStartDate.Checked = false;
            cmbTaskState.SelectedIndex = -1;
            dataGridView1.DataSource = dto.Tasks;
        }



        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<TaskDetailDTO> list = dto.Tasks;
            if (txtUserNo.Text.Trim() != "")
                list = list.Where(x => x.UserNo == Convert.ToInt32(txtUserNo.Text)).ToList();
            if (labelll.Text.Trim() != "")
                list = list.Where(x => x.Name.Contains(labelll.Text.Trim())).ToList();
            if (txtSurname.Text.Trim() != "")
                list = list.Where(x => x.SurName.Contains(txtSurname.Text)).ToList();
            if (cmbDepartment.SelectedIndex != -1)
                list = list.Where(x => x.DepartmentID == Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
            if (cmbPosition.SelectedIndex != -1)
                list = list.Where(x => x.PositionID == Convert.ToInt32(cmbPosition.SelectedValue)).ToList();
            if(rbStartDate.Checked)            
                list=list.Where(x=>x.TaskSartDate>Convert.ToDateTime(dpStat.Value) && x.TaskSartDate<Convert.ToDateTime(dpFinish.Value)).ToList();
            if (rbDeliveryDate.Checked)
                list =list.Where(x=>x.TackDeliveryDate> Convert.ToDateTime(dpStat.Value) && x.TackDeliveryDate< Convert.ToDateTime(dpFinish.Value)).ToList();
            if (cmbTaskState.SelectedIndex != -1)
                list = list.Where(x => x.taskStateID == Convert.ToInt32(cmbTaskState.SelectedValue)).ToList();
            dataGridView1.DataSource = list;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TaskDTO dto = new TaskDTO();
        private bool combofull = false;
        void FillAllData()
        {
            dto = TaskBLL.GetAll();
            dataGridView1.DataSource = dto.Tasks;
            combofull = false;
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
            cmbTaskState.DataSource = dto.TaskSatates;
            cmbTaskState.DisplayMember = "StateName";
            cmbTaskState.SelectedIndex = -1;
        }
        private void FormTaskList_Load(object sender, EventArgs e)
        {
           FillAllData();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User Nº";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Surname";
            dataGridView1.Columns[4].HeaderText = "Start Date";
            dataGridView1.Columns[5].HeaderText = "Delivery Date";
            dataGridView1.Columns[6].HeaderText = "Task State";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormTask form = new FormTask();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
            FillAllData();
            CleanFilter();
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            FormTask form = new FormTask();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {

                if (cmbDepartment.ValueMember.ToString() != "0")
                {
                    dataGridView1.DataSource = dto.Employees.Where(x => x.DepartmentID == Convert.ToInt32(cmbDepartment.ValueMember)).ToList();
                    cmbPosition.DataSource = dto.Positions.Where(x => x.DepartmentID == Convert.ToInt32(cmbDepartment.ValueMember)).ToList();
                }
                else
                {        
                    LoadDepartmentComboBox();
                    dataGridView1.DataSource = dto.Employees;
                    cmbPosition.DataSource = dto.Positions;
                    cmbPosition.SelectedIndex = -1;
            }    }
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
    }
}
