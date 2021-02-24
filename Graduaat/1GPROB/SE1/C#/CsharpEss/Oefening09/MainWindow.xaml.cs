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

namespace Oefening09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int urenStudiePunt = 25;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTestNummeriek_Click(object sender, RoutedEventArgs e)
        {
            int jaar = Convert.ToInt32(txtJaar.Text);
            int studiePunten = Convert.ToInt32(txtSP.Text);
            TestNummeriek(jaar);
            txtInschijvingsgeld.Text = BerekenInschrijvingsgeld(studiePunten, jaar);
        }

        private void TestNummeriek(int jaar)
        {
            bool blIsNummeriek = int.TryParse(txtJaar.Text, out jaar);
            if (blIsNummeriek)
            {
                lblNummeriek.Content = "Is nummeriek";
            } else
            {
                lblNummeriek.Content = "Is NIET nummeriek";
            }

        }

        private string BerekenInschrijvingsgeld(int studiepunten, int jaar)
        {
            decimal decInschrijvingsgeld;

            if (CheckSchrikkeljaar(jaar))
            {
                decInschrijvingsgeld = (studiepunten + 8) * urenStudiePunt;
            } 
            else
            {
                decInschrijvingsgeld = studiepunten * urenStudiePunt;
            }
            return decInschrijvingsgeld.ToString();
        }
        private bool CheckSchrikkeljaar(int jaar)
        {
            bool blSchrikkeljaar;
            if (jaar % 4 == 0 || jaar % 400 == 0)
            {
                blSchrikkeljaar = true;
            } 
            else
            {
                blSchrikkeljaar = false;
            }
            return blSchrikkeljaar;
        }
    }
}
