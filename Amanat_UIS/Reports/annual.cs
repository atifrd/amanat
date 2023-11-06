using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KM77.BLL;
using Telerik.WinControls.UI.Localization;

namespace Amanat_UIS.Reports
{
    public partial class annual : Form
    {
        public annual()
        {
            InitializeComponent();
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.FormStyle(this);
            customizedThemeObj.RadReportGriedStyle(radGRD_Monthly);
        }
        private void annual_Load(object sender, EventArgs e)
        {
            SetFormStyles();
            masked_ToDate.Text = BLLDate.getPersianDate(System.DateTime.Now,true);
            masked_FromDate.Text = BLLDate.getPersianDate(System.DateTime.Now, true);
        }

        private void annual_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.F)
            {
                BTN_Print_Click(sender, e);
            }
        }

        private void bTN_List_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataTable dt;
            try
            {
                dt = Amanat_BO.GiveAndTakes.GiveAndTake_AnnualReport(BLLDate.getGregorianDate(masked_FromDate.Text.Remove(2, 1).Remove(5, 1)), BLLDate.getGregorianDate(masked_ToDate.Text.Remove(2, 1).Remove(5, 1))).Tables[0];
              radGRD_Monthly.DataSource = dt;
              decimal x = 0;
              for (int i = 0; i < dt.Rows.Count; i++)
              {
                  x += Convert.ToDecimal(dt.Rows[i]["realSum"]);     
              }
              if (dt != null && dt.Rows.Count > 0)
                  label_SumMoney.Text = Amanat_BO.Helper.GetCurrencyFormat(x.ToString()) + "  " + "ریال";



              /*  for (int i = 0; i < dt.Rows.Count; i++)
                {
                   // if (dt.Rows[i]["Mydate"] != string.Empty)
                     //   GRD_Monthly.Rows[i].Cells["Mydate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(dt.Rows[i]["Mydate"])).Substring(3, 7);
                }*/
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

        private void BTN_Print_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataSet ds;
            
            try
            {
                ds = Amanat_BO.GiveAndTakes.GiveAndTake_AnnualReport(BLLDate.getGregorianDate(masked_FromDate.Text.Remove(2, 1).Remove(5, 1)), BLLDate.getGregorianDate(masked_ToDate.Text.Remove(2, 1).Remove(5, 1)));

                Amanat_BO.Helper.SetReportAppearance(stiReportAnnualReport, this);
                Amanat_BO.Helper.Print(ds, stiReportAnnualReport); 
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
    }
}
