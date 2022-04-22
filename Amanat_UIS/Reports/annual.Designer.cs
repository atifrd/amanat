namespace Amanat_UIS.Reports
{
    partial class annual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(annual));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Print = new WinCSS.SaveButton();
            this.masked_ToDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bTN_List = new WinCSS.SaveButton();
            this.masked_FromDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radGRD_Monthly = new Telerik.WinControls.UI.RadGridView();
            this.stiReportAnnualReport = new Stimulsoft.Report.StiReport();
            this.label_SumMoney = new System.Windows.Forms.Label();
            this.label_Sum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGRD_Monthly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGRD_Monthly.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Print);
            this.groupBox1.Controls.Add(this.masked_ToDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bTN_List);
            this.groupBox1.Controls.Add(this.masked_FromDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(462, 93);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // BTN_Print
            // 
            this.BTN_Print.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Print.BackgroundImage")));
            this.BTN_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Print.FlatAppearance.BorderSize = 0;
            this.BTN_Print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Print.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Print.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Print.Location = new System.Drawing.Point(89, 49);
            this.BTN_Print.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BTN_Print.Name = "BTN_Print";
            this.BTN_Print.Size = new System.Drawing.Size(122, 40);
            this.BTN_Print.TabIndex = 94;
            this.BTN_Print.Text = "چاپ";
            this.BTN_Print.UseVisualStyleBackColor = true;
            this.BTN_Print.Click += new System.EventHandler(this.BTN_Print_Click);
            // 
            // masked_ToDate
            // 
            this.masked_ToDate.Location = new System.Drawing.Point(14, 14);
            this.masked_ToDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.masked_ToDate.Mask = "00 /00 /1000";
            this.masked_ToDate.Name = "masked_ToDate";
            this.masked_ToDate.Size = new System.Drawing.Size(116, 30);
            this.masked_ToDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 63;
            this.label2.Text = "تا تاریخ";
            // 
            // bTN_List
            // 
            this.bTN_List.BackColor = System.Drawing.Color.Transparent;
            this.bTN_List.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bTN_List.BackgroundImage")));
            this.bTN_List.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bTN_List.FlatAppearance.BorderSize = 0;
            this.bTN_List.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bTN_List.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bTN_List.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTN_List.ForeColor = System.Drawing.Color.Transparent;
            this.bTN_List.Location = new System.Drawing.Point(212, 49);
            this.bTN_List.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bTN_List.Name = "bTN_List";
            this.bTN_List.Size = new System.Drawing.Size(122, 40);
            this.bTN_List.TabIndex = 2;
            this.bTN_List.Text = "نمایش";
            this.bTN_List.UseVisualStyleBackColor = true;
            this.bTN_List.Click += new System.EventHandler(this.bTN_List_Click);
            // 
            // masked_FromDate
            // 
            this.masked_FromDate.Location = new System.Drawing.Point(268, 14);
            this.masked_FromDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.masked_FromDate.Mask = "00 /00 /1000";
            this.masked_FromDate.Name = "masked_FromDate";
            this.masked_FromDate.Size = new System.Drawing.Size(116, 30);
            this.masked_FromDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "از تاریخ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_SumMoney);
            this.groupBox2.Controls.Add(this.label_Sum);
            this.groupBox2.Controls.Add(this.radGRD_Monthly);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 93);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(462, 417);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "گزارش خلاصه کارکرد سالانه به تفکیک ماه";
            // 
            // radGRD_Monthly
            // 
            this.radGRD_Monthly.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radGRD_Monthly.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGRD_Monthly.Location = new System.Drawing.Point(6, 57);
            // 
            // radGRD_Monthly
            // 
            gridViewTextBoxColumn10.FieldName = "RowNumber";
            gridViewTextBoxColumn10.FormatString = "";
            gridViewTextBoxColumn10.HeaderText = "ردیف";
            gridViewTextBoxColumn10.Name = "RowNumber";
            gridViewTextBoxColumn10.Width = 100;
            gridViewTextBoxColumn11.FieldName = "Mydate";
            gridViewTextBoxColumn11.FormatString = "";
            gridViewTextBoxColumn11.HeaderText = "تاریخ";
            gridViewTextBoxColumn11.Name = "Mydate";
            gridViewTextBoxColumn11.Width = 150;
            gridViewTextBoxColumn12.FieldName = "realSum";
            gridViewTextBoxColumn12.FormatString = "";
            gridViewTextBoxColumn12.HeaderText = "مبلغ کارکرد";
            gridViewTextBoxColumn12.Name = "realSum";
            gridViewTextBoxColumn12.Width = 180;
            this.radGRD_Monthly.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.radGRD_Monthly.Name = "radGRD_Monthly";
            // 
            // 
            // 
            this.radGRD_Monthly.RootElement.AccessibleDescription = null;
            this.radGRD_Monthly.RootElement.AccessibleName = null;
            this.radGRD_Monthly.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 240, 150);
            this.radGRD_Monthly.Size = new System.Drawing.Size(450, 355);
            this.radGRD_Monthly.TabIndex = 2;
            this.radGRD_Monthly.Text = "radGridView1";
            this.radGRD_Monthly.ThemeName = "ControlDefault";
            // 
            // stiReportAnnualReport
            // 
            this.stiReportAnnualReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReportAnnualReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReportAnnualReport.ReportAlias = "Report";
            this.stiReportAnnualReport.ReportGuid = "c64e1550a60c48498165aa8cd529b14e";
            this.stiReportAnnualReport.ReportName = "Report";
            this.stiReportAnnualReport.ReportSource = resources.GetString("stiReportAnnualReport.ReportSource");
            this.stiReportAnnualReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReportAnnualReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReportAnnualReport.UseProgressInThread = false;
            // 
            // label_SumMoney
            // 
            this.label_SumMoney.AutoSize = true;
            this.label_SumMoney.Location = new System.Drawing.Point(216, 29);
            this.label_SumMoney.Name = "label_SumMoney";
            this.label_SumMoney.Size = new System.Drawing.Size(20, 22);
            this.label_SumMoney.TabIndex = 7;
            this.label_SumMoney.Text = "0";
            // 
            // label_Sum
            // 
            this.label_Sum.AutoSize = true;
            this.label_Sum.Location = new System.Drawing.Point(378, 29);
            this.label_Sum.Name = "label_Sum";
            this.label_Sum.Size = new System.Drawing.Size(72, 22);
            this.label_Sum.TabIndex = 6;
            this.label_Sum.Text = "جمع کل :";
            // 
            // annual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "annual";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گزارش سالانه";
            this.Load += new System.EventHandler(this.annual_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.annual_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGRD_Monthly.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGRD_Monthly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WinCSS.SaveButton BTN_Print;
        private System.Windows.Forms.MaskedTextBox masked_ToDate;
        private System.Windows.Forms.Label label2;
        private WinCSS.SaveButton bTN_List;
        private System.Windows.Forms.MaskedTextBox masked_FromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Stimulsoft.Report.StiReport stiReportAnnualReport;
        private Telerik.WinControls.UI.RadGridView radGRD_Monthly;
        private System.Windows.Forms.Label label_SumMoney;
        private System.Windows.Forms.Label label_Sum;
    }
}