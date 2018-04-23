using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using System.ComponentModel;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Controls;

namespace SearchButtonEdit
{
    [UserRepositoryItem("Register")]
    public class RepositoryItemSearchButtonEdit : RepositoryItemMRUEdit
    {
        #region Service
        static RepositoryItemSearchButtonEdit() 
        { 
            Register();
        }


        public RepositoryItemSearchButtonEdit() 
        {
            Buttons[ButtonSearchIndex].Kind = ButtonPredefines.Close;
            NullValuePrompt = "Search ...";
            Buttons.CollectionChanged += new CollectionChangeEventHandler(Buttons_CollectionChanged);

        }

        internal const string EditorName = "SearchButtonEdit";

        public static void Register() 
        {
            EditorRegistrationInfo.Default.Editors.Add(
                new EditorClassInfo(EditorName, typeof(SearchButtonEdit),
                typeof(RepositoryItemSearchButtonEdit),
                typeof(MRUEditViewInfo),
                new SearchButtonEditPainter(), true, 
                null, typeof(DevExpress.Accessibility.ButtonEditAccessible)));
        }

        public override string EditorTypeName { 

            get { return EditorName; }

        }
        #endregion

        int _ButtonSearchIndex;

        public int ButtonSearchIndex
        {
            get { return _ButtonSearchIndex; }
            set 
            {

                int _OldButtonSearchIndex = _ButtonSearchIndex;
                _ButtonSearchIndex = value;


                if (IsInCollection(_OldButtonSearchIndex))
                {
                    Buttons[_OldButtonSearchIndex].Reset();
                }
                if (IsInCollection(_ButtonSearchIndex))
                {
                    Buttons[_ButtonSearchIndex].Kind = ButtonPredefines.Close;
                }
                RefreshButton(_OldButtonSearchIndex); 
                RefreshButton(_ButtonSearchIndex);

            }
        }

        public bool IsInCollection(int index)
        {
            return ((Buttons.Count != 0) && (index >= 0) && (index < Buttons.Count));
        }

        void Buttons_CollectionChanged(object sender, CollectionChangeEventArgs e)
        {

            EditorButton bt = (e.Element as EditorButton);
            if (ButtonSearchIndex == Buttons.IndexOf(bt)) bt.Kind = ButtonPredefines.Close;
            RefreshButton(ButtonSearchIndex);
        }

        public void RefreshButton(int index)
        {
            if (IsInCollection(index))
            {
                OnButtons_CollectionChanged(this,
                    new CollectionChangeEventArgs(CollectionChangeAction.Refresh,
                        Buttons[index]));
            }
        }

        public bool IsEditValueNull(object EditValue)
        {
            if (EditValue == null) return true;
            return string.IsNullOrEmpty(EditValue.ToString() as string);
        }

    }
}