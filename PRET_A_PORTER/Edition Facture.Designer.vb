<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edition_Facture
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
        Me.CrystalReportFacture = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportFacture
        '
        Me.CrystalReportFacture.ActiveViewIndex = -1
        Me.CrystalReportFacture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportFacture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportFacture.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportFacture.Name = "CrystalReportFacture"
        Me.CrystalReportFacture.SelectionFormula = ""
        Me.CrystalReportFacture.Size = New System.Drawing.Size(599, 361)
        Me.CrystalReportFacture.TabIndex = 0
        Me.CrystalReportFacture.ViewTimeSelectionFormula = ""
        '
        'Edition_Facture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 361)
        Me.Controls.Add(Me.CrystalReportFacture)
        Me.Name = "Edition_Facture"
        Me.Text = "Edition_Facture"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportFacture As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
