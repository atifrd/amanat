namespace Amanat_UIS
{
    partial class TakeBackBaggages
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_SerialNumber = new System.Windows.Forms.TextBox();
            this.LBL_Systemsession = new System.Windows.Forms.Label();
            this.LBL_SysSessionFullName = new System.Windows.Forms.Label();
            this.pictureBox_Next = new System.Windows.Forms.PictureBox();
            this.pictureBox_Previous = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Previous)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_SerialNumber);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(438, 75);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "شماره سریال";
            // 
            // TXT_SerialNumber
            // 
            this.TXT_SerialNumber.Location = new System.Drawing.Point(17, 22);
            this.TXT_SerialNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TXT_SerialNumber.Name = "TXT_SerialNumber";
            this.TXT_SerialNumber.Size = new System.Drawing.Size(285, 30);
            this.TXT_SerialNumber.TabIndex = 0;
            this.TXT_SerialNumber.TextChanged += new System.EventHandler(this.TXT_SerialNumber_TextChanged);
            this.TXT_SerialNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_SerialNumber_KeyDown);
            this.TXT_SerialNumber.Leave += new System.EventHandler(this.TXT_SerialNumber_Leave);
            // 
            // LBL_Systemsession
            // 
            this.LBL_Systemsession.AutoSize = true;
            this.LBL_Systemsession.Location = new System.Drawing.Point(0, 0);
            this.LBL_Systemsession.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LBL_Systemsession.Name = "LBL_Systemsession";
            this.LBL_Systemsession.Size = new System.Drawing.Size(43, 22);
            this.LBL_Systemsession.TabIndex = 1;
            this.LBL_Systemsession.Text = "sess";
            this.LBL_Systemsession.Visible = false;
            // 
            // LBL_SysSessionFullName
            // 
            this.LBL_SysSessionFullName.AutoSize = true;
            this.LBL_SysSessionFullName.ForeColor = System.Drawing.Color.DarkGreen;
            this.LBL_SysSessionFullName.Location = new System.Drawing.Point(27, 3);
            this.LBL_SysSessionFullName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LBL_SysSessionFullName.Name = "LBL_SysSessionFullName";
            this.LBL_SysSessionFullName.Size = new System.Drawing.Size(88, 22);
            this.LBL_SysSessionFullName.TabIndex = 1;
            this.LBL_SysSessionFullName.Text = "تعریف نشده";
            this.LBL_SysSessionFullName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox_Next
            // 
            this.pictureBox_Next.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Next.Image = global::Amanat_UIS.Properties.Resources.Actions_arrow_left_icon1;
            this.pictureBox_Next.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Next.Name = "pictureBox_Next";
            this.pictureBox_Next.Size = new System.Drawing.Size(24, 27);
            this.pictureBox_Next.TabIndex = 59;
            this.pictureBox_Next.TabStop = false;
            this.pictureBox_Next.Click += new System.EventHandler(this.pictureBox_Next_Click);
            // 
            // pictureBox_Previous
            // 
            this.pictureBox_Previous.AccessibleDescription = "";
            this.pictureBox_Previous.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_Previous.Image = global::Amanat_UIS.Properties.Resources.Actions_arrow_right_icon1;
            this.pictureBox_Previous.Location = new System.Drawing.Point(225, 0);
            this.pictureBox_Previous.Name = "pictureBox_Previous";
            this.pictureBox_Previous.Size = new System.Drawing.Size(24, 27);
            this.pictureBox_Previous.TabIndex = 60;
            this.pictureBox_Previous.TabStop = false;
            this.pictureBox_Previous.Click += new System.EventHandler(this.pictureBox_Previous_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox_Previous);
            this.panel1.Controls.Add(this.pictureBox_Next);
            this.panel1.Controls.Add(this.LBL_SysSessionFullName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 27);
            this.panel1.TabIndex = 59;
            // 
            // TakeBackBaggages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 102);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBL_Systemsession);
            this.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TakeBackBaggages";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تحویل امانت به مشتری";
            this.Load += new System.EventHandler(this.TakeBackBaggages_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TakeBackBaggages_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Previous)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public string SerialNumberParam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_SerialNumber;
        private System.Windows.Forms.Label LBL_Systemsession;
        private System.Windows.Forms.Label LBL_SysSessionFullName;
        private System.Windows.Forms.PictureBox pictureBox_Next;
        private System.Windows.Forms.PictureBox pictureBox_Previous;
        private System.Windows.Forms.Panel panel1;
       
    }
}
