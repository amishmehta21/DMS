using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMSBE;
using DMSDAL;
using System.Data;

namespace DMSBAL
{
    public class SubCategoryBAL
    {

        #region Methods




        public bool AddSubCategory(SubCategoryBE SubCatBE)
        {
            SubCategoryDAL SubCatDAL = new SubCategoryDAL();
            if (SubCatDAL.AddSubCategory(SubCatBE))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteSubCategory(SubCategoryBE SubCatBE)
        {
            SubCategoryDAL subCatDAL = new SubCategoryDAL();
            if (subCatDAL.DeleteSubCategory(SubCatBE))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool ModifySubCategory(SubCategoryBE SubCatBE)
        {
            SubCategoryDAL SubCatDAL = new SubCategoryDAL();
            if (SubCatDAL.ModifySubCategory(SubCatBE))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public bool ShowSubCategory(ref DataTable dt)
        {
            SubCategoryDAL SubCatDAL = new SubCategoryDAL();
            if (SubCatDAL.ShowSubCategory(ref dt))
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
            SubCategoryDAL SubCatDAL = new SubCategoryDAL();
            if (SubCatDAL.ShowDdlCategory(ref dt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintSubCategory()
        {
        }


        #endregion Methods
    }
}
