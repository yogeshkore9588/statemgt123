using System;

namespace statemgt123
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["count"] != null)
            {
                Label3.Text = Session["count"].ToString();
            }
            if (Request.QueryString.Count > 0)
            {
                Label2.Text = "welcome " + Request.QueryString[0];
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}