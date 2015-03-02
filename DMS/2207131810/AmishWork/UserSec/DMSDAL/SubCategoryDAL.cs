using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using DMSBE;
using System.Data;


namespace DMSDAL
{
    public class SubCategoryDAL
    {

        #region Methods


        public bool AddSubCategory(SubCategoryBE SubCatBE)
        {
            CommonDAL CommonDal = new CommonDAL();
            SqlConnection con = CommonDal.Connection();
            SqlCommand cmd = new SqlCommand("Sp_DMS_SubCategoryMsterInsert", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@CatId", System.Data.SqlDbType.VarChar).Value = SubCatBE.CatId2;
            cmd.Parameters.Add("@ShortDesc", System.Data.SqlDbType.VarChar).Value = SubCatBE.SubCatShortDesc;
            cmd.Parameters.Add("@LongDesc", System.Data.SqlDbType.VarChar).Value = SubCatBE.SubCatLongDesc;
            cmd.Parameters.Add("@LastModifiedBy", System.Data.SqlDbType.Int).Value = 1;
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

        public bool DeleteSubCategory(SubCategoryBE SubCatBE)
        {
            int msg = 0;
            CommonDAL CommonDal = new CommonDAL();
            SqlConnection con = CommonDal.Connection();

            SqlCommand cmd = new SqlCommand("Sp_DMS_SubCategoryMsterDelete", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@SubCatId", System.Data.SqlDbType.Int).Value = SubCatBE.SubCatId1;
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
            {
                return false;
            }
        }
        
        public bool ModifySubCategory(SubCategoryBE SubCatBE)
        {
            CommonDAL CommonDal = new CommonDAL();
            SqlConnection con = CommonDal.Connection();
            SqlCommand cmd = new SqlCommand("Sp_DMS_SubCategoryMsterUpdate", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@SubCatId", System.Data.SqlDbType.Int).Value = SubCatBE.SubCatId1;
            cmd.Parameters.Add("@ShortDesc", System.Data.SqlDbType.VarChar).Value = SubCatBE.SubCatShortDesc;
            cmd.Parameters.Add("@LongDesc", System.Data.SqlDbType.VarChar).Value = SubCatBE.SubCatLongDesc;
            cmd.Parameters.Add("@LastModifiedBy", System.Data.SqlDbType.Int).Value = SubCatBE.SubCatLastModifiedBy;

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

        public bool ShowSubCategory(ref DataTable dt)
        {
            CommonDAL commondal = new CommonDAL();
            SqlConnection con = commondal.Connection();
            SqlDataAdapter adp = new SqlDataAdapter("Sp_DMS_SubCategoryMsterView", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            if (loadSubCategoryProfile(ref dt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool loadSubCategoryProfile(ref DataTable dt)
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


    }


        #endregion Methods

}
