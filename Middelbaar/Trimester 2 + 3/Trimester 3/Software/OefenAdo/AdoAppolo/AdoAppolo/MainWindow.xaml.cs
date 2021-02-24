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

namespace AdoAppolo
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

        private void BtnLeverancier_Click(object sender, RoutedEventArgs e)
        {
            Leveranviers leveranciers = new Leveranviers();
            leveranciers.Show();
        }

        private void BtnType_Click(object sender, RoutedEventArgs e)
        {
            KlantPerType klantPerType = new KlantPerType();
            klantPerType.Show();
        }

        private void BtnKlantgegevens_Click(object sender, RoutedEventArgs e)
        {
            Klantgegevens klantgegevens = new Klantgegevens();
            klantgegevens.Show();
        }
    }
}
