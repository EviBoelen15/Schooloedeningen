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
using System.IO;
using Microsoft.Win32;

namespace Oef3
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
        private Dictionary<string, string> dicGeg = new Dictionary<string, string>();
        private string bestandsnaam;

        private void btnInlezen_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Alle bestanden (*.*)|*.*|Tekstbestanden (*.txt) |*.txt",
                InitialDirectory = System.IO.Path.GetFullPath(@"D:\Graduaat\1GRPOD\C#Advanced\OefeningenCSharpLaptop\Oef3\bin\Debug"),
                Title = "Bestand openen",
                AddExtension = true,
                DefaultExt = "txt",
                FileName = "Punten.txt",
                Multiselect = true
            };

            string lijn, veld1, veld2, veld3, veld4;

            if (ofd.ShowDialog() == true)
            {
                bestandsnaam = ofd.FileName;
                using (StreamReader sr = new StreamReader(bestandsnaam))
                {
                    while (!sr.EndOfStream)
                    {
                        /*Scheidingsteken opgeven, geeft array terug gescheiden door opgegeven karakter.
                        velden = sr.ReadLine();
                        sb.Append(velden);
                        sb.AppendLine();*/
                        lijn = sr.ReadLine();
                        veld1 = lijn.Substring(0, 18).Trim();                     //0 = startplaats - 18 is aantal karakters
                        veld2 = lijn.Substring(19, 20).Trim();
                        veld3 = lijn.Substring(40, 1).Trim();
                        veld4 = lijn.Substring(48, 6).Trim();

                        sb.Append($"{veld1,-21 }{veld2,-21}{ veld3,-5}{ veld4,-9 }").AppendLine();

                        //veld 1 en 4 in de dictionary
                        dicGeg.Add(veld1, veld4);
                    }
                }
            }

            btnVerwerken.IsEnabled = true;
            txtResultaat.Text = sb.ToString();
        }

        private void btnVerwerken_Click(object sender, RoutedEventArgs e)
        {
            float resultaat;
            StringBuilder sb = new StringBuilder();

            //BestandsInformatie
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Alle bestanden (*.*)|*.*|Tekstbestanden (*.txt)|*.txt",
                FilterIndex = 2,
                Title = "Geef een bestandsnaam op",
                OverwritePrompt = true,
                AddExtension = true,
                DefaultExt = "txt",
                FileName = "Verwerkt.txt",
                InitialDirectory = System.IO.Path.GetFullPath(@"D:\Graduaat\1GRPOD\C#Advanced\OefeningenCSharpLaptop\Oef3\bin\Debug"),
            };

            sfd.ShowDialog();

            //File aanmaken
            using (StreamWriter sw = File.CreateText(sfd.FileName))
            {
                foreach (var item in dicGeg)
                {
                    sb.Append($"{item.Key,-24}".Replace("\"", ""));

                    resultaat = float.Parse(item.Value.Substring(0, 3))
                    / float.Parse(item.Value.Substring(3, 3));
                    //:p staat voor percent 
                    sb.Append($"{resultaat,-10:p}");

                    sb.Append((resultaat >= 0.8) ? "Geslaagd".PadRight(20)
                     : "Niet Geslaagd".PadRight(20)).AppendLine();
                }

                sw.WriteLine(sb);
            }
            MessageBox.Show("De resultaten zijn verwerkt. " +
            " Je kan de resultaten nalezen in het bestand " + sfd.FileName,
            "Resultaten", MessageBoxButton.OK, MessageBoxImage.Information);

            btnNalezen.IsEnabled = true;
        }

        private void btnNalezen_Click(object sender, RoutedEventArgs e)
        {
            string bestandsnaam;

            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Alle bestanden (*.*)|*.*|Tekstbestanden (*.txt) |*.txt",
                InitialDirectory = System.IO.Path.GetFullPath(@"D:\Graduaat\1GRPOD\C#Advanced\OefeningenCSharpLaptop\Oef3\bin\Debug"),
                Title = "Bestand openen",
                AddExtension = true,
                DefaultExt = "txt",
                FileName = "Verwerkt.txt",
                Multiselect = true
            };

            bestandsnaam = ofd.FileName;

            if (ofd.ShowDialog() == true)
            {
                using (StreamReader sr = new StreamReader(bestandsnaam))
                {
                    txtResultaat.Text = File.ReadAllText(ofd.FileName);
                }
            }
            else
            {
                MessageBox.Show("De resultaten zijn niet verwekt", "Resultaten", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnSluiten_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
