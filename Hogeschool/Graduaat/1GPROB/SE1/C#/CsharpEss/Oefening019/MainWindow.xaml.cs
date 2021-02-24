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

namespace Oefening019
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int AANTAL_DAGEN_PER_JAAR = 365;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            int aantalPersonen = Convert.ToInt32(txtAantalPersonen.Text);
            txtAantalKans.Text = $"De kans op gelijke verjaardagen bij {aantalPersonen} is: {BerekenApparteVerjaardag(aantalPersonen).ToString()}%";
        }

        private double BerekenApparteVerjaardag(int aantalPersonen)
        {
            float dblFormule = 1.0f;
            int aantaldagen = 365;
            
            for (int i = 364; i >= AANTAL_DAGEN_PER_JAAR - (aantalPersonen - 1); i--)
            {
                aantaldagen--;
                dblFormule *= (i / (float)AANTAL_DAGEN_PER_JAAR); 
            }  
            dblFormule *= 100;

            float kansOpDezelfdeDag = 100 - dblFormule;

            return Math.Round(kansOpDezelfdeDag, 2);
        }
    }
}
