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

        private void tnInkomen_Click(object sender, RoutedEventArgs e)
        {
            int jaarsalaris = Convert.ToInt32(txtAantaljaren.Text);
            int aantalJaren = Convert.ToInt32(txtAantaljaren.Text);
            ToonInkomen(jaarsalaris, aantalJaren);
        }
        private void ToonInkomen(int jaarsal, int aantaljaren)
        {
            txtTotaal.Text = (jaarsal * aantaljaren).ToString();
        }
    }
}
