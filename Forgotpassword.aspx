<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Forgotpassword.aspx.cs" Inherits="Forgotpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ForgotPassword</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <div class="form-horizontal">
    <h2>Recover Password</h2>
        <hr />
        <h3>Please entre email address</h3>
        <div class="from-group">

            <asp:Label ID="Label1" runat="server" CssClass="col-md-2 control-label" Text="Your Email"></asp:Label>
            <div class="col-md-3">

                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" TextMode="Email"></asp:TextBox>


            </div>

        </div>
          </div>
            <div class="form-group">
                <div class="col-md-2"></div>
                <div class="col-md-6">

                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-default" Text="Send" OnClick="Button1_Click" />


                &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;


                </div>
            </div>
    </div>
    </form>
</body>
</html>
