using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using SearchButtonEdit;

namespace SearchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            searchButtonEdit1.Properties.Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton());
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (searchButtonEdit1.Properties.Buttons.Count != 0)
                searchButtonEdit1.Properties.Buttons.RemoveAt(searchButtonEdit1.Properties.Buttons.Count-1);
        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            searchButtonEdit1.Properties.ButtonSearchIndex = Convert.ToInt32(spinEdit1.Value);
            spinEdit1.Value = searchButtonEdit1.Properties.ButtonSearchIndex;
        }
    }
}
