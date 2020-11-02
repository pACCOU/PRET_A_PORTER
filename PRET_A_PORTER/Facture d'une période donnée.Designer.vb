<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facture_d_une_période_donnée
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facture_d_une_période_donnée))
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.date2 = New System.Windows.Forms.DateTimePicker
        Me.date1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnAFFICHER = New System.Windows.Forms.Button
        Me.btnFermer = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(309, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Date de fin de Période:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Date de début de Période:"
        '
        'date2
        '
        Me.date2.CustomFormat = "yyyy-MM-dd"
        Me.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date2.Location = New System.Drawing.Point(312, 108)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(113, 20)
        Me.date2.TabIndex = 66
        Me.date2.Value = New Date(2015, 1, 5, 0, 0, 0, 0)
        '
        'date1
        '
        Me.date1.CustomFormat = "yyyy-MM-dd"
        Me.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date1.Location = New System.Drawing.Point(61, 108)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(130, 20)
        Me.date1.TabIndex = 65
        Me.date1.Value = New Date(2015, 1, 5, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAFFICHER)
        Me.GroupBox1.Controls.Add(Me.btnFermer)
        Me.GroupBox1.Location = New System.Drawing.Point(119, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 47)
        Me.GroupBox1.TabIndex = 69
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 24)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Liste des factures d'une période donnée"
        '
        'Facture_d_une_période_donnée
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(508, 232)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.date2)
        Me.Controls.Add(Me.date1)
        Me.MaximizeBox = False
        Me.Name = "Facture_d_une_période_donnée"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facture_d_une_période_donnée"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAFFICHER As System.Windows.Forms.Button
    Friend WithEvents btnFermer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
