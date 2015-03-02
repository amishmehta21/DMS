<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaint/LoggedIn.Master" AutoEventWireup="true" CodeBehind="SubCategoryList.aspx.cs" Inherits="UserSec.DMS.SubCategoryList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
<div>
     <asp:ListView ID="LvSubCategoryItems" runat="server" ItemPlaceholderID="layoutTemplate" OnItemDeleting="LvSubCategoryItems_ItemDeleting"
            DataKeyNames="SubCatId" InsertItemPosition="LastItem" OnPagePropertiesChanging="ListViewSubCategory_PagePropertiesChanging"
            OnItemEditing="LvSubCategoryItems_ItemEditing" OnItemUpdating="LvSubCategoryItems_ItemUpdating" OnItemCanceling="LvSubCategoryItems_Canceling"
            OnSelectedIndexChanged="LvSubCategoryItems_SelectedIndexChanged" OnItemCommand="lvItemRowCommand">
            <ItemTemplate>
                <div class="itemdisplay">
                    <tr>
                    <td>
                            <b>
                                <%# Eval("SubCatId ")%></b>
                        </td>
                        <td>
                            <b>
                                <%# Eval("CatId ")%></b>
                        </td>
                        <td>
                           
                                <%# Eval("ShortDesc ")%>
                        </td>
                        <td>
                            <%# Eval("LongDesc ")%>
                        </td>
                         <td>
                            <%# Eval("LastModifiedAt ")%>
                        </td>
                        <td>
                            <%# Eval("LastModifiedBy ")%>
                        </td>
                        <td>
                            <asp:Button ID="BtnEdit" runat="server" CommandName="Edit" Text="Edit" CommandArgument='<%# Eval("SubCatId") %>' />
                        </td>
                        <td>
                            <asp:Button ID="BtnDelete" runat="server" CommandName="Delete" Text="Delete" />
                        </td>
                    </tr>
                </div>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <div class="itemdisplayalternate">
                    <tr>
                        <td>
                            <b>
                                <%# Eval("SubCatId ")%></b>
                        </td>
                         <td>
                            <b>
                                <%# Eval("CatId ")%></b>
                        </td>
                        <td>
                            
                                <%# Eval("ShortDesc ")%>
                        </td>
                        <td>
                            <%# Eval("LongDesc ")%>
                        </td>
                        <td>
                            <%# Eval("LastModifiedAt ")%>
                        </td>
                        <td>
                            <%# Eval("LastModifiedBy ")%>
                        </td>
                        <td>
                            <asp:Button ID="BtnEdit" runat="server" CommandName="Edit" Text="Edit" CausesValidation="false" />
                        </td>
                        <td>
                            <asp:Button ID="BtnDelete" runat="server" CommandName="Delete" Text="Delete" CausesValidation="false" />
                        </td>
                    </tr>
                </div>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr class="gridalternate">
                    <td>
                        <asp:Label runat="server" ID="txtCatId" Text='<%# Bind("SubCatId") %>'></asp:Label>
                    </td>
                     <td>
                        <asp:Label runat="server" ID="Label1" Text='<%# Bind("CatId") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtShortDesc" Text='<%# Bind("ShortDesc") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtlongDesc" Text='<%# Bind("LongDesc") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="txtLastModifiedAt" Text='<%# Bind("LastModifiedAt") %>'></asp:Label>
                    </td>
                     <td>
                        <asp:Label runat="server" ID="txtlastModifiedBy" Text='<%# Bind("LastModifiedBy") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="BtnUpdate" runat="server" CommandName="Update" Text="Update" />
                    </td>
                    <td>
                        <asp:Button ID="BtnCancel" runat="server" CommandName="Cancel" Text="Cancel" />
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
                            <table id="itemPlaceholderContainer" runat="server" style="border-style:groove" border="1">
                                <tr id="Tr2" runat="server" style="">
                                    <th id="Th1" runat="server">
                                        SubCatId
                                    </th>
                                    <th id="Th2" runat="server">
                                        CatId
                                    </th>
                                    <th id="Th3" runat="server">
                                        ShortDesc
                                    </th>
                                    <th id="Th4" runat="server">
                                        LongDesc
                                    </th>
                                     <th id="Th5" runat="server">
                                        LastModifiedAt
                                    </th>
                                     <th id="Th6" runat="server">
                                        LastModifiedBy
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
        <asp:DataPager runat="server" ID="EmployeesDataPager" PageSize="3" PagedControlID="LvSubCategoryItems">
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
    </div>
</asp:Content>
