namespace Amanat_UIS
{
    partial class PrintSetting
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.buttonFont = new WinCSS.SaveButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_PrintTxt = new System.Windows.Forms.RichTextBox();
            this.TXT_OfficeTell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_PageHeader = new System.Windows.Forms.TextBox();
            this.BTN_Save = new WinCSS.SaveButton();
            this.TXT_Print_Font = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowApply = true;
            this.fontDialog1.ShowEffects = false;
            // 
            // buttonFont
            // 
            this.buttonFont.AutoSize = true;
            this.buttonFont.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFont.Location = new System.Drawing.Point(143, 312);
            this.buttonFont.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(52, 42);
            this.buttonFont.TabIndex = 0;
            this.buttonFont.Text = "...";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(716, 322);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "فونت";
            // 
            // TXT_PrintTxt
            // 
            this.TXT_PrintTxt.Location = new System.Drawing.Point(35, 85);
            this.TXT_PrintTxt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TXT_PrintTxt.Name = "TXT_PrintTxt";
            this.TXT_PrintTxt.Size = new System.Drawing.Size(675, 183);
            this.TXT_PrintTxt.TabIndex = 4;
            this.TXT_PrintTxt.Text = "";
            // 
            // TXT_OfficeTell
            // 
            this.TXT_OfficeTell.Location = new System.Drawing.Point(196, 281);
            this.TXT_OfficeTell.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TXT_OfficeTell.Name = "TXT_OfficeTell";
            this.TXT_OfficeTell.Size = new System.Drawing.Size(513, 30);
            this.TXT_OfficeTell.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "متن توضیحات(حداکثر 5 خط)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(723, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "هدر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(724, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "تلفن";
            // 
            // TXT_PageHeader
            // 
            this.TXT_PageHeader.Location = new System.Drawing.Point(33, 10);
            this.TXT_PageHeader.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TXT_PageHeader.Name = "TXT_PageHeader";
            this.TXT_PageHeader.Size = new System.Drawing.Size(675, 30);
            this.TXT_PageHeader.TabIndex = 9;
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(8, 365);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(138, 56);
            this.BTN_Save.TabIndex = 10;
            this.BTN_Save.Text = "ثبت";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // TXT_Print_Font
            // 
            this.TXT_Print_Font.Location = new System.Drawing.Point(196, 316);
            this.TXT_Print_Font.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TXT_Print_Font.Name = "TXT_Print_Font";
            this.TXT_Print_Font.Size = new System.Drawing.Size(513, 30);
            this.TXT_Print_Font.TabIndex = 11;
            // 
            // PrintSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 429);
            this.Controls.Add(this.TXT_Print_Font);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.TXT_PageHeader);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_OfficeTell);
            this.Controls.Add(this.TXT_PrintTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFont);
            this.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "PrintSetting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "PrintSetting";
            this.Load += new System.EventHandler(this.PrintSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private WinCSS.SaveButton buttonFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TXT_PrintTxt;
        private System.Windows.Forms.TextBox TXT_OfficeTell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_PageHeader;
        private WinCSS.SaveButton BTN_Save;
        private System.Windows.Forms.TextBox TXT_Print_Font;
    }
}