using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Amanat_BO
{
   public class CustomHeader
    {
       public static  string SetReport_CustomHeader(Form MyForm)
       {
            
           string _CustomHeader=string.Empty;
           switch (MyForm.Name)
           {
               case "annual": _CustomHeader = "گزارشات سالیانه"; break;
               case "ReportEbtal": _CustomHeader = "لیست قبض های ابطال شده"; break;
               case "DailyReport": _CustomHeader = "گزارش روزانه"; break;
               case "monthlyReport": _CustomHeader = "گزارش ماهانه"; break;
               case "PassedExpectedDate": _CustomHeader = "لسیت قبض های تحویل گذشته"; break;
               case "SafeOperationList": _CustomHeader = "لیست عملیات صندوق"; break;
               case "SendToPolice_Report": _CustomHeader = "لیست اقلام جهت تحویل به پاسگاه"; break;
               case "SendToPolice": _CustomHeader = "لیست اقلام جهت تحویل به پاسگاه"; break;
               case "SystemDetails": _CustomHeader = "گزارش ریز کارکرد دفتر امانات"; break;
               case "EditList": _CustomHeader = "گزارش فیش های ویرایش  شده"; break;
           }
           return _CustomHeader;
       }
       
   }
}
