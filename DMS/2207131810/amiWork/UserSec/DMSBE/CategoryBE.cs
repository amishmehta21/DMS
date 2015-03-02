using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMSBE
{
    public class CategoryBE
    {


        #region Properties



        private int _CatId1;

        public int CatId1
        {
            get { return _CatId1; }
            set { _CatId1 = value; }
        }

        private string _CatShortDesc;

        public string CatShortDesc
        {
            get { return _CatShortDesc; }
            set { _CatShortDesc = value; }
        }

        private string _CatLongDesc;

        public string CatLongDesc
        {
            get { return _CatLongDesc; }
            set { _CatLongDesc = value; }
        }


        private DateTime _CatLastModifiedAt;

        public DateTime CatLastModifiedAt
        {
            get { return _CatLastModifiedAt; }
            set { _CatLastModifiedAt = value; }
        }
        private int _CatLastModifiedBy;

        public int CatLastModifiedBy
        {
            get { return _CatLastModifiedBy; }
            set { _CatLastModifiedBy = value; }
        }

        //private bool _CatIsValid;

        //public bool CatIsValid
        //{
        //    get { return _CatIsValid; }
        //    set { _CatIsValid = value; }
        //}





        #endregion Properties





    }
}
