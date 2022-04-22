using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Amanat_BO
{
   public class baggages
    {
       public static DataSet Baggage_SelectBybaggageCode(int baggageCode)
       {
           Database dba = new Database();
           SqlParameter[] param = new SqlParameter[1];
           try
           {
               param[0] = new SqlParameter("@baggageCode", baggageCode);
               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Baggage_SelectBybaggageCode", param);
           }
           catch (Exception)
           {

               throw;
           }
           finally
           {
               dba.getConnection().Close();
           }
       }

       public static DataSet Baggage_SelectAll()
       {
           Database dba = new Database();
           try
           {
               return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Baggage_SelectAll");
           }
           catch (Exception)
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
