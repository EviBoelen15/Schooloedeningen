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

namespace CS_Oefening_042
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rnd = new Random();
        private const int aantalLottoGetallen = 6;
        private StringBuilder builder = new StringBuilder();
        private int[] getallen = new int[aantalLottoGetallen];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            builder.Clear();

            for (int j = 0; j < getallen.Length; j++)
            {
                getallen[j] = rnd.Next(1, 46); // willekeurig getal van 1 t.e.m. 45
                for (int k = 0; k < j; k++)
                {
                    if (getallen[k] == getallen[j])
                    {
                        getallen[j] = rnd.Next(1, 46);
                    }
                }
                builder.AppendLine($"Getal {j + 1} : {getallen[j]}");
            }
            TxtResultaat.Text = builder.ToString();
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Text = string.Empty; // ""
            BtnStart.Focus();
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
