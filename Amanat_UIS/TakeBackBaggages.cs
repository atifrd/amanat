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
    public partial class TakeBackBaggages : Form
    {
        public TakeBackBaggages()
        {
            InitializeComponent();
        }

        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.FormStyle(this);
            //customizedThemeObj.ReportGriedStyle(dataGridView1);

            string NowSession = Convert.ToString(Amanat_BO.UserSettings.SessionNo);
            if (NowSession.Trim() != "0")
            {
                LBL_Systemsession.Text = NowSession;
                LBL_SysSessionFullName.Text = " فصل جاری سیستم :" + NowSession;
            }
            else
            {
                MessageBox.Show(" لطفا فصل جدید تعریف کنید. فصل در سیستم تعریف نشده ویا فصل قبلی منقضی شده است ");
                
                Sessions sessionOb = new Sessions();
                sessionOb.Show();
                this.Close();
            }
        
        }
        private void TakeBackBaggages_Load(object sender, EventArgs e)
        {
            SetFormStyles();
        }
      
        

        private void SearchBtnPressed()
        {
            this.SerialNumberParam = LBL_Systemsession.Text+TXT_SerialNumber.Text.Trim();
            try
            {
                TakeBackBaggages_sabt TakeBackBaggages_sabtOBJ = new TakeBackBaggages_sabt();
                TakeBackBaggages_sabtOBJ.TakeBackBaggagesInstanse = this;
                //TakeBackBaggages_sabtOBJ.MdiParent = Form1.ActiveForm;
                TakeBackBaggages_sabtOBJ.ShowDialog();

            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
        }

        private void TakeBackBaggages_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);

                if (e.KeyCode == Keys.Control || e.KeyCode == Keys.N)
            {
                GoToNextSession();
               
            }
            else if (e.KeyCode == Keys.Control || e.KeyCode == Keys.P)
            {
                 Amanat_UIS.customizedTheme customizedThemeObj = new customizedTheme();
                GoToPrevioseSession();
               
            }
        }

        private void GoToPrevioseSession()
        {
            LBL_SysSessionFullName.Text = " فصل جاری سیستم :" + Amanat_BO.Systemsession.SystemSession_getpreviousSession(LBL_Systemsession.Text);
            LBL_Systemsession.Text = Amanat_BO.Systemsession.SystemSession_getpreviousSession(LBL_Systemsession.Text);
        }

        private void GoToNextSession()
        {
            LBL_SysSessionFullName.Text = " فصل جاری سیستم :" + Amanat_BO.Systemsession.SystemSession_getNextSession(LBL_Systemsession.Text);
            LBL_Systemsession.Text = Amanat_BO.Systemsession.SystemSession_getNextSession(LBL_Systemsession.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TXT_SerialNumber_Leave(object sender, EventArgs e)
        {
           
        }

        private void TXT_SerialNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == System.Windows.Forms.Keys.Enter)
            {
                try
                {
                    if (TXT_SerialNumber.Text != string.Empty)
                    {
                        SearchBtnPressed();
                        TXT_SerialNumber.Text = string.Empty;
                    }

                }
                catch (Exception ex)
                {
                    Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                    MessageBox.Show("");
                }
                
            }
        }

        private void TXT_SerialNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Previous_Click(object sender, EventArgs e)
        {
            GoToPrevioseSession();
        }

        private void pictureBox_Next_Click(object sender, EventArgs e)
        {
            GoToNextSession();
        }
    }
}
