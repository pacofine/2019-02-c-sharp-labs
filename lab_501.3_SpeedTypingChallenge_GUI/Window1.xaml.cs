using System;
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

namespace lab_501._3_SpeedTypingChallenge_GUI
{
    public partial class Window1 : Window
    {
        DispatcherTimer dispatcher_timer = new DispatcherTimer();
        Stopwatch stop_watch = new Stopwatch();

        string alphabet = "abcdefghijklmnopqrstuvwxyx";
        int Score = 0;
        string CurrentTime = string.Empty;
        int Time {get; set;}

        public Window1()
        {
            InitializeComponent();
            Initialize();
            dispatcher_timer.Tick += new EventHandler(dispatcher_timer_Tick);
            dispatcher_timer.Interval = new TimeSpan(0,0,1);
        }

        private void Initialize()
        {
            TB_name.Text = File.ReadAllText("name.txt");
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

        private void dispatcher_timer_Tick(object sender, EventArgs e)
        {
            TimeSpan time_span = TimeSpan.FromSeconds(Time);

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

                MessageBox.Show($"Total score: {Score}");

                if (Convert.ToInt32(TB_Score.Text) > Convert.ToInt32(TB_HighScore.Text))
                {
                    MessageBox.Show("Congrats! You broke your high score !!!");
                    TB_HighScore.Text = TB_Score.Text;
                    File.WriteAllText("score.txt", TB_Score.Text);
                }
            }
        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            stop_watch.Start();
            dispatcher_timer.Start();
        }

        private void TB_Timer_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(TB_Time != null)
            {
                Time = Convert.ToInt32(TB_Time.Text);
            }
            else
            {
                Time = 0;
            }
        }

        private void TB_Letters_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TB_Letters.Text[TB_Letters.Text.Length - 1] == alphabet[(TB_Letters.Text.Length - 1) % 26]
                && stop_watch.IsRunning)
            {
                Score++;
                TB_Score.Text = Score.ToString();
            }
            else
            {
                string letters = TB_Letters.Text;
                TB_Letters.TextChanged -= TB_Letters_TextChanged;
                TB_Letters.Text = letters.Substring(0, letters.Length - 1);
                TB_Letters.SelectionStart = TB_Letters.Text.Length;
                TB_Letters.TextChanged += TB_Letters_TextChanged;
            }
        }
    }
}
