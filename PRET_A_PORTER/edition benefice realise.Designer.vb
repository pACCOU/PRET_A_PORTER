﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edition_benefice_realise
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
        Me.CrystalReportbenefice = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportbenefice
        '
        Me.CrystalReportbenefice.ActiveViewIndex = -1
        Me.CrystalReportbenefice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportbenefice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportbenefice.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportbenefice.Name = "CrystalReportbenefice"
        Me.CrystalReportbenefice.SelectionFormula = ""
        Me.CrystalReportbenefice.Size = New System.Drawing.Size(536, 425)
        Me.CrystalReportbenefice.TabIndex = 0
        Me.CrystalReportbenefice.ViewTimeSelectionFormula = ""
        '
        'edition_benefice_realise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 425)
        Me.Controls.Add(Me.CrystalReportbenefice)
        Me.Name = "edition_benefice_realise"
        Me.Text = "edition_benefice_realise"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportbenefice As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
