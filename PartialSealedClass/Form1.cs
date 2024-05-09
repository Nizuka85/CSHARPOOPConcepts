namespace PartialSealedClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public partial class Employee
        {
            public int EmployeeID { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }

        }
        public partial class Employee
        {
            public void SetValues()
            {
                Name = "Charles";
                EmployeeID = 1;
                Salary = 5000;
            }
        }
        //public sealed class Sealclass
        //{
        //}
        //public void newclass:Sealclass (erro)

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.SetValues();
            textBox1.Text += emp.EmployeeID + Environment.NewLine;
            textBox1.Text += emp.Name + Environment.NewLine;
            textBox1.Text += emp.Salary + Environment.NewLine;
        }
    }
}
