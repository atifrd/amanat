using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Amanat_UIS.Reports
{
    public partial class ReportEbtal : Form
    {
        public ReportEbtal()
        {
            InitializeComponent();
        }

        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.FormStyle(this);
            customizedThemeObj.RadReportGriedStyle(radGridView_edit);

        }
        DataTable dt;
        private void ReportEbtal_Load(object sender, EventArgs e)
        {
             dt=Amanat_BO.GiveAndTakes.Report_ebtal().Tables[0];
            SetFormStyles();
            radGridView_edit.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                radGridView_edit.Rows[i].Cells["EGiveDate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(dt.Rows[i]["GiveDate"]), false);
            }
           
        }

        private void ReportEbtal_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.F)
            {
                BTN_Print_Click(sender, e);
            }

        }
        private void BTN_Print_Click(object sender, EventArgs e)
        {
            try
            {
                string WhereCondition = string.Empty;
                DataSet ds = new DataSet();

               

                ds.Clear();
                ds = Amanat_BO.GiveAndTakes.Report_ebtal();
                ds.Tables[0].Columns.Add("GDate");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ds.Tables[0].Rows[i]["GDate"] = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["GiveDate"]),false);
                }
                Amanat_BO.Helper.SetReportAppearance(stiReportEbtal,this);
                Amanat_BO.Helper.Print(ds, stiReportEbtal);
                
                
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");

            }
        }

        private void GRD_Details_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                radGridView_edit.Rows[i].Cells["EGiveDate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(dt.Rows[i]["GiveDate"]), false);
            }
        }

        private void radGridView_edit_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            this.SerialNumParam_Ebtal = radGridView_edit.Rows[e.RowIndex].Cells["FullSerialNumber"].Value.ToString();
            FishPrint_Show FishPrint_ShowOb = new FishPrint_Show();
            FishPrint_ShowOb.ReportEbtalInstance = this;
            FishPrint_ShowOb.MdiParent = Form1.ActiveForm;
            FishPrint_ShowOb.Show();
        }

        private void radGridView_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
