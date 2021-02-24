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

namespace Oefening04
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

        private void btnControle_Click(object sender, RoutedEventArgs e)
        {
            int ondernemingsNummer = Convert.ToInt32(txtOnd.Text);
            int controleCijfer = Convert.ToInt32(txtOndEnd.Text);

            CheckOndernemingsNummer(ondernemingsNummer, controleCijfer);
        }

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            decimal prijs = Convert.ToDecimal(txtPrijs.Text);
            int aantal = Convert.ToInt32(txtAantal.Text);

            txtTeBetalen.Text = BerekenTeBetalen(prijs, aantal);

        }
        private void CheckOndernemingsNummer(int ondernemingsnummer, int controlecijfer)
        {
            int deelOndernemingsnummer = ondernemingsnummer / 97;
            if ((97 - deelOndernemingsnummer) == controlecijfer)
            {
                txtOnd.Background = Brushes.Green;
            }
            else
            {
                txtOnd.Background = Brushes.Red;
            }
        }

        private string BerekenTeBetalen(decimal prijs, int aantal)
        {
            decimal decTotaal = prijs * aantal;
            return decTotaal.ToString();
        }
    }
}
