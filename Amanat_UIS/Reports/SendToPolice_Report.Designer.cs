namespace Amanat_UIS.Reports
{
    partial class SendToPolice_Report
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendToPolice_Report));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Print = new WinCSS.SaveButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BTN_LIST = new WinCSS.SaveButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_FromDate = new System.Windows.Forms.Label();
            this.maskedToDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedNowDate = new System.Windows.Forms.MaskedTextBox();
            this.TXT_DayCnt = new System.Windows.Forms.TextBox();
            this.GRD_List = new System.Windows.Forms.DataGridView();
            this.EGiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eexp_GiveBackDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EbaggageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EBaggageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiveAndTakeDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.FkPersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stiReportSend = new Stimulsoft.Report.StiReport();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Print);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.BTN_LIST);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LBL_FromDate);
            this.groupBox1.Controls.Add(this.maskedToDate);
            this.groupBox1.Controls.Add(this.maskedNowDate);
            this.groupBox1.Controls.Add(this.TXT_DayCnt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(893, 173);
            this.groupBox1.TabIndex = 38;
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
            this.BTN_Print.Location = new System.Drawing.Point(7, 119);
            this.BTN_Print.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BTN_Print.Name = "BTN_Print";
            this.BTN_Print.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Print.Size = new System.Drawing.Size(100, 50);
            this.BTN_Print.TabIndex = 57;
            this.BTN_Print.Text = "چاپ رسید ";
            this.BTN_Print.UseVisualStyleBackColor = true;
            this.BTN_Print.Click += new System.EventHandler(this.BTN_Print_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 83);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 17);
            this.checkBox1.TabIndex = 42;
            this.checkBox1.Text = "منتقل شده به پاسگاه";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BTN_LIST
            // 
            this.BTN_LIST.BackColor = System.Drawing.Color.Transparent;
            this.BTN_LIST.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_LIST.BackgroundImage")));
            this.BTN_LIST.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_LIST.FlatAppearance.BorderSize = 0;
            this.BTN_LIST.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_LIST.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_LIST.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LIST.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_LIST.Location = new System.Drawing.Point(110, 119);
            this.BTN_LIST.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BTN_LIST.Name = "BTN_LIST";
            this.BTN_LIST.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_LIST.Size = new System.Drawing.Size(100, 50);
            this.BTN_LIST.TabIndex = 1;
            this.BTN_LIST.Text = "نمایش لیست";
            this.BTN_LIST.UseVisualStyleBackColor = true;
            this.BTN_LIST.Click += new System.EventHandler(this.BTN_LIST_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "تحویل می شدند";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "روز از تاریخ تحویل آنها گذشته یعنی باید تا تاریخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(757, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "گزارش اقلامی که ";
            // 
            // LBL_FromDate
            // 
            this.LBL_FromDate.AutoSize = true;
            this.LBL_FromDate.Location = new System.Drawing.Point(807, 17);
            this.LBL_FromDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LBL_FromDate.Name = "LBL_FromDate";
            this.LBL_FromDate.Size = new System.Drawing.Size(80, 22);
            this.LBL_FromDate.TabIndex = 34;
            this.LBL_FromDate.Text = "تاریخ روز";
            // 
            // maskedToDate
            // 
            this.maskedToDate.Location = new System.Drawing.Point(236, 57);
            this.maskedToDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.maskedToDate.Name = "maskedToDate";
            this.maskedToDate.ReadOnly = true;
            this.maskedToDate.Size = new System.Drawing.Size(116, 30);
            this.maskedToDate.TabIndex = 36;
            // 
            // maskedNowDate
            // 
            this.maskedNowDate.Location = new System.Drawing.Point(679, 14);
            this.maskedNowDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.maskedNowDate.Name = "maskedNowDate";
            this.maskedNowDate.Size = new System.Drawing.Size(116, 30);
            this.maskedNowDate.TabIndex = 4;
            // 
            // TXT_DayCnt
            // 
            this.TXT_DayCnt.Location = new System.Drawing.Point(688, 52);
            this.TXT_DayCnt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TXT_DayCnt.Name = "TXT_DayCnt";
            this.TXT_DayCnt.Size = new System.Drawing.Size(68, 30);
            this.TXT_DayCnt.TabIndex = 0;
            this.TXT_DayCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_DayCnt.Leave += new System.EventHandler(this.TXT_DayCnt_Leave);
            this.TXT_DayCnt.Validating += new System.ComponentModel.CancelEventHandler(this.TXT_DayCnt_Validating);
            // 
            // GRD_List
            // 
            this.GRD_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EGiveDate,
            this.Eexp_GiveBackDate,
            this.SerialNumber,
            this.ESerialNumber,
            this.EbaggageName,
            this.EBaggageCount,
            this.EId,
            this.GiveAndTakeDetailsId,
            this.Status,
            this.FkPersonId});
            this.GRD_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRD_List.Location = new System.Drawing.Point(0, 173);
            this.GRD_List.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.GRD_List.Name = "GRD_List";
            this.GRD_List.Size = new System.Drawing.Size(893, 345);
            this.GRD_List.TabIndex = 56;
            // 
            // EGiveDate
            // 
            this.EGiveDate.HeaderText = "تاریخ دریافت";
            this.EGiveDate.Name = "EGiveDate";
            this.EGiveDate.Width = 150;
            // 
            // Eexp_GiveBackDate
            // 
            this.Eexp_GiveBackDate.HeaderText = "تاریخ تحویل مقرر";
            this.Eexp_GiveBackDate.Name = "Eexp_GiveBackDate";
            this.Eexp_GiveBackDate.Width = 200;
            // 
            // SerialNumber
            // 
            this.SerialNumber.DataPropertyName = "SerialNumber";
            this.SerialNumber.HeaderText = "سریال";
            this.SerialNumber.Name = "SerialNumber";
            // 
            // ESerialNumber
            // 
            this.ESerialNumber.DataPropertyName = "Person";
            this.ESerialNumber.HeaderText = "نام";
            this.ESerialNumber.Name = "ESerialNumber";
            this.ESerialNumber.Width = 150;
            // 
            // EbaggageName
            // 
            this.EbaggageName.DataPropertyName = "baggageName";
            this.EbaggageName.HeaderText = "شرح امانت";
            this.EbaggageName.Name = "EbaggageName";
            this.EbaggageName.Width = 150;
            // 
            // EBaggageCount
            // 
            this.EBaggageCount.DataPropertyName = "BaggageCount";
            this.EBaggageCount.HeaderText = "تعداد";
            this.EBaggageCount.Name = "EBaggageCount";
            this.EBaggageCount.Width = 50;
            // 
            // EId
            // 
            this.EId.DataPropertyName = "Id";
            this.EId.HeaderText = "Id";
            this.EId.Name = "EId";
            this.EId.Visible = false;
            // 
            // GiveAndTakeDetailsId
            // 
            this.GiveAndTakeDetailsId.DataPropertyName = "GiveAndTakeDetailsId";
            this.GiveAndTakeDetailsId.HeaderText = "GiveAndTakeDetailsId";
            this.GiveAndTakeDetailsId.Name = "GiveAndTakeDetailsId";
            this.GiveAndTakeDetailsId.Visible = false;
            // 
            // Status
            // 
            this.Status.FillWeight = 10F;
            this.Status.HeaderText = "";
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.Width = 50;
            // 
            // FkPersonId
            // 
            this.FkPersonId.DataPropertyName = "FkPersonId";
            this.FkPersonId.HeaderText = "FkPersonId";
            this.FkPersonId.Name = "FkPersonId";
            this.FkPersonId.Visible = false;
            this.FkPersonId.Width = 10;
            // 
            // stiReportSend
            // 
            this.stiReportSend.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReportSend.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll",
        "Amanat_BO.Dll"};
            this.stiReportSend.ReportAlias = "Report";
            this.stiReportSend.ReportGuid = "2c27f9fa60704a0a8be74d3a7cb3886d";
            this.stiReportSend.ReportName = "Report";
            this.stiReportSend.ReportSource = resources.GetString("stiReportSend.ReportSource");
            this.stiReportSend.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReportSend.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReportSend.UseProgressInThread = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SendToPolice_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 518);
            this.Controls.Add(this.GRD_List);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SendToPolice_Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "کالاهای تحویل گشته";
            this.Load += new System.EventHandler(this.SendToPolice_Report_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendToPolice_Report_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WinCSS.SaveButton BTN_LIST;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_FromDate;
        private System.Windows.Forms.MaskedTextBox maskedToDate;
        private System.Windows.Forms.MaskedTextBox maskedNowDate;
        private System.Windows.Forms.TextBox TXT_DayCnt;
        public System.Windows.Forms.DataGridView GRD_List;
        private Stimulsoft.Report.StiReport stiReportSend;
        private WinCSS.SaveButton BTN_Print;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EGiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eexp_GiveBackDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EbaggageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EBaggageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn EId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiveAndTakeDetailsId;
        private System.Windows.Forms.DataGridViewImageColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkPersonId;
    }
}