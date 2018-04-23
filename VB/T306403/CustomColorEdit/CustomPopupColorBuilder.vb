Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraTab
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace T306403.CustomColorEdit
    Public Class CustomPopupColorBuilder
        Inherits PopupColorBuilder

        Public Sub New(ByVal edit As IPopupColorEdit)
            MyBase.New(edit)

        End Sub
        Protected Overrides Sub SetTabPageProperties(ByVal pageIndex As Integer, ByVal shadowForm As PopupBaseForm)
            If pageIndex = 3 Then
                Dim tabPage As XtraTabPage = Me.TabControl.TabPages(pageIndex)
                Dim colorBox As ColorListBox = CreateColorListBox()
                colorBox.HighlightedItemStyle = Properties.HighlightedItemStyle
                Dim colors(((TryCast(Me.Properties, RepositoryItemCustomColorEdit)).ColorSource.Count) - 1) As Object
                For i As Integer = 0 To colors.Length - 1
                    colors(i) = (TryCast(Me.Properties, RepositoryItemCustomColorEdit)).ColorSource(i)
                Next i
                colorBox.Items.AddRange(colors)
                AddHandler colorBox.EnterColor, AddressOf OnEnterColor
                AddHandler colorBox.SelectedIndexChanged, AddressOf OnSelectedIndexChanged
                colorBox.Size = GetBestListBoxSize(colorBox)
                tabPage.PageVisible = (TryCast(Me.Properties, RepositoryItemCustomColorEdit)).ShowMyCustomColors
                colorBox.Dock = DockStyle.Fill
                colorBox.BorderStyle = BorderStyles.NoBorder
                If Owner.LookAndFeel IsNot Nothing Then
                    colorBox.LookAndFeel.Assign(Owner.LookAndFeel)
                End If
                tabPage.Controls.Add(colorBox)
                Return
            End If
            MyBase.SetTabPageProperties(pageIndex, shadowForm)
        End Sub
    End Class
End Namespace
