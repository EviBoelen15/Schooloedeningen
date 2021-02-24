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

namespace Oefening47
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> lstNamen;
        string[] arrayNamen;
        public MainWindow()
        {
            InitializeComponent();
            lstNamen = new List<string>();
            lstNamen.Add("Wouter");
            lstNamen.Add("Paul");
            lstNamen.Add("Andreas");
            lstNamen.Add("Niels");
            lstNamen.Add("Kathleen");
            lstNamen.Add("Paul");
            lstNamen.Add("Silvia");
            lstNamen.Add("Patricia");

            arrayNamen = new string[lstNamen.Count()];
        }

        private void btnAddList_Click(object sender, RoutedEventArgs e)
        {
            DrukLijstAf();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            lstNamen.Add("Alejandro");
            DrukLijstAf();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int index = 0;
            string antwoord = Interaction.InputBox("Wie wil je verwijderen?", "Invoer", "Geef naam");
            foreach (string naam in lstNamen)
            {
                if(antwoord == naam)
                {
                    index = lstNamen.IndexOf(naam);
                }
            }
            lstNamen.RemoveAt(index);
            DrukLijstAf();
        }

        private void btnSortList_Click(object sender, RoutedEventArgs e)
        {
            lstNamen.Sort();
            DrukLijstAf();
        }

        private void btnToArray_Click(object sender, RoutedEventArgs e)
        {
            arrayNamen = lstNamen.ToArray();
            DrukArrayAf();
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            int index = 0;
            string antwoord = Interaction.InputBox("Welke index wil je zien?", "Invoer", "Geef naam");
            foreach (string naam in lstNamen)
            {
                if (antwoord == naam)
                {
                    index = lstNamen.IndexOf(naam);
                }
            }
            MessageBox.Show($"{index + 1}");
        }

        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCopyGedeelte_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReverse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            Array.Sort(arrayNamen);
            DrukArrayAf();
        }

        private void btnSortGedeelte_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnToList_Click(object sender, RoutedEventArgs e)
        {
            arrayNamen.ToList();
        }

        private void DrukLijstAf()
        {
            txtList.Text = null;
            foreach (string naam in lstNamen)
            {
                txtList.Text += $"{naam} \n";
            }
        }
        private void DrukArrayAf()
        {
            string uitvoer = "";
            for(int i = 0; i < arrayNamen.Length; i++)
            {
                uitvoer += $"{arrayNamen[i]} \n";
            }
            txtArray.Text = uitvoer;
        }
    }
}
