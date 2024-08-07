using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ01_3
{
    public partial class Form1 : Form
    {
        List<Button> buttonList = new List< Button > ();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            removeAllButton();
            addButton();
        }
        void addButton()
        {
            int row = Convert.ToInt32(textBox1.Text);
            int column = Convert.ToInt32(textBox2.Text);
            int buttonWidth = 35;
            int buttonHeight = 35;
            int index = 1;
            int buttonSpace = 5;
            for (int y = 0; y < column; y++)
            {
                for (int x = 0; x < row; x++)
                {
                    int buttonX = 20+buttonSpace + x * (buttonWidth + buttonSpace);
                    int buttonY = 50+buttonSpace + y * (buttonHeight + buttonSpace);

                    Button button = new Button();
                    button.Location = new Point(buttonX, buttonY);
                    button.Size = new Size(buttonWidth, buttonHeight);
                    button.Text = index.ToString();
                    button.UseVisualStyleBackColor = true;

                    buttonList.Add(button);
                    this.Controls.Add(button);
                    index++;
                }
            }
        }
        void removeAllButton()
        {
            foreach(Button button in buttonList)
            {
                this.Controls.Remove(button);
            }
            buttonList.Clear();
        }
    }
}
