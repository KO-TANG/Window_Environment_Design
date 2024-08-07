using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculate
{
    public partial class Form1 : Form
    {
        int number1;
        int number2;
        String function = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button0_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }
        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            saveNumber1();
            function = "+";
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            saveNumber1();
            function = "-";
        }

        private void ButtonMultiple_Click(object sender, EventArgs e)
        {
            saveNumber1();
            function = "*";
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            saveNumber1();
            function = "/";
        }

        private void buttonModel_Click(object sender, EventArgs e)
        {
            saveNumber1();
            function = "%";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            function = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToInt32(textBoxResult.Text);
            textBoxResult.Text = "";
            if (function.Equals("+"))
                textBoxResult.Text = (number1 + number2).ToString();
            else if (function.Equals("-"))
                textBoxResult.Text = (number1 - number2).ToString();
            else if (function.Equals("*"))
                textBoxResult.Text = (number1 * number2).ToString();
            else if (function.Equals("/"))
                textBoxResult.Text = (number1 / number2).ToString();
            else if (function.Equals("%"))
                textBoxResult.Text = (number1 % number2).ToString();
        }

        private void textButtonResult(object sender, EventArgs e)
        {

        }
        void numberClick(object sender)
        {
            Button button = (Button)sender;
            if (textBoxResult.Text.Equals(number1.ToString()))
            {
                textBoxResult.Text = "";
            }
            if (textBoxResult.Text.Equals("0"))
            {
                textBoxResult.Text = button.Text;
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + button.Text;
            }
        }
        void saveNumber1()
        {
            number1 = Convert.ToInt32(textBoxResult.Text);
            //textBoxResult.Text = "";
        }
    }
}
