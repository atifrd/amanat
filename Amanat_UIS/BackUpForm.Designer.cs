namespace Amanat_UIS
{
    partial class BackUpForm
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
            this.GRD_Backup = new System.Windows.Forms.DataGridView();
            this.BackupPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackupDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBL_FromDate = new System.Windows.Forms.Label();
            this.maskedDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTime = new System.Windows.Forms.MaskedTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFile = new WinCSS.SaveButton();
            this.TXT_BackupPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Description = new System.Windows.Forms.TextBox();
            this.BTN_Save = new WinCSS.SaveButton();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Backup)).BeginInit();
            this.SuspendLayout();
            // 
            // GRD_Backup
            // 
            this.GRD_Backup.CausesValidation = false;
            this.GRD_Backup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_Backup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BackupPath,
            this.Description,
            this.BackupDateTime});
            this.GRD_Backup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GRD_Backup.Location = new System.Drawing.Point(0, 212);
            this.GRD_Backup.Name = "GRD_Backup";
            this.GRD_Backup.Size = new System.Drawing.Size(644, 199);
            this.GRD_Backup.TabIndex = 9;
            // 
            // BackupPath
            // 
            this.BackupPath.DataPropertyName = "BackupPath";
            this.BackupPath.HeaderText = "فایل پشتیان";
            this.BackupPath.Name = "BackupPath";
            this.BackupPath.Width = 250;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "شرح";
            this.Description.Name = "Description";
            this.Description.Width = 200;
            // 
            // BackupDateTime
            // 
            this.BackupDateTime.DataPropertyName = "BackupDateTime";
            this.BackupDateTime.HeaderText = "تاریخ";
            this.BackupDateTime.Name = "BackupDateTime";
            this.BackupDateTime.Width = 150;
            // 
            // LBL_FromDate
            // 
            this.LBL_FromDate.AutoSize = true;
            this.LBL_FromDate.Location = new System.Drawing.Point(585, 2);
            this.LBL_FromDate.Name = "LBL_FromDate";
            this.LBL_FromDate.Size = new System.Drawing.Size(57, 22);
            this.LBL_FromDate.TabIndex = 35;
            this.LBL_FromDate.Text = "تاریخ :";
            // 
            // maskedDate
            // 
            this.maskedDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.maskedDate.Location = new System.Drawing.Point(438, 29);
            this.maskedDate.Margin = new System.Windows.Forms.Padding(4);
            this.maskedDate.Mask = "00 /00 /1000";
            this.maskedDate.Name = "maskedDate";
            this.maskedDate.ReadOnly = true;
            this.maskedDate.Size = new System.Drawing.Size(116, 30);
            this.maskedDate.TabIndex = 62;
            // 
            // maskedTime
            // 
            this.maskedTime.BackColor = System.Drawing.Color.LightSteelBlue;
            this.maskedTime.Location = new System.Drawing.Point(556, 29);
            this.maskedTime.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTime.Mask = "00:00";
            this.maskedTime.Name = "maskedTime";
            this.maskedTime.ReadOnly = true;
            this.maskedTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTime.Size = new System.Drawing.Size(88, 30);
            this.maskedTime.TabIndex = 63;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(611, 89);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(32, 30);
            this.btnFile.TabIndex = 64;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // TXT_BackupPath
            // 
            this.TXT_BackupPath.Location = new System.Drawing.Point(177, 89);
            this.TXT_BackupPath.Name = "TXT_BackupPath";
            this.TXT_BackupPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXT_BackupPath.Size = new System.Drawing.Size(432, 30);
            this.TXT_BackupPath.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 66;
            this.label1.Text = "مسیر ذخیره سازی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 67;
            this.label2.Text = "شرح";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXT_Description
            // 
            this.TXT_Description.Location = new System.Drawing.Point(177, 149);
            this.TXT_Description.Name = "TXT_Description";
            this.TXT_Description.Size = new System.Drawing.Size(466, 30);
            this.TXT_Description.TabIndex = 68;
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(51, 169);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_Save.Size = new System.Drawing.Size(100, 35);
            this.BTN_Save.TabIndex = 69;
            this.BTN_Save.Text = "ثبت";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.TXT_Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_BackupPath);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.maskedTime);
            this.Controls.Add(this.maskedDate);
            this.Controls.Add(this.LBL_FromDate);
            this.Controls.Add(this.GRD_Backup);
            this.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "BackUpForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "نسخه پشتیبان";
            this.Load += new System.EventHandler(this.BackUpForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackUpForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Backup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GRD_Backup;
        private System.Windows.Forms.Label LBL_FromDate;
        private System.Windows.Forms.MaskedTextBox maskedDate;
        private System.Windows.Forms.MaskedTextBox maskedTime;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private WinCSS.SaveButton btnFile;
        private System.Windows.Forms.TextBox TXT_BackupPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Description;
        private WinCSS.SaveButton BTN_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackupPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackupDateTime;
    }
}