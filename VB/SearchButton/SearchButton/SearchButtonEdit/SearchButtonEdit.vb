Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Controls
Imports System.Windows.Forms

Namespace SearchButtonEdit
	Public Class SearchButtonEdit
		Inherits MRUEdit
		#Region "Service"
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemSearchButtonEdit.EditorName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemSearchButtonEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemSearchButtonEdit)
			End Get
		End Property

		Shared Sub New()
			RepositoryItemSearchButtonEdit.Register()
		End Sub

	 #End Region
		Public Sub New()
		End Sub

		Protected Overrides Sub OnEnter(ByVal e As EventArgs)
			MyBase.OnEnter(e)
			BeginInvoke(New MethodInvoker(Function() AnonymousMethod1()))

		End Sub
		
		Private Function AnonymousMethod1() As Boolean
			ShowPopup()
			Return True
		End Function

		Protected Overrides Sub OnPressButton(ByVal buttonInfo As EditorButtonObjectInfoArgs)
			MyBase.OnPressButton(buttonInfo)
			If Properties.Buttons.IndexOf(buttonInfo.Button) = Properties.ButtonSearchIndex Then
				EditValue = Nothing
			End If
		End Sub

		Protected Overrides Sub OnEditValueChanged()
			If Properties.IsInCollection(Properties.ButtonSearchIndex) Then
				Properties.Buttons(Properties.ButtonSearchIndex).Kind = ButtonPredefines.Close
			End If

			If Properties.IsEditValueNull(EditValue) Then
				Properties.RefreshButton(Properties.ButtonSearchIndex)
			End If
			MyBase.OnEditValueChanged()
		End Sub

	End Class
End Namespace
