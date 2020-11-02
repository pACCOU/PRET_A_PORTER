<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_du_Personnel
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
        Me.CrystalReportViewerpersonne = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportViewerpersonne
        '
        Me.CrystalReportViewerpersonne.ActiveViewIndex = -1
        Me.CrystalReportViewerpersonne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerpersonne.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerpersonne.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerpersonne.Name = "CrystalReportViewerpersonne"
        Me.CrystalReportViewerpersonne.SelectionFormula = ""
        Me.CrystalReportViewerpersonne.Size = New System.Drawing.Size(969, 261)
        Me.CrystalReportViewerpersonne.TabIndex = 0
        Me.CrystalReportViewerpersonne.ViewTimeSelectionFormula = ""
        '
        'Liste_du_Personnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 261)
        Me.Controls.Add(Me.CrystalReportViewerpersonne)
        Me.Name = "Liste_du_Personnel"
        Me.Text = "Liste du Personnel"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewerpersonne As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
