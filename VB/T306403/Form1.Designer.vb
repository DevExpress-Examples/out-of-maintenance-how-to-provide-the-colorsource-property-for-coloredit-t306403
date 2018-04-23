Namespace T306403
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
            Me.customColorEdit11 = New T306403.CustomColorEdit.CustomColorEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemCustomColorEdit11 = New T306403.CustomColorEdit.RepositoryItemCustomColorEdit()
            DirectCast(Me.customColorEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemCustomColorEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' customColorEdit11
            ' 
            Me.customColorEdit11.EditValue = System.Drawing.Color.Empty
            Me.customColorEdit11.Location = New System.Drawing.Point(12, 218)
            Me.customColorEdit11.Name = "customColorEdit11"
            Me.customColorEdit11.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.customColorEdit11.Properties.ColorSource = Nothing
            Me.customColorEdit11.Properties.ShowMyCustomColors = True
            Me.customColorEdit11.Properties.TabName = "CustomTab"
            Me.customColorEdit11.Size = New System.Drawing.Size(400, 20)
            Me.customColorEdit11.TabIndex = 2
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Location = New System.Drawing.Point(12, 12)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCustomColorEdit11})
            Me.gridControl1.Size = New System.Drawing.Size(400, 200)
            Me.gridControl1.TabIndex = 3
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.FieldName = "Column1"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            ' 
            ' gridColumn2
            ' 
            Me.gridColumn2.FieldName = "Column2"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            ' 
            ' gridColumn3
            ' 
            Me.gridColumn3.ColumnEdit = Me.repositoryItemCustomColorEdit11
            Me.gridColumn3.FieldName = "Column3"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            ' 
            ' repositoryItemCustomColorEdit11
            ' 
            Me.repositoryItemCustomColorEdit11.AutoHeight = False
            Me.repositoryItemCustomColorEdit11.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemCustomColorEdit11.ColorSource = Nothing
            Me.repositoryItemCustomColorEdit11.Name = "repositoryItemCustomColorEdit11"
            Me.repositoryItemCustomColorEdit11.ShowMyCustomColors = True
            Me.repositoryItemCustomColorEdit11.TabName = "CustomTab"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(428, 260)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.customColorEdit11)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.customColorEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemCustomColorEdit11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private customColorEdit11 As CustomColorEdit.CustomColorEdit
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemCustomColorEdit11 As CustomColorEdit.RepositoryItemCustomColorEdit


    End Class
End Namespace

