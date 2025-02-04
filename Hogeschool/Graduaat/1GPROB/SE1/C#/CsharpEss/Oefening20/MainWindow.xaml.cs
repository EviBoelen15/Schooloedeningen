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

namespace Oefening20
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

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            vulTafels();
        }

        private void vulTafels()
        {
            string uitvoer = "";
            int maal = 0;
            for(int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    maal = i * j;
                    uitvoer += $"{i}   x   {j}   =   {maal} \n";
                }

            }
            txtGetallen.Text = uitvoer;
        }
    }
}
