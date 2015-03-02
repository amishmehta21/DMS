<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaint/LoggedIn.Master" AutoEventWireup="true"
    CodeBehind="UM_RoleAccessRights.aspx.cs" Inherits="UserSec.UM_RoleAccessRights" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainPage" runat="server">

    <div>
  <strong>RoleDescription</strong> &nbsp; &nbsp; <asp:DropDownList ID="ddlRoleId" runat="server" OnSelectedIndexChanged="ddlRoleId_SelectedIndexChanged"
            AutoPostBack="true">
        </asp:DropDownList>
    </div>
    <asp:ListView ID="lvRoleAccessRight" runat="server" ItemPlaceholderID="layoutTemplate"
        DataKeyNames="PRAId" InsertItemPosition="LastItem" OnPagePropertiesChanging="lvRoleAccessRight_PagePropertiesChanging">
        <ItemTemplate>
            <div>
                <tr>
                    <td>
                        <asp:Label ID="lblL1Desc" runat="server" Text='<%# Eval("L1Desc")%>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblL2Desc" runat="server" Text='<%# Eval("L2Desc")%>'></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkAddRec" runat="server" Checked='<%# Eval("AddRec")%>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="chkDeleteRec" runat="server" Checked='<%# Eval("DeleteRec")%>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="chkModifyRec" runat="server" Checked='<%# Eval("ModifyRec")%>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="chkViewRec" runat="server" Checked='<%# Eval("ViewRec")%>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="chkPrintRec" runat="server" Checked='<%# Eval("PrintRec")%>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="chkSearch" runat="server" Checked='<%# Eval("Search")%>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="chkApprove" runat="server" Checked='<%# Eval("Approve")%>' />
                    </td>
                </tr>
            </div>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <div>
                <tr>
                    <td>
                        <asp:Label ID="lblL1Desc" runat="server" Text='<%# Eval("L1Desc")%>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblL2Desc" runat="server" Text='<%# Eval("L2Desc")%>'></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkAddRec" runat="server" Checked='<%# Eval("AddRec")%>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="chkDeleteRec" runat="server" Checked='<%# Eval("DeleteRec")%>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="chkModifyRec" runat="server" Checked='<%# Eval("ModifyRec")%>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="chkViewRec" runat="server" Checked='<%# Eval("ViewRec")%>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="chkPrintRec" runat="server" Checked='<%# Eval("PrintRec")%>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="chkSearch" runat="server" Checked='<%# Eval("Search")%>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="chkApprove" runat="server" Checked='<%# Eval("Approve")%>' />
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
                        <table id="itemPlaceholderContainer" runat="server" style="border-style: groove"
                            rules="all">
                            <tr id="Tr2" runat="server" style="">
                                <th id="Th1" runat="server">
                                    L1Desc
                                </th>
                                <th id="Th2" runat="server">
                                    L2Desc
                                </th>
                                <th id="Th3" runat="server">
                                    AddRecords
                                </th>
                                <th id="Th4" runat="server">
                                    DeleteRecords
                                </th>
                                <th id="Th5" runat="server">
                                    ModifyRecords
                                </th>
                                <th id="Th6" runat="server">
                                    ViewRecords
                                </th>
                                <th id="Th7" runat="server">
                                    PrintRecords
                                </th>
                                <th id="Th8" runat="server">
                                    Search
                                </th>
                                <th id="Th9" runat="server">
                                    Approve
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
    <asp:DataPager runat="server" ID="RoleAccessRightDataPager" PageSize="3" PagedControlID="lvRoleAccessRight">
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
    <input id="hdnRoleId" type="hidden" runat="server" />
    <div>
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
    </div>
</asp:Content>
