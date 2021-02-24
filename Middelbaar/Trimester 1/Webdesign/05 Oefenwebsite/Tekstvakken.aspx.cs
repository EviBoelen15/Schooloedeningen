using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tekstvakken : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtVak1_TextChanged(object sender, EventArgs e)
    {
        lblVak1.Text = txtVak1.Text;
    }

    protected void txtVak2_TextChanged(object sender, EventArgs e)
    {
        lblVak2.Text = txtVak2.Text;
    }
}