using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Amanat_BO
{
   public class Bank
    {
       public static DataSet Bank_SelectAll()
       {
           Database dba = new Database();
           
           try
           {

               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Bank_selectAll");
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


       public static void Bank_insert(string BankName, string BranchName, string BranchDesc)
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[3];
           try
           {
               param[0] = new SqlParameter("@BankName", BankName);
               param[1] = new SqlParameter("@BranchName", BranchName);
               param[2] = new SqlParameter("@BranchDesc", BranchDesc);
               SqlHelper.ExecuteNonQuery(dba.getConnection(), CommandType.StoredProcedure, "Bank_insert", param);
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


       public static void Bank_Update(int BankId, int BranchId, string BankName, string BranchName, string BranchDesc)
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[5];
           try
           {


               param[0] = new SqlParameter("@BankName", BankName);
               param[1] = new SqlParameter("@BranchName", BranchName);
               param[2] = new SqlParameter("@BranchDesc", BranchDesc);
               param[3] = new SqlParameter("@BankId", BankId);
               param[4] = new SqlParameter("@BranchId", BranchId);
               SqlHelper.ExecuteNonQuery(dba.getConnection(), CommandType.StoredProcedure, "Bank_Update", param);
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
