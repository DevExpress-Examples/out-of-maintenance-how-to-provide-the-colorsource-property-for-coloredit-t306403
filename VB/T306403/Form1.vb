Imports DevExpress.Utils.Win
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraTab
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace T306403
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Shared Function CreateDataTable() As DataTable
            Dim table As New DataTable()
            table.Columns.Add("Column1")
            table.Columns.Add("Column2")
            table.Columns.Add("Column3", GetType(Color))
            table.Rows.Add("One", "Two", Color.Red)
            table.Rows.Add("One", "Two", Color.Blue)
            table.Rows.Add("One", "Two", Color.Green)
            Return table
        End Function

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.customColorEdit11.Properties.ShowSystemColors = False
            Me.customColorEdit11.Properties.ShowCustomColors = False
            Me.customColorEdit11.Properties.ShowWebColors = False
            Me.customColorEdit11.Properties.ColorSource = New System.Collections.Generic.List(Of Color)() From {Color.Red, Color.Green, Color.Yellow}
            Me.repositoryItemCustomColorEdit11.ShowSystemColors = False
            Me.repositoryItemCustomColorEdit11.ShowCustomColors = False
            Me.repositoryItemCustomColorEdit11.ShowWebColors = False
            Me.repositoryItemCustomColorEdit11.ColorSource = New System.Collections.Generic.List(Of Color)() From {Color.Red, Color.Green}
            Me.gridControl1.DataSource = CreateDataTable()
        End Sub
    End Class
End Namespace
