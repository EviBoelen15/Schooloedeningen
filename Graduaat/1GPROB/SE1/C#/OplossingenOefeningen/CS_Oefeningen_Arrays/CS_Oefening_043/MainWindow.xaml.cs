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

namespace CS_Oefening_043
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float[] eenheden = new float[15] {
                500.0f,
                200.0f,
                100.0f,
                50.0f,
                20.0f,
                10.0f,
                5.0f,
                2.0f,
                1.0f,
                0.5f,
                0.2f,
                0.1f,
                0.05f,
                0.02f,
                0.01f };

        private float[] aantallen = new float[15];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            float resterendeBedrag;
            bool isGelukt = float.TryParse(TxtBedrag.Text, out resterendeBedrag);
            if (!isGelukt)
            {
                TxtResultaat.Text = "Geef een correct bedrag in!";
                return;
            }
            
            // Alle briefjes één voor één proberen. Start met grootste briefje
            for (int i = 0; i < eenheden.Length; i++)
            {
                do
                {
                    resterendeBedrag -= eenheden[i];
                    aantallen[i]++;
                } while (resterendeBedrag > 0);

                if (resterendeBedrag < 0)
                {
                    resterendeBedrag += eenheden[i];
                    aantallen[i]--;
                }
            }

            // Bouw resultaat op
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < aantallen.Length; i++)
            {
                if (aantallen[i] > 0)
                    builder.AppendLine($"{aantallen[i], 3} stuk(s) van {eenheden[i]:c}");
            }
            // Toon resultaat
            TxtResultaat.Text = builder.ToString();
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtBedrag.Clear();
            TxtResultaat.Clear();
            TxtBedrag.Focus();
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
