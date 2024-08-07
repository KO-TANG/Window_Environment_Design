using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW03_09156104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int t = 0;
        int i;
        List<String> picture = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            picture.Clear();
            i = 0;
            if (checkBox1.Checked)
            {
                picture.Add("movie_001");
            }
            if (checkBox2.Checked)
            {
                picture.Add("movie_002");
            }
            if (checkBox3.Checked)
            {
                picture.Add("movie_003");
            }
            if (checkBox4.Checked)
            {
                picture.Add("movie_004");
            }
            if (checkBox5.Checked)
            {
                picture.Add("movie_005");
            }

            t = Convert.ToInt32(textBox1.Text);
            timer1.Interval = t*1000;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(picture[i]);
            if (i == picture.Count - 1)
            {
                i = 0;
            }
            else
                i++;
        }
    }
}
