namespace PathMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ourfile = @"C:\newfolder\temp\floresta.txt";           
            textBox1.Text += Path.GetDirectoryName(ourfile)+Environment.NewLine;
            textBox1.Text += Path.GetExtension(ourfile) + Environment.NewLine;
            textBox1.Text += Path.GetFileName(ourfile) + Environment.NewLine;
            textBox1.Text += Path.GetFileNameWithoutExtension(ourfile) + Environment.NewLine;
            textBox1.Text += Path.GetPathRoot(ourfile) + Environment.NewLine;
            textBox1.Text += Path.GetFullPath(ourfile) + Environment.NewLine;
        }
    }
}
