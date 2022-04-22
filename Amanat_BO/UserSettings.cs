using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amanat_BO
{
   public class UserSettings
    {
        public static int UserID { get; set; }
        public static int RoleID { get; set; }
        public static string Name { get; set; }
        public static bool isSuperVisor { get; set; }
        public static Int16 TaxId { get; set; }
        public static decimal TaxBurden { get; set; }
        public static Int16 SessionNo { get; set; }
        public static string MaskedDate { get; set; }
       // print setting
        public static string PageHeader { get; set; }
        public static string PrintTxt { get; set; }
        public static string OfficeTell { get; set; }
        public static string Print_Font { get; set; }
    }
}
