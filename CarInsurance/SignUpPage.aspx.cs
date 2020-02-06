using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class SignUpPage : System.Web.UI.Page
{
    SqlConnection mycon;
    SqlDataAdapter myadapter;
    SqlCommand mycmd;
    DataSet myds;

    static int clickStatus = 0;
    string eno;

    public object Gridview1 { get; private set; }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        try {
            if ((TextBox1.Text != "") && (TextBox2.Text != "") && (TextBox3.Text != "") && (TextBox4.Text != "") && (TextBox5.Text != "") && (TextBox6.Text != ""))
            { 
                string cs = ConfigurationManager.ConnectionStrings["insurancepolicyConnectionString1"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
           
        
            SqlCommand cmd = new SqlCommand("insert into CusDetails values('" + TextBox6.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
                con.Close();
                
           Response.Redirect("LoginPage.aspx");
        }
            else
            {
                Label1.Text = "All fields are mandatory";
            }
        }
        catch
        {
            Label1.Text ="UserName already exist";
        }


    }

    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }
}