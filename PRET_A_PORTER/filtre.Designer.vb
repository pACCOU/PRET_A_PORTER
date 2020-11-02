<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filtre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(filtre))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnAFFICHER = New System.Windows.Forms.Button
        Me.btnFermer = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.date2 = New System.Windows.Forms.DateTimePicker
        Me.date1 = New System.Windows.Forms.DateTimePicker
        Me.GRILLE = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Textmedecin = New System.Windows.Forms.TextBox
        Me.txt_statut = New System.Windows.Forms.TextBox
        Me.txt_prenommed = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_nommed = New System.Windows.Forms.TextBox
        Me.cbx_nummed = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.l_idmedecin = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.GRILLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnAFFICHER)
        Me.GroupBox1.Controls.Add(Me.btnFermer)
        Me.GroupBox1.Location = New System.Drawing.Point(167, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 47)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(26, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "&Afficher"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAFFICHER
        '
        Me.btnAFFICHER.Image = CType(resources.GetObject("btnAFFICHER.Image"), System.Drawing.Image)
        Me.btnAFFICHER.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAFFICHER.Location = New System.Drawing.Point(129, 15)
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
        Me.btnFermer.Location = New System.Drawing.Point(231, 16)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(79, 23)
        Me.btnFermer.TabIndex = 34
        Me.btnFermer.Text = "&Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(405, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Date de fin de Période:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(155, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Date de début de Période:"
        '
        'date2
        '
        Me.date2.CustomFormat = "yyyy-MM-dd"
        Me.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date2.Location = New System.Drawing.Point(408, 135)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(113, 20)
        Me.date2.TabIndex = 62
        Me.date2.Value = New Date(2015, 1, 5, 0, 0, 0, 0)
        '
        'date1
        '
        Me.date1.CustomFormat = "yyyy-MM-dd"
        Me.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date1.Location = New System.Drawing.Point(157, 135)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(130, 20)
        Me.date1.TabIndex = 61
        Me.date1.Value = New Date(2015, 1, 5, 0, 0, 0, 0)
        '
        'GRILLE
        '
        Me.GRILLE.AllowUserToAddRows = False
        Me.GRILLE.AllowUserToDeleteRows = False
        Me.GRILLE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GRILLE.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRILLE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.GRILLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRILLE.DefaultCellStyle = DataGridViewCellStyle6
        Me.GRILLE.Location = New System.Drawing.Point(11, 211)
        Me.GRILLE.Name = "GRILLE"
        Me.GRILLE.ReadOnly = True
        Me.GRILLE.Size = New System.Drawing.Size(747, 190)
        Me.GRILLE.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(17, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(745, 16)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "LISTE DES ACTES PRATIQUES PAR UN MEDECIN PENDANT UNE PERIODE DONNEE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Médecin"
        '
        'Textmedecin
        '
        Me.Textmedecin.Enabled = False
        Me.Textmedecin.Location = New System.Drawing.Point(95, 68)
        Me.Textmedecin.Name = "Textmedecin"
        Me.Textmedecin.Size = New System.Drawing.Size(103, 20)
        Me.Textmedecin.TabIndex = 105
        '
        'txt_statut
        '
        Me.txt_statut.Enabled = False
        Me.txt_statut.Location = New System.Drawing.Point(641, 138)
        Me.txt_statut.Name = "txt_statut"
        Me.txt_statut.Size = New System.Drawing.Size(98, 20)
        Me.txt_statut.TabIndex = 104
        Me.txt_statut.Visible = False
        '
        'txt_prenommed
        '
        Me.txt_prenommed.Enabled = False
        Me.txt_prenommed.Location = New System.Drawing.Point(557, 70)
        Me.txt_prenommed.Name = "txt_prenommed"
        Me.txt_prenommed.Size = New System.Drawing.Size(185, 20)
        Me.txt_prenommed.TabIndex = 103
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(506, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Prénom :"
        '
        'txt_nommed
        '
        Me.txt_nommed.Enabled = False
        Me.txt_nommed.Location = New System.Drawing.Point(285, 67)
        Me.txt_nommed.Name = "txt_nommed"
        Me.txt_nommed.Size = New System.Drawing.Size(186, 20)
        Me.txt_nommed.TabIndex = 101
        '
        'cbx_nummed
        '
        Me.cbx_nummed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_nummed.FormattingEnabled = True
        Me.cbx_nummed.Location = New System.Drawing.Point(95, 67)
        Me.cbx_nummed.Name = "cbx_nummed"
        Me.cbx_nummed.Size = New System.Drawing.Size(121, 21)
        Me.cbx_nummed.TabIndex = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Nom :"
        '
        'l_idmedecin
        '
        Me.l_idmedecin.AutoSize = True
        Me.l_idmedecin.Location = New System.Drawing.Point(598, 183)
        Me.l_idmedecin.Name = "l_idmedecin"
        Me.l_idmedecin.Size = New System.Drawing.Size(0, 13)
        Me.l_idmedecin.TabIndex = 106
        Me.l_idmedecin.Visible = False
        '
        'filtre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(787, 408)
        Me.Controls.Add(Me.l_idmedecin)
        Me.Controls.Add(Me.Textmedecin)
        Me.Controls.Add(Me.txt_statut)
        Me.Controls.Add(Me.txt_prenommed)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_nommed)
        Me.Controls.Add(Me.cbx_nummed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.date2)
        Me.Controls.Add(Me.date1)
        Me.Controls.Add(Me.GRILLE)
        Me.Controls.Add(Me.Label2)
        Me.Name = "filtre"
        Me.Text = "filtre"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GRILLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAFFICHER As System.Windows.Forms.Button
    Friend WithEvents btnFermer As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GRILLE As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Textmedecin As System.Windows.Forms.TextBox
    Friend WithEvents txt_statut As System.Windows.Forms.TextBox
    Friend WithEvents txt_prenommed As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_nommed As System.Windows.Forms.TextBox
    Friend WithEvents cbx_nummed As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents l_idmedecin As System.Windows.Forms.Label
End Class
