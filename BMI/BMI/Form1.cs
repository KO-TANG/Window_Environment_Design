using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW02_09156104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void compute_Click(object sender, EventArgs e)
        {
            
            double high1 = 0;
            if (this.mButton.Checked) {
                high1 = Convert.ToDouble(high.Text);
            }
            else if (this.cmButton.Checked)
            {
                high1 = Convert.ToDouble(high.Text)/100.0;
            }
            double weight1 = Convert.ToDouble(weight.Text);
            double BMI = Math.Round(weight1 / Math.Pow(high1, 2),2);
            if (BMI < 18.5)
            {
                pictureBox1.Image = HW02_09156104.Properties.Resources.bmi_level_01;

                this.hintlabel.Text = BMI.ToString()+"(過輕)";
            }
            else if (BMI < 24 && BMI >= 18.5)
            {
                pictureBox1.Image = HW02_09156104.Properties.Resources.bmi_level_02;

                this.hintlabel.Text = BMI.ToString() + "(正常)";
            }
            else if (BMI < 27 && BMI >= 24)
            {
                pictureBox1.Image = HW02_09156104.Properties.Resources.bmi_level_03;

                this.hintlabel.Text = BMI.ToString() + "(過胖)";
            }
            else if (BMI < 30 && BMI >= 27)
            {
                pictureBox1.Image = HW02_09156104.Properties.Resources.bmi_level_04;

                this.hintlabel.Text = BMI.ToString() + "(肥胖)";
            }
            else if ( BMI >= 30)
            {
                pictureBox1.Image = HW02_09156104.Properties.Resources.bmi_level_05;

                this.hintlabel.Text = BMI.ToString() + "(太胖啦)";
            }

        }

      
    }
}
