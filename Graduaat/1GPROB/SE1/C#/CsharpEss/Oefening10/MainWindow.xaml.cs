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

namespace Oefening10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd;
        int randomGetal;
        int aantalRaden;

        public MainWindow()
        {
            InitializeComponent();
            randomGetal = NieuwSpel(ref rnd);
        }

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            int getal = Convert.ToInt32(txtGetal.Text);
            CheckGetal(getal, randomGetal);
        }

        private void CheckGetal(int getal, int randomGetal)
        {
            if (getal != randomGetal)
            {
                aantalRaden++;
                if (getal < randomGetal)
                {
                    txtHogerLager.Text = "Raad Hoger!!";
                } else
                {
                    txtHogerLager.Text = "Raad Lager!!";
                }
            }
            else
            {
                txtHogerLager.Text = "";
                txtGewonnen.Text = $"Aantal keren geraden: {aantalRaden}";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime now = DateTime.Now;
            lblTijd.Content = now.ToString();
        }
        private void btnNieuw_Click(object sender, RoutedEventArgs e)
        {
            NieuwSpel(ref rnd);
        }        
        private int NieuwSpel(ref Random rnd)
        {
            rnd = new Random();
            int randomgetal = rnd.Next(0, 101);
            return randomgetal;
        }
    }
}
