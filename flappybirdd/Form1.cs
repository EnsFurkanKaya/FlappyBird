using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappybirdd
{
    public partial class Flappy : Form
    {



        int pipeSpeed = 8;
        int gravity = 4;
        int score = 0;

        public Flappy()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Flappybird.Top += gravity;
            pipebottom.Left -= pipeSpeed;
            PipeTop.Left -= pipeSpeed;
            scoretext.Text = "Score: " + score.ToString();


            if (pipebottom.Left < -200)
            {
                pipebottom.Left = 700;
                score++;


            }
            if (PipeTop.Left < -200)

            {
                PipeTop.Left = 700;
                
            }
            if(Flappybird.Bounds.IntersectsWith(pipebottom.Bounds) || 
                Flappybird.Bounds.IntersectsWith(PipeTop.Bounds ) ||
                Flappybird.Bounds.IntersectsWith(Ground.Bounds) || Flappybird.Top < -25
                )
            {
                EndGame();


            }
            if (score >8 )

            {
                pipeSpeed = 10;

            }


        }



        private void PipeTop_Click(object sender, EventArgs e)
        {

        }

        private void pipebottom_Click(object sender, EventArgs e)
        {

        }

        private void scoretext_Click(object sender, EventArgs e)
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            { 
                gravity = -9; 

            }

        }
             
        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 9;

            }
        }

        private void Ground_Click(object sender, EventArgs e)
        {

        }

        private void EndGame()
        {
            GameTimer.Stop();
            scoretext.Text = scoretext.Text + "            Oyun Bitti!! ";


        }
    }
}
