using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KM77.BLL;

namespace Amanat_UIS.Reports
{
    public partial class monthlyReport : Form
    {
        public monthlyReport()
        {
            InitializeComponent();
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();

            
            customizedThemeObj.ControlStyle(groupBox1);
            customizedThemeObj.ControlStyle(groupBox2);
            customizedThemeObj.FormStyle(this);
         
            customizedThemeObj.RadReportGriedStyle(radGRD_Monthly);
           
        }
        private void bTN_List_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataSet ds;
            try
            {
                ds = Amanat_BO.GiveAndTakes.GiveAndTake_DailyReport(BLLDate.getGregorianDate(masked_FromDate.Text.Remove(2, 1).Remove(5, 1)), BLLDate.getGregorianDate(masked_ToDate.Text.Remove(2, 1).Remove(5, 1)));
                radGRD_Monthly.DataSource = ds.Tables[0];
                     decimal x =0;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                     x += Convert.ToDecimal(ds.Tables[0].Rows[i]["realSum"]);
                    if (ds.Tables[0].Rows[i]["Mydate"] != string.Empty)
                        radGRD_Monthly.Rows[i].Cells["Mydate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["Mydate"]), false);
                }
                if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                    label_SumMoney.Text = Amanat_BO.Helper.GetCurrencyFormat(x.ToString())+"  "+"ریال" ;
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
            finally
            {
                Cursor = Cursors.Default;
            }


        }

        private void monthlyReport_Load(object sender, EventArgs e)
        {
            SetFormStyles();
            masked_ToDate.Text = BLLDate.getPersianDate(System.DateTime.Now,true);
            masked_FromDate.Text = BLLDate.getPersianDate(System.DateTime.Now, true);
        }

        private void monthlyReport_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.F)
            {
                BTN_Print_Click(sender, e);
            }
        }

        private void BTN_Print_Click(object sender, EventArgs e)
        {
            DataSet ds;
            
            try
            {
                ds = Amanat_BO.GiveAndTakes.GiveAndTake_DailyReport(BLLDate.getGregorianDate(masked_FromDate.Text.Remove(2, 1).Remove(5, 1)), BLLDate.getGregorianDate(masked_ToDate.Text.Remove(2, 1).Remove(5, 1)));
                ds.Tables[0].Columns.Add("StrMydate");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i]["Mydate"] != string.Empty)
                        ds.Tables[0].Rows[i]["StrMydate"] = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["Mydate"]), false);
                }
                Amanat_BO.Helper.SetReportAppearance(stiReportMonthlyReport,this);
                Amanat_BO.Helper.Print(ds, stiReportMonthlyReport);
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
            
            
        }
    }
}
