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
    /// Interaction logic for Mode_2.xaml
    /// </summary>
    public partial class Mode_2 : Window
    {
        public static int score = 0;

        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();
        string currentTime = string.Empty;

        public Mode_2()
        {
            InitializeComponent();
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 1);

            while (sw.IsRunning == true)
            {
                string text = TB_Letters.Text;
                char[] textToChar = text.ToCharArray();

                
            }
        }

        void dt_Tick(object sender, EventArgs e)
        {
            string time_text = TB_Time.Text;
            int time = Convert.ToInt32(time_text);

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
