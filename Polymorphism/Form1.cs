namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValue(1);
            string messagentext = teacher.GetValues();
            textBox1.Text = messagentext;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValue(1, "Charles");
            string messagentext = teacher.GetValues();
            textBox1.Text = messagentext;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValue(1, "Charles", 2000);
            string messagentext = teacher.GetValues();
            textBox1.Text = messagentext;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValue(1, "Charles", 2000, "teacher");
            string messagentext = teacher.GetValues();
            textBox1.Text = messagentext;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee2 employee = new Employee2();
            string messagetext = employee.SetValue(1, "Charles", 2000);
            textBox1.Text = messagetext;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Teacher2 employee = new Teacher2();
            string messagetext = employee.SetValue(1, "Charles", 2000);
            textBox1.Text = messagetext;
        }
    }
}
