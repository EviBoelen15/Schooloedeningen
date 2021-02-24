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

namespace WeerFkingRandomOef
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, int> disctZoekAfdeling = new Dictionary<string, int>();
        Dictionary<int, string[]> dictAfdelingen = new Dictionary<int, string[]>();
        string[] header;
        int maxKey = 0;

        private void BtnZoekAfdeling_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CreateHeader();
            CreateDictionary();
        }

        private void CreateHeader()
        {
            header = new string[3];
            header[0] = "NAAM";
            header[1] = "LOCATIE";
            header[2] = "HOOFD";
        }

        private void CreateDictionary()
        {
            dictAfdelingen.Add(10, CreateAfdelingARray("Hoofdkantoor", "Maasmechelen", "7782"));
            dictAfdelingen.Add(20, CreateAfdelingARray("Opleidingen", "Hasselt", "7566"));
            
        }

        private void CreateDictionaryItem(string[] item)
        {
            maxKey += 10;
            dictAfdelingen.Add(maxKey, item);

            string naam = item[0];
            if(dict)
        }
        private string[] CreateAfdelingARray(string naam, string locatie, string hoofd)
        {
            string[] item = new string[3];
            item[0] = naam;
            item[1] = locatie;
            item[2] = hoofd;
            return item;
        }
    }
}
