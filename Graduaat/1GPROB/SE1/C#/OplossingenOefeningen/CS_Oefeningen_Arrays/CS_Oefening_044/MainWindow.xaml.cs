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

namespace CS_Oefening_044
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private short index = 0;
        private const short maxAantal = 100;
        private StringBuilder resultaatBuilder = new StringBuilder();

        // Naïeve manier
        private int[] tijden = new int[maxAantal];
        private string[] atleten = new string[maxAantal];

        // Efficiëntere manier (volgend semester)
        /*
        public struct Atleet : IComparable
        {
            public int Tijd;
            public string Naam;

            public Atleet(int tijd = 0, string naam = "")
            {
                Tijd = tijd;
                Naam = naam;
            }

            int IComparable.CompareTo(object obj)
            {
                if (obj == null) return 1;

                Atleet other = (Atleet)obj;
                return Tijd.CompareTo(other.Tijd);
            }
        }
        private Atleet[] atleetStructs = new Atleet[maxAantal];
        */

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void BtnNieuw_Click(object sender, RoutedEventArgs e) 
        { 
            if (index >= maxAantal)
            {
                MessageBox.Show($"Klik eerst op opnieuw. Het maximaal aantal atleten van {maxAantal} is bereikt!", 
                    "Waarschuwing", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Nieuwe invoer toevoegen aan arrays (naïeve manier)
            atleten[index] = TxtAtleet.Text; 
            tijden[index] = int.Parse(TxtAantalSec.Text);
            index++;

            // Nieuwe invoer toevoegen aan arrays (efficiënte manier)
            /*
            atleetStructs[index] = new Atleet(int.Parse(TxtAantalSec.Text), TxtAtleet.Text);
            index++;
            */
            
            // Klaarzetten voor nieuwe invoer
            TxtAtleet.Clear(); 
            TxtAantalSec.Text = "0";
            TxtAtleet.Focus();
        }
        
        private void BtnSnelste_Click(object sender, RoutedEventArgs e)
        {
            // Ordenen van klein naar groot.
            // Naïeve manier: zelf een sorteertalgoritme maken met tijdscomplexiteit O(n^2)
            // Dit hier is insertion sort
            for (int i = 0; i < index; i++)
            {
                int indexVanMinimum = i; 
                for (int j = i + 1; j < index; j++)
                    if (tijden[j] < tijden[indexVanMinimum])
                        indexVanMinimum = j; // indien sneller dan het minimum, wordt deze tijd het nieuwe minimum
             
                // Wissel (swap) vorige minimum (index i) met nieuwe minimum (indexVanMinimum)
                // eerst voor de tijden
                int tempTijd = tijden[i];
                tijden[i] = tijden[indexVanMinimum];
                tijden[indexVanMinimum] = tempTijd;
                
                // daarna voor de atleten
                string tempAtleet = atleten[i];
                atleten[i] = atleten[indexVanMinimum];
                atleten[indexVanMinimum] = tempAtleet;
            }
            // Resultaat opbouwen en tonen
            resultaatBuilder.Clear();
            for (int i = 0; i < index; i++)
                resultaatBuilder.AppendLine($"{atleten[i], -20}{tijden[i]}");
            TxtResultaat.Text = resultaatBuilder.ToString();
            

            // Sneller en efficiënter: Array.Sort() gebruiken => O(n log n)
            /*
            Array.Sort(atleetStructs, 0, aantal);
            
            // Resultaat opbouwen en tonen
            resultaatBuilder.Clear();
            for (int i = 0; i < index; i++)
            {
                resultaatBuilder.AppendLine($"{atleetStructs[i].Naam,-20}{atleetStructs[i].Tijd}");
            }
            TxtResultaat.Text = resultaatBuilder.ToString();
            */
        }

        private void BtnOpnieuw_Click(object sender, RoutedEventArgs e)
        {
            // Arrays leeg maken en aantal terug op 0 brengen
            index = 0;
            Array.Clear(tijden, 0, index);
            Array.Fill(atleten, "");

            // Tekstvakken leeg maken
            TxtResultaat.Clear();
            TxtAtleet.Clear();
            TxtAantalSec.Text = "0";
            TxtAtleet.Focus();
        }

        private void BtnAfsluiten_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
