namespace Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        abstract class Vehicle
        {
            public abstract double GetFuelAmount();
        }
        class Bus : Vehicle
        {
            public override double GetFuelAmount()
            {
                return 300;
            }
        }
        class Truck : Vehicle
        {
            public override double GetFuelAmount()
            {
                return 500;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            Vehicle vc;
            Bus _vc =new Bus();
            double busfuel = _vc. GetFuelAmount();
            text += "bus Fuel Amount is: " + busfuel.ToString() + Environment.NewLine;
            vc = new Truck();   
            double truckfuel = vc. GetFuelAmount();
            text += "Truck Fuel Amount is: " + truckfuel.ToString() + Environment.NewLine;
            textBox1.Text = text;
        }
    }
}
