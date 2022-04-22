using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Amanat_BO
{
    public class Baggage_Prices
    {
        public static string  Baggage_Price_Insert(int baggageCode, string baggageName, DateTime FromDate, Decimal Price, short Valid)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[5];
            try
            {
                param[0] = new SqlParameter("@baggageCode", baggageCode);
                param[1] = new SqlParameter("@baggageName", baggageName);
                param[2] = new SqlParameter("@FromDate", FromDate);
                param[3] = new SqlParameter("@Price", Price);
                param[4] = new SqlParameter("@Valid", Valid);
                return SqlHelper.ExecuteScalar (dba.getConnection(), CommandType.StoredProcedure, "Baggage_Price_Insert", param).ToString();
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

        public static DataSet Baggage_Price_SelectAll(Boolean All)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[1];
            try
            {
                param[0] = new SqlParameter("@All", All);//if all==0 just valid
                return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Baggage_Price_SelectAll",param);
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


        public static DataSet Baggage_Price_GetInfoByBaggageId(string baggageId)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[1];

            try
            {
                param[0] = new SqlParameter("@baggageId", baggageId);
                return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Baggage_Price_GetInfoByBaggageId",param);
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


        public static decimal GetRealDelayPriceProcedure(decimal BaggagePrice, int BaggageCount, DateTime GiveDate, string GiveTime, DateTime GiveBackDate, string GiveBackTime)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[6];

            try
            {
                param[0] = new SqlParameter("@BaggagePrice", BaggagePrice);
                param[1] = new SqlParameter("@BaggageCount",BaggageCount );
                param[2] = new SqlParameter("@GiveDate",GiveDate );
                param[3] = new SqlParameter("@GiveBackDate", GiveBackDate);
                param[4] = new SqlParameter("@GiveTime", GiveTime);
                param[5] = new SqlParameter("@GiveBackTime", GiveBackTime);
                return Convert.ToDecimal(SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "GetRealDelayPriceProcedure", param));
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
