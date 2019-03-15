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
        
        int score = 0;
        int time = 5;

        public static List<char> inputList = new List<char>();
        
        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();
        string currentTime = string.Empty;

        public Mode_1()
        {
            InitializeComponent();
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 1);
        }

        void dt_Tick(object sender, EventArgs e)
        {
            TB_Score.Text = score.ToString();

            //if (TB_Timer.Text == "00:00")
            //{
            //    TB_Score.Text = inputList.Sum();
            //}

            string inputString = TB_Letters.ToString();
            char[] inputChar = inputString.ToCharArray();

            foreach (var item in inputChar)
            {
                inputList.Add(item);

                if (inputList == alphabet)
                {
                    score++;
                }
            }


            string time_text = TB_Time.Text;
            //int time = Convert.ToInt32(time_text); 

            TimeSpan ts = TimeSpan.FromSeconds(time);

            currentTime = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);

            if (time >= 0)
            {
                time--;
                TB_Timer.Text = currentTime;
            }
            else if (time == 0)
            {
                sw.Stop();
                MessageBox.Show("Times Up!");
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
