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
    public partial class FormDepartmentList : Form
    {
        public FormDepartmentList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormDepartment form = new FormDepartment();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
            list = DepartmentBLL.GetDepartment();
            dataGridView1.DataSource = list;
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
                MessageBox.Show("Please select a Department from Table");
            else
            {
                FormDepartment form = new FormDepartment();
                form.isupdate = true;
                form.detail = detail;
                this.Hide();
                form.ShowDialog();
                this.Visible = true;
                list = DepartmentBLL.GetDepartment();
                dataGridView1.DataSource = list;
            }
        }
        List<Department> list = new List<Department>();
        public Department detail = new Department();
        private void FormDepartmentList_Load(object sender, EventArgs e)
        {

            list = DepartmentBLL.GetDepartment();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Department Name";
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.DepartmentName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this Department", "warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DepartmentBLL.DeleteDepartment(detail.ID);
                MessageBox.Show("Department was Deleted");
                list = DepartmentBLL.GetDepartment();
                dataGridView1.DataSource = list;
            }
        }
    }
}
