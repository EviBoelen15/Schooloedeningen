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

namespace WPFReizen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Reis objReis;
        VerzamelingReizen lijstReizen;

        public MainWindow()
        {
            InitializeComponent();
            lijstReizen = new VerzamelingReizen(2018);
        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            objReis = new Reis(txtLand.Text, Convert.ToInt16(txtDagen.Text), Convert.ToInt16(txtKostprijs.Text));
            lijstReizen.ReisToevoegen(objReis);
            txtLand.Text = "";
            txtReizigers.Text = "";
            txtKostprijs.Text = "";
            txtDagen.Text = "";
        }

        private void BtnTotaal_Click(object sender, RoutedEventArgs e)
        {
            txtTotaal.Text = Convert.ToString(lijstReizen.TotaalBerekenen(objReis));
        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {
            objReis = lijstReizen.Informatie(Convert.ToInt16(txtNr.Text));
            if (objReis != null)
            {
                lblInfo.Content = objReis.OmschrijvingReis();
            }
            else
            {
                lblInfo.Content = "Ongeldig reisnummer";
            }
        }
    }
}
