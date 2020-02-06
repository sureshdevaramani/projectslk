using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class Payment : System.Web.UI.Page
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
    public string cusid;
    public string PolID, PolRate;
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        mycon = new SqlConnection("server=localhost\\SQLExpress;user id = sa; password=password@1;database=insurancepolicy");
        // Label1.Text = Session["name"].ToString();
        string eno = "select CusID from CusDetails where CusUserID = '" + Session["name"] + "'";
        // SqlCommand cmd = new SqlCommand("select CusID, CusName from CusDetails where CusUserName='" + Session["name"] + "'", con);
        myadapter = new SqlDataAdapter(eno, mycon);
        myds = new DataSet();
        myadapter.Fill(myds, "CusDetails");

        int rc = myds.Tables["CusDetails"].Rows.Count;
        if (rc > 0)
        {
            cusid = myds.Tables["CusDetails"].Rows[0]["CusID"].ToString();
            string eno1 = "select * from PolicyTable where CusID='" + cusid + "'";
            // SqlCommand cmd = new SqlCommand("select CusID, CusName from CusDetails where CusUserName='" + Session["name"] + "'", con);
            myadapter1 = new SqlDataAdapter(eno1, mycon);
            myds1 = new DataSet();
            myadapter1.Fill(myds1, "PolicyTable");
            int rc1 = myds1.Tables["PolicyTable"].Rows.Count;
            //   Label1.Text = rc.ToString();
            if (rc1 > 0)
            {
                PolID= myds1.Tables["PolicyTable"].Rows[0][0].ToString();
                PolRate = myds1.Tables["PolicyTable"].Rows[0]["PolicyRate"].ToString();
            }
        }


        string cs = ConfigurationManager.ConnectionStrings["insurancepolicyConnectionString1"].ConnectionString;
        SqlConnection con = new SqlConnection(cs);


        SqlCommand cmd = new SqlCommand("insert into Payment values('" + cusid + "','" + PolID + "','" + PolRate+ "','" +"Successfull"+ "','" + TextBox1.Text + "','" + TextBox4.Text + "')", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();


        Response.Redirect("Pay.html");
    }

}