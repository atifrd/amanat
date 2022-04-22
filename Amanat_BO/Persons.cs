using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Amanat_BO
{
   public class Persons
    {
       public static DataSet Person_MySelectAll()
       {
           Database dba = new Database();

           try
           {

               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Person_MySelectAll");
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
       public static Int64 Person_insert(string PersonName)
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[1];
           try
           {
               param[0] = new SqlParameter("@PersonName", PersonName);
               //param[1] = new SqlParameter("@BranchName", BranchName);
               return Convert.ToInt64(SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "Person_insert", param));
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
       public static string Person_SelectIdByName(string PersonName)
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[1];

           try
           {
               param[0] = new SqlParameter("@PersonName", PersonName);
               return SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "Person_SelectIdByName",param).ToString();
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
