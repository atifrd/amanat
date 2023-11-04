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
    public partial class FishPrint_Show : Form
    {
        public FishPrint_Show()
        {
            InitializeComponent();
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.InsertGriedStyle(GRD_GiveAndTakeDetails); GRD_GiveAndTakeDetails.AllowUserToAddRows = false; 
            GRD_GiveAndTakeDetails.AllowUserToDeleteRows = false;
            customizedThemeObj.FormStyle(this);
        }

        private void FishPrint_Show_Load(object sender, EventArgs e)
        {
            SetFormStyles();
            LoadFishInfo();
        }
        private void LoadFishInfo()
        {
            try
            {
                string serialNumber = SetSerialNumber_BySenderForm();
                DataSet ds = Amanat_BO.GiveAndTake_masters.Search_Fish(serialNumber, System.DateTime.Now,
                    Amanat_BO.UserSettings.TaxId);
                ds.Tables[1].Merge(ds.Tables[2]);//bara grid

                if (ds.Tables[1].Rows.Count >= 2)// ds.Tables[2] always has 1or 3 rows
                {
                    
                    Int16 Sts = Convert.ToInt16(ds.Tables[0].Rows[0]["Statuse"]);
                    switch (Sts)
                    {
                        case 1: lbl_sts.Text = string.Empty;
                            break;
                        case 2: lbl_sts.Text = "قبض مورد نظر تحویل داده شده ";
                            LBL_GiveBackDate.Text = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[0]["GiveBackDate"]),false);
                            LBL_GiveBackTime.Text = ds.Tables[0].Rows[0]["GiveBackTime"].ToString();
                            break;
                        case 4: lbl_sts.Text = "قبض مورد نظر به پایگاه تحویل داده شده ";
                            break;
                        case 5: lbl_sts.Text = "قبض مورد نظرابطال شده ";
                            break;

                    }
                        GRD_GiveAndTakeDetails.DataSource = ds.Tables[1];
                        LBL_SerialNumber.Text = ds.Tables[0].Rows[0]["SerialNumber"].ToString();
                        LBL_Person.Text = ds.Tables[0].Rows[0]["Person"].ToString();
                        PTell.Text = ds.Tables[0].Rows[0]["Ptell"].ToString();
                        LBL_GiveDate.Text = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[0]["GiveDate"]), false);
                        LBL_GiveTime.Text = ds.Tables[0].Rows[0]["GiveTime"].ToString();
                        LBL_exp_GiveBackDate.Text = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[0]["exp_GiveBackDate"]), false);
                        LBL_exp_GiveBackTime.Text = ds.Tables[0].Rows[0]["exp_GiveBackTime"].ToString();
                        
                        TXT_Discount.Text = ds.Tables[0].Rows[0]["discount"].ToString();
                        decimal FSum = 0;
                        for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                        {
                            FSum += Convert.ToDecimal(ds.Tables[1].Rows[i]["MySum"]);
                        }
                        FSum = FSum- Convert.ToDecimal(TXT_Discount.Text);
                        textBox2.Text = Amanat_BO.Helper.GetCurrencyFormat(FSum.ToString());
                        LBL_User.Text = "تحویل گیرنده :" + "  " + ds.Tables[0].Rows[0]["User_Give"].ToString() + "            " + "تحویل دهنده :" + "   " + ds.Tables[0].Rows[0]["User_back"].ToString();
                    
                }
                else { MessageBox.Show("سریال موردنظر در سیستم وجود ندارد"); this.Close(); }
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }

        }

        private string SetSerialNumber_BySenderForm()
        {
            string serialNumber = string.Empty;
            if (this.Fish_listInstance != null)
                serialNumber = this.Fish_listInstance.SerialNumParam.Trim();
            else if (this.EditListInstance != null)
                serialNumber = EditListInstance.SerialNumParam_edited.Trim();
            else if (this.ReportEbtalInstance != null)
                serialNumber = ReportEbtalInstance.SerialNumParam_Ebtal.Trim();
            return serialNumber;
        }

        private void BTN_Print_Click(object sender, EventArgs e)
        {
            try
            {
                string serialNumber = SetSerialNumber_BySenderForm();
                DataSet ds = Amanat_BO.GiveAndTake_masters.Search_Fish(serialNumber.Trim(), System.DateTime.Now,
                   Amanat_BO.UserSettings.TaxId);
                ds.Tables[1].Merge(ds.Tables[2]);
                Amanat_BO.Helper.SetReportAppearance(stiReportFishCustom, this);
                Amanat_BO.Helper.FishMainBody_SetFont(stiReportFishCustom);
                stiReportFishCustom.Compile();
                stiReportFishCustom["VTextSerial"] = " سریال  " + "  " + LBL_SerialNumber.Text;
                stiReportFishCustom["VTextName"] = "نام " + "   " + LBL_Person.Text;
                stiReportFishCustom["VTextTell"] = "تلفن " + "   " + PTell.Text;
                stiReportFishCustom["VTextGiVeDate"] = LBL_GiveDate.Text;
                stiReportFishCustom["VTextGiveTime"] = LBL_GiveTime.Text;
                stiReportFishCustom["VTextBackDate"] = LBL_GiveBackDate.Text;
                stiReportFishCustom["VTextBackTime"] = LBL_GiveBackTime.Text;

                stiReportFishCustom["VPrintTxt"] = Amanat_BO.UserSettings.PrintTxt;
                stiReportFishCustom["VOfficeTell"] = " " + "تلفن:" + " " + Amanat_BO.UserSettings.OfficeTell;
                stiReportFishCustom["VPrint_Font"] = Amanat_BO.UserSettings.Print_Font;

                Amanat_BO.Helper.FishPrint(ds.Tables[1], stiReportFishCustom); this.Close();
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
        }

        private void FishPrint_Show_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
        }
     

    }
}
