using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Interactie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtNaam_TextChanged(object sender, EventArgs e)
    {

        string strUitvoer, strVoornaam, strAchternaam;

        //Om te vermijden dat er met enkel de voornaam of de achternaam gewerkt wordt, testen we of beide tekstvakken ingevuld zijn
        if (txtNaam.Text != string.Empty && txtVoornaam.Text != string.Empty)
        {
            strVoornaam = txtVoornaam.Text;
            strAchternaam = txtNaam.Text;
            strUitvoer = "Welkom " + strVoornaam + " " + strAchternaam + " in de sessie ASP.NET";

            pnlKalender.Visible = true;
            lblAanspreking.Text = strUitvoer;
        }
    }

    protected void txtVoornaam_TextChanged(object sender, EventArgs e)
    {
        string strUitvoer, strVoornaam, strAchternaam;

        //Om te vermijden dat er met enkel de voornaam of de achternaam gewerkt wordt, testen we of beide tekstvakken ingevuld zijn
        if (txtNaam.Text != string.Empty && txtVoornaam.Text != string.Empty)
        {
            strVoornaam = txtVoornaam.Text;
            strAchternaam = txtNaam.Text;
            strUitvoer = "Welkom " + strVoornaam + " " + strAchternaam + " in de sessie ASP.NET";

            pnlKalender.Visible = true;
            lblAanspreking.Text = strUitvoer;
        }
    }
    protected void CalKalender_SelectionChanged(object sender, EventArgs e)
    {
        int intAantalDagen;

        DateTime dteSelectedDate = CalKalender.SelectedDate;
        string strUitvoer;

        if (dteSelectedDate < DateTime.Today)
        {
            strUitvoer = "Uw datum ligt in het verleden, gelieve een andere datum te kiezen.";
        }
        else
        {
            intAantalDagen = dteSelectedDate.Subtract(DateTime.Today).Days;
            strUitvoer = "Datum van vandaag is " + DateTime.Today.ToShortDateString() + ". Uw geselecteerde datum is " + dteSelectedDate.ToShortDateString() + ". Het duur nog " +intAantalDagen + " om deze datum te bereiken";
            pnlLogo.Visible = true;
        }
        lblDatum.Visible = true;
        lblDatum.Text = strUitvoer;
    }

    protected void btnLogo_Click(object sender, EventArgs e)
    {
        imgLogo.Visible = true;    }
}