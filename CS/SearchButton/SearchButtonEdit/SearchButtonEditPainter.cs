using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using System.Drawing;
using SearchButton.Properties;

namespace SearchButtonEdit
{
    public class SearchButtonEditPainter : ButtonEditPainter
    {
        protected override void DrawButton(ButtonEditViewInfo viewInfo, EditorButtonObjectInfoArgs info)
        {
            RepositoryItemSearchButtonEdit ri = (viewInfo.Item as RepositoryItemSearchButtonEdit);

            if ((ri != null) && (ri.ButtonSearchIndex == ri.Buttons.IndexOf(info.Button)) && (ri.IsEditValueNull(viewInfo.EditValue)))
            {
                DrawImage(info);
            }
            else base.DrawButton(viewInfo, info);


        }

        private void DrawImage(EditorButtonObjectInfoArgs info)
        {
            info.Cache.Graphics.FillRectangle(Brushes.White, info.Bounds);

            RectangleF iBounds = new RectangleF(
            ((float)(info.Bounds.Left + 0.1 * info.Bounds.Width)),
            ((float)(info.Bounds.Top + 0.1 * info.Bounds.Height)),
            ((float)(info.Bounds.Width * 0.8)),
            ((float)(info.Bounds.Height * 0.8))
            );

            info.Cache.Graphics.DrawImage(Resources.Search, iBounds);
        }

    }
}
