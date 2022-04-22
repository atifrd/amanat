using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Amanat_UIS.Reports
{
    public partial class MoneyInSafe : Form
    {
        public MoneyInSafe()
        {
            InitializeComponent();
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.FormStyle(this);
         

        }
        private void MoneyInSafe_Load(object sender, EventArgs e)
        {
            SetFormStyles();
            try
            {
                TXT_Sum.Text=
               Amanat_BO.Helper.GetCurrencyFormat( Amanat_BO.SafeOPeration.GiveAndTake_MoneyInSafe(Convert.ToDateTime("12-12-1812")));
            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
        }

        private void MoneyInSafe_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);

        }
    }
}
