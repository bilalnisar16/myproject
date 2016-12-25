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

public partial class Forgotpassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
         string cs = ConfigurationManager.ConnectionStrings["RMSC1ConnectionString"].ConnectionString;
         using (SqlConnection con = new SqlConnection(cs))
         {
             SqlCommand cmd = new SqlCommand("select * from CLIENT where c_Email='" +TextBox1.Text+ "'", con);
             con.Open();
             SqlDataAdapter sda = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             sda.Fill(dt);
             if(dt.Rows.Count !=0)
             {
                 string my = Guid.NewGuid().ToString();
                 int uid = Convert.ToInt32(dt.Rows[0][0]);
                // Label2.Text = Convert.ToString( dt.Rows[0][0]);
                 SqlCommand cmd1 = new SqlCommand("insert into forgotpassword_client values('" +my+ "','" +uid+ "',getDate())", con);
                 cmd1.ExecuteNonQuery();
                 
                 string toemailaddress = dt.Rows[0][3].ToString();
                  string uname = dt.Rows[0][1].ToString();
                  string email_body = "hi" + uname + ",<br/><br/>Click the link below <br/><br/> http://localhost:52416/RecoverPassword.aspx?uid=" +my;
                  string too = TextBox1.Text;
                 /*MailMessage passmail = new MailMessage("rawmaterialsupplychain@gmail.com", toemailaddress);
                 passmail.Body = email_body;
                 passmail.To = TextBox1.Text;
                 passmail.IsBodyHtml = true;
                 passmail.Subject = "reset password";
                 SmtpClient Smtp = new SmtpClient("smtp.gmail.com", 587);
                 Smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                 Smtp.Credentials = new NetworkCredential("rawmaterialsupplychain@gmail.com", "rmscdemo");
                 Smtp.EnableSsl = true;
                 Smtp.Send("rawmaterialsupplychain@gmail.com",TextBox1.Text,passmail.Subject, passmail.Body);*/
                  var smtp = new System.Net.Mail.SmtpClient();
                  {
                      smtp.Host = "smtp.gmail.com";
                      smtp.Port = 587;
                      smtp.EnableSsl = true;
                      smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                      smtp.Timeout = 20000;
                      smtp.Credentials = new NetworkCredential("rawmaterialsupplychain@gmail.com" , "rmscdemo");
                  }
                  smtp.Send("rawmaterialsupplychain@gmail.com", too, "reset password", email_body);
       

                
                 Label2.Text = "chech your email";
                 Label2.ForeColor=Color.Green;


                 //timer

                 Response.Redirect("CustomerLogin.aspx");

                // 
                

                // 
             }
             else{
                  Label2.Text = "chech your email";
                 Label2.ForeColor=Color.Red;


             }
         }
    }
}