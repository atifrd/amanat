using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinCSS
{
    public partial class SaveButton : Button
    {
        public SaveButton()
        {
            InitializeComponent();
        }

        private void SaveButton_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void SaveButton_MouseDown(object sender, MouseEventArgs e)
        {
            //Button mybtn = (Button)sender;
            //mybtn.BackgroundImage = global::WinCSS.Properties.Resources._08;
            //mybtn.Text = "ghjg";
        }

        private void SaveButton_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_MouseHover(object sender, EventArgs e)
        {
            Button mybtn = (Button)sender;
            mybtn.BackgroundImage = global::WinCSS.Properties.Resources._09;
            //mybtn.Text = "ghjg";
        }

       
    }
}
