namespace Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum colors { red=5, blue, white, black, yellow=7, puple, brown, orange };

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "red: " + (int)colors.red + Environment.NewLine;
            text += "Blue: " + (int)colors.blue + Environment.NewLine;
            text += "White: " + (int)colors.white + Environment.NewLine;
            text += "Black: " + (int)colors.black + Environment.NewLine;
            text += "Yellow: " + (int)colors.yellow + Environment.NewLine;
            text += "Puple: " + (int)colors.puple + Environment.NewLine;
            text += "Brown: " + (int)colors.brown + Environment.NewLine;
            text += "Orange: " + (int)colors.orange + Environment.NewLine;
            textBox1.Text = text;
        }
    }
}
