namespace Calculatrice_Calculator
{
    public partial class Form1 : Form
    {
        //variables 

        Double resultValue = 0;
        string operationOption = "";
        bool operationDone = false;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button_clickNumbers(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationDone == true))
            { 
                textBox1.Clear();
            }
            operationDone = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                {
                    textBox1.Text += button.Text;
                }
            }
            else
            {
                textBox1.Text += button.Text;
            }

        }

        private void OperatorClickEvent(object sender, EventArgs e)
        {
            Button button = (Button)sender; 
            
            if (resultValue!=0)
            {
                buttonEgale.PerformClick();
                operationOption = button.Text;
                //resultValue = Double.Parse(textBox1.Text);
                labelCurrentOperation.Text = resultValue + " " + operationOption;
                operationDone = true;
            }
            else
            {
                operationOption = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                labelCurrentOperation.Text = resultValue + " " + operationOption;
                operationDone = true;
            }   

            
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
        }

        private void EgaleButton(object sender, EventArgs e)
        {
            switch (operationOption)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();

                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();

                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();

                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();

                    break;
                default:
                    break;

            }
            resultValue = Double.Parse(textBox1.Text);
            labelCurrentOperation.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}