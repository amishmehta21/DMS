<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaint/LoggedIn.Master" AutoEventWireup="true"
    CodeBehind="UM_UserList.aspx.cs" Inherits="UserSec.UserMaint.UM_UserList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../js/UM_ConfirmDelete.js" type="text/javascript"></script>
    <link href="../UserMaintCSS/UM_displayNone.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainPage" runat="server">

<div><strong>Select No. of Records</strong> &nbsp; &nbsp;
    <asp:DropDownList ID="ddlPageSize" runat="server" OnSelectedIndexChanged="OnPageSizeChange" AutoPostBack="true">
        <asp:ListItem>-Select-</asp:ListItem>
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
        <asp:ListItem>6</asp:ListItem>
    </asp:DropDownList>
</div>

    <asp:ListView ID="lvUserList" runat="server" ItemPlaceholderID="layoutTemplate" OnItemDeleting="lvUserList_ItemDeleting"
        DataKeyNames="UserId" InsertItemPosition="LastItem" OnPagePropertiesChanging="lvUserList_PagePropertiesChanging"
        OnItemEditing="lvUserList_ItemEditing" OnItemUpdating="lvUserList_ItemUpdating" OnItemCanceling="lvUserList_Canceling"
        >
        <ItemTemplate>
            <div>
                <tr>
                    <td class="none">
                        <b>
                            <%# Eval("UserId")%></b>
                    </td>
                    <td>
                        <b>
                            <%# Eval("UserName")%></b>
                    </td>
                    <td>
                        <%# Eval("FirstName")%>
                    </td>
                    <td>
                        <%# Eval("MiddleName")%>
                    </td>
                    <td>
                        <%# Eval("LastName")%>
                    </td>
                    <td>
                        <%# Eval("PrimaryEmailID")%>
                    </td>
                    <td>
                        <%# Eval("SecondaryEmailID")%>
                    </td>
                    <td>
                        <%# Eval("MobileNo")%>
                    </td>
                    <td>
                        <%# Eval("Address1")%>
                    </td>
                    <td>
                        <%# Eval("Address2")%>
                    </td>
                    <td>
                        <%# Eval("Street")%>
                    </td>
                    <td>
                        <%# Eval("City")%>
                    </td>
                    <td>
                        <%# Eval("State1")%>
                    </td>
                    <td>
                        <%# Eval("Country")%>
                    </td>
                    <td>
                        <%# Eval("SecretQuest")%>
                    </td>
                    <td>
                        <%# Eval("SecretAns")%>
                    </td>
                    <td>
                        <%# Eval("Pass")%>
                    </td>
                      <td>
                        <%# Eval("LastModifiedBy")%>
                    </td>
                    <td>
                        <%# Eval("LastModifiedAt")%>
                    </td>
                    <td>
                        <asp:Button ID="btnEdit" runat="server" CommandName="Edit" Text="Edit" CommandArgument='<%# Eval("UserId") %>' />
                    </td>
                    <td>
                        <asp:Button ID="btnDelete" runat="server" CommandName="Delete" Text="Delete" OnClientClick="Confirm()"  />
                    </td>
                </tr>
            </div>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <div >
                <tr>
                    <td class="none">
                        <b>
                            <%# Eval("UserId")%></b>
                    </td>
                    <td>
                        <b>
                            <%# Eval("UserName")%></b>
                    </td>
                    <td>
                        <%# Eval("FirstName")%>
                    </td>
                    <td>
                        <%# Eval("MiddleName")%>
                    </td>
                    <td>
                        <%# Eval("LastName")%>
                    </td>
                    <td>
                        <%# Eval("PrimaryEmailID")%>
                    </td>
                    <td>
                        <%# Eval("SecondaryEmailID")%>
                    </td>
                    <td>
                        <%# Eval("MobileNo")%>
                    </td>
                    <td>
                        <%# Eval("Address1")%>
                    </td>
                    <td>
                        <%# Eval("Address2")%>
                    </td>
                    <td>
                        <%# Eval("Street")%>
                    </td>
                    <td>
                        <%# Eval("City")%>
                    </td>
                    <td>
                        <%# Eval("State1")%>
                    </td>
                    <td>
                        <%# Eval("Country")%>
                    </td>
                    <td>
                        <%# Eval("SecretQuest")%>
                    </td>
                    <td>
                        <%# Eval("SecretAns")%>
                    </td>
                    <td>
                        <%# Eval("Pass")%>
                    </td>
                     <td>
                        <%# Eval("LastModifiedBy")%>
                    </td>
                    <td>
                        <%# Eval("LastModifiedAt")%>
                    </td>
                    <td>
                        <asp:Button ID="btnEdit" runat="server" CommandName="Edit" Text="Edit" CausesValidation="false" />
                    </td>
                    <td>
                        <asp:Button ID="btnDelete" runat="server" CommandName="Delete" Text="Delete" CausesValidation="false" />
                    </td>
                </tr>
            </div>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <tr>
                <td class="none">
                    <asp:Label runat="server" ID="lbUserId"  Text='<%# Bind("UserId") %>'></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ID="lbUserName" Text='<%# Bind("UserName") %>'></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtFName" Text='<%# Bind("FirstName") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtMName" Text='<%# Bind("MiddleName") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtLName"  Text='<%# Bind("LastName") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtPREmailId" Text='<%# Bind("PrimaryEmailId") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtSCEmailId" Text='<%# Bind("SecondaryEmailId") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtMobileNo" Text='<%# Bind("MobileNo") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtAddress1" Text='<%# Bind("Address1") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtAddress2" Text='<%# Bind("Address2") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtStreet" Text='<%# Bind("Street") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtCity" Text='<%# Bind("City") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtState1" Text='<%# Bind("State1") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtCountry" Text='<%# Bind("Country") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtSecretQuest" Text='<%# Bind("SecretQuest") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtSecretAns" Text='<%# Bind("SecretAns") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtPass" Text='<%# Bind("Pass") %>'></asp:TextBox>
                </td>
                 <td>
                    <asp:Label runat="server" ID="lblLastModifiedBy" Text='<%# Bind("LastModifiedBy") %>'></asp:Label>
                </td>
                 <td>
                    <asp:Label runat="server" ID="lblLastModofiedAt" Text='<%# Bind("LastModifiedAt") %>'></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" CommandName="Update" Text="Update" />
                </td>
                <td>
                    <asp:Button ID="btnCancel" runat="server" CommandName="Cancel" Text="Cancel" />
                </td>
            </tr>
        </EditItemTemplate>
        <InsertItemTemplate>
            <%--<div style="background: Yellow">
                    <asp:TextBox runat="server" ID="txtRoleShortDesc" Text='<%# Bind("RoleShortDesc") %>'></asp:TextBox>
                    <br />
                    <asp:TextBox runat="server" ID="txtRoleLongDesc" Text='<%# Bind("RoleLongDesc") %>'></asp:TextBox>
                    <br />
                </div>
                <asp:Button ID="Button3" runat="server" CommandName="Insert" Text="Insert" />
                <asp:Button ID="Button4" runat="server" CommandName="Cancel" Text="Cancel" /><br />--%>
        </InsertItemTemplate>
        <LayoutTemplate>
            <table id="Table1" runat="server">
                <tr id="Tr1" runat="server">
                    <td id="Td1" runat="server">
                        <table id="itemPlaceholderContainer" runat="server" style="border-style: groove" rules="all">
                            <tr id="Tr2" runat="server" style="">
                                <th id="Th1" runat="server" class="none">
                                    UserId
                                </th>
                                <th id="Th2" runat="server">
                                    UserName
                                </th>
                                <th id="Th3" runat="server">
                                    FirstName
                                </th>
                                <th id="Th4" runat="server">
                                    MiddleName
                                </th>
                                <th id="Th5" runat="server">
                                    LastName
                                </th>
                                <th id="Th6" runat="server">
                                    PrimaryEmailId
                                </th>
                                <th id="Th7" runat="server">
                                    SecondaryEmailID
                                </th>
                                <th id="Th8" runat="server">
                                    MobileNo.
                                </th>
                                <th id="Th9" runat="server">
                                    Address1
                                </th>
                                <th id="Th10" runat="server">
                                    Address2
                                </th>
                                <th id="Th11" runat="server">
                                    Street
                                </th>
                                <th id="Th12" runat="server">
                                    City
                                </th>
                                <th id="Th13" runat="server">
                                    State
                                </th>
                                <th id="Th14" runat="server">
                                    Country
                                </th>
                                <th id="Th15" runat="server">
                                    SecretQuestion
                                </th>
                                <th id="Th16" runat="server">
                                    SecretAnswer
                                </th>
                                <th id="Th17" runat="server">
                                    Password
                                </th>
                                <th id="Th18" runat="server">
                                    LastModifiedBy
                                </th>
                                <th id="Th19" runat="server">
                                    LastModifiedAt
                                </th>

                            </tr>
                            <tr id="layoutTemplate" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr id="Tr3" runat="server">
                    <td id="Td2" runat="server" style="">
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
    </asp:ListView>
    <asp:DataPager runat="server" ID="EmployeesDataPager" PageSize="3" PagedControlID="lvUserList">
        <Fields>
            <asp:TemplatePagerField>
                <PagerTemplate>
                    &nbsp;
                    <asp:TextBox ID="CurrentRowTextBox" runat="server" AutoPostBack="true" Text="<%# Container.StartRowIndex + 1%>"
                        Columns="2" OnTextChanged="CurrentRowTextBox_OnTextChanged" />
                    to
                    <asp:Label ID="PageSizeLabel" runat="server" Font-Bold="true" Text="<%# Container.StartRowIndex + Container.PageSize > Container.TotalRowCount ? Container.TotalRowCount : Container.StartRowIndex + Container.PageSize %>" />
                    of
                    <asp:Label ID="TotalRowsLabel" runat="server" Font-Bold="true" Text="<%# Container.TotalRowCount %>" />
                </PagerTemplate>
            </asp:TemplatePagerField>
            <asp:NextPreviousPagerField ShowFirstPageButton="true" ShowLastPageButton="true"
                FirstPageText="|<< " LastPageText=" >>|" NextPageText=" > " PreviousPageText=" < " />
        </Fields>
    </asp:DataPager>
</asp:Content>
