<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanelTopEx1 = New TableLayputPanelTop.TableLayoutPanelTopEx()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanelTopEx1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanelTopEx1
        ' 
        TableLayoutPanelTopEx1.AutoSize = True
        TableLayoutPanelTopEx1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanelTopEx1.ButtonText = "Return To Summary Tab"
        TableLayoutPanelTopEx1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        TableLayoutPanelTopEx1.ColumnCount = 2
        TableLayoutPanelTopEx1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanelTopEx1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanelTopEx1.Dock = DockStyle.Fill
        TableLayoutPanelTopEx1.LabelText = ""
        TableLayoutPanelTopEx1.Location = New Point(3, 3)
        TableLayoutPanelTopEx1.Name = "TableLayoutPanelTopEx1"
        TableLayoutPanelTopEx1.RowCount = 1
        TableLayoutPanelTopEx1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanelTopEx1.Size = New Size(794, 37)
        TableLayoutPanelTopEx1.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "Form1"
        Text = "Layout Panel Test"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanelTopEx1 As TableLayputPanelTop.TableLayoutPanelTopEx
End Class
