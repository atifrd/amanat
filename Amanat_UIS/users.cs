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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }
        private void SetFormStyles()
        {
            customizedTheme customizedThemeObj = new customizedTheme();
            customizedThemeObj.ReportGriedStyle(dataGridViewuSers);
            customizedThemeObj.FormStyle(this);
        }

        private void FillDrp_LoadRoles()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = Amanat_BO.AmanatUsers.Role_SelectAll(); ;
                comboBoxpermissive.DisplayMember = "Desciption";
                comboBoxpermissive.ValueMember = "RoleId";
                comboBoxpermissive.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {
                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                MessageBox.Show("بروز خطا در انجام عملیات ");
            }
        }
        private void users_Load(object sender, EventArgs e)
        {
            SetFormStyles();
            LoadGrid();
            FillDrp_LoadRoles();
        }
        DataSet ds;
        private void LoadGrid()
        {//dataGridViewuSers.Columnsty
            Image myImage;
             ds = Amanat_BO.AmanatUsers.UserSelectAll();
            dataGridViewuSers.DataSource = ds.Tables[0];
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                UTF8Encoding encoder = new UTF8Encoding();
                byte[] pass = encoder.GetBytes(TextBoxPass.Text);


                Amanat_BO.AmanatUsers.User_NewUser(TXT_Family.Text, TXT_UserName.Text, pass, Convert.ToInt16(comboBoxpermissive.SelectedValue));
                LoadGrid();
                
            }
            catch (Exception ex)
            {

                Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
            }
           
        }

        private void users_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
        }

        private void dataGridViewuSers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.ColumnIndex==dataGridViewuSers.Columns["BTN_Delete"].Index)
            {

                try
                {
                    if (MessageBox.Show("آیا از حذف دسترسی کاربر مورد نظر اطمینان دارید؟", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        bool permissive = Convert.ToBoolean(dataGridViewuSers.Rows[e.RowIndex].Cells["permissive"].Value);
                        if (permissive) { MessageBox.Show(" شما مجاز به حذف مدیر سیستم نیستید "); return; }
                        int UserId = Convert.ToInt32(dataGridViewuSers.Rows[e.RowIndex].Cells["UserId"].Value);
                        Amanat_BO.AmanatUsers.AmanatUsers_Delete(UserId);
                        LoadGrid();
                    }
                }
                catch (Exception ex)
                {
                    Amanat_BO.SysLog.WriteInLogFile(ex.ToString());
                  
                }
                
            }
        }

        private void dataGridViewuSers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Image myImage;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ((DataGridViewButtonCell)(dataGridViewuSers.Rows[i].Cells["BTN_Delete"])).Value = "حذف دسترسی";
                if (Convert.ToBoolean(ds.Tables[0].Rows[i]["permissive"]))
                {
                    myImage = global::Amanat_UIS.Properties.Resources.admin_icon3;

                }
                else
                    myImage = global::Amanat_UIS.Properties.Resources.User_icon24;

                dataGridViewuSers.Rows[i].Cells["permissiveImage"].Value = myImage;
            }
        }
    }
}
