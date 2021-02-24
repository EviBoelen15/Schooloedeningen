using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Kalender : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void calKalender_SelectionChanged(object sender, EventArgs e)
    {
        lblLabel.Text = calKalender.SelectedDate.ToLongDateString();
    }
}