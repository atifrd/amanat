using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KM77.BLL;

namespace Amanat_UIS.Reports
{
    public partial class EditList : Form
    {
        public EditList()
        {
            InitializeComponent();
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.FormStyle(this); customizedThemeObj.ControlStyle(panel1);
             customizedThemeObj.RadReportGriedStyle(radGridView_edit);
        }
        void RefreshForm()
        {
            maskedExBackto.Text = BLLDate.getPersianDate(System.DateTime.Now.Date, true);
            maskedGiveBackTo.Text = BLLDate.getPersianDate(System.DateTime.Now.Date, true);
            maskedGiveTo.Text = BLLDate.getPersianDate(System.DateTime.Now.Date, true);
            TXT_SerialTo.Text = (Convert.ToInt32(Amanat_BO.GiveAndTake_masters.GiveAndTake_master_ReturnLastSerialNumber(Amanat_BO.UserSettings.SessionNo.ToString())) - 1).ToString();
        }
        

        private void EditList_Load(object sender, EventArgs e)
        {
            SetFormStyles();
            Refresh();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string WhereCondition = GetWhereCondition();
            try
            {
                DataTable dt = Amanat_BO.GiveAndTakes.Report_EditedFish(WhereCondition).Tables[0];
                radGridView_edit.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    radGridView_edit.Rows[i].Cells["EditDateTime"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(dt.Rows[i]["EditDateTime"]), false);
                    radGridView_edit.Rows[i].Cells["EGiveDate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(dt.Rows[i]["GiveDate"]), false);
                    if (dt.Rows[i]["GiveBackDate"].ToString() != string.Empty)
                        radGridView_edit.Rows[i].Cells["GiveBackDate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(dt.Rows[i]["GiveBackDate"]), false);
                  /*  if (Convert.ToInt16(dt.Rows[i]["statuse"]) == 1)
                        radGridView_edit.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    if (Convert.ToInt16(dt.Rows[i]["statuse"]) == 2 || Convert.ToInt16(dt.Rows[i]["statuse"]) == 3)
                        radGridView_edit.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    if (Convert.ToInt16(dt.Rows[i]["statuse"]) == 4)
                        radGridView_edit.Rows[i].DefaultCellStyle.BackColor = Color.Red;//Police
                 */
                }
                //
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private string GetWhereCondition()
        {
            string WhereCondition = string.Empty;
            WhereCondition += " WHERE     (GiveAndTake_master.EditDateTime is not null)";
            if (checkBoxAll.Checked) WhereCondition += " and (Statuse=1 or Statuse=2 or Statuse=3 or Statuse=4) ";
            else if (checkBoxJustBak.Checked) WhereCondition += " and Statuse=2  ";
            else if (checkBoxJustDontbaCk.Checked) WhereCondition += " and Statuse=1 ";


            if (TXT_SerialFrom.Text != string.Empty && TXT_SerialTo.Text != string.Empty)
                WhereCondition += " and SerialNumber<= " + Convert.ToString(Amanat_BO.UserSettings.SessionNo) + TXT_SerialTo.Text + "  and SerialNumber >= " + Convert.ToString(Amanat_BO.UserSettings.SessionNo) + TXT_SerialFrom.Text;
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

            return WhereCondition;
        }

        private void BTN_Print_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                string WhereCondition = GetWhereCondition();

                DataSet ds = Amanat_BO.GiveAndTakes.Report_EditedFish(WhereCondition);
                ds.Tables[0].Columns.Add("a");
                ds.Tables[0].Columns.Add("b");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ds.Tables[0].Rows[i]["a"] = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["GiveDate"]), false);
                    ds.Tables[0].Rows[i]["b"] = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["EditDateTime"]), false);
                }
                Amanat_BO.Helper.SetReportAppearance(stiReportSysDetails, this);
                Amanat_BO.Helper.Print(ds, stiReportSysDetails);
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            this.SerialNumParam_edited = radGridView_edit.Rows[e.RowIndex].Cells["FullSerialNumber"].Value.ToString();
            FishPrint_Show FishPrint_ShowOb = new FishPrint_Show();
            FishPrint_ShowOb.EditListInstance = this;
            FishPrint_ShowOb.MdiParent = Form1.ActiveForm;
            FishPrint_ShowOb.Show();
        }
    }
}

