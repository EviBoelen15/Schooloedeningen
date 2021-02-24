using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Invoeren : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        lblgerechtsdeurwaarder.Text = lblgerechtsdeurwaarder.Text + txtbxGerechtsdeurwaarder.Text;
        lblBloedwaarde.Text =  lblBloedwaarde.Text + txtbxBloedwaarde.Text;
        DateTime dteDatum = Calendar1.SelectedDate;
        if(dteDatum < DateTime.Now)
        {
            lbldatum.Text = lbldatum.Text + "Kan geen datum in het verleden aangeven, dit is fraude.";
        }
        else
        {
            string strDatum = Convert.ToString(dteDatum);
            lbldatum.Text = lbldatum.Text + strDatum;
        }
                       
    }
}