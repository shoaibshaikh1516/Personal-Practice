using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OneLabel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblhello.Text = "Hello Universe";

        if (!IsPostBack)
        {
            lblhello.Text = "Hello World";
        }
    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Response.Write("Inside PreInit");
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        Response.Write("Inside PreRender");
    }
}