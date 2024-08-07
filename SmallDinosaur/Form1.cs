using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallDinosaur
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;
        int highest = 0;
        public Form1()
        {
            InitializeComponent();
            Score.Text = String.Format("{0:H I  00000}", highest);
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            Score.Text = String.Format("{0:H I  00000}",highest);
            score++;
            current.Text = String.Format("{0:00000}", score);
            dinosaur.Top += jumpSpeed;
            if (jumping == true && force < 0)
            {
                jumping = false;
            }
            if(jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
            if(dinosaur.Top > 368 && jumping == false)
            {
                force = 12;
                dinosaur.Top = 369;
                jumpSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;
                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (dinosaur.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        dinosaur.Image = Properties.Resources.dead;
                        GameOver.Visible = true;
                        isGameOver = true;
                        checkHighestScore();
                    }
                }
            }
            if (score > 10)
            {
                obstacleSpeed = 15;
            }
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space&& jumping == false)
            {
                jumping = true;
            }
            else if(e.KeyCode == Keys.R &&isGameOver == true)
            {
                GameReset();
            }
            if (e.KeyCode == Keys.Space && isGameOver == false)
            {
                gameTimer.Enabled = true;
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if(jumping == true)
            {
                jumping = false;
            }

        }
       
        private void GameReset()
        {
            GameOver.Visible = false;
            jumping = false;
            jumpSpeed = 0;
            force = 12;
            score = 0;
            obstacleSpeed = 10;
            dinosaur.Image = Properties.Resources.running;
            isGameOver = false;
            dinosaur.Top = 369;
            checkHighestScore();

            foreach (Control x in this.Controls)
            {
                if(x is PictureBox &&(string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500,800) + (x.Width * 10);
                    x.Left = position;
                }
            }
            gameTimer.Start();
        }
        void checkHighestScore()
        {
            if (score > highest)
            {
                highest = score;
                Score.Text = String.Format("{0:H I  00000}", score);
            }
        }

    }
}
