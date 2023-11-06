using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KM77.BLL;
using Stimulsoft.Report.Components;

namespace Amanat_UIS.Reports
{
    public partial class SendToPolice_Report : Form
    {
        public SendToPolice_Report()
        {
            InitializeComponent();
        }

        private void TXT_DayCnt_Leave(object sender, EventArgs e)
        {
            maskedToDate.Text = BLLDate.getPersianDate(BLLDate.GetDateAfterNDays(System.DateTime.Now, -(Convert.ToInt32(TXT_DayCnt.Text))),false);
        }

        private void BTN_LIST_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataSet ds;
            try
            {
                short sts=1;
                 //sts = checkBox1.Checked==true ? 4 :1;
                ds = Amanat_BO.GiveAndTakes.GiveAndTake_ForSendToPolisList(BLLDate.getGregorianDate(BLLDate.ConvertRTLPDateToLTRPdate(maskedToDate.Text)),sts);
                Image myImage = global::Amanat_UIS.Properties.Resources.Delay2;
                GRD_List.DataSource = ds.Tables[0];
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    GRD_List.Rows[i].Cells["Eexp_GiveBackDate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["exp_GiveBackDate"]), false);
                    GRD_List.Rows[i].Cells["EGiveDate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["GiveDate"]), false);
                    if (Convert.ToInt16(ds.Tables[0].Rows[i]["Statuse"]) == 4)
                    {
                        myImage = global::Amanat_UIS.Properties.Resources.policIcon;
                        GRD_List.Rows[i].Cells["Status"].ToolTipText = "تحویل به پلیس";
                    }
                    else if (Convert.ToInt16(ds.Tables[0].Rows[i]["Statuse"]) == 1)
                    {
                        GRD_List.Rows[i].Cells["Status"].ToolTipText = "تاریخ گذشته";
                        myImage = global::Amanat_UIS.Properties.Resources.Delay2;
                    }


                    GRD_List.Rows[i].Cells["Status"].Value = myImage;
                }
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
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.ReportGriedStyle(GRD_List);
            customizedThemeObj.FormStyle(this);
        }
        private void SendToPolice_Report_Load(object sender, EventArgs e)
        {
            SetFormStyles();
            maskedNowDate.Text = BLLDate.getPersianDate(System.DateTime.Now, false);
        }

        private void SendToPolice_Report_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
             if (e.KeyCode == Keys.Control || e.KeyCode == Keys.F)
            {
                BTN_Print_Click(sender, e);
            }
        }

        private void TXT_DayCnt_Validating(object sender, CancelEventArgs e)
        {
            if (Amanat_BO.Validating.txtNumericStringIsValid(TXT_DayCnt.Text))
            {
                errorProvider1.SetError(TXT_DayCnt, "مقدار صحیح را وارد کنید");
                e.Cancel = true;
            }
            else errorProvider1.SetError(TXT_DayCnt, "");
        }

        private void BTN_Print_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = Amanat_BO.GiveAndTakes.GiveAndTake_ForSendToPolisList(BLLDate.getGregorianDate(BLLDate.ConvertRTLPDateToLTRPdate(maskedToDate.Text)),1);
                ds.Tables[0].Columns.Add("GDate");
                ds.Tables[0].Columns.Add("BDate");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ds.Tables[0].Rows[i]["GDate"] = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["GiveDate"]), false);
                    ds.Tables[0].Rows[i]["BDate"] = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["exp_GiveBackDate"]), false);
                }
                StiDataBand SDataBand = ((StiDataBand)stiReportSend.Pages["Page1"].Components["MyData"]);
                Amanat_BO.Helper.SetReportAppearance(stiReportSend, this);
                Amanat_BO.Helper.Print(ds, stiReportSend);
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
        }
    }
}
