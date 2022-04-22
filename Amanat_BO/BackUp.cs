using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Data;
using Microsoft.ApplicationBlocks.Data;



namespace Amanat_BO
{
    public static class BackUp
    {



        #region Public Methods
        /// <summary>
        /// Backup a whole database to the specified file.
        /// </summary>
        /// <remarks>
        /// The database must not be in use when backing up
        /// The folder holding the file must have appropriate permissions given
        /// </remarks>
        /// <param name="backUpFile">Full path to file to hold the backup</param>
        public static void BackupDatabase(string backUpFile)
        {
            Database dba = new Database();
            ServerConnection con = new ServerConnection(dba.getConnection());// new ServerConnection(@".");
            Server server = new Server(con);
            Backup source = new Backup();
            source.Action = BackupActionType.Database;
            source.Database = dba.getConnection().Database;
            BackupDeviceItem destination = new BackupDeviceItem(backUpFile, DeviceType.File);
            source.Devices.Add(destination);
            source.SqlBackup(server);
            con.Disconnect();
        }
        /// <summary>
        /// Restore a whole database from a backup file.
        /// </summary>
        /// <remarks>
        /// The database must not be in use when backing up
        /// The folder holding the file must have appropriate permissions given
        /// </remarks>
        /// <param name="backUpFile">Full path to file to holding the backup</param>
        public static void RestoreDatabase(string backUpFile)
        {
            /*string MyDataBaseName = System.Configuration.ConfigurationManager.AppSettings["MyDataBaseName"].ToString().Trim();
            ServerConnection con = new ServerConnection(@"xxxxx\SQLEXPRESS");
            Server server = new Server(con);
            Restore destination = new Restore();
            destination.Action = RestoreActionType.Database;
            destination.Database = MyDataBaseName;
            BackupDeviceItem source = new BackupDeviceItem(backUpFile, DeviceType.File);
            destination.Devices.Add(source);
            destination.ReplaceDatabase = true;
            destination.SqlRestore(server);*/
        }
        #endregion
        public static DataSet SysBackup_GetList()
        {
            Database dba = new Database();
            try
            {
                return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "SysBackup_GetList");
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
        //-------------------------------------------------------------------------------------------------------------------------------
        public static void SysBackup_Insert(string Description, string BackupDateTime,string BackupPath)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[3];
            try
            {
                param[0] = new SqlParameter("@Description", Description);
                param[1] = new SqlParameter("@BackupDateTime", BackupDateTime);
                param[2] = new SqlParameter("@BackupPath", BackupPath);
                 SqlHelper.ExecuteNonQuery(dba.getConnection(), CommandType.StoredProcedure, "SysBackup_Insert", param);
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

