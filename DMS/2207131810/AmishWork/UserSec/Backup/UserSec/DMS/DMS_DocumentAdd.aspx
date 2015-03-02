<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaint/LoggedIn.Master" AutoEventWireup="true" CodeBehind="DMS_DocumentAdd.aspx.cs" Inherits="UserSec.DMS.DocumentAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../DMSCSS/DocumentAdd.css" rel="stylesheet" type="text/css" />
    <link href="../DMSCSS/ErrorText.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainPage" runat="server">
<div id="DivDocumentAdd">
    
        <table>
         <tr>
        <td colspan="3" class="errortext">(Fields marked with
         (*) are mandatory.)
        </td>
        </tr>
          <tr>
                <td>
                    Category Id    <span class="errortext">*</span></td>
                <td>
                    <asp:DropDownList ID="ddlCatId" runat="server" >
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valCatId" runat="server" 
                        ControlToValidate="ddlCatId" EnableTheming="False" 
                        ErrorMessage="*" SetFocusOnError="True" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    SubCategory Id    <span class="errortext">*</span></td>
                <td>
                    <asp:DropDownList ID="ddlSubCatId" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valSubCatId" runat="server" 
                        ControlToValidate="ddlSubCatId" ErrorMessage="*" 
                        SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
             <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
             <tr>
                <td colspan="3" >
                    <b class="bold">Purchase Details:</b></td>
                
            </tr>
             <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Purchase Department    <span class="errortext">*</span></td>
                <td>
                    <asp:TextBox ID="txtPurchaseDept" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valPurchaseDept" runat="server" 
                        ControlToValidate="txtPurchaseDept" 
                        ErrorMessage="This Field cannot be blank" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Authorized By</td>
                <td>
                    <asp:TextBox ID="txtAuthBy" runat="server"></asp:TextBox>
                </td>
                <td>
                    </td>
            </tr>
            <tr>
                <td>
                    Purchaser    <span class="errortext">*</span></td>
                <td>
                    <asp:TextBox ID="txtPurchaser" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valPurchaser" runat="server" 
                        ControlToValidate="txtPurchaser" ErrorMessage="This field cannot be blank" 
                        SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Supplier Name    <span class="errortext">*</span></td>
                <td>
                    <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valSupName" runat="server" 
                        ControlToValidate="txtSupplierName" ErrorMessage="This Field cannot be blank" 
                        SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>

            </tr>
             <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <b class="bold">Invoice Details:</b></td>
                
            </tr>
             <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Invoice Date</td>
                <td>
                    <asp:Calendar ID="dtInvoiceDate" runat="server" BackColor="White" 
                        BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" 
                        Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" 
                        Width="330px" SelectedDate="2013-06-26">
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                            Height="8pt" />
                        <DayStyle BackColor="#CCCCCC" />
                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" 
                            Font-Size="12pt" ForeColor="White" Height="12pt" />
                        <TodayDayStyle BackColor="#999999" ForeColor="White" />
                    </asp:Calendar>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Invoice Number   <span class="errortext">*</span></td>
                <td>
                    <asp:TextBox ID="txtInvoiceNum" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valInvoiceNum" runat="server" 
                        ControlToValidate="txtInvoiceNum" ErrorMessage="This Field cannot be blank" 
                        SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Invoice Total Amount In Rs.</td>
                <td>
                    <asp:TextBox ID="txtInvoiceTotalAmt" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Invoice Total Tax Amount In Rs.</td>
                <td>
                    <asp:TextBox ID="txtInvoiceTotalTaxAmt" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Total Number Of Pages</td>
                <td>
                    <asp:TextBox ID="txtTotalNumOfPages" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
             <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <b class="b">Cheque Details:</b></td>
                
            </tr>
             <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Cheque Bank    <span class="errortext">*</span></td>
                <td>
                    <asp:TextBox ID="txtChequeBank" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valChequeBank" runat="server" 
                        ControlToValidate="txtChequeBank" ErrorMessage="This field cannot be blank" 
                        SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Account Number   <span class="errortext">*</span></td>
                <td>
                    <asp:TextBox ID="txtAcctNum" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valAcctNum" runat="server" 
                        ControlToValidate="txtAcctNum" ErrorMessage="This Field cannot be blank" 
                        SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Cheque Date</td>
                <td>
                    <asp:Calendar ID="dtChequeDate" runat="server" BackColor="White" 
                        BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" 
                        Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" 
                        Width="330px" SelectedDate="2013-06-26">
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                            Height="8pt" />
                        <DayStyle BackColor="#CCCCCC" />
                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" 
                            Font-Size="12pt" ForeColor="White" Height="12pt" />
                        <TodayDayStyle BackColor="#999999" ForeColor="White" />
                    </asp:Calendar>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Cheque Number    <span class="errortext">*</span></td>
                <td>
                    <asp:TextBox ID="txtChequeNum" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valChequeNum" runat="server" 
                        ControlToValidate="txtChequeNum" ErrorMessage="This field cannot be blank" 
                        SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Cheque Amount In Rs.</td>
                <td>
                    <asp:TextBox ID="txtChequeAmt" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
             <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <b class="b">Other Details:</b></td>
                
            </tr>
             <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Total Number Of Line Items</td>
                <td>
                    <asp:TextBox ID="txtTotalNumOfLinedItems" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Key Items</td>
                <td>
                    <asp:TextBox ID="txtKeyItems" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Remarks</td>
                <td>
                    <asp:TextBox ID="txtRemarks" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Other Keywords</td>
                <td>
                    <asp:TextBox ID="txtOtherKeywords" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
             
            <tr>
                <td>
                    File1   <span class="errortext">*</span></td>
                <td>
                    <asp:FileUpload ID="flName1" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valFile1" runat="server" 
                        ControlToValidate="flName1" ErrorMessage="This Field cannot be blank" 
                        SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
           <tr>
                <td>
                    File2</td>
                <td>
                    <asp:FileUpload ID="flName2" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    File3</td>
                <td>
                    <asp:FileUpload ID="flName3" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    File4</td>
                <td>
                    <asp:FileUpload ID="flName4" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    File5</td>
                <td>
                    <asp:FileUpload ID="flName5" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    File6</td>
                <td>
                    <asp:FileUpload ID="flName6" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    File7</td>
                <td>
                    <asp:FileUpload ID="flName7" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    File8</td>
                <td>
                    <asp:FileUpload ID="flName8" runat="server" />
                </td>
                <td>
                    
                </td>
                </tr>
                <tr>
               <td>
                    File9</td>
                <td>
                    <asp:FileUpload ID="flName9" runat="server" />
                </td>
                <td>

                    &nbsp;</td>
</tr>
<tr>
                <td>
                    File10</td>
                <td>
                    <asp:FileUpload ID="flName10" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    File11</td>
                <td>
                    <asp:FileUpload ID="flName11" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    File12</td>
                <td>
                    <asp:FileUpload ID="flName12" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
                </tr>
                <tr><td>
                    File13</td>
                <td>
                    <asp:FileUpload ID="flName13" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    File14</td>
                <td>
                    <asp:FileUpload ID="flName14" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    File15</td>
                <td>
                    <asp:FileUpload ID="flName15" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
           
            <tr>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Text="Add" onclick="btnAdd_Click" />
                </td>
                <td>
                    <asp:Button ID="btnCancel" runat="server" onclick="btnCancel_Click" 
                        Text="Cancel" CausesValidation="False" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
          
        </table>
    
    </div>
</asp:Content>
