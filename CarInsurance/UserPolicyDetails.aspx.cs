using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class UserDetails : System.Web.UI.Page
{
    DateTime StartDate;
    DateTime EndDate;
    SqlConnection mycon;
    SqlDataAdapter myadapter;
    SqlCommand mycmd;
    DataSet myds;
    SqlConnection mycon1;
    SqlDataAdapter myadapter1;
    SqlCommand mycmd1;
    DataSet myds1;
    protected void Page_Load(object sender, EventArgs e)
    {
        mycon = new SqlConnection("server=localhost\\SQLExpress;user id = sa; password=password@1;database=insurancepolicy");
       // Label1.Text = Session["name"].ToString();
        string eno = "select CusID from CusDetails where CusUserID = '" + Session["name"]+ "'";
        // SqlCommand cmd = new SqlCommand("select CusID, CusName from CusDetails where CusUserName='" + Session["name"] + "'", con);
        myadapter = new SqlDataAdapter(eno, mycon);
        myds = new DataSet();
        myadapter.Fill(myds, "CusDetails");

        int rc = myds.Tables["CusDetails"].Rows.Count;
        if (rc > 0)
        {
            Session["id"] = myds.Tables["CusDetails"].Rows[0]["CusID"].ToString();
            string eno1 = "select * from PolicyTable where CusID='" + Session["id"] + "'";
            // SqlCommand cmd = new SqlCommand("select CusID, CusName from CusDetails where CusUserName='" + Session["name"] + "'", con);
            myadapter1 = new SqlDataAdapter(eno1, mycon);
            myds1 = new DataSet();
            myadapter1.Fill(myds1, "PolicyTable");
            int rc1 = myds1.Tables["PolicyTable"].Rows.Count;
            //   Label1.Text = rc.ToString();
            if (rc1 > 0)
            {
                TextBox2.Text = myds1.Tables["PolicyTable"].Rows[0][0].ToString();
               //TextBox4.Text = myds1.Tables["PolicyTable"].Rows[0]["CusID"].ToString();
                TextBox1.Text = myds1.Tables["PolicyTable"].Rows[0]["PolicyCusname"].ToString();
                TextBox3.Text = myds1.Tables["PolicyTable"].Rows[0]["PolicyName"].ToString();
                TextBox6.Text = Session["name"].ToString();
               TextBox5.Text = myds1.Tables["PolicyTable"].Rows[0]["PolicyType"].ToString();
                TextBox7.Text = myds1.Tables["PolicyTable"].Rows[0]["PolicyCarName"].ToString();
                TextBox8.Text = myds1.Tables["PolicyTable"].Rows[0]["PolicyDate"].ToString();
                TextBox9.Text = myds1.Tables["PolicyTable"].Rows[0]["PolicyEndDate"].ToString();
                TextBox10.Text = myds1.Tables["PolicyTable"].Rows[0]["PolicyRate"].ToString();
                TextBox4.Text = myds1.Tables["PolicyTable"].Rows[0]["Claimstatus"].ToString();
            }

        }

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserPortal.aspx");
    }
}
