namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        interface Computer
        {
            void GetDesktop();
            void GetLaptops();

        }
        class DellComputers : Computer, DellComputer
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public string Mark { get; set; }
            public void GetDesktop()
            {
                Name = "Desktop1";
                Price = 2000;
            }
            public void GetLaptops()
            {
                Name = "Laptop1";
                Price = 1500;
            }

            public void GetMark()
            {
                Mark = "Dell";
            }
        }

        private void Forml_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DellComputers dell = new DellComputers();
            dell.GetLaptops();
            dell.GetMark();
            string textvalue = "Name: " + dell.Name + Environment.NewLine;
            textvalue += "Price: " + dell.Price + Environment.NewLine;
            textvalue += "Mark: " + dell.Mark;
            textBox1.Text = textvalue;
        }

        interface DellComputer
        {
            void GetMark();
        }
    }
}
