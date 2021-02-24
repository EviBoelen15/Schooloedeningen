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
    /// Interaction logic for Klantgegevens.xaml
    /// </summary>
    public partial class Klantgegevens : Window
    {
        public Klantgegevens()
        {
            InitializeComponent();
            SqlConnection scnnAppolo = new SqlConnection(Properties.Settings.Default.cnnAppolo);

            SqlCommand scmdAantalLev = new SqlCommand();
            scmdAantalLev.Connection = scnnAppolo;
            scmdAantalLev.CommandText = "SELECT Type FROM tblKlanten GROUP BY Type";
            SqlDataReader sqlRead;

            scnnAppolo.Open();
            sqlRead = scmdAantalLev.ExecuteReader();
            while (sqlRead.Read())
            {
                string strLijn;
                strLijn = sqlRead["Type"].ToString();
                cboType.Items.Add(strLijn);
            }
            scnnAppolo.Close();
        }

        private void CboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection scnnAppolo = new SqlConnection(Properties.Settings.Default.cnnAppolo);

            SqlCommand scmdAantalLev = new SqlCommand();
            scmdAantalLev.Connection = scnnAppolo;

            SqlParameter parLeveranvier = new SqlParameter();
            parLeveranvier.ParameterName = "@type";
            parLeveranvier.Value = cboType.SelectedItem;

            scmdAantalLev.CommandText = "SELECT Klantnr, Naam FROM tblKlanten WHERE Type = @type";

            scmdAantalLev.Parameters.Add(parLeveranvier);

            SqlDataReader read;

            scnnAppolo.Open();
            read = scmdAantalLev.ExecuteReader();
            while(read.Read())
            {
                string strLijn;
                strLijn = read["Klantnr"].ToString() + "     " + read["Naam"].ToString();
                cbKlantgegevens.Items.Add(strLijn);
            }
            scnnAppolo.Close();
        }
    }
}
