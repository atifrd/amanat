namespace Amanat_UIS
{
    partial class users
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
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxpermissive = new System.Windows.Forms.ComboBox();
            this.buttonSave = new WinCSS.SaveButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxPassConfirm = new System.Windows.Forms.TextBox();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.TXT_UserName = new System.Windows.Forms.TextBox();
            this.TXT_Family = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewuSers = new System.Windows.Forms.DataGridView();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.permissiveImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewuSers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxpermissive);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextBoxPassConfirm);
            this.groupBox1.Controls.Add(this.TextBoxPass);
            this.groupBox1.Controls.Add(this.TXT_UserName);
            this.groupBox1.Controls.Add(this.TXT_Family);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "دسترسی";
            // 
            // comboBoxpermissive
            // 
            this.comboBoxpermissive.FormattingEnabled = true;
            this.comboBoxpermissive.Location = new System.Drawing.Point(165, 139);
            this.comboBoxpermissive.Name = "comboBoxpermissive";
            this.comboBoxpermissive.Size = new System.Drawing.Size(121, 30);
            this.comboBoxpermissive.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(9, 142);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 50);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "ثبت";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "تکرار رمز ورود";
            // 
            // TextBoxPassConfirm
            // 
            this.TextBoxPassConfirm.Location = new System.Drawing.Point(55, 108);
            this.TextBoxPassConfirm.Name = "TextBoxPassConfirm";
            this.TextBoxPassConfirm.Size = new System.Drawing.Size(231, 30);
            this.TextBoxPassConfirm.TabIndex = 3;
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(55, 77);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(231, 30);
            this.TextBoxPass.TabIndex = 2;
            // 
            // TXT_UserName
            // 
            this.TXT_UserName.Location = new System.Drawing.Point(55, 45);
            this.TXT_UserName.Name = "TXT_UserName";
            this.TXT_UserName.Size = new System.Drawing.Size(231, 30);
            this.TXT_UserName.TabIndex = 1;
            // 
            // TXT_Family
            // 
            this.TXT_Family.Location = new System.Drawing.Point(55, 14);
            this.TXT_Family.Name = "TXT_Family";
            this.TXT_Family.Size = new System.Drawing.Size(231, 30);
            this.TXT_Family.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام کاربر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "شناسه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "رمز ورود";
            // 
            // dataGridViewuSers
            // 
            this.dataGridViewuSers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewuSers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.family,
            this.BTN_Delete,
            this.permissiveImage,
            this.UserId,
            this.permissive});
            this.dataGridViewuSers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewuSers.Location = new System.Drawing.Point(0, 204);
            this.dataGridViewuSers.Name = "dataGridViewuSers";
            this.dataGridViewuSers.Size = new System.Drawing.Size(413, 176);
            this.dataGridViewuSers.TabIndex = 1;
            this.dataGridViewuSers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewuSers_CellContentClick);
            this.dataGridViewuSers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewuSers_DataBindingComplete);
            // 
            // family
            // 
            this.family.DataPropertyName = "family";
            this.family.HeaderText = "کاربر";
            this.family.Name = "family";
            this.family.Width = 180;
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.HeaderText = "";
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BTN_Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BTN_Delete.Width = 150;
            // 
            // permissiveImage
            // 
            this.permissiveImage.HeaderText = "";
            this.permissiveImage.Name = "permissiveImage";
            this.permissiveImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.permissiveImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.permissiveImage.Width = 24;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.Visible = false;
            // 
            // permissive
            // 
            this.permissive.DataPropertyName = "permissive";
            this.permissive.HeaderText = "permissive";
            this.permissive.Name = "permissive";
            this.permissive.Visible = false;
            // 
            // users
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(413, 380);
            this.Controls.Add(this.dataGridViewuSers);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Name = "users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گروه کاربران";
            this.Load += new System.EventHandler(this.users_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.users_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewuSers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxPassConfirm;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.TextBox TXT_UserName;
        private System.Windows.Forms.TextBox TXT_Family;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewuSers;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private WinCSS.SaveButton buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxpermissive;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewButtonColumn BTN_Delete;
        private System.Windows.Forms.DataGridViewImageColumn permissiveImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissive;
    }
}