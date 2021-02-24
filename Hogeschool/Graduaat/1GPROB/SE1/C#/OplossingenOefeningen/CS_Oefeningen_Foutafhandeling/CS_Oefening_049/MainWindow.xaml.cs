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

namespace CS_Oefening_049
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAfbeelding_Click(object sender, RoutedEventArgs e)
        {
            int getal = rnd.Next(10); // willekeurig getal van 0 t.e.m. 9
            string bestandsnaam = @$"..\..\..\images\zee{getal}.jpg";
            imgAfbeelding.Source = new BitmapImage(
                new Uri(AppDomain.CurrentDomain.BaseDirectory + bestandsnaam, UriKind.RelativeOrAbsolute));
        }

        private void btnControle_Click(object sender, RoutedEventArgs e)
        {
            int getal = rnd.Next(10); // willekeurig getal van 0 t.e.m. 9
            string bestandsnaam = @$"..\..\..\images\zee{getal}.jpg";
            try
            {
                imgAfbeelding.Source = new BitmapImage(
                    new Uri(AppDomain.CurrentDomain.BaseDirectory + bestandsnaam, UriKind.RelativeOrAbsolute));
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("De afbeelding bestaat niet.", "Probeer opnieuw");
            }
        }
    }
}
