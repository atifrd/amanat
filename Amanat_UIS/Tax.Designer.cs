namespace Amanat_UIS
{
    partial class Tax
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_TaxId = new System.Windows.Forms.Label();
            this.BTN_Edit = new WinCSS.SaveButton();
            this.BTN_Save = new WinCSS.SaveButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Tax = new System.Windows.Forms.TextBox();
            this.masked_ToDate = new System.Windows.Forms.MaskedTextBox();
            this.masked_FromDate = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewtax = new System.Windows.Forms.DataGridView();
            this.FromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxBurden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TaxId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtax)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBL_TaxId);
            this.groupBox1.Controls.Add(this.BTN_Edit);
            this.groupBox1.Controls.Add(this.BTN_Save);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXT_Tax);
            this.groupBox1.Controls.Add(this.masked_ToDate);
            this.groupBox1.Controls.Add(this.masked_FromDate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(453, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LBL_TaxId
            // 
            this.LBL_TaxId.AutoSize = true;
            this.LBL_TaxId.Location = new System.Drawing.Point(306, 52);
            this.LBL_TaxId.Name = "LBL_TaxId";
            this.LBL_TaxId.Size = new System.Drawing.Size(19, 21);
            this.LBL_TaxId.TabIndex = 69;
            this.LBL_TaxId.Text = "0";
            this.LBL_TaxId.Visible = false;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Enabled = false;
            this.BTN_Edit.Location = new System.Drawing.Point(57, 46);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Edit.Size = new System.Drawing.Size(82, 32);
            this.BTN_Edit.TabIndex = 68;
            this.BTN_Edit.Text = "ویرایش";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(150, 47);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Save.Size = new System.Drawing.Size(82, 32);
            this.BTN_Save.TabIndex = 3;
            this.BTN_Save.Text = "ثبت";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(26, 21);
            this.label4.TabIndex = 67;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 66;
            this.label3.Text = "تاتاریخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "مالیات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 64;
            this.label1.Text = "از تاریخ";
            // 
            // TXT_Tax
            // 
            this.TXT_Tax.Location = new System.Drawing.Point(329, 48);
            this.TXT_Tax.Name = "TXT_Tax";
            this.TXT_Tax.Size = new System.Drawing.Size(43, 29);
            this.TXT_Tax.TabIndex = 2;
            this.TXT_Tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_Tax.Validating += new System.ComponentModel.CancelEventHandler(this.TXT_AccountCode_Validating);
            // 
            // masked_ToDate
            // 
            this.masked_ToDate.Location = new System.Drawing.Point(68, 13);
            this.masked_ToDate.Mask = "00 /00 /1000";
            this.masked_ToDate.Name = "masked_ToDate";
            this.masked_ToDate.Size = new System.Drawing.Size(110, 29);
            this.masked_ToDate.TabIndex = 1;
            // 
            // masked_FromDate
            // 
            this.masked_FromDate.Location = new System.Drawing.Point(262, 14);
            this.masked_FromDate.Name = "masked_FromDate";
            this.masked_FromDate.Size = new System.Drawing.Size(110, 29);
            this.masked_FromDate.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridViewtax
            // 
            this.dataGridViewtax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FromDate,
            this.ToDate,
            this.TaxBurden,
            this.BTN_Delete,
            this.TaxId});
            this.dataGridViewtax.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewtax.Location = new System.Drawing.Point(0, 88);
            this.dataGridViewtax.Name = "dataGridViewtax";
            this.dataGridViewtax.Size = new System.Drawing.Size(453, 135);
            this.dataGridViewtax.TabIndex = 68;
            this.dataGridViewtax.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtax_CellContentClick);
            this.dataGridViewtax.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtax_CellDoubleClick);
            this.dataGridViewtax.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewtax_DataBindingComplete);
            // 
            // FromDate
            // 
            this.FromDate.DataPropertyName = "d1";
            this.FromDate.HeaderText = "از تاریخ";
            this.FromDate.Name = "FromDate";
            this.FromDate.Width = 120;
            // 
            // ToDate
            // 
            this.ToDate.DataPropertyName = "d2";
            this.ToDate.HeaderText = "تاتاریخ";
            this.ToDate.Name = "ToDate";
            this.ToDate.Width = 120;
            // 
            // TaxBurden
            // 
            this.TaxBurden.DataPropertyName = "TaxBurden";
            this.TaxBurden.HeaderText = "مالیات";
            this.TaxBurden.Name = "TaxBurden";
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.HeaderText = "";
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BTN_Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BTN_Delete.Width = 70;
            // 
            // TaxId
            // 
            this.TaxId.DataPropertyName = "TaxId";
            this.TaxId.HeaderText = "TaxId";
            this.TaxId.Name = "TaxId";
            this.TaxId.Visible = false;
            // 
            // Tax
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(453, 223);
            this.Controls.Add(this.dataGridViewtax);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Name = "Tax";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مالیات بر ارزش افزوده";
            this.Load += new System.EventHandler(this.Tax_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tax_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox masked_ToDate;
        private System.Windows.Forms.MaskedTextBox masked_FromDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Tax;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private WinCSS.SaveButton BTN_Save;
        private System.Windows.Forms.DataGridView dataGridViewtax;
        private WinCSS.SaveButton BTN_Edit;
        private System.Windows.Forms.Label LBL_TaxId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxBurden;
        private System.Windows.Forms.DataGridViewButtonColumn BTN_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxId;
    }
}