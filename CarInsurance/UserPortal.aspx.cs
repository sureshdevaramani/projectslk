using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserPortal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["name"]==null)
        {
            Response.Redirect("LoginPage.aspx");
        }else
        {
               Label1.Text = Session["name"].ToString();
   
        }
      }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["name"] = null;
        Session["id"] = null;
        Response.Redirect("LoginPage.aspx");
    }
}