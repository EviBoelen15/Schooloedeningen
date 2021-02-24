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

namespace Oefening016
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

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int getal = Convert.ToInt32(txtGetal.Text);
            BerekenMacht(getal);
        }

        private void BerekenMacht(int getal)
        {
            if (CheckGrens(getal))
            {
                for(int i = 1; i <= 10; i++)
                {
                    lblMachten.Content = $"Macht {i} van {getal} is {Math.Pow(getal, i)} \n";
                }
            } 
            else
            {
                MessageBox.Show("Kleiner getal invullen");
            }
        }

        private bool CheckGrens(int getal)
        {
            bool blGroter;
            if (getal < 84)
            {
                blGroter = true;
            }
            else
            {
                blGroter = false;
            }
            return blGroter;
        }
    }
}
