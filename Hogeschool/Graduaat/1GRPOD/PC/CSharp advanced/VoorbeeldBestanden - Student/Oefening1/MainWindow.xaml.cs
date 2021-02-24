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

namespace Oefening1
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
        private void BtnInlezen_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = InlezenBestand("Email.txt");

            if(sb.Length != 0)
            {
                TxtResultaat.Text = sb.ToString();
            }
        }

        private StringBuilder InlezenBestand(string path)
        {
            StringBuilder sb = new StringBuilder();
            string[] velden;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int i = 1;
                    while (!sr.EndOfStream)
                    {
                        velden = sr.ReadLine().Split(',');
                        if(velden.Length!= 2)
                        {
                            MessageBox.Show($"Onvolledige gegevens bij {i}");
                        } else
                        {
                            sb.Append($"{velden[0].Replace("\\", ""), -10} : " + $"{ velden[1].Replace("\\", "")}").AppendLine();
                        }
                        i++;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Geef nieuwe naam \n\n" + ex.Message, "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Probleem met inlezen van het bestand.", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return sb;
        
        }

        private void BtnInlezenDialog_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Alle bestanden (*.*) | *.* | Tekstbestanden (*.txt) | *.txt",
                FilterIndex = 2,
                FileName = "Email.txt",
                InitialDirectory = Environment.CurrentDirectory  // ALS DE TXTFILE ONDER BIN STAAT
            }; 

            if (ofd.ShowDialog() == true)
            {
                StringBuilder sb = InlezenBestand(ofd.FileName);

                //lege stringbuilder als het bestand niet gevonden is
                if(sb.Length != 0)
                {
                    TxtResultaat.Text = sb.ToString();
                }
            }
        }

        private void BtnInlezenDictionary_Click(object sender, RoutedEventArgs e)
        {
            string[] velden;

            try
            {
                using (StreamReader sr = new StreamReader("Email.txt"))
                {
                    int i = 1;
                    while (!sr.EndOfStream)
                    {
                        velden = sr.ReadLine().Split(',');
                        if (velden.Length != 2)
                        {
                            MessageBox.Show($"Onvolledige gegevens bij {i}");
                        }
                        else
                        {
                            dicGeg.Add(velden[0].Replace("\\", ""), velden[1].Replace("\\", ""));
                        }
                        i++;
                    }
                }
                foreach(var item in dicGeg)
                {
                    TxtResultaat.Text += $"{item.Key,-20}: {item.Value}\n";
                }
                BtnWegschrijven.IsEnabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Probleem met inlezen van het bestand.", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnWegschrijven_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using(StreamWriter sw = File.CreateText("Adressen.txt"))
                {
                    foreach(var item in dicGeg)
                    {
                        sw.WriteLine(item.Value);
                    }
                }
                MessageBox.Show($"Emailadressen weggeschreven in ..Adressen.txt. ", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Kan bestand niet wegschrijven", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
