<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaint/LoggedIn.Master" AutoEventWireup="true" CodeBehind="MiscellaneousList.aspx.cs" Inherits="UserSec.DMS.MiscellaneousList" %>
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
     <asp:ListView ID="LvMiscellaneousItems" runat="server" ItemPlaceholderID="layoutTemplate" 
            DataKeyNames="MiscId" InsertItemPosition="LastItem" OnPagePropertiesChanging="ListviewvMiscellaneous_PagePropertiesChanging"
            OnItemEditing="LvMiscellaneousItems_ItemEditing" OnItemUpdating="LvMiscellaneousItems_ItemUpdating" OnItemCanceling="LvMiscellaneousItems_Canceling"
             >
            <ItemTemplate>
                <div class="itemdisplay">
                    <tr>
                   
                      
                        <td>
                           <%# Eval("FieldName1")%>
                        </td>
                        <td>
                           <%# Eval("FieldName2")%>
                        </td>
                        <td>
                           <%# Eval("FieldName3")%>
                        </td>
                        <td>
                           <%# Eval("FieldName4")%>
                        </td>
                        <td>
                           <%# Eval("FieldName5")%>
                        </td>
                        <td>
                           <%# Eval("FieldName6")%>
                        </td>
                         <td>
                           <%# Eval("FieldName7")%>
                        </td>
                        <td>
                           <%# Eval("FieldName8")%>
                        </td>
                        <td>
                           <%# Eval("FieldName9")%>
                        </td>
                        <td>
                           <%# Eval("FieldName10")%>
                        </td>
                        <td>
                           <%# Eval("FieldName11")%>
                        </td>
                        <td>
                           <%# Eval("FieldName12")%>
                        </td>
                        <td>
                           <%# Eval("FieldName13")%>
                        </td>
                        <td>
                           <%# Eval("FieldName14")%>
                        </td>
                         <td>
                           <%# Eval("FieldName15")%>
                        </td>
                        
                        <td>
                           <%# Eval("LastModifiedAt")%>
                        </td>
                        <td>
                           <%# Eval("LastModifiedBy")%>
                        </td>


                        <td>
                            <asp:Button ID="BtnEdit" runat="server" CommandName="Edit" Text="Edit" CommandArgument='<%# Eval("MiscId") %>' />
                        </td>
                        
                    </tr>
                </div>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <div class="itemdisplayalternate">
                    <tr>
               
                     
                        <td>
                           <%# Eval("FieldName1")%>
                        </td>
                        <td>
                           <%# Eval("FieldName2")%>
                        </td>
                        <td>
                           <%# Eval("FieldName3")%>
                        </td>
                        <td>
                           <%# Eval("FieldName4")%>
                        </td>
                        <td>
                           <%# Eval("FieldName5")%>
                        </td>
                        <td>
                           <%# Eval("FieldName6")%>
                        </td>
                         <td>
                           <%# Eval("FieldName7")%>
                        </td>
                        <td>
                           <%# Eval("FieldName8")%>
                        </td>
                        <td>
                           <%# Eval("FieldName9")%>
                        </td>
                        <td>
                           <%# Eval("FieldName10")%>
                        </td>
                        <td>
                           <%# Eval("FieldName11")%>
                        </td>
                        <td>
                           <%# Eval("FieldName12")%>
                        </td>
                        <td>
                           <%# Eval("FieldName13")%>
                        </td>
                        <td>
                           <%# Eval("FieldName14")%>
                        </td>
                         <td>
                           <%# Eval("FieldName15")%>
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
                        
                    </tr>
                </div>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr class="gridalternate">
                   <%-- <td>
                        <asp:Label runat="server" ID="txtDocId" ReadOnly="true" Text='<%# Bind("DocId") %>'></asp:Label>
                    </td>--%>
                   
                    <td>
                        <asp:TextBox runat="server" ID="txtFieldName1" Text='<%# Bind("FieldName1") %>'></asp:TextBox>
                    </td>
                     <td>
                        <asp:TextBox runat="server" ID="txtFieldName2" Text='<%# Bind("FieldName2") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFieldName3" Text='<%# Bind("FieldName3") %>'></asp:TextBox>
                    </td>
                     <td>
                        <asp:TextBox runat="server" ID="txtFieldName4" Text='<%# Bind("FieldName4") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFieldName5" Text='<%# Bind("FieldName5") %>'></asp:TextBox>
                    </td>

                    <td>
                        <asp:TextBox runat="server" ID="txtFieldName6" Text='<%# Bind("FieldName6") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFieldName7" Text='<%# Bind("FieldName7") %>'></asp:TextBox>
                    </td>

                    <td>
                        <asp:TextBox runat="server" ID="txtFieldName8" Text='<%# Bind("FieldName8") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFieldName9" Text='<%# Bind("FieldName9") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFieldName10" Text='<%# Bind("FieldName10") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFieldName11" Text='<%# Bind("FieldName11") %>'></asp:TextBox>
                    </td>
                     <td>
                        <asp:TextBox runat="server" ID="txtFieldName12" Text='<%# Bind("FieldName12") %>'></asp:TextBox>
                    </td>
                     <td>
                        <asp:TextBox runat="server" ID="txtFieldName13" Text='<%# Bind("FieldName13") %>'></asp:TextBox>
                    </td>
                     <td>
                        <asp:TextBox runat="server" ID="txtFieldName14" Text='<%# Bind("FieldName14") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFieldName15" Text='<%# Bind("FieldName15") %>'></asp:TextBox>
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
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="border-style:groove">
                                <tr id="Tr2" runat="server" style="">
                                    
                                    <th id="Th2" runat="server">
                                        FieldName1&nbsp;
                                    </th>
                                    <th id="Th3" runat="server">
                                        FieldName2&nbsp;
                                    </th>
                                    <th id="Th4" runat="server">
                                        FieldName3&nbsp;
                                    </th>
                                    <th id="Th5" runat="server">
                                        FieldName4&nbsp;
                                    </th>
                                    <th id="Th6" runat="server">
                                        FieldName5&nbsp;
                                    </th>
                                    <th id="Th7" runat="server">
                                        FieldName6&nbsp;
                                    </th>
                                    <th id="Th8" runat="server">
                                        FieldName7&nbsp;
                                    </th>
                                    <th id="Th9" runat="server">
                                        FieldName8&nbsp;
                                    </th>
                                    <th id="Th10" runat="server">
                                        FieldName9&nbsp;
                                    </th>
                                    <th id="Th11" runat="server">
                                        FieldName10&nbsp;
                                    </th>
                                    <th id="Th12" runat="server">
                                        FieldName11&nbsp;
                                    </th>
                                    <th id="Th13" runat="server">
                                        FieldName12&nbsp;
                                    </th>
                                    <th id="Th14" runat="server">
                                        FieldName13&nbsp;
                                    </th>
                                    <th id="Th15" runat="server">
                                        FieldName14&nbsp;
                                   </th>
                                    <th id="Th16" runat="server">
                                        FieldName15&nbsp;
                                   </th>
                                    <th id="Th17" runat="server">
                                        LastModifiedAt&nbsp;
                                    </th>
                                    <th id="Th18" runat="server">
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

         <asp:DataPager runat="server" ID="MiscellaneousDataPager" PageSize="3" PagedControlID="LvMiscellaneousItems">
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
