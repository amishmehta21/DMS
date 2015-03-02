<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaint/LoggedIn.Master" AutoEventWireup="true"
    CodeBehind="UM_RoleList.aspx.cs" Inherits="UserSec.UM_RoleList" %>

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
    <asp:ListView ID="lvItems" runat="server" ItemPlaceholderID="layoutTemplate" OnItemDeleting="lvItems_ItemDeleting"
        DataKeyNames="RoleId" InsertItemPosition="LastItem" OnPagePropertiesChanging="ListView1_PagePropertiesChanging"
        OnItemEditing="lvItems_ItemEditing" OnItemUpdating="lvItems_ItemUpdating" OnItemCanceling="lvItems_Canceling"
        OnSelectedIndexChanged="lvItems_SelectedIndexChanged" OnItemCommand="lvItemRowCommand">
        <ItemTemplate>
            <div>
                <tr>
                    <td class="none">
                        <b>
                            <%# Eval("RoleId")%></b>
                    </td>
                    <td>
                        <b>
                            <%# Eval("RoleShortDesc")%></b>
                    </td>
                    <td>
                        <%# Eval("RoleLongDesc")%>
                    </td>
                    <td>
                        <%# Eval("LastModifiedBy")%>
                    </td>
                    <td>
                        <%# Eval("LastModifiedAt")%>
                    </td>
                    <td>
                        <asp:Button ID="btnEdit" runat="server" CommandName="Edit" Text="Edit" CommandArgument='<%# Eval("RoleId") %>' />
                    </td>
                    <td>
                        <asp:Button ID="btnDelete" runat="server" CommandName="Delete" Text="Delete" OnClientClick="Confirm()" />
                    </td>
                </tr>
            </div>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <div >
                <tr>
                    <td class="none">
                        <b>
                            <%# Eval("RoleId")%></b>
                    </td>
                    <td>
                        <b>
                            <%# Eval("RoleShortDesc")%></b>
                    </td>
                    <td>
                        <%# Eval("RoleLongDesc")%>
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
            <tr >
                <td class="none">
                    <asp:Label runat="server" ID="lbRoleId" Text='<%# Bind("RoleId") %>'></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtRoleShortDesc" Text='<%# Bind("RoleShortDesc") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtRolelongDesc" Text='<%# Bind("RoleLongDesc") %>'></asp:TextBox>
                </td>
                <td>
                    <asp:Label runat="server" ID="lbLastModifiedBy" Text='<%# Bind("LastModifiedBy") %>'></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ID="lbLastModifiedAt" Text='<%# Bind("LastModifiedAt") %>'></asp:Label>
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
                                    RoleId
                                </th>
                                <th id="Th2" runat="server">
                                    RoleShortDesc
                                </th>
                                <th id="Th3" runat="server">
                                    RoleLongDesc
                                </th>
                                <th id="Th4" runat="server">
                                    LastModifiedBy
                                </th>
                                <th id="Th5" runat="server">
                                    LastModifiedAt
                                </th>
                            </tr>
                            <tr id="layoutTemplate" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr id="Tr3" runat="server">
                    <td id="Td2" runat="server">
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
    </asp:ListView>
    <asp:DataPager runat="server" ID="RoleDataPager" PageSize="3" PagedControlID="lvItems">
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
                       page
                        <asp:DropDownList ID="ddlPageJump" runat="server" AutoPostBack="true" OnSelectedIndexChanged="PageJump_SelectedIndexChanged">
                        </asp:DropDownList>
                        of
                        <asp:Label ID="TotalPageNoLabel" runat="server" Text="<%#(int) Math.Ceiling(Convert.ToDecimal(RoleDataPager.TotalRowCount) / Convert.ToDecimal(RoleDataPager.PageSize)) %>" >
                        </asp:Label>
                </PagerTemplate>
            </asp:TemplatePagerField>
            <asp:NextPreviousPagerField ShowFirstPageButton="true" ShowLastPageButton="true"
                FirstPageText="|<< " LastPageText=" >>|" NextPageText=" > " PreviousPageText=" < " />
        </Fields>
    </asp:DataPager>
</asp:Content>
