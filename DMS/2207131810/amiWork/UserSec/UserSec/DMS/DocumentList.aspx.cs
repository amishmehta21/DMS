using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMSBE;
using DMSBAL;
using System.Data;
using UserSecBE;

namespace UserSec.DMS
{
    public partial class DocumentList : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDocumentList();
            }
        }

        private void BindDocumentList()
        {
            DocumentBAL DocBAL = new DocumentBAL();
            DocumentBE DocBE = new DocumentBE();
            DataTable dt = new DataTable();
            if (DocBAL.ShowDoc(ref dt))
            {
                this.LvDocumentItems.DataSource = dt;
                LvDocumentItems.DataBind();
            }
            else
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Unsuccessful", false);
            }
        }

        protected void ListViewDocument_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            LvDocumentItems.EditIndex = -1;
            this.EmployeesDataPager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            BindDocumentList();

        }

        protected void CurrentRowTextBox_OnTextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            EmployeesDataPager.SetPageProperties(Convert.ToInt32(t.Text) - 1,
                EmployeesDataPager.PageSize, true);
            BindDocumentList();
        }


        protected void LvDocumentItems_ItemDeleting(object sender, ListViewDeleteEventArgs e)
        {

            string DocId = LvDocumentItems.DataKeys[e.ItemIndex].Value.ToString();

            DocumentBE DocBE = new DocumentBE();
            DocumentBAL DocBAL = new DocumentBAL();
            DocBE.DocID = Convert.ToInt32(DocId);


            if (DocBAL.DeleteDoc(DocBE))
            {
                LvDocumentItems.EditIndex = -1;
                BindDocumentList();
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Record successfully deleted.", true);
            }
            else
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Unsuccessful",false);
            }
        }

        protected void LvDocumentItems_Canceling(object sender, ListViewCancelEventArgs e)
        {
            LvDocumentItems.EditIndex = -1;
            BindDocumentList();
        }

        protected void LvDocumentItems_ItemEditing(object sender, ListViewEditEventArgs e)
        {

            LvDocumentItems.EditIndex = e.NewEditIndex;
            BindDocumentList();
        }

        protected void LvDocumentItems_ItemUpdating(object sender, ListViewUpdateEventArgs e)
        {


            string DocId = LvDocumentItems.DataKeys[e.ItemIndex].Value.ToString();

            TextBox purchaseDept = LvDocumentItems.Items[e.ItemIndex].FindControl("txtPurchaseDept") as TextBox;
            TextBox AuthorisedBy = LvDocumentItems.Items[e.ItemIndex].FindControl("txtAuthorisedBy") as TextBox;
            TextBox Purchaser = LvDocumentItems.Items[e.ItemIndex].FindControl("txtPurchaser") as TextBox;
            TextBox SupplierName = LvDocumentItems.Items[e.ItemIndex].FindControl("txtSupplierName") as TextBox;
            TextBox InvoiceDate = LvDocumentItems.Items[e.ItemIndex].FindControl("txtInvoiceDate") as TextBox;
            TextBox InvoiceNumber = LvDocumentItems.Items[e.ItemIndex].FindControl("txtInvoiceNumber") as TextBox;
            TextBox InvoiceTotalAmountInRs = LvDocumentItems.Items[e.ItemIndex].FindControl("txtInvoiceTotalAmountInRs") as TextBox;
            TextBox InvoiceTotalTaxAmountInRs = LvDocumentItems.Items[e.ItemIndex].FindControl("txtInvoiceTotalTaxAmountInRs") as TextBox;
            TextBox TotalNumberOfPages = LvDocumentItems.Items[e.ItemIndex].FindControl("txtTotalNumberOfPages") as TextBox;
            TextBox ChequeBank = LvDocumentItems.Items[e.ItemIndex].FindControl("txtChequeBank") as TextBox;
            TextBox AccountNumber = LvDocumentItems.Items[e.ItemIndex].FindControl("txtAccountNumber") as TextBox;
            TextBox ChequeDate = LvDocumentItems.Items[e.ItemIndex].FindControl("txtChequeDate") as TextBox;
            TextBox ChequeNumber = LvDocumentItems.Items[e.ItemIndex].FindControl("txtChequeNumber") as TextBox;
            TextBox ChequeAmountInRs = LvDocumentItems.Items[e.ItemIndex].FindControl("txtChequeAmountInRs") as TextBox;
            TextBox TotalNumberOfLineItems = LvDocumentItems.Items[e.ItemIndex].FindControl("txtTotalNumberOfLineItems") as TextBox;
            TextBox keyItems = LvDocumentItems.Items[e.ItemIndex].FindControl("txtkeyItems") as TextBox;
            TextBox Remarks = LvDocumentItems.Items[e.ItemIndex].FindControl("txtRemarks") as TextBox;
            TextBox OtherKeywords = LvDocumentItems.Items[e.ItemIndex].FindControl("txtOtherKeywords") as TextBox;
            TextBox FileName1 = LvDocumentItems.Items[e.ItemIndex].FindControl("txtFileName1") as TextBox;
            TextBox FileName2 = LvDocumentItems.Items[e.ItemIndex].FindControl("txtFileName2") as TextBox;
            TextBox FileName3 = LvDocumentItems.Items[e.ItemIndex].FindControl("txtFileName3") as TextBox;
            TextBox FileName4 = LvDocumentItems.Items[e.ItemIndex].FindControl("txtFileName4") as TextBox;
            TextBox FileName5 = LvDocumentItems.Items[e.ItemIndex].FindControl("txtFileName5") as TextBox;
            TextBox FileName6 = LvDocumentItems.Items[e.ItemIndex].FindControl("txtFileName6") as TextBox;
            TextBox FileName7 = LvDocumentItems.Items[e.ItemIndex].FindControl("txtFileName7") as TextBox;
            TextBox FileName8 = LvDocumentItems.Items[e.ItemIndex].FindControl("txtFileName8") as TextBox;
            TextBox FileName9 = LvDocumentItems.Items[e.ItemIndex].FindControl("txtFileName9") as TextBox;
            TextBox FileName10 = LvDocumentItems.Items[e.ItemIndex].FindControl("txtFileName10") as TextBox;
            TextBox FileName11 = LvDocumentItems.Items[e.ItemIndex].FindControl("txtFileName11") as TextBox;
            TextBox FileName12 = LvDocumentItems.Items[e.ItemIndex].FindControl("txtFileName12") as TextBox;
            TextBox FileName13 = LvDocumentItems.Items[e.ItemIndex].FindControl("txtFileName13") as TextBox;
            TextBox FileName14 = LvDocumentItems.Items[e.ItemIndex].FindControl("txtFileName14") as TextBox;
            TextBox FileName15 = LvDocumentItems.Items[e.ItemIndex].FindControl("txtFileName15") as TextBox;

            DocumentBE DocBE = new DocumentBE();
            DocumentBAL DocBAL = new DocumentBAL();
            DocBE.DocID = Convert.ToInt32(DocId);
            DocBE.PurchaseDept = purchaseDept.Text;
            DocBE.AuthorisedBy = AuthorisedBy.Text;
            DocBE.Purchaser = Purchaser.Text;
            DocBE.SupplierName = SupplierName.Text;
            DocBE.InvoiceDate = Convert.ToDateTime(InvoiceDate.Text);
            DocBE.InvoiceNumber = InvoiceNumber.Text;
            DocBE.InvoiceTotalAmountInRs = Convert.ToDecimal(InvoiceTotalAmountInRs.Text);
            DocBE.InvoiceTotalTaxAmountInRs = Convert.ToDecimal(InvoiceTotalTaxAmountInRs.Text);
            DocBE.TotalNumberOfPages = Convert.ToInt32(TotalNumberOfPages.Text);
            DocBE.ChequeBank = ChequeBank.Text;
            DocBE.AccountNumber = AccountNumber.Text;
            DocBE.ChequeDate = Convert.ToDateTime(ChequeDate.Text);
            DocBE.ChequeNumber = (ChequeNumber.Text);
            DocBE.ChequeAmountInRs = Convert.ToDecimal(ChequeAmountInRs.Text);
            DocBE.TotalNumberOfLineItems = Convert.ToInt32(TotalNumberOfLineItems.Text);
            DocBE.keyItems = keyItems.Text;
            DocBE.Remarks = Remarks.Text;
            DocBE.OtherKeywords = OtherKeywords.Text;
            DocBE.FileName1 = FileName1.Text;
            DocBE.FileName2 = FileName2.Text;
            DocBE.FileName3 = FileName3.Text;
            DocBE.FileName4 = FileName4.Text;
            DocBE.FileName5 = FileName5.Text;
            DocBE.FileName6 = FileName6.Text;
            DocBE.FileName7 = FileName7.Text;
            DocBE.FileName8 = FileName8.Text;
            DocBE.FileName9 = FileName9.Text;
            DocBE.FileName10 = FileName10.Text;
            DocBE.FileName11 = FileName11.Text;
            DocBE.FileName12 = FileName12.Text;
            DocBE.FileName13 = FileName13.Text;
            DocBE.FileName14 = FileName14.Text;
            DocBE.FileName15 = FileName15.Text;
            DocBE.LastModifiedBy = ((UserBE)Session["LoggedInUser"]).UserId;



            if (DocBAL.ModifyDoc(DocBE))
            {

                LvDocumentItems.EditIndex = -1;
                BindDocumentList();
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Record successfully updated.", true);
            }
            else
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Unsuccessful", false);
            }
        }

        protected void OnPageSizeChange(object sender, EventArgs e)
        {
            if (ddlPageSize.SelectedValue == "-Select-")
            {
            }
            else
            {
                EmployeesDataPager.PageSize = Convert.ToInt32(ddlPageSize.SelectedValue);
                BindDocumentList();
            }
        }

        
    }
}