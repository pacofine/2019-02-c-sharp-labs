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
    public partial class Mode_2 : Window
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        DispatcherTimer disp_timer = new DispatcherTimer();
        Stopwatch stop_watch = new Stopwatch();
        string current_time = string.Empty;

        int score = 0;
        int time { get; set; }

        public Mode_2()
        {
            InitializeComponent();
            disp_timer.Tick += new EventHandler(Disp_time_tick);
            disp_timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void Disp_time_tick(object sender, EventArgs e)
        {
            TimeSpan time_span = TimeSpan.FromSeconds(time);

            current_time = String.Format("{0:00}:{1:00}", time_span.Minutes, time_span.Seconds);

            if (time >= 0)
            {
                time--;
                TB_Timer.Text = current_time;
            }
            else if (time == 0)
            {
                stop_watch.Stop();
            }
        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            stop_watch.Start();
            disp_timer.Start();
        }

        private void TB_Letters_TextChanged(object sender, TextChangedEventArgs e)
        {
            char[] alphabet1 = alphabet.ToCharArray();
            char[] text_input = TB_Letters.ToString().ToCharArray();

            for (int i = 0; i < alphabet1.Length; i++)
            {
                if (alphabet[i] == text_input[i] && stop_watch.IsRunning)
                {
                    score++;
                    TB_Score.Text = (score / 2).ToString();
                    
                }
                else if (time < 0)
                {
                    MessageBox.Show($"Total score: {score / 2}");
                    break;
                }
            }
        }

        private void TB_Time_TextChanged(object sender, TextChangedEventArgs e)
        {
            time = Convert.ToInt32(TB_Time.Text);
        }
    }
}
