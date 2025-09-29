using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class Form1 : Form
    {
        int _gravity = 5;
        int _pipeSpeed = 8;
        int _score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblScore.Text = "Score : 0";
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimerEvent;
            //GameTimer.Start();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _gravity = -10;
              
            }
            if (e.KeyCode == Keys.R) {
                _score = 0;
                LblScore.Text = "Score : "+_score;
               
                PicBoxBird.Top = 100;
                PicBoxBird.Left = 100;
                PicBoxPipeTop.Left = 400;
                PicBoxPipeBottom.Left = 400;
                GameTimer.Start();

            }
            if ((e.KeyCode == Keys.S)) {
                GameTimer.Start();
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _gravity = 5;
                
            }
        }
       
        private void GameTimerEvent(object sender, EventArgs e)
        {
            PicBoxBird.Top += _gravity;

            PicBoxPipeTop.Left -= _pipeSpeed;
            PicBoxPipeBottom.Left -= _pipeSpeed;

            LblScore.Text = "Score : " + _score;

            if(PicBoxPipeTop.Left < -150)
            {
                PicBoxPipeTop.Left = 800;
                _score++;
            }
            if (PicBoxPipeBottom.Left < -150)
            {
                PicBoxPipeBottom.Left = 800;
            }

            if(PicBoxBird.Bounds.IntersectsWith(PicBoxPipeTop.Bounds)||
                PicBoxBird.Bounds.IntersectsWith(PicBoxPipeBottom.Bounds)||
                PicBoxBird.Bounds.IntersectsWith(PicBoxGround.Bounds))
            {
                EndGame();
            }
        }
        
        private void EndGame()
        {
            GameTimer.Stop();
            LblScore.Text = "Game Over!! Score : "+_score;
        }

      
        
    }
}
