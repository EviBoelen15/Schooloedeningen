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

namespace CS_Oefening_045
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] cijferCode = { 2, 3, 8, 8, 9, 0 };
        private char[] ingaveCode = { '*','*','*','*','*','*'};
        private const int aantalPogingen = 3;
        private int aantalResterendePogingen = aantalPogingen;
        private int index = 0;

        public MainWindow()
        {
            InitializeComponent();
            TxtCode.Text = new string(ingaveCode); // char array omzetten naar een string
        }

        private void Herstart()
        {
            aantalResterendePogingen = aantalPogingen;
            index = 0;
            /*
            for (int i = 0; i < ingaveCode.Length; i++)
            {
                ingaveCode[i] = '*';
            }
            */
            Array.Fill(ingaveCode, '*');
            TxtCode.Text = new string(ingaveCode); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Lees het cijfer uit overeenkomstige button
            string cijferStr = ((Button)sender).Content.ToString();
            int gegevenCijfer = int.Parse(cijferStr);

            // Toon resultaat

            ingaveCode[index] = cijferStr[0]; // eerste char is genoeg
            TxtCode.Text = new string(ingaveCode); // char omzetten naar string

            if (gegevenCijfer != cijferCode[index])
            {
                // Gegeven cijfer is fout
                aantalResterendePogingen--;
                if (aantalResterendePogingen != 0)
                {
                    MessageBox.Show($"Foute ingave, nog {aantalResterendePogingen} resterende pogingen");
                }
                else
                {
                    MessageBox.Show($"U heeft {aantalPogingen} fouten gemaakt, opnieuw beginnen");
                    Herstart();
                }
            }
            else if (index == cijferCode.Length - 1)
            {
                // Cijfer is juist en laatste cijfer is bereikt, dus herstarten
                MessageBox.Show("Proficiat, u hebt de kluis geopend");
                Herstart();
            }
            else
            {
                // Cijfer is juist, op naar volgende cijfer
                index++;
            }
        }
    }
}
