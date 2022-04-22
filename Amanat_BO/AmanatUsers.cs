using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace Amanat_BO
{
    public class AmanatUsers
    {
        public static DataSet UserSelectAll()
        {
            Database dba = new Database();

            try
            {

                return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "UserSelectAll");
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


        public static void User_NewUser(string family, string Username, byte[] Password,Int16 FKRoleId)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[4];
            try
            {
                param[0] = new SqlParameter("@family", family);
                param[1] = new SqlParameter("@Username", Username);
                param[2] = new SqlParameter("@Password", Password);
                param[3] = new SqlParameter("@FKRoleId ", FKRoleId);
                SqlHelper.ExecuteNonQuery(dba.getConnection(), CommandType.StoredProcedure, "User_NewUser", param);
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

        public static DataSet AmanatUsers_Loggin(string Username, byte[] Password)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[2];
            try
            {
                param[0] = new SqlParameter("@Username", Username);
                param[1] = new SqlParameter("@Password", Password);
                return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "AmanatUsers_Loggin", param);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                dba.getConnection().Close();
            }
        }

        public static DataSet Role_SelectAll()
        {
            Database dba = new Database();
            try
            {
                return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "Role_SelectAll");
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
        public static void AmanatUsers_Delete(int UserId)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[1];
            try
            {
                 param[0] = new SqlParameter("@UserId", UserId);
                 SqlHelper.ExecuteNonQuery(dba.getConnection(), CommandType.StoredProcedure, "AmanatUsers_Delete", param);
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
