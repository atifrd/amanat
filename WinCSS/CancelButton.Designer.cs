namespace WinCSS
{
    partial class CancelButton
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::WinCSS.Properties.Resources._09;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Size = new System.Drawing.Size(122, 40);
            this.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);

        }

        #endregion
        /// <summary>
        /// hi
        /// </summary>
        public override System.Drawing.Image BackgroundImage
        {
            get
            {
                return global::WinCSS.Properties.Resources._09;
            }
           
        }
        public override System.Drawing.Color ForeColor
        {
            get { return System.Drawing.Color.Transparent; }

        }

        //public override System.Drawing.Size Size
        //{
        //    get
        //    {
        //        return new System.Drawing.Size(122, 40);
        //    }
        //    private set { }
        //}
    
    }
}
