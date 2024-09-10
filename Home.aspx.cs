using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace statemgt123
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count>0)
            {
                Label2.Text="welcome "+Request.QueryString[0];
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}