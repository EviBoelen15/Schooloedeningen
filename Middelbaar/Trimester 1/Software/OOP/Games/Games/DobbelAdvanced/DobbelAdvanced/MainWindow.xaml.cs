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

namespace DobbelAdvanced
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() // <-- Constructor
        {
            InitializeComponent(); //<-- als iets direct bij start uitgevoerd word word dit hier geprogrammeerd
        }

        private void btndobbelgwn_Click(object sender, RoutedEventArgs e)
        {
            WPFDobbelx objdobbelx = new WPFDobbelx(6); //de waarde word doorgegeven aan het andere formulier (pintzijde)
            objdobbelx.Show(); //code die je nodig hebt om het formulier te openen
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            WPFDobbelx objdobbelx = new WPFDobbelx(12);
            objdobbelx.Show();
        }

        private void btnx_Click(object sender, RoutedEventArgs e)
        {
            int intzijde;
            ListBoxItem objlistboxitem = new ListBoxItem();
            objlistboxitem = (ListBoxItem)lbgetallen.SelectedItem;
            intzijde = Convert.ToInt16(objlistboxitem.Content);
            WPFDobbelx objdobbelx = new WPFDobbelx(intzijde);
            objdobbelx.Show();
        }
    }
}
