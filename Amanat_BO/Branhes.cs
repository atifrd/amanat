using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Amanat_BO
{
    public class Branhes
    {
        public static DataSet Branhes_selectAllByBankId(int BankId)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[1];
            try
            {
                param[0] = new SqlParameter("@BankId", BankId);
                return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Branhes_selectAllByBankId",param);
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
