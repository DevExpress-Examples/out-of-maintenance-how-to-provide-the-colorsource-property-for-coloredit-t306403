Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraTab
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace T306403.CustomColorEdit
    Public Class CustomColorEditPopupForm
        Inherits PopupColorEditForm

        Public Sub New(ByVal ownerEdit As CustomColorEdit)
            MyBase.New(ownerEdit)
        End Sub
        Protected Overrides Function CreateTabControl() As PopupColorEditForm.ColorEditTabControl
            Dim control As ColorEditTabControl = MyBase.CreateTabControl()
            If (TryCast(Me.Properties, RepositoryItemCustomColorEdit)).ColorSource IsNot Nothing AndAlso (TryCast(Me.Properties, RepositoryItemCustomColorEdit)).ColorSource.Count <> 0 Then
                Dim page As New XtraTabPage()
                page.Text = (TryCast(Me.Properties, RepositoryItemCustomColorEdit)).TabName
                control.TabPages.Add(page)
            End If
            Return control
        End Function
        Protected Overrides Function CreatePopupColorEditBuilder() As PopupColorBuilder
            Return New CustomPopupColorBuilder(Me)
        End Function
    End Class
End Namespace
