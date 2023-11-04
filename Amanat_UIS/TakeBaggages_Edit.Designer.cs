namespace Amanat_UIS
{
    partial class TakeBaggages_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeBaggages_Edit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedexp_GiveBackTime = new System.Windows.Forms.MaskedTextBox();
            this.maskedGiveTime = new System.Windows.Forms.MaskedTextBox();
            this.maskedexp_GiveBackDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedGiveDate = new System.Windows.Forms.MaskedTextBox();
            this.LBL_PersonId = new System.Windows.Forms.Label();
            this.TXT_Person = new System.Windows.Forms.TextBox();
            this.LBL_SerialNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBL_Person = new System.Windows.Forms.Label();
            this.LBL_Give = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_EXPTake = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BTN_Ebtal = new WinCSS.CancelButton();
            this.BTN_Save = new WinCSS.SaveButton();
            this.TXT_LockerNumber = new System.Windows.Forms.TextBox();
            this.GRD_GiveAndTakeDetails = new System.Windows.Forms.DataGridView();
            this.baggageCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baggageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaggageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MySum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaggagePriceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBL_SUM = new System.Windows.Forms.Label();
            this.LBL_LockerNumber = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_GiveAndTakeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedexp_GiveBackTime);
            this.groupBox1.Controls.Add(this.maskedGiveTime);
            this.groupBox1.Controls.Add(this.maskedexp_GiveBackDate);
            this.groupBox1.Controls.Add(this.maskedGiveDate);
            this.groupBox1.Controls.Add(this.LBL_PersonId);
            this.groupBox1.Controls.Add(this.TXT_Person);
            this.groupBox1.Controls.Add(this.LBL_SerialNumber);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LBL_Person);
            this.groupBox1.Controls.Add(this.LBL_Give);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LBL_EXPTake);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(564, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "شرح اطلاعات";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maskedexp_GiveBackTime
            // 
            this.maskedexp_GiveBackTime.Location = new System.Drawing.Point(149, 74);
            this.maskedexp_GiveBackTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedexp_GiveBackTime.Mask = "00:00";
            this.maskedexp_GiveBackTime.Name = "maskedexp_GiveBackTime";
            this.maskedexp_GiveBackTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedexp_GiveBackTime.Size = new System.Drawing.Size(79, 22);
            this.maskedexp_GiveBackTime.TabIndex = 61;
            this.maskedexp_GiveBackTime.ValidatingType = typeof(System.DateTime);
            // 
            // maskedGiveTime
            // 
            this.maskedGiveTime.Location = new System.Drawing.Point(388, 74);
            this.maskedGiveTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedGiveTime.Mask = "00:00";
            this.maskedGiveTime.Name = "maskedGiveTime";
            this.maskedGiveTime.ReadOnly = true;
            this.maskedGiveTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedGiveTime.Size = new System.Drawing.Size(79, 22);
            this.maskedGiveTime.TabIndex = 59;
            // 
            // maskedexp_GiveBackDate
            // 
            this.maskedexp_GiveBackDate.Location = new System.Drawing.Point(109, 44);
            this.maskedexp_GiveBackDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedexp_GiveBackDate.Mask = "00 /00 /1000";
            this.maskedexp_GiveBackDate.Name = "maskedexp_GiveBackDate";
            this.maskedexp_GiveBackDate.Size = new System.Drawing.Size(120, 22);
            this.maskedexp_GiveBackDate.TabIndex = 60;
            // 
            // maskedGiveDate
            // 
            this.maskedGiveDate.Location = new System.Drawing.Point(348, 46);
            this.maskedGiveDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedGiveDate.Mask = "00 /00 /1000";
            this.maskedGiveDate.Name = "maskedGiveDate";
            this.maskedGiveDate.ReadOnly = true;
            this.maskedGiveDate.Size = new System.Drawing.Size(120, 22);
            this.maskedGiveDate.TabIndex = 58;
            // 
            // LBL_PersonId
            // 
            this.LBL_PersonId.AutoSize = true;
            this.LBL_PersonId.Location = new System.Drawing.Point(11, 17);
            this.LBL_PersonId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_PersonId.Name = "LBL_PersonId";
            this.LBL_PersonId.Size = new System.Drawing.Size(14, 16);
            this.LBL_PersonId.TabIndex = 71;
            this.LBL_PersonId.Text = "0";
            this.LBL_PersonId.Visible = false;
            // 
            // TXT_Person
            // 
            this.TXT_Person.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TXT_Person.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TXT_Person.Location = new System.Drawing.Point(36, 14);
            this.TXT_Person.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TXT_Person.Name = "TXT_Person";
            this.TXT_Person.Size = new System.Drawing.Size(253, 22);
            this.TXT_Person.TabIndex = 57;
            // 
            // LBL_SerialNumber
            // 
            this.LBL_SerialNumber.AutoSize = true;
            this.LBL_SerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SerialNumber.Location = new System.Drawing.Point(468, 15);
            this.LBL_SerialNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_SerialNumber.Name = "LBL_SerialNumber";
            this.LBL_SerialNumber.Size = new System.Drawing.Size(24, 25);
            this.LBL_SerialNumber.TabIndex = 70;
            this.LBL_SerialNumber.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 69;
            this.label8.Text = "تاریخ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "ساعت";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 67;
            this.label6.Text = "سریال";
            // 
            // LBL_Person
            // 
            this.LBL_Person.AutoSize = true;
            this.LBL_Person.Location = new System.Drawing.Point(297, 17);
            this.LBL_Person.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Person.Name = "LBL_Person";
            this.LBL_Person.Size = new System.Drawing.Size(21, 16);
            this.LBL_Person.TabIndex = 66;
            this.LBL_Person.Text = "نام";
            // 
            // LBL_Give
            // 
            this.LBL_Give.AutoSize = true;
            this.LBL_Give.Location = new System.Drawing.Point(507, 58);
            this.LBL_Give.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Give.Name = "LBL_Give";
            this.LBL_Give.Size = new System.Drawing.Size(42, 16);
            this.LBL_Give.TabIndex = 65;
            this.LBL_Give.Text = "دریافت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "تاریخ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "ساعت";
            // 
            // LBL_EXPTake
            // 
            this.LBL_EXPTake.AutoSize = true;
            this.LBL_EXPTake.Location = new System.Drawing.Point(272, 58);
            this.LBL_EXPTake.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_EXPTake.Name = "LBL_EXPTake";
            this.LBL_EXPTake.Size = new System.Drawing.Size(36, 16);
            this.LBL_EXPTake.TabIndex = 62;
            this.LBL_EXPTake.Tag = "";
            this.LBL_EXPTake.Text = "تحویل";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.BTN_Ebtal);
            this.groupBox2.Controls.Add(this.BTN_Save);
            this.groupBox2.Controls.Add(this.TXT_LockerNumber);
            this.groupBox2.Controls.Add(this.GRD_GiveAndTakeDetails);
            this.groupBox2.Controls.Add(this.LBL_SUM);
            this.groupBox2.Controls.Add(this.LBL_LockerNumber);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(564, 196);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "شرح کالاها";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 122);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 60;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTN_Ebtal
            // 
            this.BTN_Ebtal.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Ebtal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Ebtal.BackgroundImage")));
            this.BTN_Ebtal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Ebtal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Ebtal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ebtal.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Ebtal.Location = new System.Drawing.Point(211, 146);
            this.BTN_Ebtal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BTN_Ebtal.Name = "BTN_Ebtal";
            this.BTN_Ebtal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Ebtal.Size = new System.Drawing.Size(107, 42);
            this.BTN_Ebtal.TabIndex = 57;
            this.BTN_Ebtal.Text = "ابطال قبض";
            this.BTN_Ebtal.UseVisualStyleBackColor = true;
            this.BTN_Ebtal.Click += new System.EventHandler(this.BTN_Ebtal_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Save.BackgroundImage")));
            this.BTN_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Save.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Save.Location = new System.Drawing.Point(340, 150);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Save.Size = new System.Drawing.Size(107, 42);
            this.BTN_Save.TabIndex = 56;
            this.BTN_Save.Text = "ویرایش";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Visible = false;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // TXT_LockerNumber
            // 
            this.TXT_LockerNumber.Location = new System.Drawing.Point(384, 121);
            this.TXT_LockerNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TXT_LockerNumber.Name = "TXT_LockerNumber";
            this.TXT_LockerNumber.ReadOnly = true;
            this.TXT_LockerNumber.Size = new System.Drawing.Size(87, 22);
            this.TXT_LockerNumber.TabIndex = 53;
            this.TXT_LockerNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GRD_GiveAndTakeDetails
            // 
            this.GRD_GiveAndTakeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_GiveAndTakeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.baggageCode,
            this.baggageName,
            this.BaggageCount,
            this.Price,
            this.MySum,
            this.BaggagePriceID});
            this.GRD_GiveAndTakeDetails.Location = new System.Drawing.Point(16, 15);
            this.GRD_GiveAndTakeDetails.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GRD_GiveAndTakeDetails.Name = "GRD_GiveAndTakeDetails";
            this.GRD_GiveAndTakeDetails.RowHeadersWidth = 51;
            this.GRD_GiveAndTakeDetails.Size = new System.Drawing.Size(541, 105);
            this.GRD_GiveAndTakeDetails.TabIndex = 52;
            this.GRD_GiveAndTakeDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRD_GiveAndTakeDetails_CellValueChanged);
            // 
            // baggageCode
            // 
            this.baggageCode.DataPropertyName = "baggageCode";
            this.baggageCode.HeaderText = "کد";
            this.baggageCode.MinimumWidth = 6;
            this.baggageCode.Name = "baggageCode";
            this.baggageCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.baggageCode.Width = 150;
            // 
            // baggageName
            // 
            this.baggageName.DataPropertyName = "baggageName";
            this.baggageName.HeaderText = "شرح";
            this.baggageName.MinimumWidth = 6;
            this.baggageName.Name = "baggageName";
            this.baggageName.ReadOnly = true;
            this.baggageName.Width = 150;
            // 
            // BaggageCount
            // 
            this.BaggageCount.DataPropertyName = "BaggageCount";
            this.BaggageCount.HeaderText = "تعداد";
            this.BaggageCount.MinimumWidth = 6;
            this.BaggageCount.Name = "BaggageCount";
            this.BaggageCount.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "مبلغ";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
            // 
            // MySum
            // 
            this.MySum.DataPropertyName = "MySum";
            this.MySum.HeaderText = "مبلغ کل";
            this.MySum.MinimumWidth = 6;
            this.MySum.Name = "MySum";
            this.MySum.ReadOnly = true;
            this.MySum.Width = 150;
            // 
            // BaggagePriceID
            // 
            this.BaggagePriceID.DataPropertyName = "BaggagePriceID";
            this.BaggagePriceID.HeaderText = "baggageId";
            this.BaggagePriceID.MinimumWidth = 6;
            this.BaggagePriceID.Name = "BaggagePriceID";
            this.BaggagePriceID.Visible = false;
            this.BaggagePriceID.Width = 125;
            // 
            // LBL_SUM
            // 
            this.LBL_SUM.AutoSize = true;
            this.LBL_SUM.Location = new System.Drawing.Point(184, 124);
            this.LBL_SUM.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_SUM.Name = "LBL_SUM";
            this.LBL_SUM.Size = new System.Drawing.Size(50, 16);
            this.LBL_SUM.TabIndex = 55;
            this.LBL_SUM.Text = "جمع کل ";
            // 
            // LBL_LockerNumber
            // 
            this.LBL_LockerNumber.AutoSize = true;
            this.LBL_LockerNumber.Location = new System.Drawing.Point(475, 127);
            this.LBL_LockerNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_LockerNumber.Name = "LBL_LockerNumber";
            this.LBL_LockerNumber.Size = new System.Drawing.Size(67, 16);
            this.LBL_LockerNumber.TabIndex = 54;
            this.LBL_LockerNumber.Text = "شماره قفسه";
            // 
            // TakeBaggages_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 302);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TakeBaggages_Edit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ابطال قبض";
            this.Load += new System.EventHandler(this.TakeBaggages_Edit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TakeBaggages_Edit_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_GiveAndTakeDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedexp_GiveBackTime;
        private System.Windows.Forms.MaskedTextBox maskedGiveTime;
        private System.Windows.Forms.MaskedTextBox maskedexp_GiveBackDate;
        private System.Windows.Forms.MaskedTextBox maskedGiveDate;
        private System.Windows.Forms.Label LBL_PersonId;
        private System.Windows.Forms.TextBox TXT_Person;
        private System.Windows.Forms.Label LBL_SerialNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBL_Person;
        private System.Windows.Forms.Label LBL_Give;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_EXPTake;
        private System.Windows.Forms.TextBox TXT_LockerNumber;
        private System.Windows.Forms.DataGridView GRD_GiveAndTakeDetails;
        private System.Windows.Forms.Label LBL_SUM;
        private System.Windows.Forms.Label LBL_LockerNumber;
        private WinCSS.CancelButton BTN_Ebtal;
        private WinCSS.SaveButton BTN_Save;
        public TakeBaggages TakeBaggagesInstance;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn baggageCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn baggageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaggageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn MySum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaggagePriceID;
    }
}