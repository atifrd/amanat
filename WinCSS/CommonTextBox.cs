using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinCSS
{
    public partial class CommonTextBox : System.Windows.Forms.TextBox
    {
        public CommonTextBox()
        {
            InitializeComponent();
        }

        public CommonTextBox(IContainer container)
        {
           // container.Add(this);

            InitializeComponent();
        }
    }
}
