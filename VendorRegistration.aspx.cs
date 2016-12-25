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
using System.Web.UI.WebControls;



public partial class _Default : System.Web.UI.Page

{
    string emails = "rawmaterialsupplychain@gmail.com";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        var userStores1 = new UserStore<IdentityUser>();
        userStores1.Context.Database.Connection.ConnectionString =
            System.Configuration.ConfigurationManager.ConnectionStrings["RMSC1ConnectionString"].ConnectionString;
        var manage1 = new UserManager<IdentityUser>(userStores1);
        var vendor = new IdentityUser { UserName = TextBox2.Text };
        //confirming the password 
        if (TextBox9.Text == TextBox10.Text)
        {
            try
            {
                IdentityResult result1 = manage1.Create(vendor, TextBox9.Text);
                // if password and cofirmed password matches then execute it 
                if (result1.Succeeded)
                {
                    // creates a new user if password and confirm password matches
                    VENDOR vendorDetails = new VENDOR();
                    //extraxting user information from the fields of the registration form
                    vendorDetails.VendorID = 3;
                    vendorDetails.v_Address = TextBox11.Text;
                    vendorDetails.v_Email = TextBox8.Text;
                    vendorDetails.v_Password = TextBox9.Text;
                    vendorDetails.Vname = TextBox2.Text;
                    vendorDetails.v_Username = TextBox3.Text;
                    vendorDetails.v_City = TextBox4.Text;
                    vendorDetails.v_ContactNo = TextBox7.Text;
                    vendorDetails.v_Username = TextBox12.Text;
                    vendorDetails.v_RegisterDate = Convert.ToDateTime(TextBox13.Text);


                    // UserDetailModel will get  the user details
                    VendorDetailModel model1 = new VendorDetailModel();
                    // insertUserDetail will be called to insert new user data in the database
                    model1.InsertVendorDetail(vendorDetails);

                    //Store user in DB
                    var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                    var userIdentity1 = manage1.CreateIdentity(vendor, DefaultAuthenticationTypes.ApplicationCookie);

                    //If succeedeed, log in the new user and set a cookie and redirect to homepage
                    authenticationManager.SignIn(new AuthenticationProperties(), userIdentity1);
                    email();
                    Response.Redirect("~/HomePage.aspx");
                }
                else
                {
                    Label3.Text = result1.Errors.FirstOrDefault();
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

