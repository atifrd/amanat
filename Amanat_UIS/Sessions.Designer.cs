namespace Amanat_UIS
{
    partial class Sessions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sessions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTN_Save = new WinCSS.SaveButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_No = new System.Windows.Forms.TextBox();
            this.masked_ToDate = new System.Windows.Forms.MaskedTextBox();
            this.masked_FromDate = new System.Windows.Forms.MaskedTextBox();
            this.GRD_Session = new System.Windows.Forms.DataGridView();
            this.FromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SessionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Deactive = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SessionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_OldSessionId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Session)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Save.BackgroundImage")));
            this.BTN_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Save.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Save.Location = new System.Drawing.Point(26, 43);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Save.Size = new System.Drawing.Size(82, 32);
            this.BTN_Save.TabIndex = 3;
            this.BTN_Save.Text = "ثبت";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "تاتاریخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "فصل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "از تاریخ";
            // 
            // TXT_No
            // 
            this.TXT_No.Location = new System.Drawing.Point(241, 47);
            this.TXT_No.Name = "TXT_No";
            this.TXT_No.ReadOnly = true;
            this.TXT_No.Size = new System.Drawing.Size(54, 20);
            this.TXT_No.TabIndex = 2;
            this.TXT_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_No.Validating += new System.ComponentModel.CancelEventHandler(this.TXT_No_Validating);
            // 
            // masked_ToDate
            // 
            this.masked_ToDate.Location = new System.Drawing.Point(5, 9);
            this.masked_ToDate.Mask = "00 /00 /1000";
            this.masked_ToDate.Name = "masked_ToDate";
            this.masked_ToDate.ReadOnly = true;
            this.masked_ToDate.Size = new System.Drawing.Size(110, 20);
            this.masked_ToDate.TabIndex = 1;
            // 
            // masked_FromDate
            // 
            this.masked_FromDate.Location = new System.Drawing.Point(185, 10);
            this.masked_FromDate.Mask = "00 /00 /1000";
            this.masked_FromDate.Name = "masked_FromDate";
            this.masked_FromDate.ReadOnly = true;
            this.masked_FromDate.Size = new System.Drawing.Size(110, 20);
            this.masked_FromDate.TabIndex = 0;
            // 
            // GRD_Session
            // 
            this.GRD_Session.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_Session.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FromDate,
            this.ToDate,
            this.SessionNo,
            this.BTN_Deactive,
            this.SessionId,
            this.Active});
            this.GRD_Session.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRD_Session.Location = new System.Drawing.Point(0, 0);
            this.GRD_Session.Name = "GRD_Session";
            this.GRD_Session.Size = new System.Drawing.Size(473, 283);
            this.GRD_Session.TabIndex = 9;
            this.GRD_Session.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRD_Baggage_Price_CellContentClick);
            this.GRD_Session.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GRD_Session_DataBindingComplete);
            // 
            // FromDate
            // 
            this.FromDate.HeaderText = "اعتبار از تاریخ";
            this.FromDate.Name = "FromDate";
            this.FromDate.Width = 120;
            // 
            // ToDate
            // 
            this.ToDate.HeaderText = "تا تاریخ";
            this.ToDate.Name = "ToDate";
            this.ToDate.Width = 110;
            // 
            // SessionNo
            // 
            this.SessionNo.DataPropertyName = "SessionNo";
            this.SessionNo.HeaderText = "شماره";
            this.SessionNo.Name = "SessionNo";
            // 
            // BTN_Deactive
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_Deactive.DefaultCellStyle = dataGridViewCellStyle1;
            this.BTN_Deactive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTN_Deactive.HeaderText = "";
            this.BTN_Deactive.Name = "BTN_Deactive";
            this.BTN_Deactive.Text = "";
            // 
            // SessionId
            // 
            this.SessionId.DataPropertyName = "SessionId";
            this.SessionId.HeaderText = "SessionId";
            this.SessionId.Name = "SessionId";
            this.SessionId.Visible = false;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LBL_OldSessionId);
            this.panel1.Controls.Add(this.BTN_Save);
            this.panel1.Controls.Add(this.masked_FromDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.masked_ToDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TXT_No);
            this.panel1.Location = new System.Drawing.Point(26, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 86);
            this.panel1.TabIndex = 67;
            this.panel1.Visible = false;
            // 
            // LBL_OldSessionId
            // 
            this.LBL_OldSessionId.AutoSize = true;
            this.LBL_OldSessionId.Location = new System.Drawing.Point(299, 62);
            this.LBL_OldSessionId.Name = "LBL_OldSessionId";
            this.LBL_OldSessionId.Size = new System.Drawing.Size(13, 13);
            this.LBL_OldSessionId.TabIndex = 67;
            this.LBL_OldSessionId.Text = "0";
            this.LBL_OldSessionId.Visible = false;
            // 
            // Sessions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(473, 283);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GRD_Session);
            this.Name = "Sessions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فصول سیستم";
            this.Load += new System.EventHandler(this.Sessions_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sessions_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Session)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WinCSS.SaveButton BTN_Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_No;
        private System.Windows.Forms.MaskedTextBox masked_ToDate;
        private System.Windows.Forms.MaskedTextBox masked_FromDate;
        private System.Windows.Forms.DataGridView GRD_Session;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_OldSessionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessionNo;
        private System.Windows.Forms.DataGridViewButtonColumn BTN_Deactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
    }
}