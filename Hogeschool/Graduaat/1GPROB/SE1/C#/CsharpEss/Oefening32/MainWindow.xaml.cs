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

namespace Oefening32
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String[] namen = { "Sander", "Quirino", "Thomas",
            "Cédric", "Jason", "Domenico", "Rickert", "Klaas", "Tom", "Stephan", "Alexander",
            "Yannick", "Robin", "Dave", "Lynn", "Arno", "Niels", "Maxiem", "Matthijs", "Kobe",
            "Michaël", "Bram", "Achraf", "Raf", "Sven", "Gerben", "Kevin", "Cem", "Steff", "Steven",
            "Rani", "Djordy", "Nick", "Mikail", "Konstantin", "Asad", "Viktor", "Antonio", "Senne",
            "Benjamin", "Stef", "Abdul", "Christiaan", "Abdurrahman", "Jurgen", "Kevin", "Silvio",
            "Nathan", "Stijn", "Bart", "Frank", "Steven", "Matty", "Arend", "Simon", "Ziggy",
            "Pascal", "Michaël", "Danny", "Robby", "Johan", "Vincent", "Wim", "Tuba", "Kristof",
            "Kenneth" };

    public MainWindow()
        {
            InitializeComponent();
            VulListbox();
        }

        private void btnSorteren_Click(object sender, RoutedEventArgs e)
        {
            lbSingle.Items.Clear();
            Array.Sort(namen);
            VulListbox();
        }
        private void VulListbox()
        {
            for(int i = 0; i < namen.Length; i++)
            {
                lbSingle.Items.Add(namen[i]);
                lbMultiple.Items.Add(namen[i]);
            }
        }

        private void btnWisItem_Click(object sender, RoutedEventArgs e)
        {
            int index = lbSingle.SelectedIndex;
            if (index == -1)
                return;

            lbSingle.Items.Remove(lbSingle.SelectedItem);
        }

        private void btnWisListbox_Click(object sender, RoutedEventArgs e)
        {
            lbSingle.Items.Clear();
        }

        private void btnVervang_Click(object sender, RoutedEventArgs e)
        {
            int index = lbSingle.SelectedIndex;
            if (index == -1)
                return;

            lbSingle.Items.RemoveAt(index);
            lbSingle.Items.Insert(index, txtVervang.Text);
            //((ListBoxItem)LbxNamen.SelectedItem).Content = TxtVervangen.Text;
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            txtToevoegen.Text = lbSingle.SelectedItem.ToString();
            //ListBoxItem item = new ListBoxItem();
            //item.Content = TxtToevoegen.Text;
            //LbxNamen.Items.Add(item);
        }

        private void btnZoeken_Click(object sender, RoutedEventArgs e)
        {
            foreach (ListBoxItem naam in lbSingle.Items)
            {
                if (naam.ToString() == txtZoeken.Text)
                {
                    lblZoeken.Content = naam;
                }
            }
            lblZoeken.Content = "Item niet gevonden";
        }

        private void lbMultiple_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtAantalItems.Text = lbMultiple.SelectedItems.Count.ToString();
        }
    }
}
