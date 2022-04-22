using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace KM77.BLL
{
    public class BLLDate
    {
        public static PersianCalendar pc = new PersianCalendar();
        public static string getPersianDay(string day)
        {
            string[] PDay = new string[7];
            PDay[0] = "شنبه"; PDay[1] = "یکشنبه"; PDay[2] = "دوشنبه"; PDay[3] = "سه شنبه"; PDay[4] = "چهارشنبه"; PDay[5] = "پنج شنبه"; PDay[6] = "جمعه";
            switch (day)
            {
                case "Saturday":
                    return PDay[0].ToString();
                case "Sunday":
                    return PDay[1].ToString();
                case "Monday":
                    return PDay[2].ToString();
                case "Tuesday":
                    return PDay[3].ToString();
                case "Wednesday":
                    return PDay[4].ToString();
                case "Thursday":
                    return PDay[5].ToString();
                case "Friday":
                    return PDay[6].ToString();
                default:
                    return "خطا";
            }
        }

        public static string getPersianMonth(int month)
        {
            string[] PMonth = new string[12];
            PMonth[0] = "فروردین";
            PMonth[1] = "اردیبهشت";
            PMonth[2] = "خرداد";
            PMonth[3] = "تیر";
            PMonth[4] = "مرداد";
            PMonth[5] = "شهریور";
            PMonth[6] = "مهر";
            PMonth[7] = "آبان";
            PMonth[8] = "آذر";
            PMonth[9] = "دی";
            PMonth[10] = "بهمن";
            PMonth[11] = "اسفند";

            return PMonth[month - 1];
        }

        public static string getFullStringPersianDate(DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            string month = getPersianMonth(pc.GetMonth(dt));
            string date = getPersianDay(dt.DayOfWeek.ToString()) + " " + pc.GetDayOfMonth(dt) + " " + month + " " + pc.GetYear(dt);
            //string date = pc.GetDayOfMonth(dt) + " " + month.Substring(0, month.Length > 3 ? 3 : month.Length) + IANNSetting.getPersianDay(dt.DayOfWeek.ToString()).Substring(0, 4);
            return date;

        }

        //public static string getFullStringPersianDate(string  FarsiDate)
        //{
        //    PersianCalendar pc = new PersianCalendar();
        //    pc.get
        //    BllPrice.price.PDay = FarsiDate.Substring(0, 2);
        //    BllPrice.price.PMonth = FarsiDate.Substring(3, 2);
        //    BllPrice.price.PYear = FarsiDate.Substring(6, 4);
        //    string date = IANNSetting.getPersianDay(dt.DayOfWeek.ToString()) + " " + pc.GetDayOfMonth(dt) + " " + month + " " + pc.GetYear(dt);
        //    //string date = pc.GetDayOfMonth(dt) + " " + month.Substring(0, month.Length > 3 ? 3 : month.Length) + IANNSetting.getPersianDay(dt.DayOfWeek.ToString()).Substring(0, 4);
        //    return date;
        //}

        public static string getPersianDate(DateTime dt, bool IsMaskedtxtBox)
        {
            PersianCalendar pc = new PersianCalendar();
            string m = pc.GetMonth(dt).ToString();
            string day = pc.GetDayOfMonth(dt).ToString();
            if (IsMaskedtxtBox)
                return (day.Length == 1 ? "0" + day : day) + "/" + (m.Length == 1 ? "0" + m : m) + "/" + pc.GetYear(dt).ToString().Substring(1, 3);
            //1400 problem
            //return (day.Length == 1 ? "0" + day : day) + "/" + (m.Length == 1 ? "0" + m : m) + "/" + pc.GetYear(dt).ToString().Substring(2,2);
            else return pc.GetYear(dt).ToString() + "/" + (m.Length == 1 ? "0" + m : m) + "/" + (day.Length == 1 ? "0" + day : day);
        }

        public static DateTime getGregorianDate(string pdate)
        {
            int day = int.Parse(pdate.Substring(0, 2));
            int month = int.Parse(pdate.Substring(3, 2));
            int year = int.Parse(pdate.Substring(6, 4));
            int hour = 0;
            int min = 0;
            if (pdate.Length > 10)
            {
                hour = int.Parse(pdate.Substring(11, 2));
                min = int.Parse(pdate.Substring(14, 2));
            }
            PersianCalendar pc = new PersianCalendar();

            return pc.ToDateTime(year, month, day, hour, min, 0, 0);
        }

        public static string getPersianYear(DateTime dt)
        {
            return pc.GetYear(dt).ToString();
        }

        public static int getPersianMonth(DateTime dt)
        {
            return pc.GetMonth(dt);
        }

        public static DateTime GetDateAfterNDays(DateTime FirstDate, int days)
        {
            return new DateTime(FirstDate.Year, FirstDate.Month, FirstDate.Day).AddDays(days);
        }

        public static DateTime GetDateAfterNMonth(DateTime FirstDate, int month)
        {
            return new DateTime(FirstDate.Year, FirstDate.Month, FirstDate.Day).AddMonths(month);
        }

        public static DateTime GetDateAfterNYears(DateTime FirstDate, int year)
        {
            return new DateTime(FirstDate.Year, FirstDate.Month, FirstDate.Day).AddMonths(year);
        }
        public static bool IsPersianLeapYear(int year)
        {
            return pc.IsLeapYear(year);
        }
        /// <summary>
        /// Compares two instances of PersianDate and returns an integer that indicates whether the first instance is earlier than, the same as, or later than the second instance.
        /// </summary>
        public static int Compare(string firstPersianDate, string secondPersianDate)
        {
            DateTime GfirstPersianDate = getGregorianDate(firstPersianDate);
            DateTime GsecondPersianDate = getGregorianDate(secondPersianDate);
            return DateTime.Compare(GfirstPersianDate, GsecondPersianDate);

        }

        /// <summary>
        /// tarike shamsi ba formate yyyy/mm/dd r   ro tabdil be dd/mm/yyyy mokonad
        /// </summary>
        /// <param name="RTLPDate"></param>
        /// <returns></returns>
        public static string ConvertRTLPDateToLTRPdate(string RTLPDate)
        {
            return RTLPDate.Substring(8, 2) + "/" + RTLPDate.Substring(5, 2) + "/" + RTLPDate.Substring(0, 4);

        }


        /// <summary>
        /// tarike shamsi ba formate dd/mm/yy r   ro tabdil be yyyy/mm/dd mokonad
        /// </summary>
        /// <param name="RTLPDate"></param>
        /// <returns></returns>
        public static string ConvertLTRPDateTORTLPDatedate(string LTRPDate)
        {
            return LTRPDate.Substring(6, 4) + "/" + LTRPDate.Substring(3, 2) + "/" + LTRPDate.Substring(0, 2);

        }
    }
}
