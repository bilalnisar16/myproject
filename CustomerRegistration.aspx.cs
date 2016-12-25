using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Models;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.Web.UI.WebControls;

public partial class _CustomerRegistration : System.Web.UI.Page
{
    string emails = "rawmaterialsupplychain@gmail.com";

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        // Default UserStore constructor uses the default connection string named: DefaultConnection
        var userStore = new UserStore<IdentityUser>();

        //Set ConnectionString
        userStore.Context.Database.Connection.ConnectionString =
            System.Configuration.ConfigurationManager.ConnectionStrings["RMSC1ConnectionString"].ConnectionString;
        var manager = new UserManager<IdentityUser>(userStore);

        //Create new user and try to store in DB.
        var user = new IdentityUser { UserName = TextBox8.Text};

        //confirming the password 
        if (TextBox9.Text == TextBox10.Text)
        {
            try
            {
                IdentityResult result = manager.Create(user, TextBox9.Text);
                // if password and cofirmed password matches then execute it 
                if (result.Succeeded)
                {
                    // creates a new user if password and confirm password matches
                    CLIENT userDetails = new CLIENT();
                    //extraxting user information from the fields of the registration form
                    userDetails.c_Address = TextBox11.Text;
                    userDetails.c_Email = TextBox8.Text;
                    userDetails.c_Password = TextBox9.Text;
                    userDetails.c_Fname = TextBox2.Text;
                    userDetails.c_Lname = TextBox3.Text;
                    userDetails.c_City = TextBox4.Text;
                    userDetails.c_ContactNo = TextBox7.Text;
                    userDetails.c_Username = TextBox12.Text;


                    // UserDetailModel will get  the user details
                    UserDetailModel model = new UserDetailModel();
                    // insertUserDetail will be called to insert new user data in the database
                    model.InsertUserDetail(userDetails);

                    //Store user in DB
                    var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                    var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    
                                        //If succeedeed, log in the new user and set a cookie and redirect to homepage
                                        authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                                        email();
                                        Response.Redirect("~/HomePage.aspx");
                }
                else
                {
                    Label3.Text = result.Errors.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Label3.Text = ex.ToString();
            }
        }
        else
        {
            Label3.Text = "Passwords must match!";
        }
    }

    private void email()
    {
        string body = "from RMSC";
        var smtp = new System.Net.Mail.SmtpClient();
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            smtp.Timeout = 20000;
            smtp.Credentials = new NetworkCredential(emails, "rmscdemo");
        }
        smtp.Send(emails, TextBox8.Text, "authentication", body);
       

    }

   
}

