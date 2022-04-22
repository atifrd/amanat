using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Amanat_BO
{
   public class sysSetting
    {
       public static DataSet sysSetting_Load()
       {
           Database dba = new Database();
           try
           {
               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "sysSetting_Load");
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
       public static void sysSetting_Change(string PrintTxt, string OfficeTell, string PageHeader, string Print_Font)
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[4];
           try
           {
               param[0] = new SqlParameter("@PrintTxt", PrintTxt);
               param[1] = new SqlParameter("@OfficeTell", OfficeTell);
               param[2] = new SqlParameter("@PageHeader", PageHeader);
               param[3] = new SqlParameter("@Print_Font", Print_Font);
               SqlHelper.ExecuteNonQuery(dba.getConnection(), CommandType.StoredProcedure, "sysSetting_Change", param);
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
