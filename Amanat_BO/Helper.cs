using System;
using System.Data;
using System.Configuration;
using System.Web;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Stimulsoft.Report;
using System.Data;
using System.Drawing.Printing;
using Stimulsoft.Report.Components;
using KM77.BLL;
using System.Drawing;
using System.Windows.Forms;

namespace Amanat_BO
{
    public class Helper
    {
       
       public static string GetCurrencyFormat(string Price)
        {
           
           if (Price=="0" || Price=="" || Price=="0.0") return "0";
            
           return decimal.Parse(Price).ToString("#,#");
        }
  
       public static void  KeyDownEvent(object sender, KeyEventArgs e)
       {
           if (e.KeyData == System.Windows.Forms.Keys.Enter   )
           {
              
               SendKeys.Send("{TAB}"); return;
           }

           else if (e.KeyCode == Keys.Escape)
           {
               ((Form)sender).Close(); return;
           }
           
           
       }
       public static void SetReportAppearance(StiReport StiReportobj,Form MyForm)
       {
           string[] StifooterBand_font =Amanat_BO.UserSettings.Print_Font.Split(';');
           //StiDataBand stidataband = ((StiDataBand)StiReportobj.Pages["Page1"].Components["DataDSDetails2"]);
           //stidataband.SetFont(new Font(StiDataBand_font[0], float.Parse(StiDataBand_font[1]), bool.Parse(StiDataBand_font[2])?FontStyle.Bold:FontStyle.Regular));
           StiText TextDate = null;
           StiText TextTime = null;
           StiText TextUser = null;

           try
           {
               StiFooterBand stfooter = ((StiFooterBand)StiReportobj.Pages["Page1"].Components["FooterBand2"]);
               TextDate = ((StiText)stfooter.Components["TextDate"]);
               TextTime = ((StiText)stfooter.Components["TextTime"]);
               TextUser = ((StiText)stfooter.Components["TextUser"]);

           }
           catch (Exception)
           {
               StiPageFooterBand Pagestfooter = ((StiPageFooterBand)StiReportobj.Pages["Page1"].Components["PageFooterBand1"]);
               TextDate = ((StiText)Pagestfooter.Components["TextDate"]);
               TextTime = ((StiText)Pagestfooter.Components["TextTime"]);
               TextUser = ((StiText)Pagestfooter.Components["TextUser"]);

           }
           finally
           {
               TextDate.Text = "    تاریخ چاپ  " + "  " + BLLDate.getPersianDate(System.DateTime.Now, false); TextDate.AutoWidth = true;

               TextTime.Text = System.DateTime.Now.TimeOfDay.ToString().Substring(0, 5) + "   " + "زمان چاپ " + "   "; TextTime.AutoWidth = true;
               TextUser.AutoWidth = true;
               TextUser.Text = "تهیه کننده :" + "  " + Amanat_BO.UserSettings.Name;

           }

           
           
           StiPageHeaderBand stPageHeader = ((StiPageHeaderBand)StiReportobj.Pages["Page1"].Components["PageHeaderBand1"]); //stPageHeader.Height = 1.5;
           StiText TextTitel = ((StiText)stPageHeader.Components["TextTitel"]);
           TextTitel.Text = Amanat_BO.UserSettings.PageHeader +System.Environment.NewLine+CustomHeader.SetReport_CustomHeader(MyForm);// "دفتر امانات پایانه مسافربری شهرداری مشهد";
               
          // TextTitel.Font = new Font("Tahoma", 12,FontStyle.Bold);
           TextTitel.Font = new Font(Amanat_BO.UserSettings.Print_Font.Split(';')[0], 12, FontStyle.Bold);
           TextTitel.AutoWidth = true; TextTitel.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
           
       }
       public static void Print(DataSet ds, StiReport StiReportobj)
       {   
           StiReportobj.Dictionary.DataSources.Items[0].DataTable = ds.Tables[0];

           StiReportobj.RegData("Datasource1", ds.Tables[0]);
           StiReportobj.Dictionary.Synchronize(); 
           StiReportobj.Render();
           StiReportobj.Show();

           //Create Printer Settings
           PrinterSettings printerSettings = new PrinterSettings();
           printerSettings.Copies = 1;
           printerSettings.FromPage = 1;
           printerSettings.ToPage = StiReportobj.RenderedPages.Count;
           //Direct Print - Don't Show Print Dialog
           StiReportobj.Print(false, printerSettings);
       }

       public static void FishPrint(DataTable dt, StiReport StiReportobj)
       {
           StiReportobj.Dictionary.DataSources.Items[0].DataTable = dt;

           StiReportobj.RegData("Datasource1", dt);
           StiReportobj.Dictionary.Synchronize();
           StiReportobj.Render();
           // StiReportobj.Show();
           //Create Printer Settings
           PrinterSettings printerSettings = new PrinterSettings();
           printerSettings.Copies = 1;
           printerSettings.FromPage = 1;
           printerSettings.ToPage = StiReportobj.RenderedPages.Count;
           //Direct Print - Don't Show Print Dialog
           StiReportobj.Print(false, printerSettings);
       }
       public static Panel CreateFloatingPanel(Panel originalPanel,Form MyForm)
       {
           Bitmap bmp = new Bitmap(originalPanel.Width,
               originalPanel.Height);
           Rectangle rect = new Rectangle(0, 0,
               bmp.Width, bmp.Height);
           originalPanel.DrawToBitmap(bmp, rect);
           foreach (Control ctrl in originalPanel.Controls)
           {
               ctrl.Visible = false;
           }
           using (Graphics g = Graphics.FromHwnd(originalPanel.Handle))
           {
               g.DrawImage(bmp, 0, 0);
               bmp.Dispose();
               SolidBrush brush =
                   new SolidBrush(Color.FromArgb(128, Color.Gray));
               g.FillRectangle(brush, rect);
               brush.Dispose();
           }
           Panel floater = new Panel();
           floater.Size = originalPanel.Size;
           floater.Left = originalPanel.Left - 50;
           floater.Top = originalPanel.Top - 50;
           MyForm.Controls.Add(floater);
           floater.BringToFront();
           return floater;
       }









    }
}