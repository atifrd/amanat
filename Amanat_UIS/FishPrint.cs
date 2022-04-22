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
    public partial class FishPrint : Form
    {
        public FishPrint()
        {
            InitializeComponent();
        }

        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.FormStyle(this);
            string NowSession = Convert.ToString(Amanat_BO.UserSettings.SessionNo);
            if (NowSession.Trim() != "0")
            {
                LBL_Systemsession.Text = NowSession;
                LBL_SysSessionFullName.Text = " فصل جاری سیستم :" + NowSession;
            }
            else
            {
                MessageBox.Show(" لطفا فصل جدید تعریف کنید. فصل در سیستم تعریف نشده ویا فصل قبلی منقضی شده است ");

                Sessions sessionOb = new Sessions();
                sessionOb.Show();
                this.Close();
            }

        }
        private void TXT_SerialNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == System.Windows.Forms.Keys.Enter)
            {
                if (TXT_SerialNumber.Text != string.Empty)
                    SearchBtnPressed();
            }
        }
        private void SearchBtnPressed()
        {

            this.WhereConParam = GetWhereCondition();
            try
            {
                Fish_list Fish_listOb = new Fish_list();
                Fish_listOb.FishPrintInstance = this; 
                this.Close();
               Fish_listOb.MdiParent = Form1.ActiveForm;
                Fish_listOb.Show();
                
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
        }

        private void FishPrint_Load(object sender, EventArgs e)
        {
            SetFormStyles();
        }
        Amanat_UIS.customizedTheme customizedThemeObj = new customizedTheme();
        private void FishPrint_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
            
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.N)
            {
               customizedThemeObj.GoToNextSession(LBL_SysSessionFullName, LBL_Systemsession);

            }
            else if (e.KeyCode == Keys.Control || e.KeyCode == Keys.P)
            {
                customizedThemeObj.GoToPrevioseSession(LBL_SysSessionFullName, LBL_Systemsession);

            }
        }
        private string GetWhereCondition()
        {
            string WhereCondition = string.Empty;
            WhereCondition += " where (Statuse=1 or Statuse=2 or Statuse=3 or Statuse=4 or Statuse=5) ";

            if (TXT_SerialNumber.Text != string.Empty)
                WhereCondition += " and SerialNumber= '" + LBL_Systemsession.Text + TXT_SerialNumber.Text.Trim()+"' " +
                    "";
            if (!maskedGiveFrom.Text.Contains("  ") && !maskedGiveTo.Text.Contains("  "))
            {
                WhereCondition += "  and  GiveDate between convert(date,'" + BLLDate.getGregorianDate(maskedGiveFrom.Text.Remove(2, 1).Remove(5, 1)) + "',101)  and  convert(date,'" + BLLDate.getGregorianDate(maskedGiveTo.Text.Remove(2, 1).Remove(5, 1)) + "',101) ";
            }
            if (!maskedExBackFrom.Text.Contains("  ") && !maskedExBackto.Text.Contains("  "))
            {
                WhereCondition += "  and  exp_GiveBackDate between convert(date,'" + BLLDate.getGregorianDate(maskedExBackFrom.Text.Remove(2, 1).Remove(5, 1)) + "',101)  and convert(date,'" + BLLDate.getGregorianDate(maskedExBackto.Text.Remove(2, 1).Remove(5, 1)) + "',101) ";
            }

            if (!maskedGiveBackFrom.Text.Contains("  ") && !maskedGiveBackTo.Text.Contains("  "))
            {
                WhereCondition += "  and  GiveBackDate between convert(date,'" + BLLDate.getGregorianDate(maskedGiveBackFrom.Text.Remove(2, 1).Remove(5, 1)) + "',101)  and convert(date,'" + BLLDate.getGregorianDate(maskedGiveBackTo.Text.Remove(2, 1).Remove(5, 1)) + "',101) ";
            }
            if (TXT_Name.Text.Trim() != string.Empty)
                WhereCondition += "  and  Person like N'%"+TXT_Name.Text.Trim()+"%'";
            if (TXT_Tell.Text.Trim() != string.Empty)
                WhereCondition += "  and  PTell = '"+TXT_Tell.Text.Trim()+"'";

            return WhereCondition;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchBtnPressed();

        }

        

        private void TXT_SerialNumber_TextChanged(object sender, EventArgs e)
        {
            if (Amanat_BO.Validating.txtNumericStringIsValid(TXT_SerialNumber.Text))
            {
                TXT_SerialNumber.Text = string.Empty;

            }
        }

        private void pictureBox_Previous_Click(object sender, EventArgs e)
        {
            customizedThemeObj.GoToPrevioseSession(LBL_SysSessionFullName, LBL_Systemsession);
        }

        private void pictureBox_Next_Click(object sender, EventArgs e)
        {
            customizedThemeObj.GoToNextSession(LBL_SysSessionFullName, LBL_Systemsession);
        }
    }
}
