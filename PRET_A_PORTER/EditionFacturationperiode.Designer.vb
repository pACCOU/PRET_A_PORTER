<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditionFacturationperiode
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
        Me.CrystalReportperiode = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportperiode
        '
        Me.CrystalReportperiode.ActiveViewIndex = -1
        Me.CrystalReportperiode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportperiode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportperiode.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportperiode.Name = "CrystalReportperiode"
        Me.CrystalReportperiode.SelectionFormula = ""
        Me.CrystalReportperiode.Size = New System.Drawing.Size(284, 262)
        Me.CrystalReportperiode.TabIndex = 0
        Me.CrystalReportperiode.ViewTimeSelectionFormula = ""
        '
        'EditionFacturationperiode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.CrystalReportperiode)
        Me.Name = "EditionFacturationperiode"
        Me.Text = "EditionFacturationperiode"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportperiode As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
