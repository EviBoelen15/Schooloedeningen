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

namespace TestArray
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
        string[] vakken, studenten;
        int[,] punten;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            vakken = new string[] { "c#", "Data", "Web" };
            studenten = new string[] { "Kristof", "Patricia" };
            punten = new int[ studenten.Length, vakken.Length];
            ToonKolomTitel(vakken);
            ToonRijTitel(studenten);
            LogAantalElementenInArray(vakken);
            LogAantalElementenInArray("studenten", studenten);
        }

        private void LogAantalElementenInArray(string[] invoer)
        {
            LogAantalElementenInArray("", invoer);
        }
        private void LogAantalElementenInArray(string naam, string[] invoer)
        {
            string naamArray = (naam != "") ? $"met naam {naam}" : "";
            string tekst = $"de invoer array {naamArray} heeft {invoer.Length} elementen";
            LstLog.Items.Add(tekst);
        }
        private void ToonKolomTitel(string[] invoer)
        {
            lblColHeader1.Content = vakken[0];
            lblColHeader2.Content = vakken[1];
            lblColHeader3.Content = vakken[2];
        }

        private void lblColHeader1_MouseEnter(object sender, MouseEventArgs e)
        {
            BerekenGemiddelde();
        }

        private void BerekenGemiddelde(int kolom)
        {
            VulArrayPunten();
            if (kolom == 1)
            {
                w1 = punten[0, 0];
                w2 = punten[1, 0];
                BerekenGemiddelde = (w1 + w2) / 2;
            }
        }
        private void VulArrayPunten()
        {
            punten[0, 0] = GetTextboxValue(txtRow1Col1);
            punten[0, 1] = GetTextboxValue(txtRow1Col2);
            punten[0, 2] = GetTextboxValue(txtRow1Col3);
            punten[1, 0] = GetTextboxValue(txtRow2Col1);
            punten[1, 1] = GetTextboxValue(txtRow2Col2);
            punten[1, 2] = GetTextboxValue(txtRow2Col3);
        }
        private int GetTextboxValue(TextBox tb)
        {
            int waarde = 0;
            if(int.TryParse(tb.Text, out waarde))
            {

            }
        }
        private void ToonRijTitel(string[] invoer)
        {
            LblRowHeader1.Content = studenten[0];
            LblRowHeader2.Content = studenten[1];
        }

    }
}
