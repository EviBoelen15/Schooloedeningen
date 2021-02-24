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

namespace Oefening05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const decimal NORMAAL = 9.10m, KORTING = 8.10m, STUDENT = 6.90m;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            int normaal = Convert.ToInt32(txtNormaal.Text);
            int korting = Convert.ToInt32(txtKorting.Text);
            int student = Convert.ToInt32(txtStudent.Text);

            txtTotaalPrijs.Text = berekenTotaal(normaal, korting, student);
        }

        private string berekenTotaal(int normaal, int korting, int student)
        {
            decimal decTotaal = (normaal * NORMAAL) + (korting * KORTING) + (student * STUDENT);
            return decTotaal.ToString();
        }
    }
}
