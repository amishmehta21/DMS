using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMSBE
{
    public class DocumentBE
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


        private DateTime _InvoiceDate;

        public DateTime InvoiceDate
        {
            get { return _InvoiceDate; }
            set { _InvoiceDate = value; }
        }

    

        private string _InvoiceNumber;

        public string InvoiceNumber
        {
            get { return _InvoiceNumber; }
            set { _InvoiceNumber = value; }
        }

      




        private Decimal _InvoiceTotalAmountInRs;

        public Decimal InvoiceTotalAmountInRs
        {
            get { return _InvoiceTotalAmountInRs; }
            set { _InvoiceTotalAmountInRs = value; }
        }




        private Decimal _InvoiceTotalTaxAmountInRs;

        public Decimal InvoiceTotalTaxAmountInRs
        {
            get { return _InvoiceTotalTaxAmountInRs; }
            set { _InvoiceTotalTaxAmountInRs = value; }
        }


        private int _TotalNumberOfPages;

        public int TotalNumberOfPages
        {
            get { return _TotalNumberOfPages; }
            set { _TotalNumberOfPages = value; }
        }

        private string _ChequeBank;

        public string ChequeBank
        {
            get { return _ChequeBank; }
            set { _ChequeBank = value; }
        }


        private string _AccountNumber;

        public string AccountNumber
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

        private string _ChequeNumber;

        public string ChequeNumber
        {
            get { return _ChequeNumber; }
            set { _ChequeNumber = value; }
        }


        private Decimal _ChequeAmountInRs;

        public Decimal ChequeAmountInRs
        {
            get { return _ChequeAmountInRs; }
            set { _ChequeAmountInRs = value; }
        }

        private int _TotalNumberOfLineItems;

        public int TotalNumberOfLineItems
        {
            get { return _TotalNumberOfLineItems; }
            set { _TotalNumberOfLineItems = value; }
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


        private string _FileName1;

        public string FileName1
        {
            get { return _FileName1; }
            set { _FileName1 = value; }
        }

        private string _FileName2;

        public string FileName2
        {
            get { return _FileName2; }
            set { _FileName2 = value; }
        }


        private string _FileName3;

        public string FileName3
        {
            get { return _FileName3; }
            set { _FileName3 = value; }
        }


        private string _FileName4;

        public string FileName4
        {
            get { return _FileName4; }
            set { _FileName4 = value; }
        }

        private string _FileName5;

        public string FileName5
        {
            get { return _FileName5; }
            set { _FileName5 = value; }
        }

        private string _FileName6;

        public string FileName6
        {
            get { return _FileName6; }
            set { _FileName6 = value; }
        }



        private string _FileName7;

        public string FileName7
        {
            get { return _FileName7; }
            set { _FileName7 = value; }
        }


        private string _FileName8;

        public string FileName8
        {
            get { return _FileName8; }
            set { _FileName8 = value; }
        }


        private string _FileName9;

        public string FileName9
        {
            get { return _FileName9; }
            set { _FileName9 = value; }
        }


        private string _FileName10;

        public string FileName10
        {
            get { return _FileName10; }
            set { _FileName10 = value; }
        }


        private string _FileName11;

        public string FileName11
        {
            get { return _FileName11; }
            set { _FileName11 = value; }
        }


        private string _FileName12;

        public string FileName12
        {
            get { return _FileName12; }
            set { _FileName12 = value; }
        }


        private string _FileName13;

        public string FileName13
        {
            get { return _FileName13; }
            set { _FileName13 = value; }
        }


        private string _FileName14;

        public string FileName14
        {
            get { return _FileName14; }
            set { _FileName14 = value; }
        }

        private string _FileName15;

        public string FileName15
        {
            get { return _FileName15; }
            set { _FileName15 = value; }
        }



        private DateTime _LastModifiedAt;

        public DateTime LastModifiedAt
        {
            get { return _LastModifiedAt; }
            set { _LastModifiedAt = value; }
        }


        private int _LastModifiedBy;

        public int LastModifiedBy
        {
            get { return _LastModifiedBy; }
            set { _LastModifiedBy = value; }
        }

        private bool _IsValid;

        public bool IsValid
        {
            get { return _IsValid; }
            set { _IsValid = value; }
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
