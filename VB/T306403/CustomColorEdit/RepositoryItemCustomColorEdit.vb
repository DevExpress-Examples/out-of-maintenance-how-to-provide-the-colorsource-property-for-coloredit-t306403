Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace T306403.CustomColorEdit
    <UserRepositoryItem("RegisterCustomColorEdit")> _
    Public Class RepositoryItemCustomColorEdit
        Inherits RepositoryItemColorEdit

        Shared Sub New()
            RegisterCustomColorEdit()
        End Sub
        Private _ColorSource As IList(Of Color)

        Private tabName_Renamed As String


        Public Const CustomEditName As String = "CustomColorEdit"

        Public Sub New()
            ShowMyCustomColors = True
        End Sub
        Public Property ColorSource() As IList(Of Color)
            Get
                Return _ColorSource
            End Get
            Set(ByVal value As IList(Of Color))
                _ColorSource = value
            End Set
        End Property
        Public Property TabName() As String
            Get
                If String.IsNullOrEmpty(tabName_Renamed) Then
                    Return "CustomTab"
                Else
                    Return tabName_Renamed
                End If
            End Get
            Set(ByVal value As String)
                tabName_Renamed = value
            End Set
        End Property
        Public Property ShowMyCustomColors() As Boolean

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return CustomEditName
            End Get
        End Property
        Public Shared Sub RegisterCustomColorEdit()
            Dim img As Image = Nothing
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomColorEdit), GetType(RepositoryItemCustomColorEdit), GetType(CustomColorEditViewInfo), New CustomColorEditPainter(), True, img))
        End Sub

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            BeginUpdate()
            Try
                MyBase.Assign(item)
                Dim source As RepositoryItemCustomColorEdit = TryCast(item, RepositoryItemCustomColorEdit)
                If source Is Nothing Then
                    Return
                End If
                Me.ColorSource = source.ColorSource
                Me.ShowMyCustomColors = source.ShowMyCustomColors
                Me.TabName = source.TabName
                '
            Finally
                EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
