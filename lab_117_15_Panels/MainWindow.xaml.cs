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

namespace lab_117_15_Panels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int index;
        string HeaderName;

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            index = 1;
            displayPanel(index);
        }

        private void ButtonChangePanel_Click(object sender, RoutedEventArgs e)
        {
            index++;
            if (index == 4)
            {
                index = 1;
            }
            displayPanel(index);
        }

        void displayPanel(int index)
        {
            switch (index)
            {
                case 1:
                    stackPanel01.Visibility = Visibility.Visible;
                    stackPanel02.Visibility = Visibility.Collapsed;
                    stackPanel03.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    stackPanel01.Visibility = Visibility.Collapsed;
                    stackPanel02.Visibility = Visibility.Visible;
                    stackPanel03.Visibility = Visibility.Collapsed;
                    break;
                case 3:
                    stackPanel01.Visibility = Visibility.Collapsed;
                    stackPanel02.Visibility = Visibility.Collapsed;
                    stackPanel03.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void ButtonChangeTab_Click(object sender, RoutedEventArgs e)
        {
            if (TabControl01.SelectedIndex < TabControl01.Items.Count - 1)
            {
                TabControl01.SelectedIndex++;
            }
            else
            {
                TabControl01.SelectedIndex = 0;
            }
        }

        enum Tab
        {
            First,
            Second,
            Third
        }

        private void ButtonChangeName_Click(object sender, RoutedEventArgs e)
        {
            ChangeByName((TabControl01.SelectedItem as TabItem).Header.ToString());
        }
            
        void ChangeByName(string HeaderName)
        {
            switch (HeaderName)
            {
                case "First":
                    TabControl01.SelectedItem = (int)Tab.Second; 
                    break;
                case "Second":
                    TabControl01.SelectedItem = (int)Tab.Third;
                    break;
                case "Third":
                    TabControl01.SelectedItem = (int)Tab.First;
                    break;
            }
        }
    }
}
