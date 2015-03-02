using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DMSBE;



namespace DMSDAL
{
    public class MiscellaneousMasterDAL
    {
        MiscellaneousMasterBE MiscBE = new MiscellaneousMasterBE();
        CommonDAL CommonDal = new CommonDAL();


        #region Methods

        public bool AddMiscellaneous(MiscellaneousMasterBE MiscBE)
        {
            SqlConnection con = CommonDal.Connection();
            SqlCommand cmd = new SqlCommand("Sp_DMS_MiscMsterInsert", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
       
            cmd.Parameters.Add("@FieldName1", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName1;
            cmd.Parameters.Add("@FieldName2", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName2;
            cmd.Parameters.Add("@Fieldname3", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName3;
            cmd.Parameters.Add("@FieldName4", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName4;
            cmd.Parameters.Add("@Fieldname5", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName5;
            cmd.Parameters.Add("@Fieldname6", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName6;
            cmd.Parameters.Add("@Fieldname7", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName7;
            cmd.Parameters.Add("@Fieldname8", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName8;
            cmd.Parameters.Add("@Fieldname9", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName9;
            cmd.Parameters.Add("@FieldName10", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName10;
            cmd.Parameters.Add("@FieldName11", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName11;
            cmd.Parameters.Add("@FieldName12", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName12;
            cmd.Parameters.Add("@Fieldname13", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName13;
            cmd.Parameters.Add("@FieldName14", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName14;
            cmd.Parameters.Add("@FieldName15", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName15;
            cmd.Parameters.Add("@LastModifiedBy", System.Data.SqlDbType.VarChar).Value = MiscBE.LastModifiedBy;


            con.Open();
            int row = cmd.ExecuteNonQuery();
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


        public bool ModifyMiscellaneous(MiscellaneousMasterBE MiscBE)
        {
            SqlConnection con = CommonDal.Connection();
            SqlCommand cmd = new SqlCommand("Sp_DMS_MiscMsterUpdate", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@MiscId", System.Data.SqlDbType.Int).Value = MiscBE.MiscId;
           
            cmd.Parameters.Add("@FieldName1", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName1;
            cmd.Parameters.Add("@FieldName2", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName2;
            cmd.Parameters.Add("@Fieldname3", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName3;
            cmd.Parameters.Add("@FieldName4", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName4;
            cmd.Parameters.Add("@Fieldname5", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName5;
            cmd.Parameters.Add("@Fieldname6", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName6;
            cmd.Parameters.Add("@Fieldname7", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName7;
            cmd.Parameters.Add("@Fieldname8", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName8;
            cmd.Parameters.Add("@Fieldname9", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName9;
            cmd.Parameters.Add("@FieldName10", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName10;
            cmd.Parameters.Add("@FieldName11", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName11;
            cmd.Parameters.Add("@FieldName12", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName12;
            cmd.Parameters.Add("@Fieldname13", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName13;
            cmd.Parameters.Add("@FieldName14", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName14;
            cmd.Parameters.Add("@FieldName15", System.Data.SqlDbType.VarChar).Value = MiscBE.FieldName15;
            cmd.Parameters.Add("@LastModifiedBy", System.Data.SqlDbType.Int).Value = MiscBE.LastModifiedBy;

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

        public bool ShowMiscellaneous(ref DataTable dt)
        {
            CommonDAL CommonDal = new CommonDAL();
            SqlConnection con = CommonDal.Connection();
            SqlDataAdapter adp = new SqlDataAdapter("Sp_DMS_MiscMsterView", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            if (LoadMiscellaneousProfile(ref dt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LoadMiscellaneousProfile(ref DataTable dt)
        {
            if (dt.Rows.Count >0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion Methods
    }
}
