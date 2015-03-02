<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaint/LoggedIn.Master" AutoEventWireup="true" CodeBehind="CategoryAdd.aspx.cs" Inherits="UserSec.CategoryAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../DMSCSS/CategoryAdd.css" rel="stylesheet" type="text/css" />
    <link href="../DMSCSS/ErrorText.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainPage" runat="server">
<center class="center">Add Category</center><br />
    <div id="divCategoryAdd">
        <table id="Table1" runat="server">
        <tr>
        <td colspan="3" class="errortext">(Fields marked with
         (*) are mandatory.)
        </td>
        </tr>
            <tr>
                <td>
                    &nbsp;
                    Short Description   <span class="errortext">*</span></td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtCatShortDesc" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valShortDesc" runat="server" 
                        ControlToValidate="txtCatShortDesc" 
                        ErrorMessage="This field cannot be blank" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                    Long Description  <span class="errortext">*</span></td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtCatLongDesc" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valLongDesc" runat="server" 
                        ControlToValidate="txtCatLongDesc" ErrorMessage="This field cannot be blank" 
                        SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
           </tr>
             <tr>
                <td>
                    &nbsp;
                    <asp:Button ID="btnAddCategory" runat="server" Text="Add" 
                        onclick="btnAddCategory_Click" />
                </td>
                <td>
                    &nbsp;
                    <asp:Button ID="btnCancelCategory" runat="server" Text="Cancel" 
                        onclick="btnCancelCategory_Click" CausesValidation="False" />
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
           
        </table>
    </div>
</asp:Content>
