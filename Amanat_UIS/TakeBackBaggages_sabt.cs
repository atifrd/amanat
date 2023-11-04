using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KM77.BLL;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;


namespace Amanat_UIS
{
    public partial class TakeBackBaggages_sabt : Form
    {
        public TakeBackBaggages_sabt()
        {
            InitializeComponent();
        }
      
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.InsertGriedStyle(GRD_GiveAndTakeDetails); GRD_GiveAndTakeDetails.AllowUserToAddRows = false; GRD_GiveAndTakeDetails.AllowUserToDeleteRows = false;
            customizedThemeObj.FormStyle(this);
        }

        private void TakeBackBaggages_sabt_Load(object sender, EventArgs e)
        {
            TXT_Discount.ReadOnly =masked_GiveBackDate.ReadOnly=masked_GiveBackTime.ReadOnly= !Amanat_BO.UserSettings.isSuperVisor;
            
            SetFormStyles();
            masked_GiveBackDate.Text = BLLDate.getPersianDate(System.DateTime.Now.Date,true);
            masked_GiveBackTime.Text = System.DateTime.Now.TimeOfDay.ToString();
            LoadFishInfo();
            if (Amanat_BO.UserSettings.isSuperVisor)
            {
                masked_GiveBackDate.TabStop =masked_GiveBackTime.TabStop = true;
            }
        }

        private void LoadFishInfo()
        {
            try
            {
                DataSet ds =
                Amanat_BO.GiveAndTakes.GiveAndTake_GetAllInfoByMasterId(this.TakeBackBaggagesInstanse.SerialNumberParam, BLLDate.getGregorianDate(masked_GiveBackDate.Text.Remove(2, 1).Remove(5, 1) + " " + masked_GiveBackTime.Text), Amanat_BO.UserSettings.TaxBurden);
                ds.Tables[0].Merge(ds.Tables[1]);
                if (ds.Tables[0].Rows.Count >= 2)// ds.Tables[1] always has 3 or 1 rows
                {
                    Int16 Sts = Convert.ToInt16(ds.Tables[0].Rows[0]["Statuse"]);
                    if (Sts != 1) { MessageBox.Show("قبض مورد نظ بسته شده است  "); this.Close(); }
                    else
                    {
                        GRD_GiveAndTakeDetails.DataSource = ds.Tables[0];
                        LBL_SerialNumber.Text = ds.Tables[0].Rows[0]["SerialNumber"].ToString();
                        LBL_Person.Text = ds.Tables[0].Rows[0]["Person"].ToString();
                        PTell.Text = ds.Tables[0].Rows[0]["PTell"].ToString();
                        LBL_GiveDate.Text = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[0]["GiveDate"]), false);
                        LBL_GiveTime.Text = ds.Tables[0].Rows[0]["GiveTime"].ToString();
                        LBL_exp_GiveBackDate.Text = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[0]["exp_GiveBackDate"]), false);
                        LBL_exp_GiveBackTime.Text = ds.Tables[0].Rows[0]["exp_GiveBackTime"].ToString();
                        decimal FSum = 0;
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            FSum += Convert.ToDecimal(ds.Tables[0].Rows[i]["MySum"]);
                        }
                        textBox2.Text = Amanat_BO.Helper.GetCurrencyFormat(FSum.ToString());
                        LBL_FSumBeforDiscount.Text = FSum.ToString();
                    }
                }
                else { MessageBox.Show("سریال موردنظر در سیستم وجود ندارد");  this.Close(); }
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }

        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string to = masked_GiveBackDate.Text.Remove(2, 1).Remove(5, 1) + " " + masked_GiveBackTime.Text;
                string from = BLLDate.ConvertRTLPDateToLTRPdate(LBL_GiveDate.Text) + " " + LBL_GiveTime.Text;
                decimal M_FSum_Delay = Convert.ToDecimal(TXT_M_FSum_Ezafe.Text.Replace(",", "")) - Convert.ToDecimal(TXT_M_FSum_kasr.Text.Replace(",", ""));
                if (!Amanat_BO.Validating.DueDatetimIsValid(from, to))
                {
                    MessageBox.Show("تاریخ تحویل نا درست است"); masked_GiveBackDate.Focus(); return;
                }

                DataGridViewRowCollection myrow = GRD_GiveAndTakeDetails.Rows;
                for (int i = 0; (Convert.ToString(myrow[i].Cells["GiveAndTakeDetailsId"].Value)!=string.Empty); i++)
                {
                    Amanat_BO.GiveAndTakes.GiveAndTake_master_UpdateForTahvil(BLLDate.getGregorianDate(masked_GiveBackDate.Text.Remove(2, 1).Remove(5, 1)),
                        masked_GiveBackTime.Text
                        , Amanat_BO.UserSettings.UserID, 2, TakeBackBaggagesInstanse.SerialNumberParam,
                        decimal.Parse(Convert.ToString(GRD_GiveAndTakeDetails.Rows[i].Cells["TakeBackDelayPrice"].Value)),
                        Int64.Parse(Convert.ToString(myrow[i].Cells["GiveAndTakeDetailsId"].Value)),
                        Convert.ToDecimal(TXT_Discount.Text.Replace(",", "")),
                        Convert.ToDecimal(textBox2.Text.Replace(",", "")), Amanat_BO.UserSettings.TaxId, M_FSum_Delay
                        );
                }
                MessageBox.Show("عملیات با موفقیت انجام شد"); this.Close();
            }

            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
            
        }

        
        private void TXT_Discount_TextChanged(object sender, EventArgs e)
        {
            TXT_Discount.Text=Amanat_BO.Helper.GetCurrencyFormat(TXT_Discount.Text);
            TXT_Discount.SelectionStart = TXT_Discount.Text.Length; TXT_Discount.Select();   
        }

        
        private void TakeBackBaggages_sabt_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
             if (e.KeyCode == Keys.Insert)
            {
                BTN_Save_Click(sender, e);
            }
             else if (e.KeyCode == Keys.Control || e.KeyCode == Keys.F)
             {
                 BTN_Print_Click(sender, e);
             }
        }

        private void BTN_Print_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds =Amanat_BO.GiveAndTakes.GiveAndTake_GetAllInfoByMasterId(this.TakeBackBaggagesInstanse.SerialNumberParam, 
                    BLLDate.getGregorianDate(masked_GiveBackDate.Text.Remove(2, 1).Remove(5, 1) + " " + masked_GiveBackTime.Text),Amanat_BO.UserSettings.TaxBurden);
                ds.Tables[0].Merge(ds.Tables[1]);
                Amanat_BO.Helper.SetReportAppearance(stiReportFish, this);
                Amanat_BO.Helper.FishMainBody_SetFont(stiReportFish);
                stiReportFish.Compile();
                stiReportFish["VTextSerial"] = " سریال  "+"  "+LBL_SerialNumber.Text;
                stiReportFish["VTextName"] = "نام "+"   "+LBL_Person.Text;
                stiReportFish["VTextGiVeDate"] = LBL_GiveDate.Text;
                stiReportFish["VTextGiveTime"] = LBL_GiveTime.Text;
                stiReportFish["VTextBackDate"] = masked_GiveBackDate.Text;
                stiReportFish["VTextBackTime"] = masked_GiveBackTime.Text;
                  
                Amanat_BO.Helper.FishPrint(ds.Tables[0], stiReportFish);
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }

        }

        private void TXT_Discount_Leave(object sender, EventArgs e)
        {
            textBox2.Text = Calc_SumAfterM_FSum();
           // textBox2.Text = Amanat_BO.Helper.GetCurrencyFormat((Convert.ToDecimal(LBL_FSumBeforDiscount.Text) - 
             //   Convert.ToDecimal(TXT_Discount.Text.Replace(",", ""))).ToString());
        }

        private void masked_GiveBackTime_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
            {
            masked_GiveBackTime.Text = Amanat_BO.Validating.TimeIsvalis(masked_GiveBackTime.Text);
            if (!e.IsValidInput)
            {
                e.Cancel = true;
                errorProvider1.SetError(masked_GiveBackTime, "ساعت را صحیح وارد کنید");
            }
            else
            {

                errorProvider1.SetError(masked_GiveBackTime, "");
                e.Cancel = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        #region kasrEzafe
        string Calc_SumAfterM_FSum()
        {
            Amanat_BO.Helper.GetCurrencyFormat((Convert.ToDecimal(LBL_FSumBeforDiscount.Text)
                - Convert.ToDecimal(TXT_Discount.Text.Replace(",", ""))).ToString());
            try
            {
                return Amanat_BO.Helper.GetCurrencyFormat(
                (Convert.ToDecimal(LBL_FSumBeforDiscount.Text.Replace(",", ""))//TXT_FSumBeforM_FSum
                   - Convert.ToDecimal(TXT_M_FSum_kasr.Text.Replace(",", ""))
                   + Convert.ToDecimal(TXT_M_FSum_Ezafe.Text.Replace(",", ""))
                    - Convert.ToDecimal(TXT_Discount.Text.Replace(",", ""))
                   ).ToString());
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                return "0";
            }

        }
        

        private void TXT_M_FSum_kasr_TextChanged(object sender, EventArgs e)
        {
            TXT_M_FSum_kasr.Text = Amanat_BO.Helper.GetCurrencyFormat(TXT_M_FSum_kasr.Text);
            TXT_M_FSum_kasr.SelectionStart = TXT_M_FSum_kasr.Text.Length; TXT_M_FSum_kasr.Select();
        }

        private void TXT_M_FSum_Ezafe_TextChanged(object sender, EventArgs e)
        {
            TXT_M_FSum_Ezafe.Text = Amanat_BO.Helper.GetCurrencyFormat(TXT_M_FSum_Ezafe.Text);
            TXT_M_FSum_Ezafe.SelectionStart = TXT_M_FSum_Ezafe.Text.Length; TXT_M_FSum_Ezafe.Select();
        }
        #endregion

        private void TXT_M_FSum_kasr_Leave(object sender, EventArgs e)
        {
           textBox2.Text= Calc_SumAfterM_FSum();
        }

        private void TXT_M_FSum_Ezafe_Leave(object sender, EventArgs e)
        {
            textBox2.Text = Calc_SumAfterM_FSum();
        }
    }
}
