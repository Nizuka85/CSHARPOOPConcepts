using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PersonalTracking
{
    public partial class FormPosition : Form
    {
        public FormPosition()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<Department> departmentsList = new List<Department>();

        private void FormPosition_Load(object sender, EventArgs e)
        {
            departmentsList = DepartmentBLL.GetDepartment();
            cmbDepartment.DataSource = departmentsList;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            
        }
    }
}
