namespace Amanat_UIS
{
    partial class TakeBaggages_Edit2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeBaggages_Edit2));
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Tell = new System.Windows.Forms.TextBox();
            this.maskedexp_GiveBackTime = new System.Windows.Forms.MaskedTextBox();
            this.maskedGiveTime = new System.Windows.Forms.MaskedTextBox();
            this.maskedexp_GiveBackDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedGiveDate = new System.Windows.Forms.MaskedTextBox();
            this.TXT_Person = new System.Windows.Forms.TextBox();
            this.TXT_LockerNumber = new System.Windows.Forms.TextBox();
            this.LBL_LockerNumber = new System.Windows.Forms.Label();
            this.LBL_SerialNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBL_Person = new System.Windows.Forms.Label();
            this.LBL_Give = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_EXPTake = new System.Windows.Forms.Label();
            this.TXT_FSumBeforM_FSum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TXT_M_FSum_Ezafe = new System.Windows.Forms.TextBox();
            this.TXT_M_FSum_kasr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LBL_Message = new System.Windows.Forms.Label();
            this.TXT_SumWithoutTax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_SumTax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BTN_Clear = new WinCSS.CancelButton();
            this.LBL_SUM = new System.Windows.Forms.Label();
            this.BTN_Edit = new WinCSS.SaveButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GRD_GiveAndTakeDetails = new grd_NewTabArrange();
            this.col_codeKala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baggageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaggageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaggagePriceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_FKGiveAndTake_masterId = new System.Windows.Forms.Label();
            this.BTN_Ebtal = new WinCSS.CancelButton();
            this.stiReportFishCustom = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_GiveAndTakeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 85;
            this.label5.Text = "تلفن :";
            // 
            // TXT_Tell
            // 
            this.TXT_Tell.Location = new System.Drawing.Point(141, 6);
            this.TXT_Tell.Margin = new System.Windows.Forms.Padding(10);
            this.TXT_Tell.Name = "TXT_Tell";
            this.TXT_Tell.Size = new System.Drawing.Size(147, 29);
            this.TXT_Tell.TabIndex = 1;
            // 
            // maskedexp_GiveBackTime
            // 
            this.maskedexp_GiveBackTime.Location = new System.Drawing.Point(549, 100);
            this.maskedexp_GiveBackTime.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.maskedexp_GiveBackTime.Mask = "00:00";
            this.maskedexp_GiveBackTime.Name = "maskedexp_GiveBackTime";
            this.maskedexp_GiveBackTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedexp_GiveBackTime.Size = new System.Drawing.Size(81, 29);
            this.maskedexp_GiveBackTime.TabIndex = 3;
            this.maskedexp_GiveBackTime.ValidatingType = typeof(System.DateTime);
            this.maskedexp_GiveBackTime.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedexp_GiveBackTime_TypeValidationCompleted);
            this.maskedexp_GiveBackTime.Leave += new System.EventHandler(this.maskedexp_GiveBackTime_Leave);
            // 
            // maskedGiveTime
            // 
            this.maskedGiveTime.BackColor = System.Drawing.Color.LightSteelBlue;
            this.maskedGiveTime.Location = new System.Drawing.Point(837, 100);
            this.maskedGiveTime.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.maskedGiveTime.Mask = "00:00";
            this.maskedGiveTime.Name = "maskedGiveTime";
            this.maskedGiveTime.ReadOnly = true;
            this.maskedGiveTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedGiveTime.Size = new System.Drawing.Size(81, 29);
            this.maskedGiveTime.TabIndex = 84;
            // 
            // maskedexp_GiveBackDate
            // 
            this.maskedexp_GiveBackDate.Location = new System.Drawing.Point(524, 63);
            this.maskedexp_GiveBackDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.maskedexp_GiveBackDate.Mask = "00 /00 /1000";
            this.maskedexp_GiveBackDate.Name = "maskedexp_GiveBackDate";
            this.maskedexp_GiveBackDate.Size = new System.Drawing.Size(106, 29);
            this.maskedexp_GiveBackDate.TabIndex = 2;
            this.maskedexp_GiveBackDate.Enter += new System.EventHandler(this.maskedexp_GiveBackDate_Enter);
            this.maskedexp_GiveBackDate.Leave += new System.EventHandler(this.maskedexp_GiveBackDate_Leave);
            // 
            // maskedGiveDate
            // 
            this.maskedGiveDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.maskedGiveDate.Location = new System.Drawing.Point(812, 63);
            this.maskedGiveDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.maskedGiveDate.Mask = "00 /00 /1000";
            this.maskedGiveDate.Name = "maskedGiveDate";
            this.maskedGiveDate.ReadOnly = true;
            this.maskedGiveDate.Size = new System.Drawing.Size(106, 29);
            this.maskedGiveDate.TabIndex = 83;
            // 
            // TXT_Person
            // 
            this.TXT_Person.Location = new System.Drawing.Point(370, 6);
            this.TXT_Person.Margin = new System.Windows.Forms.Padding(10);
            this.TXT_Person.Name = "TXT_Person";
            this.TXT_Person.Size = new System.Drawing.Size(324, 29);
            this.TXT_Person.TabIndex = 0;
            // 
            // TXT_LockerNumber
            // 
            this.TXT_LockerNumber.Location = new System.Drawing.Point(143, 82);
            this.TXT_LockerNumber.Margin = new System.Windows.Forms.Padding(10);
            this.TXT_LockerNumber.Name = "TXT_LockerNumber";
            this.TXT_LockerNumber.Size = new System.Drawing.Size(101, 29);
            this.TXT_LockerNumber.TabIndex = 82;
            this.TXT_LockerNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LBL_LockerNumber
            // 
            this.LBL_LockerNumber.AutoSize = true;
            this.LBL_LockerNumber.Location = new System.Drawing.Point(249, 87);
            this.LBL_LockerNumber.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LBL_LockerNumber.Name = "LBL_LockerNumber";
            this.LBL_LockerNumber.Size = new System.Drawing.Size(86, 21);
            this.LBL_LockerNumber.TabIndex = 81;
            this.LBL_LockerNumber.Text = "شماره قفسه :";
            // 
            // LBL_SerialNumber
            // 
            this.LBL_SerialNumber.AutoSize = true;
            this.LBL_SerialNumber.Location = new System.Drawing.Point(883, 15);
            this.LBL_SerialNumber.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LBL_SerialNumber.Name = "LBL_SerialNumber";
            this.LBL_SerialNumber.Size = new System.Drawing.Size(19, 21);
            this.LBL_SerialNumber.TabIndex = 80;
            this.LBL_SerialNumber.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(637, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 21);
            this.label8.TabIndex = 79;
            this.label8.Text = "تاریخ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 78;
            this.label7.Text = "ساعت";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(977, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 77;
            this.label6.Text = "سریال";
            // 
            // LBL_Person
            // 
            this.LBL_Person.AutoSize = true;
            this.LBL_Person.Location = new System.Drawing.Point(695, 13);
            this.LBL_Person.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LBL_Person.Name = "LBL_Person";
            this.LBL_Person.Size = new System.Drawing.Size(34, 21);
            this.LBL_Person.TabIndex = 76;
            this.LBL_Person.Text = "نام :";
            // 
            // LBL_Give
            // 
            this.LBL_Give.AutoSize = true;
            this.LBL_Give.Location = new System.Drawing.Point(972, 81);
            this.LBL_Give.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LBL_Give.Name = "LBL_Give";
            this.LBL_Give.Size = new System.Drawing.Size(53, 21);
            this.LBL_Give.TabIndex = 75;
            this.LBL_Give.Text = "دریافت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(926, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 74;
            this.label2.Text = "تاریخ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(925, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 73;
            this.label1.Text = "ساعت";
            // 
            // LBL_EXPTake
            // 
            this.LBL_EXPTake.AutoSize = true;
            this.LBL_EXPTake.Location = new System.Drawing.Point(681, 81);
            this.LBL_EXPTake.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LBL_EXPTake.Name = "LBL_EXPTake";
            this.LBL_EXPTake.Size = new System.Drawing.Size(48, 21);
            this.LBL_EXPTake.TabIndex = 72;
            this.LBL_EXPTake.Tag = "";
            this.LBL_EXPTake.Text = "تحویل";
            // 
            // TXT_FSumBeforM_FSum
            // 
            this.TXT_FSumBeforM_FSum.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXT_FSumBeforM_FSum.Location = new System.Drawing.Point(20, 371);
            this.TXT_FSumBeforM_FSum.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TXT_FSumBeforM_FSum.Name = "TXT_FSumBeforM_FSum";
            this.TXT_FSumBeforM_FSum.ReadOnly = true;
            this.TXT_FSumBeforM_FSum.Size = new System.Drawing.Size(131, 29);
            this.TXT_FSumBeforM_FSum.TabIndex = 101;
            this.TXT_FSumBeforM_FSum.TabStop = false;
            this.TXT_FSumBeforM_FSum.Text = "0";
            this.TXT_FSumBeforM_FSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(156, 371);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 21);
            this.label11.TabIndex = 100;
            this.label11.Text = "جمع اقلام با احتساب مالیات";
            // 
            // TXT_M_FSum_Ezafe
            // 
            this.TXT_M_FSum_Ezafe.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXT_M_FSum_Ezafe.Location = new System.Drawing.Point(849, 338);
            this.TXT_M_FSum_Ezafe.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TXT_M_FSum_Ezafe.Name = "TXT_M_FSum_Ezafe";
            this.TXT_M_FSum_Ezafe.Size = new System.Drawing.Size(131, 29);
            this.TXT_M_FSum_Ezafe.TabIndex = 6;
            this.TXT_M_FSum_Ezafe.Text = "0";
            this.TXT_M_FSum_Ezafe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_M_FSum_Ezafe.TextChanged += new System.EventHandler(this.TXT_M_FSum_Ezafe_TextChanged);
            this.TXT_M_FSum_Ezafe.Leave += new System.EventHandler(this.TXT_M_FSum_Ezafe_Leave);
            // 
            // TXT_M_FSum_kasr
            // 
            this.TXT_M_FSum_kasr.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXT_M_FSum_kasr.Location = new System.Drawing.Point(849, 308);
            this.TXT_M_FSum_kasr.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TXT_M_FSum_kasr.Name = "TXT_M_FSum_kasr";
            this.TXT_M_FSum_kasr.Size = new System.Drawing.Size(131, 29);
            this.TXT_M_FSum_kasr.TabIndex = 5;
            this.TXT_M_FSum_kasr.Text = "0";
            this.TXT_M_FSum_kasr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_M_FSum_kasr.TextChanged += new System.EventHandler(this.TXT_M_FSum_kasr_TextChanged);
            this.TXT_M_FSum_kasr.Leave += new System.EventHandler(this.TXT_M_FSum_kasr_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(983, 338);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 21);
            this.label10.TabIndex = 99;
            this.label10.Text = "اضافه";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(993, 308);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 21);
            this.label9.TabIndex = 98;
            this.label9.Text = "کسر";
            // 
            // LBL_Message
            // 
            this.LBL_Message.AutoSize = true;
            this.LBL_Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBL_Message.Location = new System.Drawing.Point(504, 407);
            this.LBL_Message.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Message.Name = "LBL_Message";
            this.LBL_Message.Size = new System.Drawing.Size(0, 21);
            this.LBL_Message.TabIndex = 91;
            // 
            // TXT_SumWithoutTax
            // 
            this.TXT_SumWithoutTax.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXT_SumWithoutTax.Location = new System.Drawing.Point(20, 309);
            this.TXT_SumWithoutTax.Margin = new System.Windows.Forms.Padding(10);
            this.TXT_SumWithoutTax.Name = "TXT_SumWithoutTax";
            this.TXT_SumWithoutTax.ReadOnly = true;
            this.TXT_SumWithoutTax.Size = new System.Drawing.Size(131, 29);
            this.TXT_SumWithoutTax.TabIndex = 97;
            this.TXT_SumWithoutTax.TabStop = false;
            this.TXT_SumWithoutTax.Text = "0";
            this.TXT_SumWithoutTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 96;
            this.label4.Text = "جمع اقلام";
            // 
            // LBL_SumTax
            // 
            this.LBL_SumTax.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LBL_SumTax.Location = new System.Drawing.Point(20, 340);
            this.LBL_SumTax.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LBL_SumTax.Name = "LBL_SumTax";
            this.LBL_SumTax.ReadOnly = true;
            this.LBL_SumTax.Size = new System.Drawing.Size(131, 29);
            this.LBL_SumTax.TabIndex = 95;
            this.LBL_SumTax.TabStop = false;
            this.LBL_SumTax.Text = "0";
            this.LBL_SumTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 94;
            this.label3.Text = "مالیات بر ارزش افزوده";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.Location = new System.Drawing.Point(20, 402);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(131, 29);
            this.textBox1.TabIndex = 93;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Clear.BackgroundImage")));
            this.BTN_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Clear.FlatAppearance.BorderSize = 0;
            this.BTN_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Clear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Clear.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Clear.Location = new System.Drawing.Point(363, 442);
            this.BTN_Clear.Margin = new System.Windows.Forms.Padding(10);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Clear.Size = new System.Drawing.Size(100, 50);
            this.BTN_Clear.TabIndex = 8;
            this.BTN_Clear.Text = "انصراف";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // LBL_SUM
            // 
            this.LBL_SUM.AutoSize = true;
            this.LBL_SUM.Location = new System.Drawing.Point(215, 403);
            this.LBL_SUM.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LBL_SUM.Name = "LBL_SUM";
            this.LBL_SUM.Size = new System.Drawing.Size(117, 21);
            this.LBL_SUM.TabIndex = 92;
            this.LBL_SUM.Text = "مبلغ قابل پرداخت";
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Edit.BackgroundImage")));
            this.BTN_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Edit.FlatAppearance.BorderSize = 0;
            this.BTN_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Edit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Edit.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Edit.Location = new System.Drawing.Point(465, 442);
            this.BTN_Edit.Margin = new System.Windows.Forms.Padding(10);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Edit.Size = new System.Drawing.Size(100, 50);
            this.BTN_Edit.TabIndex = 7;
            this.BTN_Edit.Text = "ویرایش";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GRD_GiveAndTakeDetails
            // 
            this.GRD_GiveAndTakeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_GiveAndTakeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codeKala,
            this.baggageName,
            this.BaggageCount,
            this.Price,
            this.count_Sum,
            this.BaggagePriceID});
            this.GRD_GiveAndTakeDetails.Location = new System.Drawing.Point(20, 141);
            this.GRD_GiveAndTakeDetails.Margin = new System.Windows.Forms.Padding(10);
            this.GRD_GiveAndTakeDetails.Name = "GRD_GiveAndTakeDetails";
            this.GRD_GiveAndTakeDetails.Size = new System.Drawing.Size(1007, 166);
            this.GRD_GiveAndTakeDetails.TabIndex = 4;
            this.GRD_GiveAndTakeDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRD_GiveAndTakeDetails_CellValueChanged);
            this.GRD_GiveAndTakeDetails.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.GRD_GiveAndTakeDetails_UserDeletedRow);
            this.GRD_GiveAndTakeDetails.Enter += new System.EventHandler(this.GRD_GiveAndTakeDetails_Enter);
            // 
            // col_codeKala
            // 
            this.col_codeKala.DataPropertyName = "baggageCode";
            this.col_codeKala.HeaderText = "کدکالا";
            this.col_codeKala.Name = "col_codeKala";
            // 
            // baggageName
            // 
            this.baggageName.DataPropertyName = "baggageName";
            this.baggageName.HeaderText = "شرح";
            this.baggageName.Name = "baggageName";
            this.baggageName.ReadOnly = true;
            this.baggageName.Width = 150;
            // 
            // BaggageCount
            // 
            this.BaggageCount.DataPropertyName = "BaggageCount";
            this.BaggageCount.HeaderText = "تعداد";
            this.BaggageCount.Name = "BaggageCount";
            this.BaggageCount.Width = 60;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "مبلغ";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 120;
            // 
            // count_Sum
            // 
            this.count_Sum.DataPropertyName = "MySum";
            this.count_Sum.HeaderText = "مبلغ کل";
            this.count_Sum.Name = "count_Sum";
            this.count_Sum.ReadOnly = true;
            this.count_Sum.Width = 120;
            // 
            // BaggagePriceID
            // 
            this.BaggagePriceID.DataPropertyName = "BaggagePriceID";
            this.BaggagePriceID.HeaderText = "FKBaggagePriceID";
            this.BaggagePriceID.Name = "BaggagePriceID";
            this.BaggagePriceID.Visible = false;
            // 
            // lbl_FKGiveAndTake_masterId
            // 
            this.lbl_FKGiveAndTake_masterId.AutoSize = true;
            this.lbl_FKGiveAndTake_masterId.Location = new System.Drawing.Point(12, 60);
            this.lbl_FKGiveAndTake_masterId.Name = "lbl_FKGiveAndTake_masterId";
            this.lbl_FKGiveAndTake_masterId.Size = new System.Drawing.Size(0, 21);
            this.lbl_FKGiveAndTake_masterId.TabIndex = 102;
            // 
            // BTN_Ebtal
            // 
            this.BTN_Ebtal.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Ebtal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Ebtal.BackgroundImage")));
            this.BTN_Ebtal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Ebtal.FlatAppearance.BorderSize = 0;
            this.BTN_Ebtal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_Ebtal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Ebtal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ebtal.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Ebtal.Location = new System.Drawing.Point(567, 442);
            this.BTN_Ebtal.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Ebtal.Name = "BTN_Ebtal";
            this.BTN_Ebtal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Ebtal.Size = new System.Drawing.Size(100, 50);
            this.BTN_Ebtal.TabIndex = 103;
            this.BTN_Ebtal.Text = "ابطال قبض";
            this.BTN_Ebtal.UseVisualStyleBackColor = true;
            this.BTN_Ebtal.Click += new System.EventHandler(this.BTN_Ebtal_Click);
            // 
            // stiReportFishCustom
            // 
            this.stiReportFishCustom.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReportFishCustom.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll",
        "Amanat_BO.Dll"};
            this.stiReportFishCustom.ReportAlias = "Report";
            this.stiReportFishCustom.ReportGuid = "c8d2fefa88e648c09b8f90c6d80c37e6";
            this.stiReportFishCustom.ReportName = "Report";
            this.stiReportFishCustom.ReportSource = resources.GetString("stiReportFishCustom.ReportSource");
            this.stiReportFishCustom.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReportFishCustom.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReportFishCustom.UseProgressInThread = false;
            // 
            // TakeBaggages_Edit2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 497);
            this.Controls.Add(this.BTN_Ebtal);
            this.Controls.Add(this.lbl_FKGiveAndTake_masterId);
            this.Controls.Add(this.TXT_FSumBeforM_FSum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TXT_M_FSum_Ezafe);
            this.Controls.Add(this.TXT_M_FSum_kasr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LBL_Message);
            this.Controls.Add(this.TXT_SumWithoutTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBL_SumTax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.LBL_SUM);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.GRD_GiveAndTakeDetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_Tell);
            this.Controls.Add(this.maskedexp_GiveBackTime);
            this.Controls.Add(this.maskedGiveTime);
            this.Controls.Add(this.maskedexp_GiveBackDate);
            this.Controls.Add(this.maskedGiveDate);
            this.Controls.Add(this.TXT_Person);
            this.Controls.Add(this.TXT_LockerNumber);
            this.Controls.Add(this.LBL_LockerNumber);
            this.Controls.Add(this.LBL_SerialNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LBL_Person);
            this.Controls.Add(this.LBL_Give);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_EXPTake);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TakeBaggages_Edit2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ویرایش قبض";
            this.Load += new System.EventHandler(this.TakeBaggages_Edit2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TakeBaggages_Edit2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_GiveAndTakeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public TakeBaggages TakeBaggagesInstance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_Tell;
        private System.Windows.Forms.MaskedTextBox maskedexp_GiveBackTime;
        private System.Windows.Forms.MaskedTextBox maskedGiveTime;
        private System.Windows.Forms.MaskedTextBox maskedexp_GiveBackDate;
        private System.Windows.Forms.MaskedTextBox maskedGiveDate;
        private System.Windows.Forms.TextBox TXT_Person;
        private System.Windows.Forms.TextBox TXT_LockerNumber;
        private System.Windows.Forms.Label LBL_LockerNumber;
        private System.Windows.Forms.Label LBL_SerialNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBL_Person;
        private System.Windows.Forms.Label LBL_Give;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_EXPTake;
        private grd_NewTabArrange GRD_GiveAndTakeDetails;
        private System.Windows.Forms.TextBox TXT_FSumBeforM_FSum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXT_M_FSum_Ezafe;
        private System.Windows.Forms.TextBox TXT_M_FSum_kasr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBL_Message;
        private System.Windows.Forms.TextBox TXT_SumWithoutTax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LBL_SumTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private WinCSS.CancelButton BTN_Clear;
        private System.Windows.Forms.Label LBL_SUM;
        private WinCSS.SaveButton BTN_Edit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codeKala;
        private System.Windows.Forms.DataGridViewTextBoxColumn baggageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaggageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaggagePriceID;
        private System.Windows.Forms.Label lbl_FKGiveAndTake_masterId;
        private WinCSS.CancelButton BTN_Ebtal;
        private Stimulsoft.Report.StiReport stiReportFishCustom;
    }
}