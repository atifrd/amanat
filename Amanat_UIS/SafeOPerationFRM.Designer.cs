namespace Amanat_UIS
{
    partial class SafeOPerationFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafeOPerationFRM));
            this.LBL_SerialNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedFishDateTime = new System.Windows.Forms.MaskedTextBox();
            this.BTN_Save = new WinCSS.SaveButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_FKAccountId = new System.Windows.Forms.Label();
            this.TXT_Account = new System.Windows.Forms.TextBox();
            this.LBL_BankFull = new System.Windows.Forms.Label();
            this.TXT_FishNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lBL_SafeMoney = new System.Windows.Forms.Label();
            this.TXT_BES = new System.Windows.Forms.TextBox();
            this.textBED = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_FishUrl = new System.Windows.Forms.TextBox();
            this.btnFile = new WinCSS.SaveButton();
            this.TXT_FishDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_SerialNumber
            // 
            this.LBL_SerialNumber.AutoSize = true;
            this.LBL_SerialNumber.Location = new System.Drawing.Point(579, 8);
            this.LBL_SerialNumber.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LBL_SerialNumber.Name = "LBL_SerialNumber";
            this.LBL_SerialNumber.Size = new System.Drawing.Size(20, 22);
            this.LBL_SerialNumber.TabIndex = 33;
            this.LBL_SerialNumber.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "سریال عملیات صندوق";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "تاریخ  عملیات";
            // 
            // maskedFishDateTime
            // 
            this.maskedFishDateTime.Location = new System.Drawing.Point(249, 2);
            this.maskedFishDateTime.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.maskedFishDateTime.Mask = "00 /00 /1000";
            this.maskedFishDateTime.Name = "maskedFishDateTime";
            this.maskedFishDateTime.ReadOnly = true;
            this.maskedFishDateTime.Size = new System.Drawing.Size(116, 30);
            this.maskedFishDateTime.TabIndex = 100;
            this.maskedFishDateTime.TabStop = false;
            this.maskedFishDateTime.Validated += new System.EventHandler(this.maskedexp_GiveBackDate_Validated);
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Save.BackgroundImage")));
            this.BTN_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Save.FlatAppearance.BorderSize = 0;
            this.BTN_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Save.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Save.Location = new System.Drawing.Point(9, 276);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Save.Size = new System.Drawing.Size(122, 40);
            this.BTN_Save.TabIndex = 7;
            this.BTN_Save.Text = "ثبت";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LBL_FKAccountId);
            this.panel1.Controls.Add(this.TXT_Account);
            this.panel1.Controls.Add(this.LBL_BankFull);
            this.panel1.Controls.Add(this.TXT_FishNumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 84);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LBL_FKAccountId
            // 
            this.LBL_FKAccountId.AutoSize = true;
            this.LBL_FKAccountId.Location = new System.Drawing.Point(271, 54);
            this.LBL_FKAccountId.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LBL_FKAccountId.Name = "LBL_FKAccountId";
            this.LBL_FKAccountId.Size = new System.Drawing.Size(20, 22);
            this.LBL_FKAccountId.TabIndex = 48;
            this.LBL_FKAccountId.Text = "0";
            this.LBL_FKAccountId.Visible = false;
            // 
            // TXT_Account
            // 
            this.TXT_Account.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TXT_Account.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TXT_Account.Location = new System.Drawing.Point(450, 6);
            this.TXT_Account.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.TXT_Account.Name = "TXT_Account";
            this.TXT_Account.Size = new System.Drawing.Size(227, 30);
            this.TXT_Account.TabIndex = 0;
            this.TXT_Account.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_Account.Leave += new System.EventHandler(this.TXT_Account_Leave);
            // 
            // LBL_BankFull
            // 
            this.LBL_BankFull.AutoSize = true;
            this.LBL_BankFull.Location = new System.Drawing.Point(83, 12);
            this.LBL_BankFull.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LBL_BankFull.Name = "LBL_BankFull";
            this.LBL_BankFull.Size = new System.Drawing.Size(0, 22);
            this.LBL_BankFull.TabIndex = 47;
            // 
            // TXT_FishNumber
            // 
            this.TXT_FishNumber.Location = new System.Drawing.Point(450, 44);
            this.TXT_FishNumber.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.TXT_FishNumber.Name = "TXT_FishNumber";
            this.TXT_FishNumber.Size = new System.Drawing.Size(227, 30);
            this.TXT_FishNumber.TabIndex = 1;
            this.TXT_FishNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 46;
            this.label4.Text = "شماره فیش";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "کد بانک";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lBL_SafeMoney);
            this.panel2.Controls.Add(this.TXT_BES);
            this.panel2.Controls.Add(this.textBED);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(6, 135);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 52);
            this.panel2.TabIndex = 37;
            // 
            // lBL_SafeMoney
            // 
            this.lBL_SafeMoney.AutoSize = true;
            this.lBL_SafeMoney.Location = new System.Drawing.Point(31, 42);
            this.lBL_SafeMoney.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lBL_SafeMoney.Name = "lBL_SafeMoney";
            this.lBL_SafeMoney.Size = new System.Drawing.Size(60, 22);
            this.lBL_SafeMoney.TabIndex = 41;
            this.lBL_SafeMoney.Text = "label3";
            this.lBL_SafeMoney.Visible = false;
            // 
            // TXT_BES
            // 
            this.TXT_BES.Location = new System.Drawing.Point(24, 8);
            this.TXT_BES.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.TXT_BES.Name = "TXT_BES";
            this.TXT_BES.Size = new System.Drawing.Size(155, 30);
            this.TXT_BES.TabIndex = 3;
            this.TXT_BES.Text = "0";
            this.TXT_BES.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_BES.TextChanged += new System.EventHandler(this.TXT_BES_TextChanged);
            this.TXT_BES.Validating += new System.ComponentModel.CancelEventHandler(this.TXT_BES_Validating);
            // 
            // textBED
            // 
            this.textBED.Location = new System.Drawing.Point(422, 10);
            this.textBED.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textBED.Name = "textBED";
            this.textBED.Size = new System.Drawing.Size(149, 30);
            this.textBED.TabIndex = 2;
            this.textBED.Text = "0";
            this.textBED.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 22);
            this.label7.TabIndex = 40;
            this.label7.Text = " بستانکار (برداشت از صندوق )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 22);
            this.label5.TabIndex = 39;
            this.label5.Text = " بدهکار (واریز به صندوق )";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TXT_FishUrl);
            this.panel3.Controls.Add(this.btnFile);
            this.panel3.Controls.Add(this.TXT_FishDesc);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(6, 192);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 80);
            this.panel3.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 67;
            this.label3.Text = "تصویرفیش";
            // 
            // TXT_FishUrl
            // 
            this.TXT_FishUrl.Location = new System.Drawing.Point(66, 41);
            this.TXT_FishUrl.Name = "TXT_FishUrl";
            this.TXT_FishUrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXT_FishUrl.Size = new System.Drawing.Size(578, 30);
            this.TXT_FishUrl.TabIndex = 6;
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.Transparent;
            this.btnFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFile.BackgroundImage")));
            this.btnFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFile.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.ForeColor = System.Drawing.Color.Transparent;
            this.btnFile.Location = new System.Drawing.Point(646, 41);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(32, 30);
            this.btnFile.TabIndex = 5;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // TXT_FishDesc
            // 
            this.TXT_FishDesc.Location = new System.Drawing.Point(66, 6);
            this.TXT_FishDesc.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.TXT_FishDesc.Name = "TXT_FishDesc";
            this.TXT_FishDesc.Size = new System.Drawing.Size(611, 30);
            this.TXT_FishDesc.TabIndex = 4;
            this.TXT_FishDesc.Enter += new System.EventHandler(this.TXT_FishDesc_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(684, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 22);
            this.label8.TabIndex = 37;
            this.label8.Text = "شرح عملیات";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(3, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 68;
            this.label9.Text = "اختیاری";
            // 
            // SafeOPerationFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 323);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.maskedFishDateTime);
            this.Controls.Add(this.LBL_SerialNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SafeOPerationFRM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ثبت عملیات صندوق";
            this.Load += new System.EventHandler(this.SafeOPerationFRM_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SafeOPerationFRM_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_SerialNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedFishDateTime;
        private WinCSS.SaveButton BTN_Save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_FKAccountId;
        private System.Windows.Forms.TextBox TXT_Account;
        private System.Windows.Forms.Label LBL_BankFull;
        private System.Windows.Forms.TextBox TXT_FishNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TXT_BES;
        private System.Windows.Forms.TextBox textBED;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TXT_FishDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lBL_SafeMoney;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TXT_FishUrl;
        private WinCSS.SaveButton btnFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label9;
    }
}