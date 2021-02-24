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

namespace Oef29
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

        private void OnClick_Berekening(object sender, RoutedEventArgs e)
        {
            char command = Convert.ToChar(((Button)sender).Content.ToString());
            leesGetallen(TxtGetal1, TxtGetal2, command);
        }

        private void leesGetallen(TextBox getal1, TextBox getal2, char command)
        {
            decimal decgetal1 = 0, decgetal2 = 0;
            if(validateTextbox(getal1, ref decgetal1) && validateTextbox(getal2, ref decgetal2))
            {
                berekenen(decgetal1, decgetal2, command);
            }
        }
        private bool validateTextbox(TextBox tb, ref decimal uitvoer)
        {
            bool validate = false;
            if(decimal.TryParse(tb.Text, out uitvoer))
            {
                tb.Background = Brushes.White;
                validate = true;
            } else
            {
                tb.Background = Brushes.Red;
                validate = false;
            }
            return validate;
        }
        private decimal berekenen(decimal getal1, decimal getal2, char command)
        {
            decimal resultaat = 0;
            switch(command)
            {
                case '+':
                    resultaat = getal1 + getal2;
                    break;
                case '-':
                    resultaat = getal1 - getal2;
                    break;
                case '*':
                    resultaat = getal1 * getal2;
                    break;
                case ':':
                    resultaat = getal1 / getal2;
                    break;
                default:
                    foutBoodschap();
                    break;
            }
            return resultaat;
        }
        private void foutBoodschap()
        {
            MessageBox.Show("Foute waarde");
        }
    }
}
