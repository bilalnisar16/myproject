<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RecoverPassword.aspx.cs" Inherits="RecoverPassword" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change Password</title>
    <style type="text/css">
        .btn-default {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <div class="form-horizontal">
    <h2>Change Password</h2>
        <hr />
        <div class="from-group">

            <asp:Label ID="Lblmsg" runat="server" CssClass="col-md-2 control-label" Font-Size="XX-Large"  ></asp:Label></div>
        <h3>Please entre new password</h3>
        <div class="from-group">

            <asp:Label ID="Label1" runat="server" CssClass="col-md-2 control-label" Visible="false" Text="New Password"></asp:Label>
            <div class="col-md-3">

                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" Visible="false" TextMode="Password" ></asp:TextBox>


            </div>
            <div></div>

        </div>
         <div class="from-group">

            <asp:Label ID="Label3" runat="server" CssClass="col-md-2 control-label" Visible="false" Text="Confirm New Password"></asp:Label>
            <div class="col-md-3">

                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"  Visible="false" TextMode="Password"></asp:TextBox>


            </div>

        </div>
          </div>
            <div class="form-group">
                <div class="col-md-2"></div>
                <div class="col-md-6">

                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-default" Visible="false" Text="Reset Password" OnClick="Button1_Click" />


                &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;


                </div>
            </div>
    </div>
    </form>
</body>
</html>
