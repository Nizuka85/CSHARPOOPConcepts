﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.DTO;
using DAL;

namespace PersonalTracking
{
    public partial class FormSalaryList : Form
    {
        public FormSalaryList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormSalary form = new FormSalary();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
            FillAllData();
            CleanFillter();
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            FormSalary form = new FormSalary();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }
        SalaryDTO dto = new SalaryDTO();
        private bool combofull;
        void FillAllData()
        {
            dto = SalaryBLL.GetAll();
            dataGridView1.DataSource = dto.Salaries;
            combofull = false;
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbPosition.SelectedIndex = -1;
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            combofull = true;
            cmbMonth.DataSource = dto.Months;
            cmbMonth.DisplayMember = "MonthName";
            cmbMonth.ValueMember = "ID";
            cmbMonth.SelectedIndex = -1;
        }

        private void FormSalaryList_Load(object sender, EventArgs e)
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
            dataGridView1.Columns[8].HeaderText = "Month";
            dataGridView1.Columns[9].HeaderText = "Year";
            dataGridView1.Columns[11].HeaderText = "Salary";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                cmbPosition.DataSource = dto.Positions.Where(x => x.DepartmentID ==
                Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<SalaryDetailDTO> list = dto.Salaries;
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
            if (txtYear.Text.Trim() != "")
                list = list.Where(x => x.SalaryYear == Convert.ToInt32(txtsalary.Text)).ToList();
            if (cmbMonth.SelectedIndex != -1)
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonth.SelectedValue)).ToList();
            if (txtsalary.Text.Trim() != "")
            {
                if (rbMore.Checked)
                    list = list.Where(x => x.SalaryAmount < Convert.ToInt32(txtsalary.Text)).ToList();
                else if (rbLess.Checked)
                    list = list.Where(x => x.SalaryAmount < Convert.ToInt32(txtsalary.Text)).ToList();
                else
                    list = list.Where(x => x.SalaryAmount == Convert.ToInt32(txtsalary.Text)).ToList();
            }

            dataGridView1.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanFillter();
        }

        private void CleanFillter()
        {
            txtUserNo.Clear();
            txtSurname.Clear();
            txtName.Clear();
            combofull = false;
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
            cmbMonth.SelectedIndex = -1;
            rbMore.Checked = false;
            rbEqual.Checked = false;
            rbLess.Checked = false;
            txtYear.Clear();
            txtsalary.Clear();
            dataGridView1.DataSource = dto.Salaries;
        }
    }
}
