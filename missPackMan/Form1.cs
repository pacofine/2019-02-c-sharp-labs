using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace missPackMan
{
    public partial class Form1 : Form
    {
        public bool goUp;
        public bool goDown;
        public bool goLeft;
        public bool goRight;

        int speed = 5;

        //Velocity variables for the red and yellow ghost : they only move in the x direction
        int ghostRed = 8;
        int ghostYellow = 8;

        //The pink ghost has x and y velocity
        int ghostPinkX = 8;
        int ghostPinky = 8;

        int score = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
        }
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                pacman.Image = Properties.Resources.Right;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                pacman.Image = Properties.Resources.Left;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                pacman.Image = Properties.Resources.Up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                pacman.Image = Properties.Resources.down;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        //This id the timer function, the main eveent that makes the game run
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Score " + score; //show score on the board
                                            //Link the score intiger to label 1
                                            //calling label 1 text property and adding scorevariable to it

            if (goLeft)
            {
                pacman.Left -= speed;
            }

            if (goRight)
            {
                pacman.Left += speed;
            }

            if (goUp)
            {
                pacman.Top -= speed;
            }

            if (goDown)
            {
                pacman.Top += speed;
            }
            //player movement code end

            //assign the ghostRed and ghostYellow speeds to redghost and yellowghost
            redGhost.Left += ghostRed;
            yellowGhost.Left += ghostYellow;

            //if redGhost touches walls it reverses velocity
            if (redGhost.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                ghostRed = -ghostRed;
            }

            else if (redGhost.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                ghostRed = -ghostRed;
            }

            //if yellowGhost touches walls it reverses velocity
            if (yellowGhost.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                ghostYellow = -ghostYellow;
            }

            else if (yellowGhost.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                ghostYellow = -ghostYellow;
            }
        }
    }
}
