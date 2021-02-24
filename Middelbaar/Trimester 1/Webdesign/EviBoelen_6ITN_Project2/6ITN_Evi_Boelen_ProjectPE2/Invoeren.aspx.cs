using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bloedwaardes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnbereken_Click(object sender, EventArgs e)
    {
        double dblbloedwaarde = Math.Round(Convert.ToDouble(tbbloedwaarde.Text),2);
        DateTime dtdatum = Convert.ToDateTime(cd.SelectedDate);
        if (dtdatum < DateTime.Now)
        {
            lblresultaat.Text = tbDeurw.Text + ", U kan kan geen datum in het verleden aangeven, dit is fraude.";
        }
        else if (dtdatum > DateTime.Now)
        {
            lblresultaat.Text = tbDeurw.Text + ", U kan geen datum in de toekomst aangeven, dit is fraude.";
        }
        else if (dtdatum == DateTime.Now)
        {
            if (dblbloedwaarde <= 4.15)
            {
                lblresultaat.Text = tbDeurw.Text + ", U test negatief voor doping.";
            }
            else
            {
                lblresultaat.Text = tbDeurw.Text + ", U test positief voor doping.";
            }
        }
    }
}