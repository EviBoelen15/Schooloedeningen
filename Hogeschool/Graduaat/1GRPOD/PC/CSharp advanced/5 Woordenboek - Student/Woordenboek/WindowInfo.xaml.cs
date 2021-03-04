﻿using System;
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
using System.Reflection;

namespace Woordenboek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WindowInfo : Window
    {
        public WindowInfo()
        {
            InitializeComponent();
        }

        // using System.Reflection!!!
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlockProductname.Text = Assembly.GetEntryAssembly()
                             .GetCustomAttributes(typeof(AssemblyProductAttribute))
                             .OfType<AssemblyProductAttribute>()
                            .FirstOrDefault().Product;


            var versie = Assembly.GetExecutingAssembly().GetName().Version;
            TextBlockVersion.Text = $"Version {versie.Major}.{versie.Minor}.{versie.Build}.{versie.Revision}";

            TextBlockCopyright.Text = Assembly.GetEntryAssembly()
                              .GetCustomAttributes(typeof(AssemblyCopyrightAttribute))
                              .OfType<AssemblyCopyrightAttribute>()
                             .FirstOrDefault().Copyright;



            TextBlockCompanyname.Text = Assembly.GetEntryAssembly()
                              .GetCustomAttributes(typeof(AssemblyCompanyAttribute))
                              .OfType<AssemblyCompanyAttribute>()
                             .FirstOrDefault().Company;




            TextBlockDescription.Text = Assembly.GetEntryAssembly()
                              .GetCustomAttributes(typeof(AssemblyDescriptionAttribute))
                              .OfType<AssemblyDescriptionAttribute>()
                             .FirstOrDefault().Description;
        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
