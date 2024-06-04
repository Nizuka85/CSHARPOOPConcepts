﻿using BLL;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!UserStatic.isAdmin)
            {
                EmployeeDTO dto = EmployeeBLL.GetAll();
                EmployeeDetailDTO detail=dto.Employees.First(x=> x.EmployeeID == UserStatic.EmployeeID);
                FormEmployee frm = new FormEmployee();
                frm.detail = detail;
                frm.isupdate = true;
                frm.Hide();
                frm.ShowDialog();
                this.Visible = true;
            }
            else
            {
                FormEmployeeList form = new FormEmployeeList();
                this.Hide();
                form.ShowDialog();
                this.Visible = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTaskList form = new FormTaskList();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            FormSalaryList form = new FormSalaryList();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            FormPermissionList form = new FormPermissionList();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            FormDepartmentList form = new FormDepartmentList();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            FormPositionList form = new FormPositionList();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            this.Hide();
            form.ShowDialog();

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!UserStatic.isAdmin)
            {
                btnDepartment.Visible = false;
                btnPosition.Visible = false;
                btnLogOut.Location = new Point(214, 189);
                btnExit.Location = new Point(389, 189);
            }
        }
    }
}
