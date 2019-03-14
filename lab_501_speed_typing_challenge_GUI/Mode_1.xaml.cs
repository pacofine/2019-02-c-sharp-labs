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
    /// <summary>
    /// Interaction logic for Mode_1.xaml
    /// </summary>
    public partial class Mode_1 : Window
    {
        public static List<char> alphabet = new List<char>() { 'a', 'b', 'c' };
            
            //, 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' };
        
        public static int score = 0;

        int time = Convert.ToInt32(time_text);

        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();
        string currentTime = string.Empty;

        public Mode_1()
        {
            InitializeComponent();
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 1);

            while (sw.IsRunning == true)
            {
                string text = TB_Letters.Text;
                char[] textToChar = text.ToCharArray();

                if (alphabet[0] == textToChar[0])
                {
                    score++;
                    TB_Score.Text = score.ToString();
                }
            }
        }

        void dt_Tick(object sender, EventArgs e)
        {
            string time_text = TB_Time.Text;
            

            TimeSpan ts = TimeSpan.FromSeconds(time);

            currentTime = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);

            if (time >= 0)
            {
                time--;
                TB_Timer.Text = currentTime;
            }
            
            if (time == 0)
            {
                sw.Stop();
            }

            ts = ts.Add(TimeSpan.FromSeconds(-1));
        }

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            sw.Start();
            dt.Start();
        }
        
        
    }
}
