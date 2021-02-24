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

namespace Oefening30
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

        private void btnDec_Click(object sender, RoutedEventArgs e)
        {
            string dec = txtDec.Text.ToString();
            DecNaarBin(dec);
        }

        private void btnAlles_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DecNaarBin(string decimaal)
        {
            int rest;
            string binair = "";
            int dec = Convert.ToInt32(decimaal);
            for (int i = 7; i >= 0; i--)
            {
                if ((dec - Convert.ToInt32(Math.Pow(2, i)) > 0))
                {
                    rest = dec - Convert.ToInt32(Math.Pow(2, i));
                    binair += "1";
                } else
                {
                    binair += "0";
                }
                dec = dec - Convert.ToInt32(Math.Pow(2, i)); 
            }
            txtBin.Text = binair;
        }
        private void BinNaarDec()
        {

        }
    }
}
