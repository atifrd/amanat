using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Amanat_BO
{
   public class Accounts
    {
       public static DataSet Account_SelectAll()
       {
           Database dba = new Database();

           try
           {

               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Account_SelectAll");
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




       public static void Account_insert(int AccountCode, string AccountName, string AccountNumber, int FKBranchId)
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[4];
           try
           {
               param[0] = new SqlParameter("@AccountCode", AccountCode);
               param[1] = new SqlParameter("@AccountName", AccountName);
               param[2] = new SqlParameter("@AccountNumber", AccountNumber);
               param[3] = new SqlParameter("@FKBranchId", FKBranchId);
               SqlHelper.ExecuteNonQuery(dba.getConnection(), CommandType.StoredProcedure, "Account_insert", param);
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

       public static void Account_Edit(int AccountCode, string AccountName, string AccountNumber, int FKBranchId, int AccountId)
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[5];
           try
           {
               param[0] = new SqlParameter("@AccountCode", AccountCode);
               param[1] = new SqlParameter("@AccountName", AccountName);
               param[2] = new SqlParameter("@AccountNumber", AccountNumber);
               param[3] = new SqlParameter("@FKBranchId", FKBranchId);
               param[4] = new SqlParameter("@AccountId", AccountId);
               SqlHelper.ExecuteNonQuery(dba.getConnection(), CommandType.StoredProcedure, "Account_Edit", param);
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
       public static string Account_GetAccountbyCode(int AccountCode)
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[1];
           try
           {
               param[0] = new SqlParameter("@AccountCode", AccountCode);
               return SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "Account_GetAccountbyCode",param).ToString();
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
