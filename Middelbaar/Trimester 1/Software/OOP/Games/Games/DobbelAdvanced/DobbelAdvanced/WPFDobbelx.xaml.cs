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
using System.Windows.Shapes;
using KlasseGames;

namespace DobbelAdvanced
{
    /// <summary>
    /// Interaction logic for WPFDobbelx.xaml
    /// </summary>
    public partial class WPFDobbelx : Window
    {
        Dobbelsteen objdobbelsteen; // zonder = word de beginwaarde nog niet gegeven maar er word gewoon gedeclareerd.
        public WPFDobbelx(int pintzijde)
        {
            InitializeComponent();
            objdobbelsteen = new Dobbelsteen(pintzijde); // hier krijgt de objdobbelsteen zijn waarde pas die word doorgegeven van het andere programma 
        }

        private void btndruk_Click(object sender, RoutedEventArgs e)
        {
            lblnummer.Content = objdobbelsteen.Gooien(); //de methode uit de apparte klasse wordt opgeroeppe
        }
    }
}
