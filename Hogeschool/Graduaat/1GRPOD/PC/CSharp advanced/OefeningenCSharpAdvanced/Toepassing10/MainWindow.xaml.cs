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

namespace Toepassing10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persoon pers;
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pers = new Persoon();
            pers.Naam = TxtNaam.Text;
            pers.Voornaam = TxtVoornaam.Text;
            pers.Startjaar = 2016;
            pers.Geslacht = ((ComboBoxItem)CboGeslacht.SelectedItem).Content.ToString();
        }

        private void BtnVerhoog_Click(object sender, RoutedEventArgs e)
        {
            pers.VerhoogBeoordeling();
            TxtResultaat.Text = pers.ToonInfo();
        }

        private void BtnVerlaag_Click(object sender, RoutedEventArgs e)
        {
            pers.VerlaagBeoordeling();
            TxtResultaat.Text = pers.ToonInfo();
        }
    }
}
