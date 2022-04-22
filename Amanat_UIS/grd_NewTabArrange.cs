using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;


public class grd_NewTabArrange : DataGridView
{
    public event OtherKeysEventHandler OtherKeys;
    public delegate void OtherKeysEventHandler(System.Windows.Forms.Keys keys);

    protected override bool ProcessCmdKey(ref Message msg, System.Windows.Forms.Keys keyData)
    {
        if (keyData == Keys.Enter)
        {
            if (this.Rows.Count > 6) { return true; }
            if (this.CurrentCell.OwningColumn.Name == "col_codeKala")
            {
                this.CurrentCell = this.Rows[this.CurrentCell.RowIndex].Cells["BaggageCount"];
                if (Convert.ToString(this.Rows[CurrentCell.RowIndex].Cells["col_codeKala"].Value) == "90")
                    this.CurrentCell = this.Rows[this.CurrentCell.RowIndex].Cells["baggageName"];
                else if (Convert.ToString(this.Rows[CurrentCell.RowIndex].Cells["col_codeKala"].Value) == string.Empty)
                {
                    this.Parent.SelectNextControl(this, true, true, true, true);
                    this.CurrentCell = null;
                }
                return true;
            }

            if (this.CurrentCell.OwningColumn.Name == "baggageName")
            {
                this.CurrentCell = this.Rows[this.CurrentCell.RowIndex].Cells["BaggageCount"];
                return true;
            }
            if (this.CurrentCell.OwningColumn.Name == "BaggageCount")
            {
                string codekala = Convert.ToString(this.Rows[CurrentCell.RowIndex].Cells["col_codeKala"].Value);
                if (codekala != "90" && this.Rows.Count-1 > this.CurrentCell.RowIndex)
                    this.CurrentCell = this.Rows[this.CurrentCell.RowIndex + 1].Cells["col_codeKala"];
                else if (codekala == "90")
                    this.CurrentCell = this.Rows[this.CurrentCell.RowIndex].Cells["Price"];
                return true;
            }
            if (this.CurrentCell.OwningColumn.Name == "Price" && this.Rows.Count-1>this.CurrentCell.RowIndex)
            {
                this.CurrentCell = this.Rows[this.CurrentCell.RowIndex + 1].Cells["col_codeKala"];
                return true;
            }
            if (this.CurrentCell.OwningColumn.Name == "count_Sum" && this.Rows.Count-1 > this.CurrentCell.RowIndex)
            {
                this.CurrentCell = this.Rows[this.CurrentCell.RowIndex + 1].Cells["col_codeKala"];
                return true;
            }

            // return base.ProcessTabKey(Keys.Tab);

        }
        return base.ProcessCmdKey(ref msg, keyData);
    }
    protected override void OnEditingControlShowing(DataGridViewEditingControlShowingEventArgs e)
    {
        //And Me.CurrentCell.ColumnIndex = 0 Then
        if (e.Control is TextBox)
        {
            TextBox tb = e.Control as TextBox;
            tb.TextChanged += text_chang;
        }
        base.OnEditingControlShowing(e);
    }

    private void text_chang(object sender, EventArgs e)
    {
    }
}


