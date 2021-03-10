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

namespace KlasseGebruiker
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

        private void BtnConLeeg_Click(object sender, RoutedEventArgs e)
        {
            Gebruiker gb = new Gebruiker();

            gb.Voornaam = TxtVoornaam.Text;
            gb.Naam = TxtNaam.Text;

            TxtResultaat.Text = $"Voornaam:  {gb.Voornaam} \n";
            TxtResultaat.Text += $"Voornaam:  {gb.Naam} \n";

            TxtResultaat.Text += $"\n\n Naam van gebruiker: {gb.ToonNaam()}";
        }

        private void BtnConParam_Click(object sender, RoutedEventArgs e)
        {
            Gebruiker gb = new Gebruiker("Evi", "Boelen");

            gb.Voornaam = TxtVoornaam.Text;
            gb.Naam = TxtNaam.Text;

            TxtResultaat.Text = $"Voornaam:  {gb.Voornaam} \n";
            TxtResultaat.Text += $"Voornaam:  {gb.Naam} \n";
        }
    }
}
