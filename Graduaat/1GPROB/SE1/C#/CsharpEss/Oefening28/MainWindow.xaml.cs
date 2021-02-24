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

namespace Oefening28
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

        private void btnToonInkomen_Click(object sender, RoutedEventArgs e)
        {
            int totaalInkomen;

            int jaarsal = Convert.ToInt32(txtJaarsal.Text);
            int aantaljaar = Convert.ToInt32(txtAantalJaar.Text);

            ToonInkomen(jaarsal, aantaljaar, out totaalInkomen);

            txtTotaalInkomen.Text = $"$ {totaalInkomen.ToString()}";
        }

        private void ToonInkomen(int jaarsal, int aantaljaar, out int  totaalInkomen)
        {
            totaalInkomen = jaarsal * aantaljaar;
        }
    }
}
