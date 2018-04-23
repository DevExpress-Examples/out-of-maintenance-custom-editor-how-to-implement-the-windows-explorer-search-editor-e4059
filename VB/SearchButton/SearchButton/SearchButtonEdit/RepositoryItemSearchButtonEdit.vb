Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports System.ComponentModel
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Controls

Namespace SearchButtonEdit
	<UserRepositoryItem("Register")> _
	Public Class RepositoryItemSearchButtonEdit
		Inherits RepositoryItemMRUEdit
		#Region "Service"
		Shared Sub New()
			Register()
		End Sub


		Public Sub New()
			Buttons(ButtonSearchIndex).Kind = ButtonPredefines.Close
			NullValuePrompt = "Search ..."
			AddHandler Buttons.CollectionChanged, AddressOf Buttons_CollectionChanged

		End Sub

		Friend Const EditorName As String = "SearchButtonEdit"

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName,
                                                                           GetType(SearchButtonEdit),
                                                                           GetType(RepositoryItemSearchButtonEdit),
                                                                           GetType(MRUEditViewInfo),
                                                                           New SearchButtonEditPainter(),
                                                                           True,
                                                                           EditImageIndexes.MRUEdit,
                                                                           GetType(DevExpress.Accessibility.ButtonEditAccessible)))
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String

			Get
				Return EditorName
			End Get

		End Property
		#End Region

		Private _ButtonSearchIndex As Integer

		Public Property ButtonSearchIndex() As Integer
			Get
				Return _ButtonSearchIndex
			End Get
			Set(ByVal value As Integer)

				Dim _OldButtonSearchIndex As Integer = _ButtonSearchIndex
				_ButtonSearchIndex = value


				If IsInCollection(_OldButtonSearchIndex) Then
					Buttons(_OldButtonSearchIndex).Reset()
				End If
				If IsInCollection(_ButtonSearchIndex) Then
					Buttons(_ButtonSearchIndex).Kind = ButtonPredefines.Close
				End If
				RefreshButton(_OldButtonSearchIndex)
				RefreshButton(_ButtonSearchIndex)

			End Set
		End Property

		Public Function IsInCollection(ByVal index As Integer) As Boolean
			Return ((Buttons.Count <> 0) AndAlso (index >= 0) AndAlso (index < Buttons.Count))
		End Function

		Private Sub Buttons_CollectionChanged(ByVal sender As Object, ByVal e As CollectionChangeEventArgs)

			Dim bt As EditorButton = (TryCast(e.Element, EditorButton))
			If ButtonSearchIndex = Buttons.IndexOf(bt) Then
				bt.Kind = ButtonPredefines.Close
			End If
			RefreshButton(ButtonSearchIndex)
		End Sub

		Public Sub RefreshButton(ByVal index As Integer)
			If IsInCollection(index) Then
				OnButtons_CollectionChanged(Me, New CollectionChangeEventArgs(CollectionChangeAction.Refresh, Buttons(index)))
			End If
		End Sub

		Public Function IsEditValueNull(ByVal EditValue As Object) As Boolean
			If EditValue Is Nothing Then
				Return True
			End If
			Return String.IsNullOrEmpty(TryCast(EditValue.ToString(), String))
		End Function

	End Class
End Namespace