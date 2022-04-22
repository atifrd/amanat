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
    public partial class Fish_list : Form
    {
        public Fish_list()
        {
            InitializeComponent();
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.ReportGriedStyle(GRD_FishList);
            customizedThemeObj.FormStyle(this);

        }DataTable dt;
        private void Fish_list_Load(object sender, EventArgs e)
        {
            SetFormStyles();
            try
            {
                GRD_FishList.AutoGenerateColumns = false;
                 dt=
                Amanat_BO.GiveAndTake_masters.Fish_GetList(FishPrintInstance.WhereConParam).Tables[0];
                GRD_FishList.DataSource = dt;
               /* for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt16(dt.Rows[i]["statuse"]) == 1)
                        GRD_FishList.Rows[i].Cells["statuse"].Value = "تحویل نشده";
                    if (Convert.ToInt16(dt.Rows[i]["statuse"]) == 2)
                    {
                        GRD_FishList.Rows[i].Cells["statuse"].Value = "تحویل شده";
                       // GRD_FishList.Rows[i].Cells["Eexp_GiveBackDate"].Value = Convert.ToString(dt.Rows[i]["GiveBackTime"]).Substring(0, 5) + " " + KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(dt.Rows[i]["GiveBackDate"]), false);
                        GRD_FishList.Rows[i].Cells["Eexp_GiveBackDate"].Value = Convert.ToString(KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(dt.Rows[i]["GiveBackDate"]), false));
                    }
                    if (Convert.ToInt16(dt.Rows[i]["statuse"]) == 4)
                        GRD_FishList.Rows[i].Cells["statuse"].Value = "تحویل به پاسگاه";
                    if (Convert.ToInt16(dt.Rows[i]["statuse"]) == 5)
                        GRD_FishList.Rows[i].Cells["statuse"].Value = "ابطال";
                    //GRD_FishList.Rows[i].Cells["EGiveDate"].Value = Convert.ToString(dt.Rows[i]["GiveTime"]).Substring(0, 5) + " " + KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(dt.Rows[i]["GiveDate"]), false);
                    GRD_FishList.Rows[i].Cells["EGiveDate"].Value = Convert.ToString(KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(dt.Rows[i]["GiveDate"]), false));
                   
                    
                }*/
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
            
            
        }

        private void GRD_FishList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
              if (e.RowIndex == -1)
            {
                return;
            }
              int index = e.RowIndex;
              redirectToFishPage(index);

        }

        private void redirectToFishPage(int index)
        {
            
            this.SerialNumParam = GRD_FishList.Rows[index].Cells["FullSerialNumber"].Value.ToString();
            FishPrint_Show FishPrint_ShowOb = new FishPrint_Show();
            FishPrint_ShowOb.Fish_listInstance = this;
            FishPrint_ShowOb.MdiParent = Form1.ActiveForm;
            FishPrint_ShowOb.Show();
        }

        private void GRD_FishList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == System.Windows.Forms.Keys.Enter)
                {
                    int index = GRD_FishList.CurrentRow.Index;
                    redirectToFishPage(index);
                }
            }
            catch(Exception ex)
            {
            }
        }

        private void Fish_list_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
        }

        private void GRD_FishList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < GRD_FishList.Rows.Count; i++)
            {
                GRD_FishList.Rows[i].Cells["EGiveDate"].Value = Convert.ToString(dt.Rows[i]["GiveTime"]).Substring(0, 5) + " " + KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(dt.Rows[i]["GiveDate"]), false);

                if (Convert.ToInt16(GRD_FishList.Rows[i].Cells["statuseFIeld"].Value) == 1)
                    GRD_FishList.Rows[i].Cells["statuse"].Value = "تحویل نشده";
                if (Convert.ToInt16(GRD_FishList.Rows[i].Cells["statuseFIeld"].Value) == 2)
                {
                    GRD_FishList.Rows[i].Cells["statuse"].Value = "تحویل شده";
                    GRD_FishList.Rows[i].Cells["Eexp_GiveBackDate"].Value = Convert.ToString(dt.Rows[i]["GiveBackTime"]).Substring(0, 5) + " " + KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(dt.Rows[i]["GiveBackDate"]), false);
                    //GRD_FishList.Rows[i].Cells["Eexp_GiveBackDate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(GRD_FishList.Rows[i].Cells["Eexp_GiveBackDate"].Value), false);
                }
                if (Convert.ToInt16(GRD_FishList.Rows[i].Cells["statuseFIeld"].Value) == 4)
                    GRD_FishList.Rows[i].Cells["statuse"].Value = "تحویل به پاسگاه";
                if (Convert.ToInt16(GRD_FishList.Rows[i].Cells["statuseFIeld"].Value) == 5)
                    GRD_FishList.Rows[i].Cells["statuse"].Value = "ابطال";
               
            }
        }
    }
}
