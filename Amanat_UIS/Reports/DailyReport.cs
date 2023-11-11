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
    public partial class DailyReport : Form
    {
        public DailyReport()
        {
            InitializeComponent();
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.FormStyle(this);

        }

        private void DailyReport_Load(object sender, EventArgs e)
        {
            SetFormStyles();
            maskedTxtTodate.Text = BLLDate.getPersianDate(System.DateTime.Now, true);
            masked_FromDate.Text = BLLDate.getPersianDate(System.DateTime.Now, true);
        }
        DataSet ds;
        private void BTN_Search_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            richTextBoxsts1.Text = ""; richTextBoxsts2.Text = "";
            try
            {
                ds = Amanat_BO.GiveAndTakes.DailyReport2(BLLDate.getGregorianDate(masked_FromDate.Text.Remove(2, 1).Remove(5, 1)), BLLDate.getGregorianDate(maskedTxtTodate.Text.Remove(2, 1).Remove(5, 1)));
                if (ds.Tables[0].Rows.Count == 1)
                {
                    lbl_FishCount.Text = ds.Tables[0].Rows[0]["FishCnt"].ToString();
                    LBL_FromFishNum.Text = ds.Tables[0].Rows[0]["MinSerial"].ToString();
                    LBL_ToFishNum.Text = ds.Tables[0].Rows[0]["MaxSerial"].ToString();

                    LBL_Sum.Text = Amanat_BO.Helper.GetCurrencyFormat(ds.Tables[0].Rows[0]["ExpSum"].ToString());
                    LBL_Delay.Text = Amanat_BO.Helper.GetCurrencyFormat(ds.Tables[0].Rows[0]["SumDelay"].ToString());

                    LBL_Discount.Text = Amanat_BO.Helper.GetCurrencyFormat(ds.Tables[0].Rows[0]["SumDiscount"].ToString());
                    LBL_Tax.Text = Amanat_BO.Helper.GetCurrencyFormat(ds.Tables[0].Rows[0]["SumTaxBurden"].ToString());
                    LBL_TaxOnDelay.Text = Amanat_BO.Helper.GetCurrencyFormat(ds.Tables[0].Rows[0]["SumTaxOnDelay"].ToString());
                    LBL_SumM_Fsum.Text = Amanat_BO.Helper.GetCurrencyFormat(ds.Tables[0].Rows[0]["SumM_Fsum"].ToString());
                }


                LBL_FSum.Text = Amanat_BO.Helper.GetCurrencyFormat((Convert.ToDecimal(LBL_Sum.Text) + Convert.ToDecimal(LBL_Delay.Text) + Convert.ToDecimal(LBL_Tax.Text) + Convert.ToDecimal(LBL_TaxOnDelay.Text)
                    - Convert.ToDecimal(LBL_Discount.Text) + Convert.ToDecimal(LBL_SumM_Fsum.Text)).ToString());

                for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                {
                    richTextBoxsts1.Text += ds.Tables[1].Rows[i]["SerialNumber"].ToString() + "    ";
                }
                for (int i = 0; i < ds.Tables[2].Rows.Count; i++)
                {
                    richTextBoxsts2.Text += ds.Tables[2].Rows[i]["SerialNumber"].ToString() + "    ";
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

        private void DailyReport_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
        }

        private void BTN_Print_Click(object sender, EventArgs e)
        {
            //if(ds==null)
            BTN_Search_Click(sender, e);           
            Amanat_BO.Helper.SetReportAppearance(stiReport1, this);
          //  StiPanel MyPanel = ((StiPanel)stiReport1.Pages["Page1"].Components["Panel1"]);
           
         
            StiText TextLong = (StiText)(stiReport1.GetComponentByName("TextLong"));
            TextLong.Text = richTextBoxsts1.Text;
            
            StiText TextLong2 = stiReport1.GetComponentByName("TextLong2") as StiText;
            TextLong2.Text = richTextBoxsts2.Text;

            //StiRichTextFirst.Margins.Left = 3;
            //StiRichTextSecond.Margins.Left = 3;



            //foreach (var item in MyPanel.Components)
            //{               

            //    if (item.GetType().Name == typeof(StiText).Name)
            //    {
            //        ((StiText)item).Font = (new Font("LMN Lotus", 9, FontStyle.Regular));
            //        ((StiText)item).AutoWidth = true;
            //    }
            //}


            stiReport1.Compile();//akharin bakhsh
                       
            stiReport1["VFishCnt"] = lbl_FishCount.Text;
            stiReport1["VMinSerial"] = LBL_FromFishNum.Text;
            stiReport1["VMaxSerial"] = LBL_ToFishNum.Text;
            stiReport1["VExpSum"] = LBL_Sum.Text;
            stiReport1["VSumDelay"] = LBL_Delay.Text;
            stiReport1["VSumDiscount"] = LBL_Discount.Text;
            stiReport1["VSumTax"] = LBL_Tax.Text;
            stiReport1["VFSum"] = LBL_FSum.Text; stiReport1["VSumM_Fsum"] = LBL_SumM_Fsum.Text;
            stiReport1["From_ToDate"] = label_from.Text + "  " + masked_FromDate.Text + "  " + label_to.Text + " " + maskedTxtTodate.Text;
            Amanat_BO.Helper.Print(ds, stiReport1);


        }

        private void masked_FromDate_Enter(object sender, EventArgs e)
        {
            masked_FromDate.Focus();
            masked_FromDate.Select(0, 2);
        }

        private void maskedTxtTodate_Enter(object sender, EventArgs e)
        {
            maskedTxtTodate.Focus();
            maskedTxtTodate.Select(0, 2);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
