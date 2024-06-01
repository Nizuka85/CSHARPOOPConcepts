using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using DAL.DTO;
using System.IO;

namespace PersonalTracking
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }
        EmployeeDTO dto = new EmployeeDTO();
        public EmployeeDetailDTO detail=new EmployeeDetailDTO();
        public bool isupdate=false;
        string imagepath = "";

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            dto = EmployeeBLL.GetAll();
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbPosition.DataSource = dto.positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
            if (isupdate)
            {
                txtName.Text=detail.Name;
                txtSurname.Text = detail.SurName;
                txtUserNo.Text=detail.UserNo.ToString();
                txtPassword.Text=detail.Password;
                chAdmin.Checked=Convert.ToBoolean(detail.isAdmin);
                txtaddres.Text = detail.Adress;
                dateTimePicker1.Value=Convert.ToDateTime(detail.BrirtDay);
                cmbDepartment.SelectedValue = detail.DepartmentID;
                cmbPosition.SelectedValue = detail.PositionID;
                txtSalary.Text= detail.Salary.ToString();
                imagepath=Application.StartupPath+ "\\images\\" + detail.ImagemPath;
                txtImagePath.Text=imagepath;
                pictureBox1.ImageLocation =imagepath;

            }
        }
        bool combofull = false;
        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                cmbPosition.DataSource = dto.positions.Where(x => x.DepartmentID == departmentID).ToList();
            }


        }
        string fileName = "";

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                txtImagePath.Text = openFileDialog1.FileName;
                string Unique = Guid.NewGuid().ToString();
                fileName += Unique + openFileDialog1.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("User No is Empy");

            
            else if (txtPassword.Text.Trim() == "")
                MessageBox.Show("Passoword is Empy");
            else if (txtName.Text.Trim() == "")
                MessageBox.Show("Name is Empy");
            else if (txtSurname.Text.Trim() == "")
                MessageBox.Show("Surname is Empy");
            else if (txtSalary.Text.Trim() == "")
                MessageBox.Show("Salary is Empy");
            else if (cmbDepartment.Text.Trim() == "")
                MessageBox.Show("Select a Departament");
            else if (cmbPosition.Text.Trim() == "")
                MessageBox.Show("Select a Position");
            else
            {
                if (!isupdate)
                {
                    if (!EmployeeBLL.isUnique(Convert.ToInt32(txtUserNo.Text)))
                        MessageBox.Show("This user nº is used by another employee please change");
                    else
                    {
                        EMPLOYEE employee = new EMPLOYEE();
                        employee.UserNo = Convert.ToInt32(txtUserNo.Text);
                        employee.Password = txtPassword.Text;
                        employee.isAdmin = chAdmin.Checked;
                        employee.Name = txtName.Text;
                        employee.SurName = txtSurname.Text;
                        employee.Salary = Convert.ToInt32(txtSalary.Text);
                        employee.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                        employee.PositionID = Convert.ToInt32(cmbPosition.SelectedValue);
                        employee.Adress = txtaddres.Text;
                        employee.BirtDay = dateTimePicker1.Value;
                        employee.ImagePath = fileName;
                        EmployeeBLL.AddEmployee(employee);
                        try
                        {
                            File.Copy(txtImagePath.Text, @"images\\" + fileName);
                        }
                        catch (Exception)
                        {
                        }

                        MessageBox.Show("Employee was added");
                        txtUserNo.Clear();
                        txtPassword.Clear();
                        chAdmin.Checked = false;
                        txtName.Clear();
                        txtSurname.Clear();
                        txtSalary.Clear();
                        txtaddres.Clear();
                        txtImagePath.Clear();
                        pictureBox1.Image = null;
                        combofull = false;
                        cmbDepartment.SelectedIndex = -1;
                        cmbPosition.DataSource = dto.positions;
                        cmbPosition.SelectedIndex = -1;
                        combofull = true;
                        dateTimePicker1.Value = DateTime.Today;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure", "warning", MessageBoxButtons.YesNo);
                    if(result== DialogResult.Yes)
                    {
                        EMPLOYEE employee= new EMPLOYEE();
                        if (txtImagePath.Text != imagepath)
                        {
                            if (File.Exists(@"images\\" + detail.ImagemPath))
                                File.Delete(@"images\\" + detail.ImagemPath);
                            File.Copy(txtImagePath.Text, @"images\\" + fileName);
                            employee.ImagePath=fileName;
                        }
                        else
                            employee.ImagePath = detail.ImagemPath;
                        employee.ID=detail.EmployeeID;
                        employee.UserNo = Convert.ToInt32(txtUserNo.Text);
                        employee.Name=txtName.Text;
                        employee.SurName=txtSurname.Text;
                        employee.isAdmin=chAdmin.Checked;
                        employee.Password=txtPassword.Text;
                        employee.Adress=txtaddres.Text;
                        employee.BirtDay= dateTimePicker1.Value;
                        employee.DepartmentID=Convert.ToInt32(cmbDepartment.SelectedValue); 
                        employee.PositionID=Convert.ToInt32(cmbPosition.SelectedValue);
                        employee.Salary=Convert.ToInt32(txtSalary.Text);
                        EmployeeBLL.UpdateEmployee(employee);
                        MessageBox.Show("Employee was update");
                        this.Close();

                    }


                }
            }
        }
        bool isUnique = false;
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("User No is Empy");
            else
            {
                isUnique=EmployeeBLL.isUnique(Convert.ToInt32(txtUserNo.Text));
                if (!isUnique)
                    MessageBox.Show("This user nº is used by another employee please change");
                else
                    MessageBox.Show("UserNo salve");
            }

        }
    }
}
