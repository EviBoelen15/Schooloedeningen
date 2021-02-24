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

namespace Oefening08
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

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            string naam = txtNaam.Text;
            decimal uurLoon = Convert.ToDecimal(txtUurloon.Text);
            int aantalUren = Convert.ToInt32(txtAantalUren.Text);
            BerekenLoon(aantalUren, uurLoon, naam);
        }

        private void BerekenLoon(int aantalUren, decimal uurLoon, string naam)
        {
            decimal bruto = uurLoon * aantalUren;
            decimal belasting = BerekenBelasting(bruto);
            decimal netto = bruto - belasting;

            vulFiche(naam, uurLoon, aantalUren, bruto, netto, belasting);
        }

        private decimal BerekenBelasting(decimal bruto)
        {
            if (bruto <= 10000)
            {
                return bruto;
            }
            else if (bruto > 10000 && bruto <= 15000)
            {
                return bruto * 0.20m;
            } 
            else if (bruto > 15000 && bruto <= 25000)
            {
                return bruto * 0.30m;
            }
            else if (bruto > 25000 && bruto <= 50000)
            {
                return bruto * 0.40m;
            }
            else
            {
                return bruto * 0.50m;
            }
        }

        private void vulFiche(string naam, decimal uurLoon, int aantalUren, decimal bruto, decimal netto, decimal belasting)
        {
            txtLoonfiche.Text = $"LOONFICHE VAN {naam}: \n " +
                $"Aantal gewerkte uren: {aantalUren:c} \r\n Uurloon: £{uurLoon:c} \r\n BrutoJaarloon: £{bruto:c} \r\n Belasting: £{belasting:c} \r\n NettoJaarWaarde: £{netto:c}";
        }
    }
}
