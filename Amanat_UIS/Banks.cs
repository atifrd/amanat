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
    public partial class Banks : Form
    {
        public Banks()
        {
            InitializeComponent();
        }
        void RefreshForm()
        {
            TXT_BankName.Text = ""; LBL_HiddenBankId.Text = "0";
            GRD_Branch.DataSource = null; GRD_Branch.Rows.Clear();
            BTN_Edit.Enabled = false;
            BTN_Save.Enabled = true;
            TXT_BankName.Focus();
        }
        private void Banks_Load(object sender, EventArgs e)
        {
           
            Loadbank();
            CreateDataTable();
            SetFormStyles();
        }

        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();

            customizedThemeObj.InsertGriedStyle(GRD_Branch);
            customizedThemeObj.ReportGriedStyle(GRD_Edit); 
            customizedThemeObj.FormStyle(this);
            customizedThemeObj.ControlStyle(groupBox1);
        }

        private static DataTable CreateDataTable()
        {
            DataTable dt = new System.Data.DataTable("Mydt");
            dt.Columns.Add("BranchId", System.Type.GetType("System.Int32"));
            dt.Columns.Add("BranchName", System.Type.GetType("System.String"));
            return dt;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Loadbank();
           
        }

        private void Loadbank()
        {
            try
            {
                DataSet ds = new DataSet();
                GRD_Edit.AutoGenerateColumns = false;
                ds = Amanat_BO.Bank.Bank_SelectAll();
                GRD_Edit.DataSource = ds.Tables[0];
                int b = ds.Tables[0].Columns.Count;
                int a = ds.Tables[0].Rows.Count;

            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
        }

       

        private void LoadBranches(int BankId)
        {
            GRD_Branch.AutoGenerateColumns = false;
            GRD_Branch.DataSource = Amanat_BO.Branhes.Branhes_selectAllByBankId(BankId).Tables[0];//0 is defualt value to show nothing
        }
        
      

        

        private void GRD_Edit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                int HiddenBankId = Convert.ToInt32(GRD_Edit.Rows[e.RowIndex].Cells["BankId"].Value);
                TXT_BankName.Text = GRD_Edit.Rows[e.RowIndex].Cells["BankName"].Value.ToString();
                LoadBranches(HiddenBankId);
                LBL_HiddenBankId.Text = HiddenBankId.ToString();
                BTN_Edit.Enabled = true;
                BTN_Save.Enabled = false;
            
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
            
           
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {object BranchId;
            try
            {
                DataGridViewRowCollection MyRows = GRD_Branch.Rows;
                    for (int i = 0; i < GRD_Branch.Rows.Count-1; i++)
                    {
                        BranchId = MyRows[i].Cells["BranchId"].Value.ToString() == "" ? 0 : MyRows[i].Cells["BranchId"].Value;
                        Amanat_BO.Bank.Bank_Update(Convert.ToInt32(LBL_HiddenBankId.Text),
                            Convert.ToInt32(BranchId), TXT_BankName.Text,
                        MyRows[i].Cells["BranchName"].Value.ToString(),
                        MyRows[i].Cells["BranchDesc"].Value.ToString());
                    }
                
                RefreshForm();
                Loadbank();
                ShowMessageBox("ویرایش با موفقیت انجام شد", "");
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
            
        }

       
        public void ShowMessageBox(string Message,string Title)
        {
            DialogResult myDialogResult = MessageBox.Show(Message, Title, MessageBoxButtons.OK);
        }

       

       

        private void Banks_Activated(object sender, EventArgs e)
        {
            
        }

      
        bool justnumber()
        {
            return true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
           // TXT_BankName_Validated(sender, e);
            try
            {
                if ((GRD_Branch.Rows.Count - 1) == 0) { MessageBox.Show("شعب بانک را وارد کنید"); return; }
                
                    for (int i = 0; i < GRD_Branch.Rows.Count - 1; i++)
                    {
                        string BranchName = GRD_Branch.Rows[i].Cells[0].Value.ToString();
                        string BranchDesc = Convert.ToString(GRD_Branch.Rows[i].Cells[1].Value);
                        Amanat_BO.Bank.Bank_insert(TXT_BankName.Text, BranchName, BranchDesc);

                    }
                    Loadbank();
                    RefreshForm();
                    ShowMessageBox("ثبت با موفقیت انجام شد", "");
                
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }

        }

        private void TXT_BankName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Banks_KeyDown_1(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
            if (e.KeyCode == Keys.Insert)
            {
                BTN_Save_Click(sender, e);
            }
        }

        private void TXT_BankName_Validating(object sender, CancelEventArgs e)
        {
            if (Amanat_BO.Validating.txtInputIsNotEmpy(TXT_BankName.Text))
            {
                errorProvider1.SetError(TXT_BankName, "نام بانک را وارد کنید");
               // e.Cancel = true;
            }
            else errorProvider1.SetError(TXT_BankName, "");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
       
    }
}
