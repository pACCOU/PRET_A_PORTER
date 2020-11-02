<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edition_stock
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrystalReportstock = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportstock
        '
        Me.CrystalReportstock.ActiveViewIndex = -1
        Me.CrystalReportstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportstock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportstock.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportstock.Name = "CrystalReportstock"
        Me.CrystalReportstock.SelectionFormula = ""
        Me.CrystalReportstock.Size = New System.Drawing.Size(559, 391)
        Me.CrystalReportstock.TabIndex = 0
        Me.CrystalReportstock.ViewTimeSelectionFormula = ""
        '
        'edition_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 391)
        Me.Controls.Add(Me.CrystalReportstock)
        Me.Name = "edition_stock"
        Me.Text = "edition_stock"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportstock As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
