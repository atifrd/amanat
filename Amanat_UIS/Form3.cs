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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void GRD_GiveAndTakeDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("hey");
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            Amanat_BO.Helper.KeyDownEvent(sender, e);
            MessageBox.Show("Form3_KeyDown");
        }

        private void GRD_GiveAndTakeDetails_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("GRD_GiveAndTakeDetails_CellLeave");
        }

        private void radTileElement1_Click(object sender, EventArgs e)
        {

        }
    }
}
