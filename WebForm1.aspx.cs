using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace statemgt123
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["UID"] = TextBox1.Text;


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ViewState["UID"]!=null)
            {
                Label1.Text = ViewState["UID"].ToString();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Webform2.aspx?userID={TextBox1.Text.Trim()}&mobile={TextBox2.Text}");
            
        }
    }
}