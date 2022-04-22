using System.Drawing;
namespace WinCSS
{
    partial class CommonLable
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
            // CommonLable
            // 
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.ResumeLayout(false);

        }


        #endregion
        /// <summary>
        /// vase in override mikonim ke red only beshan yani set{} nadashte bashan
        /// dar gheire in soorat vaghti am controli ke ghablan gozashtim font ya .... jadid ro nemigire
        /// </summary>
        public override Font Font
        {
            get
            {
                return new System.Drawing.Font("Times New Roman", 14.25F,
                           System.Drawing.FontStyle.Regular,
                           System.Drawing.GraphicsUnit.Point,
                           ((System.Byte)(0)));
            }
        }

        public override Color ForeColor
        {
            get
            {
                return System.Drawing.Color.Red;
            }
        }
        //in font o .... ro mishe bezarim too <appsetting>add key="ErrorLabelForeColorR" value="0" />
        /// <add key="ErrorLabelForeColorG" value="0" />   va bad ba ConfigurationSettings.AppSettings[""] bekhoonimeshoon

    }
}
