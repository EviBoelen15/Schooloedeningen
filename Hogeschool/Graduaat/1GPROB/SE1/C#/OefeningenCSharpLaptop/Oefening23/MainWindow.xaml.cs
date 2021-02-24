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
        string land;
        int aantaljaar;
        double groei, bevolking, nieuweBevolking;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            land = txtLand.Text.ToString();
            bevolking = Convert.ToDouble(txtBevolking.Text);
            groei = Convert.ToDouble(txtGroeipercent.Text);
            //if (CheckVoorNull(groei) == false)
            //{
            //    lblUitvoer.Content = "zonder groeipercentage nooit een verdubbeling van de bevolking";
            //} else
            //{
            //    BerekenDubbel(bevolking, groei, nieuweBevolking);
            //}
            BerekenDubbel(bevolking, groei, nieuweBevolking);
        }
        private void BerekenDubbel(double bevolking, double groei, double nieuweBevolking)
        {
            nieuweBevolking = bevolking;
            while (nieuweBevolking < (bevolking * 2))
            {
                nieuweBevolking += (nieuweBevolking * groei);
                aantaljaar++;
                lblUitvoer.Content += nieuweBevolking.ToString();
            }
            VoegToe(land, bevolking, groei, aantaljaar, nieuweBevolking);
        }
        private void VoegToe(string land, double bevolking, double groei, int aantaljaar, double nieuweBevolking)
        {
            lblUitvoer.Content = $"Verdubbeling bevolking in {land} na {aantaljaar} jaren \n" +
                $"Nieuw bevolkingsaantal op dat moment: {nieuweBevolking}";
        }

        private bool CheckVoorNull(double groei)
        {
            if (groei == 0.00) 
            {
                return false;
            }
            return true;
        }
        private void btnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtBevolking.Text = null;
            txtGroeipercent.Text = null;
            txtLand.Text = null;
            lblUitvoer.Content = null;
        }

        private void btnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
