using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using System.ComponentModel;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;

namespace SearchButtonEdit
{
    public class SearchButtonEdit : MRUEdit
    {
        #region Service
        public override string EditorTypeName
        { get { return RepositoryItemSearchButtonEdit.EditorName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]

        public new RepositoryItemSearchButtonEdit Properties
        { get { return base.Properties as RepositoryItemSearchButtonEdit; } }

        static SearchButtonEdit()
        {
            RepositoryItemSearchButtonEdit.Register(); 
        }

     #endregion
        public SearchButtonEdit() { }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            BeginInvoke(new MethodInvoker(() => { ShowPopup(); }));
            
        }

        protected override void OnPressButton(EditorButtonObjectInfoArgs buttonInfo)
        {
            base.OnPressButton(buttonInfo);
            if (Properties.Buttons.IndexOf(buttonInfo.Button) == Properties.ButtonSearchIndex)
            { EditValue = null; }
        }

        protected override void OnEditValueChanged()
        {
            if (Properties.IsInCollection(Properties.ButtonSearchIndex))
                Properties.Buttons[Properties.ButtonSearchIndex].Kind = ButtonPredefines.Close;

            if (Properties.IsEditValueNull(EditValue)) Properties.RefreshButton(Properties.ButtonSearchIndex);
            base.OnEditValueChanged();
        }

    }
}
