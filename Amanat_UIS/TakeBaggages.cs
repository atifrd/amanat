using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using KM77.BLL;
using Stimulsoft.Report.Components;

namespace Amanat_UIS
{
    public partial class TakeBaggages : Form
    {


        public DataTable baggage;
        public DataTable Baggage
        {
            get
            {
                if (baggage == null)
                    baggage = Amanat_BO.baggages.Baggage_SelectAll().Tables[0];

                return baggage;
            }
        }

        public DataTable baggagePrice;
        public DataTable BaggagePrice
        {
            get
            {
                if (baggagePrice == null)
                    baggagePrice = Amanat_BO.Baggage_Prices.Baggage_Price_SelectAll(false).Tables[0];// faghat valid=1 ha // in select bayad bar asas tarikh order shavad , ke avalin entekhab akharin gheymat vard shode bashad

                return baggagePrice;
            }
        }



        public TakeBaggages()
        {
            InitializeComponent();
        }
        
        private void FillGridComboBYBaggageCode()
        {
            try
            {
                DataGridViewComboBoxColumn my = ((DataGridViewComboBoxColumn)(GRD_GiveAndTakeDetails.Columns["baggageCode"]));
                my.DisplayMember = "baggageCode";
                my.ValueMember = "baggageId";
                my.DataSource = Amanat_BO.baggages.Baggage_SelectAll().Tables[0];
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
        }

        

        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.ReportGriedStyle(GRD_TaKen);
            customizedThemeObj.InsertGriedStyle(GRD_GiveAndTakeDetails);
            customizedThemeObj.ControlStyle(tabPage1);
            customizedThemeObj.ControlStyle(tabPage2);
            customizedThemeObj.FormStyle(this); 
            
        }
        private void TakeBaggages_Load(object sender, EventArgs e)
        {
            timer1.Start();
            maskedGiveDate.Text = BLLDate.getPersianDate(System.DateTime.Now.Date,true);
            maskedexp_GiveBackDate.Text = BLLDate.getPersianDate(System.DateTime.Now.Date,true);
           maskedGiveTime.Text = System.DateTime.Now.TimeOfDay.ToString();
            SetFormStyles();
            

            string ActivSession = Convert.ToString(Amanat_BO.UserSettings.SessionNo);
            LBL_SysSessionFullName.BackColor = Color.Transparent;
            if (ActivSession.Trim() != "0")
            {
                LBL_Systemsession.Text = ActivSession;
                LBL_SysSessionFullName.Text = " فصل جاری سیستم :" + ActivSession;
                LBL_SerialNumber.Text = Amanat_BO.GiveAndTake_masters.GiveAndTake_master_ReturnLastSerialNumber(LBL_Systemsession.Text);
            }
           
            else 
            {
                MessageBox.Show(" لطفا فصل جدید تعریف کنید. فصل در سیستم تعریف نشده ویا فصل قبلی منقضی شده است ");
                this.Close();
                Sessions sessionOb = new Sessions();
                sessionOb.Show();
            }
            if (Amanat_BO.UserSettings.TaxId == 0)
            {
                MessageBox.Show("میزان مالیات بر ارزش افزوده را تعیین کنید"); this.Close();
            }
            TXT_Person.Focus();
        }

       
    
        private void BTN_Save_Click(object sender, EventArgs e)
        
        {
            if (TXT_Person.Text == string.Empty || GRD_GiveAndTakeDetails.Rows.Count <= 1 || maskedexp_GiveBackTime.Text.Contains(' ')) 
            { MessageBox.Show("لطفا اطلاعات فرم را به طور صحیح وارد کنید"); return; }

            string to = maskedexp_GiveBackDate.Text.Remove(2, 1).Remove(5, 1) + " " + maskedexp_GiveBackTime.Text;
            string from = maskedGiveDate.Text.Remove(2, 1).Remove(5, 1) + " " + maskedGiveTime.Text;
            decimal M_FSum = Convert.ToDecimal(TXT_M_FSum_Ezafe.Text.Replace(",", "")) - Convert.ToDecimal(TXT_M_FSum_kasr.Text.Replace(",", ""));

            //problem:  master details too ye sp kena ama che joori begimage details moshkel
                try
                {
                    
                    //sava master
                    Int64 FKGiveAndTake_masterId =
                    Amanat_BO.GiveAndTake_masters.GiveAndTake_daryaftAmanat((LBL_Systemsession.Text + LBL_SerialNumber.Text),
                     TXT_Person.Text
                    , KM77.BLL.BLLDate.getGregorianDate(maskedGiveDate.Text.Remove(2, 1).Remove(5, 1)), 
                    maskedGiveTime.Text, KM77.BLL.BLLDate.getGregorianDate(maskedexp_GiveBackDate.Text.Remove(2, 1).Remove(5, 1)),
                    maskedexp_GiveBackTime.Text, Amanat_BO.UserSettings.UserID,Convert.ToDecimal(textBox1.Text.Replace(",", "")), Amanat_BO.UserSettings.TaxId, TXT_Tell.Text,M_FSum);
                    DataGridViewRowCollection MyRows = GRD_GiveAndTakeDetails.Rows;

                    // sava details
                    int FKBaggagePriceID;
                    string UndefBaggageDesc = "";
                    decimal UndefBaggagePrice = 0;
                    int BaggageCount; decimal FirstDelay_price;
                    int BCode = 0;
                    for (int i = 0; i < MyRows.Count - 1 && FKGiveAndTake_masterId>0; i++)
                    {
                        FKBaggagePriceID = Convert.ToInt32(GRD_GiveAndTakeDetails.Rows[i].Cells["BaggagePriceID"].Value);
                        BaggageCount = Convert.ToInt32(MyRows[i].Cells["BaggageCount"].Value);
                        BCode = Convert.ToInt32(MyRows[i].Cells["col_codeKala"].Value);
                        FirstDelay_price = Convert.ToDecimal(MyRows[i].Cells["count_Sum"].Value) - (BaggageCount * Convert.ToDecimal(MyRows[i].Cells["Price"].Value));
                        UndefBaggageDesc = Convert.ToString(MyRows[i].Cells["baggageName"].Value);
                        UndefBaggagePrice = Convert.ToDecimal(MyRows[i].Cells["Price"].Value);
                        if (FKBaggagePriceID != 0 && BaggageCount!=0)
                           Amanat_BO.GiveAndTakes.GiveAndTake_DaryaftDetails(FKGiveAndTake_masterId, FKBaggagePriceID, BaggageCount, FirstDelay_price, UndefBaggageDesc, UndefBaggagePrice, BCode);

                    }
                    if (FKGiveAndTake_masterId > 0)// vase zamanike 2bar ro sabt click mikone
                    {
                        LBL_Message.Text = "ثبت با موفقیت انجام شد";
                        print();
                    }
                    TXT_Person.Focus();
                }
                catch (Exception ex)
                {
                    Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                    MessageBox.Show("بروز خطا در انجام عملیات ");

                }
                finally { ResetForm(); }
            
        }
        #region Validation
        private void TXT_Person_Validating(object sender, CancelEventArgs e)
        {
            if (TXT_Person.Text==string.Empty)
            {
               errorProvider1.SetError(TXT_Person, "لطفا نام را وارد کنید");
                //e.Cancel = true;
            }
            else errorProvider1.SetError(TXT_Person, "");
        }
        #endregion

        #region Print
        public DataTable dt;
        public DataTable createdatatable()
        {
            dt = new DataTable("mydt");
            dt.Columns.Add("BaggageCount", System.Type.GetType("System.Int32"));
            
            dt.Columns.Add("baggageName".ToString());
            dt.Columns.Add("baggageCode", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Price", System.Type.GetType("System.Decimal"));
            dt.Columns.Add("MySum", System.Type.GetType("System.Decimal"));
            return dt;
        }

        private void print()
        {
            try
            {
                DataSet ds = new DataSet();
                DataRow dr;
                DataTable dt1 = createdatatable();
                for (int i = 0; i < GRD_GiveAndTakeDetails.Rows.Count - 1; i++)
                {
                    int dr_BaggageCount = Convert.ToInt32(GRD_GiveAndTakeDetails.Rows[i].Cells["BaggageCount"].Value);
                    int dr_BaggagePriceID = Convert.ToInt32(GRD_GiveAndTakeDetails.Rows[i].Cells["BaggagePriceID"].Value);
                    if (dr_BaggageCount != 0 && dr_BaggagePriceID != 0)
                    {
                        dr = dt1.NewRow();
                        dr["BaggageCount"] = dr_BaggageCount;
                        dr["baggageName"] = Convert.ToString(GRD_GiveAndTakeDetails.Rows[i].Cells["baggageName"].Value);
                        dr["baggageCode"] = Convert.ToInt32(GRD_GiveAndTakeDetails.Rows[i].Cells["col_codeKala"].Value);
                        dr["Price"] = Convert.ToDecimal(GRD_GiveAndTakeDetails.Rows[i].Cells["Price"].Value);
                        dr["MySum"] = Convert.ToDecimal(GRD_GiveAndTakeDetails.Rows[i].Cells["count_Sum"].Value);
                        dt1.Rows.Add(dr);
                    }
                }

                if (Amanat_BO.UserSettings.TaxBurden != 0)
                {
                    dr = dt1.NewRow();
                    dr["BaggageCount"] = 1;
                    dr["baggageName"] = "مالیات بر ارزش افزوده";
                    dr["baggageCode"] = 0;
                    dr["Price"] = LBL_SumTax.Text;
                    dr["MySum"] = LBL_SumTax.Text;
                    dt1.Rows.Add(dr);
                }
                if (TXT_M_FSum_Ezafe.Text!="0" || TXT_M_FSum_kasr.Text!="0")
                {
                    dr = dt1.NewRow();
                    dr["BaggageCount"] = 1;
                    dr["baggageName"] = "کسر/اضافه";
                    dr["baggageCode"] = 0;
                    var M_sum=- Convert.ToDecimal(TXT_M_FSum_kasr.Text.Replace(",", "")) 
                   + Convert.ToDecimal(TXT_M_FSum_Ezafe.Text.Replace(",", ""));
                    dr["Price"] = M_sum;
                    dr["MySum"] = M_sum;
                    dt1.Rows.Add(dr);
                }

                ds.Tables.Add(dt1);


                Amanat_BO.Helper.SetReportAppearance(stiReportFishCustom, this);
                stiReportFishCustom.Compile();
                stiReportFishCustom["VTextSerial"] = " سریال " + " " + LBL_SerialNumber.Text;
                stiReportFishCustom["VTextName"] = "نام:" + " " + TXT_Person.Text;
                stiReportFishCustom["VTextTell"] = "تلفن " + "  " + TXT_Tell.Text;
                stiReportFishCustom["VTextGiVeDate"] = BLLDate.ConvertLTRPDateTORTLPDatedate(maskedGiveDate.Text.Remove(2, 1).Remove(5, 1));
                stiReportFishCustom["VTextGiveTime"] = maskedGiveTime.Text;
                stiReportFishCustom["VTextBackDate"] = BLLDate.ConvertLTRPDateTORTLPDatedate(maskedexp_GiveBackDate.Text.Remove(2, 1).Remove(5, 1));
                stiReportFishCustom["VTextBackTime"] = maskedexp_GiveBackTime.Text;

                stiReportFishCustom["VPrintTxt"] = Amanat_BO.UserSettings.PrintTxt;
                stiReportFishCustom["VOfficeTell"] = " " + "تلفن:" + " " + Amanat_BO.UserSettings.OfficeTell;
                stiReportFishCustom["VPrint_Font"] = Amanat_BO.UserSettings.Print_Font;

                Amanat_BO.Helper.FishPrint(ds.Tables[0], stiReportFishCustom);
            }
            catch (Exception ex) { Amanat_BO.SysLog.WriteInLogFile(ex.ToString());  LBL_Message.Text = ""; MessageBox.Show("بروز خطا در چاپ فیش"); }
        }
     #endregion
        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            ResetForm();
           
        }

        private void ResetForm()
        {
            LBL_Message.Text = "";
            textBox1.Text = "0"; TXT_M_FSum_kasr.Text = "0"; TXT_M_FSum_Ezafe.Text="0"; TXT_FSumBeforM_FSum.Text="0";
            TXT_LockerNumber.Text = "";
            TXT_Person.Text = ""; TXT_Tell.Text = "";
            GRD_GiveAndTakeDetails.Rows.Clear();
            LBL_SerialNumber.Text = Amanat_BO.GiveAndTake_masters.GiveAndTake_master_ReturnLastSerialNumber(LBL_Systemsession.Text);

            maskedexp_GiveBackTime.Text = "";
            maskedGiveTime.Text = System.DateTime.Now.TimeOfDay.ToString();
            maskedexp_GiveBackDate.Text = BLLDate.getPersianDate(System.DateTime.Now.Date,true);
           
            maskedGiveDate.Text = BLLDate.getPersianDate(System.DateTime.Now.Date,true);
            LBL_SumTax.Text = "0";
            TXT_SumWithoutTax.Text = "0";
            TXT_Person.Focus();
           
           
        }
        #region Eslahat
        
      
        private void tabControl1_Click(object sender, EventArgs e)
        {//problem : ye jaye behtar vasash peida konam
            try
            {
                DataTable dt= Amanat_BO.GiveAndTakes.GiveAndTake_SelectTahvilnashode().Tables[0];
                GRD_TaKen.DataSource = dt;
                try
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        GRD_TaKen.Rows[i].Cells["Eexp_GiveBackDate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(dt.Rows[i]["exp_GiveBackDate"]),false);
                        GRD_TaKen.Rows[i].Cells["EGiveDate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(dt.Rows[i]["GiveDate"]),false);
                    }
                    //
                }
                catch (Exception ex)
                {
                    Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                    MessageBox.Show("بروز خطا در انجام عملیات ");
                }
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
            
        }

        private void GRD_TaKen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                this.SerialNumberParameter = GRD_TaKen.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString();
                this.MasterIdParameter = Convert.ToInt64(GRD_TaKen.Rows[e.RowIndex].Cells["EId"].Value);
                TakeBaggages_Edit2 TakeBaggages_EditOBJ = new TakeBaggages_Edit2();
                TakeBaggages_EditOBJ.TakeBaggagesInstance = this;

                TakeBaggages_EditOBJ.MdiParent = Form1.ActiveForm;
                TakeBaggages_EditOBJ.Show();
                // ya ye panel ya ye forme dige vase edit baz she
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");

            }

        }
        #endregion

        private void GRD_GiveAndTakeDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 & e.ColumnIndex != -1)
            {
                if (GRD_GiveAndTakeDetails.Columns[e.ColumnIndex].DataPropertyName == "baggageCode")
                {//
                    var kalaCode = GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["col_codeKala"].Value;
                    if (kalaCode != null)
                    {
                        int kCode = 0;
                        
                         if (int.TryParse(kalaCode.ToString(), out kCode))
                            foreach (DataRow currentBaggege in Baggage.Rows)
                                if (int.Parse(currentBaggege["baggageCode"].ToString()) == kCode)
                                {
                                    GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["baggageName"].Value = currentBaggege["baggageName"].ToString();

                                    int bagID = int.Parse(currentBaggege["baggageId"].ToString());
                                    foreach (DataRow currentPric in BaggagePrice.Rows)
                                    {
                                        if (int.Parse(currentPric["BaggageId"].ToString()) == bagID)
                                        {
                                            GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["BaggagePriceID"].Value = currentPric["BaggagePriceID"].ToString();
                                            GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["Price"].Value = currentPric["Price"].ToString();
                                            GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["BaggageCount"].Value = "1";
                                            break;
                                        }

                                    }
                                    break;
                                }
                    }
                    if (kalaCode.ToString() != "90")
                    {
                        GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["baggageName"].ReadOnly = true;
                        GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["Price"].ReadOnly = true;
                    }
                    else if (kalaCode.ToString() == "90")
                    {
                        GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["baggageName"].ReadOnly = false;
                        GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["Price"].ReadOnly = false;
                    }
                }
                else if (GRD_GiveAndTakeDetails.Columns[e.ColumnIndex].DataPropertyName == "BaggageCount")
                {
                    Calc_Sum(e);
                }
                else if (GRD_GiveAndTakeDetails.Columns[e.ColumnIndex].DataPropertyName == "Price"
                         && GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["BaggageCount"].Value !=null)//bara vaghti GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["col_codeKala"].Value.ToString() == "90"   ya code kala ro ye bar zadim dobare avazesh mikonim 
                {
                    Calc_Sum(e);
                } 
            }
        }
        /// <summary>
        /// aval count_Sum va bad mablaghe kol ghabl o bad az maliat ro mohasebe mikone
        /// </summary>
        /// <param name="e"></param>
        private void Calc_Sum(DataGridViewCellEventArgs e)
        {
            var price = GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["Price"].Value;
            var count = GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["BaggageCount"].Value;

            decimal p = 0; int c = 0;
            if (price != null & count != null)
                if (decimal.TryParse(price.ToString(), out p) & int.TryParse(count.ToString(), out c))
                {

                    GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["count_Sum"].Value = ((p * c) + Amanat_BO.Baggage_Prices.GetRealDelayPriceProcedure(p, c, BLLDate.getGregorianDate(maskedGiveDate.Text.Remove(2, 1).Remove(5, 1)), maskedGiveTime.Text, BLLDate.getGregorianDate(maskedexp_GiveBackDate.Text.Remove(2, 1).Remove(5, 1)), maskedexp_GiveBackTime.Text)).ToString();
                    decimal FSum = 0;
                    for (int i = 0; i < GRD_GiveAndTakeDetails.Rows.Count - 1; i++)
                    {

                        FSum += Convert.ToDecimal(GRD_GiveAndTakeDetails.Rows[i].Cells["count_Sum"].Value);
                    }
                    ReadySumForPresent(FSum);

                }
        }

        private void GRD_TaKen_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                string a=e.ToString();
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
        }

       

        private void TakeBaggages_KeyDown(object sender, KeyEventArgs e)
            {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
            if (e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{TAB}"); return;
            }
           /* if (e.KeyCode==Keys.Control ||e.KeyCode==Keys.N)
            {
                LBL_SysSessionFullName.Text = " فصل جاری سیستم :" + Amanat_BO.Systemsession.getNextSession(LBL_Systemsession.Text);
                LBL_Systemsession.Text=Amanat_BO.Systemsession.getNextSession(LBL_Systemsession.Text);
                LBL_SerialNumber.Text = Amanat_BO.GiveAndTake_masters.GiveAndTake_master_ReturnLastSerialNumber(LBL_Systemsession.Text);
                return;
            }
            else if (e.KeyCode == Keys.Control || e.KeyCode == Keys.P)
            {
                LBL_SysSessionFullName.Text = " فصل جاری سیستم :" + Amanat_BO.Systemsession.getpreviousSession(LBL_Systemsession.Text);
                LBL_Systemsession.Text = Amanat_BO.Systemsession.getpreviousSession(LBL_Systemsession.Text);
                LBL_SerialNumber.Text = Amanat_BO.GiveAndTake_masters.GiveAndTake_master_ReturnLastSerialNumber(LBL_Systemsession.Text);
            }*/
             if (e.KeyCode == Keys.Insert)
            {
                BTN_Save_Click(sender, e);
            }
        }

        private void maskedexp_GiveBackTime_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            maskedexp_GiveBackTime.Text = Amanat_BO.Validating.TimeIsvalis(maskedexp_GiveBackTime.Text);
            if (!e.IsValidInput)
            {
                errorProvider1.SetError(maskedexp_GiveBackTime, "ساعت را صحیح وارد کنید");
                e.Cancel = true;
            }
            else
            {

                errorProvider1.SetError(maskedexp_GiveBackTime, "");
                e.Cancel = false;
            }
        }

        private void maskedexp_GiveBackDate_Validating(object sender, CancelEventArgs e)
        {

        }

        private void GRD_GiveAndTakeDetails_Enter(object sender, EventArgs e)
        {
            string to = maskedexp_GiveBackDate.Text.Remove(2, 1).Remove(5, 1) + " " + maskedexp_GiveBackTime.Text;
            string from = maskedGiveDate.Text.Remove(2, 1).Remove(5, 1) + " " + maskedGiveTime.Text;
            if (!Amanat_BO.Validating.DueDatetimIsValid(from, to))
            {
                MessageBox.Show("تاریخ تحویل نا درست است"); maskedexp_GiveBackDate.Focus(); BTN_Save.Enabled = false;
            }
            else BTN_Save.Enabled = true;
        }

        private void GRD_GiveAndTakeDetails_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            decimal FSum = 0;
            for (int i = 0; i < GRD_GiveAndTakeDetails.Rows.Count - 1; i++)
            {

                FSum += Convert.ToDecimal(GRD_GiveAndTakeDetails.Rows[i].Cells["count_Sum"].Value);
            }
            FSum = ReadySumForPresent(FSum);
        }

        private decimal ReadySumForPresent(decimal FSum)
        {
            LBL_SumTax.Text = Convert.ToString(FSum * Amanat_BO.UserSettings.TaxBurden);
            TXT_SumWithoutTax.Text = Amanat_BO.Helper.GetCurrencyFormat(Convert.ToString(FSum));
            FSum += FSum * Amanat_BO.UserSettings.TaxBurden;

            TXT_FSumBeforM_FSum.Text = Amanat_BO.Helper.GetCurrencyFormat(Convert.ToString(FSum));
            textBox1.Text = Calc_SumAfterM_FSum();
            return FSum;
        }

        private void maskedexp_GiveBackDate_Enter(object sender, EventArgs e)
        {
            maskedexp_GiveBackDate.Focus();
            maskedexp_GiveBackDate.Select(0,2);
        }

        private void maskedexp_GiveBackTime_Leave(object sender, EventArgs e)
        {
            maskedexp_GiveBackTime.Text = Amanat_BO.Validating.TimeIsvalis(maskedexp_GiveBackTime.Text);
            calCount_SumIfDateIsChanged();
        }

        private void calCount_SumIfDateIsChanged()
        {
            int itemCnt = GRD_GiveAndTakeDetails.Rows.Count - 1;
            if (itemCnt > 0)
            {
                decimal price = 0;
                int cnt = 0;
                decimal FSum = 0;
                for (int i = 0; i < itemCnt; i++)
                {
                    decimal.TryParse(GRD_GiveAndTakeDetails.Rows[i].Cells["Price"].Value.ToString(), out price);
                    int.TryParse(GRD_GiveAndTakeDetails.Rows[i].Cells["BaggageCount"].Value.ToString(), out cnt);
                    GRD_GiveAndTakeDetails.Rows[i].Cells["count_Sum"].Value = ((price * cnt) + Amanat_BO.Baggage_Prices.GetRealDelayPriceProcedure(price, cnt, BLLDate.getGregorianDate(maskedGiveDate.Text.Remove(2, 1).Remove(5, 1)), maskedGiveTime.Text, BLLDate.getGregorianDate(maskedexp_GiveBackDate.Text.Remove(2, 1).Remove(5, 1)), maskedexp_GiveBackTime.Text)).ToString();
                    FSum += Convert.ToDecimal(GRD_GiveAndTakeDetails.Rows[i].Cells["count_Sum"].Value);
                }
                ReadySumForPresent(FSum);
            }
        }

        private void maskedexp_GiveBackDate_Leave(object sender, EventArgs e)
        {
            calCount_SumIfDateIsChanged();
        }

        

        private void GRD_GiveAndTakeDetails_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Tab || e.KeyData==Keys.Enter)
            //    e.Handled = true;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            maskedGiveTime.Text = System.DateTime.Now.TimeOfDay.ToString();
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

        private void TXT_M_FSum_kasr_Leave(object sender, EventArgs e)
        {

            textBox1.Text = Calc_SumAfterM_FSum();
            
        }

        private void TXT_M_FSum_Ezafe_Leave(object sender, EventArgs e)
        {
            textBox1.Text = Calc_SumAfterM_FSum();
        }


        string Calc_SumAfterM_FSum()
        {
            try
            {
                return Amanat_BO.Helper.GetCurrencyFormat(
                (Convert.ToDecimal(TXT_FSumBeforM_FSum.Text.Replace(",", ""))
                   - Convert.ToDecimal(TXT_M_FSum_kasr.Text.Replace(",", ""))
                   + Convert.ToDecimal(TXT_M_FSum_Ezafe.Text.Replace(",", ""))
                   ).ToString());
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                return "0";
            }
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Save_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BTN_Save_MouseHover(object sender, EventArgs e)
        {
            Button mybtn = (Button)sender;
            mybtn.BackgroundImage = global::Amanat_UIS.Properties.Resources.Access_icon24;
           // mybtn.Text = "ghjg";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Button mybtn = (Button)sender;
            mybtn.BackgroundImage = global::Amanat_UIS.Properties.Resources.Access_icon24;
            //mybtn.Text = "ghjg";
        }

        
        
    }
}
