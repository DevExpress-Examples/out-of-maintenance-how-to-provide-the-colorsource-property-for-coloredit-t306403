Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace T306403.CustomColorEdit
    Public Class CustomColorEditViewInfo
        Inherits ColorEditViewInfo

        Public Sub New(ByVal item As RepositoryItem)
            MyBase.New(item)
        End Sub
    End Class
End Namespace
