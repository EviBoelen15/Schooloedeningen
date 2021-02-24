using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Postback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void chkRestPagina_CheckedChanged(object sender, EventArgs e)
    {
        // als een vinkje staat, panel zichtbaar; Als ik uitvink, panel onzichtbaar. Enkel zichtbaar zetten is dus niet voldoende doordat het ook  onzichtbaar kan zijn
        if (chkRestPagina.Checked)
        {
            PanelASP.Visible = true;
        }
        else
        {
            PanelASP.Visible = false;
        }

        lblVerandering.Text = "Verandering vastgesteld in " + chkRestPagina.ID + "<br>" + " De waarde is nu " + chkRestPagina.Checked + "<br>" + "Tekstwaarde " + chkRestPagina.Text;
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void rdbMoeilijk_CheckedChanged(object sender, EventArgs e)
    {
        lblVerandering.Text = "Verandering vastgesteld in " + rdbMoeilijk.ID + "<br>" + " De waarde is nu " + rdbMoeilijk.Checked + "<br>" + "Tekstwaarde " + rdbMoeilijk.Text;

    }

    protected void rdbLeuk_CheckedChanged(object sender, EventArgs e)
    {
        lblVerandering.Text = "Verandering vastgesteld in " + rdbLeuk.ID + "<br>" + " De waarde is nu " + rdbLeuk.Checked + "<br>" + "Tekstwaarde " + rdbLeuk.Text;

    }
}