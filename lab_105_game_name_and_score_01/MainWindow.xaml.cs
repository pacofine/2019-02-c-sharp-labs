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
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace lab_105_game_name_and_score_01
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("User.txt", enterFirstName.Text + Environment.NewLine + enterLastName + Environment.NewLine + enterScore);

          //  enterFirstName.text = MySettings.Default.SomeSetting;
            // MySettings.Default.SomeSetting = enterFirstName.text;
          //  MySettings.Default.Save();
        }

        private void enterFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
       
        }

        private void enterLastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void enterScore_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void Initialize()
        {
            string[] data01 = File.ReadAllLines("Users.txt");
            enterFirstName.Text = data01[0];
            enterLastName.Text = data01[1];
            enterScore.Text = data01[2];
        }

        //Create a gaming homepage
        //Name a gamer(saved to text file)
        //level 1 reached
        //prize for best presented interface
    }

}
