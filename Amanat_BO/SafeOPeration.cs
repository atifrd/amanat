using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using System.IO;
namespace Amanat_BO
{
    public class SafeOPeration
    {

        public static void SafeOPeration_insert(long SafeOPSerialNumber, DateTime FishDateTime
            , int AccountCode, string FishNumber, long SafeOPId, string FishDesc, Int16 Statuse, decimal Bes, decimal Mandeh, int FkUserId
            ,string PicName,string PicNewName)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[11];
            try
            {
                string Path = System.Configuration.ConfigurationManager.AppSettings["FishPicPath"].ToString().Trim();
                if (Directory.Exists(Path) && PicName != string.Empty && PicNewName != string.Empty)
                    File.Copy(PicName, Path + PicNewName);
                else Path = string.Empty;
                    param[0] = new SqlParameter("@SafeOPSerialNumber", SafeOPSerialNumber);
                    param[1] = new SqlParameter("@FishDateTime", FishDateTime);
                    param[2] = new SqlParameter("@AccountCode", AccountCode);
                    param[3] = new SqlParameter("@FishNumber", FishNumber);
                    param[4] = new SqlParameter("@FishDesc", FishDesc);
                    param[4] = new SqlParameter("@FishDesc", FishDesc);
                    param[5] = new SqlParameter("@SafeOPId", SafeOPId);
                    param[6] = new SqlParameter("@Statuse", Statuse);
                    param[7] = new SqlParameter("@Bes", Bes);
                    param[8] = new SqlParameter("@Mandeh", Mandeh);
                    param[9] = new SqlParameter("@FkUserId", FkUserId);
                    param[10] = new SqlParameter("@FishUrl", Path + PicNewName);
                    SqlHelper.ExecuteNonQuery(dba.getConnection(), CommandType.StoredProcedure, "SafeOPeration_insert", param);
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



        public static string  GiveAndTake_MoneyInSafe(DateTime MyDate)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[1];
            try
            {
                param[0] = new SqlParameter("@MyDate", MyDate);
                return SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "GiveAndTake_MoneyInSafe", param).ToString();
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


        public static string SafeOPerationGetLastNumber()
        {
            Database dba = new Database();
            try
            {
                return SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "SafeOPerationGetLastNumber").ToString();
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




        public static DataSet SafeOPeration_List(string WhereCondition)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[1];

            try
            {
                param[0] = new SqlParameter("@WhereCondition", WhereCondition);
                return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "SafeOPeration_List",param);
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
