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

namespace Oefening017
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
            
            int getal = Convert.ToInt32(txtGetal.Text);
            txtTotaal.Text = Faculteit(getal).ToString();
        }

        private int Faculteit(int getal)
        {
            int totaal = getal;
            for(int i = getal; i > 0; i--)
            {
                totaal = totaal * (i - 1);
            }
            return totaal;
        }
    }
}
