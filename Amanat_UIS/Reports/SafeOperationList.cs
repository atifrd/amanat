using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KM77.BLL;
using Telerik.WinControls.UI;

namespace Amanat_UIS.Reports
{
    public partial class SafeOperationList : Form
    {
        public SafeOperationList()
        {
            InitializeComponent();
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.RadReportGriedStyle(radGridView1);
            customizedThemeObj.FormStyle(this);
            this.radGridView1.ScreenTipNeeded += new Telerik.WinControls.ScreenTipNeededEventHandler(radGridView1_ScreenTipNeeded); 
        }

        private void SafeOperationList_Load(object sender, EventArgs e)
        {
            SetFormStyles();


            try
            {
                TXT_SerialTo.Text =( Convert.ToInt32(Amanat_BO.SafeOPeration.SafeOPerationGetLastNumber())-1).ToString();
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string WhereCondition = string.Empty;
                DataSet ds = new DataSet();

                WhereCondition = GetCondtitionString(WhereCondition);

                ds.Clear();radGridView1.DataSource=null;
                ds = Amanat_BO.SafeOPeration.SafeOPeration_List(WhereCondition);
             radGridView1.DataSource= ds.Tables[0];

                 Image myImage;
            
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    radGridView1.Rows[i].Cells["FishDateTime"].Value = BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["FishDateTime"]), false);
                    if (ds.Tables[0].Rows[i]["FishUrl"].ToString()!="")
                    {
                       // myImage = Bitmap.FromFile(ds.Tables[0].Rows[i]["FishUrl"].ToString());
                        radGridView1.Rows[i].Cells["FishUrl"].Value = Image.FromFile(ds.Tables[0].Rows[i]["FishUrl"].ToString());
                           // myImage;
                    }

                }

            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
                
            }
                       
           
        }

        private string GetCondtitionString(string WhereCondition)
        {
            if (TXT_SerialFrom.Text != string.Empty && TXT_SerialTo.Text != string.Empty)
            {
                WhereCondition = " where SafeOPSerialNumber <=" + TXT_SerialTo.Text + " and SafeOPSerialNumber >= " + TXT_SerialFrom.Text.Trim();
                if (TXT_Account.Text != string.Empty)
                {
                    WhereCondition += "  and  AccountId= (select AccountId From Account where AccountCode= " + TXT_Account.Text.Trim() + ") ";
                }
                if (TXT_FishSerialFrom.Text != string.Empty && TXT_FishSerialTo.Text != string.Empty)
                {
                    WhereCondition += "  and FishNumber>=" + TXT_FishSerialFrom.Text + " and FishNumber<= " + TXT_FishSerialTo.Text.Trim();
                }
            }
            else if (TXT_Account.Text != string.Empty)
            {
                WhereCondition = " where AccountId= (select AccountId From Account where AccountCode= " + TXT_Account.Text.Trim() + ") ";
                if (TXT_SerialFrom.Text != string.Empty && TXT_SerialTo.Text != string.Empty)
                {
                    WhereCondition += " and SafeOPSerialNumber <=" + TXT_SerialTo.Text + " and SafeOPSerialNumber>= " + TXT_SerialFrom.Text.Trim();
                }
                if (TXT_FishSerialFrom.Text != string.Empty && TXT_FishSerialTo.Text != string.Empty)
                {
                    WhereCondition += "  and FishNumber>=" + TXT_FishSerialFrom.Text + " and FishNumber<= " + TXT_FishSerialTo.Text.Trim();
                }
            }
            else if (TXT_FishSerialFrom.Text != string.Empty && TXT_FishSerialTo.Text != string.Empty)
            {
                WhereCondition = " where FishNumber>=" + TXT_FishSerialFrom.Text + " and FishNumber<= " + TXT_FishSerialTo.Text.Trim();
                if (TXT_Account.Text != string.Empty)
                {
                    WhereCondition += "  and  AccountId= (select AccountId From Account where AccountCode= " + TXT_Account.Text.Trim() + ") ";
                }
                if (TXT_SerialFrom.Text != string.Empty && TXT_SerialTo.Text != string.Empty)
                {
                    WhereCondition += " and SafeOPSerialNumber <=" + TXT_SerialTo.Text + " and SafeOPSerialNumber>= " + TXT_SerialFrom.Text.Trim();
                }
            }
            return WhereCondition;
        }

        private void SafeOperationList_KeyDown(object sender, KeyEventArgs e)
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

                WhereCondition = GetCondtitionString(WhereCondition);

                ds.Clear();
                ds = Amanat_BO.SafeOPeration.SafeOPeration_List(WhereCondition);
                ds.Tables[0].Columns.Add("StrFishDateTime");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ds.Tables[0].Rows[i]["StrFishDateTime"] = BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["FishDateTime"]), false);

                }
                Amanat_BO.Helper.SetReportAppearance(stiReportSafeOP, this);
                Amanat_BO.Helper.Print(ds, stiReportSafeOP);

            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");

            }
        }

        private void radGridView1_CellMouseMove(object sender, MouseEventArgs e)
        {
            //GridCellElement MyItem = (GridCellElement)sender;
            //if (MyItem != null && MyItem.ColumnIndex == 3 && MyItem.RowIndex > 0)
            //{
            //    MyToolTip.Show(MyItem.Value.ToString(), this.radGridView1, e.X, e.Y);
            //    Tax o = new Tax();
            //    FormCollection fm = Application.OpenForms;
            //    foreach (Form item in fm)
            //    {
            //        if (item.Name == o.Name) { o.Hide(); }
            //        o.Location = new System.Drawing.Point(e.X, e.Y); o.Show();

            //    }
               
            //}

        }
        ToolTip MyToolTip = new ToolTip();
        private void radGridView1_MouseEnter(object sender, EventArgs e)
        {
            //RadGridView Mygrd = (RadGridView)sender;

            //MyToolTip.Show(Mygrd.Rows[0].Cells[0].Value.ToString(), this.radGridView1, 100, 100);
        }

        private void radGridView1_MouseLeave(object sender, EventArgs e)
        {
            //MyToolTip.Hide(this.radGridView1);
            GridViewImageColumn a = new GridViewImageColumn();
            
        }
        private void ShowScreenTipForCell(GridDataCellElement cell)
        {
            if (cell.ColumnInfo.Name == "FishUrl")
            {
                DataRowView row = (DataRowView)cell.RowInfo.DataBoundItem;
                RadOffice2007ScreenTipElement screenTip = new RadOffice2007ScreenTipElement();
                screenTip.CaptionLabel.Margin = new Padding(6);
                Image FishImage = (Image)cell.Value;
                //(Image)row["FishUrl"]; 
                screenTip.MainTextLabel.Image = FishImage;
                screenTip.MainTextLabel.ImageAlignment = ContentAlignment.MiddleCenter;
                //screenTip.MainTextLabel.Margin = new Padding(1, 0, 1, 0);       
                //screenTip.MainTextLabel.Padding = new Padding(0, 0, 0, 3);         
                String text = "تصویر فیش"; //String.Format("MaxSpeed: {0}mphAcceleration 0-62mph: {1}secHorse Power: {2} bhp",
                //row["FishDateTime"]);
                screenTip.CaptionLabel.Text = text;
                screenTip.MainTextLabel.Text = string.Empty;
                screenTip.EnableCustomSize = false;
                cell.ScreenTip = screenTip;
            }
        }
        private void radGridView1_ScreenTipNeeded(object sender, Telerik.WinControls.ScreenTipNeededEventArgs e)
        { GridDataCellElement cell = e.Item as GridDataCellElement; 
            if (cell != null) 
            { this.ShowScreenTipForCell(cell); }
        } 
    }

}
