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
using System.Globalization;

namespace Oefening16
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

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            bool blGetal = int.TryParse(txtInvoer.Text, out int intGetal);

            if (blGetal)
            {
                berekenGetal(intGetal, 10);
            } 
            else {
                MessageBox.Show("Foute ingave");
            }
            
        }
        private void berekenGetal(int getal, int macht)
        {
            for (int i = 0; i < macht; i++)
            {
                lbGetallen.Items.Add(uitvoerendeMacht(getal, i));
            }
        }
        private string uitvoerendeMacht(int getal, int macht)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = " ";

            double intMacht = Math.Pow(getal, macht);
            string uitvoer = $"Macht van 0{macht} van {getal} is {intMacht}";
            return uitvoer;
        }
    }
}
