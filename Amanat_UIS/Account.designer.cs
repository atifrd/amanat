namespace Amanat_UIS
{
    partial class Account
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
            this.GRD_Accounts = new System.Windows.Forms.DataGridView();
            this.AccountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FKBranchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_AccountId = new System.Windows.Forms.Label();
            this.btn_cancel = new WinCSS.CancelButton();
            this.BTN_Edit = new WinCSS.SaveButton();
            this.TXT_AccountCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Save = new WinCSS.SaveButton();
            this.Combo_BankBranches = new System.Windows.Forms.ComboBox();
            this.TXT_AccountName = new System.Windows.Forms.TextBox();
            this.TXT_AccountNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Accounts)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GRD_Accounts
            // 
            this.GRD_Accounts.CausesValidation = false;
            this.GRD_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_Accounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountCode,
            this.AccountName,
            this.AccountNumber,
            this.BankBranch,
            this.AccountId,
            this.FKBranchId});
            this.GRD_Accounts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GRD_Accounts.Location = new System.Drawing.Point(0, 182);
            this.GRD_Accounts.Name = "GRD_Accounts";
            this.GRD_Accounts.Size = new System.Drawing.Size(574, 161);
            this.GRD_Accounts.TabIndex = 7;
            this.GRD_Accounts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRD_Accounts_CellDoubleClick);
            // 
            // AccountCode
            // 
            this.AccountCode.DataPropertyName = "AccountCode";
            this.AccountCode.HeaderText = "کد";
            this.AccountCode.Name = "AccountCode";
            // 
            // AccountName
            // 
            this.AccountName.DataPropertyName = "AccountName";
            this.AccountName.HeaderText = "عنوان حساب";
            this.AccountName.Name = "AccountName";
            this.AccountName.Width = 150;
            // 
            // AccountNumber
            // 
            this.AccountNumber.DataPropertyName = "AccountNumber";
            this.AccountNumber.HeaderText = "شماره حساب";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Width = 150;
            // 
            // BankBranch
            // 
            this.BankBranch.DataPropertyName = "BankBranch";
            this.BankBranch.HeaderText = "شعبه";
            this.BankBranch.Name = "BankBranch";
            this.BankBranch.Width = 130;
            // 
            // AccountId
            // 
            this.AccountId.DataPropertyName = "AccountId";
            this.AccountId.HeaderText = "AccountId";
            this.AccountId.Name = "AccountId";
            this.AccountId.Visible = false;
            // 
            // FKBranchId
            // 
            this.FKBranchId.DataPropertyName = "FKBranchId";
            this.FKBranchId.HeaderText = "FKBranchId";
            this.FKBranchId.Name = "FKBranchId";
            this.FKBranchId.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBL_AccountId);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.BTN_Edit);
            this.groupBox1.Controls.Add(this.TXT_AccountCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BTN_Save);
            this.groupBox1.Controls.Add(this.Combo_BankBranches);
            this.groupBox1.Controls.Add(this.TXT_AccountName);
            this.groupBox1.Controls.Add(this.TXT_AccountNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات حساب";
            // 
            // LBL_AccountId
            // 
            this.LBL_AccountId.AutoSize = true;
            this.LBL_AccountId.Location = new System.Drawing.Point(173, 16);
            this.LBL_AccountId.Name = "LBL_AccountId";
            this.LBL_AccountId.Size = new System.Drawing.Size(20, 22);
            this.LBL_AccountId.TabIndex = 41;
            this.LBL_AccountId.Text = "0";
            this.LBL_AccountId.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.CausesValidation = false;
            this.btn_cancel.Location = new System.Drawing.Point(6, 144);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(81, 32);
            this.btn_cancel.TabIndex = 36;
            this.btn_cancel.Text = "انصراف";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Enabled = false;
            this.BTN_Edit.Location = new System.Drawing.Point(93, 144);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(81, 32);
            this.BTN_Edit.TabIndex = 35;
            this.BTN_Edit.Text = "ویرایش";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // TXT_AccountCode
            // 
            this.TXT_AccountCode.Location = new System.Drawing.Point(380, 16);
            this.TXT_AccountCode.Name = "TXT_AccountCode";
            this.TXT_AccountCode.Size = new System.Drawing.Size(85, 30);
            this.TXT_AccountCode.TabIndex = 30;
            this.TXT_AccountCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_AccountCode.TextChanged += new System.EventHandler(this.TXT_AccountCode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "کد";
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(180, 144);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Save.Size = new System.Drawing.Size(82, 32);
            this.BTN_Save.TabIndex = 34;
            this.BTN_Save.Text = "ثبت";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // Combo_BankBranches
            // 
            this.Combo_BankBranches.FormattingEnabled = true;
            this.Combo_BankBranches.Location = new System.Drawing.Point(202, 111);
            this.Combo_BankBranches.Name = "Combo_BankBranches";
            this.Combo_BankBranches.Size = new System.Drawing.Size(262, 30);
            this.Combo_BankBranches.TabIndex = 33;
            // 
            // TXT_AccountName
            // 
            this.TXT_AccountName.Location = new System.Drawing.Point(203, 48);
            this.TXT_AccountName.Name = "TXT_AccountName";
            this.TXT_AccountName.Size = new System.Drawing.Size(262, 30);
            this.TXT_AccountName.TabIndex = 31;
            // 
            // TXT_AccountNumber
            // 
            this.TXT_AccountNumber.Location = new System.Drawing.Point(203, 79);
            this.TXT_AccountNumber.Name = "TXT_AccountNumber";
            this.TXT_AccountNumber.Size = new System.Drawing.Size(262, 30);
            this.TXT_AccountNumber.TabIndex = 32;
            this.TXT_AccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_AccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.TXT_AccountNumber_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "عنوان حساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "شماره حساب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "بانک و شعبه";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // Account
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(574, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GRD_Accounts);
            this.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Name = "Account";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "افتتاح حساب";
            this.Load += new System.EventHandler(this.Account_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Account_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Accounts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GRD_Accounts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_AccountId;
        private WinCSS.CancelButton btn_cancel;
        private WinCSS.SaveButton BTN_Edit;
        private System.Windows.Forms.TextBox TXT_AccountCode;
        private System.Windows.Forms.Label label4;
        private WinCSS.SaveButton BTN_Save;
        private System.Windows.Forms.ComboBox Combo_BankBranches;
        private System.Windows.Forms.TextBox TXT_AccountName;
        private System.Windows.Forms.TextBox TXT_AccountNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FKBranchId;

    }
}