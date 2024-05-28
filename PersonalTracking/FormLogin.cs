using System;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PersonalTracking
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                MessageBox.Show("Please fill the userNº and Passaword");
            else
            {
                List<EMPLOYEE> employeelist = EmployeeBLL.GetEmployees(Convert.ToInt32(txtUserNo.Text),txtPassword.Text);
                if (employeelist.Count == 0)
                    MessageBox.Show("Please control your information");
                else
                {
                    EMPLOYEE employee = new EMPLOYEE();
                    employee = employeelist.First();
                    UserStatic.EmployeeID = employee.ID;
                    UserStatic.UserNo =employee.UserNo;
                    UserStatic.isAdmin = employee.isAdmin;
                    FormMain frm = new FormMain();
                    this.Hide();
                    frm.ShowDialog();
                }
            }
        }
    }
}
