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

namespace REIZEN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        JaarboekReizen objJaarboekreizen = new JaarboekReizen(DateTime.Now.Year);
        Reis objReis;
        public MainWindow()
        {
            InitializeComponent();           
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            int intDagen = Convert.ToInt16(txtDagen.Text);
            string strLand = txtLand.Text;
            decimal decKostprijs = Convert.ToDecimal(txtKostprijs.Text);

            DateTime dt = new DateTime();
            dt = DateTime.Now;

            objReis = new Reis(strLand, intDagen, decKostprijs);

            lbReizen.Items.Add("Land: " + strLand + " Aantal dagen: " + intDagen + " Kostprijs: " + decKostprijs);

            objJaarboekreizen.AddReis(objReis);
        }

        private void btnBerekenprijs_Click(object sender, RoutedEventArgs e)
        {
            decimal Totaalprijs;
            Totaalprijs = objJaarboekreizen.TotaalPrijs();
            txtTotaal.Text = Convert.ToString(Totaalprijs);
        }

        private void btnInfoReisnr_Click(object sender, RoutedEventArgs e)
        {
            int ReisNr;

            ReisNr = Convert.ToInt16(txtReisnummer.Text);

            //lblOmschreiving.Content = objJaarboekreizen.geefReis(ReisNr).Omschrijving();
            //reis ophalen
            objReis = objJaarboekreizen.geefReis(ReisNr);

            lblOmschreiving.Content = objReis.Omschrijving();

        }
    }
}
