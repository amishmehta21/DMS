<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaint/LoggedIn.Master" AutoEventWireup="true" CodeBehind="UM_RoleAdd.aspx.cs" Inherits="UserSec.UM_RoleAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../UserMaintCSS/UM_RoleAdd.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainPage" runat="server" >
    <table  class="TableDataStyle1">
    
        <tr>
    <td colspan="3" class="font">(Fields marked with
         (*) are mandatory.)
        </td>
        </tr>
        <tr>
        <td class="TableDataStyle2">
            RoleShortDescription <span class="font">*</span></td>
        <td class="TableDataStyle3">
            <asp:TextBox ID="txtRoleShortDesc" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvRoleShortDesc" runat="server" 
                ControlToValidate="txtRoleShortDesc" 
                ErrorMessage="Enter Short Description" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="TableDataStyle2">
            RoleLongDescription <span class="font">*</span></td>
        <td class="TableDataStyle3">
            <asp:TextBox ID="txtRoleLongDesc" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvRoleLongDesc" runat="server" 
                ControlToValidate="txtRoleLongDesc" ErrorMessage="Enter Long Description" 
                ForeColor="#FF3300"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="TableDataStyle2">
            &nbsp;</td>
        <td class="TableDataStyle3">
            <asp:Button ID="btnAddRole" runat="server" onclick="btnAddRole_Click" 
                Text="Add" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
