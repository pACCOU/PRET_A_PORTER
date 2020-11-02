<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_des_articles_et_prix
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
        Me.CrystalReportViewerarticle = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportViewerarticle
        '
        Me.CrystalReportViewerarticle.ActiveViewIndex = -1
        Me.CrystalReportViewerarticle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerarticle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerarticle.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerarticle.Name = "CrystalReportViewerarticle"
        Me.CrystalReportViewerarticle.SelectionFormula = ""
        Me.CrystalReportViewerarticle.Size = New System.Drawing.Size(284, 261)
        Me.CrystalReportViewerarticle.TabIndex = 0
        Me.CrystalReportViewerarticle.ViewTimeSelectionFormula = ""
        '
        'Liste_des_articles_et_prix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.CrystalReportViewerarticle)
        Me.Name = "Liste_des_articles_et_prix"
        Me.Text = "Liste des articles et prix"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewerarticle As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
