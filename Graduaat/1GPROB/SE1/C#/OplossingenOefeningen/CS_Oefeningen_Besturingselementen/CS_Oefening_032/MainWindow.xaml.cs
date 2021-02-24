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

namespace CS_Oefening_032
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

        private void BtnSorteren_Click(object sender, RoutedEventArgs e)
        {
            // Sorteer de items in de LbxNamen op alfabetische volgorde.
            LbxNamen.Items.SortDescriptions.Add(
                new System.ComponentModel.SortDescription(
                    "Content", 
                    System.ComponentModel.ListSortDirection.Ascending));
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            // Alle elementen verwijderen.
            LbxNamen.Items.Clear();
        }

        private void BtnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            //  index == -1 : niets geselecteerd
            if (LbxNamen.SelectedIndex == -1)  
                return;

            // Element opvragen
            TxtResultaat.Text = ((ListBoxItem)LbxNamen.SelectedItem).Content.ToString();
            // RemoveAt gooit een exception wanneer er niets is geselecteerd.
            LbxNamen.Items.RemoveAt(LbxNamen.SelectedIndex);
            // Remove gooit geen exception wanneer er niets is geselecteerd.
            // LbxNamen.Items.Remove(LbxNamen.SelectedItem);
        }

        private void BtnVervangen_Click(object sender, RoutedEventArgs e)
        {
            // Index opvragen van het geselecteerde item
            int index = LbxNamen.SelectedIndex;
            // Als niets geselecteerd is, niets meer doen.
            if (index == -1)
                return;
            
            ((ListBoxItem)LbxNamen.SelectedItem).Content = TxtVervangen.Text;
            
            // Of verwijderen en invoegen naar specifieke plaats, maar dat is trager...
            /*
            LbxNamen.Items.RemoveAt(index);
            ListBoxItem item = new ListBoxItem();
            item.Content = TxtVervangen.Text;
            LbxNamen.Items.Insert(index, item);
            */
        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            // Achteraan toevoegen.
            ListBoxItem item = new ListBoxItem();
            item.Content = TxtToevoegen.Text;
            LbxNamen.Items.Add(item);
        }

        private void BtnZoeken_Click(object sender, RoutedEventArgs e)
        {
            int index = -1; // zet op -1 omdat we in het begin nog niks gevonden hebben
            int j = 0; // huidige positie in ListBox. Start vanaf 0

            foreach (ListBoxItem item in LbxNamen.Items) 
            { 
                if (item.Content.Equals(TxtZoeken.Text)) 
                { 
                    // Gevonden! Dus stoppen met zoeken => break om uit de lus te ontsnappen
                    index = j; 
                    break; 
                } 
                j++;
            }
            if (index != -1)
            {
                LblZoeken.Content = $"Item op plaats {index + 1} gevonden.";
                // Item in listbox selecteren.
                LbxNamen.SelectedIndex = index;
            }
            else 
            { 
                LblZoeken.Content = "Item niet gevonden."; 
            }
        }

        private void LbxNamen2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*
            TxtResultaat.Clear();
            foreach (ListBoxItem item in LbxNamen2.SelectedItems)
            {
                TxtResultaat.Text += $"{item.Content}\r\n";
            }
            */
            TxtResultaat.Text = $"Er zijn {LbxNamen2.SelectedItems.Count} item(s) geselecteerd.";
        }
    }
}
