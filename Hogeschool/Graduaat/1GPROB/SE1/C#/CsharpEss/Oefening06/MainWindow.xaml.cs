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

namespace Oefening06
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
            decimal belasting = bruto * 0.3m;
            decimal netto = bruto - belasting;

            vulFiche(naam, uurLoon, aantalUren, bruto, netto, belasting);
        }

        private void vulFiche(string naam, decimal uurLoon, int aantalUren, decimal bruto, decimal netto, decimal belasting)
        {
            txtLoonfiche.Text = $"LOONFICHE VAN {naam}: \n " +
                $"Aantal gewerkte uren: {aantalUren} \n Uurloon: £{uurLoon} \n BrutoJaarloon: £{bruto} \n Belasting: £{belasting} \n NettoJaarWaarde: £{netto}";
        }
    }
}
