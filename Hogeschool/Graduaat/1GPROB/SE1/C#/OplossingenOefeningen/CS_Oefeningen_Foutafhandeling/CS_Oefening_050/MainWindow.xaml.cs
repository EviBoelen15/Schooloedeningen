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

namespace CS_Oefening_50
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

        private void Reset()
        {
            txtDeeltal.Clear();
            txtDeler.Clear();
            txtQuotient.Clear();
            txtDeeltal.Focus();
        }

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int deeltal = Convert.ToInt32(txtDeeltal.Text);
                int deler = Convert.ToInt32(txtDeler.Text);
                float quotient = ((float)deeltal) / deler;
                txtQuotient.Text = $"{quotient:n2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Je moet 2 gehele getallen ingeven.\r\n\r\nDe indeling van de invoertekenreeks is onjuist.",
                    "Conversiefout bij DELER/DEELTAL", MessageBoxButton.OK, MessageBoxImage.Error);
                Reset();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Je moet 2 gehele getallen ingeven.\r\n\r\nDe indeling van de invoertekenreeks is onjuist.",
                   "Conversiefout bij DELER/DEELTAL", MessageBoxButton.OK, MessageBoxImage.Error);
                Reset();
            }
        }

        
        private void btnSpecifiekeFout_Click(object sender, RoutedEventArgs e)
        {
            // Deeltal
            int deeltal;
            try
            {
                deeltal = Convert.ToInt32(txtDeeltal.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Fout bij DEELTAL: De indeling van de invoertekenreeks is onjuist.", 
                    "Conversiefout", MessageBoxButton.OK, MessageBoxImage.Error);
                Reset();
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("DEELTAL is te groot!", "Conversiefout", MessageBoxButton.OK, MessageBoxImage.Error);
                Reset();
                return;
            }

            // Deler
            int deler;
            try
            {
                deler = Convert.ToInt32(txtDeler.Text);
                if (deler == 0)
                {
                    throw new DivideByZeroException("De deler mag niet 0 zijn.");
                }
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "FOUT BIJ DELING", MessageBoxButton.OK, MessageBoxImage.Error);
                Reset();
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Fout bij DELER: De indeling van de invoertekenreeks is onjuist.",
                    "Conversiefout", MessageBoxButton.OK, MessageBoxImage.Error);
                Reset();
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("DELER is te groot!", "Conversiefout", MessageBoxButton.OK, MessageBoxImage.Error);
                Reset();
                return;
            }

            // Quotient
            // De returns in iedere catch voorkomen dat de code hieronder wordt uitgevoerd
            float quotient = ((float)deeltal) / deler;
            txtQuotient.Text = $"{quotient:n2}";
        } 
    }
}
