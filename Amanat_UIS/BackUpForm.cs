using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KM77.BLL;

namespace Amanat_UIS
{
    public partial class BackUpForm : Form
    {
        public BackUpForm()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK && folderBrowserDialog1.SelectedPath!=null)
            {
                TXT_BackupPath.Text=folderBrowserDialog1.SelectedPath+"\\Amanat"+maskedTime.Text.Replace(':','-')+" "+maskedDate.Text.Replace('/','-')+".Bak";
            }
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.ReportGriedStyle(GRD_Backup);
            customizedThemeObj.FormStyle(this);
        }

        private void ResetForm()
        {
            maskedTime.Text = System.DateTime.Now.TimeOfDay.ToString();
            maskedDate.Text = BLLDate.getPersianDate(System.DateTime.Now.Date, true);
            TXT_BackupPath.Text = string.Empty;
            TXT_Description.Text = string.Empty;
        }
        private void BackUpForm_Load(object sender, EventArgs e)
        {
            SetFormStyles();
            getList();
            ResetForm();
        }

        private void BackUpForm_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
            if (e.KeyCode == Keys.Insert)
            {
                BTN_Save_Click(sender, e);
            }
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Amanat_BO.BackUp.SysBackup_Insert(TXT_Description.Text, maskedDate.Text + " " + maskedTime.Text, TXT_BackupPath.Text);
                Amanat_BO.BackUp.BackupDatabase(TXT_BackupPath.Text);
                getList();
                ResetForm();
                MessageBox.Show("عملیات با موفقیت انجام شد ");
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
          
        }
        private void getList()
        {
            try
            {
                DataSet ds=
                Amanat_BO.BackUp.SysBackup_GetList();
                GRD_Backup.DataSource = ds.Tables[0];
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
