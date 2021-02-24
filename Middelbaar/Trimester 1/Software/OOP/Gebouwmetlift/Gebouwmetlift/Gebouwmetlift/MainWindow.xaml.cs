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

namespace Gebouwmetlift
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Gebouw objgebouw;
        Lift objLift;
        int intVerdiep;
        Rectangle objRechthoekLift = new Rectangle();

        public MainWindow()
        {
            InitializeComponent();
            objgebouw = new Gebouw(30, 10, 20);
            objLift = new Lift(objgebouw);
            
            
            //Teken verdiepingen
            for (intVerdiep = 0; intVerdiep <= objgebouw.Aantalverdiep; intVerdiep ++)
            {
                Rectangle objverd = new Rectangle();
                objverd.Width = objgebouw.Breedteverdiep;
                objverd.Height = objgebouw.Hoogteverdiep;
                objverd.Margin = new Thickness(10, 500 - ((intVerdiep+1) * objgebouw.Hoogteverdiep), 0, 0);
                objverd.Stroke = new SolidColorBrush(Colors.White);
                cnvGebouw.Children.Add(objverd);
            }

            //Teken lift op verdieping 0
            objRechthoekLift.Width = objLift.Breedte;
            objRechthoekLift.Height = objLift.Hoogte;
            objRechthoekLift.Margin = new Thickness(10, cnvGebouw.Height - (objLift.HuidigVerdiep + 1) * objLift.Hoogte, 0, 0);
            objRechthoekLift.Fill = new SolidColorBrush(Colors.Blue);
            cnvGebouw.Children.Add(objRechthoekLift);
        }

        private void btnLiftGo_Click(object sender, RoutedEventArgs e)
        {
            //Error Message            
            int intBestemming;
            intBestemming = Convert.ToInt16(txtBestemming.Text);
            if (intBestemming < 0 || intBestemming > objgebouw.Aantalverdiep)
            {
                MessageBox.Show("Geef een juiste verdieping in");
            }

            //Verander Verdiep
            else
            {
                //Logical
                objLift.Bestemming = intBestemming;
                objLift.GaNaarBestemming();

                //Graphic
                objRechthoekLift.Width = objLift.Breedte;
                objRechthoekLift.Height = objLift.Hoogte;
                objRechthoekLift.Margin = new Thickness(10, cnvGebouw.Height - (objLift.HuidigVerdiep + 1) * objLift.Hoogte, 0, 0);
                objRechthoekLift.Fill = new SolidColorBrush(Colors.Blue);
            }
        }
    }
}
