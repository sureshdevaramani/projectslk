using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class ThirPartyCover : System.Web.UI.Page
{

    SqlConnection mycon;
    SqlDataAdapter myadapter;
    SqlCommand mycmd;
    DataSet myds;
    public string cusid;
    public double pre;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   


    protected void Button1_Click(object sender, EventArgs e)
    {
        //double per;
        int val = int.Parse((CarAge.Value));
        //   Response.Redirect(val.ToString());
        // double Price = double.Parse(CarName.Value);
        //    Response.Redirect(Price.ToString());

        if (val == 6)
        {
            pre = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.05);

        }
        else if (val == 1)
        {
            pre = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.10);
        }
        else if (val == 2)
        {
            pre = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.15);
        }
        else if (val == 3)
        {
            pre = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.20);
        }
        else if (val == 4)
        {
            pre = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.25);
        }
        else
        {
            pre = double.Parse(CarName.Value) - (double.Parse(CarName.Value) * 0.30);
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

    protected void Button2_Click(object sender, EventArgs e)
    {

        string comp = CarName.Value.ToString();
      //  Label2.Text = comp;
        if (comp == "250000")
        {
            comp = "Car-1";
        }
        else if (comp == "350000") { comp = "Car-2"; }
        else if (comp == "450000") { comp = "Car-3"; }
       // Label3.Text = comp;

        string cs = ConfigurationManager.ConnectionStrings["insurancepolicyConnectionString1"].ConnectionString;
        SqlConnection con = new SqlConnection(cs);
        string PolicName = "Third Party Cover Policy";
        string PolicyType = PremiumAge.Value.ToString();
        //    Date.Text = DateTime.Now.ToString();\
        // int rc;
        mycon = new SqlConnection("server=localhost\\SQLExpress;user id = sa; password=password@1;database=insurancepolicy");
        string eno = "select CusID, CusName from CusDetails where CusUserID = '" + Session["name"] + "'";
        // SqlCommand cmd = new SqlCommand("select CusID, CusName from CusDetails where CusUserName='" + Session["name"] + "'", con);
        myadapter = new SqlDataAdapter(eno, mycon);
        myds = new DataSet();
        myadapter.Fill(myds, "CusDetails");
        int rc = myds.Tables["CusDetails"].Rows.Count;
        //   Label1.Text = rc.ToString();
        if (rc > 0)
        {
            Session["id"] = myds.Tables["CusDetails"].Rows[0][0].ToString();

            Session["Cusname"] = myds.Tables["CusDetails"].Rows[0]["CusName"].ToString();
        }
        else
        {
            Label1.Text = "Recor not found";
        }
      
        SqlCommand cmd = new SqlCommand("insert into PolicyTable values('" + Session["id"] + "','" + Session["Cusname"] + "','" + PolicName + "','" + PolicyType + " Year Type" + "','" + comp + "','" + DateTime.Now + "','" + TextBox4.Text + "','" + DateTime.Now.AddYears(int.Parse(PremiumAge.Value))+ "','" + "On Going" + "')", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("Payment.aspx");

        //}
        //catch
        //{
        //    Label1.Text = "You already a policy holder of this type";
        //}

    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserPortal.aspx");
    }
}