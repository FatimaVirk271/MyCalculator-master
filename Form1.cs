namespace MyCalculator
{
    public partial class Form1 : Form
    {
        double value1;
        double value2;
        double result = 0;
        string sign;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "+";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "-";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "*";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "/";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;

            value2 = Convert.ToInt32(textBox1.Text);

            label1.Text = value1 + " " + sign + " " + value2 + " =";

            if (sign == "+")
            {
                result = value1 + value2;
            }
            else if (sign == "-")
            {
                result = value1 - value2;
            }
            else if (sign == "*")
            {
                result = value1 * value2;
            }
            else if (sign == "/")
            {
                if (value2 != 0)
                {
                    result = (double)value1 / value2;
                }
                else
                {
                    textBox1.Text = "Error";
                    return;
                }
            }

            textBox1.Text = Convert.ToString(result);
        }
    }
}
