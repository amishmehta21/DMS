<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaint/LoggedIn.Master" AutoEventWireup="true" CodeBehind="DMS_SearchDocument.aspx.cs" Inherits="UserSec.DMS.SearchDocument" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainPage" runat="server">

<Table>
<tr>
<td>Search Document</td>
<td>
    <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox></td>
    <td>
        <asp:Button ID="btnSearch" runat="server" Text="Search" 
            onclick="btnSearch_Click" /></td>
</tr>
</Table>

<div>
        <asp:ListView ID="LvDocumentItems" runat="server" ItemPlaceholderID="layoutTemplate"
            DataKeyNames="DocId" InsertItemPosition="LastItem"
            OnPagePropertiesChanging="ListViewDocument_PagePropertiesChanging" 
           >
            <ItemTemplate>
                <div class="itemdisplay">
                    <tr>
                     
                        <td>
                            <%# Eval("PurchaseDept") %>
                        </td>
                        <td>
                            <%# Eval("AuthorisedBy")%>
                        </td>
                        <td>
                            <%# Eval("Purchaser")%>
                        </td>
                        <td>
                            <%# Eval("SupplierName")%>
                        </td>
                        <td>
                            <%# Eval("InvoiceDate")%>
                        </td>
                        <td>
                            <%# Eval("InvoiceNumber")%>
                        </td>
                        <td>
                            <%# Eval("InvoiceTotalAmountInRs")%>
                        </td>
                        <td>
                            <%# Eval("InvoiceTotalTaxAmountInRs")%>
                        </td>
                        <td>
                            <%# Eval("TotalNumberOfPages")%>
                        </td>
                        <td>
                            <%# Eval("ChequeBank")%>
                        </td>
                        <td>
                            <%# Eval("AccountNumber")%>
                        </td>
                        <td>
                            <%# Eval("ChequeDate")%>
                        </td>
                        <td>
                            <%# Eval("ChequeNumber")%>
                        </td>
                        <td>
                            <%# Eval("ChequeAmountInRs")%>
                        </td>
                        <td>
                            <%# Eval("TotalNumberOfLineItems")%>
                        </td>
                        <td>
                            <%# Eval("keyItems")%>
                        </td>
                        <td>
                            <%# Eval("Remarks")%>
                        </td>
                        <td>
                            <%# Eval("OtherKeywords")%>
                        </td>
                        <td>
                            <%# Eval("FileName1")%>
                        </td>
                        <td>
                            <%# Eval("FileName2")%>
                        </td>
                        <td>
                            <%# Eval("FileName3")%>
                        </td>
                        <td>
                            <%# Eval("FileName4")%>
                        </td>
                        <td>
                            <%# Eval("FileName5")%>
                        </td>
                        <td>
                            <%# Eval("FileName6")%>
                        </td>
                        <td>
                            <%# Eval("FileName7")%>
                        </td>
                        <td>
                            <%# Eval("FileName8")%>
                        </td>
                        <td>
                            <%# Eval("FileName9")%>
                        </td>
                        <td>
                            <%# Eval("FileName10")%>
                        </td>
                        <td>
                            <%# Eval("FileName11")%>
                        </td>
                        <td>
                            <%# Eval("FileName12")%>
                        </td>
                        <td>
                            <%# Eval("FileName13")%>
                        </td>
                        <td>
                            <%# Eval("FileName14")%>
                        </td>
                        <td>
                            <%# Eval("FileName15")%>
                        </td>
                        <td>
                            <%# Eval("LastModifiedAt")%>
                        </td>
                        <td>
                            <%# Eval("LastModifiedBy")%>
                        </td>
                        <td>
                            <asp:Button ID="Button1" runat="server" CommandName="Edit" Text="Edit" CommandArgument='<%# Eval("DocId") %>' />
                        </td>
                        <td>
                            <asp:Button ID="Button2" runat="server" CommandName="Delete" Text="Delete" />
                        </td>
                    </tr>
                </div>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <div class="itemdisplayalternate">
                    <tr>
                      
                        <td>
                            <%# Eval("PurchaseDept") %>
                        </td>
                        <td>
                            <%# Eval("AuthorisedBy")%>
                        </td>
                        <td>
                            <%# Eval("Purchaser")%>
                        </td>
                        <td>
                            <%# Eval("SupplierName")%>
                        </td>
                        <td>
                            <%# Eval("InvoiceDate")%>
                        </td>
                        <td>
                            <%# Eval("InvoiceNumber")%>
                        </td>
                        <td>
                            <%# Eval("InvoiceTotalAmountInRs")%>
                        </td>
                        <td>
                            <%# Eval("InvoiceTotalTaxAmountInRs")%>
                        </td>
                        <td>
                            <%# Eval("TotalNumberOfPages")%>
                        </td>
                        <td>
                            <%# Eval("ChequeBank")%>
                        </td>
                        <td>
                            <%# Eval("AccountNumber")%>
                        </td>
                        <td>
                            <%# Eval("ChequeDate")%>
                        </td>
                        <td>
                            <%# Eval("ChequeNumber")%>
                        </td>
                        <td>
                            <%# Eval("ChequeAmountInRs")%>
                        </td>
                        <td>
                            <%# Eval("TotalNumberOfLineItems")%>
                        </td>
                        <td>
                            <%# Eval("keyItems")%>
                        </td>
                        <td>
                            <%# Eval("Remarks")%>
                        </td>
                        <td>
                            <%# Eval("OtherKeywords")%>
                        </td>
                        <td>
                            <%# Eval("FileName1")%>
                        </td>
                        <td>
                            <%# Eval("FileName2")%>
                        </td>
                        <td>
                            <%# Eval("FileName3")%>
                        </td>
                        <td>
                            <%# Eval("FileName4")%>
                        </td>
                        <td>
                            <%# Eval("FileName5")%>
                        </td>
                        <td>
                            <%# Eval("FileName6")%>
                        </td>
                        <td>
                            <%# Eval("FileName7")%>
                        </td>
                        <td>
                            <%# Eval("FileName8")%>
                        </td>
                        <td>
                            <%# Eval("FileName9")%>
                        </td>
                        <td>
                            <%# Eval("FileName10")%>
                        </td>
                        <td>
                            <%# Eval("FileName11")%>
                        </td>
                        <td>
                            <%# Eval("FileName12")%>
                        </td>
                        <td>
                            <%# Eval("FileName13")%>
                        </td>
                        <td>
                            <%# Eval("FileName14")%>
                        </td>
                        <td>
                            <%# Eval("FileName15")%>
                        </td>
                        <td>
                            <%# Eval("LastModifiedAt")%>
                        </td>
                        <td>
                            <%# Eval("LastModifiedBy")%>
                        </td>
                        <td>
                            <asp:Button ID="Button1" runat="server" CommandName="Edit" Text="Edit" CausesValidation="false" />
                        </td>
                        <td>
                            <asp:Button ID="Button2" runat="server" CommandName="Delete" Text="Delete" CausesValidation="false" />
                        </td>
                    </tr>
                </div>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr class="gridalternate">
                    <%-- <td>
                        <asp:Label runat="server" ID="txtDocId" ReadOnly="true" Text='<%# Bind("DocId") %>'></asp:Label>
                    </td>--%>
                    <td>
                        <asp:TextBox runat="server" ID="txtPurchaseDept" Text='<%# Bind("PurchaseDept") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtAuthorisedBy" Text='<%# Bind("AuthorisedBy") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtPurchaser" Text='<%# Bind("Purchaser") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtSupplierName" Text='<%# Bind("SupplierName") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtInvoiceDate" Text='<%# Bind("InvoiceDate") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtInvoiceNumber" Text='<%# Bind("InvoiceNumber") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtInvoiceTotalAmountInRs" Text='<%# Bind("InvoiceTotalAmountInRs") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtInvoiceTotalTaxAmountInRs" Text='<%# Bind("InvoiceTotalTaxAmountInRs") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtTotalNumberOfPages" Text='<%# Bind("TotalNumberOfPages") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtChequeBank" Text='<%# Bind("ChequeBank") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtAccountNumber" Text='<%# Bind("AccountNumber") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtChequeDate" Text='<%# Bind("ChequeDate") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtChequeNumber" Text='<%# Bind("ChequeNumber") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtChequeAmountInRs" Text='<%# Bind("ChequeAmountInRs") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtTotalNumberOfLineItems" Text='<%# Bind("TotalNumberOfLineItems") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtkeyItems" Text='<%# Bind("keyItems") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtRemarks" Text='<%# Bind("Remarks") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtOtherKeywords" Text='<%# Bind("OtherKeywords") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFileName1" Text='<%# Bind("FileName1") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFileName2" Text='<%# Bind("FileName2") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFileName3" Text='<%# Bind("FileName3") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFileName4" Text='<%# Bind("FileName4") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFileName5" Text='<%# Bind("FileName5") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFileName6" Text='<%# Bind("FileName6") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFileName7" Text='<%# Bind("FileName7") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFileName8" Text='<%# Bind("FileName8") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFileName9" Text='<%# Bind("FileName9") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFileName10" Text='<%# Bind("FileName10") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFileName11" Text='<%# Bind("FileName11") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFileName12" Text='<%# Bind("FileName12") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFileName13" Text='<%# Bind("FileName13") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFileName14" Text='<%# Bind("FileName14") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFileName15" Text='<%# Bind("FileName15") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="txtLastModifiedAt" Text='<%# Bind("LastModifiedAt") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="txtLastModifiedBy" Text='<%# Bind("LastModifiedBy") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="Button3" runat="server" CommandName="Update" Text="Update" />
                    </td>
                    <td>
                        <asp:Button ID="Button4" runat="server" CommandName="Cancel" Text="Cancel" />
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
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="border-style: groove">
                                <tr id="Tr2" runat="server" style="">
                                    <th id="Th1" runat="server">
                                        PurchaseDept&nbsp;
                                    </th>
                                    <th id="Th2" runat="server">
                                        AuthorisedBy&nbsp;
                                    </th>
                                    <th id="Th3" runat="server">
                                        Purchaser&nbsp;
                                    </th>
                                    <th id="Th4" runat="server">
                                        SupplierName&nbsp;
                                    </th>
                                    <th id="Th5" runat="server">
                                        InvoiceDate&nbsp;
                                    </th>
                                    <th id="Th6" runat="server">
                                        InvoiceNumber&nbsp;
                                    </th>
                                    <th id="Th7" runat="server">
                                        InvoiceTotalAmountInRs&nbsp;
                                    </th>
                                    <th id="Th8" runat="server">
                                        InvoiceTotalTaxAmountInRs&nbsp;
                                    </th>
                                    <th id="Th9" runat="server">
                                        TotalNumberOfPages&nbsp;
                                    </th>
                                    <th id="Th10" runat="server">
                                        ChequeBank&nbsp;
                                    </th>
                                    <th id="Th11" runat="server">
                                        AccountNumber&nbsp;
                                    </th>
                                    <th id="Th12" runat="server">
                                        ChequeDate&nbsp;
                                    </th>
                                    <th id="Th13" runat="server">
                                        ChequeNumber&nbsp;
                                    </th>
                                    <th id="Th14" runat="server">
                                        ChequeAmountInRs&nbsp;
                                    </th>
                                    <th id="Th15" runat="server">
                                        TotalNumberOfLineItems&nbsp;
                                    </th>
                                    <th id="Th16" runat="server">
                                        keyItems&nbsp;
                                    </th>
                                    <th id="Th17" runat="server">
                                        Remarks&nbsp;
                                    </th>
                                    <th id="Th18" runat="server">
                                        OtherKeywords&nbsp;
                                    </th>
                                    <th id="Th19" runat="server">
                                        FileName1&nbsp;
                                    </th>
                                    <th id="Th20" runat="server">
                                        FileName2&nbsp;
                                    </th>
                                    <th id="Th21" runat="server">
                                        FileName3&nbsp;
                                    </th>
                                    <th id="Th22" runat="server">
                                        FileName4&nbsp;
                                    </th>
                                    <th id="Th23" runat="server">
                                        FileName5&nbsp;
                                    </th>
                                    <th id="Th24" runat="server">
                                        FileName6&nbsp;
                                    </th>
                                    <th id="Th25" runat="server">
                                        FileName7&nbsp;
                                    </th>
                                    <th id="Th26" runat="server">
                                        FileName8&nbsp;
                                    </th>
                                    <th id="Th27" runat="server">
                                        FileName9&nbsp;
                                    </th>
                                    <th id="Th28" runat="server">
                                        FileName10&nbsp;
                                    </th>
                                    <th id="Th29" runat="server">
                                        FileName11&nbsp;
                                    </th>
                                    <th id="Th30" runat="server">
                                        FileName12&nbsp;
                                    </th>
                                    <th id="Th31" runat="server">
                                        FileName13&nbsp;
                                    </th>
                                    <th id="Th32" runat="server">
                                        FileName14&nbsp;
                                    </th>
                                    <th id="Th33" runat="server">
                                        FileName15&nbsp;
                                    </th>
                                    <th id="Th34" runat="server">
                                        LastModifiedAt&nbsp;
                                    </th>
                                    <th id="Th35" runat="server">
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
        <asp:DataPager runat="server" ID="EmployeesDataPager" PageSize="3" PagedControlID="LvDocumentItems">
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
        <input id="hdnSearchField" type="hidden" runat="server" />
    </div>
</asp:Content>
