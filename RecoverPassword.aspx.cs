using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Drawing;


public partial class RecoverPassword : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["RMSC1ConnectionString"].ConnectionString;
    string GuidValue;
    DataTable dt = new DataTable();
    int uid;
    protected void Page_Load(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            GuidValue = Request.QueryString["uid"];
            if (GuidValue != null)
            {
                SqlCommand cmd = new SqlCommand("select * from forgotpassword_client where id='" + GuidValue + "'", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
               
                sda.Fill(dt);
                uid = Convert.ToInt32(dt.Rows[0][1]);
            }
            else
            {
                Response.Redirect("~/HomePage.aspx");
            }
        }
        if(!IsPostBack)
        {
            if(dt.Rows.Count!=0)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                Label1.Visible = true;
                Label3.Visible = true;
                Button1.Visible = true;
            }
            else
            {
                Lblmsg.Text = "your password reset link request has expired";
                Lblmsg.ForeColor = Color.Red;
                Lblmsg.Visible = true;
            }
        }
            
             
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            SqlCommand cmd = new SqlCommand("update CLIENT set c_Password='" + TextBox1.Text + "' where ClientID='"+uid+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();

        }

    }
}