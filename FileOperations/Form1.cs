namespace FileOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists("firstfile.txt"))
            {
                FileInfo ourfile = new FileInfo("firstfile.txt");
                ourfile.Create();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete("firstfile.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This is firt Line");
            sw.WriteLine("This is firt Line");
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string text = "";
            while (!sr.EndOfStream)
            {
                text += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();
            fs.Close();
            textBox1.Text = text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.Copy("firstfile.txt", @"C:\temp\firstfile.txt");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileInfo ourfile = new FileInfo("firstfile.txt");
            string name = ourfile.Name;
            MessageBox.Show(name);
        }
    }
}
