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

namespace Oefening4
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

        private void btnCont_Click(object sender, RoutedEventArgs e)
        {
            int OndNummer = Convert.ToInt32(txtOnd.Text);
            int intControle = OndNummer % 97;
            int intRest = 97 - intControle;
            txtContr.Text = intRest.ToString();
        }

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            decimal decPrijs = Convert.ToDecimal(txtPrijs.Text);
            int intAantal = Convert.ToInt32(txtAantal.Text);
            decimal decTotaal = decPrijs * intAantal;
            txtBetalen.Text = Convert.ToString(decTotaal);
        }

        private void btnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtOnd.Clear();
            txtPrijs.Clear();
            txtAantal.Clear();
            txtBetalen.Clear();
            txtContr.Clear();
        }

        private void btnSluiten_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
