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
        
        List<char> alphabet = new List<char> { 'a', 'b', 'c' };

        //, 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' };

        DispatcherTimer dispatcher_timer = new DispatcherTimer();
        Stopwatch stop_watch = new Stopwatch();
        string currentTime = string.Empty;

        int score = 0;
        int time { get; set; }

        public Mode_1()
        {
            InitializeComponent();
            dispatcher_timer.Tick += new EventHandler(dt_Tick);
            dispatcher_timer.Interval = new TimeSpan(0, 0, 1);
        }

        void dt_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(time);

            currentTime = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);

            if (time >= 0)
            {
                time--;
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
            //char text_input = TB_Letters.key;

            //if (alphabet[0] == text_input && stop_watch.IsRunning)
            //{
            //    score++;
            //    TB_Score.Text = (score / 2).ToString();
            //}

            //if (time < 0)
            //{
            //    MessageBox.Show($"Total score: {score /2}");
            //}
        }

        private void TB_Time_TextChanged(object sender, TextChangedEventArgs e)
        {
            time = Convert.ToInt32(TB_Time.Text);
        }
    }
}
