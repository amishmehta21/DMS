<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaint/LoggedIn.Master" AutoEventWireup="true" CodeBehind="CategoryList.aspx.cs" Inherits="UserSec.CategoryList" %>
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
        <asp:ListView ID="LvCategoryItems" runat="server" ItemPlaceholderID="layoutTemplate" OnItemDeleting="LvCategoryItems_ItemDeleting"
            DataKeyNames="CatId" InsertItemPosition="LastItem" OnPagePropertiesChanging="ListViewCategory_PagePropertiesChanging"
            OnItemEditing="LvCategoryItems_ItemEditing" OnItemUpdating="LvCategoryItems_ItemUpdating" OnItemCanceling="LvCategoryItems_Canceling"
           >
            <ItemTemplate>
                <div class="itemdisplay" style="vertical-align:middle">
                    
                        <tr>
                            <td>
                                <b>
                                    <%# Eval("CatId")%>&nbsp;&nbsp;</b>
                            </td>
                            <td>
                                <%# Eval("ShortDesc")%>&nbsp;
                            </td>
                            <td>
                                <%# Eval("LongDesc")%>&nbsp;
                            </td>
                            <td>
                                <%# Eval("LastModifiedAt")%>&nbsp;
                            </td>
                            <td>
                                <%# Eval("LastModifiedBy")%>&nbsp;
                            </td>
                            <td>
                                <asp:Button ID="BtnEdit" runat="server" CommandName="Edit" Text="Edit" CommandArgument='<%# Eval("CatId") %>' />
                            </td>
                            <td>
                                <asp:Button ID="BtnDelete" runat="server" CommandName="Delete" Text="Delete" />
                               
                                <%-- <asp:ModalPopupExtender ID="btnDelete_ModalPopupExtender" runat="server" TargetControlID="BtnDelete"
                                    PopupControlID="DivDeleteConfirmation" CancelControlID="OndeleteCancel" OkControlID="OnDeleteOkay">
                                </asp:ModalPopupExtender>
                                <asp:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" ConfirmText="Are you sure You want to delete?"
                                    Enabled="true" DisplayModalPopupID="btnDelete_ModalPopupExtender" TargetControlID="BtnDelete ">
                                </asp:ConfirmButtonExtender>--%>
                            </td>
                        </tr>
                    
                </div>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <div class="itemdisplayalternate">
                   
                        <tr>
                            <td>
                                <b>
                                    <%# Eval("CatId")%>&nbsp;&nbsp;
                                </b>
                            </td>
                            <td>
                                
                                    <%# Eval("ShortDesc")%>&nbsp;
                            </td>
                            <td>
                                <%# Eval("LongDesc")%>&nbsp;
                            </td>
                            <td>
                                <%# Eval("LastModifiedAt")%>&nbsp;
                            </td>
                            <td>
                                <%# Eval("LastModifiedBy")%>&nbsp;
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
                    <td><b>
                        <asp:Label runat="server" ID="txtCatId" Text='<%# Bind("CatId") %>'></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                        </b>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtShortDesc" Text='<%# Bind("ShortDesc") %>'></asp:TextBox>&nbsp;
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtlongDesc" Text='<%# Bind("LongDesc") %>'></asp:TextBox>&nbsp;
                    </td>
                    <td>
                        <asp:Label ID="txtLastModifiedAt" runat="server" Text='<%# Bind("LastModifiedAt") %>'></asp:Label>&nbsp;
                    </td>
                    <td>
                        <asp:Label ID="txtLastmodifiedBy" runat="server" Text='<%# Bind("LastModifiedBy") %>'></asp:Label>&nbsp;
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
               
                    <tr id="Tr1" runat="server">
                        <td id="Td1" runat="server">
                            <table id="itemPlaceholderContainer" runat="server" style="border-style:groove ;vertical-align:middle" border="1">
                                <tr id="Tr2" runat="server" style="">
                                    <th  id="Th1" runat="server">
                                        CatId &nbsp;
                                    </th>
                                    <th id="Th2" runat="server">
                                        ShortDesc &nbsp;
                                    </th>
                                    <th id="Th3" runat="server">
                                        LongDesc &nbsp;
                                    </th>
                                    <th id="Th4" runat="server">
                                        LastModifiedAt &nbsp;
                                    </th>
                                    <th id="Th5" runat="server">
                                        LastModifiedBy
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
                
            </LayoutTemplate>
        </asp:ListView>
        <asp:DataPager runat="server" ID="EmployeesDataPager" PageSize="3" PagedControlID="LvCategoryItems">
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
