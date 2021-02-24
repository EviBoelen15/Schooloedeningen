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

namespace Oefening25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtBegin.ToolTip = "Tekstvak";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            decimal begin = 0.0M;
            decimal eind = 0.0M;
            decimal interestVoet = 0.0M;
            bool isMislukt = !decimal.TryParse(txtBegin.Text, out begin) ||
                !decimal.TryParse(txtEind.Text, out eind) ||
                !decimal.TryParse(txtIntrestvoet.Text, out interestVoet);

            if (begin >= eind)
            {
                txtUitvoer.Text = $"Waarde na 0 jaren: {begin}";
                return;
            }

            berekenEindKap(begin, eind, interestVoet);
        }

        private void berekenEindKap(decimal beginkapitaal, decimal eindkapitaal, decimal intrestvoet)
        {
            int intaantalJaar = 0;
            do
            {
                intaantalJaar++;
                beginkapitaal *= (1.0M + (intrestvoet / 100.0M));
                txtUitvoer.Text += $"Waarde na {intaantalJaar} jaren: {beginkapitaal:c} \n";

            } while (beginkapitaal < eindkapitaal);
        }
    }
}
