using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using DMSBAL;
using DMSBE;
using System.Data;
using UserSecBE;

namespace UserSec.DMS
{
    public partial class DocumentAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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

        string path = @"D:\" + "DMS " + DateTime.Now.Year + " " + DateTime.Now.Month;

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!validData())
            {
            }
            else
            {
                DocumentBAL DocumentBal = new DocumentBAL();
                DocumentBE DocumentBE = new DocumentBE();

                DocumentBE.CatId = Convert.ToInt32(ddlCatId.Text);
                DocumentBE.SubCatId = Convert.ToInt32(ddlSubCatId.Text);
                DocumentBE.PurchaseDept = txtPurchaseDept.Text;
                DocumentBE.AuthorisedBy = txtAuthBy.Text;
                DocumentBE.Purchaser = txtPurchaser.Text;
                DocumentBE.SupplierName = txtSupplierName.Text;
                DocumentBE.InvoiceDate = Convert.ToDateTime(dtInvoiceDate.SelectedDate);
                DocumentBE.InvoiceNumber = txtInvoiceNum.Text;
                DocumentBE.InvoiceTotalAmountInRs = Convert.ToDecimal(txtInvoiceNum.Text);
                DocumentBE.InvoiceTotalTaxAmountInRs = Convert.ToDecimal(txtInvoiceTotalTaxAmt.Text);
                DocumentBE.TotalNumberOfPages = Convert.ToInt32(txtTotalNumOfPages.Text);
                DocumentBE.ChequeBank = txtChequeBank.Text;
                DocumentBE.AccountNumber = txtAcctNum.Text;
                DocumentBE.ChequeDate = Convert.ToDateTime(dtChequeDate.SelectedDate);
                DocumentBE.ChequeNumber = txtChequeNum.Text;
                DocumentBE.ChequeAmountInRs = Convert.ToDecimal(txtChequeAmt.Text);
                DocumentBE.TotalNumberOfLineItems = Convert.ToInt32(txtTotalNumOfLinedItems.Text);
                DocumentBE.keyItems = txtKeyItems.Text;
                DocumentBE.Remarks = txtRemarks.Text;
                DocumentBE.OtherKeywords = txtOtherKeywords.Text;
                DocumentBE.FileName1 = path + @"\" + flName1.FileName;
                DocumentBE.FileName2 = path + @"\" + flName2.FileName;
                DocumentBE.FileName3 = path + @"\" + flName3.FileName;
                DocumentBE.FileName4 = path + @"\" + flName4.FileName;
                DocumentBE.FileName5 = path + @"\" + flName5.FileName;
                DocumentBE.FileName6 = path + @"\" + flName6.FileName;
                DocumentBE.FileName7 = path + @"\" + flName7.FileName;
                DocumentBE.FileName8 = path + @"\" + flName8.FileName;
                DocumentBE.FileName9 = path + @"\" + flName9.FileName;
                DocumentBE.FileName10 = path + @"\" + flName10.FileName;
                DocumentBE.FileName11 = path + @"\" + flName11.FileName;
                DocumentBE.FileName12 = path + @"\" + flName12.FileName;
                DocumentBE.FileName13 = path + @"\" + flName13.FileName;
                DocumentBE.FileName14 = path + @"\" + flName14.FileName;
                DocumentBE.FileName15 = path + @"\" + flName15.FileName;
                DocumentBE.LastModifiedBy = ((UserBE)Session["LoggedInUser"]).UserId;

                if (DocumentBal.AddDoc(DocumentBE))
                {

                    //uploaded file getting saved in a specified folder

                    //string path = @"D:\" + "DMS " + DateTime.Now.Year + " " + DateTime.Now.Month;
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }


                    if (flName1.HasFile)
                    {

                        flName1.SaveAs(path + @"\" + flName1.FileName);

                    }
                    if (flName2.HasFile)
                    {

                        flName2.SaveAs(path + @"\" + flName2.FileName);

                    }


                    if (flName3.HasFile)
                    {

                        flName3.SaveAs(path + @"\" + flName3.FileName);

                    }
                    if (flName3.HasFile)
                    {

                        flName3.SaveAs(path + @"\" + flName3.FileName);

                    }


                    if (flName4.HasFile)
                    {

                        flName4.SaveAs(path + @"\" + flName4.FileName);

                    }

                    if (flName5.HasFile)
                    {

                        flName5.SaveAs(path + @"\" + flName5.FileName);

                    }


                    if (flName6.HasFile)
                    {

                        flName6.SaveAs(path + @"\" + flName6.FileName);

                    }


                    if (flName7.HasFile)
                    {

                        flName7.SaveAs(path + @"\" + flName7.FileName);

                    }

                    if (flName8.HasFile)
                    {

                        flName8.SaveAs(path + @"\" + flName8.FileName);

                    }

                    if (flName9.HasFile)
                    {

                        flName9.SaveAs(path + @"\" + flName9.FileName);

                    }


                    if (flName10.HasFile)
                    {

                        flName10.SaveAs(path + @"\" + flName10.FileName);

                    }


                    if (flName11.HasFile)
                    {

                        flName11.SaveAs(path + @"\" + flName11.FileName);

                    }

                    if (flName12.HasFile)
                    {

                        flName12.SaveAs(path + @"\" + flName12.FileName);

                    }

                    if (flName13.HasFile)
                    {

                        flName13.SaveAs(path + @"\" + flName13.FileName);

                    }

                    if (flName14.HasFile)
                    {

                        flName14.SaveAs(path + @"\" + flName14.FileName);

                    }


                    if (flName15.HasFile)
                    {

                        flName15.SaveAs(path + @"\" + flName15.FileName);

                    }


                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Record successfully added.", true);

                }
                else
                {
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Unsuccessful.",false);
                }
            }

            txtAcctNum.Text = "";
            dtChequeDate.SelectedDate = DateTime.Now;
            dtInvoiceDate.SelectedDate = DateTime.Now;
            txtAuthBy.Text = "";
            txtChequeAmt.Text = "";
            txtChequeBank.Text = "";
            txtChequeNum.Text = "";
            txtInvoiceNum.Text = "";
            txtInvoiceTotalAmt.Text = "";
            txtKeyItems.Text = "";
            txtInvoiceTotalTaxAmt.Text = "";
            txtOtherKeywords.Text = "";
            txtPurchaseDept.Text = "";
            txtPurchaser.Text = "";
            txtRemarks.Text = "";
            txtSupplierName.Text = "";
            txtTotalNumOfLinedItems.Text = "";
            txtTotalNumOfPages.Text = "";
        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtAcctNum.Text = "";
            dtChequeDate.SelectedDate = DateTime.Now;
            dtInvoiceDate.SelectedDate = DateTime.Now;
            txtAuthBy.Text = "";
            txtChequeAmt.Text = "";
            txtChequeBank.Text = "";
            txtChequeNum.Text = "";
            txtInvoiceNum.Text = "";
            txtInvoiceTotalAmt.Text = "";
            txtKeyItems.Text = "";
            txtInvoiceTotalTaxAmt.Text = "";
            txtOtherKeywords.Text = "";
            txtPurchaseDept.Text = "";
            txtPurchaser.Text = "";
            txtRemarks.Text = "";
            txtSupplierName.Text = "";
            txtTotalNumOfLinedItems.Text = "";
            txtTotalNumOfPages.Text = "";

        }


        private bool validData()
        {
            if (ddlCatId.Text == "" && ddlSubCatId.Text == "" && txtAcctNum.Text == "" && txtAuthBy.Text == ""
                && txtChequeAmt.Text == "" && txtChequeBank.Text == "" && txtChequeNum.Text == "" &&
                txtInvoiceNum.Text == "" && txtInvoiceTotalAmt.Text == "" && txtInvoiceTotalTaxAmt.Text == ""
                && txtKeyItems.Text == "" && txtOtherKeywords.Text == "" && txtPurchaseDept.Text == ""
                && txtPurchaser.Text == "" && txtRemarks.Text == "" && txtSupplierName.Text == ""
                && txtTotalNumOfLinedItems.Text == "" && txtTotalNumOfPages.Text == "")
            {
                //????? Message to be displayed on master page message bar
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Fields which are marked as (*) are mandatory.", false);
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}