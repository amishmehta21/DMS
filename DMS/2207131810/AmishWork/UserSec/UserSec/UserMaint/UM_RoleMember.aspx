<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaint/LoggedIn.Master" AutoEventWireup="true" CodeBehind="UM_RoleMember.aspx.cs" Inherits="UserSec.UM_RoleMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../UserMaintCSS/UM_displayNone.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainPage" runat="server">
<div>
 <strong>RoleDescription</strong> &nbsp; &nbsp;  <asp:DropDownList ID="ddlRoleId" runat="server" OnSelectedIndexChanged="ddlRoleId_SelectedIndexChanged"  AutoPostBack="true">
    </asp:DropDownList>

</div>
<asp:ListView ID="lvRoleMember" runat="server" ItemPlaceholderID="layoutTemplate"  
   OnItemCommand="lvRoleMember_OnItemCommand" OnItemDataBound="lvRoleMember_ItemDataBound"
        DataKeyNames="UserId" InsertItemPosition="LastItem" OnPagePropertiesChanging="lvRoleMember_PagePropertiesChanging"
       >
        <ItemTemplate>
            <div>
                <tr>
                    <td class="none" >
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
                        <%# Eval("MobileNo")%>
                    </td>
                     <td class="none">
                        <%# Eval("IsMember")%>
                    </td>
                     <td class="none">
                        <%# Eval("RoleIdSelected")%>
                    </td>
                    <td>
                        <asp:Button ID="btnAdd" runat="server" CommandName="Add" Text="Add" CommandArgument='<%# Eval("UserId")+","+Eval("RoleIdSelected") %>' />
                   
                        <asp:Button ID="btnRemove" runat="server" CommandName="Remove" Text="Remove" CommandArgument='<%# Eval("UserId")+","+Eval("RoleIdSelected") %>'    />
                    </td>
                </tr>
            </div>
        </ItemTemplate>
        <AlternatingItemTemplate>
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
                        <%# Eval("MobileNo")%>
                    </td>
                  <td class="none">
                        <%# Eval("IsMember")%>
                    </td>
                     <td class="none">
                        <%# Eval("RoleIdSelected")%>
                    </td>
                    <td>
                        <asp:Button ID="btnAdd" runat="server" CommandName="Add" Text="Add" CommandArgument='<%# Eval("UserId")+","+Eval("RoleIdSelected") %>'   />
                    
                        <asp:Button ID="btnRemove" runat="server" CommandName="Remove" Text="Remove" CommandArgument='<%# Eval("UserId")+","+Eval("RoleIdSelected") %>'   />
                    </td>
                </tr>
            </div>
        </AlternatingItemTemplate>
        <EditItemTemplate>
           <%-- <tr class="gridalternate">
                <td>
                    <asp:Label runat="server" ID="lblUserId" Text='<%# Bind("UserId") %>'></asp:Label>
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
                    <asp:Button ID="btnUpdate" runat="server" CommandName="Update" Text="Update" />
                </td>
                <td>
                    <asp:Button ID="btnCancel" runat="server" CommandName="Cancel" Text="Cancel" />
                </td>
            </tr>--%>
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
                               
                                <th id="Th8" runat="server">
                                    MobileNo.
                                </th>
                                 <th id="Th9" runat="server" class="none">
                                    IsMember
                                </th>
                                 <th id="Th7" runat="server" class="none">
                                    RoleIdSelected
                                </th>
                            </tr>
                            <tr id="layoutTemplate" runat="server" >
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
    <asp:DataPager runat="server" ID="RoleMemberDataPager" PageSize="3" PagedControlID="lvRoleMember">
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
    <input id="hdnRoleId" type="hidden"  runat="server" />
</asp:Content>
