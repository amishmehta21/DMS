using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DMSBE;
using DMSBAL;
using UserSecBE;
using System.Text.RegularExpressions;


namespace UserSec.DMS
{
    
    public partial class SearchDocument : System.Web.UI.Page
    {
       
        DocumentBAL DocBAL = new DocumentBAL();
        DocumentSearchBE DocSearchBE = new DocumentSearchBE();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LvDocumentItems.Visible = false;
                BindCategoryId();
                BindSubCategoryId();
            }
        }


         private void BindCategoryId()
        {
            DocumentBAL DocBAL = new DocumentBAL();
            DataTable dt = new DataTable();
            if (DocBAL.ShowDdlCategory(ref dt))
            {
                this.ddlCatId.DataSource = dt;
                ddlCatId.DataTextField = "CatId";
                ddlCatId.DataValueField = "CatId";
                ddlCatId.DataBind();
                ddlCatId.Items.Insert(0, new ListItem("--Select--", "0"));
               
            }

        }
        private void BindSubCategoryId()
        {
            DocumentBAL DocBAL = new DocumentBAL();
            DataTable dt = new DataTable();
            if (DocBAL.ShowDdlSubCategory(ref dt))
            {
                ddlSubCatId.DataSource = dt;
                ddlSubCatId.DataTextField = "SubCatId";
                ddlSubCatId.DataValueField = "SubCatId";
                ddlSubCatId.DataBind();
                ddlSubCatId.Items.Insert(0, new ListItem("--Select--", "0"));
            }

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DocumentBAL DocBAL = new DocumentBAL();
           
            //string PurchaseDept = txtPurchaseDept.Text;
            //Regex RePurchseDept = new Regex("^[a-zA-Z]");

            //if (!RePurchseDept.IsMatch(PurchaseDept))
            //{
            //    Response.Write("Please enter characters only");
            //}
            //else
            //{
                
            //}

            //if (txtFrmInvoiceNo.Text =="")
            //{
            //    DocSearchBE.FrmInvoiceNumber = "%";
            //}
           
            
            DocSearchBE.CatId = Convert.ToInt32(ddlCatId.Text);
            DocSearchBE.SubCatId = Convert.ToInt32(ddlSubCatId.Text);
            DocSearchBE.PurchaseDept = txtPurchaseDept.Text;
            DocSearchBE.AuthorisedBy = txtAuthorisedBy.Text;
            DocSearchBE.Purchaser = txtPurchaser.Text;
            DocSearchBE.SupplierName = txtSupplierName.Text;
            DocSearchBE.FrmInvoiceDate = Convert.ToDateTime(txtFrmInvoiceDate.Text);
            DocSearchBE.ToInvoiceDate = Convert.ToDateTime(txtToInvoiceDate.Text);
            DocSearchBE.FrmInvoiceNumber = Convert.ToInt32(txtFrmInvoiceNo.Text);
            DocSearchBE.ToInvoiceNumber = Convert.ToInt32(txtToInvoiceNo.Text);
            DocSearchBE.FrmInvoiceTotalAmountInRs = Convert.ToDecimal(txtFrmInvoiceTotalAmtInRs.Text);
            DocSearchBE.ToInvoiceTotalAmountInRs = Convert.ToDecimal(txtToInvoiceTotalAmtInRs.Text);
            DocSearchBE.FrmTotalNumberOfPages = Convert.ToInt32(txtFrmTotalNumberOfPages.Text);
            DocSearchBE.ToTotalNumberOfPages = Convert.ToInt32(txtToTotalNumberOfPages.Text);
            DocSearchBE.ChequeBank = txtChequeBank.Text;
            DocSearchBE.AccountNumber = Convert.ToInt32(txtAccountNumber.Text);
            DocSearchBE.FrmChequeDate = Convert.ToDateTime(txtFrmChequeDate.Text);
            DocSearchBE.ToChequeDate = Convert.ToDateTime(txtToChequeDate.Text);
            DocSearchBE.ChequeNumber = Convert.ToInt32(txtChequeNumber.Text);
            DocSearchBE.FrmChequeAmountInRs = Convert.ToDecimal(txtFrmChequeAmountInRs.Text);
            DocSearchBE.ToChequeAmountInRs = Convert.ToDecimal(txtToChequeAmountInRs.Text);
            DocSearchBE.FrmTotalNumberOfLineItems = Convert.ToInt32(txtFrmTotalNumberOfLineItems.Text);
            DocSearchBE.ToTotalNumberOfLineItems = Convert.ToInt32(txtToTotalNumberOfLineItems.Text);
            DocSearchBE.keyItems = txtKeyItems.Text;
            DocSearchBE.Remarks = txtRemarks.Text;
            DocSearchBE.OtherKeywords = txtOtherKeywords.Text;
            DocSearchBE.FileName = Convert.ToString(txtFileName.Text);

            DataTable dt = new DataTable();
            if (DocBAL.SearchDoc(DocSearchBE, ref dt))
            {
                LvDocumentItems.DataSource = dt;
                LvDocumentItems.DataBind();
                //searchDocumentDataPager.Visible = true;
                
            }
            
            if (ddlCatId.Text!="")
            { 

            }
        }

        //protected void ListViewCategory_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        //{
        //    LvDocumentItems.EditIndex = -1;
        //    this.searchDocumentDataPager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

        //    BindCategoryList();

        //}

        //protected void CurrentRowTextBox_OnTextChanged(object sender, EventArgs e)
        //{
        //    TextBox t = (TextBox)sender;
        //    EmployeesDataPager.SetPageProperties(Convert.ToInt32(t.Text) - 1,
        //        EmployeesDataPager.PageSize, true);
        //    BindCategoryList();
        //}

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ddlCatId.Text = "";
            ddlSubCatId.Text = "";
            txtPurchaseDept.Text = "";
            txtAuthorisedBy.Text = "";
            txtPurchaser.Text = "";
            txtSupplierName.Text = "";
            txtToInvoiceDate.Text = "";
            txtFrmInvoiceDate.Text = "";
            txtFrmInvoiceNo.Text = "";
            txtToInvoiceNo.Text = "";
            txtFrmInvoiceTotalAmtInRs.Text = "";
            txtToInvoiceTotalTaxAmtInRs.Text = "";
            txtFrmInvoiceTotalTaxAmtInRs.Text = "";
            txtToInvoiceTotalTaxAmtInRs.Text = "";
            txtFrmTotalNumberOfPages.Text = "";
            txtToTotalNumberOfPages.Text = "";
            txtChequeBank.Text = "";
            txtAccountNumber.Text = "";
           
            txtFrmChequeDate.Text = "";
            txtToChequeDate.Text = "";
          
            txtChequeNumber.Text = "";
            txtFrmChequeAmountInRs.Text = "";
            txtToChequeAmountInRs.Text = "";
            txtFrmTotalNumberOfLineItems.Text = "";
            txtToTotalNumberOfLineItems.Text = "";
            txtKeyItems.Text = "";
            txtRemarks.Text = "";
            txtOtherKeywords.Text = "";
            txtFileName.Text = "";
        }

    }
}