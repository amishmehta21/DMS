<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaint/LoggedIn.Master" AutoEventWireup="true"
    CodeBehind="SearchDocument.aspx.cs" Inherits="UserSec.DMS.SearchDocument"  EnableViewState="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainPage" runat="server">
    <center>
        Search Document</center>
    <div id="divsearchdocument">
    </div>
    <table>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblCategoryId" runat="server" Text="Select CategoryId"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlCatId" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblSubCategoryId" runat="server" Text="Select SubCategoryId"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlSubCatId" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblPurchaseDept" runat="server" Text="Purchase Dept"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPurchaseDept" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblAuthorisedBy" runat="server" Text="Authorised By"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAuthorisedBy" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblPurchaser" runat="server" Text="Purchaser"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPurchaser" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblInvoiceDate" runat="server" Text="Invoce Date"></asp:Label>
            </td>
            <td>
                <strong>From Date:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtFrmInvoiceDate" runat="server"></asp:TextBox>
            </td>
            <td>
                <strong>To Date:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtToInvoiceDate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblInvoiceNo" runat="server" Text="Invoce Number"></asp:Label>
            </td>
            <td>
                <strong>From Number:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtFrmInvoiceNo" runat="server"></asp:TextBox>
            </td>
            <td>
                <strong>To Number:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtToInvoiceNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblInvoiceTotalAmtInRs" runat="server" Text="Invoce Total Amount In Rs"></asp:Label>
            </td>
            <td>
                <strong>From Rs:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtFrmInvoiceTotalAmtInRs" runat="server"></asp:TextBox>
            </td>
            <td>
                <strong>To Rs:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtToInvoiceTotalAmtInRs" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Invoce Total Tax Amount In Rs"></asp:Label>
            </td>
            <td>
                <strong>From Rs:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtFrmInvoiceTotalTaxAmtInRs" runat="server"></asp:TextBox>
            </td>
            <td>
                <strong>To Rs:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtToInvoiceTotalTaxAmtInRs" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTotalNumberOfPages" runat="server" Text="Total Number Of Pages"></asp:Label>
            </td>
            <td>
                <strong>From Number:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtFrmTotalNumberOfPages" runat="server"></asp:TextBox>
            </td>
            <td>
                <strong>ToNumber:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtToTotalNumberOfPages" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblChequeBank" runat="server" Text="Cheque Bank"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtChequeBank" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblAccountNumber" runat="server" Text="Account Number"></asp:Label>
            </td>
          
            
            <td>
                <asp:TextBox ID="txtAccountNumber" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblChequeDate" runat="server" Text="Cheque Date"></asp:Label>
            </td>
            <td>
                <strong>From Date:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtFrmChequeDate" runat="server"></asp:TextBox>
            </td>
            <td>
                <strong>To Date:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtToChequeDate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblChequeNo" runat="server" Text="Cheque Number"></asp:Label>
            </td>
            
            <td>
                <asp:TextBox ID="txtChequeNumber" runat="server"></asp:TextBox>
            </td>
           
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblChequeAmountInRs" runat="server" Text="Cheque Amount Amount In Rs"></asp:Label>
            </td>
            <td>
                <strong>From Rs:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtFrmChequeAmountInRs" runat="server"></asp:TextBox>
            </td>
            <td>
                <strong>To Rs:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtToChequeAmountInRs" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTotalNumberOfLineItems" runat="server" Text="Total Number Of Line Items"></asp:Label>
            </td>
            <td>
                <strong>From Number:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtFrmTotalNumberOfLineItems" runat="server"></asp:TextBox>
            </td>
            <td>
                <strong>ToNumber:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtToTotalNumberOfLineItems" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblKeyItems" runat="server" Text="KeyItems"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtKeyItems" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblRemarks" runat="server" Text="Remarks"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRemarks" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblOtherKeywords" runat="server" Text="OtherKeywords"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtOtherKeywords" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblFileName" runat="server" Text="FileName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFileName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="5">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td align="center" colspan="5">
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CausesValidation="false"
                    OnClick="btnCancel_Click" />
            </td>
        </tr>
    </table>
    <table>
        
            <asp:ListView ID="LvDocumentItems" runat="server" ItemPlaceholderID="layoutTemplate"
                DataKeyNames="DocId">
                <ItemTemplate>
                    <div class="itemdisplay">
                        <tr>
                            <%--<td class="none">
                            <b>
                                <%# Eval("DocId ")%></b>
                        </td>
                        <td class="none">
                            <b>
                                <%# Eval("CatId ")%></b>
                        </td>
                        <td class="none">
                            <%# Eval("SubcatId ")%>
                        </td>--%>
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
                            <%-- <td class="none">
                            <b>
                                <%# Eval("DocId ")%></b>
                        </td>
                        <td class="null">
                            <b>
                                <%# Eval("CatId ")%></b>
                        </td>
                        <td class="null">
                            <%# Eval("SubcatId ")%>
                        </td>--%>
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
                        </tr>
                    </div>
                </AlternatingItemTemplate>
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
           <%-- <asp:DataPager runat="server" ID="searchDocumentDataPager" PageSize="3" PagedControlID="LvDocumentItems">
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
       --%>
    </table>
</asp:Content>
