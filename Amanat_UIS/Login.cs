using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Amanat_UIS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            //if (DateTime.Now > DateTime.Parse("2023/11/23"))
            //    return;

            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            UTF8Encoding encoder = new UTF8Encoding();
            byte[] pass = encoder.GetBytes(TextBoxPass.Text);
            DataSet ds=
            Amanat_BO.AmanatUsers.AmanatUsers_Loggin(TXT_UserName.Text.Trim(),pass);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Amanat_BO.UserSettings.UserID = Convert.ToInt32(ds.Tables[0].Rows[0]["UserId"]);
                Amanat_BO.UserSettings.Name = Convert.ToString(ds.Tables[0].Rows[0]["family"]);
                Amanat_BO.UserSettings.isSuperVisor = Convert.ToBoolean(ds.Tables[0].Rows[0]["permissive"]);

                DataSet dsSetting= Amanat_BO.sysSetting.sysSetting_Load();
                if (dsSetting.Tables[0].Rows.Count > 0)
                {
                    Amanat_BO.UserSettings.PageHeader = Convert.ToString(dsSetting.Tables[0].Rows[0]["PageHeader"]);
                    Amanat_BO.UserSettings.PrintTxt = Convert.ToString(dsSetting.Tables[0].Rows[0]["PrintTxt"]);
                    Amanat_BO.UserSettings.OfficeTell = Convert.ToString(dsSetting.Tables[0].Rows[0]["OfficeTell"]);
                    Amanat_BO.UserSettings.Print_Font = Convert.ToString(dsSetting.Tables[0].Rows[0]["Print_Font"]);
                }

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
             

    
        
        }
        private void SetFormStyles()
        {
            TXT_UserName.Focus();
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.FormStyle(this);
        }
        private void Login_Load(object sender, EventArgs e)
        {
            SetFormStyles(); 
            System.Globalization.CultureInfo lan = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(lan);
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
        }
    }
}
