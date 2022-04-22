namespace Amanat_UIS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TXT_M_FSum_Ezafe = new System.Windows.Forms.TextBox();
            this.TXT_M_FSum_kasr = new System.Windows.Forms.TextBox();
            this.TXT_FSumBeforM_FSum = new System.Windows.Forms.TextBox();
            this.TXT_SumWithoutTax = new System.Windows.Forms.TextBox();
            this.LBL_SumTax = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.TXT_Tell = new System.Windows.Forms.TextBox();
            this.TXT_Person = new System.Windows.Forms.TextBox();
            this.maskedexp_GiveBackTime = new System.Windows.Forms.MaskedTextBox();
            this.maskedGiveTime = new System.Windows.Forms.MaskedTextBox();
            this.maskedexp_GiveBackDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedGiveDate = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox_Info = new System.Windows.Forms.PictureBox();
            this.pictureBox_dateTime = new System.Windows.Forms.PictureBox();
            this.pictureBox_cache = new System.Windows.Forms.PictureBox();
            this.saveButton1 = new WinCSS.SaveButton();
            this.BTN_Save = new WinCSS.SaveButton();
            this.BTN_Clear = new WinCSS.SaveButton();
            this.label5 = new WinCSS.CommonLable();
            this.LBL_SerialNumber = new WinCSS.CommonLable();
            this.label6 = new WinCSS.CommonLable();
            this.LBL_Person = new WinCSS.CommonLable();
            this.label8 = new WinCSS.CommonLable();
            this.label7 = new WinCSS.CommonLable();
            this.LBL_Give = new WinCSS.CommonLable();
            this.label2 = new WinCSS.CommonLable();
            this.label1 = new WinCSS.CommonLable();
            this.LBL_EXPTake = new WinCSS.CommonLable();
            this.commonLable1 = new WinCSS.CommonLable();
            this.label10 = new WinCSS.CommonLable();
            this.label9 = new WinCSS.CommonLable();
            this.label11 = new WinCSS.CommonLable();
            this.label4 = new WinCSS.CommonLable();
            this.label3 = new WinCSS.CommonLable();
            this.LBL_SUM = new WinCSS.CommonLable();
            this.GRD_GiveAndTakeDetails = new grd_NewTabArrange();
            this.col_codeKala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baggageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaggageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaggagePriceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cache)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_GiveAndTakeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // stiReport1
            // 
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
            this.stiReport1.ReportGuid = "e80801c2d2ea48e1b54ffe9eee8da096";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(0, 307);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.commonLable1);
            this.splitContainer1.Panel1.Controls.Add(this.TXT_M_FSum_Ezafe);
            this.splitContainer1.Panel1.Controls.Add(this.TXT_M_FSum_kasr);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox_cache);
            this.splitContainer1.Panel2.Controls.Add(this.TXT_FSumBeforM_FSum);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.TXT_SumWithoutTax);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.LBL_SumTax);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.LBL_SUM);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(798, 123);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 76;
            // 
            // TXT_M_FSum_Ezafe
            // 
            this.TXT_M_FSum_Ezafe.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXT_M_FSum_Ezafe.Location = new System.Drawing.Point(238, 31);
            this.TXT_M_FSum_Ezafe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TXT_M_FSum_Ezafe.Name = "TXT_M_FSum_Ezafe";
            this.TXT_M_FSum_Ezafe.Size = new System.Drawing.Size(133, 29);
            this.TXT_M_FSum_Ezafe.TabIndex = 71;
            this.TXT_M_FSum_Ezafe.Text = "0";
            this.TXT_M_FSum_Ezafe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TXT_M_FSum_kasr
            // 
            this.TXT_M_FSum_kasr.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXT_M_FSum_kasr.Location = new System.Drawing.Point(238, 3);
            this.TXT_M_FSum_kasr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TXT_M_FSum_kasr.Name = "TXT_M_FSum_kasr";
            this.TXT_M_FSum_kasr.Size = new System.Drawing.Size(133, 29);
            this.TXT_M_FSum_kasr.TabIndex = 70;
            this.TXT_M_FSum_kasr.Text = "0";
            this.TXT_M_FSum_kasr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TXT_FSumBeforM_FSum
            // 
            this.TXT_FSumBeforM_FSum.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXT_FSumBeforM_FSum.Location = new System.Drawing.Point(5, 58);
            this.TXT_FSumBeforM_FSum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TXT_FSumBeforM_FSum.Name = "TXT_FSumBeforM_FSum";
            this.TXT_FSumBeforM_FSum.ReadOnly = true;
            this.TXT_FSumBeforM_FSum.Size = new System.Drawing.Size(133, 29);
            this.TXT_FSumBeforM_FSum.TabIndex = 87;
            this.TXT_FSumBeforM_FSum.TabStop = false;
            this.TXT_FSumBeforM_FSum.Text = "0";
            this.TXT_FSumBeforM_FSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TXT_SumWithoutTax
            // 
            this.TXT_SumWithoutTax.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXT_SumWithoutTax.Location = new System.Drawing.Point(5, 2);
            this.TXT_SumWithoutTax.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TXT_SumWithoutTax.Name = "TXT_SumWithoutTax";
            this.TXT_SumWithoutTax.ReadOnly = true;
            this.TXT_SumWithoutTax.Size = new System.Drawing.Size(133, 29);
            this.TXT_SumWithoutTax.TabIndex = 85;
            this.TXT_SumWithoutTax.TabStop = false;
            this.TXT_SumWithoutTax.Text = "0";
            this.TXT_SumWithoutTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LBL_SumTax
            // 
            this.LBL_SumTax.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LBL_SumTax.Location = new System.Drawing.Point(5, 30);
            this.LBL_SumTax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LBL_SumTax.Name = "LBL_SumTax";
            this.LBL_SumTax.ReadOnly = true;
            this.LBL_SumTax.Size = new System.Drawing.Size(133, 29);
            this.LBL_SumTax.TabIndex = 83;
            this.LBL_SumTax.TabStop = false;
            this.LBL_SumTax.Text = "0";
            this.LBL_SumTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.Location = new System.Drawing.Point(5, 86);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(133, 29);
            this.textBox1.TabIndex = 81;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox_Info);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.TXT_Tell);
            this.splitContainer2.Panel1.Controls.Add(this.TXT_Person);
            this.splitContainer2.Panel1.Controls.Add(this.LBL_SerialNumber);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.LBL_Person);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Panel1MinSize = 20;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox_dateTime);
            this.splitContainer2.Panel2.Controls.Add(this.maskedexp_GiveBackTime);
            this.splitContainer2.Panel2.Controls.Add(this.maskedGiveTime);
            this.splitContainer2.Panel2.Controls.Add(this.maskedexp_GiveBackDate);
            this.splitContainer2.Panel2.Controls.Add(this.maskedGiveDate);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.LBL_Give);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.LBL_EXPTake);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(800, 151);
            this.splitContainer2.SplitterDistance = 77;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 77;
            // 
            // TXT_Tell
            // 
            this.TXT_Tell.Location = new System.Drawing.Point(297, 34);
            this.TXT_Tell.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.TXT_Tell.Name = "TXT_Tell";
            this.TXT_Tell.Size = new System.Drawing.Size(193, 29);
            this.TXT_Tell.TabIndex = 80;
            // 
            // TXT_Person
            // 
            this.TXT_Person.Location = new System.Drawing.Point(213, 3);
            this.TXT_Person.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.TXT_Person.Name = "TXT_Person";
            this.TXT_Person.Size = new System.Drawing.Size(277, 29);
            this.TXT_Person.TabIndex = 79;
            // 
            // maskedexp_GiveBackTime
            // 
            this.maskedexp_GiveBackTime.Location = new System.Drawing.Point(116, 32);
            this.maskedexp_GiveBackTime.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.maskedexp_GiveBackTime.Mask = "00:00";
            this.maskedexp_GiveBackTime.Name = "maskedexp_GiveBackTime";
            this.maskedexp_GiveBackTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedexp_GiveBackTime.Size = new System.Drawing.Size(144, 29);
            this.maskedexp_GiveBackTime.TabIndex = 79;
            this.maskedexp_GiveBackTime.ValidatingType = typeof(System.DateTime);
            // 
            // maskedGiveTime
            // 
            this.maskedGiveTime.BackColor = System.Drawing.Color.LightSteelBlue;
            this.maskedGiveTime.Location = new System.Drawing.Point(474, 34);
            this.maskedGiveTime.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.maskedGiveTime.Mask = "00:00";
            this.maskedGiveTime.Name = "maskedGiveTime";
            this.maskedGiveTime.ReadOnly = true;
            this.maskedGiveTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedGiveTime.Size = new System.Drawing.Size(164, 29);
            this.maskedGiveTime.TabIndex = 87;
            // 
            // maskedexp_GiveBackDate
            // 
            this.maskedexp_GiveBackDate.Location = new System.Drawing.Point(96, 1);
            this.maskedexp_GiveBackDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.maskedexp_GiveBackDate.Mask = "00 /00 /1000";
            this.maskedexp_GiveBackDate.Name = "maskedexp_GiveBackDate";
            this.maskedexp_GiveBackDate.Size = new System.Drawing.Size(164, 29);
            this.maskedexp_GiveBackDate.TabIndex = 78;
            // 
            // maskedGiveDate
            // 
            this.maskedGiveDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.maskedGiveDate.Location = new System.Drawing.Point(480, 2);
            this.maskedGiveDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.maskedGiveDate.Mask = "00 /00 /1000";
            this.maskedGiveDate.Name = "maskedGiveDate";
            this.maskedGiveDate.ReadOnly = true;
            this.maskedGiveDate.Size = new System.Drawing.Size(164, 29);
            this.maskedGiveDate.TabIndex = 86;
            // 
            // pictureBox_Info
            // 
            this.pictureBox_Info.Image = global::Amanat_UIS.Properties.Resources.User_icon24;
            this.pictureBox_Info.Location = new System.Drawing.Point(766, 3);
            this.pictureBox_Info.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox_Info.Name = "pictureBox_Info";
            this.pictureBox_Info.Size = new System.Drawing.Size(25, 29);
            this.pictureBox_Info.TabIndex = 85;
            this.pictureBox_Info.TabStop = false;
            // 
            // pictureBox_dateTime
            // 
            this.pictureBox_dateTime.Image = global::Amanat_UIS.Properties.Resources.preferences_system_time32;
            this.pictureBox_dateTime.Location = new System.Drawing.Point(753, 3);
            this.pictureBox_dateTime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox_dateTime.Name = "pictureBox_dateTime";
            this.pictureBox_dateTime.Size = new System.Drawing.Size(39, 38);
            this.pictureBox_dateTime.TabIndex = 88;
            this.pictureBox_dateTime.TabStop = false;
            // 
            // pictureBox_cache
            // 
            this.pictureBox_cache.Image = global::Amanat_UIS.Properties.Resources.cash_register_48;
            this.pictureBox_cache.Location = new System.Drawing.Point(320, 1);
            this.pictureBox_cache.Name = "pictureBox_cache";
            this.pictureBox_cache.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_cache.TabIndex = 88;
            this.pictureBox_cache.TabStop = false;
            // 
            // saveButton1
            // 
            this.saveButton1.BackColor = System.Drawing.Color.Transparent;
            this.saveButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton1.BackgroundImage")));
            this.saveButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton1.FlatAppearance.BorderSize = 0;
            this.saveButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.saveButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton1.ForeColor = System.Drawing.Color.Transparent;
            this.saveButton1.Image = ((System.Drawing.Image)(resources.GetObject("saveButton1.Image")));
            this.saveButton1.Location = new System.Drawing.Point(598, 450);
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.Size = new System.Drawing.Size(16, 16);
            this.saveButton1.TabIndex = 81;
            this.saveButton1.Text = " ";
            this.saveButton1.UseVisualStyleBackColor = true;
            this.saveButton1.Click += new System.EventHandler(this.saveButton1_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Save.BackgroundImage")));
            this.BTN_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Save.FlatAppearance.BorderSize = 0;
            this.BTN_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Save.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Save.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Save.Image")));
            this.BTN_Save.Location = new System.Drawing.Point(389, 434);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Save.Size = new System.Drawing.Size(100, 50);
            this.BTN_Save.TabIndex = 79;
            this.BTN_Save.Text = " ";
            this.BTN_Save.UseVisualStyleBackColor = true;
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Clear.BackgroundImage")));
            this.BTN_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Clear.FlatAppearance.BorderSize = 0;
            this.BTN_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Clear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Clear.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Clear.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Clear.Image")));
            this.BTN_Clear.Location = new System.Drawing.Point(286, 434);
            this.BTN_Clear.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Clear.Size = new System.Drawing.Size(100, 50);
            this.BTN_Clear.TabIndex = 80;
            this.BTN_Clear.Text = " ";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(494, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 84;
            this.label5.Text = "تلفن :";
            // 
            // LBL_SerialNumber
            // 
            this.LBL_SerialNumber.AutoSize = true;
            this.LBL_SerialNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SerialNumber.ForeColor = System.Drawing.Color.Red;
            this.LBL_SerialNumber.Location = new System.Drawing.Point(596, 5);
            this.LBL_SerialNumber.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LBL_SerialNumber.Name = "LBL_SerialNumber";
            this.LBL_SerialNumber.Size = new System.Drawing.Size(19, 21);
            this.LBL_SerialNumber.TabIndex = 83;
            this.LBL_SerialNumber.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(704, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 82;
            this.label6.Text = "سریال :";
            // 
            // LBL_Person
            // 
            this.LBL_Person.AutoSize = true;
            this.LBL_Person.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Person.ForeColor = System.Drawing.Color.Red;
            this.LBL_Person.Location = new System.Drawing.Point(493, 9);
            this.LBL_Person.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LBL_Person.Name = "LBL_Person";
            this.LBL_Person.Size = new System.Drawing.Size(34, 21);
            this.LBL_Person.TabIndex = 81;
            this.LBL_Person.Text = "نام :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(278, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 21);
            this.label8.TabIndex = 85;
            this.label8.Text = "تاریخ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(268, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 84;
            this.label7.Text = "ساعت";
            // 
            // LBL_Give
            // 
            this.LBL_Give.AutoSize = true;
            this.LBL_Give.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Give.ForeColor = System.Drawing.Color.Red;
            this.LBL_Give.Location = new System.Drawing.Point(695, 23);
            this.LBL_Give.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LBL_Give.Name = "LBL_Give";
            this.LBL_Give.Size = new System.Drawing.Size(53, 21);
            this.LBL_Give.TabIndex = 83;
            this.LBL_Give.Text = "دریافت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(660, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 82;
            this.label2.Text = "تاریخ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(647, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 81;
            this.label1.Text = "ساعت";
            // 
            // LBL_EXPTake
            // 
            this.LBL_EXPTake.AutoSize = true;
            this.LBL_EXPTake.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EXPTake.ForeColor = System.Drawing.Color.Red;
            this.LBL_EXPTake.Location = new System.Drawing.Point(338, 23);
            this.LBL_EXPTake.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LBL_EXPTake.Name = "LBL_EXPTake";
            this.LBL_EXPTake.Size = new System.Drawing.Size(48, 21);
            this.LBL_EXPTake.TabIndex = 80;
            this.LBL_EXPTake.Tag = "";
            this.LBL_EXPTake.Text = "تحویل";
            // 
            // commonLable1
            // 
            this.commonLable1.AutoSize = true;
            this.commonLable1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commonLable1.ForeColor = System.Drawing.Color.Red;
            this.commonLable1.Location = new System.Drawing.Point(143, 86);
            this.commonLable1.Name = "commonLable1";
            this.commonLable1.Size = new System.Drawing.Size(126, 21);
            this.commonLable1.TabIndex = 74;
            this.commonLable1.Text = "commonLable1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(373, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 21);
            this.label10.TabIndex = 73;
            this.label10.Text = "اضافه";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(379, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 21);
            this.label9.TabIndex = 72;
            this.label9.Text = "کسر";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(140, 61);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 21);
            this.label11.TabIndex = 86;
            this.label11.Text = "جمع اقلام با احتساب مالیات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(231, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 84;
            this.label4.Text = "جمع اقلام";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(158, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 82;
            this.label3.Text = "مالیات بر ارزش افزوده";
            // 
            // LBL_SUM
            // 
            this.LBL_SUM.AutoSize = true;
            this.LBL_SUM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SUM.ForeColor = System.Drawing.Color.Red;
            this.LBL_SUM.Location = new System.Drawing.Point(191, 86);
            this.LBL_SUM.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LBL_SUM.Name = "LBL_SUM";
            this.LBL_SUM.Size = new System.Drawing.Size(117, 21);
            this.LBL_SUM.TabIndex = 80;
            this.LBL_SUM.Text = "مبلغ قابل پرداخت";
            // 
            // GRD_GiveAndTakeDetails
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.GRD_GiveAndTakeDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GRD_GiveAndTakeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_GiveAndTakeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codeKala,
            this.baggageName,
            this.BaggageCount,
            this.Price,
            this.count_Sum,
            this.BaggagePriceID});
            this.GRD_GiveAndTakeDetails.Location = new System.Drawing.Point(3, 156);
            this.GRD_GiveAndTakeDetails.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.GRD_GiveAndTakeDetails.Name = "GRD_GiveAndTakeDetails";
            this.GRD_GiveAndTakeDetails.Size = new System.Drawing.Size(795, 145);
            this.GRD_GiveAndTakeDetails.TabIndex = 78;
            // 
            // col_codeKala
            // 
            this.col_codeKala.DataPropertyName = "baggageCode";
            this.col_codeKala.HeaderText = "کدکالا";
            this.col_codeKala.Name = "col_codeKala";
            this.col_codeKala.Width = 150;
            // 
            // baggageName
            // 
            this.baggageName.DataPropertyName = "baggageName";
            this.baggageName.HeaderText = "شرح";
            this.baggageName.Name = "baggageName";
            this.baggageName.ReadOnly = true;
            this.baggageName.Width = 200;
            // 
            // BaggageCount
            // 
            this.BaggageCount.DataPropertyName = "BaggageCount";
            this.BaggageCount.HeaderText = "تعداد";
            this.BaggageCount.Name = "BaggageCount";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "مبلغ";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
            // 
            // count_Sum
            // 
            this.count_Sum.HeaderText = "مبلغ کل";
            this.count_Sum.Name = "count_Sum";
            this.count_Sum.ReadOnly = true;
            this.count_Sum.Width = 150;
            // 
            // BaggagePriceID
            // 
            this.BaggagePriceID.DataPropertyName = "BaggagePriceID";
            this.BaggagePriceID.HeaderText = "FKBaggagePriceID";
            this.BaggagePriceID.Name = "BaggagePriceID";
            this.BaggagePriceID.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.saveButton1);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.GRD_GiveAndTakeDetails);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cache)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_GiveAndTakeDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Stimulsoft.Report.StiReport stiReport1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox_Info;
        private WinCSS.CommonLable label5;
        private System.Windows.Forms.TextBox TXT_Tell;
        private System.Windows.Forms.TextBox TXT_Person;
        private WinCSS.CommonLable LBL_SerialNumber;
        private WinCSS.CommonLable label6;
        private WinCSS.CommonLable LBL_Person;
        private System.Windows.Forms.PictureBox pictureBox_dateTime;
        private System.Windows.Forms.MaskedTextBox maskedexp_GiveBackTime;
        private System.Windows.Forms.MaskedTextBox maskedGiveTime;
        private System.Windows.Forms.MaskedTextBox maskedexp_GiveBackDate;
        private System.Windows.Forms.MaskedTextBox maskedGiveDate;
        private WinCSS.CommonLable label8;
        private WinCSS.CommonLable label7;
        private WinCSS.CommonLable LBL_Give;
        private WinCSS.CommonLable label2;
        private WinCSS.CommonLable label1;
        private WinCSS.CommonLable LBL_EXPTake;
        private System.Windows.Forms.PictureBox pictureBox_cache;
        private System.Windows.Forms.TextBox TXT_FSumBeforM_FSum;
        private WinCSS.CommonLable label11;
        private System.Windows.Forms.TextBox TXT_SumWithoutTax;
        private WinCSS.CommonLable label4;
        private System.Windows.Forms.TextBox LBL_SumTax;
        private WinCSS.CommonLable label3;
        private System.Windows.Forms.TextBox textBox1;
        private WinCSS.CommonLable LBL_SUM;
        private System.Windows.Forms.TextBox TXT_M_FSum_Ezafe;
        private System.Windows.Forms.TextBox TXT_M_FSum_kasr;
        private WinCSS.CommonLable label10;
        private WinCSS.CommonLable label9;
        private grd_NewTabArrange GRD_GiveAndTakeDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codeKala;
        private System.Windows.Forms.DataGridViewTextBoxColumn baggageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaggageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaggagePriceID;
        private WinCSS.SaveButton BTN_Save;
        private WinCSS.SaveButton BTN_Clear;
        private WinCSS.CommonLable commonLable1;
        private WinCSS.SaveButton saveButton1;
       

    }
}