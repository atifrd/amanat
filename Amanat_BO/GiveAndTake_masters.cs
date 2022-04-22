using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using System.Xml;
namespace Amanat_BO
{
    public class GiveAndTake_masters
    {
        public static string GiveAndTake_master_ReturnLastSerialNumber(string SysSession)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[1];
            try
            {

                param[0] = new SqlParameter("@SysSession", SysSession);
               return SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_master_ReturnLastSerialNumber",param).ToString();
                
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                dba.getConnection().Close();
            }
        }


        public static Int64 GiveAndTake_daryaftAmanat(string SerialNumber, string Person, DateTime GiveDate, string GiveTime, DateTime exp_GiveBackDate, string exp_GiveBackTime
            , int FKUserId_Give, decimal Fsum, Int16 FkTaxId, string PTell, decimal M_FSum)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[11];
            try
            {
                param[0] = new SqlParameter("@SerialNumber", SerialNumber);
                param[1] = new SqlParameter("@Person", Person);
                param[2] = new SqlParameter("@GiveDate", GiveDate);

                param[3] = new SqlParameter("@GiveTime", GiveTime);
                param[4] = new SqlParameter("@exp_GiveBackDate", exp_GiveBackDate);
                param[5] = new SqlParameter("@exp_GiveBackTime", exp_GiveBackTime);
                param[6] = new SqlParameter("@FKUserId_Give", FKUserId_Give);
                param[7] = new SqlParameter("@Fsum", Fsum);
                param[8] = new SqlParameter("@FkTaxId", FkTaxId);
                param[9] = new SqlParameter("@PTell", PTell);
                param[10] = new SqlParameter("@M_FSum", M_FSum);
                return Convert.ToInt64(SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_daryaftAmanat", param));
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                dba.getConnection().Close();
            }
        }

        /*public static DataSet GiveAndTake_masterSelectTahvilnashode()
        {
            Database dba = new Database();
            try
            {

                return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_masterSelectTahvilnashode");

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                dba.getConnection().Close();
            }
        }*/

        public static void GiveAndTake_master_Ebtal(string SerialNumber)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[1];
            try
            {
                param[0] = new SqlParameter("@SerialNumber", SerialNumber);
                SqlHelper.ExecuteNonQuery(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_master_Ebtal", param);
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                dba.getConnection().Close();
            }
        }

        public static DataSet Search_Fish(string SerialNumber, DateTime GiveBackDateTime, int TaxId)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[3];
            try
            {
                param[0] = new SqlParameter("@SerialNumber", SerialNumber);
                param[1] = new SqlParameter("@GiveBackDateTime", GiveBackDateTime);
                param[2] = new SqlParameter("@TaxId", TaxId);//  جهت محاسبه مالیات تاخیر کالاهایی که هنوز تحویل داده نشدند 
                return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Search_Fish", param);
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                dba.getConnection().Close();
            }
        }




        public static DataSet Fish_GetList(string WhereCondition)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[1];
            try
            {
                param[0] = new SqlParameter("@WhereCondition", WhereCondition);
                return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Fish_GetList", param);
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                dba.getConnection().Close();
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------
          public static Int64 GiveAndTake_masterDetails_edit(XmlDocument xmldoc )
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[11];
            try
            {
                param[0] = new SqlParameter("@doc", xmldoc.OuterXml);
                
                return Convert.ToInt64(SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_masterDetails_edit", param));
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                dba.getConnection().Close();
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------
          public static Int64 GiveAndTake_masterAllDetails_edit(Int64 GiveAndTake_masterId,string SerialNumber , string Person, DateTime GiveDate, string GiveTime, DateTime exp_GiveBackDate, string exp_GiveBackTime
              , decimal Fsum, Int16 FkTaxId, string PTell, decimal M_FSum, int FKUserId_Edit, DateTime EditDateTime,DataTable myList)
          {
              Database dba = new Database();
              SqlParameter[] param = new SqlParameter[14];
              try
              {
                  param[0] = new SqlParameter("@GiveAndTake_masterId", GiveAndTake_masterId);
                  param[1] = new SqlParameter("@Person", Person);
                  param[2] = new SqlParameter("@GiveDate", GiveDate);
                  param[3] = new SqlParameter("@GiveTime", GiveTime);
                  param[4] = new SqlParameter("@exp_GiveBackDate", exp_GiveBackDate);
                  param[5] = new SqlParameter("@exp_GiveBackTime", exp_GiveBackTime);
                  param[6] = new SqlParameter("@Fsum", Fsum);
                  param[7] = new SqlParameter("@FkTaxId", FkTaxId);
                  param[8] = new SqlParameter("@PTell", PTell);
                  param[9] = new SqlParameter("@M_FSum", M_FSum);
                  param[10] = new SqlParameter("@FKUserId_Edit", FKUserId_Edit);
                  param[11] = new SqlParameter("@EditDateTime", EditDateTime);
                  param[12] = new SqlParameter("@myList", myList);
                  param[13] = new SqlParameter("@SerialNumber", SerialNumber);
                  return Convert.ToInt64(SqlHelper.ExecuteNonQuery(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_masterAllDetails_edit", param));
              }
              catch (Exception ex)
              {

                  throw;
              }
              finally
              {
                  dba.getConnection().Close();
              }
          }
    }
}
