using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using KM77.BLL;

namespace Amanat_BO
{
    public class SysLog
    {
        public static string myLog;

        public SysLog()
		{
           // LogFile.myLog = new string(s2.ToCharArray());
		}
		 public static void WriteInLogFile(string log)
		{

            string s2 = System.Configuration.ConfigurationManager.AppSettings["logPath"].ToString().Trim();
            SysLog.myLog = new string(s2.ToCharArray());

            string mydate = BLLDate.getPersianDate(System.DateTime.Now.Date, false);

			try
			{
                StreamWriter srw = new StreamWriter(SysLog.myLog, true);
				srw.WriteLine("----------------------------------------------------------");
				srw.WriteLine(" مورخ : " + mydate + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute);
				srw.WriteLine(log);
				srw.WriteLine("----------------------------------------------------------");
				srw.Close();
			}
			catch(Exception ex)
			{ }
		}
    }
}
