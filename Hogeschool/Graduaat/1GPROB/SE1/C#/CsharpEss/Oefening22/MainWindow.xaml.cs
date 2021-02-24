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

namespace Oefening22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            vulWorpen();
        }

        private void vulWorpen()
        {
            int worp = rnd.Next(1, 7);

            string uitvoer = "";
            int teller = 0;

            while(worp != 6)
            {
                teller++;
                uitvoer += $"Worp {teller} geeft {worp} \n";
                worp = rnd.Next(0, 7);
            }
            uitvoer += $"Worp {teller + 1} geeft {worp}";
            txtWorpen.Text = uitvoer;
        }
    }
}
