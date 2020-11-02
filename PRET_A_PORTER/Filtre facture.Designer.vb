<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filtre_facture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Filtre_facture))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnRechCam = New System.Windows.Forms.Button
        Me.txt_prenomp = New System.Windows.Forms.TextBox
        Me.txt_numfact = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAFFICHER = New System.Windows.Forms.Button
        Me.btnFermer = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnRechCam)
        Me.GroupBox1.Controls.Add(Me.txt_prenomp)
        Me.GroupBox1.Controls.Add(Me.txt_numfact)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facture à Imprimer"
        '
        'BtnRechCam
        '
        Me.BtnRechCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRechCam.Image = CType(resources.GetObject("BtnRechCam.Image"), System.Drawing.Image)
        Me.BtnRechCam.Location = New System.Drawing.Point(212, 31)
        Me.BtnRechCam.Name = "BtnRechCam"
        Me.BtnRechCam.Size = New System.Drawing.Size(21, 21)
        Me.BtnRechCam.TabIndex = 236
        Me.BtnRechCam.UseVisualStyleBackColor = True
        '
        'txt_prenomp
        '
        Me.txt_prenomp.Enabled = False
        Me.txt_prenomp.Location = New System.Drawing.Point(97, 75)
        Me.txt_prenomp.Name = "txt_prenomp"
        Me.txt_prenomp.Size = New System.Drawing.Size(213, 20)
        Me.txt_prenomp.TabIndex = 105
        '
        'txt_numfact
        '
        Me.txt_numfact.Enabled = False
        Me.txt_numfact.Location = New System.Drawing.Point(97, 32)
        Me.txt_numfact.Name = "txt_numfact"
        Me.txt_numfact.Size = New System.Drawing.Size(112, 20)
        Me.txt_numfact.TabIndex = 104
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Du Client :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Facture N° :"
        '
        'btnAFFICHER
        '
        Me.btnAFFICHER.Enabled = False
        Me.btnAFFICHER.Image = CType(resources.GetObject("btnAFFICHER.Image"), System.Drawing.Image)
        Me.btnAFFICHER.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAFFICHER.Location = New System.Drawing.Point(285, 169)
        Me.btnAFFICHER.Name = "btnAFFICHER"
        Me.btnAFFICHER.Size = New System.Drawing.Size(96, 23)
        Me.btnAFFICHER.TabIndex = 35
        Me.btnAFFICHER.Text = "&Impression"
        Me.btnAFFICHER.UseVisualStyleBackColor = True
        '
        'btnFermer
        '
        Me.btnFermer.Image = CType(resources.GetObject("btnFermer.Image"), System.Drawing.Image)
        Me.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFermer.Location = New System.Drawing.Point(387, 170)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(79, 23)
        Me.btnFermer.TabIndex = 36
        Me.btnFermer.Text = "&Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'Filtre_facture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(492, 201)
        Me.Controls.Add(Me.btnAFFICHER)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Filtre_facture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtre_facture"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_prenomp As System.Windows.Forms.TextBox
    Friend WithEvents txt_numfact As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnRechCam As System.Windows.Forms.Button
    Friend WithEvents btnAFFICHER As System.Windows.Forms.Button
    Friend WithEvents btnFermer As System.Windows.Forms.Button
End Class
