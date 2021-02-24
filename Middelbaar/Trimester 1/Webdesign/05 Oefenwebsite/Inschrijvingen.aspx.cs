using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class Inschrijvingen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (IsPostBack)
        {
            lblTitel.BackColor = Color.Green;

        }
        else
        {
            lblTitel.BackColor = Color.Red;
        }

    }

    protected void btnGenereer_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        string strId = txtFamilie.Text;
        string strSleutel = txtFamilie.Text.Substring(0, 2).ToLower() + txtVoornaam.Text.Substring(0, 2).ToUpper() + calKalender.SelectedDate.Month;


        //Weergeven
        lblSleutel.Text = strSleutel;
        lblId.Text = strId;

    }
}