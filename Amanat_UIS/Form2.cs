using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Amanat_UIS
{
    public partial class Form2 : Form
    {

      

        public Form2()
        {
            
            InitializeComponent();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView h = new DataGridView();
            this.Controls.Add(h);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            
            customizedThemeObj.FormStyle(this);
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            //if (textBox1.Text.Length == 0)
            //{
            //    errorProvider1.SetError(textBox1, "please");
            //    e.Cancel=true;
            //}
            //else errorProvider1.SetError(textBox1, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataSet ds = Amanat_BO.Bank.Bank_SelectAll();
            stiReport1.RegData("Datasource1", ds.Tables[0]);
            stiReport1.Dictionary.Synchronize();
            stiReport1.Show();


            PrinterSettings printerSettings = new PrinterSettings();
            printerSettings.Copies = 1;
            printerSettings.FromPage = 1;
            printerSettings.ToPage = stiReport1.RenderedPages.Count;
            //Direct Print - Don't Show Print Dialog
            //stiReport1.Print(true, printerSettings);

         //   flowLayoutPanel1.Visible = true;
            /*Amanat_BO.Validating.MyPersianDate(maskedexp_GiveBackDate.Text.Remove(2, 1).Remove(5, 1));
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            int a=pc.GetLeapMonth(1391);
            pc.ToDateTime(1391, 13, 24, 0, 0, 0, 0);*/
        }

        private void maskedexp_GiveBackTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show(e.RejectionHint + "Position " + e.Position);
        }

        private void maskedexp_GiveBackTime_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            
           
              //string[] chunks=  maskedexp_GiveBackTime.Text.Split(':');
              //if (chunks[0].Trim() == string.Empty && chunks[1].Trim() == string.Empty)
              //    maskedexp_GiveBackTime.Text = "00" + "00";
              //else if (chunks[1].Trim() == string.Empty)
              //    maskedexp_GiveBackTime.Text = chunks[0] + "00";
              //if (!e.IsValidInput)
              //{
              //    e.Cancel = true;
              //    MessageBox.Show(e.Message);
              //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form1 ob = new Form1();
            //ob.Show();
          //  radListView1.DataSource = Amanat_BO.GiveAndTakes.GiveAndTake_SelectTahvilnashode().Tables[0];
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
