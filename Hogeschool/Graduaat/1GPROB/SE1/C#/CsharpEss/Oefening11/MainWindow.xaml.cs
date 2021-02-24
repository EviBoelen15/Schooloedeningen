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

namespace Oefening11
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

        private void btnEvalueer_Click(object sender, RoutedEventArgs e)
        {
            txtRaad.IsEnabled = true;
        }

        private void btnNieuw_Click(object sender, RoutedEventArgs e)
        {
            maakRandom();
        }

        private void btnEinde_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtRaad_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool blRaden = int.TryParse(txtRaad.Text, out int getalRaden);
            if (getalRaden != )
        }

        private int maakRandom()
        {
            Random rndGetal = new Random();
            int intTeRadenGetal = rndGetal.Next(0, 101);

            return intTeRadenGetal;
        }

        private void checkGetal(int intGetal)
        {
            bool blRaden = int.TryParse(txtRaad.Text, out int getalRaden);
            int aantalgeraden = 0;

            if (blRaden)
            {
                if (getalRaden > intGetal)
                {
                    aantalgeraden++;
                    txtMelding.Text = "Raad lager";
                }
                else if (getalRaden < intGetal)
                {
                    aantalgeraden++;
                    txtMelding.Text = "Raad lager";
                }
                else
                {
                    txtAantalRaden.Text = "Aantal keer geraden: " + aantalgeraden;
                }
            }
        }
    }
}
