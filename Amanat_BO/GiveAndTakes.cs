using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Amanat_BO
{
   public class GiveAndTakes
    {
       public static void GiveAndTake_DaryaftDetails(Int64 FKGiveAndTake_masterId, int FKBaggagePriceID, int BaggageCoun, decimal Delay_price
           , string UndefBaggageDesc, decimal UndefBaggagePrice, int baggageCode)
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[7];
           try
           {
               param[0] = new SqlParameter("@FKGiveAndTake_masterId", FKGiveAndTake_masterId);
               param[1] = new SqlParameter("@FKBaggagePriceID", FKBaggagePriceID);
               param[2] = new SqlParameter("@BaggageCoun", BaggageCoun);
               param[3] = new SqlParameter("@Delay_price", Delay_price);
               param[4] = new SqlParameter("@UndefBaggageDesc", UndefBaggageDesc);
               param[5] = new SqlParameter("@UndefBaggagePrice", UndefBaggagePrice);
               param[6] = new SqlParameter("@baggageCode", baggageCode);
               SqlHelper.ExecuteNonQuery(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_DaryaftDetails", param);
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


       public static DataSet GiveAndTake_SelectTahvilnashode()
       {
           Database dba = new Database();
           try
           {

               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_SelectTahvilnashode");

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




       public static void GiveAndTake_master_UpdateForTahvil(DateTime GiveBackDate, string GiveBackTime
           , int FKUserId_GiveBack, Int16 Statuse, string SerialNumber
           , Decimal TakeBackDelay_price, Int64 DetailsId, decimal discount, decimal Fsum, Int16 FkTaxIdBack
           , decimal M_FSum_Delay
           )
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[11];
           try
           {
               param[0] = new SqlParameter("@GiveBackDate",GiveBackDate );
               param[1] = new SqlParameter("@GiveBackTime",GiveBackTime );
               param[2] = new SqlParameter("@FKUserId_GiveBack",FKUserId_GiveBack );
               param[3] = new SqlParameter("@Statuse", Statuse);
               param[4] = new SqlParameter("@SerialNumber",SerialNumber );
               param[5] = new SqlParameter("@TakeBackDelay_price", TakeBackDelay_price);
               param[6] = new SqlParameter("@DetailsId", DetailsId);
               param[7] = new SqlParameter("@discount", discount);
               param[8] = new SqlParameter("@Fsum", Fsum);
               param[9] = new SqlParameter("@FkTaxIdBack", FkTaxIdBack);
               param[10] = new SqlParameter("@M_FSum_Delay", M_FSum_Delay);
               
               SqlHelper.ExecuteNonQuery(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_master_UpdateForTahvil", param);
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



       public static DataSet GiveAndTake_GetAllInfoByMasterId(string SerialNumber, DateTime GiveBackDateTime, decimal TaxBurden)
       {//problem:age bara search lazem shid ye joori avazesh mikonim ke ba serialNumber va masalan tarikh beshe
           SqlParameter[] param = new SqlParameter[3];
           Database dba = new Database();
           try
           {
               param[0] = new SqlParameter("@SerialNumber", SerialNumber);
               param[1] = new SqlParameter("@GiveBackDateTime", GiveBackDateTime);
               param[2] = new SqlParameter("@TaxBurden", TaxBurden);
               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_GetAllInfoByMasterId",param);

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

       public static DataSet GiveAndTake_returnInfoToEbtal(string SerialNumber, decimal TaxBurden)
       {//problem:age bara search lazem shid ye joori avazesh mikonim ke ba serialNumber va masalan tarikh beshe
           SqlParameter[] param = new SqlParameter[2];
           Database dba = new Database();
           try
           {
               param[0] = new SqlParameter("@SerialNumber", SerialNumber);
               param[1] = new SqlParameter("@TaxBurden", TaxBurden);
               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_returnInfoToEbtal", param);
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


       public static DataSet GiveAndTake_ForSendToPolisList(DateTime exDate,short sts)
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[2];
           try
           {
               param[0] = new SqlParameter("@exDate", exDate);
               param[1] = new SqlParameter("@sts", sts);

              return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_ForSendToPolisList", param);
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
       //------------------------------------------------------------------------------------------------------------------------
       public static bool GiveAndTake_ExistForSendToPolice(DateTime exDate)
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[1];
           try
           {
               param[0] = new SqlParameter("@exDate", exDate);

               return Convert.ToBoolean(SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_ExistForSendToPolice", param));
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
       //----------------------------------------------------------------------------------------------------------------------------
       public static DataSet GiveAndTake_master_UodateSwndToPolice(DateTime exDate, DateTime SendToPoliceDate, Int32 FKUserId_SendToPolic)
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[3];
           try
           {
               param[0] = new SqlParameter("@exDate", exDate);
               param[1] = new SqlParameter("@SendToPoliceDate",SendToPoliceDate );
               param[2] = new SqlParameter("@FKUserId_SendToPolic", FKUserId_SendToPolic);

               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_master_UodateSwndToPolice", param);
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


       #region reports
       public static DataSet GiveAndTake_DailyReport(DateTime  FromDate,DateTime ToDate)
       {
           SqlParameter[] param = new SqlParameter[2];
           Database dba = new Database();
           try
           {
               param[0] = new SqlParameter("@FromDate", FromDate);
               param[1] = new SqlParameter("@ToDate", ToDate);
               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_DailyReport_New", param);

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

       public static DataSet GiveAndTake_AnnualReport(DateTime FromDate, DateTime ToDate)
       {
           SqlParameter[] param = new SqlParameter[2];
           Database dba = new Database();
           try
           {
               param[0] = new SqlParameter("@FromDate", FromDate);
               param[1] = new SqlParameter("@ToDate", ToDate);
               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_AnnualReport_New", param);

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


       public static DataSet DailyReport2(DateTime FromDate, DateTime ToDate)
       {
           SqlParameter[] param = new SqlParameter[2];
           Database dba = new Database();
           try
           {
               param[0] = new SqlParameter("@FromDate", FromDate);
               param[1] = new SqlParameter("@ToDate", ToDate);
               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "DailyReport2", param);

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

       public static DataSet Report_SystemDetails(string WhereCondition)
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[1];

           try
           {
               param[0] = new SqlParameter("@WhereCondition", WhereCondition);
               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Report_SystemDetails", param);
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


       public static DataSet Report_ebtal()
       {
           SqlParameter[] param = new SqlParameter[1];
           Database dba = new Database();
           try
           {
               
               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Report_ebtal");

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
       //--------------------------------------------------------------------------------------------------------------------------
       public static DataSet Report_EditedFish(string WhereCondition)
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[1];

           try
           {
               param[0] = new SqlParameter("@WhereCondition", WhereCondition);
               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Report_EditedFish", param);
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


       #endregion
    }

}
