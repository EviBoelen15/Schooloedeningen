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

namespace Oefening3
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

        private void Click_Button(object sender, RoutedEventArgs e)
        {
            string bewerking = ((Button)sender).Content.ToString();
            double getal1 = Convert.ToDouble(txtGetal1.Text);
            double getal2 = Convert.ToDouble(txtGetal2.Text);

            txtResultaat.Text = Bereken(bewerking, getal1, getal2);
        }

        private string Bereken(string bewerking, double getal1, double getal2)
        {
            double resultaat = 0;

            switch (bewerking)
            {
                case "+":
                    resultaat = getal1 + getal2;
                    break;

                case "-":
                    resultaat = getal1 - getal2;
                    break;

                case "*":
                    resultaat = getal1 * getal2;
                    break;

                case "/":
                    resultaat = getal1 / getal2;
                    break;
            }
            return resultaat.ToString();
        }
        private void btnWis_Click(object sender, RoutedEventArgs e)
        {
            txtGetal1.Text = null;
            txtGetal2.Text = null;
            txtResultaat.Text = null;
        }
    }
}
