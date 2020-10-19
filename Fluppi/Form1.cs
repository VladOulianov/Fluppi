using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fluppi
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            fluppy.Top += gravity;
            piloneBot.Left -= pipeSpeed;
            piloneTop.Left -= pipeSpeed;
            ScoreText.Text = "Score: " + score;

            if(piloneBot.Left < -50)
            {
                piloneBot.Left = 800;
                score++;
                pipeSpeed++;
               
            }

            if(piloneTop.Left < -80)
            {
                piloneTop.Left = 950;
                score++;
            }

            if(
                fluppy.Bounds.IntersectsWith(piloneBot.Bounds) ||
                fluppy.Bounds.IntersectsWith(piloneTop.Bounds) ||
                fluppy.Bounds.IntersectsWith(flore.Bounds) /*||
                fluppy.Top > -25*/
               )
            {
                endGame();
            }

            
            
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
            
            if (e.KeyCode == Keys.Enter)
            {
                GameTimer.Start();
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

       

        private void endGame()
        {

            
            
            GameTimer.Stop();
            ScoreText.Text += " Game Over !!!";

        }


        private void flore_Click(object sender, EventArgs e)
        {

        }
    }
}
