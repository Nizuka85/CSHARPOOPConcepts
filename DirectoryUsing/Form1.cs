namespace DirectoryUsing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo ds = new DirectoryInfo("folder2");
            string accesstime = ds.CreationTime.ToString();
            MessageBox.Show(accesstime);

            if (Directory.Exists("temp2"))
            {
                Directory.CreateDirectory("folder2");
            }
            //Directory.CreateDirectory("temp");
            DirectoryInfo dr = new DirectoryInfo("temp2");
            dr.Create();
            MessageBox.Show("Folder was created");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Directory.Move("temp", @"C:\newfolder\temp");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Directory.Delete("temp2");
        }
    }
}
