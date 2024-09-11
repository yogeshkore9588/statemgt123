using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace statemgt123
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["count"]!=null)
            {
                int n = int.Parse(Session["count"].ToString());
                Label1.Text=n.ToString();
                n++;
                Session["count"] = n;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["count"] = 1;
            Session.Timeout = 1;
            Label1.Text = Session.Timeout.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["count"]!=null)
            {
                Label1.Text = Session["count"].ToString();
            }
            else
            {
                Label1.Text = "Session not available!!!";
            }
            
        }
    }
}