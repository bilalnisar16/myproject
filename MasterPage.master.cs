using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["uname"]!=null)
        {
            Label1.Text = Session["uname"].ToString();
        }
        else
        {
            Label1.Text = "Guest";
        }
        if (!IsPostBack)
        {
            if (Session["search"] != null)
            {
                txtsearch.Text = Session["search"].ToString();
            }
        }
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        Session["search"] = txtsearch.Text;
        Response.Redirect("~/search.aspx");
    }
}
