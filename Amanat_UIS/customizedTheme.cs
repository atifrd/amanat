using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  System.Windows.Forms;
using System.Drawing;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls.UI;

namespace Amanat_UIS
{
   public class customizedTheme
    {
       public void FormStyle(Form MyForm)
       {
           MyForm.Font = new Font("Times New Roman", 15); 
           MyForm.AutoScaleMode = AutoScaleMode.Font;
           //MyForm.ForeColor = Color.Black;
           MyForm.BackColor = Color.LightSteelBlue;//MediumAquamarine;
           MyForm.RightToLeft = RightToLeft.Yes;
           //MyForm.StartPosition = FormStartPosition.CenterParent;    
           MyForm.FormBorderStyle = FormBorderStyle.Fixed3D;
           MyForm.MaximizeBox = false;
           MyForm.KeyPreview = true;
           System.Globalization.CultureInfo lan = new System.Globalization.CultureInfo("fa-ir");
           InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(lan);   
       }

       public void ControlStyle(System.Windows.Forms.Control myControl)
       {
           //myControl.Font = new Font("Times New Roman", 13); 
           myControl.ForeColor = Color.Black;
           myControl.RightToLeft = RightToLeft.Yes;
           myControl.BackColor = Color.LightSteelBlue; //MediumAquamarine;
       }
       public void gridSerialNumber(DataGridView myDataGridView)
       {
           if (myDataGridView != null)
           {
               for (int i = 0; i <= (myDataGridView.Rows.Count - 2); i++)
               {
                   myDataGridView.Rows[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");
               }
           }
       }
       public  void GriedStyle(DataGridView myDataGridView)
       {
           myDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           myDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           myDataGridView.AutoGenerateColumns = false;

           myDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 0);//64, 64, 0     227,246,219
           myDataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

           myDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(215, 230, 254);
           myDataGridView.RowsDefaultCellStyle.ForeColor = Color.Black;

           myDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.Red;
           myDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.White;

           myDataGridView.BackgroundColor = Color.LightSteelBlue;//MediumAquamarine;
           myDataGridView.BorderStyle = BorderStyle.None;
       }
       public void ReportGriedStyle(DataGridView myDataGridView)
       {
           myDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           myDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           myDataGridView.AutoGenerateColumns = false;

           myDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(227, 246, 219);
           myDataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

           myDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(215, 230, 254);
           myDataGridView.RowsDefaultCellStyle.ForeColor = Color.Black;

           myDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.Red;
           myDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.White;

           myDataGridView.AllowUserToAddRows = false;
           myDataGridView.AllowUserToDeleteRows = false;

           myDataGridView.BackgroundColor = Color.LightSteelBlue;//MediumAquamarine;
           myDataGridView.BorderStyle = BorderStyle.None;
           myDataGridView.ReadOnly = true;
          

       }
       public void InsertGriedStyle(DataGridView myDataGridView)
       {
           myDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           myDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           myDataGridView.AutoGenerateColumns = false;

           myDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(227, 246, 219);
           myDataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

           myDataGridView.RowsDefaultCellStyle.BackColor = System.Drawing.Color.DeepSkyBlue;//Color.FromArgb(215, 230, 254);
           myDataGridView.RowsDefaultCellStyle.ForeColor = Color.White;

           myDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.Gold;
           myDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.White;

          // myDataGridView.BackgroundColor = Color.MediumAquamarine;
           //myDataGridView.BorderStyle = BorderStyle.None;
       }
       //---------------------------------------------------------------------------------------------------------------------------------------------------------
       public void RadGriedStyle(RadGridView myDataGridView)
       {
           //myDataGridView..RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           //myDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           myDataGridView.AutoGenerateColumns = false;

           //myDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(227, 246, 219);
           //myDataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

           //myDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(215, 230, 254);
           //myDataGridView.RowsDefaultCellStyle.ForeColor = Color.Black;

           //myDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.Red;
           //myDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.White;

           //myDataGridView.BackgroundColor = Color.LightSteelBlue;//MediumAquamarine;
           //myDataGridView.BorderStyle = BorderStyle.None;

           RadGridLocalizationProvider.CurrentProvider = new PersianRadGridLocalizationProvider();
           myDataGridView.EnableFiltering = true;
           myDataGridView.MasterTemplate.EnableFiltering = true;
           myDataGridView.MasterTemplate.EnableSorting = true;
           myDataGridView.Font = new Font("Times New Roman", 15); 
       }
       public void RadReportGriedStyle(RadGridView myDataGridView)
       {
           myDataGridView.AutoGenerateColumns = false;  
           myDataGridView.ReadOnly = true;
           RadGridLocalizationProvider.CurrentProvider = new PersianRadGridLocalizationProvider();
           myDataGridView.EnableFiltering = true;
           myDataGridView.MasterTemplate.EnableFiltering = true;
           myDataGridView.MasterTemplate.EnableSorting = true;
           myDataGridView.Font = new Font("Times New Roman", 13); 
           myDataGridView.MasterTemplate.AllowAddNewRow = false;
           myDataGridView.MasterTemplate.AllowDeleteRow = false;
           myDataGridView.MasterTemplate.EnableAlternatingRowColor = true;
           
       }
       //---------------------------------------------------------------------------------------------------------------------------------------------------------
       

       public  void GoToNextSession(Label LBL_SysSessionFullName, Label LBL_Systemsession)
       {
           LBL_SysSessionFullName.Text = " فصل جاری سیستم :" + Amanat_BO.Systemsession.SystemSession_getNextSession(LBL_Systemsession.Text);
           LBL_Systemsession.Text = Amanat_BO.Systemsession.SystemSession_getNextSession(LBL_Systemsession.Text);
       }

       public  void GoToPrevioseSession(Label LBL_SysSessionFullName, Label LBL_Systemsession)
       {
           LBL_SysSessionFullName.Text = " فصل جاری سیستم :" + Amanat_BO.Systemsession.SystemSession_getpreviousSession(LBL_Systemsession.Text);
           LBL_Systemsession.Text = Amanat_BO.Systemsession.SystemSession_getpreviousSession(LBL_Systemsession.Text);
       }
    }
}
