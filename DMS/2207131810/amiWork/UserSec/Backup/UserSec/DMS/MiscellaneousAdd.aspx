<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaint/LoggedIn.Master" AutoEventWireup="true" CodeBehind="MiscellaneousAdd.aspx.cs" Inherits="UserSec.DMS.MiscellaneousAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../DMSCSS/ErrorText.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainPage" runat="server">
<div>
        <table>
            <tr>
                <td colspan="3" class="errortext">
                    (Fields marked with (*) are mandatory.)
                </td>
            </tr>
            
            <tr>
                <td>
                    &nbsp; FieldName1  <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtFieldName1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ValFieldName1" runat="server" ControlToValidate="txtFieldName1"
                        ErrorMessage="This field cannot be blank" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp; FieldName2   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtFieldName2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ValFieldName2" runat="server" ControlToValidate="txtFieldName2"
                        ErrorMessage="This field cannot be blank" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp; FieldName3   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtFieldName3" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ValFieldName3" runat="server" ControlToValidate="txtFieldName3"
                        ErrorMessage="This field cannot be blank" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp; FieldName4   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtFieldName4" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ValFieldName4" runat="server" ControlToValidate="txtFieldName4"
                        ErrorMessage="This field cannot be blank" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp; FieldName5   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtFieldName5" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ValFieldName5" runat="server" ControlToValidate="txtFieldName5"
                        ErrorMessage="This field cannot be blank" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp; FieldName6   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtFieldName6" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ValFieldName6" runat="server" ControlToValidate="txtFieldName6"
                        ErrorMessage="This field cannot be blank" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp; FieldName7   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtFieldName7" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ValFieldName7" runat="server" ControlToValidate="txtFieldName7"
                        ErrorMessage="This field cannot be blank" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp; FieldName8   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtFieldName8" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ValFieldName8" runat="server" ControlToValidate="txtFieldName8"
                        ErrorMessage="This field cannot be blank" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp; FieldName9   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtFieldName9" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ValFieldName9" runat="server" ControlToValidate="txtFieldName9"
                        ErrorMessage="This field cannot be blank" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp; FieldName10   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtFieldName10" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ValFieldName10" runat="server" ControlToValidate="txtFieldName10"
                        ErrorMessage="This field cannot be blank" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp; FieldName11   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtFieldName11" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ValFieldName11" runat="server" ControlToValidate="txtFieldName11"
                        ErrorMessage="This field cannot be blank" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp; FieldName12   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtFieldName12" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ValFieldName12" runat="server" ControlToValidate="txtFieldName12"
                        ErrorMessage="This field cannot be blank" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp; FieldName13   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtFieldName13" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ValFieldName13" runat="server" ControlToValidate="txtFieldName13"
                        ErrorMessage="This field cannot be blank" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp; FieldName14   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtFieldName14" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ValFieldName14" runat="server" ControlToValidate="txtFieldName14"
                        ErrorMessage="This field cannot be blank" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
             <tr>
                <td>
                    &nbsp; FieldName15   <span class="errortext">*</span>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtFieldName15" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFieldName14"
                        ErrorMessage="This field cannot be blank" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                    <asp:Button ID="btnAddMiscellaneous" runat="server" Text="Add" OnClick="btnAddMiscellaneous_Click" />
                </td>
                <td>
                    &nbsp;
                    <asp:Button ID="btnCancelCategory" runat="server" Text="Cancel" 
                        OnClick="btnCancelCategory_Click" CausesValidation="False" />
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
