using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KM77.BLL;
using System.IO;

namespace Amanat_UIS
{
    public partial class SafeOPerationFRM : Form
    {
        public SafeOPerationFRM()
        {
            InitializeComponent();
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();

            
            customizedThemeObj.FormStyle(this);
           
        }
        private static AutoCompleteStringCollection Account_AutoComplete()
        {   
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
            DataSet ds = Amanat_BO.Accounts.Account_SelectAll();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                myCollection.Add(ds.Tables[0].Rows[i]["AccountCode"].ToString());
            }

            return myCollection;
        }

        void LastNumber()
        {
               
                try
                {
                    LBL_SerialNumber.Text=Amanat_BO.SafeOPeration.SafeOPerationGetLastNumber();
                }
                catch (Exception ex)
                {
                    Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                    MessageBox.Show("بروز خطا در انجام عملیات ");
                }

        }
        private void SafeOPerationFRM_Load(object sender, EventArgs e)
        {
            maskedFishDateTime.Text = BLLDate.getPersianDate(System.DateTime.Now.Date,true);
            SetFormStyles();
            LastNumber();
            try{//problem:poole tooye sandoogh be tarikh nabaiad va baste bash?
                 lBL_SafeMoney.Text=Amanat_BO.SafeOPeration.GiveAndTake_MoneyInSafe(Convert.ToDateTime("12-12-1812"));
                AutoCompleteStringCollection myCollection = Account_AutoComplete();
                TXT_Account.AutoCompleteCustomSource = myCollection;
                TXT_Account.Focus();

            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
            
        }

        private void TXT_Account_Leave(object sender, EventArgs e)
        {
            try
            {
                if (TXT_Account.Text!=string.Empty)
                {
                    LBL_BankFull.Text = Amanat_BO.Accounts.Account_GetAccountbyCode(Convert.ToInt32(TXT_Account.Text));   
                }
               
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("کدبانک صحیح نیست  "); TXT_Account.Focus();
            }
           
        }

        private void maskedexp_GiveBackDate_Validated(object sender, EventArgs e)
        {
            TXT_Account.Focus();
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            decimal mande = 0;
            string PicNewName = string.Empty;
            try
            {
                if (TXT_FishUrl.Text != string.Empty)
                {
                     PicNewName = GetPicNewName();
                    var size = new FileInfo(TXT_FishUrl.Text).Length;
                    if (size > 60000)//byte
                    {
                        MessageBox.Show("حجم تصویر از حد مجاز بیشتر است"); return;
                    }
                }
                
                mande = Convert.ToDecimal(lBL_SafeMoney.Text) - Convert.ToDecimal(TXT_BES.Text.Replace(",",""));
                Amanat_BO.SafeOPeration.SafeOPeration_insert(Convert.ToInt64(LBL_SerialNumber.Text), 
                    BLLDate.getGregorianDate(maskedFishDateTime.Text.Remove(2, 1).Remove(5, 1)),
                               Convert.ToInt32(TXT_Account.Text.Trim()), TXT_FishNumber.Text, 0, TXT_FishDesc.Text, 3, Convert.ToDecimal(TXT_BES.Text.Replace(",", "")), mande, Amanat_BO.UserSettings.UserID,
                               TXT_FishUrl.Text, PicNewName
                               );
                
                MessageBox.Show("عملیات با موفقیت انجام شد");
                ResetForm();
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");

            }
            finally
            {
                
            }


        }

        private void ResetForm()
        {
            TXT_Account.Text = "";
            TXT_BES.Text = "0";
            TXT_FishDesc.Text = "";
            TXT_FishNumber.Text = "";
            LBL_BankFull.Text = "";
            LBL_FKAccountId.Text = "0";
            LBL_SerialNumber.Text = "0";
            maskedFishDateTime.Text = BLLDate.getPersianDate(System.DateTime.Now.Date, true);
            TXT_FishUrl.Text = "";
            TXT_Account.Focus();
            LastNumber();
        }

        private void SafeOPerationFRM_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
            if (e.KeyCode == Keys.Insert)
           {
               BTN_Save_Click(sender, e);
           }
        }

        private void TXT_FishDesc_Enter(object sender, EventArgs e)
        {
            TXT_FishDesc.Text = string.Empty;
                TXT_FishDesc.Text = "واریز وجه به حساب " + " " + LBL_BankFull.Text;
            
        }

        private void TXT_BES_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(TXT_BES.Text.Replace(",", "")) > Convert.ToDecimal(lBL_SafeMoney.Text))
                {
                    errorProvider1.SetError(TXT_BES, "مبلغ مورد نظر از مانده صندوق بیستر است");
                    e.Cancel = true; ;
                }
                else { e.Cancel = false; errorProvider1.SetError(TXT_BES, ""); }
            }
            catch (Exception ex) { Amanat_BO.SysLog.WriteInLogFile(ex.ToString()); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        string GetPicNewName()
        {
            string ImageName = System.IO.Path.GetFileNameWithoutExtension(TXT_FishUrl.Text);
            string ImageExtension = System.IO.Path.GetExtension(TXT_FishUrl.Text);
            ImageName = ImageName +"_S"+LBL_SerialNumber.Text.Trim() +ImageExtension;
            return ImageName;
        }
        private void btnFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK  && openFileDialog1.FileName!=null)
            {
              
                TXT_FishUrl.Text = openFileDialog1.FileName;
                
            }
            if (result == DialogResult.Cancel) TXT_FishUrl.Focus();
            
            
        }

        private void TXT_BES_TextChanged(object sender, EventArgs e)
        {
            TXT_BES.Text = Amanat_BO.Helper.GetCurrencyFormat(TXT_BES.Text);
            TXT_BES.SelectionStart = TXT_BES.Text.Length; TXT_BES.Select();
        }
    }
}
