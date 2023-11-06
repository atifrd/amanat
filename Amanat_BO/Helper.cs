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

            if (Price == "0" || Price == "" || Price == "0.0") return "0";

            return decimal.Parse(Price).ToString("#,#");
        }

        public static void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData == System.Windows.Forms.Keys.Enter)
            {

                SendKeys.Send("{TAB}"); return;
            }

            else if (e.KeyCode == Keys.Escape)
            {
                ((Form)sender).Close(); return;
            }


        }
        public static void SetReportAppearance(StiReport StiReportobj, Form MyForm)
        {
            string[] StifooterBand_font = Amanat_BO.UserSettings.Print_Font.Split(';');
            //StiDataBand stidataband = ((StiDataBand)StiReportobj.Pages["Page1"].Components["DataDSDetails2"]);
            //stidataband.SetFont(new Font(StiDataBand_font[0], float.Parse(StiDataBand_font[1]), bool.Parse(StiDataBand_font[2])?FontStyle.Bold:FontStyle.Regular));
            StiText TextDate = null;
            StiText TextTime = null;
            StiText TextUser = null;
            //  StiText Text18 = null;//line
            StiText Text1 = null;

            try
            {//marboot be fish ha
                // StiReportobj.Pages["Page1"].SetFont(new Font("Tahoma", 45, FontStyle.Bold));
                StiFooterBand stfooter = ((StiFooterBand)StiReportobj.Pages["Page1"].Components["FooterBand2"]);
                TextDate = ((StiText)stfooter.Components["TextDate"]);
                TextTime = ((StiText)stfooter.Components["TextTime"]);
                TextUser = ((StiText)stfooter.Components["TextUser"]);



                StiFooterBand stfooterBand1 = ((StiFooterBand)StiReportobj.Pages["Page1"].Components["FooterBand1"]);
                Text1 = ((StiText)stfooterBand1.Components["Text1"]);//{{VPrintTxt} {VOfficeTell}}
                Text1.Font = new Font("LMN Lotus", 6, FontStyle.Regular);//توضیحات پایین فیش     
            }
            catch (Exception)
            {//marboot be gozareshat
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
                TextUser.Font = TextDate.Font = TextTime.Font = new Font("LMN Lotus", 7, FontStyle.Regular);
            }



            StiPageHeaderBand stPageHeader = ((StiPageHeaderBand)StiReportobj.Pages["Page1"].Components["PageHeaderBand1"]); //stPageHeader.Height = 1.5;
            StiText TextTitel = ((StiText)stPageHeader.Components["TextTitel"]);
            TextTitel.Text = Amanat_BO.UserSettings.PageHeader + System.Environment.NewLine + CustomHeader.SetReport_CustomHeader(MyForm);// "دفتر امانات پایانه مسافربری شهرداری مشهد";

            // TextTitel.Font = new Font("Tahoma", 12,FontStyle.Bold);
            TextTitel.Font = new Font(Amanat_BO.UserSettings.Print_Font.Split(';')[0], 12, FontStyle.Bold);
            TextTitel.AutoWidth = true; TextTitel.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;

        }
        public static void Print(DataSet ds, StiReport StiReportobj)
        {
            try
            {
                StiReportobj.Dictionary.DataSources.Items[0].DataTable = ds.Tables[0];

                StiReportobj.RegData("Datasource1", ds.Tables[0]);

                StiReportobj.Dictionary.Synchronize();
                StiReportobj.Render();
                //  StiReportobj.Show();
                var parr = StiReportobj.Pages;
                //Create Printer Settings
                PrinterSettings printerSettings = new PrinterSettings();
                printerSettings.Copies = 1;
                printerSettings.FromPage = 1;
                printerSettings.ToPage = StiReportobj.RenderedPages.Count;
                //Direct Print - Don't Show Print Dialog
                StiReportobj.Print(true, printerSettings);
            }
            catch (Exception ex)
            {

               
            }
           
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
        public static Panel CreateFloatingPanel(Panel originalPanel, Form MyForm)
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




        public static void FishMainBody_SetFont(StiReport StiReportobj)
        {
            //(فونت اطلاعات فرد صاحب فیش و کالاهاش(جدول محموله های تحویل شده ش
            StiPanel stpanel = ((StiPanel)StiReportobj.Pages["Page1"].Components["Panel2"]);
            StiText TextSerial = ((StiText)stpanel.Components["TextSerial"]);
            StiText TextTell = ((StiText)stpanel.Components["TextTell"]);
            StiText TextName = ((StiText)stpanel.Components["TextName"]);

            StiText TextGiVeDate = ((StiText)stpanel.Components["Text12"]);
            StiText TextBackDate = ((StiText)stpanel.Components["Text14"]);
            StiText TextBackTime = ((StiText)stpanel.Components["Text15"]);
            StiText TextGiveTime = ((StiText)stpanel.Components["Text16"]);




            TextName.Font = TextTell.Font =
                TextGiVeDate.Font = TextBackDate.Font = TextBackTime.Font = TextGiveTime.Font =
                new Font("LMN Lotus", 9, FontStyle.Regular);

            TextSerial.Font = new Font("LMN Lotus", 10, FontStyle.Bold);


            StiDataBand stdata = ((StiDataBand)StiReportobj.Pages["Page1"].Components["DataDSDetails2"]);
            StiText DataDSDetails_Price = ((StiText)stdata.Components["DataDSDetails_Price2"]);
            StiText DataDSDetails_MySum = ((StiText)stdata.Components["DataDSDetails_MySum2"]);
            StiText DataDSDetails_BaggageCount = ((StiText)stdata.Components["DataDSDetails_BaggageCount2"]);
            StiText DataDSDetails_baggageCode = ((StiText)stdata.Components["DataDSDetails_baggageCode2"]);
            StiText Text21 = ((StiText)stdata.Components["Text21"]);//ردیف


            StiFooterBand FooterDSDetails = ((StiFooterBand)StiReportobj.Pages["Page1"].Components["FooterDSDetails"]);
            StiText Text19 = ((StiText)FooterDSDetails.Components["Text19"]);//جمع کل


            Text19.Font = Text21.Font =
                DataDSDetails_baggageCode.Font =
                DataDSDetails_BaggageCount.Font =
                DataDSDetails_MySum.Font =
                DataDSDetails_Price.Font
                = new Font("LMN Lotus", 9, FontStyle.Regular);
        }









    }
}