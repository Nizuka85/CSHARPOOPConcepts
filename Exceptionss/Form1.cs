namespace Exceptionss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                textBox3.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception("You can not Divide any number to Zero");
            }
            catch (Exception ex)
            {
                throw new Exception("Please use only number");
            }
            finally
            {
                MessageBox.Show("Program Was Finished");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
