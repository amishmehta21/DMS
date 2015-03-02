<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaint/LoggedIn.Master" AutoEventWireup="true" CodeBehind="UM_UserAdd.aspx.cs" Inherits="UserSec.UM_AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../UserMaintCSS/UM_UserAdd.css" rel="stylesheet" type="text/css" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainPage" runat="server">
<div>
    <table class="TableDatastyle1">
       
        <tr>
        <td colspan="3" class="font">(Fields marked with
         (*) are mandatory.)
        </td>
        </tr>
        <tr>
            <td class="style3">
                UserName <span class="font">*</span></td>
            <td class="style2">
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvUserName" runat="server" 
                    ControlToValidate="txtUserName" ErrorMessage="Enter UserName" 
                    ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                    FirstName <span class="font">*</span></td>
            <td class="style2">
                <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" 
                    ControlToValidate="txtFName" ErrorMessage="Enter FirstName" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                    MiddleName</td>
            <td class="style2">
                <asp:TextBox ID="txtMName" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                    LastName <span class="font">*</span></td>
            <td class="style2">
                <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvLastName" runat="server" 
                    ControlToValidate="txtLName" ErrorMessage="Enter LastName" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="style3">
                    Primary EmailID <span class="font">*</span></td>
            <td class="style2">
                <asp:TextBox ID="txtPREmailId" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvPREmailID" runat="server" 
                    ControlToValidate="txtPREmailId" ErrorMessage="Enter EmailID" 
                    ForeColor="#FF3300" 
                    
                    style="z-index: 1; left: 353px; top: 479px; position: absolute; height: 19px;"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rexPREmaiId" runat="server" 
                    ControlToValidate="txtPREmailId" ErrorMessage="Invalid Email Format" 
                    ForeColor="#FF3300" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                    Secondary EmailID</td>
            <td class="style2">
                <asp:TextBox ID="txtSCEmailId" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="rexSCEmailId" runat="server" 
                    ControlToValidate="txtSCEmailId" ErrorMessage="Invalid Email Format" 
                    ForeColor="#FF3300" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                    Mobile No</td>
            <td class="style2">
                <asp:TextBox ID="txtMobileNo" runat="server" MaxLength="10"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="rexMobileNo" runat="server" 
                    ControlToValidate="txtMobileNo" 
                    ErrorMessage="Please enter 10 digits mobile No." ForeColor="#FF3300" 
                    ValidationExpression="^[0-9]{10}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                    Address1</td>
            <td class="style2">
                <asp:TextBox ID="txtAddress1" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                    Address2</td>
            <td class="style2">
                <asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                    Street</td>
            <td class="style2">
                <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                    City</td>
            <td class="style2">
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                    State</td>
            <td class="style2">
                <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                    Country</td>
            <td class="style2">
                <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                    SecretQuestion <span class="font">*</span></td>
            <td class="style2">
                <asp:DropDownList ID="ddSecretQuest" runat="server" Height="22px" Width="169px">
                    <asp:ListItem>-Select-</asp:ListItem>
                    <asp:ListItem>What&#39;s ur college name?</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvSecretQuest" runat="server" 
                    ControlToValidate="ddSecretQuest" ErrorMessage="Select A Question" 
                    ForeColor="#FF3300" InitialValue="-Select-"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                    SecretAnswer <span class="font">*</span></td>
            <td class="style2">
                <asp:TextBox ID="txtSecretAns" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvSecretAnswer" runat="server" 
                    ControlToValidate="txtSecretAns" ErrorMessage="Answer Required" 
                    ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                    Password <span class="font">*</span></td>
            <td class="style2">
                <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvPass" runat="server" 
                    ControlToValidate="txtPass" ErrorMessage="Enter Password" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                    ConfirmPassword <span class="font">*</span></td>
            <td class="style2">
                <asp:TextBox ID="txtConfirmPass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="cvConfirmPass" runat="server" 
                    ControlToCompare="txtPass" ControlToValidate="txtConfirmPass" 
                    ErrorMessage="Password do not Match. Try again" ForeColor="#FF3300"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style2">
                <asp:Button ID="btnAdd" runat="server" Text="Add" onclick="btnAdd_Click" />
            </td>
            <td>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" 
                    onclick="btnCancel_Click" CausesValidation="False" />
            </td>
        </tr>
    </table>
</div>
</asp:Content>
