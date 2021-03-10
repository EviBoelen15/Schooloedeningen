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

namespace Toepassing07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bankrekening bnk = new Bankrekening();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            bnk.HuidigSaldo = Convert.ToDecimal(txtBasisbedrag.Text);

            if(Convert.ToDecimal(txtToevoegingbedrag.Text) < 0)
            {
                bnk.Opname(Convert.ToDecimal(txtToevoegingbedrag.Text));
            }
            else
            {
                bnk.Storting(Convert.ToDecimal(txtToevoegingbedrag.Text));
            }
            txtHuidigbedrag.Text = bnk.HuidigSaldo.ToString();
        }
    }
}
