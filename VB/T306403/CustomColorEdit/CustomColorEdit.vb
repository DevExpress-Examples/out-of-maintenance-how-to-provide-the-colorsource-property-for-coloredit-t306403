Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text

Namespace T306403.CustomColorEdit
    <ToolboxItem(True)> _
    Public Class CustomColorEdit
        Inherits ColorEdit

        Shared Sub New()
            RepositoryItemCustomColorEdit.RegisterCustomColorEdit()
        End Sub
        Protected Overrides ReadOnly Property IsAllTabsHidden() As Boolean
            Get
                Return (Not Properties.ShowCustomColors) AndAlso (Not Properties.ShowWebColors) AndAlso (Not Properties.ShowSystemColors) AndAlso Not Properties.ShowMyCustomColors
            End Get
        End Property
        Public Sub New()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Shadows ReadOnly Property Properties() As RepositoryItemCustomColorEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomColorEdit)
            End Get
        End Property
        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return RepositoryItemCustomColorEdit.CustomEditName
            End Get
        End Property
        Protected Overrides Function CreatePopupForm() As PopupBaseForm
            Return New CustomColorEditPopupForm(Me)
        End Function
    End Class
End Namespace
