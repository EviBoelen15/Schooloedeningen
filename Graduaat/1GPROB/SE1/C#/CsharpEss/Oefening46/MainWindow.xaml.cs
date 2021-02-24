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

namespace Oefening46
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

        private void btnGooi_Click(object sender, RoutedEventArgs e)
        {
            int worp1 = 0, worp2 = 0;
            bool verkeerdeInvoer = !int.TryParse(txtWorp1.Text, out worp1) || !int.TryParse(txtWorp2.Text, out worp2);

            if(verkeerdeInvoer)
            {
                MessageBox.Show("Geef geldige getallen in AUB");
            } 
            else
            {
                SimuleerWorp(worp1, worp2);
            }

        }

        private void btnComputer_Click(object sender, RoutedEventArgs e)
        {
            SimuleerHonderdWorpen();
        }

        private void btnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void SimuleerWorp(int worp1, int worp2)
        {
            int totaal = worp1 + worp2;
            txtWorpTotaal.Text = totaal.ToString();
        }

        private void SimuleerHonderdWorpen()
        {
            int somWorpen = 0;
            int somTweeWorpen;
            int worp1, worp2;
            int int2 = 0, int3 = 0, int4 = 0, int5 = 0, int6 = 0, int7 = 0, int8 = 0, int9 = 0, int10 = 0, int11 = 0, int12 = 0;

            Random randomWorp = new Random();

            while (somWorpen < 1000)
            {
                worp1 = randomWorp.Next(1, 7);
                worp2 = randomWorp.Next(1, 7);

                somTweeWorpen = worp1 + worp2; 
                switch(somTweeWorpen)
                {
                    case 2:
                        int2++;
                        break;
                    case 3:
                        int3++;
                        break;
                    case 4:
                        int4++;
                        break;
                    case 5:
                        int5++;
                        break;
                    case 6:
                        int6++;
                        break;
                    case 7:
                        int7++;
                        break;
                    case 8:
                        int8++;
                        break;
                    case 9:
                        int9++;
                        break;
                    case 10:
                        int10++;
                        break;
                    case 11:
                        int11++;
                        break;
                    case 12:
                        int12++;
                        break;
                }
                somWorpen += somTweeWorpen;
            }
            txtTwee.Text = int2.ToString();
            txtDrie.Text = int3.ToString();
            txtVier.Text = int4.ToString();
            txtVijf.Text = int5.ToString();
            txtZes.Text = int6.ToString();
            txtZeven.Text = int7.ToString();
            txtAcht.Text = int8.ToString();
            txtNegen.Text = int9.ToString();
            txtTien.Text = int10.ToString();
            txtElf.Text = int11.ToString();
            txtTwaalf.Text = int12.ToString();
            txtTotaal.Text = somWorpen.ToString();
        }
    }
}
