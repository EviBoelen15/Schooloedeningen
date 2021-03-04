using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Woordenboek
{
    /// <summary>
    /// Interaction logic for WindowWoordenboek.xaml
    /// </summary>
    public partial class WindowWoordenboek : Window
    {
        public WindowWoordenboek()
        {
            InitializeComponent();
        }
     

       

       private void BtnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
                string[] velden;
                string bestand = @"..\..\Bestanden\ICTWoordenboek.txt";
                if (File.Exists(bestand))
                {
                    using (StreamReader sr = File.OpenText(bestand))
                    {
                        while (!sr.EndOfStream)
                        {
                            velden = sr.ReadLine().Split('|');

                        Lexicon.ICTEngels.Add(velden[0]);
                        Lexicon.ICTNed.Add(velden[1]);

                        LbxTermen.Items.Add($"{velden[0]} - {velden[1]}");
                        }
                    }
                }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }

        private void MnuAfsluiten_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void MnuZoekvenster_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void MenuInfo_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
