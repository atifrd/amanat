using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Amanat_UIS
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            bool login = false;
            if (new Login().ShowDialog() != DialogResult.OK)
                MessageBox.Show("نام کاربری و کلمه عبور را اشتباه وارد کرده اید");
            else
            {
                login = true;
                
            }
            if (login)
            {
               
               Application.EnableVisualStyles();
                Application.Run(new Form1());
            }


            
            
        }
    }
}
