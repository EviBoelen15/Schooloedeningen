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

namespace Oefening_9
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool blJaar = int.TryParse(txtJaar.Text, out int jaar);
            
            if (blJaar)
            {
                lblNummeriek.Content = "Is nummeriek";
            } else
            {
                lblNummeriek.Content = "Is niet nummeriek";
            }
        }

        private void txtJaar_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool blJaar = int.TryParse(txtJaar.Text, out int jaar);

            if (blJaar)
            {
                lblNummeriek.Content = "Is nummeriek";
            }
            else
            {
                lblNummeriek.Content = "Is niet nummeriek";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            const double cdblPerStudiepunt = 15.65;
            const int cintSchrikkel = 8;
            bool blJaar = int.TryParse(txtJaar.Text, out int jaar);
            bool blSP = int.TryParse(txtSP.Text, out int SP);

            if  (blSP && blJaar)
            {
                if (jaar % 4 == 0 && jaar % 400 == 0)
                {
                    txtInschrijving.Text = (SP * cdblPerStudiepunt + cintSchrikkel).ToString();
                }
            }
        }
    }
}
