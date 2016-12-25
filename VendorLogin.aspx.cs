using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Models;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            using (RMSC1Entities1 r2 = new RMSC1Entities1())
            {
                var query = from o in r2.VENDORs
                            where o.v_Email == vemail.Text && o.v_Password == vpass.Text
                            select o;
                if (query.SingleOrDefault() != null)
                {
                    Label2.ForeColor = System.Drawing.Color.FromName("#5BB1E6");
                    Label2.Text = "Sucessful login";

                    Response.Redirect("~/Vendor/Vieworder.aspx");

                }
            }
        }
        catch (Exception)
        {



            Label2.Text = "Invalid username or password";
        }
    }
}