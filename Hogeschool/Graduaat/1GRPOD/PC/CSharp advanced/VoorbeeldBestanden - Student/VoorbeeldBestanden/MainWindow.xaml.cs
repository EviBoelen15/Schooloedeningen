using System;
using System.IO;
using System.Windows;

namespace VoorbeeldBestanden
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

        private void BtnWriteCsv_Click(object sender, RoutedEventArgs e)
        {
            string[] velden;
            TxtResultaat.Clear();

            using(StreamReader sr = new StreamReader(@"..\..\bin\debug\KlasCsv.txt"))
            {
                while(!sr.EndOfStream)
                {
                    velden = sr.ReadLine().Split(';');
                    TxtResultaat.Text += $"Naam: {velden[0],-15} Voornaam: {velden[1]} \n";
                }
            }
        }

        private void BtnFixRead_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Clear();

            //bestand vaste lengte maken
            //vast bestand bestaat uit 17 + 12 karakters
            
            //vaste lengte geven
            using (StreamReader sr = new StreamReader(@"..\..\Bestanden\KlasVast.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string lijn = sr.ReadLine();
                    string veld1 = lijn.Substring(0, 16).Trim(); 
                    string veld2 = lijn.Substring(17, 11).Trim();

                    TxtResultaat.Text += $"{veld2}, {veld1}\n";
                }
            }
        }
    }
}
