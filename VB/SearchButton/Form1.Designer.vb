Imports Microsoft.VisualBasic
Imports System
Namespace SearchButton
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.label1 = New System.Windows.Forms.Label()
			Me.searchButtonEdit1 = New SearchButtonEdit.SearchButtonEdit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.searchButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(17, 106)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(237, 23)
			Me.simpleButton1.TabIndex = 4
			Me.simpleButton1.Text = "AddButton"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' simpleButton3
			' 
			Me.simpleButton3.Location = New System.Drawing.Point(17, 164)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(237, 23)
			Me.simpleButton3.TabIndex = 6
			Me.simpleButton3.Text = "RemoveButton"
'			Me.simpleButton3.Click += New System.EventHandler(Me.simpleButton3_Click);
			' 
			' spinEdit1
			' 
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(180, 138)
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.spinEdit1.Size = New System.Drawing.Size(74, 20)
			Me.spinEdit1.TabIndex = 9
'			Me.spinEdit1.EditValueChanged += New System.EventHandler(Me.spinEdit1_EditValueChanged);
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(14, 141)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(160, 13)
			Me.label1.TabIndex = 10
			Me.label1.Text = "Properties.ButtonSearchIndex = "
			' 
			' searchButtonEdit1
			' 
			Me.searchButtonEdit1.Location = New System.Drawing.Point(12, 23)
			Me.searchButtonEdit1.Name = "searchButtonEdit1"
			Me.searchButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close)})
			Me.searchButtonEdit1.Properties.ButtonSearchIndex = 0
			Me.searchButtonEdit1.Properties.NullValuePrompt = "Search ..."
			Me.searchButtonEdit1.Size = New System.Drawing.Size(242, 20)
			Me.searchButtonEdit1.TabIndex = 13
'			Me.searchButtonEdit1.Popup += New System.EventHandler(Me.searchButtonEdit1_Popup);
'			Me.searchButtonEdit1.CloseUp += New DevExpress.XtraEditors.Controls.CloseUpEventHandler(Me.searchButtonEdit1_CloseUp);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(266, 206)
			Me.Controls.Add(Me.searchButtonEdit1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.spinEdit1)
			Me.Controls.Add(Me.simpleButton3)
			Me.Controls.Add(Me.simpleButton1)
			Me.Name = "Form1"
			Me.Text = "SearchButton"
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.searchButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton3 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private label1 As System.Windows.Forms.Label
		Private WithEvents searchButtonEdit1 As SearchButtonEdit.SearchButtonEdit

	End Class
End Namespace

