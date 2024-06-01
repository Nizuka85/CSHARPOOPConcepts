using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
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
        public PositionDTO detail=new PositionDTO();
        public bool isupdate = false;

        private void FormPosition_Load(object sender, EventArgs e)
        {
            departmentsList = DepartmentBLL.GetDepartment();
            cmbDepartment.DataSource = departmentsList;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            if (isupdate)
            {
                txtPosition.Text=detail.PositionName;
                cmbDepartment.SelectedValue=detail.DepartmentID;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPosition.Text.Trim() == "")
                MessageBox.Show("Please fill the position name");
            else if (cmbDepartment.SelectedIndex == -1)
                MessageBox.Show("Please select a department");
            else
            {
                if (!isupdate)
                {
                    POSITION position = new POSITION();
                    position.PositionName = txtPosition.Text;
                    position.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                    BLL.PositionBLL.AddPosition(position);
                    MessageBox.Show("position was added");
                    txtPosition.Clear();
                    cmbDepartment.SelectedIndex = -1;
                }
                else
                {
                    POSITION position = new POSITION();
                    position.ID=detail.ID;
                    position.PositionName = txtPosition.Text;
                    position.DepartmentID=Convert.ToInt32(cmbDepartment.SelectedValue);
                    bool control = false;
                    if (Convert.ToInt32(cmbDepartment.SelectedValue) != detail.OldDepartmenteID)
                        control = true;
                    PositionBLL.UpdatePosition(position, control);
                    MessageBox.Show("Position was usdated");
                    this.Close();
                }
            }
        }
    }
}
