namespace Amanat_UIS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.TXT_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoggin = new WinCSS.SaveButton();
            this.SuspendLayout();
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(106, 82);
            this.TextBoxPass.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(289, 30);
            this.TextBoxPass.TabIndex = 2;
            this.TextBoxPass.UseSystemPasswordChar = true;
            // 
            // TXT_UserName
            // 
            this.TXT_UserName.Location = new System.Drawing.Point(106, 21);
            this.TXT_UserName.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.TXT_UserName.Name = "TXT_UserName";
            this.TXT_UserName.Size = new System.Drawing.Size(289, 30);
            this.TXT_UserName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(348, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "شناسه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("IRYekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(335, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "رمز ورود";
            // 
            // btnLoggin
            // 
            this.btnLoggin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoggin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoggin.BackgroundImage")));
            this.btnLoggin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoggin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoggin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoggin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoggin.Location = new System.Drawing.Point(106, 120);
            this.btnLoggin.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnLoggin.Name = "btnLoggin";
            this.btnLoggin.Size = new System.Drawing.Size(98, 32);
            this.btnLoggin.TabIndex = 3;
            this.btnLoggin.Text = "ورود";
            this.btnLoggin.UseVisualStyleBackColor = false;
            this.btnLoggin.Click += new System.EventHandler(this.btnLoggin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Amanat_UIS.Properties.Resources.imagesCAGBKB22;
            this.ClientSize = new System.Drawing.Size(403, 166);
            this.ControlBox = false;
            this.Controls.Add(this.btnLoggin);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TXT_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ورود به سیستم";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.TextBox TXT_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private WinCSS.SaveButton btnLoggin;
        public int UserId;
    }
}