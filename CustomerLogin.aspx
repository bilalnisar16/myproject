﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="_CustomerLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <style type="text/css">
        .auto-style1 {
            width: 227px;
        }
        .auto-style2 {
            width: 196px;
        }
        .auto-style3 {
            width: 227px;
            height: 35px;
        }
        .auto-style4 {
            width: 196px;
            height: 35px;
        }
        .auto-style5 {
            height: 35px;
        }
        .auto-style6 {
            width: 227px;
            height: 28px;
            text-align: center;
        }
        .auto-style7 {
            width: 196px;
            height: 28px;
        }
        .auto-style8 {
            height: 28px;
        }
        .auto-style9 {
            width: 227px;
            height: 26px;
            text-align: center;
        }
        .auto-style10 {
            width: 196px;
            height: 26px;
        }
        .auto-style11 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <table align="center" class="style1" style="height: 49px; width: 49%">
        <tr>
            
            <td class="auto-style3" style="font-size: large; font-weight: bold">Customer Login Pannel</td>
            <td class="auto-style4">
            </td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            
            <td class="auto-style9" style="font-weight: bold; font-size: medium">User-Email Id</td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBox12" runat="server" Height="21px" Width="127px" ></asp:TextBox>
            </td>
            <td class="auto-style11"></td>
        </tr>
        <tr>
            <td class="auto-style6" style="font-weight: bold; font-size: medium">Password</td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="127px" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="Button1" runat="server" Text="Login" Width="86px" OnClick="Button1_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                <asp:LinkButton ID="lblForget" runat="server"  PostBackUrl="~/Forgotpassword.aspx" OnClick="lblForget_Click">Forgot password !</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

