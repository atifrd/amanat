namespace Amanat_UIS.Reports
{
    partial class MoneyInSafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneyInSafe));
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Sum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // TXT_Sum
            // 
            this.TXT_Sum.ForeColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.TXT_Sum, "TXT_Sum");
            this.TXT_Sum.Name = "TXT_Sum";
            this.TXT_Sum.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Name = "label2";
            // 
            // MoneyInSafe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_Sum);
            this.Controls.Add(this.label1);
            this.Name = "MoneyInSafe";
            this.Load += new System.EventHandler(this.MoneyInSafe_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoneyInSafe_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Sum;
        private System.Windows.Forms.Label label2;
    }
}