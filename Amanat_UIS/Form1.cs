using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KM77.BLL;
using System.Drawing.Imaging;

namespace Amanat_UIS
{
    public partial class Form1 : Form
    {

       private MdiClient _f = null;
        Rectangle _r = new Rectangle();
        bool _loaded = false;

       

        public Form1()
        {
            count = 1;
            InitializeComponent();
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;

            this.IsMdiContainer = true;

            //this.Width *= 3;
            //this.Height *= 2;

           foreach (Control c in this.Controls)
            {
                try
                {
                    _f = (MdiClient)c;
                    break;
                }
                catch
                {

                }
            }


           _f.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

           _f.Paint += new PaintEventHandler(_f_Paint);
           // _f.Layout += new LayoutEventHandler(_f_Layout);

            //this.Shown += new EventHandler(Form1_Shown);
            //this.Load += new EventHandler(Form1_Load);

            //this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            
        }
      
         void _f_Paint(object sender, PaintEventArgs e)
        {
         
            if (_f != null)
            {
                Rectangle r = new Rectangle(0, 0, this.Width,this.Height);
                Image myImage = global::Amanat_UIS.Properties.Resources._2 ; 
                e.Graphics.DrawImage(myImage, r);      
            }
        }

         void _f_Layout(object sender, LayoutEventArgs e)
         {
             if (_f != null && _loaded)
             {
                 _r = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                 Graphics g = _f.CreateGraphics();
                 this.InvokePaint(_f, new PaintEventArgs(g, _r));
                 g.Dispose();
             }
         }

        private void button1_Click(object sender, EventArgs e)
        {

            Banks Form2obj = new Banks(); Form2obj.MdiParent = this;
            Form2obj.Show();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            Notify_expDate();
            this.LayoutMdi(MdiLayout.Cascade);
            //Amanat_BO.UserSettings.MaskedDate = "00 /00 /"+KM77.BLL.BLLDate.getPersianDate(System.DateTime.Now).Substring(6, 2)+"00";
            Amanat_BO.UserSettings.MaskedDate = "00 /00 /" + KM77.BLL.BLLDate.getPersianYear(System.DateTime.Now).Substring(0, 2) + "00";//bara sale 1400 be adam javab bede :)

            ToolStripMenuItemUsers.Enabled = Amanat_BO.UserSettings.isSuperVisor;

            Lbl_CurrentUser.Text = "کاربر سیستم :" + Amanat_BO.UserSettings.Name;
            if (Amanat_BO.Systemsession.SystemSession_SessionIsExpired(System.DateTime.Now))//akhare sal fasl ro mibande
            {
                MessageBox.Show("  فصل در سیستم تعریف نشده ویا فصل قبلی منقضی شده است ");
                Sessions sessionOb = new Sessions(); sessionOb.MdiParent = this;
                sessionOb.Show();
            }
            
            string ActivSession = Amanat_BO.Systemsession.SystemSession_getActiveSession(System.DateTime.Now);
            if (ActivSession.Trim() == string.Empty)
            {
               // MessageBox.Show(" لطفا فصل جدید تعریف کنید. فصل در سیستم تعریف نشده ویا فصل قبلی منقضی شده است ");
                LBL_Systemsession.Text = "            فصل جاری سیستم تعریف نشده ";
            }
            else
            {
                LBL_Systemsession.Text = "            فصل جاری :" + " " + ActivSession;
                Amanat_BO.UserSettings.SessionNo = Convert.ToInt16(ActivSession);
            }
            DataSet dsTax = Amanat_BO.Tax.Tax_GetActiveOne(System.DateTime.Now);
            if (dsTax.Tables[0].Rows.Count > 0)
            {
                Amanat_BO.UserSettings.TaxId = Convert.ToInt16(dsTax.Tables[0].Rows[0]["TaxId"]);
                Amanat_BO.UserSettings.TaxBurden = Convert.ToDecimal(dsTax.Tables[0].Rows[0]["TaxBurden"]);
            }
            else MessageBox.Show("میزان مالیات بر ارزش افزوده را تعیین کنید");
            timer1.Start();
            
        }

        private void Notify_expDate()
        {
            int day = 55;
            if (Amanat_BO.GiveAndTakes.GiveAndTake_ExistForSendToPolice(System.DateTime.Now.AddDays(-day)))
            {
                radDesktopAlert1.ContentImage = global::Amanat_UIS.Properties.Resources.Delay2;
                radDesktopAlert1.CaptionText = "";
                radDesktopAlert1.ContentText = "تعدادی از امانات بیش از" + " 3" + "روز از تاریخ تحویلشان گذشته.برای اطلاع به گزارش مربوطه مراجعه کنید";
                radDesktopAlert1.Show();
            }
        }


        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            
            customizedThemeObj.FormStyle(this);
            customizedThemeObj.ControlStyle(panel1);
        } 

     
        //--------------------------------------------------------------------------------------------------------
        private void MEnueItemBank_Click(object sender, EventArgs e)
        {
            Banks Form2obj = new Banks(); Form2obj.MdiParent = this;
            Form2obj.Show();
        }

        private void MEnueItemAccount_Click(object sender, EventArgs e)
        {
            Account accountobj = new Account(); accountobj.MdiParent = this;
            accountobj.Show();
        }

        private void MEnueItemBaggage_Price_Click(object sender, EventArgs e)
        {
            //this.MdiChildren = MdiChildren.All<Form>;
            Baggage_Prices Baggage_PricesObj = new Baggage_Prices();
            Baggage_PricesObj.MdiParent = this;
            Baggage_PricesObj.Show();
        }

        private void MEnueItemTake_Click(object sender, EventArgs e)
        {
            FormCollection fm = Application.OpenForms;

            TakeBaggages GiveAndTakeobj = new TakeBaggages();
            GiveAndTakeobj.MdiParent = this;
            foreach (Form item in fm)
            {
                if (item.Name == GiveAndTakeobj.Name) return;
            }
              GiveAndTakeobj.Show();
        }

        private void MEnueItemTakeBack_Click(object sender, EventArgs e)
        {
            TakeBackBaggages TakeBackBaggagesOBJ = new TakeBackBaggages(); TakeBackBaggagesOBJ.MdiParent = this;
            TakeBackBaggagesOBJ.Show();
            
        }

        private void MEnueItemPrintFish_Click(object sender, EventArgs e)
        {

        }

        private void ghgfhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SafeOPerationFRM SafeOPerationFRMOBJ = new SafeOPerationFRM(); SafeOPerationFRMOBJ.MdiParent = this;
            SafeOPerationFRMOBJ.Show();
        }

        private void MenueItemSendToPolice_Click(object sender, EventArgs e)
        {
            SendToPolice SendToPoliceobj = new SendToPolice(); SendToPoliceobj.MdiParent = this;
            SendToPoliceobj.Show();
 
        }
        #region ToolStrip
        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        #endregion

        private void toolStripButtonDaryaft_Click(object sender, EventArgs e)
        {
            FormCollection fm = Application.OpenForms;
            
            TakeBaggages GiveAndTakeobj = new TakeBaggages();
           GiveAndTakeobj.MdiParent = this;
            foreach (Form item in fm)
            {
                if (item.Name == GiveAndTakeobj.Name) return;
               
            }
             GiveAndTakeobj.Show();
        }

        private void toolStripButtonTahvil_Click(object sender, EventArgs e)
        {
            TakeBackBaggages TakeBackBaggagesOBJ = new TakeBackBaggages();
           TakeBackBaggagesOBJ.MdiParent = this;
            TakeBackBaggagesOBJ.Show();
        }

        private void toolStripButtonSafe_Click(object sender, EventArgs e)
        {
            SafeOPerationFRM SafeOPerationFRMOBJ = new SafeOPerationFRM(); SafeOPerationFRMOBJ.MdiParent = this;

            SafeOPerationFRMOBJ.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            PrintSetting PrintSettingob = new PrintSetting(); PrintSettingob.MdiParent = this;
            PrintSettingob.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Sessions sessionOb = new Sessions(); sessionOb.MdiParent = this;
            sessionOb.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FishPrint FishPrintObj = new FishPrint();
            FishPrintObj.MdiParent = this;
            FishPrintObj.Show();
        }

        private void toolStripButtonPassedDate_Click(object sender, EventArgs e)
        {
            Reports.DailyReport DailyReportOBJ = new Reports.DailyReport(); DailyReportOBJ.MdiParent = this;
            DailyReportOBJ.Show();
        }

        private void ToolStripMenuItemDailyReport_Click(object sender, EventArgs e)
        {
            Reports.DailyReport DailyReportOBJ = new Reports.DailyReport(); DailyReportOBJ.MdiParent = this;
            DailyReportOBJ.Show();
        }

        private void ToolStripMenuItemMonthly_Click(object sender, EventArgs e)
        {
            Reports.monthlyReport monthlyReportOBJ = new Reports.monthlyReport(); monthlyReportOBJ.MdiParent = this;
            monthlyReportOBJ.Show();
        }

        private void toolStripBtnMoneyInSafe_Click(object sender, EventArgs e)
        {
            Reports.MoneyInSafe MoneyInSafeObj = new Reports.MoneyInSafe(); MoneyInSafeObj.MdiParent = this;
            MoneyInSafeObj.Show();
        }

        private void ToolStripMenuItemoneyInSafe_Click(object sender, EventArgs e)
        {
            Reports.MoneyInSafe MoneyInSafeObj = new Reports.MoneyInSafe(); MoneyInSafeObj.MdiParent = this;
            MoneyInSafeObj.Show();
        }

        private void گزارشلیستعملیاتصندوقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.SafeOperationList SafeOperationListObj = new Reports.SafeOperationList(); SafeOperationListObj.MdiParent = this;
            SafeOperationListObj.Show();
        }

        private void ToolStripMenuItemSysDetails_Click(object sender, EventArgs e)
        {
            Reports.SystemDetails SystemDetailsObj = new Reports.SystemDetails(); SystemDetailsObj.MdiParent = this;
            SystemDetailsObj.Show();
        }
        // LBL_Timer.Text = BLLDate.getPersianDate(DateTime.Now) +" " + DateTime.Now.ToShortTimeString();
        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemUsers_Click(object sender, EventArgs e)
        {
            users usersobj = new users(); usersobj.MdiParent = this;
            usersobj.Show();
        }

        private void ToolStripMenuItemPassed_Click(object sender, EventArgs e)
        {
            Reports.SendToPolice_Report SendToPoliceobj = new Reports.SendToPolice_Report(); SendToPoliceobj.MdiParent = this;
            SendToPoliceobj.Show();
        }

        private void ToolStripMenuItemEbtal_Click(object sender, EventArgs e)
        {
            Reports.ReportEbtal ReportEbtalobj = new Reports.ReportEbtal(); ReportEbtalobj.MdiParent = this;
            ReportEbtalobj.Show();
        }

        private void ToolStripMenuItemTax_Click(object sender, EventArgs e)
        {
            Tax TaxObj = new Tax(); TaxObj.MdiParent = this;
            TaxObj.Show();

        }

        private void ToolStripMenuItemAnnual_Click(object sender, EventArgs e)
        {
            Reports.annual AnnualObj = new Reports.annual(); AnnualObj.MdiParent = this;
            AnnualObj.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (_backBmp != null)
              //  _backBmp.Dispose();

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           // _loaded = true;

        }
        int count;
        Form mdiChild;
        TextBox editTextBox;
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            mdiChild = new Form();
            mdiChild.Text = "Document" + count.ToString();
            mdiChild.MdiParent = this;
            editTextBox = new TextBox();
            editTextBox.Multiline = true;
            editTextBox.Dock = DockStyle.Fill;
            mdiChild.Controls.Add(editTextBox);
            mdiChild.Show();
            count++;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Open a Text File";
            ofd.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";

            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);

                Form activeChildForm = this.ActiveMdiChild;

                if (activeChildForm != null)
                {
                    TextBox activeTextBox = (TextBox)activeChildForm.ActiveControl;

                    if (activeTextBox != null)
                        activeTextBox.Text = sr.ReadToEnd();

                    sr.Close();
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Save a Text File";
            sfd.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";

            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);

                Form activeChildForm = this.ActiveMdiChild;

                if (activeChildForm != null)
                {
                    TextBox activeTextBox = (TextBox)activeChildForm.ActiveControl;

                    if (activeTextBox != null)
                        sw.Write(activeTextBox.Text);

                    sw.Close();
                }
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            Form activeChildForm = this.ActiveMdiChild;

            if (activeChildForm != null)
            {
                TextBox activeTextBox = (TextBox)activeChildForm.ActiveControl;
                if (activeTextBox != null)
                    activeTextBox.Cut();
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            Form activeChildForm = this.ActiveMdiChild;

            if (activeChildForm != null)
            {
                TextBox activeTextBox = (TextBox)activeChildForm.ActiveControl;
                if (activeTextBox != null)
                    activeTextBox.Copy();
            }
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            Form activeChildForm = this.ActiveMdiChild;

            if (activeChildForm != null)
            {
                TextBox activeTextBox = (TextBox)activeChildForm.ActiveControl;
                if (activeTextBox != null)
                    activeTextBox.Paste();
            }
        }

        private void ToolStripMenuItemSession_Click(object sender, EventArgs e)
        {
            Sessions sessionOb = new Sessions(); sessionOb.MdiParent = this;
            sessionOb.Show();
        }

        private void StripMenuItem_EditList_Click(object sender, EventArgs e)
        {
            Reports.EditList EditListobj = new Reports.EditList(); EditListobj.MdiParent = this;
            EditListobj.Show();

        }

        private void ToolStripMenuItemBackup_Click(object sender, EventArgs e)
        {
            BackUpForm BackUpFormOb = new BackUpForm(); BackUpFormOb.MdiParent = this;
            BackUpFormOb.Show();
        }

        private void BackuptoolStripButton_Click(object sender, EventArgs e)
        {
            BackUpForm BackUpFormOb = new BackUpForm(); BackUpFormOb.MdiParent = this;
            BackUpFormOb.Show();
        }
        
        private void helpToolStripButton_Click_1(object sender, EventArgs e)
        {
            string s2 = System.Configuration.ConfigurationSettings.AppSettings["logPath"].ToString().Trim();
            System.IO.StreamReader sr = new System.IO.StreamReader(s2);
            sr.ReadToEnd();
            
        }
    }
}
