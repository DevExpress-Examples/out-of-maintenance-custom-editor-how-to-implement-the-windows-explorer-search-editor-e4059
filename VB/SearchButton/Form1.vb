Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports SearchButtonEdit

Namespace SearchButton
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			searchButtonEdit1.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton())
		End Sub

		Private Sub simpleButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton3.Click
			If searchButtonEdit1.Properties.Buttons.Count <> 0 Then
				searchButtonEdit1.Properties.Buttons.RemoveAt(searchButtonEdit1.Properties.Buttons.Count-1)
			End If
		End Sub

		Private Sub spinEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinEdit1.EditValueChanged
			searchButtonEdit1.Properties.ButtonSearchIndex = Convert.ToInt32(spinEdit1.Value)
			spinEdit1.Value = searchButtonEdit1.Properties.ButtonSearchIndex
		End Sub


		Private Sub searchButtonEdit1_Popup(ByVal sender As Object, ByVal e As EventArgs) Handles searchButtonEdit1.Popup

		End Sub

		Private Sub searchButtonEdit1_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles searchButtonEdit1.CloseUp

		End Sub
	End Class
End Namespace
