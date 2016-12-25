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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        string idd = Request.QueryString["RawID"].ToString();





        try
        {
            
            string cs = ConfigurationManager.ConnectionStrings["RMSC1ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {

                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader myreader = null;
                SqlCommand mycommand = new SqlCommand("select * from rawmaterial where RawId='" + Convert.ToInt32(idd) + "'", con);
                myreader = mycommand.ExecuteReader();
                while (myreader.Read())
                {
                    lblname.Text = (myreader["r_Name"].ToString());
                    lblprice.Text = (myreader["r_Price"].ToString());
                    lbldetail.Text = (myreader["r_Description"].ToString());
                    lblqnt.Text = (myreader["r_QuantityInStock"].ToString());
                    Image1.ImageUrl="data:Image/png;base64,"+ Convert.ToBase64String((byte[])(myreader["r_image1"])) ;
                    Image4.ImageUrl = "data:Image/png;base64," + Convert.ToBase64String((byte[])(myreader["r_image1"]));
                    Image2.ImageUrl = "data:Image/png;base64," + Convert.ToBase64String((byte[])(myreader["r_image2"]));
                    Image3.ImageUrl = "data:Image/png;base64," + Convert.ToBase64String((byte[])(myreader["r_image3"]));
                }
            }
        }
        catch (Exception)
        {



            lbldetail.Text = "Invalid username or password";
        }



    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    
}