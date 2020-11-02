<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filtre_benefice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Filtre_benefice))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnAFFICHER = New System.Windows.Forms.Button
        Me.btnFermer = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.date2 = New System.Windows.Forms.DateTimePicker
        Me.date1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 24)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Bénéfice d'une période donnée"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAFFICHER)
        Me.GroupBox1.Controls.Add(Me.btnFermer)
        Me.GroupBox1.Location = New System.Drawing.Point(133, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 47)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        '
        'btnAFFICHER
        '
        Me.btnAFFICHER.Image = CType(resources.GetObject("btnAFFICHER.Image"), System.Drawing.Image)
        Me.btnAFFICHER.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAFFICHER.Location = New System.Drawing.Point(26, 16)
        Me.btnAFFICHER.Name = "btnAFFICHER"
        Me.btnAFFICHER.Size = New System.Drawing.Size(96, 23)
        Me.btnAFFICHER.TabIndex = 32
        Me.btnAFFICHER.Text = "&Impression"
        Me.btnAFFICHER.UseVisualStyleBackColor = True
        '
        'btnFermer
        '
        Me.btnFermer.Image = CType(resources.GetObject("btnFermer.Image"), System.Drawing.Image)
        Me.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFermer.Location = New System.Drawing.Point(154, 16)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(79, 23)
        Me.btnFermer.TabIndex = 34
        Me.btnFermer.Text = "&Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(323, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Date de fin de Période:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Date de début de Période:"
        '
        'date2
        '
        Me.date2.CustomFormat = "yyyy-MM-dd"
        Me.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date2.Location = New System.Drawing.Point(326, 114)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(113, 20)
        Me.date2.TabIndex = 72
        Me.date2.Value = New Date(2015, 1, 5, 0, 0, 0, 0)
        '
        'date1
        '
        Me.date1.CustomFormat = "yyyy-MM-dd"
        Me.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date1.Location = New System.Drawing.Point(75, 114)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(130, 20)
        Me.date1.TabIndex = 71
        Me.date1.Value = New Date(2015, 1, 5, 0, 0, 0, 0)
        '
        'Filtre_benefice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(503, 240)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.date2)
        Me.Controls.Add(Me.date1)
        Me.MaximizeBox = False
        Me.Name = "Filtre_benefice"
        Me.Opacity = 0.8
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtre_benefice"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAFFICHER As System.Windows.Forms.Button
    Friend WithEvents btnFermer As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents date1 As System.Windows.Forms.DateTimePicker
End Class
