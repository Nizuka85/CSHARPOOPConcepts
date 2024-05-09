namespace Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void fillTextBox(int x);
        string textValue = "";
        public void FillMathNote(int ExamNote)
        {
            textValue += "Your Math Note is: " + ExamNote + Environment.NewLine;
        }

        public void FillChemistryNote(int ExamNote)
        {
            textValue += "Your Chemistry Note is: " + ExamNote + Environment.NewLine;
        }

        public void showInTextBox()
        {
            textBox1.Text = textValue;
        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            fillTextBox fillText = FillMathNote;
            fillTextBox fillText1 = new fillTextBox(FillMathNote);
            fillTextBox fillText2 = new fillTextBox(FillMathNote);
            fillText += FillChemistryNote;
            fillText(80);
            fillText1(90);
            fillText1.Invoke(100);
            fillText2.Invoke(150);
            fillText -= FillMathNote;
            fillText.Invoke(20);
            showInTextBox();
        }
    }
}
