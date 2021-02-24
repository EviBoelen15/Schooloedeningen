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

namespace CS_Oefening_034
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float getal1 = 0;
        private float getal2 = 0;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        // Methode dat de getallen inleest.
        private void LeesGetallen()
        {
            getal1 = float.Parse(TxtGetal1.Text);
            getal2 = float.Parse(TxtGetal2.Text);
        }
        
        // Methode dat de getallen berekent.
        private float Berekenen(char teken)
        {
            // Alle menu-items eerst vinkje uitschakelen.
            MnuOptellen.IsChecked = false;
            MnuAftrekken.IsChecked = false;
            MnuVermenigvuldiging.IsChecked = false;
            MnuDeling.IsChecked = false;
            
            switch (teken)
            {
                case '+':
                    MnuOptellen.IsChecked = true;
                    return getal1 + getal2;
                case '-':
                    MnuAftrekken.IsChecked = true;
                    return getal1 -getal2;
                case '*':
                    MnuVermenigvuldiging.IsChecked = true;
                    return getal1 * getal2;
                case '/':
                    MnuDeling.IsChecked = true;
                    return getal1 / getal2;
                default: 
                    return 0;  // Je moet altijd waarde teruggeven, ook als cases niet voldoen.
            }
        }

        public void BtnSluiten_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            LeesGetallen();
            TxtResultaat.Text = Berekenen('+').ToString();
        }

        private void BtnDeel_Click(object sender, RoutedEventArgs e)
        {
            // Je moet niet meer testen op deling door 0 want er wordt automatisch 'oneindig' gegeven!
            LeesGetallen(); 
            TxtResultaat.Text = Berekenen('/').ToString();
        }

        private void BtnMaal_Click(object sender, RoutedEventArgs e)
        { 
            LeesGetallen();
            TxtResultaat.Text = Berekenen('*').ToString(); 
        }

        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            LeesGetallen();
            TxtResultaat.Text = Berekenen('-').ToString();
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        { 
            TxtGetal1.Text = "0"; 
            TxtGetal2.Text = "0"; 
            TxtResultaat.Clear(); 
            TxtGetal1.Focus();
        }

        private void MnuDeling_Click(object sender, RoutedEventArgs e)
        {
            LeesGetallen();
            TxtResultaat.Text = Berekenen('/').ToString();
            //BtnDeel_Click(this, null);
        }
        private void MnuVermenigvuldiging_Click(object sender, RoutedEventArgs e)
        {
            LeesGetallen();
            TxtResultaat.Text = Berekenen('*').ToString();
        }

        private void MnuAftrekken_Click(object sender, RoutedEventArgs e) 
        { 
            LeesGetallen(); 
            TxtResultaat.Text = Berekenen('-').ToString(); 
        }
        private void MnuOptellen_Click(object sender, RoutedEventArgs e)
        { 
            LeesGetallen(); 
            TxtResultaat.Text = Berekenen('+').ToString(); 
        }

        private void MnuAfsluiten_Click(object sender, RoutedEventArgs e)
        { 
            Close(); 
        }
    }
}
