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

namespace Oefening23
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

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            int bevolking = Convert.ToInt32(txtHuidigeBevolking.Text);
            double groeiPercent = Convert.ToDouble(txtGroei.Text);
            string land = txtLand.Text;

            if (groeiPercent == 0.00)
            {
                MessageBox.Show("Zonder groeipercent nooit een verdubbeling");
            }
            BerekenWanneerDubbel(bevolking, groeiPercent, land);

        }

        private void BerekenWanneerDubbel(double bevolking, double groeiPercent, string land)
        {
            double dubbelBevolking = bevolking * 2;
            int aantalJaar = 0;
            double groeiFactor = (1.0 + (groeiPercent / 100.0));

            while (bevolking < dubbelBevolking)
            {
                bevolking *= groeiFactor;
                aantalJaar++;
            }

            txtResultaat.Text = $"Verdubbelende bevolking van {land} na {aantalJaar} jaren \n" +
                $"Nieuw bevolkingsaantal op dat moment: {Math.Round(bevolking, 2)}";

        }
    }
}
