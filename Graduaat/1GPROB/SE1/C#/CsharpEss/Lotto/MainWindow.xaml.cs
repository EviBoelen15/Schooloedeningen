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

namespace Lotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] getallen;
        List<int> getallenList;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Start()
        {
            getallen = new int[6] { 0, 0, 0, 0, 0, 0 };
            getallenList = new List<int>();
            int getal;
            for(int i = 0; i < 6; i++)
            {
                getal = GetUniekGetal();
                getallen[i] = getal;
                getallenList.Add(getal);
            }
        }

        private int GetUniekGetal()
        {
            int getal = -1;
            int kleinste = 1;
            int grootste = 46;
            Random rnd = new Random();
            do
            {
                getal = rnd.Next(kleinste, grootste);
            } while (Array.IndexOf(getallen, getal) != -1);
            return getal;
        }

        
        private void Uitvoer()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("De Lotto getallen zijn: ");
            sb.AppendLine();
            for (int i = 0; i < 6; i++)
            {
                sb.AppendLine($"Getal {i + 1}: {getallen[i]}");
            }
            lblLotto.Content = sb.ToString();
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            Start();
            Uitvoer();
        }

        private void BtnList_Click(object sender, RoutedEventArgs e)
        {
            if(getallenList.Count == 6)
            {
                getallenList.Sort();
                getallen = getallenList.ToArray();
                Uitvoer();
            }
        }
    }
}
