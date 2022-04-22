namespace Amanat_UIS
{
    partial class Fish_list
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
            this.GRD_FishList = new System.Windows.Forms.DataGridView();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EGiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eexp_GiveBackDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Give = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_back = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuseFIeld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_FishList)).BeginInit();
            this.SuspendLayout();
            // 
            // GRD_FishList
            // 
            this.GRD_FishList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_FishList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.ESerialNumber,
            this.PTell,
            this.EGiveDate,
            this.Eexp_GiveBackDate,
            this.FullSerialNumber,
            this.statuse,
            this.User_Give,
            this.User_back,
            this.statuseFIeld});
            this.GRD_FishList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRD_FishList.Location = new System.Drawing.Point(0, 0);
            this.GRD_FishList.Margin = new System.Windows.Forms.Padding(10);
            this.GRD_FishList.Name = "GRD_FishList";
            this.GRD_FishList.Size = new System.Drawing.Size(1088, 396);
            this.GRD_FishList.TabIndex = 54;
            this.GRD_FishList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRD_FishList_CellDoubleClick);
            this.GRD_FishList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GRD_FishList_DataBindingComplete);
            this.GRD_FishList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GRD_FishList_KeyDown);
            // 
            // SerialNumber
            // 
            this.SerialNumber.DataPropertyName = "SerialNumber";
            this.SerialNumber.HeaderText = "سریال";
            this.SerialNumber.Name = "SerialNumber";
            // 
            // ESerialNumber
            // 
            this.ESerialNumber.DataPropertyName = "Person";
            this.ESerialNumber.HeaderText = "نام";
            this.ESerialNumber.Name = "ESerialNumber";
            this.ESerialNumber.Width = 150;
            // 
            // PTell
            // 
            this.PTell.DataPropertyName = "Ptell";
            this.PTell.HeaderText = "تلفن";
            this.PTell.Name = "PTell";
            this.PTell.Width = 150;
            // 
            // EGiveDate
            // 
            this.EGiveDate.HeaderText = "تاریخ دریافت";
            this.EGiveDate.Name = "EGiveDate";
            this.EGiveDate.Width = 170;
            // 
            // Eexp_GiveBackDate
            // 
            this.Eexp_GiveBackDate.HeaderText = "تاریخ تحویل ";
            this.Eexp_GiveBackDate.Name = "Eexp_GiveBackDate";
            this.Eexp_GiveBackDate.Width = 170;
            // 
            // FullSerialNumber
            // 
            this.FullSerialNumber.DataPropertyName = "FullSerialNumber";
            this.FullSerialNumber.HeaderText = "FullSerialNumber";
            this.FullSerialNumber.Name = "FullSerialNumber";
            this.FullSerialNumber.Visible = false;
            // 
            // statuse
            // 
            this.statuse.HeaderText = "وضعیت";
            this.statuse.Name = "statuse";
            // 
            // User_Give
            // 
            this.User_Give.DataPropertyName = "User_Give";
            this.User_Give.HeaderText = "تحویل گیرنده";
            this.User_Give.Name = "User_Give";
            this.User_Give.Width = 150;
            // 
            // User_back
            // 
            this.User_back.DataPropertyName = "User_back";
            this.User_back.HeaderText = "تحویل دهنده";
            this.User_back.Name = "User_back";
            this.User_back.Width = 150;
            // 
            // statuseFIeld
            // 
            this.statuseFIeld.DataPropertyName = "statuse";
            this.statuseFIeld.HeaderText = "Column1";
            this.statuseFIeld.Name = "statuseFIeld";
            this.statuseFIeld.Visible = false;
            // 
            // Fish_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 396);
            this.Controls.Add(this.GRD_FishList);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Fish_list";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نتایج جستجو";
            this.Load += new System.EventHandler(this.Fish_list_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fish_list_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GRD_FishList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public FishPrint FishPrintInstance;
        public string SerialNumParam;
        private System.Windows.Forms.DataGridView GRD_FishList;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTell;
        private System.Windows.Forms.DataGridViewTextBoxColumn EGiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eexp_GiveBackDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullSerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuse;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Give;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuseFIeld;
    }
}