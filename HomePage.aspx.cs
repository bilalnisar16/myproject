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

public partial class HomePage : System.Web.UI.Page
{
    string x;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            loadRawmaterials();
        }
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        Session["search"] = txtsearch.Text;
        Response.Redirect("~/search.aspx");
    }
    
    private void loadRawmaterials()
    {
        string cs = ConfigurationManager.ConnectionStrings["RMSC1ConnectionString"].ConnectionString;
        using(SqlConnection con=new SqlConnection(cs))
        {
            SqlCommand cmd = new SqlCommand("select RawID,r_image1,r_Name,r_Price from RAWMATERIAL", con);
            con.Open();
            SqlDataReader rdr=cmd.ExecuteReader();
            DataList1.DataSource = rdr;
            DataList1.DataBind();
            

        }
    }

    public string raw
    {
        get{return x;}
        
            
        
    }
   
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        x = e.CommandArgument.ToString();
        Response.Redirect("Itemview.aspx?RawID=" + e.CommandArgument.ToString());
         

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string productid = Convert.ToInt16((((Button)sender).CommandArgument)).ToString();
    }
}