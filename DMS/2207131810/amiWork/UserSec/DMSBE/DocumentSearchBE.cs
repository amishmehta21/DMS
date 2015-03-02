using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMSBE
{
    public class DocumentSearchBE
    {
    
        #region Properties

        private int _DocId;
        public int DocID
        {
            get { return _DocId; }
            set { _DocId = value; }
        }


        private int _CatId;

        public int CatId
        {
            get { return _CatId; }
            set { _CatId = value; }
        }

        private int _SubCatId;

        public int SubCatId
        {
            get { return _SubCatId; }
            set { _SubCatId = value; }
        }

        private string _PurchaseDept;

        public string PurchaseDept
        {
            get { return _PurchaseDept; }
            set { _PurchaseDept = value; }
        }

        private string _AuthorisedBy;

        public string AuthorisedBy
        {
            get { return _AuthorisedBy; }
            set { _AuthorisedBy = value; }
        }


        private string _Purchaser;

        public string Purchaser
        {
            get { return _Purchaser; }
            set { _Purchaser = value; }
        }



        private string _SupplierName;

        public string SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
        }


       
        private DateTime _FrmInvoiceDate;

        public DateTime FrmInvoiceDate
        {
            get { return _FrmInvoiceDate; }
            set { _FrmInvoiceDate = value; }
        }

        private DateTime _ToInvoiceDate;
        public DateTime ToInvoiceDate
        {
            get { return _ToInvoiceDate; }
            set { _ToInvoiceDate = value; }
        }

       
        private int _FrmInvoiceNumber;

        public int FrmInvoiceNumber
        {
            get { return _FrmInvoiceNumber; }
            set { _FrmInvoiceNumber = value; }
        }


        private int _ToInvoiceNumber;

        public int ToInvoiceNumber
        {
            get { return _ToInvoiceNumber; }
            set { _ToInvoiceNumber = value; }
        }




        private Decimal _FrmInvoiceTotalAmountInRs;

        public Decimal FrmInvoiceTotalAmountInRs
        {
            get { return _FrmInvoiceTotalAmountInRs; }
            set { _FrmInvoiceTotalAmountInRs = value; }
        }

        private Decimal _ToInvoiceTotalAmountInRs;

        public Decimal ToInvoiceTotalAmountInRs
        {
            get { return _ToInvoiceTotalAmountInRs; }
            set { _ToInvoiceTotalAmountInRs = value; }
        }


        private Decimal _FrmInvoiceTotalTaxAmountInRs;

        public Decimal FrmInvoiceTotalTaxAmountInRs
        {
            get { return _FrmInvoiceTotalTaxAmountInRs; }
            set { _FrmInvoiceTotalTaxAmountInRs = value; }
        }

        private Decimal _ToInvoiceTotalTaxAmountInRs;

        public Decimal ToInvoiceTotalTaxAmountInRs
        {
            get { return _ToInvoiceTotalTaxAmountInRs; }
            set { _ToInvoiceTotalTaxAmountInRs = value; }
        }

   

        private int _FrmTotalNumberOfPages;

        public int FrmTotalNumberOfPages
        {
            get { return _FrmTotalNumberOfPages; }
            set { _FrmTotalNumberOfPages = value; }
        }

        private int _ToTotalNumberOfPages;

        public int ToTotalNumberOfPages
        {
            get { return _ToTotalNumberOfPages; }
            set { _ToTotalNumberOfPages = value; }
        }

        private string _ChequeBank;

        public string ChequeBank
        {
            get { return _ChequeBank; }
            set { _ChequeBank = value; }
        }



        private int _AccountNumber;

        public int AccountNumber
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; }
        }

        private DateTime _ChequeDate;

        public DateTime ChequeDate
        {
            get { return _ChequeDate; }
            set { _ChequeDate = value; }
        }

         private DateTime _FrmChequeDate;

        public DateTime FrmChequeDate
        {
            get { return _FrmChequeDate; }
            set { _FrmChequeDate = value; }
        }

        private DateTime _ToChequeDate;

        public DateTime ToChequeDate
        {
            get { return _ToChequeDate; }
            set { _ToChequeDate = value; }
        }



        private int _ChequeNumber;

        public int ChequeNumber
        {
            get { return _ChequeNumber; }
            set { _ChequeNumber = value; }
        }

       

        private Decimal _FrmChequeAmountInRs;

        public Decimal FrmChequeAmountInRs
        {
            get { return _FrmChequeAmountInRs; }
            set { _FrmChequeAmountInRs = value; }
        }

        private Decimal _ToChequeAmountInRs;

        public Decimal ToChequeAmountInRs
        {
            get { return _ToChequeAmountInRs; }
            set { _ToChequeAmountInRs = value; }
        }


        private int _FrmTotalNumberOfLineItems;

        public int FrmTotalNumberOfLineItems
        {
            get { return _FrmTotalNumberOfLineItems; }
            set { _FrmTotalNumberOfLineItems = value; }
        }

        private int _ToTotalNumberOfLineItems;

        public int ToTotalNumberOfLineItems
        {
            get { return _ToTotalNumberOfLineItems; }
            set { _ToTotalNumberOfLineItems = value; }
        }

        private string _keyItems;

        public string keyItems
        {
            get { return _keyItems; }
            set { _keyItems = value; }
        }


        private string _Remarks;

        public string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }


        private string _OtherKeywords;

        public string OtherKeywords
        {
            get { return _OtherKeywords; }
            set { _OtherKeywords = value; }
        }

        private string _FileName;

        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value; }
        }

        #endregion Properties



    }



}
