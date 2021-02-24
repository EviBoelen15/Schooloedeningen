using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Wachtwoord : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtPaswoord_TextChanged(object sender, EventArgs e)
    {
        string strPaswoord = txtPaswoord.Text;
        string strUitvoer;

        if (strPaswoord == "ASP")
            {
            strUitvoer = "Proficiat";
             }
        else
        {
            strUitvoer = "Incorrect paswoord";
            txtPaswoord.Focus();
        }

        lblFeedback.Text = strUitvoer;
    }
}