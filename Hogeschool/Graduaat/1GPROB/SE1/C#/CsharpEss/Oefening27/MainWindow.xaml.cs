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
using Microsoft.VisualBasic;

namespace Oefening27
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
            int aantalKeer = 0;
            Random rnd = new Random();
            int randomGetal = rnd.Next(0, 101);

            string antwoord = Interaction.InputBox("Geef een getal", "Invoer", "50");
            int getal = Convert.ToInt32(antwoord);

            while (getal != randomGetal)
            {
                aantalKeer++;
                if (string.IsNullOrEmpty(antwoord) || !int.TryParse(antwoord, out getal)) 
                {
                    MessageBox.Show("Geef een geldig getal in");
                }
                else if (getal < randomGetal)
                {
                    MessageBox.Show("Raad hoger!", "Raadspel");
                }
                else
                {
                    MessageBox.Show("Raad lager!", "Raadspel");
                }
                antwoord = Interaction.InputBox("Geef een getal", "Invoer", "50");
            }
            MessageBox.Show($"U hebt het getal geraden in {aantalKeer} beurten!");
        }
        private void btnSluit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }


    }
}
