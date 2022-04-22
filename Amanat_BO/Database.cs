using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Collections;

namespace Amanat_BO
{
    class Database
    {
        private SqlConnection sqlConnection;

        public Database()//ok
		{
            try
            {
                 string ConectServer = System.Configuration.ConfigurationManager.ConnectionStrings["connectionStringsSection"].ConnectionString;
                // @"Data Source=(local);Initial Catalog=AllElseHogh;Integrated Security=True";;
                sqlConnection = new SqlConnection(ConectServer);

            }
            catch (Exception ex)
            {

                string a = ex.Message;
                string b = ex.ToString();
            }
		}

		public SqlConnection getConnection() //ok
		{
			return sqlConnection;
		}

    }
}
