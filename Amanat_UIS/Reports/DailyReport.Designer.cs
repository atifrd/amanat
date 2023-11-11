namespace Amanat_UIS.Reports
{
    partial class DailyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Print = new WinCSS.SaveButton();
            this.maskedTxtTodate = new System.Windows.Forms.MaskedTextBox();
            this.label_to = new System.Windows.Forms.Label();
            this.BTN_Search = new WinCSS.SaveButton();
            this.masked_FromDate = new System.Windows.Forms.MaskedTextBox();
            this.label_from = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LBL_SumM_Fsum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_TaxOnDelay = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LBL_Tax = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBoxsts2 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxsts1 = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.LBL_FSum = new System.Windows.Forms.Label();
            this.LBL_Discount = new System.Windows.Forms.Label();
            this.LBL_Delay = new System.Windows.Forms.Label();
            this.LBL_Sum = new System.Windows.Forms.Label();
            this.LBL_ToFishNum = new System.Windows.Forms.Label();
            this.LBL_FromFishNum = new System.Windows.Forms.Label();
            this.lbl_FishCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LBL_ = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Print);
            this.groupBox1.Controls.Add(this.maskedTxtTodate);
            this.groupBox1.Controls.Add(this.label_to);
            this.groupBox1.Controls.Add(this.BTN_Search);
            this.groupBox1.Controls.Add(this.masked_FromDate);
            this.groupBox1.Controls.Add(this.label_from);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(765, 57);
            this.groupBox1.TabIndex = 0;
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
            this.BTN_Print.Font = new System.Drawing.Font("LMN Zar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Print.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Print.Location = new System.Drawing.Point(8, 12);
            this.BTN_Print.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Print.Name = "BTN_Print";
            this.BTN_Print.Size = new System.Drawing.Size(122, 40);
            this.BTN_Print.TabIndex = 64;
            this.BTN_Print.Text = "چاپ";
            this.BTN_Print.UseVisualStyleBackColor = true;
            this.BTN_Print.Click += new System.EventHandler(this.BTN_Print_Click);
            // 
            // maskedTxtTodate
            // 
            this.maskedTxtTodate.Location = new System.Drawing.Point(286, 18);
            this.maskedTxtTodate.Margin = new System.Windows.Forms.Padding(5);
            this.maskedTxtTodate.Mask = "00 /00 /1000";
            this.maskedTxtTodate.Name = "maskedTxtTodate";
            this.maskedTxtTodate.Size = new System.Drawing.Size(147, 45);
            this.maskedTxtTodate.TabIndex = 1;
            this.maskedTxtTodate.Enter += new System.EventHandler(this.maskedTxtTodate_Enter);
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(443, 23);
            this.label_to.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(74, 27);
            this.label_to.TabIndex = 63;
            this.label_to.Text = "تا تاریخ";
            // 
            // BTN_Search
            // 
            this.BTN_Search.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Search.BackgroundImage")));
            this.BTN_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Search.FlatAppearance.BorderSize = 0;
            this.BTN_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Search.Font = new System.Drawing.Font("LMN Zar", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Search.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Search.Location = new System.Drawing.Point(133, 12);
            this.BTN_Search.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(122, 40);
            this.BTN_Search.TabIndex = 2;
            this.BTN_Search.Text = "جستجو";
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // masked_FromDate
            // 
            this.masked_FromDate.Location = new System.Drawing.Point(545, 18);
            this.masked_FromDate.Margin = new System.Windows.Forms.Padding(5);
            this.masked_FromDate.Mask = "00 /00 /1000";
            this.masked_FromDate.Name = "masked_FromDate";
            this.masked_FromDate.Size = new System.Drawing.Size(133, 45);
            this.masked_FromDate.TabIndex = 0;
            this.masked_FromDate.Enter += new System.EventHandler(this.masked_FromDate_Enter);
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Location = new System.Drawing.Point(688, 23);
            this.label_from.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(79, 27);
            this.label_from.TabIndex = 0;
            this.label_from.Text = "از تاریخ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBL_SumM_Fsum);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LBL_TaxOnDelay);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.LBL_Tax);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.richTextBoxsts2);
            this.groupBox2.Controls.Add(this.richTextBoxsts1);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.LBL_FSum);
            this.groupBox2.Controls.Add(this.LBL_Discount);
            this.groupBox2.Controls.Add(this.LBL_Delay);
            this.groupBox2.Controls.Add(this.LBL_Sum);
            this.groupBox2.Controls.Add(this.LBL_ToFishNum);
            this.groupBox2.Controls.Add(this.LBL_FromFishNum);
            this.groupBox2.Controls.Add(this.lbl_FishCount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.LBL_);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("LMN Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 57);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(765, 537);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LBL_SumM_Fsum
            // 
            this.LBL_SumM_Fsum.AutoSize = true;
            this.LBL_SumM_Fsum.Font = new System.Drawing.Font("LMN Zar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SumM_Fsum.ForeColor = System.Drawing.Color.DarkGreen;
            this.LBL_SumM_Fsum.Location = new System.Drawing.Point(310, 128);
            this.LBL_SumM_Fsum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_SumM_Fsum.Name = "LBL_SumM_Fsum";
            this.LBL_SumM_Fsum.Size = new System.Drawing.Size(24, 35);
            this.LBL_SumM_Fsum.TabIndex = 22;
            this.LBL_SumM_Fsum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "کسر/اضافه";
            // 
            // LBL_TaxOnDelay
            // 
            this.LBL_TaxOnDelay.AutoSize = true;
            this.LBL_TaxOnDelay.Font = new System.Drawing.Font("LMN Zar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TaxOnDelay.ForeColor = System.Drawing.Color.DarkGreen;
            this.LBL_TaxOnDelay.Location = new System.Drawing.Point(310, 176);
            this.LBL_TaxOnDelay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_TaxOnDelay.Name = "LBL_TaxOnDelay";
            this.LBL_TaxOnDelay.Size = new System.Drawing.Size(24, 35);
            this.LBL_TaxOnDelay.TabIndex = 20;
            this.LBL_TaxOnDelay.Text = "0";
            this.LBL_TaxOnDelay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(506, 176);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(295, 31);
            this.label12.TabIndex = 19;
            this.label12.Text = "جمع مبلغ مالیات بر ارزش افزوده دیرکردها";
            // 
            // LBL_Tax
            // 
            this.LBL_Tax.AutoSize = true;
            this.LBL_Tax.Font = new System.Drawing.Font("LMN Zar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Tax.ForeColor = System.Drawing.Color.DarkGreen;
            this.LBL_Tax.Location = new System.Drawing.Point(310, 150);
            this.LBL_Tax.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Tax.Name = "LBL_Tax";
            this.LBL_Tax.Size = new System.Drawing.Size(24, 35);
            this.LBL_Tax.TabIndex = 18;
            this.LBL_Tax.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(559, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 31);
            this.label10.TabIndex = 17;
            this.label10.Text = "جمع مبلغ مالیات بر ارزش افزوده";
            // 
            // richTextBoxsts2
            // 
            this.richTextBoxsts2.BackColor = System.Drawing.Color.Silver;
            this.richTextBoxsts2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxsts2.Location = new System.Drawing.Point(13, 403);
            this.richTextBoxsts2.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBoxsts2.Name = "richTextBoxsts2";
            this.richTextBoxsts2.ReadOnly = true;
            this.richTextBoxsts2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBoxsts2.Size = new System.Drawing.Size(728, 121);
            this.richTextBoxsts2.TabIndex = 4;
            this.richTextBoxsts2.Text = "";
            // 
            // richTextBoxsts1
            // 
            this.richTextBoxsts1.BackColor = System.Drawing.Color.Silver;
            this.richTextBoxsts1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxsts1.ForeColor = System.Drawing.Color.DarkGreen;
            this.richTextBoxsts1.Location = new System.Drawing.Point(13, 250);
            this.richTextBoxsts1.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBoxsts1.Name = "richTextBoxsts1";
            this.richTextBoxsts1.ReadOnly = true;
            this.richTextBoxsts1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBoxsts1.Size = new System.Drawing.Size(730, 121);
            this.richTextBoxsts1.TabIndex = 3;
            this.richTextBoxsts1.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(402, 377);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(403, 31);
            this.label17.TabIndex = 16;
            this.label17.Text = "* سریال هایی که روزهای قبل باید می آمدند اما امروز آمدند";
            // 
            // LBL_FSum
            // 
            this.LBL_FSum.AutoSize = true;
            this.LBL_FSum.Font = new System.Drawing.Font("LMN Zar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_FSum.ForeColor = System.Drawing.Color.DarkGreen;
            this.LBL_FSum.Location = new System.Drawing.Point(310, 197);
            this.LBL_FSum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_FSum.Name = "LBL_FSum";
            this.LBL_FSum.Size = new System.Drawing.Size(24, 35);
            this.LBL_FSum.TabIndex = 15;
            this.LBL_FSum.Text = "0";
            // 
            // LBL_Discount
            // 
            this.LBL_Discount.AutoSize = true;
            this.LBL_Discount.Font = new System.Drawing.Font("LMN Zar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Discount.ForeColor = System.Drawing.Color.DarkGreen;
            this.LBL_Discount.Location = new System.Drawing.Point(310, 105);
            this.LBL_Discount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Discount.Name = "LBL_Discount";
            this.LBL_Discount.Size = new System.Drawing.Size(24, 35);
            this.LBL_Discount.TabIndex = 14;
            this.LBL_Discount.Text = "0";
            // 
            // LBL_Delay
            // 
            this.LBL_Delay.AutoSize = true;
            this.LBL_Delay.Font = new System.Drawing.Font("LMN Zar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Delay.ForeColor = System.Drawing.Color.DarkGreen;
            this.LBL_Delay.Location = new System.Drawing.Point(310, 81);
            this.LBL_Delay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Delay.Name = "LBL_Delay";
            this.LBL_Delay.Size = new System.Drawing.Size(24, 35);
            this.LBL_Delay.TabIndex = 13;
            this.LBL_Delay.Text = "0";
            // 
            // LBL_Sum
            // 
            this.LBL_Sum.AutoSize = true;
            this.LBL_Sum.Font = new System.Drawing.Font("LMN Zar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Sum.ForeColor = System.Drawing.Color.DarkGreen;
            this.LBL_Sum.Location = new System.Drawing.Point(310, 57);
            this.LBL_Sum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Sum.Name = "LBL_Sum";
            this.LBL_Sum.Size = new System.Drawing.Size(24, 35);
            this.LBL_Sum.TabIndex = 12;
            this.LBL_Sum.Text = "0";
            // 
            // LBL_ToFishNum
            // 
            this.LBL_ToFishNum.AutoSize = true;
            this.LBL_ToFishNum.Font = new System.Drawing.Font("LMN Zar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ToFishNum.ForeColor = System.Drawing.Color.DarkGreen;
            this.LBL_ToFishNum.Location = new System.Drawing.Point(33, 34);
            this.LBL_ToFishNum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_ToFishNum.Name = "LBL_ToFishNum";
            this.LBL_ToFishNum.Size = new System.Drawing.Size(24, 35);
            this.LBL_ToFishNum.TabIndex = 11;
            this.LBL_ToFishNum.Text = "0";
            // 
            // LBL_FromFishNum
            // 
            this.LBL_FromFishNum.AutoSize = true;
            this.LBL_FromFishNum.Font = new System.Drawing.Font("LMN Zar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_FromFishNum.ForeColor = System.Drawing.Color.DarkGreen;
            this.LBL_FromFishNum.Location = new System.Drawing.Point(310, 34);
            this.LBL_FromFishNum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_FromFishNum.Name = "LBL_FromFishNum";
            this.LBL_FromFishNum.Size = new System.Drawing.Size(24, 35);
            this.LBL_FromFishNum.TabIndex = 10;
            this.LBL_FromFishNum.Text = "0";
            // 
            // lbl_FishCount
            // 
            this.lbl_FishCount.AutoSize = true;
            this.lbl_FishCount.Font = new System.Drawing.Font("LMN Zar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FishCount.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_FishCount.Location = new System.Drawing.Point(310, 13);
            this.lbl_FishCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_FishCount.Name = "lbl_FishCount";
            this.lbl_FishCount.Size = new System.Drawing.Size(24, 35);
            this.lbl_FishCount.TabIndex = 9;
            this.lbl_FishCount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 224);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(341, 31);
            this.label9.TabIndex = 8;
            this.label9.Text = "* سریال هایی که امروز باید می آمدند اما نیامدند *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(640, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 31);
            this.label8.TabIndex = 7;
            this.label8.Text = "جمع مبلغ دریافتی";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LMN Zar", 12F);
            this.label7.Location = new System.Drawing.Point(656, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "تخفیف تحویل";
            // 
            // LBL_
            // 
            this.LBL_.AutoSize = true;
            this.LBL_.Location = new System.Drawing.Point(678, 81);
            this.LBL_.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_.Name = "LBL_";
            this.LBL_.Size = new System.Drawing.Size(75, 31);
            this.LBL_.TabIndex = 5;
            this.LBL_.Text = "دیرکردها";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "مبلغ دریافتی از مراجعین";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "تا سریال";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "از سریال";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "تعداد قبض های صادره";
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "9ff6a7ac5cf64e6cb5e2e550b93de01b";
            this.stiReport1.ReportImage = null;
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // DailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 594);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("LMN Zar", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DailyReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گزارش روزانه";
            this.Load += new System.EventHandler(this.DailyReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DailyReport_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.MaskedTextBox masked_FromDate;
        private WinCSS.SaveButton BTN_Search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LBL_;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_FSum;
        private System.Windows.Forms.Label LBL_Discount;
        private System.Windows.Forms.Label LBL_Delay;
        private System.Windows.Forms.Label LBL_Sum;
        private System.Windows.Forms.Label LBL_ToFishNum;
        private System.Windows.Forms.Label LBL_FromFishNum;
        private System.Windows.Forms.Label lbl_FishCount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox maskedTxtTodate;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.RichTextBox richTextBoxsts1;
        private System.Windows.Forms.RichTextBox richTextBoxsts2;
        private System.Windows.Forms.Label LBL_Tax;
        private System.Windows.Forms.Label label10;
        private Stimulsoft.Report.StiReport stiReport1;
        private WinCSS.SaveButton BTN_Print;
        private System.Windows.Forms.Label LBL_TaxOnDelay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LBL_SumM_Fsum;
        private System.Windows.Forms.Label label1;
    }
}