<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UserSec.General1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="UserMaintCSS/GeneralMaster.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="cphGeneralMaster">
    <table class="dataTablestyle1">
        <tr>
            <td class="dataTablestyle2">
                UserName</td>
            <td>
                <asp:TextBox ID="txtName" runat="server" MaxLength="50"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="dataTablestyle2">
                Password</td>
            <td>
                <asp:TextBox ID="txtPass" runat="server" MaxLength="100" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="dataTablestyle2">
                <asp:LinkButton ID="lbtnForgotPass" runat="server">Forgot Password?</asp:LinkButton>
            </td>
            <td>
                <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" Text="Login" />
            </td>
        </tr>
    </table>
</asp:Content>

