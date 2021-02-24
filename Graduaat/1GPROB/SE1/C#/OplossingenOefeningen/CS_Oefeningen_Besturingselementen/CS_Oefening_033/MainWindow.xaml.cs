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

namespace CS_Oefening_033
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

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            float basisbedrag = 0.0f;
            int opleiding = CboOpleiding.SelectedIndex;
            switch (opleiding)
            {
                case -1: // Niks gekozen...
                    MessageBox.Show("Selecteer een opleiding!", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                case 2: // "Internet of Things"
                case 4: // "Drone opleiding"
                    basisbedrag = 520.80f;
                    break;
                case 3: // "Digitale vormgever"
                    basisbedrag = 750.80f;
                    break;
                default: // De rest (programmeren of netwerkbeheer)
                    basisbedrag = 920.80f;
                    break;
            }

            float betaalFactor = 1.0f; // standaard bachelor
            if (RadSec.IsChecked == true)
            {
                betaalFactor = 0.7f; // 30% korting, dus 70% betalen
            }
            else if (RadGraduaat.IsChecked == true)
            {
                betaalFactor = 0.8f; // 20% korting, dus 80% betalen
            }
            else if (RadMaster.IsChecked == true)
            {
                betaalFactor = 1.1f; // 10% extra betalen (toeslag)
            }

            // Wie werkzoekend is krijgt nog eens 50% korting op het totale bedrag
            bool isWerkzoekend = (ChkWerkzoekend.IsChecked == true);
            if (isWerkzoekend)
                betaalFactor /= 2;

            float inschrijvingsgeld = basisbedrag * betaalFactor;

            TxtResultaat.Text = 
                $"INSCHRIJVINGSBEDRAG VOOR: {TxtNaam.Text}\r\n\r\nBasisbedrag:{basisbedrag:c}\r\nTe betalen: {inschrijvingsgeld:c}";
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtNaam.Clear();
            TxtResultaat.Clear();
            CboOpleiding.Text = string.Empty;

            // Selectievak uitschakelen
            ChkWerkzoekend.IsChecked = false;
            // Keuzerondjes inschakelen
            RadBachelor.IsChecked = true;
            // ComboBox op eerste keuze zetten
            CboOpleiding.SelectedIndex = 0;

            TxtNaam.Focus();
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        // Hebben we onderstaande eventprocedures wel nodig?
        // Je kan deze eens uittesten als je wil.

        private void CboOpleiding_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ChkWerkzoekend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadSec_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadHoger_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadBachelor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadMaster_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
