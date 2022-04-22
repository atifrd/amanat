namespace Amanat_UIS
{
    partial class Banks
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_BankName = new System.Windows.Forms.TextBox();
            this.GRD_Branch = new System.Windows.Forms.DataGridView();
            this.BranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRD_Edit = new System.Windows.Forms.DataGridView();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchDesc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Save = new WinCSS.SaveButton();
            this.BTN_Edit = new WinCSS.SaveButton();
            this.LBL_HiddenBankId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new WinCSS.CancelButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Branch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Edit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام بانک";
            // 
            // TXT_BankName
            // 
            this.TXT_BankName.Location = new System.Drawing.Point(116, 19);
            this.TXT_BankName.Name = "TXT_BankName";
            this.TXT_BankName.Size = new System.Drawing.Size(272, 30);
            this.TXT_BankName.TabIndex = 0;
            this.TXT_BankName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_BankName_KeyDown);
            this.TXT_BankName.Validating += new System.ComponentModel.CancelEventHandler(this.TXT_BankName_Validating);
            // 
            // GRD_Branch
            // 
            this.GRD_Branch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GRD_Branch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_Branch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BranchName,
            this.BranchDesc,
            this.BranchId});
            this.GRD_Branch.Location = new System.Drawing.Point(116, 50);
            this.GRD_Branch.Name = "GRD_Branch";
            this.GRD_Branch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GRD_Branch.Size = new System.Drawing.Size(273, 97);
            this.GRD_Branch.TabIndex = 1;
            // 
            // BranchName
            // 
            this.BranchName.DataPropertyName = "BranchName";
            this.BranchName.HeaderText = "نام شعبه";
            this.BranchName.Name = "BranchName";
            // 
            // BranchDesc
            // 
            this.BranchDesc.DataPropertyName = "BranchDesc";
            this.BranchDesc.HeaderText = "توضیحات";
            this.BranchDesc.Name = "BranchDesc";
            this.BranchDesc.Width = 130;
            // 
            // BranchId
            // 
            this.BranchId.DataPropertyName = "BranchId";
            this.BranchId.HeaderText = "BranchId";
            this.BranchId.Name = "BranchId";
            this.BranchId.Visible = false;
            // 
            // GRD_Edit
            // 
            this.GRD_Edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GRD_Edit.CausesValidation = false;
            this.GRD_Edit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_Edit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BankName,
            this.BranchName2,
            this.BranchDesc2,
            this.BankId});
            this.GRD_Edit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GRD_Edit.Location = new System.Drawing.Point(3, 184);
            this.GRD_Edit.Name = "GRD_Edit";
            this.GRD_Edit.ReadOnly = true;
            this.GRD_Edit.Size = new System.Drawing.Size(465, 131);
            this.GRD_Edit.TabIndex = 5;
            this.GRD_Edit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRD_Edit_CellDoubleClick);
            // 
            // BankName
            // 
            this.BankName.DataPropertyName = "BankName";
            this.BankName.HeaderText = "نام بانک";
            this.BankName.Name = "BankName";
            this.BankName.ReadOnly = true;
            // 
            // BranchName2
            // 
            this.BranchName2.DataPropertyName = "BranchName";
            this.BranchName2.HeaderText = "شعبه";
            this.BranchName2.Name = "BranchName2";
            this.BranchName2.ReadOnly = true;
            this.BranchName2.Width = 150;
            // 
            // BranchDesc2
            // 
            this.BranchDesc2.DataPropertyName = "BranchDesc";
            this.BranchDesc2.HeaderText = "توضیحات";
            this.BranchDesc2.Name = "BranchDesc2";
            this.BranchDesc2.ReadOnly = true;
            this.BranchDesc2.Width = 157;
            // 
            // BankId
            // 
            this.BankId.DataPropertyName = "BankId";
            this.BankId.HeaderText = "BankId";
            this.BankId.Name = "BankId";
            this.BankId.ReadOnly = true;
            this.BankId.Visible = false;
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(174, 150);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(81, 32);
            this.BTN_Save.TabIndex = 2;
            this.BTN_Save.Text = "ثبت";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Enabled = false;
            this.BTN_Edit.Location = new System.Drawing.Point(87, 150);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(81, 32);
            this.BTN_Edit.TabIndex = 10;
            this.BTN_Edit.Text = "ویرایش";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // LBL_HiddenBankId
            // 
            this.LBL_HiddenBankId.AutoSize = true;
            this.LBL_HiddenBankId.Location = new System.Drawing.Point(84, 22);
            this.LBL_HiddenBankId.Name = "LBL_HiddenBankId";
            this.LBL_HiddenBankId.Size = new System.Drawing.Size(20, 22);
            this.LBL_HiddenBankId.TabIndex = 11;
            this.LBL_HiddenBankId.Text = "0";
            this.LBL_HiddenBankId.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.GRD_Edit);
            this.groupBox1.Controls.Add(this.TXT_BankName);
            this.groupBox1.Controls.Add(this.GRD_Branch);
            this.groupBox1.Controls.Add(this.LBL_HiddenBankId);
            this.groupBox1.Controls.Add(this.BTN_Edit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BTN_Save);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 318);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت اطلاعات";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_cancel
            // 
            this.btn_cancel.CausesValidation = false;
            this.btn_cancel.Location = new System.Drawing.Point(5, 150);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(76, 32);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "انصراف";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Banks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(471, 318);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.KeyPreview = true;
            this.Name = "Banks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "بانک";
            this.Load += new System.EventHandler(this.Banks_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Banks_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Branch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Edit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_BankName;
        private System.Windows.Forms.DataGridView GRD_Branch;
        private System.Windows.Forms.DataGridView GRD_Edit;
        private WinCSS.SaveButton BTN_Save;
        private WinCSS.SaveButton BTN_Edit;
        private System.Windows.Forms.Label LBL_HiddenBankId;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinCSS.CancelButton btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchDesc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchId;
    }
}