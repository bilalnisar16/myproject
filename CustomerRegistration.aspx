<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CustomerRegistration.aspx.cs" Inherits="_CustomerRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #FF6600;
        }
        .auto-style2 {
            height: 19px;
        }
        .auto-style3 {
            height: 20px;
        }
        .auto-style4 {
            height: 21px;
        }
        .auto-style5 {
            text-align: right;
            font-weight: bold;
            font-size: medium;
        }
        .auto-style6 {
            height: 21px;
            text-align: right;
            font-weight: bold;
            font-size: medium;
        }
        .auto-style7 {
            height: 20px;
            text-align: right;
            font-weight: bold;
            font-size: medium;
        }
        .auto-style8 {
            height: 19px;
            text-align: right;
            font-weight: bold;
            font-size: medium;
        }
        .auto-style9 {
            width: 332px;
        }
        .auto-style10 {
            height: 19px;
            width: 332px;
        }
        .auto-style11 {
            height: 20px;
            width: 332px;
        }
        .auto-style12 {
            height: 21px;
            width: 332px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p></p>
     <h2>Registration Form</h2>
     <table align="center" class="auto-style1">
         <tr>
             <td class="auto-style5">&nbsp;</td>
             <td class="auto-style9">&nbsp;</td>
             <td>&nbsp;</td>
         </tr>
         <tr>
             <td class="auto-style8">
                 <pre style="font-family: Consolas; font-size: 13; color: black; background: white;" class="auto-style5">FIRST&nbsp;NAME:</pre>
             </td>
             <td class="auto-style10">
                 <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
             </td>
             <td class="auto-style2"></td>
         </tr>
         <tr>
             <td class="auto-style5">
                 <pre style="font-family: Consolas; font-size: 13; color: black; background: white;" class="auto-style5">LAST&nbsp;NAME:</pre>
             </td>
             <td class="auto-style9">
                 <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
             </td>
             <td>&nbsp;</td>
         </tr>
         <tr>
             <td class="auto-style5">ADDRESS:</td>
             <td class="auto-style9">
                 <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
             </td>
             <td>&nbsp;</td>
         </tr>
         <tr>
             <td class="auto-style7">CITY:</td>
             <td class="auto-style11">
                 <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
             </td>
             <td class="auto-style3"></td>
         </tr>
         <tr>
             <td class="auto-style7">STATE:</td>
             <td class="auto-style11">
                 <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
             </td>
             <td class="auto-style3"></td>
         </tr>
         <tr>
             <td class="auto-style5">PINCODE:</td>
             <td class="auto-style9">
                 <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
             </td>
             <td>&nbsp;</td>
         </tr>
         <tr>
             <td class="auto-style5">GENDRE:</td>
             <td class="auto-style9">
                 <asp:RadioButton ID="Male" runat="server"  />
&nbsp;
                 <asp:Label ID="Label1" runat="server" Text="Male"></asp:Label>
&nbsp;&nbsp;&nbsp;
                 <asp:RadioButton ID="Female" runat="server" />
                 <asp:Label ID="Label2" runat="server" Text="Female"></asp:Label>
             </td>
             <td>&nbsp;</td>
         </tr>
         <tr>
             <td class="auto-style5">MOBILE NO:</td>
             <td class="auto-style9">
                 <asp:TextBox ID="TextBox7" runat="server" TextMode="Number"></asp:TextBox>
             </td>
             <td>&nbsp;</td>
         </tr>
         <tr>
             <td class="auto-style6">EMAIL_ID:</td>
             <td class="auto-style12">
                 <asp:TextBox ID="TextBox8" runat="server" TextMode="Email"></asp:TextBox>
             </td>
             <td class="auto-style4"></td>
         </tr>
         <tr>
             <td class="auto-style5">PASSWORD:</td>
             <td class="auto-style9">
                 <asp:TextBox ID="TextBox9" runat="server" TextMode="Password"></asp:TextBox>
             </td>
             <td>&nbsp;</td>
         </tr>
         <tr>
             <td class="auto-style5">Confirm PASSWORD</td>
             <td class="auto-style9">
                 <asp:TextBox ID="TextBox10" runat="server" TextMode="Password"></asp:TextBox>
             </td>
             <td>&nbsp;</td>
         </tr>
         <tr>
             <td class="auto-style5">USER NAME</td>
             <td class="auto-style9">
                 <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
             </td>
             <td>&nbsp;</td>
         </tr>
         <tr>
             <td class="auto-style5">&nbsp;</td>
             <td class="auto-style9">
                 <asp:Button ID="Button1" runat="server" Text="Submit" Width="138px" OnClick="Button1_Click" />
             </td>
             <td>&nbsp;</td>
         </tr>
         <tr>
             <td class="auto-style5">&nbsp;</td>
             <td class="auto-style9">
                 <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
             </td>
             <td>&nbsp;</td>
         </tr>
     </table>
</asp:Content>

