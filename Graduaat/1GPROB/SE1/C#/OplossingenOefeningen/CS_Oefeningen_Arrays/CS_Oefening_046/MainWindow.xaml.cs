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

namespace CS_Oefening_046
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int maxAantalComputerWorpen = 1000;
        private Random rnd = new Random();
        
        private int worp1 = 0;
        private int worp2 = 0;
        private int som = 0;

        private int[] aantallen;

        public MainWindow()
        {
            InitializeComponent();

            int aantalTextBoxes = CanTotaal.Children.OfType<TextBox>().Count() - 1; // laatste textbox is het totaal
            aantallen = new int[aantalTextBoxes];
        }

        public void ComputerSimulatie()
        {
            worp1 = rnd.Next(1, 7);
            worp2 = rnd.Next(1, 7);
            som = worp1 + worp2;
            int index = som - 2; // -2 omdat totaal van 2 de index 0 krijgt in array
            aantallen[index]++;
        }

        private void Simulatie()
        {
            worp1 = rnd.Next(1, 7);
            worp2 = rnd.Next(1, 7);
            som = worp1 + worp2;
        }

        private void BtnGooi_Click(object sender, RoutedEventArgs e)
        {
            Simulatie();
            TxtWorp1.Text = worp1.ToString();
            TxtWorp2.Text = worp2.ToString();
            TxtTotWorp.Text = som.ToString();
        }

        private void BtnComputer_Click(object sender, RoutedEventArgs e)
        {
            // Reset alle waardes
            som = 0;
            Array.Fill(aantallen, 0);

            // Maak TextBoxes leeg
            TxtWorp1.Clear();
            TxtWorp2.Clear();
            TxtTotWorp.Clear();
            
            // Simulaties
            for (int i = 0; i < maxAantalComputerWorpen; i++)
                ComputerSimulatie();
            
            // Toon resultaten
            for (int i = 0; i < aantallen.Length; i++)
            {
                TextBox textBox = CanTotaal.Children.OfType<TextBox>().ElementAt(i);
                textBox.Text = aantallen[i].ToString();
            }
            TxtTotComputer.Text = maxAantalComputerWorpen.ToString();
        }

        private void ButtonAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
