using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Policy : System.Web.UI.Page
{
    public double pre;
    public double pre1;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //double per;
        int val = int.Parse((CarAge.Value));
        int valpol = int.Parse(policy.Value);
        //   Response.Redirect(val.ToString());
        double Price = double.Parse(CarName.Value);
        //    Response.Redirect(Price.ToString());
      //  PoclicyName.Text = val.ToString();
        if (valpol == 1)
        {
            if (val == 6)
            {
                pre = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.05);

            }
            else if (val == 1)
            {
                pre = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.15);
            }
            else if (val == 2)
            {
                pre = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.2);
            }
            else if (val == 3)
            {
                pre = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.3);
            }
            else if (val == 4)
            {
                pre = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.4);
            }
            else
            {
                pre = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.5);
            }

            TextBox2.Text = Convert.ToString(pre);
            int valpre = int.Parse((PremiumAge.Value));
            if (valpre == 1)
            {
                pre /= 12;
                TextBox3.Text = Convert.ToString(pre);
            }
            else if (valpre == 2)
            {
                pre /= 24;
                TextBox3.Text = Convert.ToString(pre);
            }
            else if (valpre == 3)
            {
                pre /= 36;
                TextBox3.Text = Convert.ToString(pre);
            }
            else if (valpre == 4)
            {
                pre /= 48;
                TextBox3.Text = Convert.ToString(pre);

            }
            else if (valpre == 5)
            {
                pre /= 60;
                TextBox3.Text = Convert.ToString(pre);

            }
            pre = pre - (pre * 0.8);
            TextBox4.Text = Convert.ToString(pre);
        }
        else if(valpol==2)
        {
           // double per;
            int val1 = int.Parse((CarAge.Value));
            PoclicyName.Text = val1.ToString();
            //   Response.Redirect(val.ToString());
            // double Price = double.Parse(CarName.Value);
            //    Response.Redirect(Price.ToString());
        //    PoclicyName.Text = val1.ToString();
           // Label2.Text = valpol.ToString();
            if (val1 == 6)
            {
                pre1 = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.01);

            }
            else if (val1 == 1)
            {
                pre1 = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.10);
            }
            else if (val1 == 2)
            {
                pre1 = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.15);
            }
            else if (val1 == 3)
            {
                pre1 = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.20);
            }
            else if (val1 == 4)
            {
                pre1 = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.25);
            }
            else
            {
                pre1 = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.30);
            }

            TextBox2.Text = Convert.ToString(pre1);
            int valpre = int.Parse((PremiumAge.Value));
            if (valpre == 1)
            {
                pre1 /= 12;
                TextBox3.Text = Convert.ToString(pre1);
            }
            else if (valpre == 2)
            {
                pre1 /= 24;
                TextBox3.Text = Convert.ToString(pre1);
            }
            else if (valpre == 3)
            {
                pre1 /= 36;
                TextBox3.Text = Convert.ToString(pre1);
            }
            else if (valpre == 4)
            {
                pre1 /= 48;
                TextBox3.Text = Convert.ToString(pre1);

            }
            else if (valpre == 5)
            {
                pre1 /= 60;
                TextBox3.Text = Convert.ToString(pre1);

            }
            pre1 = pre1 - (pre1 * 0.8);
            TextBox4.Text = Convert.ToString(pre1);
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage1.html");
    }
}