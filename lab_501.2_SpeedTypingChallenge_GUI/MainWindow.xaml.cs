﻿using System;
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

namespace lab_501._2_SpeedTypingChallenge_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            TB_NameInput.Text = File.ReadAllText("name.txt");
            //TB_HighScoreInput.Text = File.ReadAllText("score.txt");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("name.txt", TB_NameInput.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Window1 = new Window1();
            Window1.Show();
        }
    }
}
