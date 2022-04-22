using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;


namespace Amanat_BO
{
    public class Systemsession
    {
       /* public static string getNowsession(DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            string PMonth = pc.GetMonth(dt).ToString();
            string PYear = pc.GetYear(dt).ToString().Substring(2,2);
           if (PMonth=="1" || PMonth=="2" || PMonth=="3")
           {
               return PYear+"1";
           }
            if (PMonth=="4" || PMonth=="5" || PMonth=="6")
           {
               return PYear+"2";
           }
            if (PMonth=="7" || PMonth=="8" || PMonth=="9")
           {
               return PYear+"3";
           }
            if (PMonth == "10" || PMonth == "11" || PMonth == "12")
            {
                return PYear + "4";
            }

            return "";
        }
        public static string getNextSession(String SystemSession)
        {
            string Psession =SystemSession.Substring(2,1);
            string PYear = SystemSession.Substring(0,2);
            if (Psession == "4")
            {
                Psession = "1";
                PYear = (int.Parse(PYear) + 1).ToString();
            }
            else Psession = (int.Parse(Psession) + 1).ToString();
            return  (PYear+Psession);

        }
        public static string getpreviousSession(String SystemSession)
        {
            string Psession = SystemSession.Substring(2, 1);
            string PYear = SystemSession.Substring(0, 2);
            if (Psession == "1")
            {
                Psession = "4";
                PYear = (int.Parse(PYear) - 1).ToString();
            }
            else Psession = (int.Parse(Psession) - 1).ToString();
            return (PYear + Psession);
        }
        public static bool IsItStartOfSession(DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            string PMonth = pc.GetMonth(dt).ToString();
            string PDay = pc.GetDayOfMonth(dt).ToString();
            if ((PMonth == "1" || PMonth == "4" || PMonth == "7" || PMonth == "10") && PDay == "1")
                return true;
            return false;

        }*/
        /*public static Boolean SystemSession_Insert(DateTime FromDate, DateTime ToDate, Int16 SessionNo)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[3];
            try
            {
                param[0] = new SqlParameter("@FromDate", FromDate);
                param[1] = new SqlParameter("@ToDate", ToDate);
                param[2] = new SqlParameter("@SessionNo", SessionNo);
                return Convert.ToBoolean(SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "SystemSession_Insert", param));
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                dba.getConnection().Close();
            }
        }*/


        public static Int16 SystemSession_MakeDeactiveOldOne_CreateNewOne(int SessionId, DateTime OldSessionTodate, DateTime NewSessionFromDate, DateTime NewSessionToDate
            , int SessionNo, int FKUserId)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[6];
            try
            {
                param[0] = new SqlParameter("@SessionId", SessionId);
                param[1] = new SqlParameter("@OldSessionTodate", OldSessionTodate);
                param[2] = new SqlParameter("@NewSessionFromDate", NewSessionFromDate);
                param[3] = new SqlParameter("@NewSessionToDate", NewSessionToDate);
                param[4] = new SqlParameter("@SessionNo", SessionNo);
                param[5] = new SqlParameter("@FKUserId", FKUserId);
                return Convert.ToInt16(SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "SystemSession_MakeDeactiveOldOne_CreateNewOne", param));
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

        public static DataSet SystemSession_SelectAll()
        {
            Database dba = new Database();
            try
            {
                return SqlHelper.ExecuteDataset(dba.getConnection(), CommandType.StoredProcedure, "SystemSession_SelectAll");
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

        public static string SystemSession_getActiveSession(DateTime NowDate)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[1];
            try
            {
                param[0] = new SqlParameter("@NowDate", NowDate);
                return Convert.ToString(SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "SystemSession_getActiveSession",param));
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

        public static string SystemSession_getpreviousSession(string SessionNo)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[1];
            try
            {
                param[0] = new SqlParameter("@SessionNo", SessionNo);
                return Convert.ToString(SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "SystemSession_getpreviousSession",param));
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

        public static string SystemSession_getNextSession(string SessionNo)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[1];
            try
            {
                param[0] = new SqlParameter("@SessionNo", SessionNo);
                return Convert.ToString(SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "SystemSession_getNextSession", param));
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





        public static Boolean SystemSession_SessionIsExpired(DateTime NowDate)
        {
            Database dba = new Database();
            SqlParameter[] param = new SqlParameter[1];
            try
            {
                param[0] = new SqlParameter("@NowDate", NowDate);
                return Convert.ToBoolean(SqlHelper.ExecuteScalar(dba.getConnection(), CommandType.StoredProcedure, "SystemSession_SessionIsExpired", param));
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
