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
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDepartment.Text.Trim() == "")
                MessageBox.Show("Please Fill Name Field");
            else
            {
                Department department = new Department();
                if (!isupdate)
                {
                    department.DepartmentName = txtDepartment.Text;
                    BLL.DepartmentBLL.AddDepartment(department);
                    MessageBox.Show("Department Was Added");
                    txtDepartment.Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "warning!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        department.ID=detail.ID;
                        department.DepartmentName=txtDepartment.Text;
                        DepartmentBLL.UpdateDepartment(department);
                        MessageBox.Show("Department was Updated");
                        this.Close();
                    }
                }
            }


        }
        public bool isupdate=false;
        public Department detail=new Department();
        private void FormDepartment_Load(object sender, EventArgs e)
        {
            if(!isupdate)
                txtDepartment.Text=detail.DepartmentName;
        }
    }
}
