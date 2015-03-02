using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMSBE
{
    public class SubCategoryBE
    {


        #region Properties



        private int _SubCatId1;

        public int SubCatId1
        {
            get { return _SubCatId1; }
            set { _SubCatId1 = value; }
        }


        private int _CatId2;

        public int CatId2
        {
            get { return _CatId2; }
            set { _CatId2 = value; }
        }

        private string _SubCatShortDesc;

        public string SubCatShortDesc
        {
            get { return _SubCatShortDesc; }
            set { _SubCatShortDesc = value; }
        }

        private string _SubCatLongDesc;

        public string SubCatLongDesc
        {
            get { return _SubCatLongDesc; }
            set { _SubCatLongDesc = value; }
        }

        private DateTime _SubCatLastModifiedAt;

        public DateTime SubCatLastModifiedAt
        {
            get { return _SubCatLastModifiedAt; }
            set { _SubCatLastModifiedAt = value; }
        }
        private int _SubCatLastModifiedBy;

        public int SubCatLastModifiedBy
        {
            get { return _SubCatLastModifiedBy; }
            set { _SubCatLastModifiedBy = value; }
        }

        private bool _SubCatIsValid;

        public bool SubCatIsValid
        {
            get { return _SubCatIsValid; }
            set { _SubCatIsValid = value; }
        }



        #endregion Properties


    }
}
