using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            helicopter.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;
            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 750;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 900;
                score++;
            }

            if (helicopter.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                helicopter.Bounds.IntersectsWith(pipeTop.Bounds) ||
                helicopter.Bounds.IntersectsWith(ground.Bounds) ||
                helicopter.Top < -25    
               )
            {
                endGame();   
            }
            
            if(score > 7)
            {
                pipeSpeed = 14;
            }
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game over!!!";
        }
    }
}
