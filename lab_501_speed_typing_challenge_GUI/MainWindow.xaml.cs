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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_501_speed_typing_challenge_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Mode_1 = new Mode_1();
            Mode_1.Show();
            this.Close();
        }

        private void ButtonMode_2_Click(object sender, RoutedEventArgs e)
        {
            var Mode_2 = new Mode_2();
            Mode_2.Show();
            this.Close();
        }
    }
}
