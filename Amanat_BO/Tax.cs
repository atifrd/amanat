using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Amanat_BO
{
    public class Tax
    {

        public static DataSet Tax_SelectAll()
        {
            Database dba = new Database();
            try
            {
                return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Tax_SelectAll");
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
        public static DataSet Tax_GetActiveOne(DateTime Today)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[1];
            try
            {
                param[0] = new SqlParameter("@Today", Today);
                return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Tax_GetActiveOne",param);
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

        public static  Boolean Tax_Insert(DateTime FromDate, DateTime ToDate, double TaxBurden)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[3];
            try
            {
                param[0] = new SqlParameter("@FromDate", FromDate);
                param[1] = new SqlParameter("@ToDate", ToDate);
                param[2] = new SqlParameter("@TaxBurden", TaxBurden);
               return Convert.ToBoolean(SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "Tax_Insert", param));
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
        public static Boolean Tax_Delete(DateTime FromDate, DateTime ToDate, int TaxId)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[3];
            try
            {
                param[0] = new SqlParameter("@FromDate", FromDate);
                param[1] = new SqlParameter("@ToDate", ToDate);
                param[2] = new SqlParameter("@TaxId", TaxId);
                return Convert.ToBoolean(SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "Tax_Delete", param));
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
        public static DataSet Tax_Edit(DateTime FromDate, DateTime ToDate, double TaxBurden, int TaxId)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[4];
            try
            {
                param[0] = new SqlParameter("@NewFromDate", FromDate);
                param[1] = new SqlParameter("@NewToDate", ToDate);
                param[2] = new SqlParameter("@TaxId", TaxId);
                param[3] = new SqlParameter("@TaxBurden", TaxBurden);
                return   SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Tax_Edit", param);
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
