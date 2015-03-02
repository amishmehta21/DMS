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
    public class CategoryBAL
    {
        #region Methods

        public bool AddCategory(CategoryBE CatBE)
        {
            CategoryDAL CatDal = new CategoryDAL();
            if (CatDal.AddCategory(CatBE))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteCategory(CategoryBE CatBE)
        {
            CategoryDAL CatDal = new CategoryDAL();

            if (CatDal.DeleteCategory(CatBE))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ModifyCategory(CategoryBE CatBE)
        {
            CategoryDAL CatDal = new CategoryDAL();
            if (CatDal.ModifyCategory(CatBE))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ShowCategory(ref DataTable dt)
        {
            CategoryDAL CatDal = new CategoryDAL();
            if (CatDal.ShowCategory(ref dt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintCategory()
        {
        }


        #endregion Methods
    }
}
