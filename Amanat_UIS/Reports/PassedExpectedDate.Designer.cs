namespace Amanat_UIS
{
    partial class PassedExpectedDate
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
            this.GRD_TaKen = new System.Windows.Forms.DataGridView();
            this.EGiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EbaggageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MySum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EBaggageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eexp_GiveBackDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkPersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiveAndTakeDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_TaKen)).BeginInit();
            this.SuspendLayout();
            // 
            // GRD_TaKen
            // 
            this.GRD_TaKen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_TaKen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EGiveDate,
            this.EbaggageName,
            this.MySum,
            this.ESerialNumber,
            this.SerialNumber,
            this.EBaggageCount,
            this.Eexp_GiveBackDate,
            this.FkPersonId,
            this.EId,
            this.GiveAndTakeDetailsId});
            this.GRD_TaKen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRD_TaKen.Location = new System.Drawing.Point(0, 0);
            this.GRD_TaKen.Margin = new System.Windows.Forms.Padding(4);
            this.GRD_TaKen.Name = "GRD_TaKen";
            this.GRD_TaKen.Size = new System.Drawing.Size(743, 515);
            this.GRD_TaKen.TabIndex = 54;
            // 
            // EGiveDate
            // 
            this.EGiveDate.DataPropertyName = "GiveDate";
            this.EGiveDate.HeaderText = "تاریخ دریافت";
            this.EGiveDate.Name = "EGiveDate";
            // 
            // EbaggageName
            // 
            this.EbaggageName.DataPropertyName = "baggageName";
            this.EbaggageName.HeaderText = "شرح امانت";
            this.EbaggageName.Name = "EbaggageName";
            // 
            // MySum
            // 
            this.MySum.DataPropertyName = "MySum";
            this.MySum.HeaderText = "جمع مبلغ کل";
            this.MySum.Name = "MySum";
            // 
            // ESerialNumber
            // 
            this.ESerialNumber.DataPropertyName = "PersonName";
            this.ESerialNumber.HeaderText = "نام";
            this.ESerialNumber.Name = "ESerialNumber";
            // 
            // SerialNumber
            // 
            this.SerialNumber.DataPropertyName = "SerialNumber";
            this.SerialNumber.HeaderText = "سریال";
            this.SerialNumber.Name = "SerialNumber";
            // 
            // EBaggageCount
            // 
            this.EBaggageCount.DataPropertyName = "BaggageCount";
            this.EBaggageCount.HeaderText = "تعداد";
            this.EBaggageCount.Name = "EBaggageCount";
            // 
            // Eexp_GiveBackDate
            // 
            this.Eexp_GiveBackDate.DataPropertyName = "exp_GiveBackDate";
            this.Eexp_GiveBackDate.HeaderText = "تاریخ تحویل مقرر";
            this.Eexp_GiveBackDate.Name = "Eexp_GiveBackDate";
            // 
            // FkPersonId
            // 
            this.FkPersonId.DataPropertyName = "FkPersonId";
            this.FkPersonId.HeaderText = "FkPersonId";
            this.FkPersonId.Name = "FkPersonId";
            this.FkPersonId.Visible = false;
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
            // PassedExpectedDate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 515);
            this.Controls.Add(this.GRD_TaKen);
            this.Name = "PassedExpectedDate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "لیست اقلام تاریخ تحویل گذشته";
            this.Load += new System.EventHandler(this.PassedExpectedDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRD_TaKen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GRD_TaKen;
        private System.Windows.Forms.DataGridViewTextBoxColumn EGiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EbaggageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MySum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EBaggageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eexp_GiveBackDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkPersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiveAndTakeDetailsId;
    }
}