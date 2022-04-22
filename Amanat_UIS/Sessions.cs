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
    public partial class Sessions : Form
    {
        public Sessions()
        {
            InitializeComponent();
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.FormStyle(this);
            customizedThemeObj.ReportGriedStyle(GRD_Session);

        }
        DataSet ds;
        private void LoadInfo()
        {
            DataGridViewButtonColumn btn = ((DataGridViewButtonColumn)(GRD_Session.Columns["BTN_Deactive"])); btn.Text = "بستن سال مالی"; btn.ToolTipText = "dsfsdf";

            ds = Amanat_BO.Systemsession.SystemSession_SelectAll();
            GRD_Session.DataSource = ds.Tables[0];

        }


        private void Sessions_Load(object sender, EventArgs e)
        {

            SetFormStyles();
            LoadInfo();
            if (GRD_Session.Rows.Count == 0 || Amanat_BO.Systemsession.SystemSession_SessionIsExpired(System.DateTime.Now))//we dont have active session or we dont have session at all
            {
                String Year = BLLDate.getPersianYear(System.DateTime.Now).ToString();
                CreateNewSession_PreRequirement(Year + "1", 0);
                panel1.Visible = true;
            }
        }

        private void Sessions_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            Int16 IsAllowed = 0;
            try
            {
                IsAllowed = Amanat_BO.Systemsession.SystemSession_MakeDeactiveOldOne_CreateNewOne(Convert.ToInt32(LBL_OldSessionId.Text), System.DateTime.Now, BLLDate.getGregorianDate(masked_FromDate.Text.Remove(2, 1).Remove(5, 1)),
                     BLLDate.getGregorianDate(masked_ToDate.Text.Remove(2, 1).Remove(5, 1)), Convert.ToInt16(TXT_No.Text), 1);//Amanat_BO.UserSettings.UserID

                LoadInfo();
                panel1.Visible = false; LBL_OldSessionId.Text = "0";
                string _message = IsAllowed == 1 ? "ثبت با موفقیت انجام شد" : "شماره فصل تکراری است ویا تاریخ صحیح نیست";
                MessageBox.Show(_message);
                // Form1_Load( sender,  e);

            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
        }
        public delegate void MyEventHandler(object sender, EventArgs e);
        public event MyEventHandler Form1_Load;

        private void TXT_No_Validating(object sender, CancelEventArgs e)
        {
            if (Amanat_BO.Validating.txtNumericStringIsValid(TXT_No.Text))
            {
                errorProvider1.SetError(TXT_No, "شماره فصل را صحیح وارد کنید");
                e.Cancel = true;
            }
            else errorProvider1.SetError(TXT_No, "");
        }
        private bool NewSessionRestriction(string SessionNo, out string message)
        {
            //string Message=string.Empty;
            if (SessionNo == "9")
            {
                message = "امکان تعریف بیش از 9 فصل در یک سال وجود ندارد";
                return false;
            }
            message = string.Empty;
            return true;

        }
        private void GRD_Baggage_Price_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int k = e.RowIndex;
            DataGridViewRow CurrentRow = GRD_Session.Rows[e.RowIndex];
            try
            {
                if (e.ColumnIndex == GRD_Session.Columns["BTN_Deactive"].Index && Convert.ToBoolean(CurrentRow.Cells["Active"].Value))
                {
                    string message = string.Empty;
                    //1400 Problem
                    //if (!NewSessionRestriction(Convert.ToString(CurrentRow.Cells["SessionNo"].Value).Substring(2, 1),out message))
                    if (!NewSessionRestriction(Convert.ToString(CurrentRow.Cells["SessionNo"].Value).Substring(4, 1), out message))
                    {
                        MessageBox.Show(message); return;
                    }


                    if (MessageBox.Show("آیا از بستن فصل جاری اطمینان دارید؟ تاریخ شروع فصل جدید از فردا خواهد بود", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        panel1.Visible = true;
                        // Panel floater = Amanat_BO.Helper.CreateFloatingPanel(panel1,this);
                        // floater.BackColor = Color.White;
                        //ListView lv = new ListView();
                        //floater.Controls.Add(lv);

                        CreateNewSession_PreRequirement((Convert.ToInt32(CurrentRow.Cells["SessionNo"].Value) + 1).ToString(),
                            Convert.ToInt32(CurrentRow.Cells["SessionId"].Value));
                    }
                }
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
            }
        }

        private void CreateNewSession_PreRequirement(string SessionNoParameter, int OldSessionId)
        {
            LBL_OldSessionId.Text = OldSessionId.ToString().Trim();
            String Year = BLLDate.getPersianYear(System.DateTime.Now);   //Substring(6, 4);
            int AfterNDays;
            if (OldSessionId == 0) AfterNDays = 0;
            else AfterNDays = 1;
            masked_FromDate.Text = BLLDate.getPersianDate(BLLDate.GetDateAfterNDays(System.DateTime.Now, AfterNDays), true);
            string day = BLLDate.IsPersianLeapYear(int.Parse(Year)) ? "30" : "29";
            //1400 Problem
            //masked_ToDate.Text = day + "/" + "12/" + Year.Substring(2, 2);
            masked_ToDate.Text = day + "/" + "12/" + Year.Substring(1, 3);

            //1400 Problem
            //if (Year.Substring(2, 2) == SessionNoParameter.Substring(0, 2))
            if (Year == SessionNoParameter.Substring(0, 4))
                TXT_No.Text = SessionNoParameter;
            else TXT_No.Text = Year + "1";
            //1400 Problem
            //else TXT_No.Text = Year.substring(2,2) + "1";

        }

        private void GRD_Session_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                GRD_Session.Rows[i].Cells["FromDate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["FromDate"]), false);
                GRD_Session.Rows[i].Cells["ToDate"].Value = KM77.BLL.BLLDate.getPersianDate(Convert.ToDateTime(ds.Tables[0].Rows[i]["ToDate"]), false);


                if (Convert.ToBoolean(ds.Tables[0].Rows[i]["Active"]))
                    GRD_Session.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                ((DataGridViewButtonCell)(GRD_Session.Rows[i].Cells["BTN_Deactive"])).Value = "بستن فصل";

            }
            // 
        }



    }
}
