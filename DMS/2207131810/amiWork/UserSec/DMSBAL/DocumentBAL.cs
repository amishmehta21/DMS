using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMSBE;
using DMSDAL;
using System.Data;
using System.Data.SqlClient;

namespace DMSBAL
{
    public class DocumentBAL
    {
        #region Methods

        public bool AddDoc(DocumentBE DocBE)
        {
            DocumentDAL DocumentDal = new DocumentDAL();
            if (DocumentDal.AddDoc(DocBE))
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
            DocumentDAL DocDAL = new DocumentDAL();
            if (DocDAL.DeleteDoc(DocBE))
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
            DocumentDAL DocDAL = new DocumentDAL();
            if (DocDAL.ModifyDoc(DocBE))
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
            DocumentDAL DocDAL = new DocumentDAL();
            if (DocDAL.ShowDoc(ref dt))
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
            DocumentDAL DocDAL = new DocumentDAL();
            if (DocDAL.ShowDdlCategory(ref dt))
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
            DocumentDAL DocDAL = new DocumentDAL();
            if (DocDAL.ShowDdlSubCategory(ref dt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SearchDoc(DocumentSearchBE DocSearchBE, ref DataTable dt)
        {
            DocumentDAL DocDAL = new DocumentDAL();
            if (DocDAL.SearchDoc(DocSearchBE, ref dt))
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
