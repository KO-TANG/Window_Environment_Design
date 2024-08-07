using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MID_09156104_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int duration = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(textBox1.Text);
            int sec = Convert.ToInt32(textBox2.Text);
            duration = min * 60 + sec;
            if (duration == 0)
            {
                return;
            }
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void count_down(object sender, EventArgs e)
        {
            if (duration == 0)
            {
                timer1.Stop();
                MessageBox.Show("時間到囉");
            }
            else if (duration > 0)
            {
                duration--;
                label3.Text = (duration/60).ToString()+"分"+(duration%60)+"秒";
            }
        }
    }
}
