using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MID_09156104_1
{
    public partial class Form1 : Form
    {
        List<Button> buttonList = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            initButtonList();
            updateButtonImage();
        }
        void initButtonList()
        {
            buttonList.Add(button1);
            buttonList.Add(button2);
            buttonList.Add(button3);
            buttonList.Add(button4);
            buttonList.Add(button5);
            buttonList.Add(button6);
            buttonList.Add(button7);
            buttonList.Add(button8);
            buttonList.Add(button9);
            for (int i = 0; i < 9; i++)
            {
                buttonList[i].Tag = i + 1;
                buttonList[i].Click += new System.EventHandler(this.Button_Click);
            }
        }
        void updateButtonImage()
        {
            for (int i = 0; i < 9; i++)
            {
                String imageName = "a0" + Convert.ToInt32(buttonList[i].Tag);//圖檔名稱
                buttonList[i].BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int tag = Convert.ToInt32(button.Tag);
            if (tag == 1)
            {
                label2.Text = "答對了";
            }
            else
            {
                label2.Text = "不對喔，再看仔細一點";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < buttonList.Count; i++)
            {
                int randombutton = random.Next(0, buttonList.Count);
                //三角互換 tag
                int temp = Convert.ToInt32(buttonList[i].Tag);
                buttonList[i].Tag = buttonList[randombutton].Tag;
                buttonList[randombutton].Tag = temp;
            }
            updateButtonImage();
        }
    }
}
