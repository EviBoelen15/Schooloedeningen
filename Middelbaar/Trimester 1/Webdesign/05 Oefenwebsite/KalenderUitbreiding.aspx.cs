using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KalenderUitbreiding : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void calBegin_SelectionChanged(object sender, EventArgs e)
    {
        lblBegin.Text = calBegin.SelectedDate.ToLongDateString();
        lblEind.Text = CalEind.SelectedDate.ToLongDateString();

        lblVerschil.Text = Convert.ToString(CalEind.SelectedDate.Subtract(calBegin.SelectedDate).Days);
    }


    protected void CalEind_SelectionChanged(object sender, EventArgs e)
    {
        lblBegin.Text = calBegin.SelectedDate.ToLongDateString();
        lblEind.Text = CalEind.SelectedDate.ToLongDateString();

        lblVerschil.Text = Convert.ToString(CalEind.SelectedDate.Subtract(calBegin.SelectedDate).Days);
    }
}