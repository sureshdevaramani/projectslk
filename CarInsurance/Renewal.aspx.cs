using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Renewal : System.Web.UI.Page
{
    private string mycon;
    public string cusid;

   
    SqlDataAdapter myadapter;
    SqlCommand mycmd;
    DataSet myds;
    SqlConnection mycon1;
    SqlDataAdapter myadapter1;
    SqlCommand mycmd1;
    DataSet myds2;
    //  SqlConnection mycon;
    SqlDataAdapter myadapter2;
    SqlCommand mycmd2;
    DataSet myds1;
    protected void Page_Load(object sender, EventArgs e)
    {
        // DateTime StartDate;
        //   DateTime EndDate;

        SqlConnection mycon;
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
              cusid  = myds1.Tables["PolicyTable"].Rows[0]["CusID"].ToString();
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



    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection mycon1 = new  SqlConnection("server=localhost\\SQLExpress;user id = sa; password=password@1;database=insurancepolicy");

      using(  SqlCommand Mycmd = new SqlCommand("update PolicyTable set PolicyEndDate=@pd  where CusID=@ID", mycon1)) { 
        Mycmd.Connection.Open();
            if (TextBox5.Text == "1 Year Type")
            {
                TextBox5.Text = "1";
            }
            else if(TextBox5.Text == "2 Year Type")
            {
                TextBox5.Text = "2";
            }
            else if (TextBox5.Text == "3 Year Type")
            {
                TextBox5.Text = "3";
            }
            else if (TextBox5.Text == "4 Year Type")
            {
                TextBox5.Text = "4";
            }
            else if (TextBox5.Text == "5 Year Type")
            {
                TextBox5.Text = "5";
            }
            string dt = DateTime.Now.AddYears(int.Parse(TextBox5.Text)).ToString();
           

           // Label2.Text = "dt: " + dt + " id: " + id;
        Mycmd.Parameters.AddWithValue("@pd",dt);
        Mycmd.Parameters.AddWithValue("@ID",cusid );

            try
            {
                Mycmd.ExecuteNonQuery();
            }
            catch(Exception eee)
            {
                Label1.Text = eee.Message.ToString();
            }
        }
        //  
        //   string q = ;
        // SqlDataAdapter  myadapter2 = new SqlDataAdapter(q, mycon1);
        //  DataSet myds2 = new DataSet();
        //   myadapter2.Fill(myds2, "PolicyTable");
        ////   Label2.Text = q;
        //    int rc2 = myds2.Tables["PolicyTable"].Rows.Count;
        //   Label2.Text = rc2.ToString();
        //if (rc1 > 0)
        //{

        //}
        Response.Redirect("Payment.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserPortal.aspx");
    }
}
