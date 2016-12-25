<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #FF6600;
        }
        .auto-style2 {
            width: 318px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <table align="center" class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">USER NAME</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="165px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">USER ID</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="164px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">E-Mail ID</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Email" Width="163px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">MESSAGE</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Height="86px" TextMode="MultiLine" Width="175px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" Width="96px" OnClick="Button1_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

