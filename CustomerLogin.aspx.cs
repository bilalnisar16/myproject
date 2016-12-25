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
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.IdentityModel;
using System.IO;





public partial class _CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //login through owin entity

        /*
        UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();


        userStore.Context.Database.Connection.ConnectionString =
            System.Configuration.ConfigurationManager.
            ConnectionStrings["RMSC1ConnectionString"].ConnectionString;


        UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);
        var user = manager.Find(TextBox12.Text, TextBox2.Text);
        

        if (user != null)
        {
            //Call OWIN functionality
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

            //Sign in user
            authenticationManager.SignIn(new AuthenticationProperties
            {
                IsPersistent = false
            }, userIdentity);

            //Redirect user to homepage
                                Response.Redirect("~/User/Default.aspx");

        }
        else
        {
             Label1.Visible = true;
            Label1.Text = "Invalid username or password";
        }
    

        */

        // login through simple client table
       
        try
        {

            using (RMSC1Entities1 r1 = new RMSC1Entities1())
            {
                
                var query = from o in r1.CLIENTs
                            where o.c_Email == TextBox12.Text && o.c_Password == TextBox2.Text
                            select o;

                
                if (query.SingleOrDefault() != null)
                {

                    UserDetailModel a = new UserDetailModel();
                    int cid = a.GetUserInformation(TextBox12.Text);
                    Session["clientid"] = cid;
                    Session["uname"]=a.GetUserName(TextBox12.Text);
                    Label1.ForeColor = System.Drawing.Color.FromName("#5BB1E6");
                    Label1.Text = "Sucessful login";

                    
                    Response.Redirect("~/User/Default.aspx");

                }
            }
        }
        catch (Exception)
        {


            Label1.Visible = true;
            Label1.Text = "Invalid username or password";
        }


        

    }



    private void las(object sender, EventArgs e)
    {
        System.Collections.Specialized.NameValueCollection collection = Request.Form;
        string str = "select * from rawmaterial where r_Name like '" + collection["txtsearch"] + "%'";
        string css = ConfigurationManager.ConnectionStrings["RMSC1ConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(css))
        {
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            

        }
    }



    protected void lblForget_Click(object sender, EventArgs e)
    {

    }
}
