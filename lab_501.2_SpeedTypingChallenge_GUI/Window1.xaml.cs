﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Threading;
using System.IO;

namespace lab_501._2_SpeedTypingChallenge_GUI
{
    public partial class Window1 : Window
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        

        DispatcherTimer dispatcher_timer = new DispatcherTimer();
        Stopwatch stop_watch = new Stopwatch();
        string CurrentTime = string.Empty;

        int Time;
        int score = 0;

        public Window1()
        {
            InitializeComponent();
            Initialise();
            dispatcher_timer.Tick += new EventHandler(Dispatcher_timer_Tick);
            dispatcher_timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void Initialise()
        {
            TB_Player.Text = File.ReadAllText("name.txt");
            if (File.Exists("score.txt"))
            {
                TB_HighScore.Text = File.ReadAllText("score.txt");
            }
            else
            {
                TB_HighScore.Text = "0";
            }
            TB_Score.Text = "0";
        }

        private void Dispatcher_timer_Tick(object sender, EventArgs e)
        {
            TimeSpan time_span = new TimeSpan(Time);

            CurrentTime = String.Format("{0:00}:{1:00}", time_span.Minutes, time_span.Seconds);

            if (Time >= 0)
            {
                Time--;
                TB_Timer.Text = CurrentTime;
            }
            else if (Time <= 0)
            {
                stop_watch.Stop();
                dispatcher_timer.Stop();

                MessageBox.Show($"Total score: {score}");

                if (Convert.ToInt32(TB_Score.Text) < Convert.ToInt32(TB_HighScore.Text))
                {
                    TB_HighScore.Text = TB_Score.Text;
                    MessageBox.Show("Congrats, you got the new high score!");
                    File.WriteAllText("score.txt", TB_Score.Text);
                }
            }
        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            stop_watch.Start();
            dispatcher_timer.Start();
        }

        private void TB_Time_Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(TB_Time_Input != null)
            {
                Time = Convert.ToInt32(TB_Time_Input.Text);
            }
            else
            {
                Time = 0;
            }

        }

        private void TB_Letter_Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TB_Letter_Input.Text[TB_Letter_Input.Text.Length - 1] == alphabet[(TB_Letter_Input.Text.Length)%26] && stop_watch.IsRunning)
            {
                score++;
                TB_Score.Text = score.ToString();
            }
            else
            {
                string letters = TB_Letter_Input.Text;
                TB_Letter_Input.TextChanged -= TB_Letter_Input_TextChanged;
                TB_Letter_Input.Text = letters.Substring(0, letters.Length);
                TB_Letter_Input.SelectionStart = TB_Letter_Input.Text.Length;
                TB_Letter_Input.TextChanged += TB_Letter_Input_TextChanged;
            }
        }
    }
}