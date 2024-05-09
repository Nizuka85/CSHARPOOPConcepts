namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employeeDetails = new Employee();
            employeeDetails.EmployeeName = txtEmployeeName.Text;
            employeeDetails.EmployeeAge = Convert.ToInt32(txtEmployeeAge.Text);
            employeeDetails.EmployeePosition = txtEmployeePosition.Text;
            FormEmployeeDetails form = new FormEmployeeDetails();   
            form.label2.Text = employeeDetails.EmployeeName;
            form.label3.Text = employeeDetails.EmployeeAge.ToString();
            form.label4.Text = employeeDetails.EmployeePosition;
            form.ShowDialog();
        }
    }
}
