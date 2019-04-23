//04/17/2019
//FlappyBird TEST

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class flappyGame : Form
    {
        //core variables
        bool jumping = false;

        int speedPipe = 8;
        int gravity = 10;
        int gameScore = 0;
        int recentScore = 0;
        int highScore = 0;

        public flappyGame()
        {
            InitializeComponent();

            //end labels text; need to be set invisible till
            //the end of the game; final score and shit
            endText1.Text = "Final Score:  " + gameScore;
            endText2.Text = "Highscore:  " + highScore;
            gameDesigners.Text = "Game Designers: ";

            //here house to set the labels visible till the end
            endText1.Visible = false;
            endText2.Visible = false;
            gameDesigners.Visible = false;
        }

        private void ground_Click(object sender, EventArgs e)
        {

        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //pipe speed; we should control and test how fast we want the pipes to move
            pipeBottom.Left -= speedPipe;
            pipeTop.Left -= speedPipe;

            //this makes the bird fall down and control the 'gravity' in the game
            flappyBird.Top += gravity;

            //this adds the game score up
            scoreText.Text = " " + gameScore;

            //now these should be the bounds for collision in the game
            //this is the bounds for the Eric bird to hit the ground
            if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            //bounds if the Eric bird hits the pipe bottom
            else if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                endGame();
            }
            //bounds if the Eric bird hits the pipe top
            else if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
            }

            //so this is for the pipes to appear and reappear after they leave
            //a certain amount of pixels in the screen
            if (pipeBottom.Left < -80)
            {
                pipeBottom.Left = 1000;
                gameScore += 1;
            }

            else if (pipeTop.Left < -95)
            {
                pipeTop.Left = 1100;
                gameScore += 1;
            }
        }

        private void inGameKeyDown(object sender, KeyEventArgs e)
        {
            //if statement where the down key is used to control the bird
            //reverses the gravity and the bird goes up i hope lmao
            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
                gravity = -12;
            }
        }

        private void inGameKeyUP(object sender, KeyEventArgs e)
        {
            //if statement where the gravity is back for the bird
            //meaning the shit will fall back down
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = 10;
            }
        }

        private void endGame()
        {
            //highscore shit
            gameScore = recentScore;
            if (recentScore > highScore)
            {
                highScore = recentScore;
            }

            //how to manually stop the timer from running 
            gameTimer.Stop();

            //this is to make the other end game labels visible
            endText1.Visible = true;
            endText2.Visible = true;
            gameDesigners.Visible = true;
        }


        //sources:
        //https://www.youtube.com/watch?v=ndImyD17Viw
        //https://www.youtube.com/watch?v=nzgXp7h0d7I, https://www.mooict.com/create-flappy-bird-game-in-visual-studio-using-c/
        //https://github.com/crosslife/OpenBird
        //https://www.twitch.tv/videos/409642335?filter=archives&sort=time
    }
}
