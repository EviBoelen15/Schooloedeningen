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

namespace VBSportclub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declaratie arrays
        private List<string> namen = new List<string>() { "Sander", "Quirino", "Thomas",
            "Cédric", "Jason", "Domenico", "Rickert", "Klaas", "Tom", "Stephan", "Alexander",
            "Yannick", "Robin", "Dave", "Lynn", "Arno", "Niels", "Maxiem", "Matthijs", "Kobe",
            "Michaël", "Bram", "Achraf", "Raf", "Sven", "Gerben", "Kevin", "Cem", "Steff", "Steven",
            "Rani", "Djordy", "Nick", "Mikail", "Konstantin", "Asad", "Viktor", "Antonio", "Senne",
            "Benjamin", "Stef", "Abdul", "Christiaan", "Abdurrahman", "Jurgen", "Kevin", "Silvio",
            "Nathan", "Stijn", "Bart", "Frank", "Steven", "Matty", "Arend", "Simon", "Ziggy",
            "Pascal", "Michaël", "Danny", "Robby", "Johan", "Vincent", "Wim", "Tuba", "Kristof",
            "Kenneth" };

        private string[,] lidgeldPerCat = { { "Preminiem", "150" }, 
                                            { "Miniem", "150" }, 
                                            {"Junior", "170" }, 
                                            { "Kadet", "170" },
                                            { "Senior", "200" } };
        //Array voor de prognose
        private TextBox[] prognoseVakken = new TextBox[6];

        //declaratie constante waarde
        const decimal EXTRA_COMPETITIELID = 50.00m;
        const decimal EXTRA_PROCENT_KORTING_PERLID = 0.05m;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //namen van de array inladen in de combobox
            for (int i = 0; i < namen.Count; i++)
            {
                cbNamen.Items.Add(namen[i]);
            }
        }

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int rangFamilie = 0;
            double tijd = 0.00;
            tijd = Convert.ToDouble(txtTijd.Text);

            string naam = "";
            try 
            {
                rangFamilie = Convert.ToInt32(txtRang.Text);
                naam = cbNamen.SelectedValue.ToString();
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Zorg dat alle velden ingevuld zijn \n {ex}");
            }

            Berekenen(rangFamilie, naam);
            BerekenPrognose(tijd);
        }

        private void Berekenen(int rangFamilie, string naam)
        {
            decimal decTotaal = 0.00m;
            decimal startgeld = BerekenStartgeld();
            //decimal startgeld = BerekenStartgeld(categorie);
            decimal korting = BerekenKorting(rangFamilie);

            decTotaal = (cbCompetitie.IsChecked == true) ? startgeld + 50 * korting : startgeld * korting;

            VulUitvoer(naam, startgeld, decTotaal);
        }

        private void VulUitvoer(string naam, decimal startgeld, decimal totaalBetalen)
        {
            txtUitvoer.Text = $"Inschrijvingsbedrag voor {naam} \n\n\n" +
                              $"Basisbedrag voor {naam}:  {startgeld} \n" +
                              $"Te betalen: {Math.Round(totaalBetalen, 2)}";
        } 

        private decimal BerekenKorting(int rangFamilie)
        {
            decimal korting = 0.00m;
            if (rangFamilie > 1)
            {
                for (int i = 1; i < rangFamilie; i++)
                {
                    korting += EXTRA_PROCENT_KORTING_PERLID;
                }
            }
            return korting;
        }

        private decimal BerekenStartgeld()
        {
            decimal startgeld = 0.00m;
            int i = 0;
            foreach (RadioButton item in spCategorie.Children)
            {
                if (item.IsChecked == true)
                {
                    startgeld = int.Parse(lidgeldPerCat[i, 1]);
                }
                i++;
            }
            return startgeld;
        }

        private void BerekenPrognose(double tijd)
        {
            double width = 316.00;
            Label lbl;

            VulTBArray(prognoseVakken);

            if (cbNieuwLid.IsChecked == true)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (i == 0)
                    {
                        lbl = new Label();
                        lbl.Content = $"Nu";
                    } else
                    {
                        lbl = new Label();
                        lbl.Content = $"Na {i} jaar: ";
                    }

                    prognoseVakken[i].Width = width;
                    prognoseVakken[i].Text = Math.Round(tijd, 2).ToString();
                    prognoseVakken[i].IsEnabled = false;
                    prognoseVakken[i].Background = Brushes.GreenYellow;
                    prognoseVakken[i].FlowDirection = FlowDirection.RightToLeft;
                    prognoseVakken[i].HorizontalAlignment = HorizontalAlignment.Left;

                    SPPrognose.Children.Add(lbl);
                    SPPrognose.Children.Add(prognoseVakken[i]);

                    width *= (double)(1.00m - EXTRA_PROCENT_KORTING_PERLID);
                    tijd *= (double)(1.00m - EXTRA_PROCENT_KORTING_PERLID);
                }
            }
        }

        private void VulTBArray(TextBox[] textboxen)
        {
            for(int i = 0; i < textboxen.Length; i++)
            {
                textboxen[i] = new TextBox();
            }
        }

        private void btnWissen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

