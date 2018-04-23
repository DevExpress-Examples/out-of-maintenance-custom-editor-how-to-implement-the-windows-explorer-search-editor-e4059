Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports System.Drawing


Namespace SearchButtonEdit
	Public Class SearchButtonEditPainter
		Inherits ButtonEditPainter
		Protected Overrides Sub DrawButton(ByVal viewInfo As ButtonEditViewInfo, ByVal info As EditorButtonObjectInfoArgs)
			Dim ri As RepositoryItemSearchButtonEdit = (TryCast(viewInfo.Item, RepositoryItemSearchButtonEdit))

			If (ri IsNot Nothing) AndAlso (ri.ButtonSearchIndex = ri.Buttons.IndexOf(info.Button)) AndAlso (ri.IsEditValueNull(viewInfo.EditValue)) Then
				DrawImage(info)
			Else
				MyBase.DrawButton(viewInfo, info)
			End If


		End Sub

		Private Sub DrawImage(ByVal info As EditorButtonObjectInfoArgs)
			info.Cache.Graphics.FillRectangle(Brushes.White, info.Bounds)

			Dim iBounds As New RectangleF((CSng(info.Bounds.Left + 0.1 * info.Bounds.Width)), (CSng(info.Bounds.Top + 0.1 * info.Bounds.Height)), (CSng(info.Bounds.Width * 0.8)), (CSng(info.Bounds.Height * 0.8)))

			info.Cache.Graphics.DrawImage(Resources.Search, iBounds)
		End Sub

	End Class
End Namespace
