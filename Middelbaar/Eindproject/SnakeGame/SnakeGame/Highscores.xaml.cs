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
    /// Interaction logic for Highscores.xaml
    /// </summary>
    public partial class Highscores : Window
    {
        //de database wordt aangeroepen
        SqlConnection scnnHighscores = new SqlConnection(Properties.Settings.Default.SnakeConnection);
        SqlCommand scmdtop10 = new SqlCommand();

        //datareader overloopt alle gegevens in de database
        SqlDataReader sdrHighscores;

        //De data van de vorige spelers worden in het highscore venster geladen
        public Highscores()
        {
            InitializeComponent();

            scmdtop10.Connection = scnnHighscores;
            scnnHighscores.Open();

            scmdtop10.CommandText = "SELECT TOP 10 * FROM tblScore ORDER BY Score DESC";
            sdrHighscores = scmdtop10.ExecuteReader();

            //elk gelezen gegeven (in de top 10) wordt toegevoegd aan de list
            while (sdrHighscores.Read())
            {
                string strlijn;
                strlijn = "Speler " + sdrHighscores["Naam"].ToString() + ": \t\t" + sdrHighscores["Score"].ToString() + " punten";
                lstHighscores.Items.Add(strlijn);
            }

            //connectie sluiten
            scnnHighscores.Close();
        }

        //de game wordt afgesloten
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //de game start opnieuw
        private void BtnOpnieuw_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.score = 0;
            main.txtbScore.Text = "0";
            this.Hide();
            main.Show();
        }
    }
}
