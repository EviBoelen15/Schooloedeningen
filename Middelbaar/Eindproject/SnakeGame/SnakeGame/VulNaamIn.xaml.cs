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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace SnakeGame
{
    /// <summary>
    /// Interaction logic for VulNaamIn.xaml
    /// </summary>
    public partial class VulNaamIn : Window
    {
        //de database wordt aangeroepen
        SqlConnection snnScore = new SqlConnection(Properties.Settings.Default.SnakeConnection);
        SqlCommand cmd = new SqlCommand();

        //het mainwindow wordt opgeroepen om de score door te geven aan de DB
        MainWindow MainWindow = (MainWindow)Application.Current.MainWindow;

        public VulNaamIn()
        {
            InitializeComponent();
        }

        //de naam en de score van de speler worden opgeslagen
        private void BtnOpslaan_Click(object sender, RoutedEventArgs e)
        {           
            snnScore.Open();

            cmd.Connection = snnScore;
            cmd.CommandText = "INSERT INTO tblScore(Naam, Score) VALUES('" + txtNaam.Text + "','" + MainWindow.txtbScore.Text + "')";
            cmd.ExecuteNonQuery();

            snnScore.Close();

            MessageBox.Show("Uw score is opgeslagen!");
        }

        //als er op de highscores knop gedrukt wordt opent het highscores window
        //dit window sluit 
        private void BtnHighscores_Click(object sender, RoutedEventArgs e)
        {
            Highscores highscores = new Highscores();
            this.Close();
            highscores.Show();
        }

        //de game wordt gesloten
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
