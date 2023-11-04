namespace Amanat_UIS
{
    partial class Baggage_Prices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baggage_Prices));
            this.TXT_baggageCode = new System.Windows.Forms.TextBox();
            this.LBL_baggageCode = new System.Windows.Forms.Label();
            this.TXT_baggageName = new System.Windows.Forms.TextBox();
            this.TXT_Price = new System.Windows.Forms.TextBox();
            this.LBL_baggageName = new System.Windows.Forms.Label();
            this.LBL_Price = new System.Windows.Forms.Label();
            this.LBL_FromDate = new System.Windows.Forms.Label();
            this.BTN_Save = new WinCSS.SaveButton();
            this.GRD_Baggage_Price = new System.Windows.Forms.DataGridView();
            this.baggageCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baggageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaggagePriceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valid = new System.Windows.Forms.DataGridViewImageColumn();
            this.LBL_Rial = new System.Windows.Forms.Label();
            this.maskedFromDate = new System.Windows.Forms.MaskedTextBox();
            this.BTN_Edit = new WinCSS.SaveButton();
            this.btn_cancel = new WinCSS.CancelButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Baggage_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_baggageCode
            // 
            this.TXT_baggageCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TXT_baggageCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TXT_baggageCode.Location = new System.Drawing.Point(373, 13);
            this.TXT_baggageCode.Name = "TXT_baggageCode";
            this.TXT_baggageCode.Size = new System.Drawing.Size(136, 36);
            this.TXT_baggageCode.TabIndex = 0;
            this.TXT_baggageCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_baggageCode.TextChanged += new System.EventHandler(this.TXT_baggageCode_TextChanged);
            this.TXT_baggageCode.Leave += new System.EventHandler(this.TXT_baggageCode_Leave);
            // 
            // LBL_baggageCode
            // 
            this.LBL_baggageCode.AutoSize = true;
            this.LBL_baggageCode.Location = new System.Drawing.Point(515, 18);
            this.LBL_baggageCode.Name = "LBL_baggageCode";
            this.LBL_baggageCode.Size = new System.Drawing.Size(79, 29);
            this.LBL_baggageCode.TabIndex = 31;
            this.LBL_baggageCode.Text = "کد کالا :";
            // 
            // TXT_baggageName
            // 
            this.TXT_baggageName.Location = new System.Drawing.Point(37, 11);
            this.TXT_baggageName.Name = "TXT_baggageName";
            this.TXT_baggageName.Size = new System.Drawing.Size(189, 36);
            this.TXT_baggageName.TabIndex = 1;
            this.TXT_baggageName.Validating += new System.ComponentModel.CancelEventHandler(this.TXT_baggageName_Validating);
            // 
            // TXT_Price
            // 
            this.TXT_Price.Location = new System.Drawing.Point(329, 55);
            this.TXT_Price.Name = "TXT_Price";
            this.TXT_Price.Size = new System.Drawing.Size(180, 36);
            this.TXT_Price.TabIndex = 2;
            this.TXT_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_Price.TextChanged += new System.EventHandler(this.TXT_Price_TextChanged);
            // 
            // LBL_baggageName
            // 
            this.LBL_baggageName.AutoSize = true;
            this.LBL_baggageName.Location = new System.Drawing.Point(232, 14);
            this.LBL_baggageName.Name = "LBL_baggageName";
            this.LBL_baggageName.Size = new System.Drawing.Size(81, 29);
            this.LBL_baggageName.TabIndex = 28;
            this.LBL_baggageName.Text = "نام کالا :";
            // 
            // LBL_Price
            // 
            this.LBL_Price.AutoSize = true;
            this.LBL_Price.Location = new System.Drawing.Point(515, 62);
            this.LBL_Price.Name = "LBL_Price";
            this.LBL_Price.Size = new System.Drawing.Size(66, 29);
            this.LBL_Price.TabIndex = 27;
            this.LBL_Price.Text = "قیمت :";
            // 
            // LBL_FromDate
            // 
            this.LBL_FromDate.AutoSize = true;
            this.LBL_FromDate.Location = new System.Drawing.Point(515, 100);
            this.LBL_FromDate.Name = "LBL_FromDate";
            this.LBL_FromDate.Size = new System.Drawing.Size(145, 29);
            this.LBL_FromDate.TabIndex = 33;
            this.LBL_FromDate.Text = "اعتبار از تاریخ :";
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Save.BackgroundImage")));
            this.BTN_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Save.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Save.Location = new System.Drawing.Point(181, 181);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Save.Size = new System.Drawing.Size(76, 32);
            this.BTN_Save.TabIndex = 5;
            this.BTN_Save.Text = "ثبت";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // GRD_Baggage_Price
            // 
            this.GRD_Baggage_Price.CausesValidation = false;
            this.GRD_Baggage_Price.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_Baggage_Price.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.baggageCode,
            this.baggageName,
            this.Price,
            this.FromDate,
            this.BaggagePriceID,
            this.Valid});
            this.GRD_Baggage_Price.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GRD_Baggage_Price.Location = new System.Drawing.Point(0, 236);
            this.GRD_Baggage_Price.Name = "GRD_Baggage_Price";
            this.GRD_Baggage_Price.RowHeadersWidth = 51;
            this.GRD_Baggage_Price.Size = new System.Drawing.Size(688, 209);
            this.GRD_Baggage_Price.TabIndex = 8;
            this.GRD_Baggage_Price.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRD_Baggage_Price_CellDoubleClick);
            this.GRD_Baggage_Price.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GRD_Baggage_Price_DataBindingComplete);
            // 
            // baggageCode
            // 
            this.baggageCode.DataPropertyName = "baggageCode";
            this.baggageCode.HeaderText = "کد";
            this.baggageCode.MinimumWidth = 6;
            this.baggageCode.Name = "baggageCode";
            this.baggageCode.Width = 125;
            // 
            // baggageName
            // 
            this.baggageName.DataPropertyName = "baggageName";
            this.baggageName.HeaderText = "نام";
            this.baggageName.MinimumWidth = 6;
            this.baggageName.Name = "baggageName";
            this.baggageName.Width = 150;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "قیمت";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // FromDate
            // 
            this.FromDate.HeaderText = "اعتبار از تاریخ";
            this.FromDate.MinimumWidth = 6;
            this.FromDate.Name = "FromDate";
            this.FromDate.Width = 150;
            // 
            // BaggagePriceID
            // 
            this.BaggagePriceID.DataPropertyName = "BaggagePriceID";
            this.BaggagePriceID.HeaderText = "Column1";
            this.BaggagePriceID.MinimumWidth = 6;
            this.BaggagePriceID.Name = "BaggagePriceID";
            this.BaggagePriceID.Visible = false;
            this.BaggagePriceID.Width = 125;
            // 
            // Valid
            // 
            this.Valid.HeaderText = "";
            this.Valid.MinimumWidth = 6;
            this.Valid.Name = "Valid";
            this.Valid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Valid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Valid.Width = 48;
            // 
            // LBL_Rial
            // 
            this.LBL_Rial.AutoSize = true;
            this.LBL_Rial.Location = new System.Drawing.Point(279, 58);
            this.LBL_Rial.Name = "LBL_Rial";
            this.LBL_Rial.Size = new System.Drawing.Size(44, 29);
            this.LBL_Rial.TabIndex = 36;
            this.LBL_Rial.Text = "ریال";
            // 
            // maskedFromDate
            // 
            this.maskedFromDate.Location = new System.Drawing.Point(329, 97);
            this.maskedFromDate.Mask = "00 /00 /1000";
            this.maskedFromDate.Name = "maskedFromDate";
            this.maskedFromDate.Size = new System.Drawing.Size(180, 36);
            this.maskedFromDate.TabIndex = 3;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Edit.BackgroundImage")));
            this.BTN_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Edit.Enabled = false;
            this.BTN_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Edit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Edit.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Edit.Location = new System.Drawing.Point(94, 181);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(81, 32);
            this.BTN_Edit.TabIndex = 35;
            this.BTN_Edit.Text = "ویرایش";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.CausesValidation = false;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Location = new System.Drawing.Point(12, 181);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(76, 32);
            this.btn_cancel.TabIndex = 34;
            this.btn_cancel.Text = "انصراف";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Baggage_Prices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 445);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.LBL_Rial);
            this.Controls.Add(this.LBL_FromDate);
            this.Controls.Add(this.GRD_Baggage_Price);
            this.Controls.Add(this.TXT_baggageCode);
            this.Controls.Add(this.maskedFromDate);
            this.Controls.Add(this.LBL_baggageCode);
            this.Controls.Add(this.TXT_baggageName);
            this.Controls.Add(this.TXT_Price);
            this.Controls.Add(this.LBL_baggageName);
            this.Controls.Add(this.LBL_Price);
            this.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Name = "Baggage_Prices";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "لیست کدینگ نوع محموله";
            this.Load += new System.EventHandler(this.Baggage_Prices_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Baggage_Prices_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Baggage_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_baggageCode;
        private System.Windows.Forms.Label LBL_baggageCode;
        private System.Windows.Forms.TextBox TXT_baggageName;
        private System.Windows.Forms.TextBox TXT_Price;
        private System.Windows.Forms.Label LBL_baggageName;
        private System.Windows.Forms.Label LBL_Price;
        private System.Windows.Forms.Label LBL_FromDate;
        private WinCSS.SaveButton BTN_Save;
        private System.Windows.Forms.DataGridView GRD_Baggage_Price;
        private System.Windows.Forms.Label LBL_Rial;
        private System.Windows.Forms.MaskedTextBox maskedFromDate;
        private WinCSS.CancelButton btn_cancel;
        private WinCSS.SaveButton BTN_Edit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn baggageCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn baggageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaggagePriceID;
        private System.Windows.Forms.DataGridViewImageColumn Valid;
    }
}