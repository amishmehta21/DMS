using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMSBE;
using System.Data.SqlClient;
using System.Data;

namespace DMSDAL
{
    public class DocumentDAL
    {
        CommonDAL CommonDal = new CommonDAL();
       
        #region Methods

        public bool AddDoc(DocumentBE DocBE)
        {
            SqlConnection con = CommonDal.Connection();
            SqlCommand cmd = new SqlCommand("Sp_DMS_DocumentInsert", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@CatId", System.Data.SqlDbType.Int).Value = DocBE.CatId;
            cmd.Parameters.Add("@SubCatId", System.Data.SqlDbType.Int).Value = DocBE.SubCatId;
            cmd.Parameters.Add("@PurchaseDept", System.Data.SqlDbType.VarChar).Value = DocBE.PurchaseDept;
            cmd.Parameters.Add("@AuthorisedBy", System.Data.SqlDbType.VarChar).Value = DocBE.AuthorisedBy;
            cmd.Parameters.Add("@Purchaser", System.Data.SqlDbType.VarChar).Value = DocBE.Purchaser;
            cmd.Parameters.Add("@SupplierName", System.Data.SqlDbType.VarChar).Value = DocBE.SupplierName;
            cmd.Parameters.Add("@Invoicedate", System.Data.SqlDbType.DateTime).Value = DocBE.InvoiceDate;
            cmd.Parameters.Add("@InvoiceNumber", System.Data.SqlDbType.VarChar).Value = DocBE.InvoiceNumber;
            cmd.Parameters.Add("@InvoiceTotalAmountInRs", System.Data.SqlDbType.Decimal).Value = DocBE.InvoiceTotalAmountInRs;
            cmd.Parameters.Add("@InvoiceTotalTaxAmountInRs", System.Data.SqlDbType.Decimal).Value = DocBE.InvoiceTotalTaxAmountInRs;
            cmd.Parameters.Add("@TotalNumberOfPages", System.Data.SqlDbType.Int).Value = DocBE.TotalNumberOfPages;
            cmd.Parameters.Add("@ChequeBank", System.Data.SqlDbType.VarChar).Value = DocBE.ChequeBank;
            cmd.Parameters.Add("@AccountNumber", System.Data.SqlDbType.VarChar).Value = DocBE.AccountNumber;
            cmd.Parameters.Add("@ChequeDate", System.Data.SqlDbType.DateTime).Value = DocBE.ChequeDate;
            cmd.Parameters.Add("@ChequeNumber", System.Data.SqlDbType.VarChar).Value = DocBE.ChequeNumber;
            cmd.Parameters.Add("@ChequeAmountInRs", System.Data.SqlDbType.Decimal).Value = DocBE.ChequeAmountInRs;
            cmd.Parameters.Add("@TotalNumberOfLineItems", System.Data.SqlDbType.Int).Value = DocBE.TotalNumberOfLineItems;
            cmd.Parameters.Add("@keyItems", System.Data.SqlDbType.VarChar).Value = DocBE.keyItems;
            cmd.Parameters.Add("@Remarks", System.Data.SqlDbType.VarChar).Value = DocBE.Remarks;
            cmd.Parameters.Add("@OtherKeywords", System.Data.SqlDbType.VarChar).Value = DocBE.OtherKeywords;
            cmd.Parameters.Add("@FileName1", System.Data.SqlDbType.VarChar).Value = DocBE.FileName1; //flName1.FileName;
            cmd.Parameters.Add("@FileName2", System.Data.SqlDbType.VarChar).Value = DocBE.FileName2;//flName2.FileName;
            cmd.Parameters.Add("@FileName3", System.Data.SqlDbType.VarChar).Value = DocBE.FileName3;//flName3.FileName;
            cmd.Parameters.Add("@FileName4", System.Data.SqlDbType.VarChar).Value = DocBE.FileName4;//flName4.FileName;
            cmd.Parameters.Add("@FileName5", System.Data.SqlDbType.VarChar).Value = DocBE.FileName5;//flName5.FileName;
            cmd.Parameters.Add("@FileName6", System.Data.SqlDbType.VarChar).Value = DocBE.FileName6;//flName6.FileName;
            cmd.Parameters.Add("@FileName7", System.Data.SqlDbType.VarChar).Value = DocBE.FileName7;//flName7.FileName;
            cmd.Parameters.Add("@FileName8", System.Data.SqlDbType.VarChar).Value = DocBE.FileName8;//flName8.FileName;
            cmd.Parameters.Add("@FileName9", System.Data.SqlDbType.VarChar).Value = DocBE.FileName9;//flName9.FileName;
            cmd.Parameters.Add("@FileName10", System.Data.SqlDbType.VarChar).Value = DocBE.FileName10;// flName10.FileName;
            cmd.Parameters.Add("@FileName11", System.Data.SqlDbType.VarChar).Value = DocBE.FileName11;//flName11.FileName;
            cmd.Parameters.Add("@FileName12", System.Data.SqlDbType.VarChar).Value = DocBE.FileName12;//flName12.FileName;
            cmd.Parameters.Add("@FileName13", System.Data.SqlDbType.VarChar).Value = DocBE.FileName13;//flName13.FileName;
            cmd.Parameters.Add("@FileName14", System.Data.SqlDbType.VarChar).Value = DocBE.FileName14;//flName14.FileName;
            cmd.Parameters.Add("@FileName15", System.Data.SqlDbType.VarChar).Value = DocBE.FileName15;//flName15.FileName;
            cmd.Parameters.Add("@LastModifiedBy", System.Data.SqlDbType.Int).Value = DocBE.LastModifiedBy;

            con.Open();
            int row = cmd.ExecuteNonQuery(); //returns an integer value to check whether the data has been successfully inserted into the database table
            con.Close();
            if (row == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteDoc(DocumentBE DocBE)
        {
            SqlConnection con = CommonDal.Connection();
            SqlCommand cmd = new SqlCommand("Sp_DMS_DocumentDelete", con);
            cmd.Parameters.Add("@DocID", System.Data.SqlDbType.Int).Value = DocBE.DocID;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row == 2)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public bool ModifyDoc(DocumentBE DocBE)
        {
            SqlConnection con = CommonDal.Connection();
            SqlCommand cmd = new SqlCommand("Sp_DMS_DocumentUpdate", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@DocId", System.Data.SqlDbType.Int).Value = DocBE.DocID;
            cmd.Parameters.Add("@PurchaseDept", System.Data.SqlDbType.VarChar).Value = DocBE.PurchaseDept;
            cmd.Parameters.Add("@AuthorisedBy", System.Data.SqlDbType.VarChar).Value = DocBE.AuthorisedBy;
            cmd.Parameters.Add("@Purchaser", System.Data.SqlDbType.VarChar).Value = DocBE.Purchaser;
            cmd.Parameters.Add("@SupplierName", System.Data.SqlDbType.VarChar).Value = DocBE.SupplierName;
            cmd.Parameters.Add("@Invoicedate", System.Data.SqlDbType.DateTime).Value = DocBE.InvoiceDate;
            cmd.Parameters.Add("@InvoiceNumber", System.Data.SqlDbType.VarChar).Value = DocBE.InvoiceNumber;
            cmd.Parameters.Add("@InvoiceTotalAmountInRs", System.Data.SqlDbType.Decimal).Value = DocBE.InvoiceTotalAmountInRs;
            cmd.Parameters.Add("@InvoiceTotalTaxAmountInRs", System.Data.SqlDbType.Decimal).Value = DocBE.InvoiceTotalTaxAmountInRs;
            cmd.Parameters.Add("@TotalNumberOfPages", System.Data.SqlDbType.Int).Value = DocBE.TotalNumberOfPages;
            cmd.Parameters.Add("@ChequeBank", System.Data.SqlDbType.VarChar).Value = DocBE.ChequeBank;
            cmd.Parameters.Add("@AccountNumber", System.Data.SqlDbType.VarChar).Value = DocBE.AccountNumber;
            cmd.Parameters.Add("@ChequeDate", System.Data.SqlDbType.DateTime).Value = DocBE.ChequeDate;
            cmd.Parameters.Add("@ChequeNumber", System.Data.SqlDbType.VarChar).Value = DocBE.ChequeNumber;
            cmd.Parameters.Add("@ChequeAmountInRs", System.Data.SqlDbType.Decimal).Value = DocBE.ChequeAmountInRs;
            cmd.Parameters.Add("@TotalNumberOfLineItems", System.Data.SqlDbType.Int).Value = DocBE.TotalNumberOfLineItems;
            cmd.Parameters.Add("@keyItems", System.Data.SqlDbType.VarChar).Value = DocBE.keyItems;
            cmd.Parameters.Add("@Remarks", System.Data.SqlDbType.VarChar).Value = DocBE.Remarks;
            cmd.Parameters.Add("@OtherKeywords", System.Data.SqlDbType.VarChar).Value = DocBE.OtherKeywords;
            cmd.Parameters.Add("@FileName1", System.Data.SqlDbType.VarChar).Value = DocBE.FileName1; //flName1.FileName;
            cmd.Parameters.Add("@FileName2", System.Data.SqlDbType.VarChar).Value = DocBE.FileName2;//flName2.FileName;
            cmd.Parameters.Add("@FileName3", System.Data.SqlDbType.VarChar).Value = DocBE.FileName3;//flName3.FileName;
            cmd.Parameters.Add("@FileName4", System.Data.SqlDbType.VarChar).Value = DocBE.FileName4;//flName4.FileName;
            cmd.Parameters.Add("@FileName5", System.Data.SqlDbType.VarChar).Value = DocBE.FileName5;//flName5.FileName;
            cmd.Parameters.Add("@FileName6", System.Data.SqlDbType.VarChar).Value = DocBE.FileName6;//flName6.FileName;
            cmd.Parameters.Add("@FileName7", System.Data.SqlDbType.VarChar).Value = DocBE.FileName7;//flName7.FileName;
            cmd.Parameters.Add("@FileName8", System.Data.SqlDbType.VarChar).Value = DocBE.FileName8;//flName8.FileName;
            cmd.Parameters.Add("@FileName9", System.Data.SqlDbType.VarChar).Value = DocBE.FileName9;//flName9.FileName;
            cmd.Parameters.Add("@FileName10", System.Data.SqlDbType.VarChar).Value = DocBE.FileName10;// flName10.FileName;
            cmd.Parameters.Add("@FileName11", System.Data.SqlDbType.VarChar).Value = DocBE.FileName11;//flName11.FileName;
            cmd.Parameters.Add("@FileName12", System.Data.SqlDbType.VarChar).Value = DocBE.FileName12;//flName12.FileName;
            cmd.Parameters.Add("@FileName13", System.Data.SqlDbType.VarChar).Value = DocBE.FileName13;//flName13.FileName;
            cmd.Parameters.Add("@FileName14", System.Data.SqlDbType.VarChar).Value = DocBE.FileName14;//flName14.FileName;
            cmd.Parameters.Add("@FileName15", System.Data.SqlDbType.VarChar).Value = DocBE.FileName15;//flName15.FileName;
            cmd.Parameters.Add("@LastModifiedBy", System.Data.SqlDbType.Int).Value = DocBE.LastModifiedBy;

            con.Open();
            int row = cmd.ExecuteNonQuery(); //returns an integer value to check whether the data has been successfully inserted into the database table
            con.Close();
            if (row == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ShowDoc(ref DataTable dt)
        {
            CommonDAL CommonDal = new CommonDAL();
            SqlConnection con = CommonDal.Connection();
            SqlDataAdapter adp = new SqlDataAdapter("Sp_DMS_DocumentView", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            if (LoadcategoryProfile(ref dt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LoadcategoryProfile(ref DataTable dt)
        {
            if (dt.Rows.Count != 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ShowDdlCategory(ref DataTable dt)
        {
            CommonDAL commondal = new CommonDAL();
            SqlConnection con = commondal.Connection();
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("Sp_DMS_CategoryIdView", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            con.Close();
            if (LoadCategoryId(ref dt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool LoadCategoryId(ref DataTable dt)
        {
            if (dt.Rows.Count != 1)
            {
                return true;
            }
            else
            {

                return false;

            }
        }

        public bool ShowDdlSubCategory(ref DataTable dt)
        {
            CommonDAL commondal = new CommonDAL();
            SqlConnection con = commondal.Connection();
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("Sp_DMS_SubCategoryIdView", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            con.Close();
            if (LoadSubCategoryId(ref dt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool LoadSubCategoryId(ref DataTable dt)
        {
            if (dt.Rows.Count != 1)
            {
                return true;
            }
            else
            {

                return false;

            }
        }
        public bool SearchDoc(DocumentSearchBE DocSearchBE , ref DataTable dt)
        {
            SqlConnection con = CommonDal.Connection();

            SqlDataAdapter da = new SqlDataAdapter("Sp_DMS_SearchDocument", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter CatId  = new SqlParameter("@CatId", SqlDbType.VarChar);
            SqlParameter SubCatId = new SqlParameter("@SubCatId", SqlDbType.VarChar);


            SqlParameter PurchaseDept = new SqlParameter("@PurchaseDept", SqlDbType.VarChar);
            SqlParameter AuthorisedBy = new SqlParameter("@AuthorisedBy", SqlDbType.VarChar);
            SqlParameter Purchaser = new SqlParameter("@Purchaser", SqlDbType.VarChar);
            SqlParameter SupplierName = new SqlParameter("@SupplierName", SqlDbType.VarChar);
            SqlParameter FrmInvoiceDate = new SqlParameter("@FrmInvoiceDate", SqlDbType.VarChar);
            SqlParameter ToInvoiceDate = new SqlParameter("@ToInvoiceDate", SqlDbType.VarChar);
            SqlParameter FrmInvoiceNumber = new SqlParameter("@FrmInvoiceNumber", SqlDbType.VarChar);
            SqlParameter ToInvoiceNumber = new SqlParameter("@ToInvoiceNumber", SqlDbType.VarChar);
            SqlParameter FrmInvoiceTotalAmountInRs = new SqlParameter("@FrmInvoiceTotalAmountInRs", SqlDbType.VarChar);
            SqlParameter ToInvoiceTotalAmountInRs = new SqlParameter("@ToInvoiceTotalAmountInRs", SqlDbType.VarChar);
            SqlParameter FrmInvoiceTotalTaxAmountInRs = new SqlParameter("@FrmInvoiceTotalTaxAmountInRs", SqlDbType.VarChar);
            SqlParameter ToInvoiceTotalTaxAmountInRs = new SqlParameter("@ToInvoiceTotalTaxAmountInRs", SqlDbType.VarChar);
            SqlParameter FrmTotalNumberOfPages = new SqlParameter("@FrmTotalNumberOfPages", SqlDbType.VarChar);
            SqlParameter ToTotalNumberOfPages = new SqlParameter("@ToTotalNumberOfPages", SqlDbType.VarChar);
            SqlParameter ChequeBank = new SqlParameter("@ChequeBank", SqlDbType.VarChar);
            SqlParameter AccountNumber = new SqlParameter("@AccountNumber", SqlDbType.VarChar);
            SqlParameter FrmChequeDate = new SqlParameter("@FrmChequeDate", SqlDbType.VarChar);
            SqlParameter ToChequeDate = new SqlParameter("@ToChequeDate", SqlDbType.VarChar);
            SqlParameter ChequeNumber = new SqlParameter("@ChequeNumber", SqlDbType.VarChar);
            SqlParameter FrmChequeAmountInRs = new SqlParameter("@FrmChequeAmountInRs", SqlDbType.VarChar);
            SqlParameter ToChequeAmountInRs = new SqlParameter("@ToChequeAmountInRs", SqlDbType.VarChar);
            SqlParameter FrmTotalNumberOfLineItems = new SqlParameter("@FrmTotalNumberOfLineItems", SqlDbType.VarChar);
            SqlParameter ToTotalNumberOfLineItems = new SqlParameter("@ToTotalNumberOfLineItems", SqlDbType.VarChar);
            SqlParameter keyItems = new SqlParameter("@keyItems", SqlDbType.VarChar);
            SqlParameter Remarks = new SqlParameter("@Remarks", SqlDbType.VarChar);
            SqlParameter OtherKeywords = new SqlParameter("@OtherKeywords", SqlDbType.VarChar);
            SqlParameter FileName = new SqlParameter("@FileName", SqlDbType.VarChar);

            CatId.Value = DocSearchBE.CatId;
           
            SubCatId.Value = DocSearchBE.SubCatId;

            PurchaseDept.Value = DocSearchBE.PurchaseDept;
            AuthorisedBy.Value = DocSearchBE.AuthorisedBy;
            Purchaser.Value = DocSearchBE.Purchaser;
            SupplierName.Value = DocSearchBE.SupplierName;
            FrmInvoiceDate.Value = DocSearchBE.FrmInvoiceDate;
            ToInvoiceDate.Value = DocSearchBE.ToInvoiceDate;
            FrmInvoiceNumber.Value = DocSearchBE.FrmInvoiceNumber;
            ToInvoiceNumber.Value = DocSearchBE.ToInvoiceNumber;
            FrmInvoiceTotalAmountInRs.Value = DocSearchBE.FrmInvoiceTotalAmountInRs;
            ToInvoiceTotalAmountInRs.Value = DocSearchBE.ToInvoiceTotalAmountInRs;
            FrmInvoiceTotalTaxAmountInRs.Value = DocSearchBE.FrmInvoiceTotalTaxAmountInRs;
            ToInvoiceTotalTaxAmountInRs.Value = DocSearchBE.ToInvoiceTotalTaxAmountInRs;
            FrmTotalNumberOfPages.Value = DocSearchBE.FrmTotalNumberOfPages;
            ToTotalNumberOfPages.Value = DocSearchBE.ToTotalNumberOfPages;
            ChequeBank.Value = DocSearchBE.ChequeBank;
            AccountNumber.Value = DocSearchBE.AccountNumber;
            
            FrmChequeDate.Value = DocSearchBE.FrmChequeDate;
            ToChequeDate.Value = DocSearchBE.ToChequeDate;
            ChequeNumber.Value = DocSearchBE.ChequeNumber;
            FrmChequeAmountInRs.Value = DocSearchBE.FrmChequeAmountInRs;
            ToChequeAmountInRs.Value = DocSearchBE.ToChequeAmountInRs;
            FrmTotalNumberOfLineItems.Value = DocSearchBE.FrmTotalNumberOfLineItems;
            ToTotalNumberOfLineItems.Value = DocSearchBE.ToTotalNumberOfLineItems;
            keyItems.Value = DocSearchBE.keyItems;
            Remarks.Value = DocSearchBE.Remarks;
            OtherKeywords.Value = DocSearchBE.OtherKeywords;
            FileName.Value = DocSearchBE.keyItems;

            da.SelectCommand.Parameters.Add(CatId);
            da.SelectCommand.Parameters.Add(SubCatId);
            da.SelectCommand.Parameters.Add(PurchaseDept);
            da.SelectCommand.Parameters.Add(AuthorisedBy);
            da.SelectCommand.Parameters.Add(Purchaser);
            da.SelectCommand.Parameters.Add(SupplierName);
            da.SelectCommand.Parameters.Add(FrmInvoiceDate);
            da.SelectCommand.Parameters.Add(ToInvoiceDate);
            da.SelectCommand.Parameters.Add(FrmInvoiceNumber);
            da.SelectCommand.Parameters.Add(ToInvoiceNumber);
            da.SelectCommand.Parameters.Add(FrmInvoiceTotalTaxAmountInRs);
            da.SelectCommand.Parameters.Add(FrmTotalNumberOfPages);
            da.SelectCommand.Parameters.Add(ToTotalNumberOfPages);
            da.SelectCommand.Parameters.Add(ChequeBank);
            da.SelectCommand.Parameters.Add(AccountNumber);
            da.SelectCommand.Parameters.Add(FrmChequeDate);
            da.SelectCommand.Parameters.Add(ToChequeDate);
            da.SelectCommand.Parameters.Add(ChequeNumber);
            da.SelectCommand.Parameters.Add(FrmChequeAmountInRs);
            da.SelectCommand.Parameters.Add(ToChequeAmountInRs);
            da.SelectCommand.Parameters.Add(FrmTotalNumberOfLineItems);
            da.SelectCommand.Parameters.Add(ToTotalNumberOfLineItems);
            da.SelectCommand.Parameters.Add(keyItems);
            da.SelectCommand.Parameters.Add(Remarks);
            da.SelectCommand.Parameters.Add(OtherKeywords);
            da.SelectCommand.Parameters.Add(FileName);
           

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void BrowseDocs()
        {
        }
        public void Approve()
        {
        }

        #endregion Methods

    }
}
