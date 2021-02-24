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

namespace CS_Oefening_047
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> voornamen = new List<string>
                { "Wouter", "Paul", "Andreas", "Niels", "Kathleen", "Paul", "Silvia", "Patricia" };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAddList_Click(object sender, RoutedEventArgs e)
        {
            LbxNamen.Items.Clear();
            foreach (string voornaam in voornamen)
                LbxNamen.Items.Add(voornaam);
        }

        private void BtnInsertList_Click(object sender, RoutedEventArgs e)
        {
            string voornaam = "Aleandro";
            voornamen.Add(voornaam);
            LbxNamen.Items.Add(voornaam);
        }

        private void BtnDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            int index = LbxNamen.SelectedIndex;
            if (index == -1)
                return;

            voornamen.RemoveAt(index);
            LbxNamen.Items.RemoveAt(index);
        }

        private void BtnSortList_Click(object sender, RoutedEventArgs e)
        {
            voornamen.Sort();
            BtnAddList_Click(this, null);
        }

        private void BtnToArray_Click(object sender, RoutedEventArgs e)
        {
            string[] voornamenArray = voornamen.ToArray();
            StringBuilder builder = new StringBuilder();
            foreach (string voornaam in voornamenArray)
                builder.AppendLine(voornaam);
            TxtResultaat.Text = builder.ToString();
        }

        private void BtnFindItem_Click(object sender, RoutedEventArgs e)
        {
            string gezochteVoornaam = Interaction.InputBox("Geef de voornaam in die je wil zoeken", 
                "Voornaam zoeken", voornamen[0]);

            int index = voornamen.FindIndex(voornaam => voornaam.Equals(gezochteVoornaam));
            TxtResultaat.Text = index.ToString();
        }
    }
}
