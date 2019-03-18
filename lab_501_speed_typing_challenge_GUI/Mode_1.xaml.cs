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

namespace lab_501_speed_typing_challenge_GUI
{
    public partial class Mode_1 : Window
    {

        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        DispatcherTimer dispatcher_timer = new DispatcherTimer();
        Stopwatch stop_watch = new Stopwatch();
        string currentTime = string.Empty;

        int score = 0;
        int Time { get; set; }

        public Mode_1()
        {
            InitializeComponent();
            dispatcher_timer.Tick += new EventHandler(Dt_Tick);
            dispatcher_timer.Interval = new TimeSpan(0, 0, 1);
        }

        void Dt_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(Time);

            currentTime = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);

            if (Time >= 0)
            {
                Time--;
                TB_Timer.Text = currentTime;
            }
        }

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            stop_watch.Start();
            dispatcher_timer.Start();
        }

        private void TB_Letters_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TB_Letters.Text[TB_Letters.Text.Length - 1] == alphabet[(TB_Letters.Text.Length-1)%26] && stop_watch.IsRunning)
            {
                score++;
                TB_Score.Text = (score).ToString();
            }
            else if (Time < 0)
            {
                MessageBox.Show($"Total score: {score / 2}");
            }
        }

        private void TB_Time_TextChanged(object sender, TextChangedEventArgs e)
        {
            Time = Convert.ToInt32(TB_Time.Text);
        }

        private void TB_Timer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
