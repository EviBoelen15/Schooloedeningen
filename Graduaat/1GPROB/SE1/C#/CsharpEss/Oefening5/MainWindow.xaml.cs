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

namespace Oefening5
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

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            berekenen();
        }

        public void berekenen()
        {
            int intNT = Convert.ToInt32(txtNT.Text);
            int intKT = Convert.ToInt32(txtKT.Text);
            int intStudentenKaart = Convert.ToInt32(txtStudentenKaart.Text);

            double dblTotaal;

            dblTotaal = intNT * 9.10 + intKT * 8.10 + intStudentenKaart * 6.90;

            txtPrijs.Text = dblTotaal.ToString();
        }
    }
}
