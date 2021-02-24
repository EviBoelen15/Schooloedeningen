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
using System.Windows.Threading;

namespace SnakeGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //declaratie 

        DispatcherTimer time;

        //lijst items van de slang en het voedsel
        List<Snake> snakebody;
        List<Food> food;

        Random rd = new Random();

        double x = 100;
        double y = 100;

        public int score = 0;
        int direction = 0;
        int count = 0;

        bool EindschermKanOpenen = false;

        //waardes van de bewegingen
        int right = 2;
        int left = 4;
        int up = 6;
        int down = 8;


        //de beginwaardes worden gegeven
        public MainWindow()
        {
            InitializeComponent();
            time = new DispatcherTimer();
            snakebody = new List<Snake>();
            food = new List<Food>();
            snakebody.Add(new Snake(x, y));
            food.Add(new Food(rd.Next(0, 37) * 10, rd.Next(0, 35) * 10));

            //De snelheid van de slang
            time.Interval = new TimeSpan(0, 0, 0, 0, 55);
            time.Tick += time_Tick;

        }

        //Voegt "voedsel" toe in het venster
        void VoegVoedselToe()
        {
            food[0].PlaatsVoedsel();
            mycanvas.Children.Insert(0, food[0].ellipse);
        }

        //zet het 1ste bolletje van de slang in het venster
        void VoegSlangToe()
        {
            foreach (Snake snake in snakebody)
            {
                snake.PlaatsSlang();
                mycanvas.Children.Add(snake.ellipse);
            }
        }

        //deze acties worden uitgevoerd bij elke tick van de timer
        void time_Tick(object sender, EventArgs e)
        {
            //als de speler niets indrukt gaat de slang niet van richting veranderen
            if (direction != 0)
            {
                for (int i = snakebody.Count - 1; i > 0; i--)
                {
                    snakebody[i] = snakebody[i - 1];
                }
            }
            //(int)Richting roept een waarde in het EnumSlangRichting script aan
            if (direction == up)
                y -= 10;
            if (direction == down)
                y += 10;
            if (direction == left)
                x -= 10;
            if (direction == right)
                x += 10;

            //slang eet voedsel, er komt nieuw voedsel op het spelvenster en het oude voedsel gaat weg
            //score wordt opgeteld en in het txt vakje van de score gezet
            if (snakebody[0].x == food[0].x && snakebody[0].y == food[0].y)
            {
                snakebody.Add(new Snake(food[0].x, food[0].y));
                food[0] = new Food(rd.Next(0, 33) * 10, rd.Next(0, 30) * 10);
                mycanvas.Children.RemoveAt(0);
                VoegVoedselToe();
                score++;
                txtbScore.Text = score.ToString();
            }

            snakebody[0] = new Snake(x, y);

            //raakt de slang de rand?
            if (!EindschermKanOpenen && (snakebody[0].x > 370 || snakebody[0].y > 350 || snakebody[0].x < 0 || snakebody[0].y < 0))
            {
                EindschermKanOpenen = true;
                VulNaamIn vulnaamin = new VulNaamIn();
                this.Hide();
                vulnaamin.Show();
            }

            //raakt de slang zijn eigen lichaam?
            for (int i = 1; i < snakebody.Count; i++)
            {
                if (!EindschermKanOpenen && (snakebody[0].x == snakebody[i].x && snakebody[0].y == snakebody[i].y))
                {
                    EindschermKanOpenen = true;
                    VulNaamIn vulnaamin = new VulNaamIn();
                    this.Hide();
                    vulnaamin.Show();
                }
            }

            //toevoegen van een bolletje
            for (int i = 0; i < mycanvas.Children.Count; i++)
            {
                if (mycanvas.Children[i] is Ellipse)
                    count++;
            }

            mycanvas.Children.RemoveRange(1, count);
            count = 0;
            VoegSlangToe();
        }

        //detecteerd wanneer er een knop op het toetsenbord ingedrukt wordt
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //als de ingeduwde knop het pijltje naar boven is wordt er gekeken of de slang niet naar beneden gaat
            //indien deze niet naar beneden gaat zal de slang naar boven gaan
            //dit is zo omdat de slang geen contact mag maken met zijn lichaam, en anders door zichzelf heen zou gaan
            if (e.Key == Key.Up && direction != down)
                direction = up;

            if (e.Key == Key.Down && direction != up)
                direction = down;

            if (e.Key == Key.Left && direction != right)
                direction = left;

            if (e.Key == Key.Right && direction != left)
                direction = right;
        }

        //message box met informatie als de game begint
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Beweeg de slang doorheen het veld, en vang het voedsel" + "\n" +
                "Als je de randen, of het lichaam van de slang zelf raakt, heb je gefaald" + "\n" + "\n" +
                "Gebruik de pijltjestoetsen om je doorheen het veld te bewegen" + "\n" + "\n" +
                "Om te starten:" + "\n" + "Druk op start en gebruik één van de pijltjestoetsen ");
        }

        //als er op start gedrukt wordt verschijnt de slang en het voedsel en kan je beginnen
        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            VoegSlangToe();
            VoegVoedselToe();
            time.Start();
        }

        //opent het highscore menu
        private void BtnHighscores_Click(object sender, RoutedEventArgs e)
        {
            Highscores highscores = new Highscores();
            this.Close();
            highscores.Show();
        }

        //beeindigd de game
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
