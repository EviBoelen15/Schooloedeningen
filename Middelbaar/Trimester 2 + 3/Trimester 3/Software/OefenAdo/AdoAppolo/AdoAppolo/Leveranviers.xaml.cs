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

namespace AdoAppolo
{
    /// <summary>
    /// Interaction logic for Leveranviers.xaml
    /// </summary>
    public partial class Leveranviers : Window
    {
        public Leveranviers()
        {
            InitializeComponent();
            SqlConnection scnnAppolo = new SqlConnection(Properties.Settings.Default.cnnAppolo);

            SqlCommand scmdAantalLev = new SqlCommand();
            scmdAantalLev.Connection = scnnAppolo;
            scmdAantalLev.CommandText = "SELECT firmanaam FROM tblLeveranciers";
            SqlDataReader sqlRead;

            scnnAppolo.Open();
            sqlRead = scmdAantalLev.ExecuteReader();
            while(sqlRead.Read())
            {
                string strLijn;
                strLijn = sqlRead["firmanaam"].ToString();
                cbLeveranviers.Items.Add(strLijn);
            }
            scnnAppolo.Close();
        }

        private void CbLeveranviers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection scnnAppolo = new SqlConnection(Properties.Settings.Default.cnnAppolo);

            SqlCommand scmdAantalLev = new SqlCommand();
            scmdAantalLev.Connection = scnnAppolo;

            SqlParameter parLeveranvier = new SqlParameter();
            parLeveranvier.ParameterName = "@leverancier";
            parLeveranvier.Value = cbLeveranviers.SelectedValue;

            scmdAantalLev.CommandText = "SELECT count(InBestelling) FROM tblWijnen INNER JOIN tblLeveranciers on tblWijnen.Leveranciersnummer = tblLeveranciers.Leveranciernummer WHERE tblLeveranciers.firmanaam = @leverancier";

            scmdAantalLev.Parameters.Add(parLeveranvier);

            scnnAppolo.Open();

            lblAantal.Content = scmdAantalLev.ExecuteScalar();

            scnnAppolo.Close();
        }
    }
}
