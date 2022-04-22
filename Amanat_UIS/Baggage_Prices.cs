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
    public partial class Baggage_Prices : Form
    {
        public Baggage_Prices()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SetFormStyles()
        {
         
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.ReportGriedStyle(GRD_Baggage_Price);
            customizedThemeObj.FormStyle(this);
        }

        private void Baggage_Prices_Load(object sender, EventArgs e)
        {
            SetFormStyles();
            LoadeBaggage_Price();
            AutoCompleteStringCollection myCollection = BaggageCode_AutoComplete();
            TXT_baggageCode.AutoCompleteCustomSource = myCollection;

        }

        private static AutoCompleteStringCollection BaggageCode_AutoComplete()
        {
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
            DataSet ds = Amanat_BO.baggages.Baggage_SelectAll();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                myCollection.Add(ds.Tables[0].Rows[i]["baggageCode"].ToString());
            }

            return myCollection;
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {//problem felan be in tatije residam ke aslan tarikhe koochektar ro nabaiad ghabool kone
            string Message = "";
            
           
            try
            {
                 Message=Amanat_BO.Baggage_Prices.Baggage_Price_Insert(Convert.ToInt32(TXT_baggageCode.Text),
                 TXT_baggageName.Text, KM77.BLL.BLLDate.getGregorianDate(maskedFromDate.Text.Remove(2, 1).Remove(5, 1)),
                 Convert.ToInt64(TXT_Price.Text.Replace(",","")),1);
                 // problem:  MessageBox.Show(Message);
                 LoadeBaggage_Price();
                 AutoCompleteStringCollection myCollection = BaggageCode_AutoComplete();
                 TXT_baggageCode.AutoCompleteCustomSource = myCollection;
                 ResetForm();
                 MessageBox.Show("عملیات با موفقیت انجام شد");
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
            
        }

        private void TXT_baggageCode_Leave(object sender, EventArgs e)
        {
            try
            {
                if (TXT_baggageCode.Text == "")
                       TXT_baggageName.Text = "";
                else
                {
                    DataTable dt = Amanat_BO.baggages.Baggage_SelectBybaggageCode(Convert.ToInt32(TXT_baggageCode.Text))
                      .Tables[0];
                    if (dt.Rows.Count == 0)
                        TXT_baggageName.Text = "";
                    else if (dt.Rows.Count > 0)
                        TXT_baggageName.Text = dt.Rows[0]["Baggagename"].ToString();
                }
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
           
            
        }DataSet ds;
        private void LoadeBaggage_Price()
        {
            try
            {
                
               // Image myImage;
                ds=Amanat_BO.Baggage_Prices.Baggage_Price_SelectAll(true);
                GRD_Baggage_Price.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
            
        }
        void ResetForm()
        {
            TXT_baggageCode.Text = "";
            TXT_baggageName.Text = "";
            TXT_Price.Text = "0";
            maskedFromDate.Text = "";
            TXT_baggageCode.Focus(); BTN_Edit.Enabled = false; BTN_Save.Enabled = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void GRD_Baggage_Price_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TXT_baggageCode.Text = GRD_Baggage_Price.Rows[e.RowIndex].Cells["baggageCode"].Value.ToString();
                TXT_baggageName.Text = GRD_Baggage_Price.Rows[e.RowIndex].Cells["baggageName"].Value.ToString();
                TXT_Price.Text = GRD_Baggage_Price.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                maskedFromDate.Text = BLLDate.ConvertRTLPDateToLTRPdate(GRD_Baggage_Price.Rows[e.RowIndex].Cells["FromDate"].Value.ToString()).Remove(6, 2);
                BTN_Edit.Enabled = true; BTN_Save.Enabled = false;
            }
        }

        private void TXT_Price_TextChanged(object sender, EventArgs e)
        {
            if (Amanat_BO.Validating.TXTPriceIsValid(TXT_Price.Text))
            {
                errorProvider1.SetError(TXT_Price, "قیمت را صحیح وارد کنید");

            }
            else
            {
                TXT_Price.Text = Amanat_BO.Helper.GetCurrencyFormat(TXT_Price.Text);
                TXT_Price.SelectionStart = TXT_Price.Text.Length; TXT_Price.Select();
                errorProvider1.SetError(TXT_Price, "");
            }
        }

        private void Baggage_Prices_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
            if (e.KeyCode == Keys.Insert)
            {
                BTN_Save_Click(sender, e);
            }
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            try
            {


                MessageBox.Show("ویرایش با موفقیت انجام شد");
                LoadeBaggage_Price();
                ResetForm();
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
           
        }

        private void TXT_baggageName_Validating(object sender, CancelEventArgs e)
        {
            if (Amanat_BO.Validating.txtInputIsNotEmpy(TXT_baggageName.Text))
            {
                errorProvider1.SetError(TXT_baggageName, "نام کالا را وارد کنید");
                
            }
            else  errorProvider1.SetError(TXT_baggageName, "");

        }

        private void GRD_Baggage_Price_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Image myImage;
            for (int i = 0; i < GRD_Baggage_Price.Rows.Count; i++)
            {
                GRD_Baggage_Price.Rows[i].Cells["FromDate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["FromDate"]),false);
                if (Convert.ToBoolean(ds.Tables[0].Rows[i]["Valid"]))
                {
                    myImage = global::Amanat_UIS.Properties.Resources.ok_26x26;

                }
                else
                    myImage = global::Amanat_UIS.Properties.Resources.DeleteIcon;

                GRD_Baggage_Price.Rows[i].Cells["Valid"].Value = myImage;
            }
        }

        private void TXT_baggageCode_TextChanged(object sender, EventArgs e)
        {
            if (Amanat_BO.Validating.txtNumericStringIsValid(TXT_baggageCode.Text))
            {
                errorProvider1.SetError(TXT_baggageCode, "کد را صحیح وارد کنید");
                TXT_baggageCode.Text = string.Empty;

            }
            else errorProvider1.SetError(TXT_baggageCode, "");
        }

    }
}
