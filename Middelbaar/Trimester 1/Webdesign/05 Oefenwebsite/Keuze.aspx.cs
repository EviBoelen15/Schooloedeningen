using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Keuze : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInschrijven_Click(object sender, EventArgs e)
    {
        string strTaal = Convert.ToString(ddlTaal.SelectedItem);
        string strSessie = Convert.ToString(chklSessies.SelectedItem);

        string strReceptie="";
        if (chkReceptie.Checked)
            {
            strReceptie = "ingeschreven";
             }
            else
            {
            strReceptie = "niet ingeschreven";
            }
        string strMiddagmaal = Convert.ToString(rdblMiddagmaal.SelectedItem);

        //Uitvoer samenstellen en uitvoeren
        string strUitvoer= "U bent ingeschreven voor de sessie " +strSessie+" in de taal " + strTaal +". U bent " + strReceptie +" voor de receptie. Als middagmaal maakte u de volgende keuze: " + strMiddagmaal + ". Wij wensen u een interessante vorming.";
        lblBevestiging.Visible = true;
        lblBevestiging.Text = strUitvoer;
    }
}