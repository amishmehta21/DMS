using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DMSBE;

namespace DMSDAL
{
    public class CategoryDAL
    {

        #region Methods

        public bool AddCategory(CategoryBE CatBE)
        {
            CommonDAL CommonDAL = new CommonDAL();
            SqlConnection con = CommonDAL.Connection();
            SqlCommand cmd = new SqlCommand("Sp_DMS_CategoryMsterInsert", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@ShortDesc", System.Data.SqlDbType.VarChar).Value = CatBE.CatShortDesc;  
            cmd.Parameters.Add("@LongDesc", System.Data.SqlDbType.VarChar).Value = CatBE.CatLongDesc;  
            cmd.Parameters.Add("@LastModifiedBy", System.Data.SqlDbType.Int).Value = CatBE.CatLastModifiedBy; ; 

            con.Open();
            int row = cmd.ExecuteNonQuery();   //returns an integer value to check whether the data has been successfully inserted into the database table
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

        public bool DeleteCategory(CategoryBE CatBE)
        {
            int msg = 0;

            CommonDAL CommonDAL = new CommonDAL();
            SqlConnection con = CommonDAL.Connection();

            SqlCommand cmd = new SqlCommand("Sp_DMS_CategoryMsterDelete", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@CatId", System.Data.SqlDbType.Int).Value = CatBE.CatId1;
            cmd.Parameters.Add("@ReturnCode", System.Data.SqlDbType.Int);
            cmd.Parameters["@ReturnCode"].Direction = ParameterDirection.Output;

            con.Open();

            int row = cmd.ExecuteNonQuery();

            msg = Convert.ToInt32(cmd.Parameters["@ReturnCode"].Value);

            con.Close();

            if (msg == 0)
            {
                return true;
            }
            else
                return false;
        }


        public bool ModifyCategory(CategoryBE CatBE)
        {
            CommonDAL commondal = new CommonDAL();

            SqlConnection con = commondal.Connection();
            SqlCommand cmd = new SqlCommand("Sp_DMS_CategoryMsterUpdate", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@CatId", System.Data.SqlDbType.Int).Value = CatBE.CatId1;
            cmd.Parameters.Add("@ShortDesc", System.Data.SqlDbType.VarChar).Value = CatBE.CatShortDesc;
            cmd.Parameters.Add("@LongDesc", System.Data.SqlDbType.VarChar).Value = CatBE.CatLongDesc;
            cmd.Parameters.Add("@LastModifiedBy", System.Data.SqlDbType.VarChar).Value = CatBE.CatLastModifiedBy;

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
        public bool ShowCategory(ref DataTable dt)
        {
            //??? this rtn is not used at this moment but can be used for single record show
            CommonDAL commondal = new CommonDAL();
            SqlConnection con = commondal.Connection();
            SqlDataAdapter adp = new SqlDataAdapter("Sp_DMS_CategoryMsterView", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            if (loadCategoryProfile(ref dt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool loadCategoryProfile(ref DataTable dt)
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


        public void PrintCategory()
        {
        }

        //public bool ShowDdlCategory(ref DataTable dt)
        //public bool GetAllCategoryDetails(ref DataTable dt)
        //{
        //    CommonDAL CommonDal = new CommonDAL();
        //    SqlConnection con = CommonDal.Connection();
        //    SqlDataAdapter adp = new SqlDataAdapter("Sp_DMS_CategoryMsterView", con);

        //    adp.Fill(dt);

        //    if(

        //    return true;
        //}


        #endregion Methods

    }
}
