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




public partial class Default2 : System.Web.UI.Page
{
    string y;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadRawmaterials();
        }
        
    
    }
    private void loadRawmaterials()
    {

        string str = "select RawID,r_image1,r_Name,r_Price from rawmaterial where r_Name like '" + Session["search"] + "%'";
        string css = ConfigurationManager.ConnectionStrings["RMSC1ConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(css))
        {
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            DataList1.DataSource = rdr;
            DataList1.DataBind();

        }
       }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        y = e.CommandArgument.ToString();
        Response.Redirect("Itemview.aspx?RawID=" + e.CommandArgument.ToString());
         
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string productid = Convert.ToInt16((((Button)sender).CommandArgument)).ToString();
    }
}