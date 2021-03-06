﻿using System;
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

        int speed = 10; // Player speed

        //Velocity variables for the red and yellow ghost : they only move in the x direction
        int redSpeed1 = 10;
        int redSpeed2 = 10;
        int yellowSpeed1 = 10;
        int yellowSpeed2 = 10;

        //The pink ghost has x and y velocity
        int pinkSpeedX = 4;
        int pinkSpeedY = 2;

        int pinkSpeed2X = 4;
        int pinkSpeed2Y = 2;

        int score = 0;
        int bonusScore = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Visible = false;
        }

        //player movement code start

        //Tracking 4 keys: up, down, left and right
        //when either of these keys are presses it changes the directional images of pacman 
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true; //if key code is left goLeft is set to true 
                pacman.Image = Properties.Resources.Right; //change pacman image to left
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true; //if key code is right goRight is set to true 
                pacman.Image = Properties.Resources.Left; //change pacman image to right
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true; //if key code is up goUp is set to true 
                pacman.Image = Properties.Resources.Up; //change pacman image to up
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true; //if key code is Down goDown is set to true 
                pacman.Image = Properties.Resources.down; //change pacman image to down
            }
        }

        //Tracking 4 keys: up, down, left and right again
        //key up event stops the pacman image from moving when the arrow keys are released
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false; //goLeft is no longer true when the left key is released so movement halts
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

        //This is the timer function, the main event that makes the game run
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Score " + score; //show score on the board
                                            //Link the score intiger to label 1
                                            //calling label 1 text property and adding scorevariable to it
            
            // assigning speed to the movement events allowing the player to move
            // used a boolian so that when its true the player moves and when its false the player stops moving
            if (goLeft)
            {
                pacman.Left -= speed; // by using the minus sign the player is dynamically moved to the left
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
            redGhost1.Top += redSpeed1;
            redGhost2.Top += redSpeed2;

            yellowGhost1.Left += yellowSpeed1;
            yellowGhost2.Left += yellowSpeed2;

            //assign two speed constants to ghostPink
            pinkGhost1.Left += pinkSpeedX;
            pinkGhost1.Top += pinkSpeedY;

            pinkGhost2.Left += pinkSpeed2X;
            pinkGhost2.Top += pinkSpeed2Y;

            //if redGhost touches walls it reverses velocity
            if (redGhost1.Top <= wall23.Bottom + 1 || redGhost1.Bottom + 1 >= wall24.Top)
            {
                redSpeed1 = -redSpeed1;
            }

            if (redGhost2.Top <= wall23.Bottom + 1 || redGhost2.Bottom + 1 >= wall24.Top)
            {
                redSpeed2 = -redSpeed2;
            }

            //if yellowGhost touches walls it reverses velocity
            if (yellowGhost1.Left <= wall10.Right + 5 || yellowGhost1.Right + 5 >= wall11.Left)
            {
                yellowSpeed1 = -yellowSpeed1;
            }

            if (yellowGhost2.Left <= wall12.Right + 5 || yellowGhost2.Right + 10 >= wall13.Left)
            {
                yellowSpeed2 = -yellowSpeed2;
            }

            //pink ghost boundary conditions 
            if (pinkGhost1.Left < wall6.Right + 5 || pinkGhost1.Right > wall7.Left - 10)
            {
                pinkSpeedX = -pinkSpeedX;
            }

            if (pinkGhost1.Top <=  wall23.Bottom || pinkGhost1.Top + pinkGhost1.Height + 2 > wall4.Top)
            {
                pinkSpeedY = -pinkSpeedY;
            }

            if (pinkGhost2.Left < wall8.Right + 5 || pinkGhost2.Right > wall9.Left - 10)
            {
                pinkSpeed2X = -pinkSpeed2X;
            }

            if (pinkGhost2.Top <= wall5.Bottom + 1 || pinkGhost2.Bottom >= wall24.Top) 
            {
                pinkSpeed2Y = -pinkSpeed2Y;
            }

            //losing condition code start
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag is "wall" || x.Tag is "ghost")//Tags for the ghost and wall pictureboxes are marked as x 
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds))//If the packman picturebox intersects with anything marked as x 
                                                                            //the timer stops and the game ends
                    {
                        //reposition all the characers in the game to the center of the scree
                        pacman.Left = 680;
                        pacman.Top = 25;

                        redGhost1.Left = 323;
                        redGhost1.Top = 255;
                        redGhost2.Left = 383;
                        redGhost2.Top = 220;

                        yellowGhost1.Left = 353;
                        yellowGhost1.Top = 255;
                        yellowGhost2.Left = 323;
                        yellowGhost2.Top = 220;

                        pinkGhost1.Left = 383;
                        pinkGhost1.Top = 255;
                        pinkGhost2.Left = 353;
                        pinkGhost2.Top = 220;

                        label3.Text = "You Lose";
                        label3.Visible = true;
                        label2.Text = "Game Over";
                        label2.Visible = true;
                        timer1.Stop();
                    }
                    //losing condition code ends 

                    //Winning condition code start
                    else if (score == 64 || bonusScore == 10)
                    {
                        pacman.Left = 680;
                        pacman.Top = 25;

                        redGhost1.Left = 323;
                        redGhost1.Top = 255;
                        redGhost2.Left = 383;
                        redGhost2.Top = 220;

                        yellowGhost1.Left = 353;
                        yellowGhost1.Top = 255;
                        yellowGhost2.Left = 323;
                        yellowGhost2.Top = 220;

                        pinkGhost1.Left = 383;
                        pinkGhost1.Top = 255;
                        pinkGhost2.Left = 353;
                        pinkGhost2.Top = 220;

                        label3.Text = "You Win!";
                        label3.Visible = true;
                        timer1.Stop();
                    }
                    //Winning condition code ends
                }

                //coins are marked as x 
                if (x is PictureBox && x.Tag is "coin")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds))
                    {
                        this.Controls.Remove(x); //removes coin from the form after interaction 
                        score++; //score increases by 1 point
                    }
                }

                if (x is PictureBox && x.Tag is "coin2")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds))
                    {
                        this.Controls.Remove(x);
                        bonusScore += 5; //score increases by 5 point
                    }
                }

            }
            
        }

        private void yellowGhost1_Click(object sender, EventArgs e)
        {

        }
    }
}
