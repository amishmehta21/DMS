<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaint/LoggedIn.Master" AutoEventWireup="true" CodeBehind="DMS_SubCategoryAdd.aspx.cs" Inherits="UserSec.DMS.SubCategoryAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../DMSCSS/SubCategoryAdd.css" rel="stylesheet" type="text/css" />
    <link href="../DMSCSS/ErrorText.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainPage" runat="server">
<center class="center">
        Add Sub Category</center>
    <br />
    <div id="divSubCatAdd">
        <table>
        <tr>
        <td colspan="3" class="errortext">(Fields marked with
         (*) are mandatory.)
        </td>
        </tr>
            <tr>
                <td>
                    &nbsp; Category Id   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:DropDownList ID="ddlCategory" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valCatId" runat="server" ErrorMessage="This field Cannot be blank"
                        SetFocusOnError="True" ControlToValidate="ddlCategory" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp; Short Description   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtSubCatShortDesc" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valShortDesc" runat="server" ErrorMessage="This field cannot be blank"
                        SetFocusOnError="True" ControlToValidate="txtSubCatShortDesc" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp; Long Description   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtSubCatLongDesc" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valLongDesc" runat="server" ErrorMessage="RequiredFieldValidator"
                        SetFocusOnError="True" ControlToValidate="txtSubCatLongDesc" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                    <asp:Button ID="btnAddSubCategory" runat="server" Text="Add" OnClick="btnAddSubCategory_Click" />
                </td>
                <td>
                    &nbsp;
                    <asp:Button ID="btnCancelSubCategory" runat="server" Text="Cancel" 
                        OnClick="btnCancelSubCategory_Click" CausesValidation="False" />
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
