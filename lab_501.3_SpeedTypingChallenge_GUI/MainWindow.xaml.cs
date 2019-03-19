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
using System.IO;

namespace lab_501._3_SpeedTypingChallenge_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Initialize();
        }

        //private void Initialize()
        //{
        //    TB_inputName.Text = File.ReadAllText("name.txt");
        //    TB_HighScore.Text = File.ReadAllText("score.txt");
        //}

        private void Btn_Play_Click(object sender, RoutedEventArgs e)
        {
            var Window1 = new Window1();
            Window1.Show();
        }

        private void Btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string name = Convert.ToString(TB_inputName);
            File.WriteAllText("name.txt", TB_inputName.Text);
        }
    }
}
