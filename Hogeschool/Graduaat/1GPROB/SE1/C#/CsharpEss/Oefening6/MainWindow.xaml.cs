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

namespace Oefening6
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
            string strNaam = txtNaam.ToString();
            decimal decUurloon = Convert.ToDecimal(txtUren.Text);
            int intAantalUren = Convert.ToInt32(txtUurloon.Text);

            decimal decBruto = decUurloon * intAantalUren;
            decimal decBelasting = decBruto / 100 * 21;
            decimal decNetto = decBruto - decBelasting;

            lbInfo.Items.Add("LOONFICHE VAN " + strNaam);
            lbInfo.Items.Add("Aantal gewerkte uren: " + intAantalUren);
            lbInfo.Items.Add("Uurloon: " + decUurloon);
            lbInfo.Items.Add("Brutojaarwedde: " + decBruto);
            lbInfo.Items.Add("Belasting: " + decBelasting);
            lbInfo.Items.Add("Nettojaarwedde: " + decNetto);
        }

        private void btnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtNaam.Clear();
            txtUren.Clear();
            txtUurloon.Clear();
        }

        private void btnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
