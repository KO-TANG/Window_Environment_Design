using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MID_09156104_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double resault = 0;
            if (this.radioButton1.Checked)
            {
                resault = a + b;
            }
            else if (this.radioButton2.Checked)
            {
                resault = a - b ;
            }
            else if (this.radioButton3.Checked)
            {
                resault = a * b;
            }
            else if (this.radioButton4.Checked)
            {
                if (b == 0)
                    resault = 0;
                else
                    resault = Math.Round(a/b, 2); 
            }
            this.label3.Text = resault.ToString();
        }
    }
}
