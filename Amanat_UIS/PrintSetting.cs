using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Amanat_UIS
{
    public partial class PrintSetting : Form
    {
        public PrintSetting()
        {
            InitializeComponent();
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.FormStyle(this);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] _font=TXT_Print_Font.Text.Split(';');
            fontDialog1.Font=new Font(_font[0],float.Parse(_font[1]), bool.Parse(_font[2])?FontStyle.Bold:FontStyle.Regular);
            fontDialog1.ShowColor = false;
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Font font = fontDialog1.Font;
                TXT_Print_Font.Text = string.Format("{0}",font.Name+";"+font.Size+";"+font.Bold);
                TXT_PrintTxt.Font=TXT_PageHeader.Font=TXT_OfficeTell.Font=TXT_Print_Font.Font = font;
                
            }
            
        }

        private void PrintSetting_Load(object sender, EventArgs e)
        {
            try
            {
                SetFormStyles();
                TXT_Print_Font.Text = Amanat_BO.UserSettings.Print_Font;
                TXT_PageHeader.Text = Amanat_BO.UserSettings.PageHeader;
                TXT_PrintTxt.Text = Amanat_BO.UserSettings.PrintTxt;
                TXT_OfficeTell.Text = Amanat_BO.UserSettings.OfficeTell;


                string[] _font = TXT_Print_Font.Text.Split(';');
                TXT_PageHeader.Font = TXT_Print_Font.Font = TXT_PrintTxt.Font = TXT_OfficeTell.Font = new Font(_font[0], float.Parse(_font[1]), bool.Parse(_font[2]) ? FontStyle.Bold : FontStyle.Regular);
                
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
            
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Amanat_BO.sysSetting.sysSetting_Change(TXT_PrintTxt.Text, TXT_OfficeTell.Text, TXT_PageHeader.Text,
                    TXT_Print_Font.Text);
                MessageBox.Show("ثبت با موفقیت انجام شد");
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
        }
    }
}
