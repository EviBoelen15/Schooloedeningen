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

namespace Oefening24
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
            decimal weekgeld = Convert.ToDecimal(txtWeekgeld.Text);
            decimal verhoging = Convert.ToDecimal(txtVerhogingPercent.Text);
            decimal gewenstBedrag = Convert.ToDecimal(txtGewenstTotaal.Text);

            BerekenAantalWeken(weekgeld, verhoging, gewenstBedrag);

        }

        private void BerekenAantalWeken(decimal weekGeld, decimal verhoging, decimal eindBedrag) 
        {
            int aantalWeken = 0;
            decimal totaalGespaard = weekGeld;
            decimal nieuwWeekgeld = 0;
            decimal spaargeld = 0;

            do
            {
                spaargeld += weekGeld;
                nieuwWeekgeld += verhoging;
                totaalGespaard = spaargeld + nieuwWeekgeld;

                aantalWeken++;

            } while (totaalGespaard < eindBedrag);

                txtUitvoer.Text = $"Spaarbedrag na {aantalWeken} weken: {spaargeld} \n" +
                $"Extra weekgeld op dat moment: {nieuwWeekgeld} \n" +
                $"Totaal spaargeld: {totaalGespaard}";
        }

    }
}
