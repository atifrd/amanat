namespace Amanat_UIS.Reports
{
    partial class ReportEbtal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportEbtal));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.stiReportEbtal = new Stimulsoft.Report.StiReport();
            this.radGridView_edit = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // stiReportEbtal
            // 
            this.stiReportEbtal.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReportEbtal.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll",
        "Amanat_BO.Dll"};
            this.stiReportEbtal.ReportAlias = "Report";
            this.stiReportEbtal.ReportGuid = "335ef4bfc38d4347964266ca5cbdc1a9";
            this.stiReportEbtal.ReportName = "Report";
            this.stiReportEbtal.ReportSource = resources.GetString("stiReportEbtal.ReportSource");
            this.stiReportEbtal.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReportEbtal.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReportEbtal.UseProgressInThread = false;
            // 
            // radGridView_edit
            // 
            this.radGridView_edit.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView_edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGridView_edit.Location = new System.Drawing.Point(0, 0);
            // 
            // radGridView_edit
            // 
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "تاریخ دریافت";
            gridViewTextBoxColumn1.Name = "EGiveDate";
            gridViewTextBoxColumn1.Width = 150;
            gridViewTextBoxColumn2.FieldName = "FSum";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "جمع مبلغ کل";
            gridViewTextBoxColumn2.Name = "FSum";
            gridViewTextBoxColumn2.Width = 150;
            gridViewTextBoxColumn3.FieldName = "SerialNumber";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "سریال";
            gridViewTextBoxColumn3.Name = "SerialNumber";
            gridViewTextBoxColumn3.Width = 120;
            gridViewTextBoxColumn4.FieldName = "Person";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "نام";
            gridViewTextBoxColumn4.Name = "Person";
            gridViewTextBoxColumn4.Width = 150;
            gridViewTextBoxColumn5.FieldName = "FullSerialNumber";
            gridViewTextBoxColumn5.HeaderText = "FullSerialNumber";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "FullSerialNumber";
            this.radGridView_edit.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.radGridView_edit.Name = "radGridView_edit";
            // 
            // 
            // 
            this.radGridView_edit.RootElement.AutoToolTip = true;
            this.radGridView_edit.Size = new System.Drawing.Size(589, 311);
            this.radGridView_edit.TabIndex = 59;
            this.radGridView_edit.Text = "radGridView1";
            this.radGridView_edit.ThemeName = "ControlDefault";
            this.radGridView_edit.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView_edit_CellDoubleClick);
            this.radGridView_edit.Click += new System.EventHandler(this.radGridView_edit_Click);
            // 
            // ReportEbtal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 309);
            this.Controls.Add(this.radGridView_edit);
            this.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ReportEbtal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "قبض های ابطال شده";
            this.Load += new System.EventHandler(this.ReportEbtal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportEbtal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView_edit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Stimulsoft.Report.StiReport stiReportEbtal;
        private Telerik.WinControls.UI.RadGridView radGridView_edit;
        public string SerialNumParam_Ebtal;
    }
}