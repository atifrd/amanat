using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KM77.BLL;
using System.Xml;

namespace Amanat_UIS
{
    public partial class TakeBaggages_Edit2 : Form
    {
        public TakeBaggages_Edit2()
        {
            InitializeComponent();
        }
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
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.InsertGriedStyle(GRD_GiveAndTakeDetails);
            customizedThemeObj.FormStyle(this);
        }

        private void TakeBaggages_Edit2_Load(object sender, EventArgs e)
        {
            SetFormStyles();
            LoadInfo();
        }

        private void LoadInfo()
        {
            DataSet ds =
              Amanat_BO.GiveAndTakes.GiveAndTake_returnInfoToEbtal(this.TakeBaggagesInstance.SerialNumberParameter, Amanat_BO.UserSettings.TaxBurden);
            //ds.Tables[0].Merge(ds.Tables[1]);
            if (ds.Tables[0].Rows.Count > 0)
            {
                GRD_GiveAndTakeDetails.DataSource = ds.Tables[0];
                LBL_SerialNumber.Text = ds.Tables[0].Rows[0]["SerialNumber"].ToString();
                TXT_Person.Text = ds.Tables[0].Rows[0]["Person"].ToString();
                maskedGiveDate.Text = BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[0]["GiveDate"]), true);
                maskedGiveTime.Text = ds.Tables[0].Rows[0]["GiveTime"].ToString();
                maskedexp_GiveBackDate.Text = BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[0]["exp_GiveBackDate"]), true);
                maskedexp_GiveBackTime.Text = ds.Tables[0].Rows[0]["exp_GiveBackTime"].ToString();
                TXT_Tell.Text = ds.Tables[0].Rows[0]["PTell"].ToString();
                decimal M_FSum = Convert.ToDecimal(ds.Tables[0].Rows[0]["M_FSum"]);
                if (M_FSum < 0) TXT_M_FSum_kasr.Text = System.Math.Abs(M_FSum).ToString();
                else TXT_M_FSum_Ezafe.Text = M_FSum.ToString();
                decimal FSum = 0;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    FSum += Convert.ToDecimal(ds.Tables[0].Rows[i]["MySum"]);
                }
                ReadySumForPresent(FSum);
            }
        }

        private void jkkXML()
        {
            decimal M_FSum = Convert.ToDecimal(TXT_M_FSum_Ezafe.Text.Replace(",", "")) - Convert.ToDecimal(TXT_M_FSum_kasr.Text.Replace(",", ""));
            XmlDocument xmldoc = new XmlDocument();
            XmlElement doc = xmldoc.CreateElement("doc");
            xmldoc.AppendChild(doc);
            XmlElement D_GiveAndTake_master = xmldoc.CreateElement("D_GiveAndTake_master");
            doc.AppendChild(D_GiveAndTake_master);
            D_GiveAndTake_master.SetAttribute("SerialNumber", (TakeBaggagesInstance.SerialNumberParameter));
            D_GiveAndTake_master.SetAttribute("Person", TXT_Person.Text);
            D_GiveAndTake_master.SetAttribute("exp_GiveBackDate", KM77.BLL.BLLDate.getGregorianDate(maskedexp_GiveBackDate.Text.Remove(2, 1).Remove(5, 1)).ToString());
            D_GiveAndTake_master.SetAttribute("exp_GiveBackTime", maskedexp_GiveBackTime.Text);
            D_GiveAndTake_master.SetAttribute("FKUserId_Give", Amanat_BO.UserSettings.UserID.ToString());
            D_GiveAndTake_master.SetAttribute("Fsum", (textBox1.Text.Replace(",", "")));
            D_GiveAndTake_master.SetAttribute("FkTaxId", Amanat_BO.UserSettings.TaxId.ToString());
            D_GiveAndTake_master.SetAttribute("PTell", TXT_Tell.Text);
            D_GiveAndTake_master.SetAttribute("M_FSum", M_FSum.ToString());
            D_GiveAndTake_master.SetAttribute("EditDateTime", "EditDateTime");
            int FKBaggagePriceID;
            string UndefBaggageDesc = "";
            decimal UndefBaggagePrice = 0;
            int BaggageCount; decimal FirstDelay_price;
            int BCode = 0;
            DataGridViewRowCollection MyRows = GRD_GiveAndTakeDetails.Rows;
            for (int i = 0; i < MyRows.Count - 1 &&  lbl_FKGiveAndTake_masterId.Text!=string.Empty ; i++)
            {
                FKBaggagePriceID = Convert.ToInt32(GRD_GiveAndTakeDetails.Rows[i].Cells["BaggagePriceID"].Value);
                BaggageCount = Convert.ToInt32(MyRows[i].Cells["BaggageCount"].Value);
                BCode = Convert.ToInt32(MyRows[i].Cells["col_codeKala"].Value);
                FirstDelay_price = Convert.ToInt64(MyRows[i].Cells["count_Sum"].Value) - (BaggageCount * Convert.ToInt64(MyRows[i].Cells["Price"].Value));
                UndefBaggageDesc = Convert.ToString(MyRows[i].Cells["baggageName"].Value);
                UndefBaggagePrice = Convert.ToDecimal(MyRows[i].Cells["Price"].Value);

                XmlElement D_GiveAndTake = xmldoc.CreateElement("D_GiveAndTake");
                doc.AppendChild(D_GiveAndTake);
                StringBuilder titleID = new StringBuilder("DT100");
                StringBuilder titleName = new StringBuilder("OOP Concepts and .NET Part ");
                D_GiveAndTake.SetAttribute("FKGiveAndTake_masterId", lbl_FKGiveAndTake_masterId.Text.Trim());
                D_GiveAndTake.SetAttribute("FKBaggagePriceID", FKBaggagePriceID.ToString());
                D_GiveAndTake.SetAttribute("BaggageCount", BaggageCount.ToString());
                D_GiveAndTake.SetAttribute("FirstDelay_price", FirstDelay_price.ToString());
                D_GiveAndTake.SetAttribute("UndefBaggageDesc", UndefBaggageDesc.ToString());
                D_GiveAndTake.SetAttribute("UndefBaggagePrice", UndefBaggagePrice.ToString());
                D_GiveAndTake.SetAttribute("BCode", BCode.ToString());
                D_GiveAndTake.SetAttribute("UndefBaggagePrice", UndefBaggagePrice.ToString());
            }
            Amanat_BO.GiveAndTake_masters.GiveAndTake_masterDetails_edit(xmldoc);

        }
        /// <summary>
        /// sabte master va details dat yek sp ast .be in soorat ke
        /// dar datatable etelaate lazem baraye details ferestade mishavad dar halghe for.ke in data table samte sql be soorate parametr
        /// az noe table daryaft mishavad.  va dabte master ham dar hamoon sp 
        /// dar datatable etelate lazem baraye jadvar givaandtake + BagageCod ast ke BagageCode baraye sharte BagageCod=90 lazem ast 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از ویرایش قبض اطمینان دارید ؟", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (TXT_Person.Text == string.Empty || GRD_GiveAndTakeDetails.Rows.Count <= 1) { MessageBox.Show("لطفا اطلاعات فرم را به طور صحیح وارد کنید"); return; }
                string to = maskedexp_GiveBackDate.Text.Remove(2, 1).Remove(5, 1) + " " + maskedexp_GiveBackTime.Text;
                string from = maskedGiveDate.Text.Remove(2, 1).Remove(5, 1) + " " + maskedGiveTime.Text;
                decimal M_FSum = Convert.ToDecimal(TXT_M_FSum_Ezafe.Text.Replace(",", "")) - Convert.ToDecimal(TXT_M_FSum_kasr.Text.Replace(",", ""));
                int BaggageCount = 0;
                try
                {
                    DataGridViewRowCollection MyRows = GRD_GiveAndTakeDetails.Rows;
                    DataTable mydt = new DataTable();
                    DataRow mydr;
                    mydt.Columns.Add(new DataColumn("FKGiveAndTake_masterId"));
                    mydt.Columns.Add(new DataColumn("FKBaggagePriceID"));
                    mydt.Columns.Add(new DataColumn("BaggageCount"));
                    mydt.Columns.Add(new DataColumn("Delay_price"));
                    mydt.Columns.Add(new DataColumn("UndefBaggageDesc"));
                    mydt.Columns.Add(new DataColumn("UndefBaggagePrice"));
                    mydt.Columns.Add(new DataColumn("baggageCode"));
                    for (int i = 0; i < MyRows.Count - 1 && 1 > 0; i++)
                    {
                        BaggageCount = Convert.ToInt32(MyRows[i].Cells["BaggageCount"].Value);
                        mydr = mydt.NewRow();
                        mydr["FKGiveAndTake_masterId"] = this.TakeBaggagesInstance.MasterIdParameter;
                        mydr["FKBaggagePriceID"] = Convert.ToInt32(GRD_GiveAndTakeDetails.Rows[i].Cells["BaggagePriceID"].Value);
                        mydr["BaggageCount"] = BaggageCount;
                        mydr["Delay_price"] = Convert.ToDecimal(MyRows[i].Cells["count_Sum"].Value) - (BaggageCount * Convert.ToDecimal(MyRows[i].Cells["Price"].Value));
                        mydr["UndefBaggageDesc"] = Convert.ToString(MyRows[i].Cells["baggageName"].Value);
                        mydr["UndefBaggagePrice"] = Convert.ToDecimal(MyRows[i].Cells["Price"].Value);
                        mydr["baggageCode"] = Convert.ToInt32(MyRows[i].Cells["col_codeKala"].Value);

                        mydt.Rows.Add(mydr);
                    }



                    Amanat_BO.GiveAndTake_masters.GiveAndTake_masterAllDetails_edit(this.TakeBaggagesInstance.MasterIdParameter, this.TakeBaggagesInstance.SerialNumberParameter, TXT_Person.Text
                        , KM77.BLL.BLLDate.getGregorianDate(maskedGiveDate.Text.Remove(2, 1).Remove(5, 1)),
                    maskedGiveTime.Text, KM77.BLL.BLLDate.getGregorianDate(maskedexp_GiveBackDate.Text.Remove(2, 1).Remove(5, 1)),
                    maskedexp_GiveBackTime.Text, Convert.ToDecimal(textBox1.Text.Replace(",", "")), Amanat_BO.UserSettings.TaxId, TXT_Tell.Text, M_FSum, Amanat_BO.UserSettings.UserID, System.DateTime.Now, mydt);
                    LBL_Message.Text = "ویرایش با موفقیت انجام شد";
                    print();
                }
                catch (Exception ex)
                {
                    Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                    MessageBox.Show("بروز خطا در انجام عملیات ");
                }
                finally
                {
                    TXT_Person.Focus();
                    this.Close();
                }
            }
        }
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
                if (TXT_M_FSum_Ezafe.Text != "0" || TXT_M_FSum_kasr.Text != "0")
                {
                    dr = dt1.NewRow();
                    dr["BaggageCount"] = 1;
                    dr["baggageName"] = "کسر/اضافه";
                    dr["baggageCode"] = 0;
                    var M_sum = -Convert.ToDecimal(TXT_M_FSum_kasr.Text.Replace(",", ""))
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
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                LBL_Message.Text = ""; MessageBox.Show("بروز خطا در چاپ فیش"); }
        }
        #endregion

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                         && GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["BaggageCount"].Value != null)//bara vaghti GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["col_codeKala"].Value.ToString() == "90"   ya code kala ro ye bar zadim dobare avazesh mikonim 
                {
                    Calc_Sum(e);
                }
            }
        }

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

        private void TakeBaggages_Edit2_KeyDown(object sender, KeyEventArgs e)
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

        private void GRD_GiveAndTakeDetails_Enter(object sender, EventArgs e)
        {
            string to = maskedexp_GiveBackDate.Text.Remove(2, 1).Remove(5, 1) + " " + maskedexp_GiveBackTime.Text;
            string from = maskedGiveDate.Text.Remove(2, 1).Remove(5, 1) + " " + maskedGiveTime.Text;
            if (!Amanat_BO.Validating.DueDatetimIsValid(from, to))
            {
                MessageBox.Show("تاریخ تحویل نا درست است"); maskedexp_GiveBackDate.Focus(); BTN_Edit.Enabled = false;
            }
            else BTN_Edit.Enabled = true;
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
            maskedexp_GiveBackDate.Select(0, 2);
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

        private void BTN_Ebtal_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("آیا از ابطال قبض اطمینان دارید ؟", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Amanat_BO.GiveAndTake_masters.GiveAndTake_master_Ebtal(this.TakeBaggagesInstance.SerialNumberParameter);
                    MessageBox.Show("ابطال قبض با موفقیت انجام شد");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
            }
        }
    }
}
