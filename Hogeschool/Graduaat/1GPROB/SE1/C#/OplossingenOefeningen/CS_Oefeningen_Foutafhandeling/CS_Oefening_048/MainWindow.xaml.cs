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

namespace CS_Oefening_048
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            // Oorspronkelijke foute code
            int product = 0, teller = 1, getal = 0;
            txtResultaat.Text = "";
            getal = System.Convert.ToInt32(txtGetal.Text);
            while (product <= 1000 || teller <= 51)
            {
                product = getal * teller;
                txtResultaat.Text = txtResultaat.Text + teller.ToString() + " x " +
                    getal.ToString() + " = " + product.ToString() + "\r\n";
                teller++;
            }

            // Getest door getallen 17, 21, -17 en -21 in te lezen in txtGetal
            // Verbetering: 
            // * Voorwaarde in while moet && hebben ipv. || en 50 ipv. 51
            // * Vang de FormatException en OverflowException op van Convert.ToInt32()
            // * Als je geen negatief getal wil toelaten, dan moet je dit ook eerst testen
        }

        private void btnStart2_Click(object sender, RoutedEventArgs e)
        {
            int product = 0, teller = 1, getal = 0; 
            txtResultaat.Text = "";
            getal = System.Convert.ToInt32(txtGetal.Text); 
            while (product <= 1000 && teller < 51) 
            { 
                product = getal * teller; 
                txtResultaat.Text = txtResultaat.Text + teller.ToString() + " x " + 
                    getal.ToString() + " = " + product.ToString() + "\r\n"; 
                teller++; 
            }

            // Getest door getallen 17, 21, -17 en -21 in te lezen in txtGetal
            // Verbetering: 
            // * Vang de FormatException en OverflowException op van Convert.ToInt32()
            // * Als je geen negatief getal wil toelaten, dan moet je dit ook eerst testen
        }

        private void btnStartGoed_Click(object sender, RoutedEventArgs e)
        {
           
            int product = 0, teller = 1, getal = 0; 
            txtResultaat.Text = "";
            lblError.Content = "";
            try
            {
                getal = System.Convert.ToInt32(txtGetal.Text);
            }
            catch (FormatException)
            {
                lblError.Content = "(Alleen natuurlijke getallen worden toegestaan)";
                return;
            }
            catch (OverflowException)
            {
                lblError.Content = "(Getal is te groot)";
                return;
            }
            if (getal < 0)
            {
                lblError.Content = "(Geef een natuurlijk getal in)";
                return;
            }

            while (product <= 1000 && teller <= 50) 
            { 
                product = getal * teller; 
                txtResultaat.Text = txtResultaat.Text + teller.ToString() + " x " + 
                    getal.ToString() + " = " + product.ToString() + "\r\n"; 
                teller++; 
            }
        }

        private void btnOpnieuw_Click(object sender, RoutedEventArgs e)
        {
            txtGetal.Clear();
            txtResultaat.Clear();
            lblError.Content = string.Empty;
        }

        private void btnSluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnToonBeeld_Click(object sender, RoutedEventArgs e)
        {
            int getal = rnd.Next(10); // willekeurig getal van 0 t.e.m. 9
            string bestandsnaam = @$"..\..\..\images\zee{getal}.jpg";
            imgBeeld.Source = new BitmapImage(
                new Uri(AppDomain.CurrentDomain.BaseDirectory + bestandsnaam, UriKind.RelativeOrAbsolute));
        }

        // Let op de Content van deze Button in de XAML file:
        // Content="Toon beeld&#xa;met controle"
        // We gebruiken &#xa; voor een nieuwe regel!
        private void btnToonBeeldMetControle_Click(object sender, RoutedEventArgs e)
        {
            int getal = rnd.Next(10); // willekeurig getal van 0 t.e.m. 9
            string bestandsnaam = @$"..\..\..\images\zee{getal}.jpg";
            try
            {
                imgBeeld.Source = new BitmapImage(
                    new Uri(AppDomain.CurrentDomain.BaseDirectory + bestandsnaam, UriKind.RelativeOrAbsolute));
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Afbeelding niet aanwezig.", "Fout", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
