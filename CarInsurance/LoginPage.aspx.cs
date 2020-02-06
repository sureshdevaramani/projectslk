using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if ((TextBox1.Text != "") && (TextBox2.Text != "") )
            {
                string cs = ConfigurationManager.ConnectionStrings["insurancepolicyConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);

                
                SqlCommand cmd = new SqlCommand("select CusUserID,CusPassword from CusDetails where CusUserID='" + TextBox1.Text + "' and CusPassword='" + TextBox2.Text + "'", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    Session["name"] = TextBox1.Text;
                    Response.Redirect("UserPortal.aspx");
                }
                else
                {
                    Label1.Text = "Invalid username or password";
                }
                //Label1.Text = cmd.ExecuteNonQuery().ToString();
          //if (cmd.ExecuteNonQuery() == 1)
          //      {
          //           Response.Redirect("UserPortal.aspx");
          //      }
          //      else
          //      {
          //          Label1.Text = "invalid UserName or Password";
          //      }


            }
            else
            {
                Label1.Text = "Enter Username and password";
            }
        }
        catch
        {
            Label1.Text = "invalid UserName or Password";
        }
    }
}