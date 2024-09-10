using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace statemgt123
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Label1.Text= Request.QueryString["userID"];
            Label2.Text = Request.QueryString["mobile"];
            Label3.Text= Request.QueryString.Count.ToString();
        }
    }
}