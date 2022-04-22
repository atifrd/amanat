using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Amanat_UIS
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.GriedStyle(GRD_Accounts);
            customizedThemeObj.FormStyle(this);
            customizedThemeObj.ControlStyle(groupBox1);
        }

        private void Account_Load(object sender, EventArgs e)
        {
            SetFormStyles();
            FillDrp_LoadBank();
            LoadAccounts();
        }
        public void ShowMessageBox(string Message, string Title)
        {
            DialogResult myDialogResult = MessageBox.Show(Message, Title, MessageBoxButtons.OK);
        }
        private void ClearForm()
        {
            TXT_AccountCode.Text = "";
            TXT_AccountName.Text = "";
            TXT_AccountNumber.Text = "";
            Combo_BankBranches.SelectedIndex = 0;
            BTN_Edit.Enabled = false;
            BTN_Save.Enabled = true;
            TXT_AccountCode.Focus();
        }
        private void FillDrp_LoadBank()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = Amanat_BO.Bank.Bank_SelectAll();
                Combo_BankBranches.DisplayMember = "bankBranch";
                Combo_BankBranches.ValueMember = "BranchId";
                Combo_BankBranches.DataSource = ds.Tables[0];
               

            }
            catch (Exception ex)
            {

                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
        }



        private void LoadAccounts()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = Amanat_BO.Accounts.Account_SelectAll();
                GRD_Accounts.AutoGenerateColumns = false;
                GRD_Accounts.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {

                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Amanat_BO.Accounts.Account_insert(Convert.ToInt32(TXT_AccountCode.Text),
                TXT_AccountName.Text,
                TXT_AccountNumber.Text,
                Convert.ToInt32(Combo_BankBranches.SelectedValue));
                LoadAccounts();
                ClearForm();
                MessageBox.Show("ثبت با موفقیت انجام شد");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
            
        }

        private void GRD_Accounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                
                return;
            }
            try
            {
                TXT_AccountCode.Text = GRD_Accounts.Rows[e.RowIndex].Cells["AccountCode"].Value.ToString();
                TXT_AccountName.Text = GRD_Accounts.Rows[e.RowIndex].Cells["AccountName"].Value.ToString();
                TXT_AccountNumber.Text = GRD_Accounts.Rows[e.RowIndex].Cells["AccountNumber"].Value.ToString();
                LBL_AccountId.Text = GRD_Accounts.Rows[e.RowIndex].Cells["AccountId"].Value.ToString();
                //FKBranchId
                Combo_BankBranches.SelectedValue = GRD_Accounts.Rows[e.RowIndex].Cells["FKBranchId"].Value.ToString();
                BTN_Edit.Enabled = true;
                BTN_Save.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearForm();

        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                Amanat_BO.Accounts.Account_Edit(Convert.ToInt32(TXT_AccountCode.Text),
                TXT_AccountName.Text,
                TXT_AccountNumber.Text,
                Convert.ToInt32(Combo_BankBranches.SelectedValue), Convert.ToInt32(LBL_AccountId.Text));
                ClearForm();
                MessageBox.Show("ویرایش با موفقیت انجام شد");
                LoadAccounts();
                
            }
            catch (Exception)
            {

                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
        }

        private void Account_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
        }

       

        private void TXT_AccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (Amanat_BO.Validating.txtNumericStringIsValid(TXT_AccountNumber.Text))
            {
                errorProvider1.SetError(TXT_AccountNumber, "کد بانک را صحیح وارد کنید");
                e.Cancel = true;
            }
            else errorProvider1.SetError(TXT_AccountNumber, "");
        }

        private void TXT_AccountCode_TextChanged(object sender, EventArgs e)
        {
            if (Amanat_BO.Validating.txtNumericStringIsValid(TXT_AccountCode.Text))
            {
                errorProvider1.SetError(TXT_AccountCode, "کد بانک را صحیح وارد کنید");
                TXT_AccountCode.Text = string.Empty;
            }
            else errorProvider1.SetError(TXT_AccountCode, "");
        }
    }
}
