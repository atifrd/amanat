using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KM77.BLL;

namespace Amanat_UIS
{
    public partial class TakeBaggages_Edit : Form
    {
        public TakeBaggages_Edit()
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

        private void TakeBaggages_Edit_Load(object sender, EventArgs e)
        {
            
            SetFormStyles();
            DataSet ds =
              Amanat_BO.GiveAndTakes.GiveAndTake_returnInfoToEbtal(this.TakeBaggagesInstance.SerialNumberParameter, Amanat_BO.UserSettings.TaxBurden);
            ds.Tables[0].Merge(ds.Tables[1]);
            if (ds.Tables[0].Rows.Count>1)
          {
              GRD_GiveAndTakeDetails.DataSource = ds.Tables[0];
              LBL_SerialNumber.Text = ds.Tables[0].Rows[0]["SerialNumber"].ToString();
              TXT_Person.Text = ds.Tables[0].Rows[0]["Person"].ToString();
              maskedGiveDate.Text = BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[0]["GiveDate"]),true);
              maskedGiveTime.Text = ds.Tables[0].Rows[0]["GiveTime"].ToString();
              maskedexp_GiveBackDate.Text = BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[0]["exp_GiveBackDate"]),true);
              maskedexp_GiveBackTime.Text = ds.Tables[0].Rows[0]["exp_GiveBackTime"].ToString();
              decimal FSum = 0;
              for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
              {
                  FSum += Convert.ToDecimal(ds.Tables[0].Rows[i]["MySum"]);
              }


              textBox1.Text = Amanat_BO.Helper.GetCurrencyFormat(FSum.ToString());
          }
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.InsertGriedStyle(GRD_GiveAndTakeDetails);
            customizedThemeObj.FormStyle(this);
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("آیا از ویرایش قبض اطمینان دارید ؟", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MessageBox.Show("ویرایش قبض با موفقیت انجام شد");
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GRD_GiveAndTakeDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 & e.ColumnIndex != -1)
            {
                if (GRD_GiveAndTakeDetails.Columns[e.ColumnIndex].DataPropertyName == "baggageCode")
                {
                    var kalaCode = GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["baggageCode"].Value;
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
                                        {//FKBaggagePriceID ham mitoone set beshe
                                            GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["BaggagePriceID"].Value = currentPric["BaggagePriceID"].ToString();
                                            GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["Price"].Value = currentPric["Price"].ToString();
                                           
                                            GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["BaggageCount"].Selected = true;
                                            GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["BaggageCount"].Value = "1";
                                           // GRD_GiveAndTakeDetails.CurrentCell = GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["BaggageCount"];
                                            
                                        }//break;

                                    }
                                }//break;
                    }
                }
                else if (GRD_GiveAndTakeDetails.Columns[e.ColumnIndex].DataPropertyName == "BaggageCount")
                {
                    var price = GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["Price"].Value;
                    var count = GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["BaggageCount"].Value;

                    decimal p = 0; int c = 0;
                    if (price != null & count != null)
                        if (decimal.TryParse(price.ToString(), out p) & int.TryParse(count.ToString(), out c))
                        {
                            GRD_GiveAndTakeDetails.Rows[e.RowIndex].Cells["MySum"].Value = (p * c).ToString();
                            decimal FSum = 0;
                            for (int i = 0; i < GRD_GiveAndTakeDetails.Rows.Count - 1; i++)
                            {

                                FSum += Convert.ToDecimal(GRD_GiveAndTakeDetails.Rows[i].Cells["MySum"].Value);
                            }
                            textBox1.Text = Convert.ToString(FSum);
                        }
                }
            }
        }

        private void TakeBaggages_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
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
            catch (Exception)
            {
                
                throw;
            }
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

            
        }
    }
}
