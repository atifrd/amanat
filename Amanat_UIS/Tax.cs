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
    public partial class Tax : Form
    {
        public Tax()
        {
            InitializeComponent();
           
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
          customizedThemeObj.ReportGriedStyle(dataGridViewtax);
            customizedThemeObj.FormStyle(this);
            masked_FromDate.Mask = Amanat_BO.UserSettings.MaskedDate;
            
        }

        private void TXT_AccountCode_Validating(object sender, CancelEventArgs e)
        {
            if (Amanat_BO.Validating.txtNumericStringIsValid(TXT_Tax.Text))
            {
                errorProvider1.SetError(TXT_Tax, "میزان مالیات را صحیح وارد کنید");
                //e.Cancel = true;
            }
            else errorProvider1.SetError(TXT_Tax, "");
        }

        
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (!Amanat_BO.Validating.DueDatetimIsValid(masked_FromDate.Text.Remove(2, 1).Remove(5, 1), masked_ToDate.Text.Remove(2, 1).Remove(5, 1)))
            {
                MessageBox.Show("تاریخ نا درست است"); return;
            }
            Boolean Result = false;
            try
            {
               Result= Amanat_BO.Tax.Tax_Insert(BLLDate.getGregorianDate(masked_FromDate.Text.Remove(2, 1).Remove(5, 1)),
                    BLLDate.getGregorianDate(masked_ToDate.Text.Remove(2, 1).Remove(5, 1)), Convert.ToDouble(TXT_Tax.Text)*0.01);
               if (Result) {
                   MessageBox.Show("ثبت با موفقیت انجام شد"); 
                   LoadGried();
                   resetform();
               }
               else MessageBox.Show("Period overlaps");
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
           
        }

        private void resetform()
        {
            TXT_Tax.Text = "";
            LBL_TaxId.Text = "0";
            masked_ToDate.Text = "";
            masked_FromDate.Text = "";
            BTN_Edit.Enabled = false; BTN_Save.Enabled = true; masked_FromDate.Focus();
        }

        private void Tax_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
        }

        private void Tax_Load(object sender, EventArgs e)
        {
            SetFormStyles();
            LoadGried();
        }
        DataSet ds;
        private void LoadGried()
        {
            try
            {
                 ds = Amanat_BO.Tax.Tax_SelectAll();
                dataGridViewtax.DataSource = ds.Tables[0];
                               
            }
            catch (Exception ex) { Amanat_BO.SysLog.WriteInLogFile(ex.ToString()); }
        }

        private void dataGridViewtax_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int k = e.RowIndex;
            DataGridViewRow CurrentRow = dataGridViewtax.Rows[e.RowIndex];
            try
            {
               
                if (e.ColumnIndex == dataGridViewtax.Columns["BTN_Delete"].Index)
                {
                    if (MessageBox.Show("آیا از حذف سطر مورد نظر اطمینان دارید؟", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        int _TaxId = Convert.ToInt32(CurrentRow.Cells["TaxId"].Value);
                        DateTime _FromDate = BLLDate.getGregorianDate(BLLDate.ConvertRTLPDateToLTRPdate(CurrentRow.Cells["FromDate"].Value.ToString()));
                        DateTime _ToDate = BLLDate.getGregorianDate(BLLDate.ConvertRTLPDateToLTRPdate(CurrentRow.Cells["ToDate"].Value.ToString()));
                       
                        string _Message=Amanat_BO.Tax.Tax_Delete(_FromDate,_ToDate,_TaxId) ? "حذف با موفقیت انجام شد" : "امکان حذف وجود ندارد";
                        MessageBox.Show(_Message);
                        resetform();
                        LoadGried();
                    }
                }


            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا");
            }
        }

        private void dataGridViewtax_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int k = e.RowIndex;
            DataGridViewRow CurrentRow = dataGridViewtax.Rows[e.RowIndex];
            LBL_TaxId.Text = Convert.ToString(CurrentRow.Cells["TaxId"].Value);
            masked_FromDate.Text = BLLDate.ConvertRTLPDateToLTRPdate(CurrentRow.Cells["FromDate"].Value.ToString()).Remove(6, 2);
            masked_ToDate.Text =BLLDate.ConvertRTLPDateToLTRPdate( CurrentRow.Cells["ToDate"].Value.ToString()).Remove(6, 2);
            TXT_Tax.Text = (Convert.ToDouble(CurrentRow.Cells["TaxBurden"].Value)*100).ToString();
            BTN_Edit.Enabled = true;
            BTN_Save.Enabled = false;

        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("آیا از ویرایش سطر مورد نظر اطمینان دارید؟", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataSet ds =
                    Amanat_BO.Tax.Tax_Edit(BLLDate.getGregorianDate(masked_FromDate.Text.Remove(2, 1).Remove(5, 1)),
                        BLLDate.getGregorianDate(masked_ToDate.Text.Remove(2, 1).Remove(5, 1)), Convert.ToDouble(TXT_Tax.Text) * 0.01, Convert.ToInt32(LBL_TaxId.Text));
                    //bool ChangingFromDateIsOk = 
                    string _message = "";
                    _message = Convert.ToBoolean(ds.Tables[0].Rows[0]["ChangingFromDateIsOk"]) ? "" : ".امکان تغییر تاریخ شروع وجود ندارد";
                    _message += Convert.ToBoolean(ds.Tables[0].Rows[0]["ChangingToDateIsOk"]) ? "" : ".امکان تغییر تاریخ پایان وجود ندارد";
                    _message += Convert.ToBoolean(ds.Tables[0].Rows[0]["ChangingTaxBurdenIsOk"]) ? "" : ".امکان تغییر مالیات وجود ندارد";
                    _message += Convert.ToBoolean(ds.Tables[0].Rows[0]["DateDoesntOverLap"]) ? "" : ".بازه تعیین شده صحیح نیست";
                    if (_message.Trim() == "")
                    {
                        _message = "ویرایش با موفقیت انجام شد";
                        LoadGried();

                    }
                    MessageBox.Show(_message);
                    resetform();

                }
            }
            catch (Exception ex)
            {

                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadGried();
        }

        private void dataGridViewtax_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ((DataGridViewButtonCell)(dataGridViewtax.Rows[i].Cells["BTN_Delete"])).Value = "حذف";
                dataGridViewtax.Rows[i].Cells["FromDate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["FromDate"]),false);
                dataGridViewtax.Rows[i].Cells["ToDate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["ToDate"]),false);
               
            }

        }
                

        
    }
}
